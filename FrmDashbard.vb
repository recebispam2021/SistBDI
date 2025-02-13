Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports ProjSistBDIMax.ConfigCartao
Public Class FrmDashbard
    Public var1 As Boolean = False
    Dim ProcRegistro As Boolean
    'Instanciar a classe ConfigCartao
    Dim cartao As New InfCartao
    Dim caixa As New Caixa
    Private Sub BancoDeDados()
        Dim cn As New OleDbConnection(conn)
        Try
            'Verifica se existem registros iguais nas tabelas Cartão e CartãoMov
            Dim sql = "Select * from Cartao a Where exists (SELECT * FROM CartaoMov b where a.ID_Cartao=b.ID_Cartao)"
            cn.Open()
            Dim cmd1 As New OleDbCommand(sql, cn)
            ProcRegistro = (cmd1.ExecuteScalar)
        Catch ex As Exception
            MsgBox("Falha em BancoDeDados")
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub DesabilitarChart()
        For Each Ctr As Control In PanelHome.Controls
            If TypeOf Ctr Is Chart Then
                Dim rb As Chart = TryCast(Ctr, Chart)
                If TypeOf rb Is DataVisualization.Charting.Chart Then
                    rb.Hide()
                End If
            End If
        Next
    End Sub
    Private Sub DesabilitarButton()
        For Each Ctr As Control In GroupBox4.Controls
            If TypeOf Ctr Is Button Then
                Dim rb As Button = TryCast(Ctr, Button)
                If TypeOf rb Is Button Then
                    rb.Hide()
                End If
            End If
        Next
    End Sub
    Private Sub DesabilitarComboBox()
        For Each Ctr As Control In GroupBox4.Controls
            If TypeOf Ctr Is ComboBox Then
                Dim rb As ComboBox = TryCast(Ctr, ComboBox)
                If TypeOf rb Is ComboBox Then
                    rb.Hide()
                End If
            End If
        Next
        Label7.Hide()
        Label9.Hide()
    End Sub

    Private Sub FrmDashbard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BancoDeDados()
            'Verifica se existem registros iguais nas tabelas Cartão e CartãoMov
            If ProcRegistro = False Then
                DesabilitarChart()
                DesabilitarButton()
                DesabilitarComboBox()
            End If
            MostrarValores() 'Recupera os valores de limite e dividas do cartão
            MostrarPagamentos()
            PesqHome()
            PesqCategorias()
            PesqCartao()
            PesqNome()
            PesqPeriodoGeral()
        Catch ex As Exception
        MsgBox("Falha em FrmDashbard: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub MostrarValores()
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Dim sql = "select a.CPF, a.Cartao, formatcurrency(sum(a.Valor*-1)) as TGasto, formatcurrency(b.Limite) as Limite, formatcurrency(b.Saldo) as Saldo FROM CartaoMov a LEFT JOIN Cartao b ON a.ID_Cartao=b.ID_Cartao where a.fluxocaixa='Saída' Group by a.CPF, a.Cartao, b.Limite, b.Saldo ORDER BY Count(a.Cartao) DESC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewCartoes.DataSource = dt
                    End Using
                End Using
            End Using
            For Each col As DataGridViewRow In DataGridViewCartoes.Rows
                caixa.Credito += col.Cells(3).Value 'Total de limites
                caixa.Divida += col.Cells(2).Value 'Total de gastos
                caixa.SaldoLimite += col.Cells(4).Value 'Total de saldo
            Next
            LblTotDivida.Text = FormatCurrency(caixa.Divida)
            LblLimiteTotal.Text = FormatCurrency(caixa.Credito)
            LblLimitDispon.Text = FormatCurrency(caixa.SaldoLimite)
            TxtAnoRef.Text = Year(Today) 'Data de entrada no textbox
        Catch ex As Exception
            MsgBox("Falha em MostrarInnerJoin: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub MostrarPagamentos()
        Dim sql = "Select formatcurrency(sum(Valor)) as Pagtos from CartaoMov where FluxoCaixa='Entrada'"
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read Then
                                LblTotPagto.Text = dr("Pagtos")
                                caixa.ValorPago = dr("Pagtos")
                            End If
                        End If
                    End Using
                End Using
            End Using
            caixa.CalculoPercMov()
        Catch ax As InvalidCastException
            Exit Try
        Catch ex As Exception
            MsgBox("Falha em MostrarPagamentos: " & ex.Message, vbCritical, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub RestaurarChart()
        For Each Ctr As Control In PanelHome.Controls
            If TypeOf Ctr Is Chart Then
                Dim rb As Chart = TryCast(Ctr, Chart)
                If rb.Dock = DockStyle.Fill Then
                    rb.Dock = DockStyle.None
                    Exit For
                End If
            End If
        Next
    End Sub
    Private Sub VisualizarChart()
        For Each Ctr As Control In PanelHome.Controls
            If TypeOf Ctr Is Chart Then
                Dim rb As Chart = TryCast(Ctr, Chart)
                While rb.Visible = False
                    rb.Visible = True
                End While
            End If
        Next
    End Sub
    Private Sub PesqHome()
        ChartEntSai.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select FluxoCaixa as Caixa, formatcurrency(sum(Valor)) as Divida FROM CartaoMov Group by FluxoCaixa"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewEntSai.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewEntSai.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    If col.Cells(1).Value > 0 Then
                        ChartEntSai.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value / caixa.Credito)
                    Else
                        ChartEntSai.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value * -1 / caixa.Credito)
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha PesqHome " & ex.Message)
        End Try
    End Sub
    Private Sub PesqHomeMes()
        Dim AnoFT As Integer = TxtAnoRef.Text
        Dim MesFT As Integer = CboMesInicio.SelectedIndex + 1
        Dim MesFTa As Integer = CboMesTermino.SelectedIndex + 1
        RestaurarChart()
        ChartEntSai.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select FluxoCaixa, formatcurrency(sum(Valor)) as Divida FROM CartaoMov"
                If var1 = True Then
                    sql = $"{sql} where year(Vencimento) = {AnoFT} and month(Vencimento) between {MesFT} and  {MesFTa}"
                End If
                sql = $"{sql} Group by FluxoCaixa"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewEntSai.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewEntSai.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    If col.Cells(1).Value > 0 Then
                        ChartEntSai.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value / caixa.Credito)
                    Else
                        ChartEntSai.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value * -1 / caixa.Credito)
                    End If
                End If
            Next
            ChartEntSai.Dock = DockStyle.Fill
            ChartEntSai.Visible = True
            ChartCartoes.Visible = False
            ChartCategorias.Visible = False
            ChartNomes.Visible = False
            ChartPeriodo.Visible = False
        Catch ex As Exception
            MsgBox("Falha PesqHomeMes " & ex.Message)
        End Try
    End Sub

    Private Sub PesqPeriodoGeral()
        ChartPeriodo.Series(0).Points.Clear()
        ChartPeriodo.Series(1).Points.Clear()
        Dim AnoFT As Integer = TxtAnoRef.Text
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "select Format(a.Vencimento,'MMMM') as Vencimento, Sum(a.Valor*-1) as Valor, month(a.Vencimento) as mes FROM CartaoMov a Where FluxoCaixa='Saída' AND year(Vencimento) = " & AnoFT & " 
                    GROUP BY Format(a.Vencimento,'MMMM'), month(a.Vencimento) ORDER BY month(a.Vencimento) asc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewPeriodo.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewPeriodo.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartPeriodo.Series(0).Points.AddXY(col.Cells(0).Value, 1000)
                    ChartPeriodo.Series(1).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
                End If
            Next
        Catch ax As OleDbException
            Exit Sub
        Catch ex As Exception
            MsgBox("Falha PesqPeriodoGeral" & ex.Message)
        End Try
    End Sub
    Private Sub PesqCategorias()
        ChartCategorias.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select top 5 LCategorias, formatcurrency(sum(Valor*-1)) as TGasto FROM CartaoMov where FluxoCaixa='Saída' Group by LCategorias Order by sum(Valor*-1) desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewCategorias.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewCategorias.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartCategorias.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha PesqCategorias" & ex.Message)
        End Try
    End Sub
    Private Sub PesqCategoriasMes()
        Dim AnoFT As Integer = TxtAnoRef.Text
        Dim MesFT As Integer = CboMesInicio.SelectedIndex + 1
        Dim MesFTa As Integer = CboMesTermino.SelectedIndex + 1
        RestaurarChart()
        ChartCategorias.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select top 5 LCategorias, formatcurrency(sum(Valor*-1)) as TGasto FROM CartaoMov where FluxoCaixa='Saída'"
                If var1 = True Then
                    sql = $"{sql} AND year(Vencimento) = {AnoFT} and month(Vencimento) between {MesFT} and  {MesFTa}"
                End If
                sql = $"{sql} Group by LCategorias Order by sum(Valor*-1) Desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewCategorias.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewCategorias.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                End If
                ChartCategorias.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
            Next
            ChartCategorias.Dock = DockStyle.Fill
            ChartEntSai.Visible = False
            ChartCartoes.Visible = False
            ChartCategorias.Visible = True
            ChartNomes.Visible = False
            ChartPeriodo.Visible = False
        Catch ex As Exception
            MsgBox("Falha PesqCategoriasMes" & ex.Message)
        End Try
    End Sub
    Private Sub PesqCartao()
        ChartCartoes.Dock = DockStyle.None
        ChartCartoes.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select Cartao, formatcurrency(sum(Valor*-1)) as TGasto FROM CartaoMov where FluxoCaixa='Saída' Group by Cartao Order By sum(Valor*-1) Desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewCartoes.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewCartoes.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartCartoes.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha PesqCartao" & ex.Message)
        End Try
    End Sub
    Private Sub PesqNome()
        ChartNomes.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select p.Nome, formatcurrency(sum(a.Valor*-1)) as TGasto FROM CartaoMov a inner join Pessoal p on p.cpf=a.cpf where FluxoCaixa='Saída' Group by p.nome Order By sum(a.Valor*-1) Desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewNomes.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using

            For Each col As DataGridViewRow In DataGridViewNomes.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartNomes.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha PesqNome " & ex.Message)
        End Try
    End Sub
    Private Sub BtnCartoes_Click(sender As Object, e As EventArgs) Handles BtnCartoes.Click
        If TxtAnoRef.Text = "" Then
            MsgBox("O ano de referência é obrigatório!", vbInformation, "Atenção!")
            TxtAnoRef.Focus()
            Exit Sub
        End If
        DesvioDaPesquisa()
        PesqCartaoMes()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        MostrarValores()
        PesqHome()
        PesqCategorias()
        PesqCartao()
        PesqNome()
        PesqPeriodoGeral()
        RestaurarChart()
        VisualizarChart()
        CboMesInicio.SelectedIndex = -1
        CboMesTermino.SelectedIndex = -1
    End Sub
    Private Sub BtnPeriodo_Click(sender As Object, e As EventArgs) Handles BtnPeriodo.Click
        If TxtAnoRef.Text = "" Then
            MsgBox("O ano de referência é obrigatório!", vbInformation, "Atenção!")
            TxtAnoRef.Focus()
            Exit Sub
        End If
        DesvioDaPesquisa()
        PesqPeriodoMes()
    End Sub
    Private Sub PesqCartaoMes()
        Dim AnoFT As Integer = TxtAnoRef.Text
        Dim MesFT As Integer = CboMesInicio.SelectedIndex + 1
        Dim MesFTa As Integer = CboMesTermino.SelectedIndex + 1
        RestaurarChart()
        ChartCartoes.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "Select Cartao, formatcurrency(sum(Valor*-1)) as TGasto FROM CartaoMov where FluxoCaixa='Saída'"
                If var1 = True Then
                    sql = $"{sql} AND year(Vencimento) = {AnoFT} and month(Vencimento) between {MesFT} and  {MesFTa}"
                End If
                sql = $"{sql} Group by Cartao Order by sum(Valor*-1) Desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewCartoes.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewCartoes.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartCartoes.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
                End If
            Next
            ChartCartoes.Dock = DockStyle.Fill
            ChartEntSai.Visible = False
            ChartCartoes.Visible = True
            ChartCategorias.Visible = False
            ChartNomes.Visible = False
            ChartPeriodo.Visible = False
        Catch ex As Exception
            MsgBox("Falha PesqCartaoMes" & ex.Message)
        End Try
    End Sub
    Private Sub PesqNomeMes()
        Dim AnoFT As Integer = TxtAnoRef.Text
        Dim MesFT As Integer = CboMesInicio.SelectedIndex + 1
        Dim MesFTa As Integer = CboMesTermino.SelectedIndex + 1
        RestaurarChart()
        ChartNomes.Series(0).Points.Clear()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "Select p.Nome, formatcurrency(sum(a.Valor*-1)) as TGasto FROM CartaoMov a inner join Pessoal p on p.cpf=a.cpf where FluxoCaixa ='Saída'"
                If var1 = True Then
                    sql = $"{sql} AND year(Vencimento) = {AnoFT} and month(Vencimento) between {MesFT} and  {MesFTa}"
                End If
                sql = $"{sql} Group by p.nome Order by sum(a.Valor*-1) Desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewNomes.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using

            For Each col As DataGridViewRow In DataGridViewNomes.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartNomes.Series(0).Points.AddXY(col.Cells(0).Value, col.Cells(1).Value)
                End If
            Next
            ChartNomes.Dock = DockStyle.Fill
            ChartEntSai.Visible = False
            ChartCartoes.Visible = False
            ChartCategorias.Visible = False
            ChartNomes.Visible = True
            ChartPeriodo.Visible = False
        Catch ex As Exception
            MsgBox("Falha PesqNomeMes" & ex.Message)
        End Try
    End Sub
    Private Sub PesqPeriodoMes()
        RestaurarChart()
        ChartPeriodo.Series(0).Points.Clear()
        ChartPeriodo.Series(1).Points.Clear()
        Dim AnoFT As Integer = TxtAnoRef.Text
        Dim MesFT As Integer = CboMesInicio.SelectedIndex + 1
        Dim MesFTa As Integer = CboMesTermino.SelectedIndex + 1
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql =
                    "select Format(a.Vencimento,'MMMM') as Vencimento, Sum(a.Valor*-1) as Valor, month(a.Vencimento) as mes FROM CartaoMov a where FluxoCaixa ='Saída'"
                If var1 = True Then
                    sql = $"{sql} AND year(Vencimento) = {AnoFT} and month(Vencimento) between {MesFT} and  {MesFTa}"
                End If
                sql = $"{sql} Group by Format(a.Vencimento,'MMMM'), year(Vencimento), month(a.Vencimento) ORDER BY year(Vencimento), month(a.Vencimento) asc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridViewPeriodo.DataSource = dt
                    End Using
                End Using
                cn.Close()
            End Using
            For Each col As DataGridViewRow In DataGridViewPeriodo.Rows
                If col.Cells(1).Value Is Nothing Then
                    Exit For
                Else
                    ChartPeriodo.Series(0).Points.AddXY(col.Cells(0).Value, 1000)
                    ChartPeriodo.Series(1).Points.AddXY(col.Cells(0).Value.ToString, col.Cells(1).Value)
                End If
            Next
            ChartPeriodo.Dock = DockStyle.Fill
            ChartEntSai.Visible = False
            ChartCartoes.Visible = False
            ChartCategorias.Visible = False
            ChartNomes.Visible = False
            ChartPeriodo.Visible = True
        Catch ax As OleDbException
            Exit Sub
        Catch ex As Exception
            MsgBox("Falha PesqPeriodoMes" & ex.Message)
        End Try
    End Sub
    Private Sub BtnNomes_Click(sender As Object, e As EventArgs) Handles BtnNomes.Click
        If TxtAnoRef.Text = "" Then
            MsgBox("O ano de referência é obrigatório!", vbInformation, "Atenção!")
            TxtAnoRef.Focus()
            Exit Sub
        End If
        DesvioDaPesquisa()
        PesqNomeMes()
    End Sub

    Private Sub BtnCategorias_Click(sender As Object, e As EventArgs) Handles BtnCategorias.Click
        If TxtAnoRef.Text = "" Then
            MsgBox("O ano de referência é obrigatório!", vbInformation, "Atenção!")
            TxtAnoRef.Focus()
            Exit Sub
        End If
        DesvioDaPesquisa()
        PesqCategoriasMes()
    End Sub

    Private Sub BtnEntSai_Click(sender As Object, e As EventArgs) Handles BtnEntSai.Click
        If TxtAnoRef.Text = "" Then
            MsgBox("O ano de referência é obrigatório!", vbInformation, "Atenção!")
            TxtAnoRef.Focus()
            Exit Sub
        End If
        DesvioDaPesquisa()
        PesqHomeMes()
    End Sub

    Public Function DesvioDaPesquisa() As Boolean
        'Código para definir o caminho da pesquisa
        If CboMesInicio.Text = "" And CboMesTermino.Text = "" Then
            var1 = False
        ElseIf CboMesInicio.Text = "" Then
            MsgBox("Mês de início é obrigatório!", vbInformation, "Atenção!")
            CboMesInicio.Focus()
            Exit Function
        ElseIf CboMesTermino.Text = "" Then
            MsgBox("Mês de termino é obrigatório!", vbInformation, "Atenção!")
            CboMesTermino.Focus()
            Exit Function
        Else
            var1 = True
        End If
        Return var1
    End Function
End Class