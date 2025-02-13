Imports System.Data.OleDb
Imports System.Windows.Media
Imports ProjSistBDIMax.ConfigCartao

Module LimparBD
    Function ExcluirTudoCartaoMov()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                '********* NÃO ALTERAR SE FOR PAGAMENTOS **********
                'Zera toda divida dos cartões
                Dim sql = "UPDATE Cartao Set Divida=@Divida"
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Divida", 0)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
                'Deleta todos os dados dos cartões consolidados e apagados
                sql = ("DELETE FROM CartaoMov")
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoPessoal()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?" & vbNewLine & "Atenção! esta exclusão tera um efeito cascata!", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM Pessoal")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoBancos()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?" & vbNewLine & "Atenção! esta exclusão tera um efeito cascata!", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM Bancos")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoCartao()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?" & vbNewLine & "Atenção! esta exclusão tera um efeito cascata!", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM Cartao")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoAgencias()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?" & vbNewLine & "Atenção! esta exclusão tera um efeito cascata!", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM Agencias")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoSites()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM Sites")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoEmail()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM Email")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoAnoGerais()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM OutrosAberto")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function

    Function ExcluirTudoPix()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then
                Dim sql = ("DELETE FROM ChavePix")
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function
    Function ExcluirTudoCategorias()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then 'Botão ok selecionado
                Dim sql = ("DELETE FROM Categorias")
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function
    Function ExcluirTudoUsuario()
        Dim resultado As String
        resultado = MsgBox("Tem certeza que deseja excluir TODOS os registros do BD?", MsgBoxStyle.OkCancel, "Confirmação de Exclusão")
        Try
            If resultado = vbOK Then 'Botão ok selecionado
                Dim sql = ("DELETE FROM Usuarios where ID > 2")
                Using cn = New OleDbConnection(conn)
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
                MsgBox("Banco de Dados excluido!", vbExclamation, Sistema)
            Else
                MsgBox("Banco de Dados não foi excluido!", vbExclamation, Sistema)
            End If
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        End Try
        Return resultado
    End Function
End Module
