Module ConfigMensagens
    Public Function MsgNovo()
        Dim _novo As String = ""
        MessageBox.Show("Registro criado com sucesso!", "Alteração no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return _novo
    End Function

    Public Function MsgAtualizado()
        Dim _atualizado As String = ""
        MessageBox.Show("Registro atualizado com sucesso!", "Alteração no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return _atualizado
    End Function

    Public Function MsgExclusao()
        Dim _excluido As String = ""
        MessageBox.Show("Registro excluido com sucesso!", "Alteração no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return _excluido
    End Function

    Public Function MsgNaoExclusao()
        Dim _naoexcluido As String = ""
        MessageBox.Show("O registro não foi excluido!", "Falha na alteração!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return _naoexcluido
    End Function
    Public Function AcessoNegado()
        MessageBox.Show("Você não esta logado!" & Chr(10) & "Faça o login para ter acesso a Agenda!", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return True
    End Function
End Module
