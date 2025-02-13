Imports System.Net.Security

Public Class FrmAgenda
    Private Const Item = 0
    Private Const Descricao = 1
    Private Const DataHorario = 2
    Private Const Tipo = 3
    Private Const Complemento = 4
    Private Const Status = 5
    Private Sub AtualizarToolStripButton_Click(sender As Object, e As EventArgs) Handles AtualizarToolStripButton.Click
        Try
            If ValidarForm() Then
                If LblItem.Text = "" Then
                    InserirTarefa()
                    Arquivo.SalvarLista(ListView1, conArquivoCSV)
                Else
                    AlterarTarefa()
                    Arquivo.SalvarLista(ListView1, conArquivoCSV)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro no btnSalvar: " & ex.Message, vbCritical, Sistema)
        Finally
            LimparFormAgenda()
            TxtDescricao.Focus()
        End Try
    End Sub

    Private Sub AlterarTarefa()
        With ListView1
            Dim row = 0
            For Each i As ListViewItem In ListView1.Items
                If i.SubItems(Item).Text = LblItem.Text Then
                    '**********Atualizar colunas************
                    i.SubItems(Descricao).Text = TxtDescricao.Text
                    i.SubItems(DataHorario).Text = MskDataHorario.Text
                    i.SubItems(Tipo).Text = CmbTipo.Text
                    i.SubItems(Complemento).Text = TxtComplemento.Text
                End If
            Next i
        End With
    End Sub

    Private Sub LimparFormAgenda()
        LblItem.Text = ""
        TxtDescricao.Clear()
        MskDataHorario.Clear()
        CmbTipo.SelectedIndex = -1
        TxtComplemento.Clear()
        LblStatus.Text = ""
    End Sub
    Private Sub InserirTarefa()
        With ListView1
            Dim it = 1
            If .Items.Count > 0 Then
                it = .Items(.Items.Count - 1).SubItems(0).Text + 1
            End If
            .Items.Add(New ListViewItem({it, TxtDescricao.Text, MskDataHorario.Text, CmbTipo.Text, TxtComplemento.Text, "1 - Pendente"}))
        End With
    End Sub

    Private Function ValidarForm() As Boolean
        Try
            Dim result As Boolean

            If TxtDescricao.Text = "" Then
                MsgBox("A descrição é obrigatória.", vbCritical, Sistema)
                TxtDescricao.Focus()
                result = False
            ElseIf Not IsDate(MskDataHorario.Text) Then
                MsgBox("Data/horário inválido.", vbCritical, Sistema)
                MskDataHorario.Focus()
                result = False
            ElseIf CmbTipo.Text = "" Then
                MsgBox("Selecione o tipo.", vbCritical, Sistema)
                CmbTipo.Focus()
                result = False
            ElseIf TxtComplemento.Text = "" Then
                MsgBox("O complemento é obrigatório.", vbCritical, Sistema)
                TxtComplemento.Focus()
                result = False
            Else
                result = True
            End If
            Return result

        Catch ex As Exception
            MsgBox("Erro no ValidarForm: " & ex.Message, vbCritical, Sistema)
        Finally
        End Try
    End Function

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        SelecionarTarefa()
    End Sub
    Private Sub SelecionarTarefa()
        With ListView1
            Dim row = .Items.IndexOf(.SelectedItems(0))
            LblItem.Text = .Items(row).SubItems(Item).Text
            TxtDescricao.Text = .Items(row).SubItems(Descricao).Text
            MskDataHorario.Text = .Items(row).SubItems(DataHorario).Text
            CmbTipo.Text = .Items(row).SubItems(Tipo).Text
            TxtComplemento.Text = .Items(row).SubItems(Complemento).Text
            LblStatus.Text = .Items(row).SubItems(Status).Text
        End With
    End Sub

    Private Sub FrmAgenda_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Arquivo.CarregarLista(ListView1, conArquivoCSV)
        Timer1.Enabled = True
    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        LimparFormAgenda()
        TxtDescricao.Focus()
    End Sub

    Private Sub ExcluirToolStripButton1_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton1.Click
        If LblItem.Text <> "" Then
            Dim resposta = MessageBox.Show("Deseja excluir o item " & LblItem.Text & "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resposta = DialogResult.Yes Then
                With ListView1
                    Dim row = .Items.IndexOf(.SelectedItems(0))
                    .Items.RemoveAt(row)
                End With
                Arquivo.SalvarLista(ListView1, conArquivoCSV)
                LimparFormAgenda()
                TxtDescricao.Focus()
            End If
        End If
    End Sub
    Private Sub ChecarTarefas()
        With ListView1
            If .Items.Count > 0 Then
                Dim dataHoraAgendada As DateTime
                Dim dataHoraAtual = DateTime.Now

                For Each row As ListViewItem In ListView1.Items
                    dataHoraAgendada = Convert.ToDateTime(row.SubItems(DataHorario).Text)
                    If (dataHoraAgendada <= dataHoraAtual) Then
                        If row.SubItems(Status).Text.Substring(0, 1) = "1" Then
                            If row.SubItems(Tipo).Text.Substring(0, 1) = "1" Then
                                Dim msg = row.SubItems(Descricao).Text & vbNewLine & row.SubItems(DataHorario).Text & vbNewLine & row.SubItems(Complemento).Text
                                NotifyIcon1.ShowBalloonTip(1000, "Tarefa Agendada", msg, ToolTipIcon.Info)
                                NotifyIcon1.BalloonTipTitle = "Tarefas Agendadas"
                                row.SubItems(Status).Text = "2 - Realizado"
                                Arquivo.SalvarLista(ListView1, conArquivoCSV) 'arquivoCSV
                                Exit For
                            Else
                                Arquivo.Abrir(row.SubItems(Complemento).Text)
                                row.SubItems(Status).Text = "2 - Realizado"
                                Arquivo.SalvarLista(ListView1, conArquivoCSV) 'arquivoCSV
                            End If
                        End If
                    End If
                Next
            End If
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ChecarTarefas()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        NotifyIcon1.Visible = True
        Me.Show()
    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Close()
    End Sub
End Class