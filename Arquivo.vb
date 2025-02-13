Imports System.IO

Public NotInheritable Class Arquivo
    Private Sub New()

    End Sub
    Public Shared Sub SalvarLista(Listview1 As ListView, arquivo As String)
        Using sw As New StreamWriter(arquivo)
            For Each row As ListViewItem In Listview1.Items
                sw.WriteLine(row.SubItems(0).Text & ";" &
                             row.SubItems(1).Text & ";" &
                             row.SubItems(2).Text & ";" &
                             row.SubItems(3).Text & ";" &
                             row.SubItems(4).Text & ";" &
                             row.SubItems(5).Text)
            Next
        End Using
    End Sub
    Public Shared Sub CarregarLista(Listview1 As ListView, arquivo As String)
        Using sr = New StreamReader(arquivo)

            Dim linha = sr.ReadLine()
            While Not linha Is Nothing
                Listview1.Items.Add(New ListViewItem(linha.Split(";")))
                linha = sr.ReadLine()
            End While
        End Using
    End Sub

    Public Shared Sub Abrir(arquivo As String)
        Try
            Dim starinfo = New ProcessStartInfo()
            starinfo.FileName = arquivo
            Process.Start(starinfo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
