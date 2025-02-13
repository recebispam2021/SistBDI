Imports System.Data.OleDb

Public Class ListaDeResumo
    Private Sub ListaCartao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        ConfigurarGrade()
    End Sub
    Private Sub ConfigurarGrade()
        Try
            Dim sql = "SELECT p.nome AS Nome, p.CPF As CPF,b.Instituicao As Banco,a.NAgencia As Agencia,c.Cartao As Cartão,c.Status As Status,c.Limite As Limite,a.ContaCorrente As Conta,a.LoginUsuario As Usuário,a.EmailCadastro As Email,t.Chave As Chaves_Pix,b.Observacoes As Observações FROM (pessoal p LEFT JOIN (chavepix t LEFT JOIN (bancos b LEFT JOIN (agencias a LEFT JOIN cartao c On (((a.ID_Agencias = c.ID_Agencias) And (c.CPF = a.CPF)))) On ((b.ID_Bancos = a.ID_Bancos))) On ((b.ID_Bancos = t.ID_Bancos))) On ((p.CPF = t.CPF))) ORDER BY b.Instituicao desc"
            Using cn As New OleDbConnection(conn)
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader

                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("Nome", 40, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("CPF", 110, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Banco", 110, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Agencia", 110, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Cartao", 150, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Status", 40, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Limite", 130, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Conta", 130, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Usuario", 130, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Email", 130, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Chave", 130, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Observação", 130, System.Windows.Forms.HorizontalAlignment.Center)
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = Dr.Item("Nome")
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("CPF"))
                                .SubItems.Add(Dr.Item("Banco"))
                                .SubItems.Add("")
                                .SubItems.Add("")
                                .SubItems.Add("")
                                .SubItems.Add(Dr.Item("Limite"))
                                ListView1.Items.Add(Ls)
                                .SubItems.Add(Dr.Item("a.ContaCorrente"))
                                ListView1.Items.Add(Ls)
                                .SubItems.Add(Dr.Item("a.LoginUsuario"))
                                ListView1.Items.Add(Ls)
                                .SubItems.Add(Dr.Item("a.EmailCadastro"))
                                ListView1.Items.Add(Ls)
                                .SubItems.Add(Dr.Item("t.Chave"))
                                ListView1.Items.Add(Ls)
                                .SubItems.Add(Dr.Item("b.Observacoes"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro1!")
        End Try
    End Sub
    Private Sub MostrarUsuarios()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Dim sql = "select ID_Pessoal, DataRegistro, Nome, DataNascimento, Cidade, UF, Celular FROM Pessoal Order by id Desc"
                Dim cmd As New OleDb.OleDbCommand(sql, cn)
                ' Executa a consulta criando um datareader
                Dim dr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.Default)
                ' exibe o resultado no listbox
                Dim texto As String = ""
                Dim i As Integer
                'percorre o datareader
                Do While dr.Read
                    'le o primeiro campo do datareader
                    texto = dr.Item(0).ToString
                    For i = 1 To dr.FieldCount - 1
                        texto &= vbTab & dr.Item(i).ToString
                    Next i
                Loop
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro2!")
        End Try
    End Sub
    Private Sub BtnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro3!")
        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            'Verifica se há item(s) na lista
            If (ListView1.SelectedItems.Count > 0) Then
                'Envia o item selecionado para o cadastro de movimentação
                FaturaCartao.CboNCartao.SelectedValue = ListView1.SelectedItems(0).SubItems(0).Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro4!")
        End Try
    End Sub
End Class