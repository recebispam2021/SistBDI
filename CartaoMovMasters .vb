Imports System.Data.OleDb
Imports ProjSistBDIMax.ConfigCartao

Public Class CartaoMovMasters
    'Instanciar a classe de Conexão
    Dim conexao As New OleDbConnection()
    'Instanciar a classe ConfigCartao
    Dim cartao As New InfCartao
    Dim caixa As New Caixa

    Dim _click As Boolean = False
    Dim Data1 As Date = Today
    Dim Data2 As Date = DateAdd(DateInterval.Month, 0, Data1)
    Dim MesAtual As String
    Dim Data3 As String
    Private Sub CartaoMovConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        MesAtual = Format(Data2, "MMMM")
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub CartaoMovConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub
    Private Sub CartaoMovConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        Try
            If pAdministrador Then
                BtnResgatar.Visible = True
            Else
                BtnResgatar.Visible = False
            End If
            CbCampos.SelectedIndex = -1
            txtProcurar.Clear()
            txtProcurar2.Clear()
            txtProcurar3.Clear()
            txtProcurar.Visible = False
            txtProcurar2.Visible = False
            txtProcurar3.Visible = False
            lblLegenda.Visible = False
            lblLegenda2.Visible = False
            lblLegenda3.Visible = False
            'Rotina para apresentar as faturas
            MostrarTodosItens()
            ConfigurarGrade()
        Catch ax As NullReferenceException
            Exit Sub
        Catch ex As Exception
            MsgBox("F: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                .Columns("ID_CartaoMov").Visible = True
                .Columns("ID_CartaoMov").HeaderText = "ID" 'Posição 0
                .Columns("ID_CartaoMov").Width = 30
                .Columns("ID_CartaoMov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DataRegistro").Visible = True
                .Columns("DataRegistro").HeaderText = "Data" 'Posição 1
                .Columns("DataRegistro").Width = 90
                .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Nome").Visible = True
                .Columns("Nome").HeaderText = "Nome" 'Posição 2
                .Columns("Nome").Width = 70
                .Columns("Nome").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("CPF").Visible = True
                .Columns("CPF").HeaderText = "CPF" 'Posição 3
                .Columns("CPF").Width = 90
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Cartao").HeaderText = "Cartão" 'Posição 4
                .Columns("Cartao").Width = 70
                .Columns("Cartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("NCartao").Visible = False
                .Columns("NCartao").HeaderText = "Número" 'Posição 5
                .Columns("NCartao").Width = 90
                .Columns("NCartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("FluxoCaixa").HeaderText = "Caixa" 'Posição 6
                .Columns("FluxoCaixa").Width = 60
                .Columns("FluxoCaixa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Historico").Visible = True
                .Columns("Historico").HeaderText = "Histórico" 'Posição 7
                .Columns("Historico").Width = 100
                .Columns("Historico").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("LCategorias").Visible = True
                .Columns("LCategorias").HeaderText = "Categorias" 'Posição 8
                .Columns("LCategorias").Width = 100
                .Columns("LCategorias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Valor").HeaderText = "Valor Gasto" 'Posição 9
                .Columns("Valor").DefaultCellStyle.Format = "C"
                .Columns("Valor").Width = 90
                .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Prazo").Visible = True
                .Columns("Prazo").HeaderText = "Prazo" 'Posição 10
                .Columns("Prazo").Width = 80
                .Columns("Prazo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Parcela").Visible = True
                .Columns("Parcela").HeaderText = "Parcela" 'Posição 11
                .Columns("Parcela").Width = 60
                .Columns("Parcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Vencimento").HeaderText = "Vencimento" 'Posição 12
                .Columns("Vencimento").Width = 90
                .Columns("Vencimento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Consolidada").Visible = True
                .Columns("Consolidada").HeaderText = "Cons." 'Posição 13
                .Columns("Consolidada").Width = 50
                .Columns("Consolidada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With
        Catch ax As NullReferenceException
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
<<<<<<< Updated upstream
    Private Sub Filtragem()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "select ID, DataRegistro, Nome, Sobrenome, CPF, Cartao, NCartao, FluxoCaixa, Historico, Vencimento, DPagto, ValorPago, iif(DPagto is not null or DPagto <> '','Pago','Não Pago') as Situação, Consolidada  FROM CartaoMov where FluxoCaixa = 'Entrada' And Consolidada = 'S' order by year(Vencimento) DESC, month(Vencimento) DESC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        With DataGridView1
                            .Columns("ValorPago").HeaderText = "Valor Pago"
                            .Columns("ValorPago").DefaultCellStyle.Format = "C"
                            .Columns("ValorPago").Width = 90
                            .Columns("ValorPago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        End With
                        'Calculo para o valor total dos pagamentos realizados
                        Pagamentos()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
        MsgBox("Falha Filtragem " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
=======
>>>>>>> Stashed changes

    Private Sub MostrarTodosItens()
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
<<<<<<< Updated upstream
                Dim sql = "select ID, DataRegistro, Nome, Sobrenome, CPF, Cartao, NCartao, FluxoCaixa, Historico, Valor, Vencimento, DPagto, Consolidada, iif(DPagto is not null or DPagto <> '','Não Pago','Aguardando') as Situação FROM CartaoMov where FluxoCaixa = 'Saída' and Consolidada= 'N' order by year(Vencimento) DESC, month(Vencimento) DESC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        With DataGridView1
                            .Columns("Valor").HeaderText = "Valor Gasto" 'Posição 9
                            .Columns("Valor").DefaultCellStyle.Format = "C"
                            .Columns("Valor").Width = 90
                            .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        End With
                        'Calculo para o valor total dos pagamentos não realizados
                        NaoPagos()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Falha LimparFiltro: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub MostrarTodosUsuarios()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "select ID, DataRegistro, Nome, Sobrenome, CPF, Cartao, NCartao, FluxoCaixa, Historico, Valor, Prazo, Parcela, Vencimento, DPagto, ValorPago, Consolidada from CartaoMov"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        TotalGeral() 'Definir depois
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Falha MostrarTodosUsuarios" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub MostrarProxFatura()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "select ID, DataRegistro, Nome, Sobrenome, CPF, Cartao, NCartao, FluxoCaixa, Historico, LCategorias, Valor, Prazo, Parcela, Vencimento, DPagto, ValorPago, Consolidada from CartaoMov where month(Vencimento)=" & Month(Today.AddMonths(1)) & " order by year(Vencimento), month(Vencimento), day(Vencimento), Cartao Asc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        TotalGeral() 'Definir depois
                    End Using
                End Using
                cn.Close()
            End Using

        Catch ex As Exception
        MsgBox("Falha MostrarProxFatura " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub MostrarItensVencidos()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "select ID, DataRegistro, Nome, Sobrenome, CPF, Cartao, NCartao, FluxoCaixa, Historico, LCategorias, Valor, Prazo, Parcela, Vencimento, DPagto, ValorPago, Consolidada from CartaoMov where Consolidada NOT IN ('E') order by year(Vencimento), month(Vencimento), day(Vencimento), Cartao Asc"
=======
                Dim sql = "select c.ID_CartaoMov, c.DataRegistro, p.Nome, c.CPF, c.Cartao, c.NCartao, c.FluxoCaixa, c.Historico, c.LCategorias, c.Valor, c.Prazo, c.Parcela, c.Vencimento, c.Consolidada from CartaoMov c inner join Pessoal p on p.CPF = c.CPF where Consolidada NOT IN ('E') order by year(Vencimento) DESC, month(Vencimento) DESC, day(Vencimento) DESC, Consolidada DESC"
>>>>>>> Stashed changes
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        'Calculo para o valor total da dívida do cartão
                        TotalGeral()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha MostrarItensVencidos " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub MostrarItensApagados()
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Dim sql = "select c.ID_CartaoMov, c.DataRegistro, p.Nome, c.CPF, c.Cartao, c.NCartao, c.FluxoCaixa, c.Historico, c.LCategorias, c.Valor, c.Prazo, c.Parcela, c.Vencimento, c.Consolidada from CartaoMov c inner join Pessoal p on p.CPF = c.CPF where Consolidada IN ('E') order by year(Vencimento) DESC, month(Vencimento) DESC, day(Vencimento) DESC, Consolidada DESC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        'Calculo para o valor total da dívida do cartão
                        TotalGeral()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha MostrarItensVencidos " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub BtnResgatar_Click(sender As Object, e As EventArgs) Handles BtnResgatar.Click
        MostrarItensApagados()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Try
            With DataGridView1
                pIDCanM = .Rows(.CurrentCell.RowIndex).Cells("ID_CartaoMov").Value
            End With
        Catch ex As Exception
            pIDCanM = 0
            MsgBox("Não existe item para ser apagado!", vbCritical, "Erro")
            DataGridView1.Enabled = False
        End Try
    End Sub

    Private Sub BtnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Try
            If lblIdCartaoMov.Text <> "" Then
                SalvarUsuario(lblIdCartaoMov.Text)
            Else
                Exit Sub
            End If

        Catch ix As NullReferenceException
            MsgBox("Falha: Alt" & ix.Message, vbExclamation, Sistema)
        Catch ex As Exception
            MsgBox("Erro no btnAlterar: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub SalvarUsuario(ByVal Id As Integer)
        Dim cn = New OleDbConnection(conn)
        Try
            For Each col As DataGridViewRow In DataGridView1.Rows
                If col.Cells(0).Value = Id And col.Cells(13).Value = "E" Then
                    Dim Sql = ("UPDATE CartaoMov Set Consolidada=@Consolidada where ID_CartaoMov=" & Id)
                    Using cn
                        cn.Open()
                        Using cmd = New OleDbCommand(Sql, cn)
                            cmd.Parameters.AddWithValue("@Consolidada", "S")
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    MsgBox("Cadastro Resgatado com sucesso!", vbExclamation, Sistema)
                    Exit For
                Else
                    Dim Sql = ("UPDATE CartaoMov SET Historico=@Historico, Valor=@Valor, Vencimento=@Vencimento WHERE ID_CartaoMov=" & Id)
                    Using cn
                        cn.Open()
                        Using cmd = New OleDbCommand(Sql, cn)
                            cmd.Parameters.AddWithValue("@Historico", txtHistorico.Text)
                            cmd.Parameters.AddWithValue("@Valor", txtValor.Text)
                            mskVencimento.TextMaskFormat = MaskFormat.IncludeLiterals
                            cmd.Parameters.AddWithValue("@Vencimento", mskVencimento.Text)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    MsgBox("Cadastro Alterado com sucesso!", vbExclamation, Sistema)
                    Exit For
                End If
            Next
        Catch ix As NullReferenceException
            MsgBox("Falha: Alt" & ix.Message, vbExclamation, Sistema)
        Catch ex As Exception
            MsgBox("Erro no SalvarUsuario: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
            PLimpar()
            MostrarTodosItens()
        End Try
    End Sub
    Private Sub PLimpar()
        lblIdCartaoMov.Text = String.Empty
        For Each controle As Control In Me.Controls
            If TypeOf controle Is TextBox Then
                Dim txt As TextBox = TryCast(controle, TextBox)
                txt.Text = String.Empty
                txt.ForeColor = Color.Black
            End If
            If TypeOf controle Is MaskedTextBox Then
                Dim msk As MaskedTextBox = TryCast(controle, MaskedTextBox)
                msk.Clear()
            End If
        Next
        txtValor.Text = "0.00"
        DataGridView1.Rows(0).Selected = False
        DataGridView1.ClearSelection()
    End Sub
    Private Sub BtnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        pIDCanM = 0
        'Acesso ao sistema
        Using frm = New FrmPrincipal
<<<<<<< Updated upstream
            CartaoFluxograma.MdiParent = FrmPrincipal
            CartaoFluxograma.Show()
=======
            FaturaCartao.MdiParent = FrmPrincipal
            FaturaCartao.Show()
>>>>>>> Stashed changes
        End Using
        Me.Close()
    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        If _click = False Then
            pIDCanM = -1
        Else
            pIDCanM = 0
        End If
        Me.Close()
    End Sub

    Private Function Getlivros(ByVal filtro As String) As DataTable

        Dim sql = ""
        If CbCampos.Text = "Cartão" Then
            sql = "select c.ID_CartaoMov, c.DataRegistro, p.Nome, c.CPF, c.Cartao, c.NCartao, c.FluxoCaixa, c.Historico, c.LCategorias, c.Valor, c.Prazo, c.Parcela, c.Vencimento, c.Consolidada from CartaoMov c inner join Pessoal p on p.CPF=c.CPF where c.Consolidada and c.Cartao LIKE  '%" & txtProcurar.Text & "%' and format(c.Vencimento,'MMMM') LIKE  '%" & txtProcurar2.Text & "%' ORDER BY c.ID_CartaoMov DESC"

        ElseIf CbCampos.Text = "Nome" Then
            sql = "select c.ID_CartaoMov, c.DataRegistro, p.Nome, c.CPF, c.Cartao, c.NCartao, c.FluxoCaixa, c.Historico, c.LCategorias, c.Valor, c.Prazo, c.Parcela, c.Vencimento, c.Consolidada from CartaoMov c inner join Pessoal p on p.CPF=c.CPF where c.Consolidada and p.Nome LIKE  '%" & txtProcurar.Text & "%' and format(c.Vencimento,'MMMM') LIKE  '%" & txtProcurar2.Text & "%' ORDER BY c.ID_CartaoMov DESC"
        ElseIf CbCampos.Text = "Grupo" Then
            sql = "select c.ID_CartaoMov, c.DataRegistro, p.Nome, c.CPF, c.Cartao, c.NCartao, c.FluxoCaixa, c.Historico, c.LCategorias, c.Valor, c.Prazo, c.Parcela, c.Vencimento, c.Consolidada from CartaoMov c inner join Pessoal p on p.CPF=c.CPF where c.Consolidada and p.Nome LIKE  '%" & txtProcurar.Text & "%' and c.Cartao LIKE  '%" & txtProcurar2.Text & "%' and format(c.Vencimento,'MMMM') LIKE  '%" & txtProcurar3.Text & "%' ORDER BY c.ID_CartaoMov DESC"
        End If
        Dim cn = New OleDbConnection(conn)
        Dim dt As New DataTable
        Try
            Using cn
                cn.Open()
                Using da = New OleDbDataAdapter(sql, cn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha no Getlivros", vbInformation, Sistema)
        Finally
            cn.Close()
        End Try
        Return dt
    End Function

    Private Sub CbCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCampos.SelectedIndexChanged

        If CbCampos.Text = "Cartão" Then
            lblLegenda.Visible = True
            lblLegenda.Text = "Digite o cartão procurado!"
            lblLegenda2.Visible = True
            lblLegenda2.Text = "Digite o mês procurado!"
            txtProcurar.Visible = True
            txtProcurar.Clear()
            txtProcurar.Focus()
            txtProcurar2.Visible = True
            txtProcurar2.Clear()
            txtProcurar3.Visible = False
            txtProcurar3.Clear()
            lblLegenda3.Visible = False
        ElseIf CbCampos.Text = "Nome" Then
            lblLegenda.Visible = True
            lblLegenda.Text = "Digite o nome procurado!"
            lblLegenda2.Visible = True
            lblLegenda2.Text = "Digite o mês procurado!"
            txtProcurar.Visible = True
            txtProcurar.Clear()
            txtProcurar.Focus()
            txtProcurar2.Visible = True
            txtProcurar2.Clear()
            txtProcurar3.Visible = False
            txtProcurar3.Clear()
            lblLegenda3.Visible = False
        ElseIf CbCampos.Text = "Grupo" Then
            lblLegenda.Visible = True
            lblLegenda.Text = "Digite o nome procurado!"

            lblLegenda2.Visible = True
            lblLegenda2.Text = "Digite o cartão procurado!"

            lblLegenda3.Visible = True
            lblLegenda3.Text = "Digite o mês procurado!"

            txtProcurar.Visible = True
            txtProcurar.Clear()
            txtProcurar.Focus()

            txtProcurar2.Visible = True
            txtProcurar2.Clear()

            txtProcurar3.Visible = True
            txtProcurar3.Clear()
        End If
        DataGridView1.ClearSelection()
        PLimpar()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If CbCampos.Text = Nothing Then
            Exit Sub
        End If
        DataGridView1.DataSource = Getlivros(CbCampos.Text)
        If DataGridView1.Rows.Count > 0 Then
            ConfigurarGrade()
        End If
        Somar()
    End Sub

    Private Sub Somar()
        Dim valor(2) As Decimal
        For Each col As DataGridViewRow In DataGridView1.Rows
            valor(0) += col.Cells(9).Value
            valor(1) += 0 'col.Cells(15).Value
        Next
        valor(2) = valor(0) - valor(1)
        lblTotal.Text = "Total de crédito: " & valor(2).ToString("C")
    End Sub

    Private Sub TotalGeral()
        Try
            Dim valorG As Decimal = 0
            Dim Saldo As Decimal
            For Each col As DataGridViewRow In DataGridView1.Rows
                valorG += col.Cells(9).Value
            Next
            Saldo = valorG
            lblTotal.Text = "Saldo de: " & Saldo.ToString("C")
            DataGridView1.Rows(0).Selected = False
            DataGridView1.ClearSelection()
        Catch ax As ArgumentOutOfRangeException
        Exit Try
        Catch ex As Exception
        MsgBox("Falha TotalGeral: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub BtnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        If Not lblIdCartaoMov.Text = Nothing Then
            Dim id As Integer
            id = lblIdCartaoMov.Text
            ApagarRegistros(id) 'Código não excluir o registro, apenas esconde
            'ExcluirRegistros(id) 'Código excluir o registro completamente
        Else
            MsgBox("Você precisa selecionar um registro", vbInformation, "Exclusão!")
            Exit Sub
        End If
    End Sub

    Private Sub ApagarRegistros(ByVal id As Integer)
        Dim resultado As String
        Try
            For Each col As DataGridViewRow In DataGridView1.Rows
                If col.Cells(0).Value = id And col.Cells(13).Value = "N" Then
                    PLimpar()
                    MsgBox("O registro não foi excluido!", vbExclamation, Sistema)
                    Exit Sub
                End If
            Next
            resultado = MsgBox("Você esta preste a excluir o registro!" & vbNewLine & "Tem certeza que deseja proceguir?", vbYesNo + vbCritical, "Exclusão de registro")
            If resultado = vbYes Then
                'Atualiza o status do cartão
                Dim Sql = ("UPDATE CartaoMov Set Consolidada=@Consolidada where Consolidada='S' and id_CartaoMov=" & id)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(Sql, cn)
                        cmd.Parameters.AddWithValue("@Consolidada", "E")
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
                MsgBox("Registro excluido com sucesso!", vbExclamation, Sistema)

<<<<<<< Updated upstream
                For Each col As DataGridViewRow In DataGridView1.Rows
                    If col.Cells(0).Value = id And col.Cells(16).Value = "N" Then
                        Exit Sub
                        'Else
                    End If
                Next

                '********* NÃO ALTERAR SE FOR PAGAMENTOS **********

                caixa.CalculoDel()
                'Atualiza o saldo de limite do cartão
                sql = ("UPDATE Cartao Set Saldo=@Saldo where ID=" & cartao.IdCartao)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Saldo", caixa.SaldoCartao + caixa.ValorDel)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
=======
>>>>>>> Stashed changes
            Else
                MsgBox("O registro não foi excluido!", vbExclamation, Sistema)
            End If
            PLimpar()
            MostrarTodosItens()
        Catch ex As Exception
            MsgBox("Falha ExcluirRegistros: " & ex.Message, vbExclamation, Sistema)
        Finally

        End Try
    End Sub

    Private Sub PleDados()
        Dim dr As OleDbDataReader = Nothing
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                '************** FAZER PESQUISA POR N° DO CARTÃO E CPF ******************
                Dim sql As String = "SELECT * FROM Cartao WHERE NCartao='" & cartao.NuCartao & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    cartao.IdCartao = dr.Item("ID_Cartao")
                    caixa.Divida = dr.Item("Divida")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha PleDados(): " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MostrarUsuario(pIDCanM)
        PleDados()
    End Sub
    Private Sub MostrarUsuario(ByVal id As Long)
        Dim sql = "Select c.ID_CartaoMov, p.Nome, c.DataRegistro, c.CPF, c.Cartao, c.NCartao, c.fluxocaixa, c.Historico, c.Valor, c.Prazo, c.Parcela, c.Vencimento, c.Consolidada from CartaoMov c inner join Pessoal p on p.cpf = c.cpf where c.ID_CartaoMov=" & id
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@ID_CartaoMov", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblIdCartaoMov.Text = dr("ID_CartaoMov")
                                txtNome.Text = dr("Nome")
                                txtCartao.Text = dr("Cartao")
                                cartao.NuCartao = CLng(dr("NCartao"))
                                txtHistorico.Text = dr("Historico")
                                txtValor.Text = FormatCurrency(dr("Valor"))
                                caixa.ValorDel = txtValor.Text
                                mskVencimento.Text = dr("Vencimento")
                            End If
                        End If
                    End Using
                End Using
            End Using
            If txtValor.Text > 0 Then
                txtValor.ForeColor = Color.Green
            ElseIf txtValor.Text < 0 Then
                txtValor.ForeColor = Color.Red
            Else
                txtValor.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox("Falha4b: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CartaoMovMasters_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '*******************Código que mostra mensagem de aviso de vencimento***********************
        With DataGridView1
            Dim dataHoraAgendada As DateTime
            Dim dataHoraAtual = DateTime.Now
            Dim Sql = ""
            For Each col As DataGridViewRow In DataGridView1.Rows
                dataHoraAgendada = Convert.ToDateTime(col.Cells(12).Value)
                If (dataHoraAgendada <= dataHoraAtual) And col.Cells(6).Value <> "Entrada" And col.Cells(13).Value = "N" Then
                    Sql = "UPDATE CartaoMov SET Vencimento=@Vencimento, Consolidada=@Consolidada WHERE FluxoCaixa='Saída' and ID_CartaoMov=" & col.Cells(0).Value
                    Using cn = New OleDbConnection(conn)
                        cn.Open()
                        Using cmd = New OleDbCommand(Sql, cn)
                            cmd.Parameters.AddWithValue("@Vencimento", Format(dataHoraAgendada, "Short Date"))
                            cmd.Parameters.AddWithValue("@Consolidada", "S")
                            cmd.ExecuteNonQuery()
                            MsgBox("O item " & col.Cells(7).Value & " da fatura, foi consolidado!")
                        End Using
                        cn.Close()
                    End Using
                End If
            Next
        End With
        MostrarTodosItens() 'Retorno de valor
    End Sub

<<<<<<< Updated upstream
=======
    Public Sub ChecarPagto()
        '*******************Código que mostra mensagem de aviso de vencimento**********************
        Dim ProcRegistro As Boolean
        Dim Sql = "Select * from CartaoMov Where exists (SELECT * FROM CartaoMov where Vencimento < now() and Consolidada ='N')"
        Try
            Dim cn As New OleDbConnection(conn)
            cn.Open()
            Dim cmd1 As New OleDbCommand(Sql, cn)
            ProcRegistro = (cmd1.ExecuteScalar)
            cn.Close()
            If ProcRegistro = True Then
                NotifyIcon1.ShowBalloonTip(1000, "Pagamento de Faturas", "Existe(m) fatura(s) em aberto!", ToolTipIcon.Info)
                NotifyIcon1.BalloonTipTitle = Sistema
            End If
        Catch ex As Exception
            MsgBox("Falha ChecarPagto: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

>>>>>>> Stashed changes
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        PLimpar()
        MostrarTodosItens()
    End Sub
<<<<<<< Updated upstream
=======

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        NotifyIcon1.Visible = True
        Me.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Close()
    End Sub

>>>>>>> Stashed changes
End Class