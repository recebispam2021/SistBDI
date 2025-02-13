Imports System.Data.OleDb
Imports System.IO
Imports System.Reflection
Module AcessoBancodeDados

<<<<<<< Updated upstream
<<<<<<< Updated upstream
    ''Conexão geral do Sistema Original
    Public ReadOnly conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\NewProject\Sistema\Projeto de sistema.accdb; Mode=Share Deny None; Jet OLEDB:Database Password=sistbdi2022"
=======
    'Conexão geral do Sistema Original para testes
    Public ReadOnly conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\NewProject\MySistemBDI\Projeto de sistema.accdb; Mode=Share Deny None; Jet OLEDB:Database Password=sistbdi2022"
>>>>>>> Stashed changes

    'Conexão do Backup do Sistema
    Private ReadOnly bancoDados = "Projeto de sistema.accdb"
    Private ReadOnly arquivoOrigem = "c:\NewProject\" + bancoDados
<<<<<<< Updated upstream
    Private ReadOnly pastaDestinoBase = "c:\NewProject\Sistema\BKP"
    Public ReadOnly connB = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SURCE = " + arquivoOrigem + ";Persist Security Info=true;jet OLEDB:Database Password = sistbdi2022"
    'Conexão da Agendda Eletrônica
    Public ReadOnly conArquivoCSV = "c:\NewProject\Sistema\TarefasAgendadas.csv"

    ''***************************NÃO APAGAR ESTE CÓDIGO***********************
    ''Conexão geral do Sistema Alternativa
    'Public ReadOnly conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Application Files\Sistema\Projeto de sistema.accdb; Mode=Share Deny None; Jet OLEDB:Database Password=sistbdi2022"
=======
    Private ReadOnly pastaDestinoBase = "c:\NewProject\MySistemBDI\BKP"
    Public ReadOnly connB = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SURCE = " + arquivoOrigem + ";Persist Security Info=true;jet OLEDB:Database Password = sistbdi2022"
    'Conexão da Agendda Eletrônica
    Public ReadOnly conArquivoCSV = "c:\NewProject\MySistemBDI\TarefasAgendadas.csv"

    ''***************************NÃO APAGAR ESTE CÓDIGO***********************
    ''Conexão geral do Sistema Original para operação
    'Public ReadOnly conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Application Files\MySistemBDI\Projeto de sistema.accdb; Mode=Share Deny None; Jet OLEDB:Database Password=sistbdi2022"
>>>>>>> Stashed changes

    ''Conexão do Backup do Sistema
    'Private ReadOnly bancoDados = "Projeto de sistema.accdb"
    'Private ReadOnly arquivoOrigem = "c:\Application Files\" + bancoDados
<<<<<<< Updated upstream
    'Private ReadOnly pastaDestinoBase = "c:\Application Files\Sistema\BKP"
    'Public ReadOnly connB = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SURCE = " + arquivoOrigem + ";Persist Security Info=true;jet OLEDB:Database Password = sistbdi2022"
    ''Conexão da Agendda Eletrônica
    'Public ReadOnly conArquivoCSV = "c:\Application Files\Sistema\TarefasAgendadas.csv"
=======
    'Private ReadOnly pastaDestinoBase = "c:\Application Files\MySistemBDI\BKP"
    'Public ReadOnly connB = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SURCE = " + arquivoOrigem + ";Persist Security Info=true;jet OLEDB:Database Password = sistbdi2022"
    ''Conexão da Agendda Eletrônica
    'Public ReadOnly conArquivoCSV = "c:\Application Files\MySistemBDI\TarefasAgendadas.csv"
