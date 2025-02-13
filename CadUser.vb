Imports System.Data.OleDb
Public Class CadUser
    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim Id As Integer = 0
        If ValidarForm() Then
            SalvarUsuario(Id)
            Me.Close()
            UsuariosConsulta.Show()
        End If
    End Sub
    Private Sub LimparForm()
        lblId.Text = ""
        txtNome.Clear()
        txtUsuario.Clear()
        txtSenha.Clear()
        chkAdmin.Checked = False
        chkAtivo.Checked = False
    End Sub
    Private Function ValidarForm() As Boolean
        If txtNome.Text = "" Then
            MsgBox("Informe o nome do usuário", vbExclamation, Sistema)
            txtNome.Focus()
            result = False
        ElseIf txtUsuario.Text = "" Then
            MsgBox("Informe o login do usuário", vbExclamation, Sistema)
            txtUsuario.Focus()
            result = False
        ElseIf txtSenha.TextLength < 4 Then
            MsgBox("A senha tem que ter pelo menos 4 caracteres.", vbExclamation, Sistema)
            txtSenha.Focus()
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub SalvarUsuario(ByVal Id As Integer)
        Dim sql
        Dim cn = New OleDbConnection(conn)
        Try
            If CLng(0 & Id) = 0 Then
                sql = "INSERT INTO usuarios(Nome, Usuario, Senha, Administrador, Ativo) Values (@Nome, @Usuario, @Senha, @Administrador, @Ativo)"
                MsgNovo()
            Else
                sql = ("UPDATE usuarios SET Nome=@Nome, Usuario=@Usuario, Senha=@Senha, Administrador=@Administrador, Ativo=@Ativo WHERE id =" & Id)
                MsgAtualizado()
            End If
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                    cmd.Parameters.AddWithValue("@Senha", txtSenha.Text)
                    cmd.Parameters.AddWithValue("@Administrador", IIf(chkAdmin.Checked, "S", "N"))
                    cmd.Parameters.AddWithValue("@Ativo", IIf(chkAtivo.Checked, "S", "N"))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CadUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ficha de Cadastro de Admin/Usuários"
        tssTexto.Text = pNomeSistema & pID

        If Not pAdministrador Then
            txtSenha.Enabled = False
            chkAdmin.Enabled = False
            chkAtivo.Enabled = False
            If pID >= "2" Then
                btnExcluir.Enabled = False
            End If
        Else
            btnExcluir.Enabled = True
        End If

        If pID > 0 Then
            MostrarUsuario(pID)
        End If

        If pID = 0 Then
            txtSenha.Enabled = True
            chkAdmin.Enabled = True
            chkAtivo.Enabled = True
        End If

    End Sub
    Private Sub MostrarUsuario(ByVal id As Long)
        Dim cn = New OleDbConnection(conn)
        Dim sql = "Select * from Usuarios where id=" & id
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblId.Text = dr("id")
                                txtNome.Text = dr("Nome")
                                txtUsuario.Text = dr("Usuario")
                                txtSenha.Text = dr("Senha")
                                If dr("Administrador") = "S" Then
                                    chkAdmin.Checked = True
                                Else
                                    chkAdmin.Checked = False
                                End If
                                If dr("Ativo") = "S" Then
                                    chkAtivo.Checked = True
                                Else
                                    chkAtivo.Checked = False
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        'Chama o procedimento
        ExcluirRegistros(lblId.Text)
    End Sub

    Private Sub ExcluirRegistros(ByVal Id As Integer)
        Dim resp As String
        Dim cn = New OleDbConnection(conn)
        resp = MsgBox("Tem certeza que deseja excluir este registro?", vbYesNo, "Exclusão de registro")
        Try
            If resp = vbYes Then
                Dim sql = ("Delete from Usuarios where id =" & Id)
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text)
                        cmd.Parameters.AddWithValue("@Administrador", IIf(chkAdmin.Checked, "S", "N"))
                        cmd.Parameters.AddWithValue("@Ativo", IIf(chkAtivo.Checked, "S", "N"))
                        cmd.ExecuteNonQuery()
                    End Using
                    UsuariosConsulta.Show()
                End Using
                MsgExclusao()
                Me.Close()
            Else
                MsgNaoExclusao()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CadUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub CadUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
        pID = -1
    End Sub
End Class