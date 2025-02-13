Imports System.Data.OleDb

Public Class ListaBancos
    Private Sub ListaBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        ConfigurarGrade()
    End Sub
    Private Sub ConfigurarGrade()
        Try
            Dim Sql As String = "SELECT ID_Bancos, DataRegistro, Instituicao, NBanco, NAgencia, Observacoes FROM Bancos Order by DataRegistro, NBanco, NAgencia Asc"
            Using cn As New OleDbConnection(conn)
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader

                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("ID", 40, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Registro", 110, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Instituição", 150, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Número", 80, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Agencia", 80, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Observação", 200, System.Windows.Forms.HorizontalAlignment.Left)
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = Dr.Item("ID_Bancos")
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("DataRegistro"))
                                .SubItems.Add(Dr.Item("Instituicao"))
                                .SubItems.Add(Dr.Item("NBanco"))
                                .SubItems.Add(Dr.Item("NAgencia"))
                                .SubItems.Add(Dr.Item("Observacoes"))
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