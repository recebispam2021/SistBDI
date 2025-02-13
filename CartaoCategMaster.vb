Imports System.Data.OleDb
Public Class CartaoCategMaster
    Dim result As Boolean
    Private Function ValidarForm(result)
        For Each controle As Control In Me.Controls
            If TypeOf controle Is TextBox Then
                Dim txt As TextBox = TryCast(controle, TextBox)
                If txt.Text = String.Empty Then
                    result = False
                Else
                    result = True
                End If
            End If
        Next
        Return result
    End Function
    Private Sub BtnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGravar.Click
        If ValidarForm(result) Then
            SalvarCategorias(CLng(0 & lblidCateg.Text))
        End If
    End Sub
    Private Sub SalvarCategorias(ByVal Id As Integer)
        Id = CLng(0 & lblidCateg.Text)
        Dim cn = New OleDbConnection(conn)
        Dim sql As String
        If Id = 0 Then
            sql = "INSERT INTO Categorias(DataRegistro, LCategorias) Values (@DataRegistro, @LCategorias)"
            MsgBox("A categoria foi salva com sucesso!", vbExclamation, Sistema)
        Else
            sql = "UPDATE Categorias set DataRegistro=@DataRegistro, LCategorias=@LCategorias where id=" & Id
            MsgBox("A categoria foi alterada com sucesso!", vbExclamation, Sistema)
        End If
        Try
            Using cn
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@DataRegistro", TxtDataR.Text)
                    cmd.Parameters.AddWithValue("@LCategorias", TxtCategorias.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            ConfigurarGrade()
            PLimpar()
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CartaoCategMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
        ConfigurarGrade()
    End Sub
    Private Sub ConfigurarGrade()
        Dim Sql As String = "SELECT ID, DataRegistro, LCategorias FROM Categorias Order by LCategorias"
        Dim cn As New OleDbConnection(conn)
        Try
            Using cn
                cn.Open()
                Using Cmd As New OleDbCommand(Sql, cn)
                    Using Dr As OleDbDataReader = Cmd.ExecuteReader
                        ' Colocando Nomes nas colunas do ListView:
                        With ListView1
                            .Clear()
                            .Columns.Add("ID", 50, System.Windows.Forms.HorizontalAlignment.Center)
                            .Columns.Add("DataRegistro", 130, System.Windows.Forms.HorizontalAlignment.Left)
                            .Columns.Add("Categorias", 190, System.Windows.Forms.HorizontalAlignment.Left)
                        End With
                        ' Povoando o ListView
                        While Dr.Read
                            Dim Dt As String = Dr.Item("ID")
                            Dim Ls As New ListViewItem(Dt, 1)
                            With Ls
                                .SubItems.Add(Dr.Item("DataRegistro"))
                                .SubItems.Add(Dr.Item("LCategorias"))
                                ListView1.Items.Add(Ls)
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro!")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            'Verifica se há item(s) na lista
            If (ListView1.SelectedItems.Count > 0) Then
                'Envia o item selecionado para o cadastro de movimentação
                lblidCateg.Text = ListView1.SelectedItems(0).SubItems(0).Text
                TxtDataR.Text = ListView1.SelectedItems(0).SubItems(1).Text
                TxtCategorias.Text = ListView1.SelectedItems(0).SubItems(2).Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Erro4!")
        End Try
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If lblidCateg.Text <> "" Then
            ExcluirRegistros(CLng(0 & lblidCateg.Text))
        End If
    End Sub
    Private Sub ExcluirRegistros(ByVal id As String)
        Dim sql = "Delete * from Categorias where id =" & id
        Dim resultado As String
        Dim cn = New OleDbConnection(conn)
        resultado = MsgBox("Tem certeza que deseja excluir este registro?", vbYesNo + vbCritical, "Exclusão de registro!")
        Try
            If resultado = vbYes Then
                Using cn
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@DataRegistro", TxtDataR.Text)
                        cmd.Parameters.AddWithValue("@LCategorias", TxtCategorias.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                End Using
                MsgBox("Cadastro excluido com sucesso!", vbExclamation, Sistema)
            Else
                MsgBox("Cadastro não excluido!", vbExclamation, Sistema)
            End If
            ConfigurarGrade()
            PLimpar()
        Catch ex As Exception
            MsgBox("Falha5: " & ex.Message, vbExclamation, Sistema)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub PLimpar()
        lblidCateg.Text = String.Empty
        For Each controle As Control In Me.Controls
            If TypeOf controle Is TextBox Then
                Dim txt As TextBox = TryCast(controle, TextBox)
                txt.Text = String.Empty
            End If
        Next
    End Sub
End Class