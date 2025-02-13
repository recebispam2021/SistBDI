Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ListaCartao
    Private Sub ListaCartao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        ConfigurarGrade()
    End Sub
    Private Sub ConfigurarGrade()
        Try
            Dim Sql As String = "SELECT ID, Nome, Instituicao, Cartao, (NCartao) as N FROM Cartao where Tipo='Crédito' AND Status='Ativo' Order by id Desc"
            Using cn As New OleDbConnection(conn)
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader

                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("ID", 40, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Nome", 130, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Instituição", 150, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Cartão", 130, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Número", 170, System.Windows.Forms.HorizontalAlignment.Left)
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = Dr.Item("ID")
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("Nome"))
                                .SubItems.Add(Dr.Item("Instituicao"))
                                .SubItems.Add(Dr.Item("Cartao"))
                                .SubItems.Add(Dr.Item("N"))
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
                Dim sql = "select ID, Nome, Instituicao, Cartao, NCartao FROM Cartao Order by id Desc"
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