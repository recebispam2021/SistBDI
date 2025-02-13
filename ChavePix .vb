Imports System.Configuration
Imports System.Data.OleDb
Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Media
Imports ProjSistBDIMax.ClassChavePix
Public Class ChavePix
    Dim ch As New ClassChavePix
    Dim resp As String

    Private Sub ChavePix_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub ChavePix_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub

    Private Sub ChavePix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        Try
            Dim Tempo = Today
            Dim a As String
            a = Tempo.ToString("dd/MM/yyyy")
            txtDataR.Text = a
            MostrarUsuarios()
            ConfigurarGrade()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub

    Private Sub ConfigurarGrade()
        With DataGridView1

            .Columns("ID_Pix").Visible = False
            .Columns("ID_Pix").HeaderText = "ID"
            .Columns("ID_Pix").Width = 30
            .Columns("ID_Pix").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("ID_Bancos").HeaderText = "IDB"
            .Columns("ID_Bancos").Width = 30
            .Columns("ID_Bancos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("DataRegistro").HeaderText = "D. Registro"
            .Columns("DataRegistro").Width = 90
            .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("CPF").HeaderText = "CPF"
            .Columns("CPF").Width = 120
            .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Instituicao").HeaderText = "Instituição"
            .Columns("Instituicao").Width = 120

            .Columns("Chave").HeaderText = "Chave"
            .Columns("Chave").Width = 300

        End With

    End Sub
    Private Sub MostrarUsuarios()
        CbCampos.Text = "Selecione"
        Dim sql = "SELECT c.ID_Pix,c.ID_Bancos,c.DataRegistro,p.Nome,c.CPF,b.Instituicao,c.Chave FROM ((chavepix c LEFT JOIN bancos b ON ((b.ID_Bancos = c.ID_Bancos))) LEFT JOIN pessoal p ON ((c.CPF = p.CPF))) ORDER BY c.ID_Pix"
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
            MsgBox("Falha2:  " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Function ValidarForm(ByVal result As Boolean) As Boolean
        Try
            If txtDataR.Text = "" Then
                MsgBox("Informe a data do registro.", vbExclamation, Sistema)
                txtDataR.Focus()
                result = False
            ElseIf cboCPF.Text = "" Then
                MsgBox("Informe o cpf.", vbExclamation, Sistema)
                cboCPF.Focus()
                result = False
            ElseIf lblInst.Text = "" Then
                MsgBox("Informe o nome da Instituição/Banco.", vbExclamation, Sistema)
                lblInst.Focus()
                result = False
            ElseIf txtChavePix.Text = "" Then
                MsgBox("Informe a chave pix.", vbExclamation, Sistema)
                txtChavePix.Focus()
                result = False
            Else
                result = True
            End If
            Return result
        Catch ex As Exception
            MsgBox("Falha ValidarForm: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Function
    Private Sub SalvarUsuario(ByVal ID As String, ByVal Resp As Boolean)
        Dim sql As String
        Dim cn = New OleDbConnection(conn)
        If CLng(0 & ID) = 0 Then
            sql = "INSERT INTO ChavePix(DataRegistro,ID_Bancos, CPF, Instituicao, Chave) Values (@DataRegistro,@ID_Bancos, @CPF, @Instituicao, @Chave)"
            Resp = True
        Else
            sql = ("UPDATE ChavePix SET  DataRegistro=@DataRegistro,ID_Bancos=@ID_Bancos, CPF=@CPF, Instituicao=@Instituicao, Chave=@Chave WHERE id_Pix =" & ID)
            Resp = False
        End If
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                    cmd.Parameters.AddWithValue("@ID_Bancos", cboNBanco.Text)
                    cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                    cmd.Parameters.AddWithValue("@Instituicao", lblInst.Text)
                    cmd.Parameters.AddWithValue("@Chave", txtChavePix.Text)
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
            MsgBox("Falha SalvarUsuario: " & ex.Message, vbExclamation, Sistema)
            MsgBox("O valor é: " & cboNBanco.Text)
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
    Private Sub MostrarUsuario(ByVal id As Long)
        Dim sql = "Select * from ChavePix where id_Pix =" & id
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id_Pix", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblId.Text = dr("ID_Pix")
                                txtDataR.Text = dr("DataRegistro")
                                cboNBanco.Text = dr("ID_Bancos")
                                cboCPF.Text = dr("CPF")
                                lblInst.Text = dr("Instituicao")
                                txtChavePix.Text = dr("Chave")
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
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Se os campos de pesquisas estiverem nulos, não fazer nada
        If CbCampos.Text = "" Or TxtProcurar.Text = "" Then
            If result = True Then
                PCarregaDados()
                PCarregaDados1()
                MostrarUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Pix").Value)
                ch.IdChavePix = Convert.ToByte(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Pix").Value)
                ch.Instituicao = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Instituicao").Value)
            Else
                MsgBox("Selecione um item da lista!", vbExclamation, Sistema)
            End If
            If lblId.Text = 0 Then
                cboCPF.Enabled = True
                cboNBanco.Enabled = True
            Else
                cboCPF.Enabled = False
                cboNBanco.Enabled = False
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
    Private Function Getlivros(ByVal filtro As String) As DataTable
        Dim sql As String = ""
        If CbCampos.Text = "Nome" Then
            sql = "Select chavepix.ID_Pix,chavepix.ID_Bancos,chavepix.DataRegistro,pessoal.Nome,pessoal.CPF,chavepix.Instituicao,chavepix.Chave From chavepix inner Join pessoal On pessoal.CPF=chavepix.CPF where pessoal.Nome LIKE  '%" & TxtProcurar.Text & "%' ORDER BY ID_Pix"
        ElseIf CbCampos.Text = "CPF" Then
            sql = "Select chavepix.ID_Pix,chavepix.ID_Bancos,chavepix.DataRegistro,pessoal.Nome,pessoal.CPF,chavepix.Instituicao,chavepix.Chave From chavepix inner Join pessoal On pessoal.CPF=chavepix.CPF where pessoal.CPF LIKE  '%" & TxtProcurar.Text & "%' ORDER BY ID_Pix"
        ElseIf CbCampos.Text = "Instituição" Then
            sql = "Select chavepix.ID_Pix,chavepix.ID_Bancos,chavepix.DataRegistro,pessoal.Nome,pessoal.CPF,chavepix.Instituicao,chavepix.Chave From chavepix inner Join pessoal On pessoal.CPF=chavepix.CPF where chavepix.Instituicao LIKE  '%" & TxtProcurar.Text & "%' ORDER BY ID_Pix"
        ElseIf CbCampos.Text = "Chave" Then
            sql = "Select chavepix.ID_Pix,chavepix.ID_Bancos,chavepix.DataRegistro,pessoal.Nome,pessoal.CPF,chavepix.Instituicao,chavepix.Chave From chavepix inner Join pessoal On pessoal.CPF=chavepix.CPF where chavepix.Chave LIKE  '%" & TxtProcurar.Text & "%' ORDER BY ID_Pix"
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
            'Testar com a função PLimpar
            CbCampos.SelectedIndex = -1
            TxtProcurar.Mask = ""
            TxtProcurar.Clear()
        Catch ex As Exception
            MsgBox("Falha Getlivros: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
        Return dt
    End Function
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
    Private Sub CbCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCampos.SelectedIndexChanged
        TxtProcurar.Enabled = True
        TxtProcurar.Focus()
    End Sub
    Private Sub TxtProcurar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnBuscar.Enabled = True
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim Resp As Boolean
        If ValidarForm(result) Then
            SalvarUsuario(lblId.Text, Resp)
        End If
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
            ElseIf result = True And DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Pix").Value <> lblId.Text Then
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
            MsgBox("Falha BtnExcluir: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Sub ExcluirRegistros(ByVal id As String)
        resp = MsgBox("Tem certeza que deseja excluir a Chave Pix do ''" & ch.Instituicao & "'' ?", vbCritical + vbYesNo, "Exclusão de registro do sistema!")
        Dim cn = New OleDbConnection(conn)
        Try
            If resp = vbYes Then
                Dim sql = ("Delete from ChavePix where ID_Pix =" & id)
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                        cmd.Parameters.AddWithValue("@ID_Bancos", cboNBanco.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Instituicao", lblInst.Text)
                        cmd.Parameters.AddWithValue("@Chave", txtChavePix.Text)
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
            MsgBox("Falha ExcluirRegistros: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
    Private Sub BtnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpar.Click
        PLimpar()
        MostrarUsuarios()
    End Sub
    Private Sub CboCPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCPF.SelectedIndexChanged
        Try
            PleDados()
        Catch ex As Exception
            MsgBox("Falha CboCPF: " & ex.Message, vbExclamation, Sistema)
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
                End If
            Catch ex As Exception
                MsgBox("Falha PleDados: " & ex.Message, vbExclamation, Sistema)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
    Private Sub CboCPF_GotFocus(sender As Object, e As EventArgs) Handles cboCPF.GotFocus
        PCarregaDados()
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

    Private Sub PCarregaDados1()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Bancos ID_Bancos"
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                cboNBanco.ValueMember = "ID_Bancos"
                cboNBanco.DisplayMember = "ID_Bancos"
                cboNBanco.DataSource = dt
                lblInst.Text = ""
            Catch ex As Exception
                MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub CboNBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNBanco.SelectedIndexChanged
        Try
            PleDados1()
        Catch ex As Exception
            MsgBox("Falha cboNBanco: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
    End Sub

    Private Sub CboNBanco_GotFocus(sender As Object, e As EventArgs) Handles cboNBanco.GotFocus
        PCarregaDados1()
    End Sub
    Private Sub PleDados1()
        If cboNBanco.Text = "" Then
            Exit Sub
        End If
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Bancos WHERE ID_Bancos = " & cboNBanco.Text
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    lblInst.Text = dr.Item("Instituicao")
                End If
            Catch ex As Exception
                MsgBox("Falha PleDados1: " & ex.Message, vbExclamation, Sistema)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

End Class