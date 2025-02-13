Imports System.Data.OleDb

Public Class CartoesMasters
    Dim cartao As New ClassCartao
    Dim caixa As New ConfigCartao
    Private Sub CartaoConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub CartaoConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub

    Private Sub CartaoConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        Try
            txtDataR.Text = Today
            MostrarUsuarios()
            ConfigurarGrade()
        Catch ex As Exception
            MsgBox("Falha em Load: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub

    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                DataGridView1.Columns("ID_Cartao").Visible = False
                .Columns("ID_Cartao").Width = 40
                .Columns("ID_Cartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DataRegistro").HeaderText = "Data"
                .Columns("DataRegistro").Width = 80
                .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("CPF").Visible = False
                .Columns("CPF").HeaderText = "CPF"
                .Columns("CPF").Width = 90
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Instituicao").Visible = True
                .Columns("Instituicao").HeaderText = "Instituição"
                .Columns("Instituicao").Width = 90
                .Columns("Instituicao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Cartao").HeaderText = "Cartão"
                .Columns("Cartao").Width = 70
                .Columns("Cartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("NCartao").HeaderText = "Número"
                .Columns("NCartao").Width = 110
                .Columns("NCartao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Status").HeaderText = "Status"
                .Columns("Status").Width = 50
                .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Limite").HeaderText = "Limites"
                .Columns("Limite").DefaultCellStyle.Format = "C"
                .Columns("Limite").Width = 80
                .Columns("Limite").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("DiaFechamento").Visible = True
                .Columns("DiaFechamento").HeaderText = "D.Fech."
                .Columns("DiaFechamento").Width = 50
                .Columns("DiaFechamento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DiaVencimento").HeaderText = "D.Venc."
                .Columns("DiaVencimento").Width = 50
                .Columns("DiaVencimento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Senha").HeaderText = "Senha"
                .Columns("Senha").Width = 60
                .Columns("Senha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Validade").HeaderText = "Validade"
                .Columns("Validade").Width = 60
                .Columns("Validade").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("CodSeguranca").HeaderText = "Cód"
                .Columns("CodSeguranca").Width = 50
                .Columns("CodSeguranca").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Saldo").HeaderText = "Saldo Restante"
                .Columns("Saldo").DefaultCellStyle.Format = "C"
                .Columns("Saldo").Width = 80
                .Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Catch ex As Exception
            MsgBox("Falha: 1" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub MostrarUsuarios()
        Dim sql = "select cartao.ID_Cartao, cartao.DataRegistro,Pessoal.Nome, Pessoal.CPF, cartao.Instituicao,  cartao.Cartao, cartao.NCartao, cartao.Status, cartao.Limite, cartao.DiaFechamento, cartao.DiaVencimento, cartao.Senha, cartao.Validade, cartao.CodSeguranca, cartao.Saldo FROM Cartao Inner Join Pessoal on Pessoal.cpf=cartao.cpf where cartao.Status='Ativo' Order by cartao.id_Cartao desc"
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            'Verifica se tem registro
            If DataGridView1.Rows.Count = 0 Then
                MsgBox("Não existe registro no banco de dados!", vbInformation, "Banco de dados vazio!")
            Else
                DataGridView1.Rows(0).Selected = False
                DataGridView1.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox("Falha: 2" & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Instanciar o modulo geral
        VerificarItem(Me, e, DataGridView1)
    End Sub
    Private Sub SelecionarTudo()
        Try
            Dim row As New DataGridViewRow()
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                row = DataGridView1.Rows(i)
                DataGridView1.Rows(i).Cells(0).Value = 1
                i += 1
            End While
        Catch ex As Exception
            MsgBox("Não há registro para exluir!", vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If chkPass.Checked = False Then
            If e.ColumnIndex = 12 Or e.ColumnIndex = 14 Then
                If e.Value IsNot Nothing Then
                    e.Value = New String("*", e.Value.ToString().Length)
                End If
            End If
        End If
    End Sub

    Private Sub ChkPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPass.CheckedChanged
        'Exibir as senhas do cadastro
        If pAdministrador Then
            MostrarUsuarios()
        End If
    End Sub

    Private Function Getlivros(ByVal filtro As String) As DataTable
        Dim sql = ""
        If CbCampos.Text = "Nome" Then
            sql = "select cartao.ID_Cartao, cartao.DataRegistro,Pessoal.Nome, Pessoal.CPF, cartao.Instituicao,  cartao.Cartao, cartao.ncartao, cartao.Status, cartao.Limite, cartao.DiaFechamento, cartao.DiaVencimento, cartao.Senha, cartao.Validade, cartao.CodSeguranca FROM Cartao inner join Pessoal on Pessoal.cpf=cartao.cpf where cartao.Status <> 'Cancelado' and Pessoal.Nome LIKE  '%" & TxtProcurar.Text & "%' Order by cartao.id_Cartao desc"
        ElseIf CbCampos.Text = "Cartão" Then
            sql = "select cartao.ID_Cartao, cartao.DataRegistro,Pessoal.Nome, Pessoal.CPF, cartao.Instituicao,  cartao.Cartao, cartao.ncartao, cartao.Status, cartao.Limite, cartao.DiaFechamento, cartao.DiaVencimento, cartao.Senha, cartao.Validade, cartao.CodSeguranca FROM Cartao inner join Pessoal on Pessoal.cpf=cartao.cpf where cartao.Status <> 'Cancelado' and cartao.Cartao LIKE  '%" & TxtProcurar.Text & "%' Order by cartao.id_Cartao desc"
        ElseIf CbCampos.Text = "Status" Then
            sql = "select cartao.ID_Cartao, cartao.DataRegistro,Pessoal.Nome, Pessoal.CPF, cartao.Instituicao,  cartao.Cartao, cartao.ncartao, cartao.Status, cartao.Limite, cartao.DiaFechamento, cartao.DiaVencimento, cartao.Senha, cartao.Validade, cartao.CodSeguranca FROM Cartao inner join Pessoal on Pessoal.cpf=cartao.cpf where cartao.Status LIKE  '%" & TxtProcurar.Text & "%' Order by cartao.id_Cartao desc"
        ElseIf CbCampos.Text = "Instituição" Then
            sql = "select cartao.ID_Cartao, cartao.DataRegistro,Pessoal.Nome, Pessoal.CPF, cartao.Instituicao,  cartao.Cartao, cartao.ncartao, cartao.Status, cartao.Limite, cartao.DiaFechamento, cartao.DiaVencimento, cartao.Senha, cartao.Validade, cartao.CodSeguranca FROM Cartao inner join Pessoal on Pessoal.cpf=cartao.cpf where cartao.Status <> 'Cancelado' and cartao.Instituicao LIKE  '%" & TxtProcurar.Text & "%' Order by cartao.id_Cartao desc"
        End If
        Dim dt As New DataTable
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using da = New OleDbDataAdapter(sql, cn)
                    da.Fill(dt)

                End Using
            End Using
            CbCampos.SelectedIndex = -1
            TxtProcurar.Clear()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
        Return dt
    End Function

    Private Sub CbCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCampos.SelectedIndexChanged
        TxtProcurar.ReadOnly = False
        TxtProcurar.Enabled = True
        TxtProcurar.Focus()
    End Sub

    Private Sub TxtProcurar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProcurar.TextChanged
        BtnBuscar.Enabled = True
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Se os campos de pesquisas estiverem nulos, não fazer nada
        If CbCampos.Text = "" Or TxtProcurar.Text = "" Then
            If result = True Then
                If pAdministrador Then
                    PCarregaDados()
                    PCarregaDados1()
                    MostrarUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Cartao").Value)
                    CboStatus.Enabled = True
                    CboTipo.Enabled = True
                    txtSenCartao.Enabled = True
                    txtCSeg.Enabled = True
                    txtSenCartao.PasswordChar = ("")
                    txtCSeg.PasswordChar = ("")
                    lblSaldo.Enabled = True
                    Exit Sub
                End If
                If pAcessoPermitido Then
                    PCarregaDados()
                    PCarregaDados1()
                    MostrarUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Cartao").Value)
                    'Bloqueia o formulário se o cartão estiver como cancelado
                    If (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Status").Value) = "Cancelado" Then
                        BloquearControles()
                    Else
                        DesbloquearControles()
                    End If
                    txtSenCartao.Enabled = False
                    txtCSeg.Enabled = False
                    txtSenCartao.PasswordChar = ("*")
                    txtCSeg.PasswordChar = ("*")
                Else
                    MsgBox("Acesso não permitido!", vbInformation, "Logoff")
                    PLimpar()
                End If
            Else
                If pAcessoPermitido Then
                    MsgBox("Selecione um item da lista!", vbExclamation, Sistema)
                End If
            End If
        Else
            DataGridView1.DataSource = Getlivros(TxtProcurar.Text)
            If DataGridView1.Rows.Count > 0 Then
                ConfigurarGrade()
            ElseIf DataGridView1.Rows.Count = 0 Then
                MsgBox("Nenhum item foi encontrado!", vbInformation, Sistema)
            End If
        End If
    End Sub
    Private Sub BloquearControles()
        For Each controle As Control In Me.Controls
            If TypeOf controle Is TextBox Then
                Dim txt As TextBox = TryCast(controle, TextBox)
                txt.ReadOnly = True
            End If
            If TypeOf controle Is ComboBox Then
                Dim cbo As ComboBox = TryCast(controle, ComboBox)
                cbo.Enabled = False
            End If
            If TypeOf controle Is MaskedTextBox Then
                Dim msk As MaskedTextBox = TryCast(controle, MaskedTextBox)
                msk.ReadOnly = True
            End If
        Next
        CbCampos.Enabled = True
    End Sub
    Private Sub DesbloquearControles()
        For Each controle As Control In Me.Controls
            If TypeOf controle Is TextBox Then
                Dim txt As TextBox = TryCast(controle, TextBox)
                txt.ReadOnly = False
            End If
            If TypeOf controle Is ComboBox Then
                Dim cbo As ComboBox = TryCast(controle, ComboBox)
                cbo.Enabled = True
            End If
            If TypeOf controle Is MaskedTextBox Then
                Dim msk As MaskedTextBox = TryCast(controle, MaskedTextBox)
                msk.ReadOnly = False
            End If
        Next
    End Sub
    Private Sub MostrarUsuario(ByVal id As Long)
        Dim sql = "Select * from Cartao where id_Cartao=" & id
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id_Cartao", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblId.Text = dr("ID_Cartao")
                                lblIdAgencias.Text = dr("ID_Agencias")
                                txtDataR.Text = dr("DataRegistro")
                                cboCPF.Text = dr("CPF")
                                cboInst.Text = dr("Instituicao")
                                lblNBan.Text = dr("NBanco")
                                txtCartao.Text = dr("Cartao")
                                mskNCartao.Text = dr("NCartao")
                                CboTipo.Text = dr("Tipo")
                                CboStatus.Text = dr("Status")
                                txtLimite.Text = FormatCurrency(dr("Limite"))
                                txtDiaFecha.Text = dr("DiaFechamento")
                                txtDiaVenc.Text = dr("DiaVencimento")
                                txtSenCartao.Text = dr("Senha")
                                mskValidade.Text = dr("Validade")
                                txtCSeg.Text = dr("CodSeguranca")
                                lblSaldo.Text = FormatCurrency(dr("Divida"))
                                cartao.Divida = dr("Saldo")
                            End If
                        End If
                    End Using
                End Using
            End Using
            cartao.Nome = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Nome").Value)
            cartao.Cartao = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Cartao").Value)
            cartao.Limite = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Limite").Value)
        Catch ix As InvalidCastException
            MsgBox("Falha: existe campo(s) nulo(s) ou vazio(s)", vbInformation, Sistema)
        Catch ex As Exception
            MsgBox("Falha em MostrarUsuario: " & ex.Message, vbCritical, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub PCarregaDados()
        Dim sql As String = "SELECT * FROM Pessoal CPF"
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                cboCPF.ValueMember = "ID_Pessoal"
                cboCPF.DisplayMember = "CPF"
                cboCPF.DataSource = dt
                lblNome.Text = ""
                lblSobrenome.Text = ""
                cboCPF.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim Resp As Boolean
        Try
            If ValidarForm(result) Then
                If ValidarCartao(result) Then
                    SalvarUsuario(lblId.Text, Resp)
                End If
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Function ValidarCartao(ByVal result As Boolean)
        Dim sql = "select * from Cartao where NCartao=@NCartao"
        Dim cn = New OleDbConnection(conn)
        Try
            If lblId.Text = Nothing Or lblId.Text = "" Then
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@NCartao", mskNCartao.Text)
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows = True Then
                                MsgBox("O Cartão já existe no sistema!", vbInformation, "Falha no cadastro!")
                                mskNCartao.Focus()
                                result = False
                            ElseIf dr.HasRows = False Then
                                result = True
                            End If
                        End Using
                    End Using
                End Using
            Else
                result = True
            End If
        Catch ex As Exception
            MsgBox("Falha1: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
        Return result
    End Function
    Private Function ValidarForm(ByVal result As Boolean) As Boolean
        mskValidade.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        Try
            If cboCPF.Text = "" Then
                result = False
                Exit Try
            End If
            If txtDataR.Text = "" Then
                MsgBox("Informe a data do registro.", vbExclamation, Sistema)
                txtDataR.Focus()
                result = False
            ElseIf cboInst.Text = "" Then
                MsgBox("Informe a Instituição/Banco.", vbExclamation, Sistema)
                cboInst.Focus()
                result = False
            ElseIf txtCartao.Text = "" Then
                MsgBox("Informe o nome do cartão.", vbExclamation, Sistema)
                txtCartao.Focus()
                result = False
            ElseIf mskNCartao.Text = "" Then
                MsgBox("Informe o número do cartão.", vbExclamation, Sistema)
                mskNCartao.Focus()
                result = False
            ElseIf txtLimite.Text = Nothing Then
                MsgBox("Informe o limite do cartão.", vbExclamation, Sistema)
                txtLimite.Focus()
                result = False
            ElseIf txtDiaFecha.Text = Nothing Then
                MsgBox("Informe o dia do fechamento do cartão.", vbExclamation, Sistema)
                txtDiaFecha.Focus()
                result = False
            ElseIf txtDiaFecha.Text < 1 Or txtDiaFecha.Text > 31 Then
                MsgBox("O dia do fechamento esta incorreto!", vbExclamation, Sistema)
                txtDiaFecha.Text = ""
                txtDiaFecha.Focus()
                result = False
            ElseIf txtDiaVenc.Text = Nothing Then
                MsgBox("Informe o dia do vencimento do cartão.", vbExclamation, Sistema)
                txtDiaVenc.Focus()
                result = False
            ElseIf txtDiaVenc.Text < 1 Or txtDiaVenc.Text > 31 Then
                MsgBox("O dia do vencimento do cartão esta incorreto!", vbExclamation, Sistema)
                txtDiaVenc.Text = ""
                txtDiaVenc.Focus()
                result = False
            ElseIf txtSenCartao.Text = "" Then
                MsgBox("Informe a senha do cartão.", vbExclamation, Sistema)
                txtSenCartao.Focus()
                result = False
            ElseIf mskValidade.Text = "" Then
                MsgBox("Informe a validade do cartao.", vbExclamation, Sistema)
                mskValidade.Focus()
                result = False
            ElseIf txtCSeg.Text = "" Then
                MsgBox("Informe o cód de segurança.", vbExclamation, Sistema)
                txtCSeg.Focus()
                result = False
            Else
                result = True
            End If
            Return result
        Catch ex As Exception
            MsgBox("Falha ValidarForm : " & ex.Message, vbExclamation, Sistema)
        Finally
            mskValidade.TextMaskFormat = MaskFormat.IncludeLiterals
        End Try
    End Function
    Private Sub SalvarUsuario(ByVal ID As String, ByVal Resp As Boolean)
        Dim sql As String
        If CLng(0 & ID) = 0 Then
            sql = "INSERT INTO Cartao(Id_Agencias, DataRegistro, CPF, Instituicao, NBanco, Cartao, NCartao, Tipo, Status, Limite, DiaFechamento, DiaVencimento, Senha, Validade, CodSeguranca) Values (@IdAgencias, @DataRegistro, @CPF, @Instituicao, @NBanco, @Cartao, @NCartao, @Tipo, @Status, @Limite, @DiaFechamento, @DiaVencimento, @Senha, @Validade, @CodSeguranca)"
            Resp = True
        Else
            sql = ("UPDATE Cartao SET  Id_Agencias=@Id_Agencias, DataRegistro=@DataRegistro, CPF=@CPF, Instituicao=@Instituicao, NBanco=@NBanco, Cartao=@Cartao, NCartao=@NCartao, Tipo=@Tipo, Status=@Status, Limite=@Limite, DiaFechamento=@DiaFechamento, DiaVencimento=@DiaVencimento, Senha=@Senha, Validade=@Validade, CodSeguranca=@CodSeguranca WHERE ID_Cartao =" & ID)
            Resp = False
        End If
        MostrarIDAgencias(pIDCan)
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Id_Agencias", lblIdAgencias.Text)
                    cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                    cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                    cmd.Parameters.AddWithValue("@Instituicao", cboInst.Text)
                    cmd.Parameters.AddWithValue("@NBanco", lblNBan.Text)
                    cmd.Parameters.AddWithValue("@Cartao", txtCartao.Text)
                    cmd.Parameters.AddWithValue("@NCartao", mskNCartao.Text)
                    cmd.Parameters.AddWithValue("@Tipo", CboTipo.Text)
                    cmd.Parameters.AddWithValue("@Status", CboStatus.Text)
                    cmd.Parameters.AddWithValue("@Limite", txtLimite.Text)
                    cmd.Parameters.AddWithValue("@DiaFechamento", txtDiaFecha.Text)
                    cmd.Parameters.AddWithValue("@DiaVencimento", txtDiaVenc.Text)
                    cmd.Parameters.AddWithValue("@Senha", txtSenCartao.Text)
                    cmd.Parameters.AddWithValue("@Validade", mskValidade.Text)
                    cmd.Parameters.AddWithValue("@CodSeguranca", txtCSeg.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            If Resp = True Then
                MsgNovo()
            ElseIf Resp = False Then
                MsgAtualizado()
            End If
            PLimpar()
            MostrarUsuarios()
        Catch ex As Exception
            MsgBox("Falha em SalvarUsuario: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub MostrarIDAgencias(ByVal id As Long)
        Dim sql = "Select * from Agencias where Instituicao='" & cboInst.Text & "'"
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id_Agencias", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblIdAgencias.Text = dr("id_Agencias")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha em MostrarIDAgencias: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        PLimpar()
        MostrarUsuarios()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            'Verifica se o item esta selecionado corretamente
            If result = False Then
                MsgBox("Item não selecionado!", vbCritical, "Erro!")
                Exit Sub
            ElseIf result = True And lblId.Text = "" Then
                MsgBox("Click no botão de Buscar" & vbNewLine & "para efetuar a pesquisa!", vbCritical, "Atenção!")
                Exit Sub
            ElseIf result = True And DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Cartao").Value <> lblId.Text Then
                MsgBox("Item selecionado está incorreto!", vbCritical, "Erro!")
                Exit Sub
            End If
            If lblId.Text <> "" Then
                ExcluirRegistros(lblId.Text)
            ElseIf lblId.Text = "" Then
                MsgBox("Selecione um item da lista e" & vbNewLine & "click no botão de 'Buscar'" & vbNewLine & "antes de fazer a exclusão!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha Excluir: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub ExcluirRegistros(ByVal id As String)
        Dim sql = ("Delete from Cartao where id_Cartao =" & id)
        Dim cn = New OleDbConnection(conn)
        Dim resultado As String
        Try
            resultado = MsgBox("ATENÇÃO!" + Chr(10) + "A exclusão deste item, pode ter um efeito cascata!" + Chr(10) + "" + Chr(10) + "Tem certeza que deseja excluir o " & cartao.Cartao & " de " & cartao.Nome & "?", vbYesNo + vbCritical, "Exclusão de registro do sistema!")
            If resultado = vbYes Then
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@ID_Agencias", lblIdAgencias.Text)
                        cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Instituicao", cboInst.Text)
                        cmd.Parameters.AddWithValue("@NBanco", lblNBan.Text)
                        cmd.Parameters.AddWithValue("@Cartao", txtCartao.Text)
                        cmd.Parameters.AddWithValue("@NCartao", mskNCartao.Text)
                        cmd.Parameters.AddWithValue("@Tipo", CboTipo.Text)
                        cmd.Parameters.AddWithValue("@Status", CboStatus.Text)
                        cmd.Parameters.AddWithValue("@Limite", txtLimite.Text)
                        cmd.Parameters.AddWithValue("@DiaFechamento", txtDiaFecha.Text)
                        cmd.Parameters.AddWithValue("@DiaVencimento", txtDiaVenc.Text)
                        cmd.Parameters.AddWithValue("@Senha", txtSenCartao.Text)
                        cmd.Parameters.AddWithValue("@Validade", mskValidade.Text)
                        cmd.Parameters.AddWithValue("@CodSeguranca", txtCSeg.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MsgExclusao()
            Else
                MsgNaoExclusao()
            End If
            PLimpar()
            MostrarUsuarios()
        Catch ex As Exception
            MsgBox("Falha em ExcluirRegistros: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CboCPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCPF.SelectedIndexChanged
        Try
            PleDados()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub
    Private Sub PleDados()
        Dim dr As OleDbDataReader = Nothing
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim sql As String = "SELECT * FROM Pessoal WHERE CPF='" & cboCPF.Text & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblNome.Text = dr.Item("Nome")
                    lblSobrenome.Text = dr.Item("Sobrenome")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CboCPF_GotFocus(sender As Object, e As EventArgs) Handles cboCPF.GotFocus
        PCarregaDados()
    End Sub

    Private Sub CboInst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInst.SelectedIndexChanged
        Try
            PleDados1()
        Catch ex As Exception
            MsgBox("Falha em CboInst.SelectedIndexChanged_1: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub
    Private Sub PleDados1()
        Dim sql = "Select * from Agencias where Instituicao='" & cboInst.Text & "'"
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id_Agencias", lblIdAgencias.Text)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read Then
                                lblNBan.Text = dr.Item("NBanco")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha em PleDados1: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CboInst_GotFocus(sender As Object, e As EventArgs) Handles cboInst.GotFocus
        'Faz uma pesquisa de Cartões cadastrados
        PCarregaDados1()
    End Sub
    Private Sub PCarregaDados1()
        Dim sql As String = "SELECT Instituicao FROM Agencias where Instituicao GROUP BY Instituicao"
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                cboInst.ValueMember = "ID_Agencias"
                cboInst.DisplayMember = "Instituicao"
                cboInst.DataSource = dt
                lblNBan.Text = ""
                cboInst.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Falha em PCarregaDados1: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TxtCartao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCartao.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNCartao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDiaFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaFecha.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDiaVenc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaVenc.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCSeg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCSeg.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLimite_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimite.LostFocus
        Try
            If Not txtLimite.Text = Nothing Then
                If txtLimite.Text > 1 Then
                    txtLimite.Text = FormatCurrency(txtLimite.Text)
                ElseIf txtLimite.Text <= 0 Then
                    txtLimite.Text = FormatCurrency(txtLimite.Text)
                End If

            End If
        Catch ex As Exception
            MsgBox("Falha em TxtLimite.LostFocus: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub

    Private Sub TxtLimite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLimite.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSenCartao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenCartao.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CbCampos_Click(sender As Object, e As EventArgs) Handles CbCampos.Click
        PLimpar()
        MostrarUsuarios()
    End Sub

End Class