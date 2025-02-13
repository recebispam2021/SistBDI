Imports System.Data.SqlClient
Public Class BackupSist
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;User ID=Admin;Password=sistbdi2022;Initial Catalog=Master;Server=MySqlServer"
        Dim sqlUtils As New SQLServer

        Dim databases() As String = sqlUtils.ObtemBancoDeDadosSQLSever(conexaoSQLServer)
        Dim listaDB As String

        For Each listaDB In databases
            lstBDSQLServer.Items.Add(listaDB)
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlUtils As New SQLServer
        Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;User ID=Admin;Password=sistbdi2022;Initial Catalog=Master;Server=MySqlServer"
        Try
            sqlUtils.BackupDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, "C:\Application Files\Backup-bkp")
            MsgBox("BACKUP DO BANCO DE DADOS " & lstBDSQLServer.SelectedItem & " FEITO COM SUCESSO !")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;User ID=Admin;Password=sistbdi2022;Initial Catalog=Master;Server=MySqlServer"
        Dim sqlUtils As New SQLServer
        Try
            sqlUtils.RestauraDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, "C:\Application Files\Sistema\Backup.bak")
            MsgBox("RESTAURAÇÃO DO BANCO DE DADOS  " & lstBDSQLServer.SelectedItem & "  EFETUADA COM SUCESSO !")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackupSist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
    End Sub
End Class