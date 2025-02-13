Imports System.Data.OleDb

Public Class Balancete
    Dim MesFT As Integer
    Dim ano As Integer

    Private Sub CartaoAnaliseConsMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        TxtAno.Text = Year(Today)
        MostrarInnerJoin()
    End Sub

    Private Sub MostrarInnerJoin()
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Dim sql =
                "Select ('Todos') as Nome, ('Todos') as Cartão, Count(a.Cartao) as Qtd_Cartões, a.Mes as Mês, a.Ano as Ano, formatcurrency(Sum(a.Valor)) as Dívida, iif (Dívida=0,'Paga','Não Paga') as Situação from (select cm.Cartao as Cartao, sum(cm.Valor) as Valor, month(cm.Vencimento) as Mes, year(cm.Vencimento) as Ano from cartaomov cm inner join cartao c on c.ID_Cartao=cm.ID_Cartao group by cm.Cartao, month(cm.Vencimento), year(cm.Vencimento), cm.Consolidada order by year(cm.Vencimento), month(cm.Vencimento)) a Group By a.Mes, a.Ano Order By a.Ano, a.Mes"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            With DataGridView1
                .Columns("Nome").HeaderText = "Nome"
                .Columns("Nome").Width = 90
                .Columns("Nome").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Cartão").HeaderText = "Cartão"
                .Columns("Cartão").Width = 90
                .Columns("Cartão").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Qtd_Cartões").HeaderText = "Qtd_Registros"
                .Columns("Qtd_Cartões").Width = 80
                .Columns("Qtd_Cartões").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Mês").HeaderText = "Mês"
                .Columns("Mês").Width = 60
                .Columns("Mês").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Ano").HeaderText = "Ano"
                .Columns("Ano").Width = 90
                .Columns("Ano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Dívida").HeaderText = "Dívida"
                .Columns("Dívida").Width = 90
                .Columns("Dívida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Situação").HeaderText = "Situação"
                .Columns("Situação").Width = 90
                .Columns("Situação").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
        Catch ex As Exception
            MsgBox("Falha em MostrarInnerJoin: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtAno.Text = "" Or TxtAno.TextLength = 0 Then
            Exit Sub
        End If
        Try
            'Para cada controle, verificar o tipo e associar ao evento
            For Each crt As Control In GroupCriterios.Controls
                If TypeOf crt Is RadioButton Then
                    Dim txt As RadioButton = TryCast(crt, RadioButton)
                    If txt.Checked = True Then
                        Dim CritFT As String = txt.Text
                        Select Case CritFT
                            Case "Geral"
                                PesqMesAno(MesFT, ano)
                            Case "Por Cartão"
                                PesqPorCartao(MesFT, ano)
                            Case "Por Nome"
                                PesqPorNome(MesFT, ano)
                            Case "Por Fluxo"
                                PesqPorFluxo(MesFT, ano)
                            Case "Por Categorias"
                                PesqPorCategorias(MesFT, ano)
                        End Select
                        Exit For
                    End If
                End If
            Next
            'Verifica se exitem itens no mês para exibir 
            If DataGridView1.RowCount.ToString <= 0 Then
                MsgBox("Não existe fatura para este mês!", vbInformation, "Aviso!")
            End If
        Catch ex As Exception
            MsgBox("Falha BtnBuscar")
        End Try
    End Sub
    Private Sub PesqMesAno(MesFT As Integer, ano As Integer)
        Dim cn = New OleDbConnection(conn)
        ano = TxtAno.Text
        'Para cada controle, verificar o tipo e associar ao evento
        For Each crt As Control In GroupMesAno.Controls
            If TypeOf crt Is RadioButton Then
                Dim txt As RadioButton = TryCast(crt, RadioButton)
                If txt.Checked = True Then
                    MesFT = txt.Tag
                    Exit For
                End If
            End If
        Next
        Try
            Using cn
                cn.Open()
                Dim sql =
                "select Format(a.Vencimento,'MMMM') as Fatura,('Todos') as Cartão, count(a.Cartao) as Qtd, month(a.Vencimento) as Mês, year(a.Vencimento) as Ano, formatcurrency(sum(a.Valor)) as Valor_Dívida, iif (Valor_Dívida=0,'Paga','Não Paga') as Situação FROM CartaoMov a Where month(Vencimento) = " & MesFT & " And year(Vencimento) = " & ano & " GROUP BY Format(a.Vencimento,'MMMM'), month(a.Vencimento), year(a.Vencimento) ORDER BY year(a.Vencimento) asc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            With DataGridView1
                .Columns("Fatura").HeaderText = "Fatura"
                .Columns("Fatura").Width = 130
                .Columns("Fatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Cartão").HeaderText = "Cartão"
                .Columns("Cartão").Width = 100
                .Columns("Cartão").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Qtd").HeaderText = "Qtd_Registros"
                .Columns("Qtd").Width = 100
                .Columns("Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Mês").HeaderText = "Mês"
                .Columns("Mês").Width = 50
                .Columns("Mês").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Ano").HeaderText = "Ano"
                .Columns("Ano").Width = 50
                .Columns("Ano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Valor_Dívida").HeaderText = "Valor_Dívida"
                .Columns("Valor_Dívida").Width = 100
                .Columns("Valor_Dívida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Situação").HeaderText = "Situação"
                .Columns("Situação").Width = 100
                .Columns("Situação").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
        Catch ex As Exception
            MsgBox("Falha PesqMesAno")
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub PesqPorCartao(MesFT As Integer, ano As Integer)
        Dim cn = New OleDbConnection(conn)
        ano = TxtAno.Text
        'Para cada controle, verificar o tipo e associar ao evento
        For Each crt As Control In GroupMesAno.Controls
            If TypeOf crt Is RadioButton Then
                Dim txt As RadioButton = TryCast(crt, RadioButton)
                If txt.Checked = True Then
                    MesFT = txt.Tag
                    Exit For
                End If
            End If
        Next
        Try
            Using cn
                cn.Open()
                Dim sql =
                    "select format(a.Vencimento, 'MMMM') as Fatura,a.Cartao as Cartão,a.NCartao as Numero,count(a.Cartao) as Qtd,month(a.Vencimento) as Mês,year(a.Vencimento) as Ano,formatcurrency(sum(a.Valor)) as Valor_Dívida,iif (Valor_Dívida=0,'Paga','Não Paga') as Situação FROM CartaoMov a inner join Pessoal p on p.CPF=a.CPF Where month(Vencimento) = " & MesFT & " And year(Vencimento) = " & ano & " GROUP BY Format(a.Vencimento,'MMMM'),a.Cartao,a.NCartao,month(a.Vencimento),year(a.Vencimento) ORDER BY a.Cartao ASC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            With DataGridView1

                .Columns("Fatura").HeaderText = "Fatura"
                .Columns("Fatura").DisplayIndex = 0
                .Columns("Fatura").Width = 90
                .Columns("Fatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Cartão").HeaderText = "Cartão"
                .Columns("Cartão").DisplayIndex = 1
                .Columns("Cartão").Width = 80
                .Columns("Cartão").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Numero").HeaderText = "Número"
                .Columns("Numero").DisplayIndex = 2
                .Columns("Numero").Width = 120
                .Columns("Numero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Qtd").HeaderText = "Qtd_Registros"
                .Columns("Qtd").DisplayIndex = 3
                .Columns("Qtd").Width = 80
                .Columns("Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Mês").HeaderText = "Mês"
                .Columns("Mês").DisplayIndex = 4
                .Columns("Mês").Width = 50
                .Columns("Mês").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Ano").HeaderText = "Ano"
                .Columns("Ano").DisplayIndex = 5
                .Columns("Ano").Width = 50
                .Columns("Ano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Valor_Dívida").HeaderText = "Dívida"
                .Columns("Valor_Dívida").DisplayIndex = 6
                .Columns("Valor_Dívida").Width = 100
                .Columns("Valor_Dívida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Situação").HeaderText = "Situação"
                .Columns("Situação").DisplayIndex = 7
                .Columns("Situação").Width = 100
                .Columns("Situação").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            End With
        Catch ex As Exception
            MsgBox("Falha PesqPorCartao" & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub PesqPorNome(MesFT As Integer, ano As Integer)
        Dim cn = New OleDbConnection(conn)
        ano = TxtAno.Text
        'Para cada controle, verificar o tipo e associar ao evento
        For Each crt As Control In GroupMesAno.Controls
            If TypeOf crt Is RadioButton Then
                Dim txt As RadioButton = TryCast(crt, RadioButton)
                If txt.Checked = True Then
                    MesFT = txt.Tag
                    Exit For
                End If
            End If
        Next
        Try
            Using cn
                cn.Open()
                Dim sql = "select format(a.Vencimento, 'MMMM') as Fatura,p.Nome as Nome,'Todos' as Cartão,count(a.CPF) as Qtd,month(a.Vencimento) as Mês, year(a.Vencimento) as Ano,formatcurrency(sum(a.Valor)) as Valor_Dívida,iif (Valor_Dívida=0,'Paga','Não Paga') as Situação FROM CartaoMov a inner join Pessoal p on p.CPF=a.CPF Where month(a.Vencimento) = " & MesFT & " And year(a.Vencimento) = " & ano & " GROUP BY p.Nome, 'Todos', Format(a.Vencimento,'MMMM'), month(a.Vencimento), year(a.Vencimento)ORDER BY p.Nome ASC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            With DataGridView1
                .Columns("Fatura").HeaderText = "Fatura"
                .Columns("Fatura").DisplayIndex = 0
                .Columns("Fatura").Width = 90
                .Columns("Fatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Nome").HeaderText = "Nome"
                .Columns("Nome").DisplayIndex = 1
                .Columns("Nome").Width = 90
                .Columns("Nome").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Cartão").HeaderText = "Cartão"
                .Columns("Cartão").DisplayIndex = 2
                .Columns("Cartão").Width = 90
                .Columns("Cartão").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Qtd").HeaderText = "Qtd_Registros"
                .Columns("Qtd").DisplayIndex = 3
                .Columns("Qtd").Width = 100
                .Columns("Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Mês").HeaderText = "Mês"
                .Columns("Mês").DisplayIndex = 4
                .Columns("Mês").Width = 50
                .Columns("Mês").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Ano").HeaderText = "Ano"
                .Columns("Ano").DisplayIndex = 5
                .Columns("Ano").Width = 50
                .Columns("Ano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Valor_Dívida").HeaderText = "Dívida"
                .Columns("Valor_Dívida").DisplayIndex = 6
                .Columns("Valor_Dívida").Width = 100
                .Columns("Valor_Dívida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Situação").HeaderText = "Situação"
                .Columns("Situação").DisplayIndex = 7
                .Columns("Situação").Width = 100
                .Columns("Situação").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
        Catch ex As Exception
            MsgBox("Falha PesqPorNome" & ex.Message)
        Finally
        cn.Close()
        End Try
    End Sub
    Private Sub PesqPorCategorias(MesFT As Integer, ano As Integer)
        Dim cn = New OleDbConnection(conn)
        ano = TxtAno.Text
        'Para cada controle, verificar o tipo e associar ao evento
        For Each crt As Control In GroupMesAno.Controls
            If TypeOf crt Is RadioButton Then
                Dim txt As RadioButton = TryCast(crt, RadioButton)
                If txt.Checked = True Then
                    MesFT = txt.Tag
                    Exit For
                End If
            End If
        Next
        Try
            Using cn
                cn.Open()
                Dim sql =
                    "select format(a.Vencimento, 'MMMM') as Fatura, a.FluxoCaixa, a.LCategorias, count(a.LCategorias) as Qtd, month(a.Vencimento) as Mês, year(a.Vencimento) as Ano, formatcurrency(sum(a.Valor)) as Valor_Dívida
                    FROM CartaoMov a 
                    Where month(Vencimento) = " & MesFT & " And year(Vencimento) = " & ano & " 
                    GROUP BY  a.FluxoCaixa, a.LCategorias, Format(a.Vencimento,'MMMM'), month(a.Vencimento), year(a.Vencimento) 
                    ORDER BY year(a.Vencimento) asc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            With DataGridView1

                .Columns("Fatura").HeaderText = "Fatura"
                .Columns("Fatura").Width = 90
                .Columns("Fatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("LCategorias").HeaderText = "Categorias"
                .Columns("LCategorias").Width = 130
                .Columns("LCategorias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Qtd").HeaderText = "Qtd_Registros"
                .Columns("Qtd").Width = 100
                .Columns("Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Mês").HeaderText = "Mês"
                .Columns("Mês").Width = 50
                .Columns("Mês").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Ano").HeaderText = "Ano"
                .Columns("Ano").Width = 50
                .Columns("Ano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Valor_Dívida").HeaderText = "Dívida/Saldo"
                .Columns("Valor_Dívida").Width = 100
                .Columns("Valor_Dívida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("FluxoCaixa").HeaderText = "Caixa"
                .Columns("FluxoCaixa").Width = 100
                .Columns("FluxoCaixa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
        Catch ex As Exception
            MsgBox("Falha PesqPorCategorias")
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub PesqPorFluxo(MesFT As Integer, ano As Integer)
        Dim MesRef As Integer
        Dim cn = New OleDbConnection(conn)
        ano = TxtAno.Text
        MesRef = Format(Today, "MM")
        'Para cada controle, verificar o tipo e associar ao evento
        For Each crt As Control In GroupMesAno.Controls
            If TypeOf crt Is RadioButton Then
                Dim txt As RadioButton = TryCast(crt, RadioButton)
                If txt.Checked = True Then
                    MesFT = txt.Tag
                    Exit For
                End If
            End If
        Next
        Try
            Using cn
                cn.Open()
                Dim sql =
                    "select format(a.Vencimento, 'MMMM') as Fatura, a.FluxoCaixa as Caixa, count(a.FluxoCaixa) as Qtd, month(a.Vencimento) as Mês, year(a.Vencimento) as Ano, formatcurrency(sum(a.Valor)) as Valor_Dívida, iif (" & MesFT & " <= " & MesRef & ",'Quitada','Aberta') as Situação
                    FROM CartaoMov a 
                    Where month(Vencimento) = " & MesFT & " And year(Vencimento) = " & ano & " 
                    GROUP BY Format(a.Vencimento,'MMMM'), a.FluxoCaixa, month(a.Vencimento), year(a.Vencimento)
                    ORDER BY a.FluxoCaixa DESC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            With DataGridView1

                .Columns("Fatura").HeaderText = "Fatura"
                .Columns("Fatura").Width = 90
                .Columns("Fatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Caixa").HeaderText = "Caixa"
                .Columns("Caixa").Width = 130
                .Columns("Caixa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Qtd").HeaderText = "Qtd_Registros"
                .Columns("Qtd").Width = 100
                .Columns("Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Mês").HeaderText = "Mês"
                .Columns("Mês").Width = 50
                .Columns("Mês").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Ano").HeaderText = "Ano"
                .Columns("Ano").Width = 50
                .Columns("Ano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Valor_Dívida").HeaderText = "Valor"
                .Columns("Valor_Dívida").Width = 100
                .Columns("Valor_Dívida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Catch ex As Exception
            MsgBox("Falha PesqPorFluxo " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnLimpar_Click_1(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparRadioButton()
        MostrarInnerJoin()
    End Sub
    Private Sub LimparRadioButton()
        Try
            For Each Ctr As Control In GroupCriterios.Controls
                If TypeOf Ctr Is RadioButton Then
                    Dim rb As RadioButton = TryCast(Ctr, RadioButton)
                    If rb.Checked = True Then
                        rb.Checked = False
                        Exit For
                    End If
                End If
            Next
            For Each Ctr As Control In GroupMesAno.Controls
                If TypeOf Ctr Is RadioButton Then
                    Dim rb As RadioButton = TryCast(Ctr, RadioButton)
                    If rb.Checked = True Then
                        rb.Checked = False
                        Exit For
                    End If
                End If
            Next
            DataGridView1.DataSource = Nothing
            TxtAno.Text = Year(Today)
            RdbJan.Checked = True
            RadioButton2.Checked = True
        Catch ix As InvalidCastException
            MsgBox("Falha InvalidCastException")
            Exit Try
        Catch ex As Exception
            MsgBox("Falha LimparRadioButton")
        End Try
    End Sub
    Private Sub CartaoAnaliseConsMov_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub CartaoAnaliseConsMov_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub

End Class
