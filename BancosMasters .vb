Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Documents

Public Class BancosMasters
    Dim banco As New ClassBancos

    Private Sub BancosConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Desativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = False
    End Sub

    Private Sub BancosConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Ativa o submenu
        FrmPrincipal.MenuStrip1.Enabled = True
    End Sub

    Private Sub BancosConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        MostrarPesqUsuarios()
        ConfigurarGrade()
    End Sub

    Private Sub ConfigurarGrade()
        Try
            With DataGridView1

                DataGridView1.Columns("ID_Bancos").Visible = False
                .Columns("ID_Bancos").Width = 30
                .Columns("ID_Bancos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("DataRegistro").HeaderText = "Data"
                .Columns("DataRegistro").Width = 100
                .Columns("DataRegistro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Nome").HeaderText = "Nome"
                .Columns("Nome").Width = 100
                .Columns("Nome").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("CPF").HeaderText = "CPF"
                .Columns("CPF").Width = 100
                .Columns("CPF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Instituicao").HeaderText = "Instituição"
                .Columns("Instituicao").Width = 190
                .Columns("Instituicao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("NBanco").HeaderText = "Nº Banco"
                .Columns("NBanco").Width = 80
                .Columns("NBanco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("NAgencia").HeaderText = "Nº Agencia"
                .Columns("NAgencia").Width = 90
                .Columns("NAgencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Observacoes").HeaderText = "Observações"
                .Columns("Observacoes").Width = 250
                .Columns("Observacoes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
        Catch ex As Exception
            MsgBox("Falha1: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Function MostrarPesqUsuarios() As Boolean
        'Conexão geral do Sistema
        Dim cn = New OleDbConnection(conn)
        Dim sql = "select bancos.ID_Bancos, bancos.DataRegistro,Pessoal.Nome, Pessoal.CPF, bancos.Instituicao, bancos.NBanco, bancos.NAgencia, bancos.Observacoes FROM Bancos inner join Pessoal on Pessoal.cpf=bancos.cpf Order by bancos.ID_Bancos DESC"
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
                MsgBox("Não existe registro no banco de dados!",
                       vbInformation, "Banco de dados vazio!")
            Else
                DataGridView1.Rows(0).Selected = False
                DataGridView1.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox("Falha2: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Function

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

    Private Function Getlivros(ByVal filtro As String) As DataTable
        Dim sql = ""
        If CbCampos.Text = "Instituição" Then
            sql = "Select bancos.ID_Bancos, bancos.DataRegistro,Pessoal.Nome, Pessoal.CPF, 
                    bancos.Instituicao, bancos.NBanco, bancos.NAgencia, bancos.Observacoes from bancos 
                    inner join Pessoal on Pessoal.cpf=Bancos.cpf where bancos.Instituicao 
                    LIKE  '%" & TxtProcurar.Text & "%'"
        ElseIf CbCampos.Text = "CPF" Then
            sql = "Select bancos.ID_Bancos, bancos.DataRegistro,Pessoal.Nome, Pessoal.CPF, 
                    bancos.Instituicao, bancos.NBanco, bancos.NAgencia, bancos.Observacoes from bancos 
                    inner join Pessoal on Pessoal.cpf=Bancos.cpf where Pessoal.CPF 
                    LIKE  '%" & TxtProcurar.Text & "%'"
        ElseIf CbCampos.Text = "Nº Banco" Then
            sql = "Select bancos.ID_Bancos, bancos.DataRegistro,Pessoal.Nome, Pessoal.CPF, 
                    bancos.Instituicao, bancos.NBanco, bancos.NAgencia, bancos.Observacoes from bancos 
                    inner join Pessoal on Pessoal.cpf=Bancos.cpf where bancos.NBanco 
                    LIKE  '%" & TxtProcurar.Text & "%'"
        ElseIf CbCampos.Text = "Nº Agência" Then
            sql = "Select bancos.ID_Bancos, bancos.DataRegistro,Pessoal.Nome, Pessoal.CPF, 
                    bancos.Instituicao, bancos.NBanco, bancos.NAgencia, bancos.Observacoes from bancos 
                    inner join Pessoal on Pessoal.cpf=Bancos.cpf where bancos.NAgencia 
                    LIKE  '%" & TxtProcurar.Text & "%'"
        ElseIf CbCampos.Text = "Nome" Then
            sql = "Select bancos.ID_Bancos, bancos.DataRegistro,Pessoal.Nome, Pessoal.CPF, 
                    bancos.Instituicao, bancos.NBanco, bancos.NAgencia, bancos.Observacoes from bancos 
                    inner join Pessoal on Pessoal.cpf=Bancos.cpf where Pessoal.Nome 
                    LIKE  '%" & TxtProcurar.Text & "%'"
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
            CbCampos.SelectedIndex = -1
            TxtProcurar.Clear()
            TxtProcurar.Mask = ""
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

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Se os campos de pesquisas estiverem nulos, não fazer nada
        If CbCampos.Text = "" Or TxtProcurar.Text = "" Then
            'Identifica que existe celula marcada
            If result = True Then
                If pAdministrador Then
                    MostrarIdUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Bancos").Value)
                    Exit Sub
                End If
                If pAcessoPermitido Then
                    MostrarIdUsuario(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Bancos").Value)
                    cboCPF.Enabled = False
                Else
                    MsgBox("Acesso não permitido!", vbInformation, "Logoff")
                    PLimpar()
                End If
            Else 'Identifica que não existe celula marcada
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

    Private Function MostrarIdUsuario(ByVal id As Long) As Long
        'Retorno da pesquisa
        Dim sql = "Select * from Bancos where id_Bancos=" & id
        Dim cn = New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    Using dr = cmd.ExecuteReader()
                        cmd.Parameters.AddWithValue("@id_Bancos", id)
                        If dr.HasRows Then
                            If dr.Read Then
                                lblId.Text = dr("id_Bancos")
                                txtDataR.Text = dr("DataRegistro")
                                cboCPF.Text = dr("CPF")
                                txtInst.Text = dr("Instituicao")
                                txtNBan.Text = dr("NBanco")
                                txtNAg.Text = dr("NAgencia")
                                txtObs.Text = dr("Observacoes")
                            End If
                        End If
                    End Using
                End Using
            End Using
            banco.Nome = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Nome").Value)
            banco.Instituicao = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("Instituicao").Value)
        Catch ix As InvalidCastException
            MsgBox("Falha: existe campo(s) nulo(s) ou vazio(s)",
                   vbInformation, Sistema)
        Catch ex As Exception
            MsgBox("Falha em MostrarUsuario: " & ex.Message, vbCritical, Sistema)
        Finally
            cn.Close()
        End Try
    End Function

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        PLimpar()
        MostrarPesqUsuarios()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try
            If ValidarForm() Then
                SalvarUsuario(lblId.Text)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Function ValidarForm() As Boolean
        Try
            If txtDataR.Text = "" Then
                MsgBox("Informe a DATA do registro.", vbExclamation, Sistema)
                txtDataR.Focus()
                ValidarForm = False
            ElseIf txtInst.Text = "" Then
                MsgBox("Informe o BANCO(Instituição) para cadastro.", vbExclamation, Sistema)
                txtInst.Focus()
                ValidarForm = False
            ElseIf cboCPF.Text = "" Then
                MsgBox("Informe o CPF para cadastro.", vbExclamation, Sistema)
                cboCPF.Focus()
                ValidarForm = False
            ElseIf txtNBan.Text = "" Then
                MsgBox("Informe o NÚMERO para cadastro.", vbExclamation, Sistema)
                txtNBan.Focus()
                ValidarForm = False
            ElseIf txtNAg.Text = "" Then
                MsgBox("Informe a AGÊNCIA para cadastro.", vbExclamation, Sistema)
                txtNAg.Focus()
                ValidarForm = False
            Else
                ValidarForm = True
            End If
        Catch ex As Exception
            MsgBox("Falha1: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    Private Function SalvarUsuario(ID) As Integer
        Dim Resp As Boolean
        Dim cn = New OleDbConnection(conn)
        Dim sql
        Try
            If CLng(0 & ID) = 0 Then
                sql = "INSERT INTO Bancos(DataRegistro, CPF, Instituicao, NBanco, NAgencia, Observacoes) 
                        Values (@DataRegistro, @CPF, @Instituicao, @NBanco, @NAgencia, @Observacoes)"
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Instituicao", txtInst.Text)
                        cmd.Parameters.AddWithValue("@NBanco", txtNBan.Text)
                        cmd.Parameters.AddWithValue("@NAgencia", txtNAg.Text)
                        cmd.Parameters.AddWithValue("@Observacoes", txtObs.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Resp = True
            Else
                sql = ("UPDATE Bancos SET  DataRegistro=@DataRegistro, CPF=@CPF, Instituicao=@Instituicao,
                        NBanco=@NBanco, NAgencia=@NAgencia, Observacoes=@Observacoes WHERE id_Bancos =" & ID)
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Instituicao", txtInst.Text)
                        cmd.Parameters.AddWithValue("@NBanco", txtNBan.Text)
                        cmd.Parameters.AddWithValue("@NAgencia", txtNAg.Text)
                        cmd.Parameters.AddWithValue("@Observacoes", txtObs.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Resp = False
            End If
            'Decisão de qual mensasem será apersentada
            If Resp = True Then
                MsgNovo()
            ElseIf Resp = False Then
                MsgAtualizado()
            End If
            PLimpar()
            MostrarPesqUsuarios()
        Catch ex As Exception
            MsgBox("Falha2: Ban " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
        'Return ID
    End Function

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            'SelecionarTudo() 'Seleciona todos os registos
            If VerificaRegistro() Then
                ExcluirRegistros(lblId.Text)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Function VerificaRegistro() As Boolean
        Try
            'Verifica se o item esta selecionado corretamente
            If result = False Then
                MsgBox("Item não selecionado!", vbCritical, "Erro!")
                VerificaRegistro = False
            ElseIf result = True And lblId.Text = "" Then
                MsgBox("Click no botão de Buscar" & vbNewLine & "para efetuar a pesquisa!", vbCritical, "Atenção!")
                VerificaRegistro = False
            ElseIf result = True And DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("ID_Bancos").Value <> lblId.Text Then
                MsgBox("Item selecionado está incorreto!", vbCritical, "Erro!")
                VerificaRegistro = False
            ElseIf lblId.Text = "" Then
                MsgBox("Selecione um item da lista e" & vbNewLine & "click no botão de 'Buscar'" &
                       vbNewLine & "antes de fazer a exclusão!", vbExclamation, Sistema)
                VerificaRegistro = False
            ElseIf result = True And lblId.Text <> "" Then
                VerificaRegistro = True
            End If
            Return VerificaRegistro
        Catch ex As Exception
            MsgBox("Falha Excluir: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    Private Function ExcluirRegistros(ByVal id As String) As Integer
        Dim cn = New OleDbConnection(conn)
        Dim resultado As String
        Try
            resultado = MsgBox("ATENÇÃO!" + Chr(10) + "A exclusão deste item, pode ter um efeito cascata!" +
                               Chr(10) + "" + Chr(10) + "Tem certeza que deseja excluir o ''" & banco.Instituicao & "'' de " & banco.Nome & " ?", vbYesNo +
                               vbCritical, "Exclusão de registro do sistema!")
            If resultado = vbYes Then
                Dim sql = ("Delete from Bancos where id_Bancos =" & id)
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@DataRegistro", txtDataR.Text)
                        cmd.Parameters.AddWithValue("@CPF", cboCPF.Text)
                        cmd.Parameters.AddWithValue("@Instituicao", txtInst.Text)
                        cmd.Parameters.AddWithValue("@NBanco", txtNBan.Text)
                        cmd.Parameters.AddWithValue("@NAgencia", txtNAg.Text)
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
        'Return id
    End Function

    Private Sub TxtNBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNBan.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNAg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNAg.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtInstituicao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInst.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtProcurar_GotFocus(sender As Object, e As EventArgs) Handles TxtProcurar.GotFocus
        If CbCampos.Text = "CPF" Then
            TxtProcurar.Mask = "000,000,000-00"
        End If
    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles cboCPF.GotFocus
        PCarregaDados()
    End Sub
    Private Function PCarregaDados() As Integer
        Dim con As OleDbConnection = Getconnection()
        Try
            'Faz uma pesquisa de CPFs cadastrados
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
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            con.Close()
        End Try

    End Function

    Private Sub CbCampos_Click(sender As Object, e As EventArgs) Handles CbCampos.Click
        PLimpar()
        MostrarPesqUsuarios()
    End Sub
End Class