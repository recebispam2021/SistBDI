Imports System.Data.OleDb
Public Class CartaoMovAltConsulta
    Dim _click As Boolean = False

    Private Sub CartaoMovAltConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub CartaoMovAltConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub
    Private Sub CartaoMovConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        If pAdministrador Then
            btnExcluir.Enabled = True
        End If
        chkSel.Checked = False
        DeletarAutomatico()
        MostrarUsuarios()
        ConfigurarGrade()
    End Sub

    Private Sub DeletarAutomatico()
        Dim DataInicial, DataFinal As Date
        Dim DataF As String
        DataInicial = Today
        DataFinal = DateAdd(DateInterval.Day, -180, DataInicial)
        'Data limite para apagar registros
        DataF = (Format(DataFinal, "#dd/MM/yyyy#"))
        Dim sql = ("Delete from CartaoMov where dpagto is not null and Vencimento <" & DataF & " ")
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Falha Del: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                DataGridView1.Columns("ID").Visible = True
                .Columns("ID").Width = 30
                .Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Nome").HeaderText = "Nome"
                .Columns("Nome").Width = 70

                .Columns("Sobrenome").Visible = False
                .Columns("Sobrenome").HeaderText = "Sobrenome"
                .Columns("Sobrenome").Width = 150

                .Columns("CPF").Visible = False
                .Columns("CPF").HeaderText = "CPF"
                .Columns("CPF").Width = 90
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Cartao").HeaderText = "Cartão"
                .Columns("Cartao").Width = 70
                .Columns("Cartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("NCartao").Visible = False
                .Columns("NCartao").HeaderText = "Número"
                .Columns("NCartao").Width = 90
                .Columns("NCartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("FluxoCaixa").HeaderText = "Caixa"
                .Columns("FluxoCaixa").Width = 70
                .Columns("FluxoCaixa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Historico").HeaderText = "Histórico"
                .Columns("Historico").Width = 100
                .Columns("Historico").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Valor").HeaderText = "Valor"
                .Columns("Valor").DefaultCellStyle.Format = "C"
                .Columns("Valor").Width = 80
                .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Vencimento").HeaderText = "Vencimento"
                .Columns("Vencimento").Width = 90
                .Columns("Vencimento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("ValorPago").HeaderText = "ValorPago"
                .Columns("ValorPago").DefaultCellStyle.Format = "C"
                .Columns("ValorPago").Width = 80
                .Columns("ValorPago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("DPagto").HeaderText = "DPagto"
                .Columns("DPagto").Width = 90
                .Columns("DPagto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Consolidada").HeaderText = "Cons."
                .Columns("Consolidada").Width = 50
                .Columns("Consolidada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        Catch ex As Exception
            MsgBox("Falha1: C" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub MostrarUsuarios()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "select ID, Nome, Sobrenome, CPF, Cartao, NCartao, FluxoCaixa, Historico, Valor, Vencimento, ValorPago, DPagto, Consolidada FROM CartaoMov where Consolidada='E' And DateDiff('m',now(),Vencimento)>='0' order by Vencimento"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Falha2: C" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub DataPag()
        Try
            Dim DPag As Date
            Dim DTex As Date = "22/03/2023"
            Dim DExc As String
            For Each col As DataGridViewRow In DataGridView1.Rows
                DPag = col.Cells(12).Value
            Next
            'Acrescenta mais 3 meses apartir da data 22/03/2023
            DExc = DateAdd(DateInterval.Month, 3, DPag)
            If DTex >= DExc Then
                'verdadeiro
            Else
                'falso
            End If
        Catch ix As InvalidCastException
            MsgBox("Erro:" & Chr(13) & "verifique se existe uma data inválida no sistema!", vbExclamation, Sistema)
        Catch ex As Exception
            MsgBox("Erro no DataPag: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub BtnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resultado As String
        Try
            With DataGridView1
                If .Item(0, .CurrentRow.Index).Value() = False Then
                    MsgBox("Selecione uma ou mais linhas para excluir!", vbExclamation, Sistema)
                    Exit Sub
                End If
            End With

            resultado = MsgBox("Tem certeza que deseja excluir este(s) registro(s)?", vbYesNo, "Exclusão de registro")
            If resultado = vbYes Then
                MsgBox("registro(s) excluido!", vbExclamation, Sistema)
            Else
                MsgBox("registro(s) não excluido!", vbExclamation, Sistema)
                Exit Sub
            End If

            Dim row As New DataGridViewRow()
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                row = DataGridView1.Rows(i)

                If Convert.ToBoolean(row.Cells(0).Value) Then
                    Dim id As Integer = Convert.ToInt16(row.Cells(1).Value)
                    DeletaLinhaDoGrid(id)
                    i -= 1
                    DataGridView1.Rows.Remove(row)
                End If
                i += 1
                Label1.Text = ""
                Label2.Text = "0"
            End While
            'Colocar um código para reconhecer que não existe mais registro
        Catch ex As Exception
            MsgBox("Não há registro para exluir!", vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub DeletaLinhaDoGrid(ByVal id As Integer)
        Dim sql = ("Delete from CartaoMov where id =" & id)
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using

        Catch ex As Exception
            MsgBox("Falha Del: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub SomarLinhas()
        Label2.Text = Label2.Text + 1
        Label1.Text = ("Linha(s) " + Label2.Text & " selecionada(s) ")
    End Sub
    Private Sub DiminuirLinhas()
        Label2.Text = Label2.Text - 1
        Label1.Text = ("Linha(s) " + Label2.Text & " selecionada(s) ")
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            'Vê se a culuna clicada é a que tem o checkbox
            With DataGridView1
                If .CurrentCell.ColumnIndex = 0 Then
                    'Vê se a linha está marcada true
                    If .Item(0, .CurrentRow.Index).Value() Then
                        .Item(0, .CurrentRow.Index).Value() = False
                        DiminuirLinhas()
                    Else
                        .Item(0, .CurrentRow.Index).Value() = True
                        SomarLinhas()
                        If DataGridView1.RowCount.ToString = Label2.Text Then
                            chkSel.Checked = True
                        End If
                    End If
                End If
                If DataGridView1.RowCount.ToString <> Label2.Text Then
                    chkSel.Checked = False
                End If
            End With
            'Linha de código desnecessário
            For Each dr As DataGridViewRow In DataGridView1.Rows
                If dr.Cells(0).Value IsNot Nothing Then
                    ''Na primeira célula Cells[0] foi adicionado o checkbox
                    'Label1.Text = ("Linha(s) " + dr.Index.ToString & " selecionada(s) ")
                Else
                    'Label1.Text = ("Linha(s) " + "" & " selecionada(s) ")
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha :" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Try
            With DataGridView1
                pIDCanM = .Rows(.CurrentCell.RowIndex).Cells("ID").Value
            End With

        Catch ex As Exception
            MsgBox("Falha :" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Try
            If _click = False Then
                pIDCanM = -1
            Else
                pIDCanM = 0
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("Falha :" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub ChkSel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSel.CheckedChanged
        Try
            If Label2.Text = 0 Or Label2.Text = DataGridView1.RowCount.ToString Then
                'Selecionar todos os itens da coluna do checkbox
                If chkSel.Checked = True Then
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        row.Cells(0).Value = True
                        Label1.Text = ("Linha(s) " + DataGridView1.RowCount.ToString & " selecionada(s) ")
                    Next
                Else
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        row.Cells(0).Value = False
                        Label1.Text = ("Linha(s) " + Label2.Text & " selecionada(s) ")
                    Next
                End If

                If chkSel.Checked = False Then
                    Label1.Text = ("Linha(s) " & "0" & " selecionada(s) ")
                    Label2.Text = "0"
                End If
            ElseIf chkSel.Checked = True And Label2.Text <> 0 Then
                For Each row As DataGridViewRow In DataGridView1.Rows
                    row.Cells(0).Value = True
                    Label1.Text = ("Linha(s) " + DataGridView1.RowCount.ToString & " selecionada(s) ")
                Next
            ElseIf chkSel.Checked = False And Label2.Text <> 0 Then
                For Each row As DataGridViewRow In DataGridView1.Rows
                    row.Cells(0).Value = False
                    Label1.Text = ("Linha(s) " & "0" & " selecionada(s) ")
                    Label2.Text = "0"
                Next
            End If

        Catch ex As Exception
            MsgBox("Falha :" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Dim Id As Integer
        Dim i As Integer
        i = DataGridView1.Rows.Count
        If i > 0 Then
            With DataGridView1
                Id = .Rows(.CurrentCell.RowIndex).Cells("ID").Value
            End With
            RestaurarRegistro(Id)
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells(0).Value = False
                chkSel.Checked = False
                Label1.Text = ("Linha(s) " & "0" & " selecionada(s) ")
                Label2.Text = "0"
            Next
        Else
            MsgBox("Não há registro para exluir!", vbExclamation, Sistema)
        End If
    End Sub
    Private Sub RestaurarRegistro(ByVal Id As Integer)
        Try
            Dim Sql = ("UPDATE CartaoMov SET Consolidada=@Consolidada WHERE id=" & Id)
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Using cmd = New OleDbCommand(Sql, cn)
                    cmd.Parameters.AddWithValue("@Consolidada", "S")
                    cmd.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
            MsgBox("Registro restaurado com sucesso!", vbExclamation, Sistema)
        Catch ix As NullReferenceException
            MsgBox("Falha: Alt" & ix.Message, vbExclamation, Sistema)
        Catch ex As Exception
            MsgBox("Erro no SalvarUsuario: " & ex.Message, vbExclamation, Sistema)
        Finally
            MostrarUsuarios()
        End Try
    End Sub
End Class