Imports System.Data.OleDb
Public Class AgenciasMasters
    Dim agencia As New ClassAgencias
    Private Sub AgenciasConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        FrmPrincipal.MenuStrip1.Enabled = False 'Desativa o submenu
    End Sub

    Private Sub AgenciasConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmPrincipal.MenuStrip1.Enabled = True 'Ativa o submenu
    End Sub

    Private Sub AgenciasConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        LblDataR.Text = Today
        MostrarPesqUsuarios()
        ConfigurarGrade()
    End Sub

    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                DataGridView1.Columns("ID_Agencias").Visible = False
                .Columns("ID_Agencias").Width = 30
                .Columns("ID_Agencias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DataRegistro").HeaderText = "Data"
                .Columns("DataRegistro").Width = 80
                .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Nome").HeaderText = "Nome"
                .Columns("Nome").Width = 80

                .Columns("CPF").HeaderText = "CPF"
                .Columns("CPF").Width = 100
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Instituicao").HeaderText = "Instituição"
                .Columns("Instituicao").Width = 120
                .Columns("Instituicao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("ContaCorrente").HeaderText = "Conta Corrente"
                .Columns("ContaCorrente").Width = 100
                .Columns("ContaCorrente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("LoginUsuario").HeaderText = "Login"
                .Columns("LoginUsuario").Width = 80
                .Columns("LoginUsuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Senha").HeaderText = "Senha"
                .Columns("Senha").Width = 80
                .Columns("Senha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("CodigoAcesso").HeaderText = "Cód. Acesso"
                .Columns("CodigoAcesso").Width = 80
                .Columns("CodigoAcesso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("EmailCadastro").HeaderText = "Email de Cadastro"
                .Columns("EmailCadastro").Width = 200
                .Columns("EmailCadastro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            End With
        Catch ex As Exception
            MsgBox("Falha: 1" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub MostrarPesqUsuarios()
        Dim sql = "select Agencias.ID_Agencias, Agencias.DataRegistro, Pessoal.Nome, Pessoal.CPF, Agencias.Instituicao, Agencias.ContaCorrente, Agencias.LoginUsuario, Agencias.Senha, Agencias.CodigoAcesso, Agencias.EmailCadastro FROM Agencias inner join Pessoal on Pessoal.cpf=Agencias.cpf Order by Agencias.ID_Agencias desc"
        'Conexão geral do Sistema
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
            MsgBox("Falha:2 " & ex.Message, vbExclamation, Sistema)
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
    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If chkPass.Checked = False Then
            If e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
                If e.Value IsNot Nothing Then
                    e.Value = New String("*", e.Value.ToString().Length)
                End If
            End If
        End If
    End Sub

    Private Sub ChkPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPass.CheckedChanged
        'Exibir as senhas do cadastro
        If pAdministrador Then
            MostrarPesqUsuarios()
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Se os campos de pesquisas estiverem nulos, não fazer nada
        If CbCampos.Text = "" Or TxtProcurar.Text = "" Then
            If result = True Then
                If pAdministrador Then
                    PCarregaDados()
                    PCarregaDados1()
                    MostrarUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Agencias").Value)
                    txtCAcesso.Enabled = True
                    txtSenB.Enabled = True
                    txtCAcesso.PasswordChar = ("")
                    txtSenB.PasswordChar = ("")
                    Exit Sub
                End If
                If pAcessoPermitido Then
                    PCarregaDados()
                    PCarregaDados1()
                    MostrarUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Agencias").Value)
                    txtCAcesso.Enabled = False
                    txtSenB.Enabled = False
                    txtCAcesso.PasswordChar = ("*")
                    txtSenB.PasswordChar = ("*")
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
    Private Sub MostrarUsuario(ByVal id As Long)
        Dim sql = "Select * from Agencias where id_Agencias=" & id
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id_Agencias", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblId.Text = dr("id_Agencias")
                                lblIdBancos.Text = dr("id_Bancos")
                                LblDataR.Text = dr("DataRegistro")
                                CboCPF.Text = dr("CPF")
                                CboInst.Text = dr("Instituicao")
                                lblNBan.Text = dr("NBanco")
                                lblNAg.Text = dr("NAgencia")
                                txtCC.Text = dr("ContaCorrente")
                                txtLUser.Text = dr("LoginUsuario")
                                txtSenB.Text = dr("Senha")
                                txtCAcesso.Text = dr("CodigoAcesso")
                                txtEmail.Text = dr("EmailCadastro")
                                txtObs.Text = dr("Observacoes")
                            End If
                        End If
                    End Using
                End Using
            End Using
            agencia.ID = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Agencias").Value)
            agencia.Nome = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Nome").Value)
            agencia.Instituicao = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Instituicao").Value)
            agencia.CC = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ContaCorrente").Value)
        Catch ix As InvalidCastException
            MsgBox("Falha a: existe campo(s) nulo(s) ou vazio(s)", vbInformation, Sistema)
        Catch ex As Exception
            MsgBox("Falha em MostrarUsuario: " & ex.Message, vbCritical, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Function Getlivros(ByVal filtro As String) As DataTable
        Dim sql = ""
        If CbCampos.Text = "Nome" Then
            sql = "select Agencias.ID_Agencias, Agencias.DataRegistro, Pessoal.Nome, Pessoal.CPF, Agencias.Instituicao, Agencias.ContaCorrente, Agencias.LoginUsuario, Agencias.Senha, Agencias.CodigoAcesso, Agencias.EmailCadastro FROM Agencias inner join Pessoal on Pessoal.cpf=Agencias.cpf where Nome LIKE  '%" & TxtProcurar.Text & "%' order by Agencias.ID_Agencias desc"
        ElseIf CbCampos.Text = "Instituição" Then
            sql = "select Agencias.ID_Agencias, Agencias.DataRegistro, Pessoal.Nome, Pessoal.CPF, Agencias.Instituicao, Agencias.ContaCorrente, Agencias.LoginUsuario, Agencias.Senha, Agencias.CodigoAcesso, Agencias.EmailCadastro FROM Agencias inner join Pessoal on Pessoal.cpf=Agencias.cpf where Agencias.Instituicao LIKE  '%" & TxtProcurar.Text & "%' order by Agencias.ID_Agencias desc"
        ElseIf CbCampos.Text = "CPF" Then
            sql = "select Agencias.ID_Agencias, Agencias.DataRegistro, Pessoal.Nome, Pessoal.CPF, Agencias.Instituicao, Agencias.ContaCorrente, Agencias.LoginUsuario, Agencias.Senha, Agencias.CodigoAcesso, Agencias.EmailCadastro FROM Agencias inner join Pessoal on Pessoal.cpf=Agencias.cpf where Pessoal.CPF LIKE  '%" & TxtProcurar.Text & "%' order by Agencias.ID_Agencias desc"
        ElseIf CbCampos.Text = "Email" Then
            sql = "select Agencias.ID_Agencias, Agencias.DataRegistro, Pessoal.Nome, Pessoal.CPF, Agencias.Instituicao, Agencias.ContaCorrente, Agencias.LoginUsuario, Agencias.Senha, Agencias.CodigoAcesso, Agencias.EmailCadastro FROM Agencias inner join Pessoal on Pessoal.cpf=Agencias.cpf where Agencias.EmailCadastro LIKE  '%" & TxtProcurar.Text & "%' order by Agencias.ID_Agencias desc"
        End If
        Dim dt As New DataTable
        'Conexão geral do Sistema
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using da = New OleDbDataAdapter(sql, cn)
                    da.Fill(dt)

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha no Getlivros: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
        Return dt
    End Function

    Private Sub CbCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCampos.SelectedIndexChanged
        TxtProcurar.Enabled = True
        TxtProcurar.Focus()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim Resp As Boolean
        Try
            If ValidarForm(result) Then
                SalvarUsuario(lblId.Text, Resp)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Function ValidarForm(result As Boolean) As Boolean

        Try
            If LblDataR.Text = "" Then
                MsgBox("Informe a data do registro.", vbExclamation, Sistema)
                LblDataR.Focus()
                result = False
            ElseIf CboCPF.Text = "" Then
                MsgBox("Informe o cpf do cadastro.", vbExclamation, Sistema)
                CboCPF.Focus()
                result = False
            ElseIf CboInst.Text = "" Then
                MsgBox("Informe a Instituição/Banco.", vbExclamation, Sistema)
                CboInst.Focus()
                result = False
            ElseIf lblNBan.Text = "" Then
                MsgBox("Informe o Banco.", vbExclamation, Sistema)
                lblNBan.Focus()
                result = False
            ElseIf lblNAg.Text = "" Then
                MsgBox("Informe a Agencia.", vbExclamation, Sistema)
                lblNAg.Focus()
                result = False
            ElseIf txtCC.Text = "" Then
                MsgBox("Informe o número da CC.", vbExclamation, Sistema)
                txtCC.Focus()
                result = False
            ElseIf txtLUser.Text = "" Then
                MsgBox("Informe o login.", vbExclamation, Sistema)
                txtLUser.Focus()
                result = False
            ElseIf txtSenB.Text = "" Then
                MsgBox("Informe a senha.", vbExclamation, Sistema)
                txtSenB.Focus()
                result = False
            ElseIf txtEmail.Text = "" Then
                MsgBox("Email é obrigatório!" & vbCrLf & "Valor padrão é 'null'", vbCritical, "Erro!")
                txtEmail.Focus()
                result = False
            ElseIf Not txtEmail.Text = Nothing Then
                If txtEmail.Text = "null" Then
                    result = True
                ElseIf Not ValidarEmail(txtEmail.Text) Then
                    MsgBox("Email é Inválido!", vbInformation, Sistema)
                    txtEmail.Focus()
                    result = False
                Else
                    result = True
                End If
            Else
                result = True
            End If
            Return result
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function

    Private Sub SalvarUsuario(ByVal ID As String, ByVal Resp As Boolean)
        Dim sql
        If CLng(0 & ID) = 0 Then
            sql = "INSERT INTO Agencias(ID_Bancos, DataRegistro, CPF, Instituicao, NBanco, NAgencia, ContaCorrente, LoginUsuario, Senha, CodigoAcesso, EmailCadastro, Observacoes) Values (@ID_Bancos, @DataRegistro, @CPF, @Instituicao, @NBanco, @NAgencia, @ContaCorrente, @LoginUsuario, @Senha, @CodigoAcesso, @EmailCadastro, @Observacoes)"
            Resp = True
        Else
            sql = ("UPDATE Agencias SET  ID_Bancos=@ID_Bancos, DataRegistro=@DataRegistro, CPF=@CPF, Instituicao=@Instituicao, NBanco=@NBanco, NAgencia=@NAgencia, ContaCorrente=@ContaCorrente, LoginUsuario=@LoginUsuario, Senha=@Senha, CodigoAcesso=@CodigoAcesso, EmailCadastro=@EmailCadastro, Observacoes=@Observacoes WHERE id_Agencias =" & ID)
            Resp = False
        End If
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ID_Bancos", lblIdBancos.Text)
                    cmd.Parameters.AddWithValue("@DataRegistro", LblDataR.Text)
                    cmd.Parameters.AddWithValue("@CPF", CboCPF.Text)
                    cmd.Parameters.AddWithValue("@Instituicao", CboInst.Text)
                    cmd.Parameters.AddWithValue("@NBanco", lblNBan.Text)
                    cmd.Parameters.AddWithValue("@NAgencia", lblNAg.Text)
                    cmd.Parameters.AddWithValue("@ContaCorrente", txtCC.Text)
                    cmd.Parameters.AddWithValue("@LoginUsuario", txtLUser.Text)
                    cmd.Parameters.AddWithValue("@Senha", txtSenB.Text)
                    cmd.Parameters.AddWithValue("@CodigoAcesso", txtCAcesso.Text)
                    cmd.Parameters.AddWithValue("@EmailCadastro", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Observacoes", txtObs.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            If Resp = True Then
                MsgNovo()
            ElseIf Resp = False Then
                MsgAtualizado()
            End If
            PLimpar()
            MostrarPesqUsuarios()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
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
            ElseIf result = True And DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Agencias").Value <> lblId.Text Then
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
        Dim sql = ("Delete from Agencias where id_Agencias =" & id)
        Dim resultado As String
        Dim cn = New OleDbConnection(conn)
        Try
            resultado = MsgBox("ATENÇÃO!" + Chr(10) + "A exclusão deste item, pode ter um efeito cascata!" + Chr(10) + "" + Chr(10) + "Tem certeza que deseja excluir a CC " & agencia.CC & " de " & agencia.Nome & "?", vbYesNo + vbCritical, "Exclusão de registro!")
            If resultado = vbYes Then
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@ID_Bancos", lblIdBancos.Text)
                        cmd.Parameters.AddWithValue("@DataRegistro", LblDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", CboCPF.Text)
                        cmd.Parameters.AddWithValue("@Instituicao", CboInst.Text)
                        cmd.Parameters.AddWithValue("@NBanco", lblNBan.Text)
                        cmd.Parameters.AddWithValue("@NAgencia", lblNAg.Text)
                        cmd.Parameters.AddWithValue("@ContaCorrente", txtCC.Text)
                        cmd.Parameters.AddWithValue("@LoginUsuario", txtLUser.Text)
                        cmd.Parameters.AddWithValue("@Senha", txtSenB.Text)
                        cmd.Parameters.AddWithValue("@CodigoAcesso", txtCAcesso.Text)
                        cmd.Parameters.AddWithValue("@EmailCadastro", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@Observacoes", txtObs.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MsgExclusao()
            Else
                MsgNaoExclusao()
            End If
            PLimpar()
            MostrarPesqUsuarios()
        Catch ex As Exception
            MsgBox("Falha5: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        PLimpar()
        MostrarPesqUsuarios()
    End Sub

    Private Sub CboCPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCPF.SelectedIndexChanged
        Try
            'Faz uma pesquisa de CPF e retorna o nome e sobrenome de cadastro
            PleDados()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub PleDados()
        Dim con As OleDbConnection = Getconnection()
        Try
            'Faz uma pesquisa de CPF e retorna o nome e sobrenome de cadastro
            Dim dr As OleDbDataReader = Nothing
            Using con
                con.Open()
                Dim sql As String = "SELECT * FROM Pessoal WHERE CPF='" & CboCPF.Text & "'"
                'Seleciona todos os CPFs cadastrados
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblNome.Text = dr.Item("Nome")
                    lblSobrenome.Text = dr.Item("Sobrenome")
                    CboCPF.Text = dr.Item("CPF")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CboCPF_GotFocus(sender As Object, e As EventArgs) Handles CboCPF.GotFocus
        'Faz uma pesquisa de CPFs cadastrados
        PCarregaDados()
    End Sub
    Private Sub PCarregaDados()
        Dim con As OleDbConnection = Getconnection()
        Dim sql As String = "SELECT * FROM Pessoal CPF"
        Try
            'Faz uma pesquisa de CPFs cadastrados
            Using con
                con.Open()
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                CboCPF.ValueMember = "ID_Pessoal"
                CboCPF.DisplayMember = "CPF"
                CboCPF.DataSource = dt
                lblNome.Text = ""
                lblSobrenome.Text = ""
                CboCPF.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CboInst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboInst.SelectedIndexChanged
        MostrarIdBancos(pIDAge)
        Try
            'Faz uma pesquisa de BANCOS e retorna o número e nome de cadastro
            PleDados1()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub PleDados1()
        Dim sql As String = "SELECT * FROM Bancos WHERE Instituicao='" & CboInst.Text & "'"
        Dim con As OleDbConnection = Getconnection()
        Try
            'Faz uma pesquisa de BANCOS e retorna o número e nome de cadastro
            Dim dr As OleDbDataReader = Nothing
            Using con
                con.Open()
                'Seleciona todos os BANCOS cadastrados
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblNBan.Text = dr.Item("NBanco")
                    CboInst.Text = dr.Item("Instituicao")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close() 'Tem que ser nessa posição
        End Try
    End Sub

    Private Sub CboInst_GotFocus(sender As Object, e As EventArgs) Handles CboInst.GotFocus
        'Faz uma pesquisa de BANCOS cadastrados
        PCarregaDados1()
    End Sub
    Private Sub PCarregaDados1()
        'Faz uma pesquisa de BANCOS cadastrados
        Dim sql As String = "SELECT * FROM Bancos where Instituicao" 'Seleciona todos os BANCOS cadastrados
        Dim con As OleDbConnection = Getconnection()
        Try
            Using con
                con.Open()
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                CboInst.ValueMember = "CPF"
                CboInst.DisplayMember = "Instituicao"
                CboInst.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Falha6: Ban" & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub MostrarIdBancos(ByVal id As Long)
        Dim sql = "Select * from Bancos where Instituicao='" & CboInst.Text & "'"
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id_Bancos", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblIdBancos.Text = dr("id_Bancos")
                                lblNAg.Text = dr("NAgencia")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("FalhaQ: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub TxtInst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNAg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCC.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtIdPessoal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtProcurar_GotFocus(sender As Object, e As EventArgs) Handles TxtProcurar.GotFocus
        If CbCampos.Text = "CPF" Then
            TxtProcurar.Mask = "000,000,000-00"
        End If
    End Sub

    Private Sub CbCampos_Click(sender As Object, e As EventArgs) Handles CbCampos.Click
        PLimpar()
        MostrarPesqUsuarios()
    End Sub

End Class

