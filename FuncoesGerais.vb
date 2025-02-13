Module FuncoesGerais 'Funções gerais do sistema
    Public Function VerificarItem(ctrl As Control, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, dgv As DataGridView) As Boolean
        ' Exemplo de como percorrer todos os formulários abertos
        For Each form As Form In Application.OpenForms
            For Each c As Control In ctrl.Controls
                If TypeOf dgv Is DataGridView Then
                    With dgv
                        If e.ColumnIndex = 0 And e.RowIndex <= -1 Then
                            MsgBox("Click na caixa de seleção" &
                                   vbNewLine & "para escolher um item!", vbCritical, "Erro!")
                            VerificarItem = False
                        ElseIf e.ColumnIndex <= -1 And e.RowIndex <= -1 Then
                            For i = .Rows.Count - 1 To 0 Step -1
                                .Rows(i).Selected = False
                                .Rows(i).Cells(0).Value = 0
                            Next
                            MsgBox("Você não pode selecionar tudo," &
                                    vbNewLine & "escolha um item por vez!", vbCritical, "Erro!")
                            VerificarItem = False
                        ElseIf e.ColumnIndex >= 1 And e.RowIndex <= -1 Then
                            VerificarItem = False
                        ElseIf e.ColumnIndex >= 1 And e.RowIndex >= 0 Then
                            .Rows(e.RowIndex).Selected = False
                            MsgBox("Click na caixa de seleção" &
                                   vbNewLine & "para escolher um item!", vbCritical, "Erro!")
                            VerificarItem = False
                        Else
                            .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not .Rows(e.RowIndex).Cells(e.ColumnIndex).Value

                            If .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                                .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
                                .Rows(e.RowIndex).Selected = False
                                result = False
                            Else
                                'Código para percorrer todas as linhas e achar a selecionada
                                For i = .Rows.Count - 1 To 0 Step -1
                                    .Rows(i).Selected = False
                                    .Rows(i).Cells(0).Value = 0
                                Next
                                .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
                                .Rows(e.RowIndex).Selected = True
                                result = True
                            End If
                            VerificarItem = True
                        End If
                    End With
                End If
                Return result
                Exit Function
            Next
        Next
        'Return result
    End Function

    Public Function ValidarEmail(Email As String) As Boolean
        Dim EmailValido = True
        Dim I As Byte
        Dim QtdeCaracteres As Byte

        If Len(Email) < 5 Then 'Não pode ter menos que 5 caracteres
            EmailValido = False
        ElseIf InStr(Email, "@") = 1 Or InStr(Email, ".") = 1 Then 'Não pode começar com @ ou .
            EmailValido = False
        ElseIf InStr(Email, "@") = Len(Email) Or InStr(Email, ".") = Len(Email) Then 'não pode terminar com @ ou com  .
            EmailValido = False
        ElseIf InStr(Email, ".") = 0 Then 'tem que ter pelo menos um .
            EmailValido = False
        ElseIf InStr(Email, "..") > 0 Then 'não pode ter dois pontos (ou mais) seguidos
            EmailValido = False
        Else
            'Verificando a quantidade de @ no email
            QtdeCaracteres = 0
            For I = 1 To Len(Email)
                If Mid(Email, I, 1) = "@" Then
                    QtdeCaracteres += 1 'Quantidade de @
                End If
            Next
            If QtdeCaracteres <> 1 Then 'Só pode ter um @
                EmailValido = False
            End If
        End If

        If EmailValido = True Then
            'Verificando se tem mais de dois pontos depois do @
            QtdeCaracteres = 0
            For I = InStr(Email, "@") To Len(Email)
                If Mid(Email, I, 1) = "." Then
                    QtdeCaracteres += 1 'Quantidade de . depois do @
                End If
            Next
            If QtdeCaracteres > 2 Then 'Só pode ter até dois . depois do @
                EmailValido = False
            End If
        End If

        If EmailValido = True Then
            'Verificar se tem somente caracteres válidos
            Dim Letra As String
            For I = 1 To Len(Email)
                Letra = Mid(Email, I, 1)
                If Not (LCase(Letra) Like "[a-z]" Or Letra = "@" Or Letra = "." Or Letra = "-" Or Letra = "_" Or IsNumeric(Letra)) Then
                    'Tem caracter inválido
                    EmailValido = False
                    Exit For
                End If
            Next
        End If

        ValidarEmail = EmailValido
    End Function

End Module