>>>>>>> Stashed changes
=======
    'Public Property DataDirectory As String
    ''Conexão geral do Sistema Original para testes
    'Public ReadOnly conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & [DataDirectory] & "\Application Files\MySistemBDI\SistBDI.accdb; Mode=Share Deny None; Jet OLEDB:Database Password=sistbdi2022"
    'Public resultado As Boolean
    ''Conexão do Backup do Sistema
    'Private ReadOnly bancoDados = "SistBDI.accdb"
    'Private ReadOnly arquivoOrigem = [DataDirectory] & "\Application Files\MySistemBDI\" + bancoDados
    'Private ReadOnly pastaDestinoBase = [DataDirectory] & "\Application Files\MySistemBDI\BKP"
    'Public ReadOnly connB = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SURCE = " + arquivoOrigem + ";Persist Security Info=true;jet OLEDB:Database Password = sistbdi2022"
    ''Conexão da Agendda Eletrônica
    'Public ReadOnly conArquivoCSV = [DataDirectory] & "\Application Files\MySistemBDI\TarefasAgendadas.csv"

    '***************************NÃO APAGAR ESTE CÓDIGO***********************
    Public Property DataDirectory As String
    'Conexão geral do Sistema Original para testes
    Public ReadOnly conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & [DataDirectory] & "\SistBDIMax_2.0\SistBDI.accdb; Mode=Share Deny None; Jet OLEDB:Database Password=sistbdi2022"
    Public resultado As Boolean
    'Conexão do Backup do Sistema
    Private ReadOnly bancoDados = "SistBDI.accdb"
    Private ReadOnly arquivoOrigem = [DataDirectory] & "\SistBDIMax_2.0\" + bancoDados
    Private ReadOnly pastaDestinoBase = [DataDirectory] & "\SistBDIMax_2.0\BKP"
    Public ReadOnly connB = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SURCE = " + arquivoOrigem + ";Persist Security Info=true;jet OLEDB:Database Password = sistbdi2022"
    'Conexão da Agendda Eletrônica
    Public ReadOnly conArquivoCSV = [DataDirectory] & "\SistBDIMax_2.0\TarefasAgendadas.csv"
>>>>>>> Stashed changes
    '*************************************************************************

    Public Function Getconnection() As OleDbConnection
        'Conexão local do Sistema
        Dim sql As String = conn
        Return New OleDbConnection(sql)
    End Function
    Public Sub ObterPasta()
        Dim arqpasta = VerificarPasta(arquivoOrigem)
    End Sub
    Private Function VerificarPasta(arqpasta As String) As Boolean
        Try
            If File.Exists(arqpasta) Then
                resultado = True
                Return True
            Else
                resultado = False
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Falha: " + ex.Message, "Atenção!")
            Return False
        End Try
    End Function

    Public Sub PercorrerAplicação()
        ' Obter o assembly atual
        Dim assembly As Assembly = Assembly.GetExecutingAssembly()
        ' Iterar sobre todos os tipos no assembly
        For Each type As Type In assembly.GetTypes()
            ' Verificar se o tipo é um formulário
            If type.IsSubclassOf(GetType(Form)) Then
                ' Criar uma instância do formulário
                Dim form As Form = CType(Activator.CreateInstance(type), Form)
                If form.TopMost = False Then
                    ' Acessar as propriedades do formulário
                    MsgBox($"Formulário: {form.Name} e TopMost: {form.TopMost}")
                End If
            End If
        Next
    End Sub


    Public Sub FazerCopia()
        Dim pastaDestino = ObterPastaDestino(pastaDestinoBase)
        Try
            If CriarPasta(pastaDestinoBase) Then
                If CriarPasta(pastaDestino) Then
                    File.Copy(arquivoOrigem, pastaDestino + "\" + bancoDados, True)
                    MessageBox.Show("Foi criado uma cópia do sistema no diretório:" + Chr(10) + pastaDestino, "Backup do Sistema!")
                    Exit Try
                End If
            End If
        Catch ix As IOException
            MessageBox.Show("O arquivo '" & bancoDados & "'" & Chr(10) & "já existe, verifique no diretório que foi salvo!", "Falha de Backup!")
            Exit Try
        Catch ex As Exception
            MessageBox.Show("Falha de FazerCopia " & ex.Message, "Falha!")
        End Try
    End Sub

    Private Function ObterPastaDestino(destinoBase) As String
        Dim hoje = Date.Today
        Dim diaSemana = hoje.DayOfWeek
        Dim dataSemana = Format(Today, "ddMMyyyy")
        Select Case diaSemana
            Case 0
                Return destinoBase + "\1-domingo_" + dataSemana
            Case 1
                Return destinoBase + "\2-segunda_" + dataSemana
            Case 2
                Return destinoBase + "\3-terça_" + dataSemana
            Case 3
                Return destinoBase + "\4-quarta_" + dataSemana
            Case 4
                Return destinoBase + "\5-quinta_" + dataSemana
            Case 5
                Return destinoBase + "\6-sexta_" + dataSemana
            Case 6
                Return destinoBase + "\7-sabado_" + dataSemana
            Case Else
                Return destinoBase + "\8-não-identificado_" + dataSemana
        End Select
    End Function
    Private Function CriarPasta(pasta As String) As Boolean
        Try
            If Directory.Exists(pasta) Then
                Return True
            Else
                Directory.CreateDirectory(pasta)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha: " + ex.Message, "Atenção!")
            Return False
        End Try
    End Function
End Module
