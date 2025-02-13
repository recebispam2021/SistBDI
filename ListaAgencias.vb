Imports System.Data.OleDb

Public Class ListaAgencias
    Private Sub ListaAgencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        ConfigurarGrade()
    End Sub
    Private Sub ConfigurarGrade()
        Try
            Dim Sql As String = "SELECT ID_Agencias, DataRegistro, Instituicao, NAgencia, ContaCorrente FROM Agencias Order by DataRegistro, NAgencia Asc"
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
                            .Columns.Add("Agencia", 100, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("Conta Corrente", 130, System.Windows.Forms.HorizontalAlignment.Center)
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = Dr.Item("ID_Agencias")
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("DataRegistro"))
                                .SubItems.Add(Dr.Item("Instituicao"))
                                .SubItems.Add(Dr.Item("NAgencia"))
                                .SubItems.Add(Dr.Item("ContaCorrente"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha de ConfigurarGrade: " & ex.Message, vbExclamation, "Erro1!")
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