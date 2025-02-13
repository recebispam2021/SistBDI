Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports ProjSistBDIMax.ConfigCartao

Public Class FaturaCartao
    'Instanciar a classe de Conexão
    Dim conexao As New OleDbConnection()
    'Instanciar a classe ConfigCartao
    Dim cartao As New InfCartao
    Dim caixa As New Caixa

    'Iniciar aplicação
    Private Sub FaturaCartao_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub
    Private Sub FaturaCartao_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub
    Private Sub FaturaCartao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nome do sistema
        tssTexto.Text = pNomeSistema
        'Data de hoje como padrão no início
        mskDataR.Text = Today
        'Buscar o nome da categoria cadastrada
        ExibirCategoria()
        'Fazendo uma pesquisa para buscar os dados do cartão por cpf
        BuscaCPF()
        MostrarTodosUsuarios()
        ConfigurarGrade()
    End Sub
    Private Sub BuscaDividaCartao()
        'Buscar o total de divida por cartao
        Dim con As OleDbConnection = Getconnection()
        Try
            Dim dr As OleDbDataReader = Nothing
            Using con
                con.Open()
                Dim sql As String = "SELECT Cartao, CPF, Sum(Valor) as Divida from CartaoMov WHERE CPF='" & cboCPF.Text & "' and NCartao='" & CboNCartao.Text & "' group by Cartao, CPF"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    caixa.Divida = dr.Item("Divida")
                    lblSaldo.Text = FormatCurrency(caixa.Divida)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha8: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub MostrarTodosUsuarios()
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Dim sql = "Select top 7 * from CartaoMov where Consolidada NOT IN ('E') and FluxoCaixa NOT IN ('Entrada') order by Id_CartaoMov desc"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                .Columns("ID_CartaoMov").Visible = False
                .Columns("ID_CartaoMov").HeaderText = "IDm"
                .Columns("ID_CartaoMov").Width = 40
                .Columns("ID_CartaoMov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("ID_Cartao").Visible = True
                .Columns("ID_Cartao").HeaderText = "IDc"
                .Columns("ID_Cartao").Width = 40
                .Columns("ID_Cartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DataRegistro").HeaderText = "Registro"
                .Columns("DataRegistro").Width = 80
                .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("CPF").Visible = True
                .Columns("CPF").HeaderText = "CPF"
                .Columns("CPF").Width = 100
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Cartao").HeaderText = "Cartão"
                .Columns("Cartao").Width = 80
                .Columns("Cartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("NCartao").Visible = False
                .Columns("NCartao").HeaderText = "Número"
                .Columns("NCartao").Width = 110
                .Columns("NCartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("fluxocaixa").HeaderText = "Caixa"
                .Columns("fluxocaixa").Width = 80
                .Columns("fluxocaixa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Historico").HeaderText = "Historico"
                .Columns("Historico").Width = 150
                .Columns("Historico").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("LCategorias").HeaderText = "LCategorias"
                .Columns("LCategorias").Width = 100
                .Columns("LCategorias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Valor").HeaderText = "Valor"
                .Columns("Valor").DefaultCellStyle.Format = "C"
                .Columns("Valor").Width = 90
                .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Prazo").Visible = True
                .Columns("Prazo").HeaderText = "Prazo"
                .Columns("Prazo").Width = 70
                .Columns("Prazo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Parcela").HeaderText = "Parc"
                .Columns("Parcela").Width = 80
                .Columns("Parcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Vencimento").HeaderText = "Vencimento"
                .Columns("Vencimento").Width = 80
                .Columns("Vencimento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Consolidada").HeaderText = "Cons"
                .Columns("Consolidada").Width = 40
                .Columns("Consolidada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub ExibirCategoria()
        'Buscar o nome da categoria cadastrada
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "SELECT ID, LCategorias FROM Categorias GROUP BY ID, LCategorias ORDER BY LCategorias"
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                CboCategorias.ValueMember = "ID"
                CboCategorias.DisplayMember = "LCategorias"
                CboCategorias.DataSource = dt
                CboCategorias.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Falha6: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub BuscaCPF()
        'Buscar o n° do CPF da pessoa
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "SELECT * FROM Pessoal CPF"
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                cboCPF.ValueMember = "ID_Pessoal"
                cboCPF.DisplayMember = "CPF"
                cboCPF.DataSource = dt
                cboCPF.SelectedIndex = -1
                lblNome.Text = ""
                lblSobrenome.Text = ""
            End Using
        Catch ex As Exception
            MsgBox("Falha51: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub CboCPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCPF.SelectedIndexChanged
        BuscaNome()
        'BuscaDividaCartao()
    End Sub
    Private Sub BuscaNome()
        'Buscar o nome e o sobrenome da pessoa
        Dim con As OleDbConnection = Getconnection()
        Try
            Dim dr As OleDbDataReader = Nothing
            Using con
                con.Open()
                Dim sql As String = "SELECT * FROM Pessoal WHERE CPF='" & cboCPF.Text & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblNome.Text = dr.Item("Nome")
                    lblSobrenome.Text = dr.Item("Sobrenome")
                    cartao.Nome = dr.Item("Nome")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha8: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BuscaCartao()
        'Buscar o nome e o dia de vencimento do cartao
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "SELECT ID_Cartao, NCartao FROM Cartao where CPF = '" & cboCPF.Text & "' AND Status='Ativo' GROUP BY ID_Cartao, NCartao ORDER BY ID_Cartao Desc"
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                CboNCartao.ValueMember = "ID_Cartao"
                CboNCartao.DisplayMember = "NCartao"
                CboNCartao.DataSource = dt
                CboNCartao.SelectedIndex = -1
                lblCartao.Text = ""
                lblSaldo.Text = ""
            End Using
        Catch ex As Exception
            MsgBox("Falha52: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub CboCPF_LostFocus(sender As Object, e As EventArgs) Handles cboCPF.LostFocus
        'Fazendo uma pesquisa para buscar os dados do cartão por número
        BuscaCartao()
    End Sub
    Private Sub CboNCartao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNCartao.SelectedIndexChanged
        'Fazendo uma pesquisa para buscar os dados do cartão por número
        ExibirCartao()
        BuscaDividaCartao()
    End Sub
    Private Sub ExibirCartao()
        'Buscar o nome e o dia de vencimento do cartao
        Dim con As OleDbConnection = Getconnection()
        Try
            Dim dr As OleDbDataReader = Nothing
            Using con
                con.Open()
                Dim sql As String = "SELECT * FROM Cartao WHERE NCartao='" & CboNCartao.Text & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblCartao.Text = dr.Item("Cartao")
                    cartao.IdCartao = dr.Item("ID_Cartao")
                    cartao.Cartao = dr.Item("Cartao")
                    cartao.NuCartao = dr.Item("NCartao")
                    cartao.DonoCartao = lblNome.Text
                    cartao.Cpf = cboCPF.Text
                    caixa.Limite = dr.Item("Limite")
                    caixa.Divida = dr.Item("Divida")
                    cartao.DiaVenc = dr.Item("DiaVencimento")
                    caixa.SaldoLimite = dr.Item("Saldo")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha9: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        PLimpar()
        btnGerParc.Visible = True
        cboConsolidada.Text = "N"
        lblSaldo.Text = "0.00"
    End Sub
    Private Sub TxtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        If txtValor.Text < 0.00 Then
            caixa.Parc = FormatCurrency(txtValor.Text) 'Exibe o valor da movimentação
            txtValor.Text = FormatCurrency(txtValor.Text)
            caixa.CalculoLimitePagar()
            lblSaldo.Text = FormatCurrency(caixa.Credito)
        Else
            caixa.Parc = FormatCurrency(txtValor.Text * -1)  'Exibe o valor da movimentação
            txtValor.Text = FormatCurrency(txtValor.Text * -1)
            caixa.CalculoLimitePagar()
            lblSaldo.Text = FormatCurrency(caixa.Credito)
        End If
    End Sub
    Private Sub TxtValorPago_LostFocus(sender As Object, e As EventArgs) Handles txtValorPago.LostFocus
        Try
            If txtValorPago.Text > 0.00 Then
                caixa.ValorPago = FormatCurrency(txtValorPago.Text) 'Exibe o valor positivo
                caixa.CalculoLimitePagar()
                txtValorPago.Text = FormatCurrency(txtValorPago.Text)
                lblSaldo.Text = FormatCurrency(caixa.Credito)
            Else
                caixa.ValorPago = FormatCurrency(txtValorPago.Text * -1) 'Exibe o valor positivo
                caixa.CalculoLimitePagar()
                txtValorPago.Text = FormatCurrency(txtValorPago.Text * -1)
                lblSaldo.Text = FormatCurrency(caixa.Credito)
            End If
        Catch ix As InvalidCastException
            MsgBox("Erro: O campo não pode ser nulo!", vbInformation, Sistema)
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro no txtValor_LostFocus" & ex.Message, vbCritical, Sistema)
        Finally

        End Try
    End Sub
    Private Sub CboNParcelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNParcelas.SelectedIndexChanged
        'N° de parcelas para calculo
        caixa.Num = cboNParcelas.SelectedIndex + 1
    End Sub
    Private Sub BuscarCategoriaSai()
        'Seleciona os itens de saída ou despesas
        Try
            Using con As OleDbConnection = Getconnection()
                con.Open()
                Dim sql As String = "SELECT ID, LCategorias FROM Categorias where not LCategorias='Pagamento' or LCategorias='Estorno'"
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                CboCategorias.ValueMember = "ID"
                CboCategorias.DisplayMember = "LCategorias"
                CboCategorias.DataSource = dt
                CboCategorias.SelectedIndex = -1
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Falha BuscarCategoriaSai(): " & ex.Message, vbExclamation, Sistema)
        Finally

        End Try
    End Sub
    Private Sub BuscarCategoriaEnt()
        'Seleciona os itens de entrada ou receitas
        Try
            Using con As OleDbConnection = Getconnection()
                con.Open()
                Dim sql As String = "SELECT ID, LCategorias FROM Categorias where LCategorias='Pagamento' or LCategorias='Estorno' or LCategorias='Outros'"
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                CboCategorias.ValueMember = "ID"
                CboCategorias.DisplayMember = "LCategorias"
                CboCategorias.DataSource = dt
                CboCategorias.SelectedIndex = -1
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Falha BuscarCategoriaEnt(): " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub CboFluxo_LostFocus(sender As Object, e As EventArgs) Handles CboFluxo.LostFocus
        'Verifica se o fluxo é de saída ou despesas
        If CboFluxo.SelectedIndex = 0 Then
            txtValor.Visible = True
            cboNParcelas.Visible = True
            btnGerParc.Visible = True
            txtValorPago.Visible = False
            mskPagamento.Visible = False
            mskVencimento.Visible = True
            lblvpc.Visible = True
            lblvcpg.Visible = True
            lblnpc.Visible = True
            lblpg.Visible = False
            lbldtpg.Visible = False
            cboConsolidada.Text = "N"
            BuscarCategoriaSai()
            'Verifica se o fluxo é de entrada ou receitas
        ElseIf CboFluxo.SelectedIndex = 1 Then
            txtValor.Visible = False
            cboNParcelas.Visible = False
            btnGerParc.Visible = False
            txtValorPago.Visible = True
            mskPagamento.Visible = True
            mskVencimento.Visible = False
            lblvpc.Visible = False
            lblvcpg.Visible = False
            lblnpc.Visible = False
            lblpg.Visible = True
            lbldtpg.Visible = True
            cboConsolidada.Text = "S"
            BuscarCategoriaEnt()
        End If
    End Sub
    Private Sub BtnGerParc_Click(sender As Object, e As EventArgs) Handles btnGerParc.Click
        If Not IsDate(mskDataR.Text) Then
            MsgBox("Informe a data do registro.", vbCritical, Sistema)
            mskDataR.Focus()
            Exit Sub
        End If

        If cboCPF.Text <> "" And CboNCartao.Text <> "" Then
            'Se o nome do dono for diferente
            If cartao.DonoCartao <> lblNome.Text Then
                MsgBox("Este cartão não pertence a " & lblNome.Text & "," & Chr(13) & "favor selecionar um outro!", vbExclamation, Sistema)
                CboNCartao.Focus()
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        If txtValor.Text = "" Or txtValor.Text = "R$ 0.00" Then
            MsgBox("O campo 'Valor das Parcelas'" & Chr(13) & "não pode ser zero ou nulo!", vbCritical, "Erro!")
            Exit Sub
        End If
        Try
            'Calculo para o valor total da compra
            caixa.TotalCompra()

            caixa.CalculoLimiteComprar()
            lblSaldo.Text = FormatCurrency(caixa.Credito)

            ListBox1.Items.Add("")
            ListBox1.Items.Add("Compra(s) efetuada(s) no Cartão " & lblCartao.Text)
            ListBox1.Items.Add("no valor total de " & FormatCurrency(caixa.TotParc))

            cartao.DateInicial = mskDataR.Text 'Data de hoje/Data da compra
            cartao.MesInicial = Month(mskDataR.Text) 'Mês da data da compra
            cartao.AnoInicial = Year(mskDataR.Text) 'Ano da data da compra

            cartao.CalcularData()
            mskVencimento.Text = cartao.NovaData
            mskVencimento.Enabled = True

        Catch ax As InvalidCastException
            MsgBox("Falha InvalidCastException " & ax.Message, vbInformation, Sistema)
        Catch ex As Exception
            MsgBox("Falha12: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If ValidarForm() Then
                SalvarUsuario()
            End If
        Catch ex As Exception
            MsgBox("Erro no btnSalvar: " & ex.Message, vbCritical, Sistema)
        Finally

        End Try
    End Sub
    Private Function ValidarForm() As Boolean
        Try
            Dim result As Boolean
            If Not IsDate(mskDataR.Text) Then
                MsgBox("Informe a data do registro.", vbCritical, Sistema)
                mskDataR.Focus()
                result = False
            ElseIf cboCPF.Text = "" Then
                MsgBox("Informe o número do CPF.", vbCritical, Sistema)
                cboCPF.Focus()
                result = False
            ElseIf CboNCartao.Text = "" Then
                MsgBox("Informe o número do cartão.", vbCritical, Sistema)
                CboNCartao.Focus()
                result = False
            ElseIf lblCartao.Text = "" Then
                MsgBox("Informe o nome do cartão.", vbCritical, Sistema)
                lblCartao.Focus()
                result = False
            ElseIf txtHistorico.Text = "" Then
                MsgBox("Informe o histórico da compra.", vbCritical, Sistema)
                txtHistorico.Focus()
                result = False
            ElseIf CboFluxo.Text = "" Or CboFluxo.SelectedIndex = -1 Then
                MsgBox("Informe o fluxo do cartão.", vbCritical, Sistema)
                CboFluxo.Focus()
                result = False
            ElseIf CboCategorias.Text = "" Or CboCategorias.SelectedIndex = -1 Then
                MsgBox("Informe a categoria da compra.", vbCritical, Sistema)
                CboCategorias.Focus()
                result = False
            ElseIf txtValor.Text = "" Then
                MsgBox("Informe o valor da parcela.", vbCritical, Sistema)
                txtValor.Focus()
                result = False
            ElseIf cboNParcelas.Text = "" And CboFluxo.SelectedIndex = 0 Then
                MsgBox("Informe a quntidade de parcelas.", vbCritical, Sistema)
                cboNParcelas.Focus()
                result = False
            ElseIf mskVencimento.Text = "" And CboFluxo.SelectedIndex = 0 Then
                MsgBox("Click no botão 'Gerar' para obter" & Chr(13) & "a data da primeira parcela!", vbInformation, Sistema)
                mskVencimento.Focus()
                result = False
            ElseIf mskPagamento.Text = "" And CboFluxo.SelectedIndex = 1 Then
                MsgBox("Informe a data do pagamento.", vbCritical, Sistema)
                mskPagamento.Focus()
                result = False
            Else
                mskVencimento.TextMaskFormat = MaskFormat.IncludeLiterals
                result = True
            End If
            Return result
        Catch ex As Exception
            MsgBox("Erro no ValidarForm: " & ex.Message, vbCritical, Sistema)
        Finally
            mskVencimento.Enabled = False
        End Try
    End Function
    Private Sub SalvarUsuario()
        Dim DtVenc As Date 'Data de Vencimento
        Dim DtEfet As String 'Data de Vencimento
        Dim parcelas(caixa.Num) As String 'Mostra o numero de parcelas QtdParc
        Dim sql As String
        Try
            If CLng(0 & lblIdCartaoMov.Text) <= 0 And CboFluxo.SelectedIndex = 0 Then
                Dim msg As String
                caixa.Comprar()
                'Verifica o limite do cartão
                If caixa.Credito > 0 Then
                    MsgBox("Compra(s) regeitada(s) por falta de crédito!", vbInformation, "Saldo Insuficiente!")
                    Exit Try
                End If
                DtEfet = DateAdd("m", -1, mskVencimento.Text)
                sql = "INSERT INTO CartaoMov(ID_Cartao, DataRegistro, CPF, Cartao, NCartao, FluxoCaixa, Historico, LCategorias, Valor, Prazo, Parcela, Vencimento, Consolidada) Values (@ID_Cartao, @DataRegistro, @CPF, @Cartao, @NCartao,  @FluxoCaixa, @Historico, @LCategorias, @Valor, @Prazo, @Parcela, @Vencimento, @Consolidada)"
                ListBox1.Items.Add("")
                ListBox1.Items.Add("Resumo:")
                ListBox1.Items.Add("Cartão     " & "Parc.    " & "Vencimento       " & "Dívida")
                For i = 1 To caixa.Num 'N° de parcelas para calculo QtdParc
                    DtVenc = DateAdd("m", i, DtEfet) 'Data efetiva de registro
                    parcelas(i) = i & "/" & caixa.Num
                    Using cn = New OleDbConnection(conn)
                        cn.Open()
                        Using cmd = New OleDbCommand(sql, cn)
                            cmd.Parameters.AddWithValue("@ID_Cartao", cartao.IdCartao)
                            cmd.Parameters.AddWithValue("@DataRegistro", mskDataR.Text)
                            cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                            cmd.Parameters.AddWithValue("@Cartao", lblCartao.Text)
                            cmd.Parameters.AddWithValue("@NCartao", CboNCartao.Text)
                            cmd.Parameters.AddWithValue("@FluxoCaixa", CboFluxo.Text)
                            cmd.Parameters.AddWithValue("@Historico", txtHistorico.Text)
                            cmd.Parameters.AddWithValue("@LCategorias", CboCategorias.Text)
                            cmd.Parameters.AddWithValue("@Valor", txtValor.Text) '* -1
                            cmd.Parameters.AddWithValue("@Prazo", cboNParcelas.Text)
                            cmd.Parameters.AddWithValue("@Parcela", parcelas(i))
                            cmd.Parameters.AddWithValue("@Vencimento", DtVenc)
                            cmd.Parameters.AddWithValue("@Consolidada", "N")
                            cmd.ExecuteNonQuery()
                            ListBox1.Items.Add(lblCartao.Text & "     " & i & "/" & caixa.Num & "       " & DtVenc & "       " & FormatCurrency(caixa.Parc))
                        End Using
                        cn.Close()
                    End Using
                Next
                msg = MsgBox("Cadastro incluido com sucesso!" & vbNewLine & "Deseja cadastrar novamente?" & vbNewLine & "Sim - Continuar Não - Fechar cadastro", vbYesNo + vbInformation, "Novo!")
                If msg = vbYes Then
                    NovoRegistro()
                Else
                    MostrarTodosUsuarios()
                    PLimpar()
                End If
                'Atualiza o saldo de limite do cartão
                sql = ("UPDATE Cartao Set Divida=@Divida where ID_Cartao=" & cartao.IdCartao)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Divida", FormatCurrency(caixa.Divida))
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            ElseIf CLng(0 & lblIdCartaoMov.Text) <= 0 And CboFluxo.SelectedIndex = 1 Then
                Dim msg As String
                caixa.Pagar()
                'Verifica o limite do cartão
                If caixa.SaldoLimite > caixa.Limite Then
                    MsgBox("Limite do cartão ultrapassado!", vbInformation, "Valor excedente!")
                    Exit Try
                End If
                sql = "INSERT INTO CartaoMov(ID_Cartao, DataRegistro, CPF, Cartao, NCartao, FluxoCaixa, Historico, LCategorias, Prazo, Parcela, Vencimento, Valor, Consolidada) Values (@ID_Cartao, @DataRegistro, @CPF, @Cartao, @NCartao,  @FluxoCaixa, @Historico, @LCategorias, @Prazo, @Parcela, @Vencimento, @Valor, @Consolidada)"
                ListBox1.Items.Add("")
                ListBox1.Items.Add("Pagto. da fatura do Cartão " & lblCartao.Text & " de " & FormatCurrency(caixa.ValorPago))
                ListBox1.Items.Add("Data do Pagto. em " & mskPagamento.Text)
                ListBox1.Items.Add("")
                ListBox1.Items.Add("Resumo:")
                ListBox1.Items.Add("Cartão     " & "Valor Pago    " & "Data Pagto.")
                ListBox1.Items.Add(lblCartao.Text & "     " & FormatCurrency(caixa.ValorPago) & "       " & mskPagamento.Text)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@ID_Cartao", cartao.IdCartao)
                        cmd.Parameters.AddWithValue("@DataRegistro", mskDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Cartao", lblCartao.Text)
                        cmd.Parameters.AddWithValue("@NCartao", CboNCartao.Text)
                        cmd.Parameters.AddWithValue("@FluxoCaixa", CboFluxo.Text)
                        cmd.Parameters.AddWithValue("@Historico", txtHistorico.Text)
                        cmd.Parameters.AddWithValue("@LCategorias", CboCategorias.Text)
                        cmd.Parameters.AddWithValue("@Prazo", "-")
                        cmd.Parameters.AddWithValue("@Parcela", "-")
                        cmd.Parameters.AddWithValue("@Vencimento", mskPagamento.Text)
                        cmd.Parameters.AddWithValue("@Valor", caixa.ValorPago)
                        cmd.Parameters.AddWithValue("@Consolidada", "S")
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
                msg = MsgBox("Cadastro incluido com sucesso!" & vbNewLine & "Deseja cadastrar novamente?" & vbNewLine & "Sim - Continuar Não - Fechar cadastro", vbYesNo + vbInformation, "Novo!")
                If msg = vbYes Then
                    NovoRegistro()
                Else
                    MostrarTodosUsuarios()
                    PLimpar()
                End If
                'Atualiza o saldo de limite do cartão
                sql = ("UPDATE Cartao set Divida=@Divida where ID_Cartao=" & cartao.IdCartao)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Divida", FormatCurrency(caixa.Divida))
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            End If
        Catch ex As Exception
            MsgBox("Erro no SalvarUsuario: " & ex.Message, vbExclamation, Sistema)
        Finally
            Using cn = New OleDbConnection(conn)
                cn.Close()
            End Using
        End Try
    End Sub
    Private Sub NovoRegistro()
        CboFluxo.SelectedIndex = -1
        txtHistorico.Clear()
        CboCategorias.SelectedIndex = -1
        txtValorPago.Text = "0.00"
        mskPagamento.Clear()
        txtValor.Text = "0.00"
        mskVencimento.Clear()
        cboNParcelas.SelectedIndex = -1
    End Sub

End Class
