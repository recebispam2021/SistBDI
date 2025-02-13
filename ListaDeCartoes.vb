Imports System.Data.OleDb

Public Class ListaDeCartoes
    Private Sub ListaCartoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        ConfigurarGrade()
    End Sub
    Private Sub ConfigurarGrade()
        Try
            Dim Sql As String = "SELECT ID_Cartao, Instituicao, Cartao, (NCartao) as N, Status FROM Cartao where Tipo='Crédito' Order by Status, NCartao Asc"
            Using cn As New OleDbConnection(conn)
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader
                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("ID", 40, System.Windows.Forms.HorizontalAlignment.Center)
                            '.Columns.Add("Nome", 110, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Instituição", 150, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Cartão", 110, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Número", 170, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Status", 100, System.Windows.Forms.HorizontalAlignment.Left)
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = Dr.Item("ID_Cartao")
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                '.SubItems.Add(Dr.Item("Nome"))
                                .SubItems.Add(Dr.Item("Instituicao"))
                                .SubItems.Add(Dr.Item("Cartao"))
                                .SubItems.Add(Dr.Item("N"))
                                .SubItems.Add(Dr.Item("Status"))
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

    Private Sub BtnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro3!")
        End Try
    End Sub
End Class