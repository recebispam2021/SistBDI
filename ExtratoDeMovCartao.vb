Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports ProjSistBDIMax.ConfigCartao
Public Class ExtratoDeMovCartao
    'Instanciar a classe ConfigCartao
    Dim cartao As New InfCartao
    Dim caixa As New Caixa
    Private Sub MostrarQtdCartao()
        Dim dr As OleDbDataReader = Nothing
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "select count(*) as Qtd from (SELECT Cartao as Item FROM cartaomov group by Cartao) a"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    cartao.QtdCartao = dr.Item("Qtd")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha MostrarQtdCartao: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub MostrarDadosCartao()
        Dim Sql As String = "SELECT cm.Cartao, c.Limite as Limite, sum(cm.Valor) as Divida FROM Cartao c inner join CartaoMov cm on c.id_Cartao=cm.id_Cartao group by cm.Cartao, c.Limite"
        Dim cn As New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader
                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Ls As New ListViewItem("", 1)
                            With Ls
                                cartao.Limite += FormatCurrency(Dr.Item("Limite"))
                                cartao.Divida += FormatCurrency(Dr.Item("Divida"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using
            If cartao.QtdCartao >= 1 Then
                cartao.Percentual()
            End If
        Catch ex As Exception
            MsgBox("Falha ao MostrarAbertura: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub MostrarSaida()
        Dim dr As OleDbDataReader = Nothing
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "SELECT Sum(Valor) as Valor FROM CartaoMov where FluxoCaixa='Saída'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    caixa.TotParc = dr.Item("Valor")
                End If
            End Using
        Catch ax As InvalidCastException
            Exit Try
        Catch ex As Exception
            MsgBox("Falha MostrarSaida: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub MostrarEntrada()
        Dim dr As OleDbDataReader = Nothing
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "SELECT Sum(Valor) as Valor FROM CartaoMov where FluxoCaixa='Entrada'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    caixa.ValorPago = dr.Item("Valor")
                End If
            End Using
        Catch ax As InvalidCastException
            Exit Try
        Catch ex As Exception
            MsgBox("Falha MostrarEntrada: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub MostrarTodasMovimentacao()
        Dim Sql As String = "SELECT cm.ID_CartaoMov,cm.ID_Cartao,cm.DataRegistro,p.Nome,cm.CPF,cm.Cartao,cm.NCartao,cm.FluxoCaixa,cm.Historico,cm.LCategorias,cm.Valor,cm.Prazo,cm.Parcela,cm.Vencimento,cm.Consolidada FROM CartaoMov cm INNER JOIN Pessoal p ON p.CPF=cm.CPF order by cm.Vencimento,cm.DataRegistro"
        Dim cn As New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader
                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("ID", 0, System.Windows.Forms.HorizontalAlignment.Left) '0
                            .Columns.Add("IDCar", 0, System.Windows.Forms.HorizontalAlignment.Left) '1
                            .Columns.Add("Registro", 80, System.Windows.Forms.HorizontalAlignment.Center) '2
                            .Columns.Add("Nome", 70, System.Windows.Forms.HorizontalAlignment.Left) '3
                            .Columns.Add("CPF", 90, System.Windows.Forms.HorizontalAlignment.Left) '4
                            .Columns.Add("Cartao", 70, System.Windows.Forms.HorizontalAlignment.Left) '5
                            .Columns.Add("Número", 110, System.Windows.Forms.HorizontalAlignment.Left) '6
                            .Columns.Add("Caixa", 70, System.Windows.Forms.HorizontalAlignment.Left) '7
                            .Columns.Add("Historico", 90, System.Windows.Forms.HorizontalAlignment.Left) '8
                            .Columns.Add("Categorias", 90, System.Windows.Forms.HorizontalAlignment.Left) '9
                            .Columns.Add("Valor", 70, System.Windows.Forms.HorizontalAlignment.Right) '10
                            .Columns.Add("Prazo", 80, System.Windows.Forms.HorizontalAlignment.Center) '11
                            .Columns.Add("Parcelas", 60, System.Windows.Forms.HorizontalAlignment.Center) '12
                            .Columns.Add("Vencimento", 80, System.Windows.Forms.HorizontalAlignment.Center) '13
                            .Columns.Add("Cons", 40, System.Windows.Forms.HorizontalAlignment.Center) '14
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = (Dr.Item("ID_CartaoMov"))
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("ID_Cartao"))
                                .SubItems.Add(Dr.Item("DataRegistro"))
                                .SubItems.Add(Dr.Item("Nome"))
                                .SubItems.Add(Dr.Item("CPF"))
                                .SubItems.Add(Dr.Item("Cartao"))
                                .SubItems.Add(Dr.Item("NCartao"))
                                .SubItems.Add(Dr.Item("FluxoCaixa"))
                                .SubItems.Add(Dr.Item("Historico"))
                                .SubItems.Add(Dr.Item("LCategorias"))
                                .SubItems.Add(FormatCurrency(Dr.Item("Valor")))
                                .SubItems.Add(Dr.Item("Prazo"))
                                .SubItems.Add(Dr.Item("Parcela"))
                                .SubItems.Add(Dr.Item("Vencimento"))
                                .SubItems.Add(Dr.Item("Consolidada"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using
            'BUSCAR OS DADOS DO CARTAO NA CLASSE DE CONFIGURAÇÃO DO CARTAO
            lblTotalDivida.Text = FormatCurrency(caixa.TotParc)
            lblLimTotalCar.Text = FormatCurrency(cartao.Limite)
            lblTotalPago.Text = FormatCurrency(caixa.ValorPago)
            lblSaldoConta.Text = FormatCurrency(cartao.Divida)
            lblLimDisp.Text = FormatCurrency(cartao.Limite + cartao.Divida)
            lblPercDiv.Text = FormatPercent(cartao.Perc)
            '*****************NÃO APAGAR******************
            For j As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(j).UseItemStyleForSubItems = False
                If ListView1.Items(j).SubItems.Count > 1 Then
                    ListView1.Items(j).SubItems(5).Font = New Font(ListView1.Items(j).SubItems(5).Font, FontStyle.Bold) 'Negrito na coluna
                End If
            Next
            'Colorir ListView
            Dim linhas As Integer
            Dim y As Integer
            With ListView1
                linhas = .Items.Count
                For y = 0 To linhas - 1
                    ListView1.Items(y).UseItemStyleForSubItems = True

                    If ListView1.Items(y).SubItems(7).Text = "Saída" And ListView1.Items(y).SubItems(13).Text < Today And ListView1.Items(y).SubItems(14).Text = "N" Then 'Não foi pago
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Red

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Entrada" And ListView1.Items(y).SubItems(13).Text < Today And ListView1.Items(y).SubItems(14).Text = "N" Then
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Black

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Saída" And ListView1.Items(y).SubItems(13).Text > Today And ListView1.Items(y).SubItems(14).Text = "N" Then
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Black

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Entrada" And ListView1.Items(y).SubItems(13).Text < Today And ListView1.Items(y).SubItems(14).Text = "S" Then 'Dia de pagamento
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Green

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Saída" And ListView1.Items(y).SubItems(13).Text < Today And ListView1.Items(y).SubItems(14).Text = "S" Then 'Foi pago e em dia
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Green

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Entrada" And ListView1.Items(y).SubItems(13).Text < Today And ListView1.Items(y).SubItems(14).Text = "E" Then 'Dia de pagamento
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Chocolate

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Saída" And ListView1.Items(y).SubItems(13).Text < Today And ListView1.Items(y).SubItems(14).Text = "E" Then 'Dia de pagamento
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Chocolate
                        '*******Área de atenção********
                    ElseIf ListView1.Items(y).SubItems(7).Text = "Entrada" And ListView1.Items(y).SubItems(13).Text > Today And ListView1.Items(y).SubItems(14).Text = "N" Then 'Atenção
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Saída" And ListView1.Items(y).SubItems(13).Text > Today And ListView1.Items(y).SubItems(14).Text = "S" Then 'Atenção
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Saída" And ListView1.Items(y).SubItems(13).Text > Today And ListView1.Items(y).SubItems(14).Text = "E" Then
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Entrada" And ListView1.Items(y).SubItems(13).Text > Today And ListView1.Items(y).SubItems(14).Text = "E" Then
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow

                    ElseIf ListView1.Items(y).SubItems(7).Text = "Entrada" And ListView1.Items(y).SubItems(13).Text > Today And ListView1.Items(y).SubItems(14).Text = "S" Then
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow
                    Else
                        ListView1.Items(y).SubItems(10).Font = New Font(ListView1.Items(y).SubItems(10).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Pink
                    End If
                Next
            End With
            lblQtdCartao.Text = cartao.QtdCartao & " Cartão(ões) utilizado(s)" 'Quantidade de cartões
            Label2.Text = ListView1.Items.Count & " Item(s)" 'Quantidade de itens na lista
            Label11.Text = "Geral" 'Identificação da coluna no filtro
        Catch ex As Exception
            MsgBox("Falha ao MostrarAbertura: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub ExtratoDeMovCartao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema 'Nome do sistema
        MostrarQtdCartao()
        MostrarDadosCartao()
        MostrarSaida()
        MostrarEntrada()
        MostrarTodasMovimentacao()
    End Sub

    Private Sub BtnResumo_Click(sender As Object, e As EventArgs) Handles btnResumo.Click
        MostrarResumoMovimentacao()
    End Sub
    Private Sub MostrarResumoMovimentacao()
        Dim Sql As String = "select b.Nome, b.CPF, b.Cartao, Sum(b.Valor) as Valor, b.Vencimento, b.Cons, b.Qtd, b.Mes_Ref, b.Ano_Ref from (Select a.Nome as Nome, a.cpf as CPF, a.Cartao as Cartao, Sum(a.Valor) as Valor, a.Vencimento as Vencimento, a.Cons, count(a.Nome) as Qtd, a.Mes_Ref, a.Ano_Ref from (SELECT year(cm.Vencimento) as Ano_Ref,month(cm.Vencimento) as Mes_Ref,p.Nome as Nome,cm.CPF as CPF,cm.Cartao as Cartao,Sum(cm.Valor) as Valor, cm.Vencimento as Vencimento,cm.Consolidada as Cons FROM cartaomov cm inner join pessoal p on p.cpf=cm.cpf where cm.FluxoCaixa='Saída' and cm.Consolidada not in ('E') group by p.nome, cm.cpf, cm.cartao, cm.Vencimento, cm.Consolidada, month(cm.Vencimento), year(cm.Vencimento) order by year(cm.Vencimento), month(cm.Vencimento), cm.Consolidada) a group by a.Ano_Ref, a.Mes_Ref, a.Nome, a.cpf, a.Cartao, a.Vencimento, a.Cons) b group by b.Nome, b.CPF, b.Cartao, b.Vencimento, b.Cons, b.Qtd, b.Mes_Ref, b.Ano_Ref order by b.Ano_Ref DESC, b.Mes_Ref DESC"
        Dim cn As New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader
                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("Qtd", 50, System.Windows.Forms.HorizontalAlignment.Center) '0
                            .Columns.Add("Nome", 70, System.Windows.Forms.HorizontalAlignment.Left) '1
                            .Columns.Add("CPF", 100, System.Windows.Forms.HorizontalAlignment.Left) '2
                            .Columns.Add("Cartao", 70, System.Windows.Forms.HorizontalAlignment.Left) '3
                            .Columns.Add("Valor", 80, System.Windows.Forms.HorizontalAlignment.Right) '4
                            .Columns.Add("Vencimento", 80, System.Windows.Forms.HorizontalAlignment.Right) '5
                            .Columns.Add("Cons", 50, System.Windows.Forms.HorizontalAlignment.Center) '6
                            .Columns.Add("Mês Ref", 60, System.Windows.Forms.HorizontalAlignment.Center) '7
                            .Columns.Add("Ano Ref", 60, System.Windows.Forms.HorizontalAlignment.Center) '8
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = (Dr.Item("Qtd"))
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("Nome"))
                                .SubItems.Add(Dr.Item("CPF"))
                                .SubItems.Add(Dr.Item("Cartao"))
                                .SubItems.Add(FormatCurrency(Dr.Item("Valor")))
                                .SubItems.Add(Dr.Item("Vencimento"))
                                .SubItems.Add(Dr.Item("Cons"))
                                .SubItems.Add(Dr.Item("Mes_Ref"))
                                .SubItems.Add(Dr.Item("Ano_Ref"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using
            'BUSCAR OS DADOS DO CARTAO NA CLASSE DE CONFIGURAÇÃO DO CARTAO
            lblTotalDivida.Text = FormatCurrency(caixa.TotParc)
            lblLimTotalCar.Text = FormatCurrency(cartao.Limite)
            lblTotalPago.Text = FormatCurrency(caixa.ValorPago)
            lblSaldoConta.Text = FormatCurrency(cartao.Divida)
            lblLimDisp.Text = FormatCurrency(cartao.Limite + cartao.Divida)
            lblPercDiv.Text = FormatPercent(cartao.Perc)

            For j As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(j).UseItemStyleForSubItems = False
                If ListView1.Items(j).SubItems.Count > 1 Then
                    ListView1.Items(j).SubItems(5).Font = New Font(ListView1.Items(j).SubItems(5).Font, FontStyle.Bold) 'Negrito na coluna
                End If
            Next
            'Colorir ListView
            Dim linhas As Integer
            Dim y As Integer
            With ListView1
                linhas = .Items.Count
                For y = 0 To linhas - 1
                    ListView1.Items(y).UseItemStyleForSubItems = True
                    If ListView1.Items(y).SubItems(6).Text = "N" And ListView1.Items(y).SubItems(5).Text < Today Then 'Não foi pago
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Red
                    ElseIf ListView1.Items(y).SubItems(6).Text = "N" And ListView1.Items(y).SubItems(5).Text = Today Then 'Dia de pagamento
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.DarkGreen
                    ElseIf ListView1.Items(y).SubItems(6).Text = "N" And ListView1.Items(y).SubItems(5).Text > Today Then 'Futuro pagamento
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Black
                    ElseIf ListView1.Items(y).SubItems(6).Text = "S" And ListView1.Items(y).SubItems(5).Text < Today Then 'Foi pago e em dia
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Green
                    ElseIf ListView1.Items(y).SubItems(6).Text = "S" And ListView1.Items(y).SubItems(5).Text = Today Then 'Dia de pagamento
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.DarkGreen
                    ElseIf ListView1.Items(y).SubItems(6).Text = "S" And ListView1.Items(y).SubItems(5).Text > Today Then 'Atenção
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow
                    ElseIf ListView1.Items(y).SubItems(6).Text = "E" And ListView1.Items(y).SubItems(5).Text < Today Then 'Foi pago e excluido
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Chocolate
                    ElseIf ListView1.Items(y).SubItems(6).Text = "E" And ListView1.Items(y).SubItems(5).Text = Today Then 'Atenção
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow
                    ElseIf ListView1.Items(y).SubItems(6).Text = "E" And ListView1.Items(y).SubItems(5).Text > Today Then 'Atenção
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Yellow
                    Else
                        ListView1.Items(y).SubItems(6).Font = New Font(ListView1.Items(y).SubItems(6).Font, FontStyle.Bold)
                        ListView1.Items(y).ForeColor = Color.Pink
                    End If
                Next
            End With
            lblQtdCartao.Text = cartao.QtdCartao & " Cartão(ões) utilizado(s)" 'Quantidade de cartões
            Label2.Text = ListView1.Items.Count & " Item(s)" 'Quantidade de itens na lista
            Label11.Text = "Geral" 'Identificação da coluna no filtro
        Catch ex As Exception
            MsgBox("Falha ao MostrarResumoMovimentacao: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        MostrarTodasMovimentacao()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        PesquisaPeriodo()
    End Sub
    Private Sub PesquisaPeriodo()
        'Busca por datas
        txtDtInicial.Value = Format(txtDtInicial.Value, "dd/MM/yyyy")
        txtDtFinal.Value = Format(txtDtFinal.Value, "dd/MM/yyyy")
        Try
            Dim Sql As String = "SELECT cm.ID_CartaoMov,cm.ID_Cartao,cm.DataRegistro,p.Nome,cm.CPF,cm.Cartao,cm.NCartao,cm.FluxoCaixa,cm.Historico,cm.LCategorias,cm.Valor,cm.Prazo,cm.Parcela,cm.Vencimento,cm.Consolidada FROM CartaoMov cm 
INNER JOIN Pessoal p ON p.CPF=cm.CPF where cm.FluxoCaixa = 'Saída' and cm.Vencimento between @data1 and @data2 and cm.Consolidada not in ('E') order by cm.ID_CartaoMov DESC"
            Using cn As New OleDbConnection(conn)
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Cmd.Parameters.AddWithValue("@data1", txtDtInicial.Value)
                    Cmd.Parameters.AddWithValue("@data2", txtDtFinal.Value)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader
                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("ID", 0, System.Windows.Forms.HorizontalAlignment.Left) '0
                            .Columns.Add("Car", 0, System.Windows.Forms.HorizontalAlignment.Left) '1
                            .Columns.Add("Registro", 80, System.Windows.Forms.HorizontalAlignment.Center) '2
                            .Columns.Add("Nome", 70, System.Windows.Forms.HorizontalAlignment.Left) '3
                            .Columns.Add("CPF", 90, System.Windows.Forms.HorizontalAlignment.Left) '4
                            .Columns.Add("Cartao", 70, System.Windows.Forms.HorizontalAlignment.Left) '5
                            .Columns.Add("Número", 110, System.Windows.Forms.HorizontalAlignment.Left) '6
                            .Columns.Add("Caixa", 70, System.Windows.Forms.HorizontalAlignment.Left) '7
                            .Columns.Add("Historico", 90, System.Windows.Forms.HorizontalAlignment.Left) '8
                            .Columns.Add("Categorias", 90, System.Windows.Forms.HorizontalAlignment.Left) '9
                            .Columns.Add("Valor", 70, System.Windows.Forms.HorizontalAlignment.Right) '10
                            .Columns.Add("Prazo", 80, System.Windows.Forms.HorizontalAlignment.Center) '11
                            .Columns.Add("Parcela", 60, System.Windows.Forms.HorizontalAlignment.Center) '12
                            .Columns.Add("Vencimento", 80, System.Windows.Forms.HorizontalAlignment.Center) '13
                            .Columns.Add("Cons", 40, System.Windows.Forms.HorizontalAlignment.Center) '14
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = (Dr.Item("ID_CartaoMov"))
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                '.ForeColor = Color.Red
                                .SubItems.Add(Dr.Item("ID_Cartao"))
                                .SubItems.Add(Dr.Item("DataRegistro"))
                                .SubItems.Add(Dr.Item("Nome"))
                                .SubItems.Add(Dr.Item("CPF"))
                                .SubItems.Add(Dr.Item("Cartao"))
                                .SubItems.Add(Dr.Item("NCartao"))
                                .SubItems.Add(Dr.Item("FluxoCaixa"))
                                .SubItems.Add(Dr.Item("Historico"))
                                .SubItems.Add(Dr.Item("LCategorias"))
                                .SubItems.Add(FormatCurrency(Dr.Item("Valor")))
                                .SubItems.Add(Dr.Item("Prazo"))
                                .SubItems.Add(Dr.Item("Parcela"))
                                .SubItems.Add(Dr.Item("Vencimento"))
                                .SubItems.Add(Dr.Item("Consolidada"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using

            lblTotalDivida.Text = FormatCurrency(caixa.TotParc)
            lblTotalPago.Text = FormatCurrency(caixa.ValorPago)
            lblLimTotalCar.Text = FormatCurrency(cartao.Limite)
            lblLimDisp.Text = FormatCurrency(cartao.Limite + cartao.Divida)

            lblQtdCartao.Text = cartao.QtdCartao & " Cartão(ões) utilizado(s)" 'Quantidade de cartões
            Label2.Text = ListView1.Items.Count & " Item(s)"

            Label11.Text = "Pesquisa" '(ListView1.Columns(0).Text) 'Criterio 

            txtDtInicial.Value = Format(Now(), "dd/MM/yyyy")
        Catch ex As Exception
            MsgBox("Falha PesquisaPeriodo: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

End Class
Public Enum Mes
    janeiro = 1
    fevereiro
    marco
    abril
    maio
    junho
    julho
    agosto
    setembro
    outubro
    novembro
    dezembro
End Enum