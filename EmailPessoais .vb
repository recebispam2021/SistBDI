Imports System.Data.OleDb
Public Class EmailPessoais
    Dim em As New ClassEmailPessoais
    Dim resp As String = False
    Private Sub EmailConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        FrmPrincipal.MenuStrip1.Enabled = False 'Desativa o submenu
    End Sub

    Private Sub EmailConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmPrincipal.MenuStrip1.Enabled = True 'Ativa o submenu
    End Sub

    Private Sub EmailConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        Try
            Dim Tempo = Today
            Dim a As String
            a = Tempo.ToString("dd/MM/yyyy")
            LblDataR.Text = a
            MostrarUsuarios()
            ConfigurarGrade()
            If Not pAdministrador Then
                chkPass.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Falha load: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub

    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                .Columns("ID_Email").HeaderText = "ID"
                .Columns("ID_Email").Width = 30
                .Columns("ID_Email").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DataRegistro").HeaderText = "D. Registro"
                .Columns("DataRegistro").Width = 100
                .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Nome").HeaderText = "Nome"
                .Columns("Nome").Width = 100

                .Columns("CPF").HeaderText = "CPF"
                .Columns("CPF").Width = 120
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Email").HeaderText = "Email"
                .Columns("Email").Width = 300

                .Columns("Login").HeaderText = "Login de Usuário"
                .Columns("Login").Width = 110
                .Columns("Login").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Senha").HeaderText = "Senha"
                .Columns("Senha").Width = 110
                .Columns("Senha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Function GetPesquisa(ByVal filtro As String) As DataTable
        Dim cn = New OleDbConnection(conn)
        Dim sql = ""
        If CbCampos.Text = "Nome" Then
            sql = "SELECT e.ID_Email, e.DataRegistro,p.Nome, p.CPF, e.Email, e.Login, e.Senha FROM Email e inner join Pessoal p on p.cpf=e.cpf where Nome LIKE  '%" & TxtProcurar.Text & "%' Order by e.id_Email DESC"
        ElseIf CbCampos.Text = "CPF" Then
            sql = "SELECT e.ID_Email, e.DataRegistro,p.Nome, p.CPF, e.Email, e.Login, e.Senha FROM Email e inner join Pessoal p on p.cpf=e.cpf where p.CPF LIKE  '%" & TxtProcurar.Text & "%' Order by e.id_Email DESC"
        ElseIf CbCampos.Text = "Email" Then
            sql = "SELECT e.ID_Email, e.DataRegistro,p.Nome, p.CPF, e.Email, e.Login, e.Senha FROM Email e inner join Pessoal p on p.cpf=e.cpf where e.Email LIKE  '%" & TxtProcurar.Text & "%' Order by e.id_Email DESC"
        ElseIf CbCampos.Text = "Login" Then
            sql = "SELECT e.ID_Email, e.DataRegistro,p.Nome, p.CPF, e.Email, e.Login, e.Senha FROM Email e inner join Pessoal p on p.cpf=e.cpf where e.Login LIKE  '%" & TxtProcurar.Text & "%' Order by e.id_Email DESC"
        End If
        Dim dt As New DataTable
        Try
            Using cn
                cn.Open()
                Using da = New OleDbDataAdapter(sql, cn)
                    da.Fill(dt)
                End Using
            End Using
            'Testar com a função PLimpar
            CbCampos.SelectedIndex = -1
            TxtProcurar.Clear()
            TxtProcurar.Mask = ""
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
        Return dt
    End Function

    Private Sub MostrarUsuarios()
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Dim sql = "SELECT e.ID_Email, e.DataRegistro,p.Nome, p.CPF, e.Email, e.Login, e.Senha FROM Email e inner join Pessoal p on p.cpf=e.cpf Order by e.id_Email DESC"
                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
            If DataGridView1.Rows.Count = 0 Then 'Verifica se tem registro
                MsgBox("Não existe registro no banco de dados!", vbInformation, "Banco de dados vazio!")
            Else
                DataGridView1.Rows(0).Selected = False
                DataGridView1.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
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
            If e.ColumnIndex = 7 Then 'e.ColumnIndex = 7 Or
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            'Se os campos de pesquisas estiverem nulos, não fazer nada
            If CbCampos.Text = "" Or TxtProcurar.Text = "" Then
                If result = True Then
                    PCarregaDados()
                    MostrarUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Email").Value)
                    em.EmailNome = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Nome").Value)
                    If pAdministrador Then
                        txtSenEmail.Enabled = True
                        txtSenEmail.PasswordChar = ("")
                        Exit Sub
                    End If
                    If lblId.Text = 0 Then
                        txtSenEmail.Enabled = True
                        txtSenEmail.PasswordChar = ("")
                    Else
                        cboCPF.Enabled = False
                        txtSenEmail.Enabled = False
                        txtSenEmail.PasswordChar = ("*")
                    End If
                Else
                    MsgBox("Selecione um item da lista" & vbNewLine & "para fazer a pesquisa!", vbExclamation, Sistema)
                End If
            Else
                DataGridView1.DataSource = GetPesquisa(TxtProcurar.Text)
                If DataGridView1.Rows.Count > 0 Then
                    ConfigurarGrade()
                ElseIf DataGridView1.Rows.Count = 0 Then
                    MsgBox("Nenhum item foi encontrado!", vbInformation, Sistema)
                End If
            End If
        Catch ex As Exception
            MsgBox("Falha buscar: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub PCarregaDados()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Pessoal CPF"
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
            Catch ex As Exception
                MsgBox("Falha PCarregaDados: " & ex.Message, vbExclamation, Sistema)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub MostrarUsuario(ByVal id As Long)
        Dim sql = "Select * from Email where id_Email=" & id
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@ID_Email", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblId.Text = dr("ID_Email")
                                LblDataR.Text = dr("DataRegistro")
                                cboCPF.Text = dr("CPF")
                                txtEmail.Text = dr("Email")
                                txtLogin.Text = dr("Login")
                                txtSenEmail.Text = dr("Senha")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha MostrarUsuario: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub CbCampos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCampos.SelectedIndexChanged
        TxtProcurar.Enabled = True
        TxtProcurar.Focus()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        PLimpar()
        MostrarUsuarios()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If ValidarForm(result) Then
            SalvarUsuario(lblId.Text, resp)
        End If
    End Sub
    Private Function ValidarForm(ByVal result As Boolean) As Boolean
        Try
            If cboCPF.Text = "" Then
                MsgBox("O CPF é obrigatório!", vbExclamation, Sistema)
                result = False
                Exit Try
            End If
            If LblDataR.Text = "" Then
                MsgBox("Informe a data do registro.", vbExclamation, Sistema)
                LblDataR.Focus()
                result = False
            ElseIf txtEmail.Text = "" Then
                MsgBox("Informe o e-mail do cadastro.", vbExclamation, Sistema)
                txtEmail.Focus()
                result = False
            ElseIf Not ValidarEmail(txtEmail.Text) Then
                MsgBox("Email é Inválido", vbInformation)
                txtEmail.Focus()
                result = False
            ElseIf txtLogin.Text = "" Then
                MsgBox("Informe o login do cadastro.", vbExclamation, Sistema)
                txtLogin.Focus()
                result = False
            ElseIf txtSenEmail.Text = "" Then
                MsgBox("Informe a senha do cadastro.", vbExclamation, Sistema)
                txtSenEmail.Focus()
                result = False
            Else
                result = True
            End If
        Catch ex As Exception
            MsgBox("Falha ValidarForm: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return result
    End Function
    Private Sub SalvarUsuario(ByVal ID As String, ByVal Resp As Boolean)
        Dim sql
        Dim cn = New OleDbConnection(conn)
        If CLng(0 & ID) = 0 Then
            sql = "INSERT INTO Email(DataRegistro, CPF, Email, Login, Senha) Values (@DataRegistro, @CPF, @Email, @Login, @Senha)"
            Resp = True
        Else
            sql = ("UPDATE Email SET  DataRegistro=@DataRegistro, CPF=@CPF, Email=@Email, Login=@Login, Senha=@Senha WHERE id_Email =" & ID)
            Resp = False
        End If
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@DataRegistro", LblDataR.Text)
                    cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Login", txtLogin.Text)
                    cmd.Parameters.AddWithValue("@Senha", txtSenEmail.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            If Resp = True Then
                MsgNovo()
            Else
                MsgAtualizado()
            End If
            PLimpar()
            MostrarUsuarios()
        Catch ex As Exception
            MsgBox("Falha SalvarUsuario: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CboCPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCPF.SelectedIndexChanged
        Try
            PleDados()
        Catch ex As Exception
            MsgBox("Falha SelectedIndexChanged: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub
    Private Sub PleDados()
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Pessoal WHERE CPF='" & cboCPF.Text & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblNome.Text = dr.Item("Nome")
                    lblSobrenome.Text = dr.Item("Sobrenome")
                Else

                End If
            Catch ex As Exception
                MsgBox("Falha PleDados: " & ex.Message, vbExclamation, Sistema)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub CboCPF_GotFocus(sender As Object, e As EventArgs) Handles cboCPF.GotFocus
        PCarregaDados()
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
            ElseIf result = True And DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Email").Value <> lblId.Text Then
                MsgBox("Item selecionado está incorreto!", vbCritical, "Erro!")
                Exit Sub
            End If
            If Not pAcessoPermitido And lblId.Text = "" Then
                MsgBox("Não há item selecionado para excluir!", vbCritical, Sistema)
                Exit Sub
            ElseIf Not pAcessoPermitido And lblId.Text <> "" Then
                MsgBox("Acesso negado!" & vbNewLine & "Você não pode excluir este item!", vbCritical, Sistema)
                PLimpar()
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
    Private Sub ExcluirRegistros(ByVal ID As String)
        Dim cn = New OleDbConnection(conn)
        Try
            Dim resp As String
            resp = MsgBox("Tem certeza que deseja excluir o email de " & em.EmailNome & " ?", vbCritical + vbYesNo, "Exclusão de registro do sistema!")
            If resp = vbYes Then
                Dim sql = ("Delete from Email where id_Email =" & ID)
                MsgExclusao()
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@DataRegistro", LblDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@LoginUsuario", txtLogin.Text)
                        cmd.Parameters.AddWithValue("@Senha", txtSenEmail.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Else
                MsgNaoExclusao()
            End If
            PLimpar()
            MostrarUsuarios()
        Catch ex As Exception
            MsgBox("Falha ExcluirRegistros: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub TxtProcurar_GotFocus(sender As Object, e As EventArgs) Handles TxtProcurar.GotFocus
        If CbCampos.Text = "CPF" Then
            TxtProcurar.Mask = "000,000,000-00"
        End If
    End Sub

    Private Sub CbCampos_Click(sender As Object, e As EventArgs) Handles CbCampos.Click
        PLimpar()
        MostrarUsuarios()
    End Sub
End Class