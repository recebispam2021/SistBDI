Imports System.Globalization

Module ConfgCaracteres 'Funções de modificação de letras e números
    Public Function PrimeiraLetraMaiuscula(ByVal str As String) As String
        PrimeiraLetraMaiuscula = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower())
    End Function

    Public Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If
        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function

    Public Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
            Case 44
                SoNumeros = Keyascii
            Case 45
                SoNumeros = Keyascii
        End Select
    End Function
End Module
