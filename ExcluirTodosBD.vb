Public Class ExcluirTodosBD

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Resposta As String
        Resposta = cboPesquisar.SelectedItem
        Select Case Resposta
            Case Is = Nothing
                MessageBox.Show("Por favor, selecione ou digite um item", "Erro!")
                Exit Sub
            Case Is = "Fluxo de Caixa"
                Call ExcluirTudoCartaoMov() 'Excluir todos os registros, limpar o sistema
            Case Is = "Agências"
                Call ExcluirTudoAgencias() 'Excluir todos os registros, limpar o sistema
            Case Is = "Bancos"
                Call ExcluirTudoBancos() 'Excluir todos os registros, limpar o sistema
            Case Is = "Cartões"
                Call ExcluirTudoCartao()'Excluir todos os registros, limpar o sistema
            Case Is = "Pessoal"
                Call ExcluirTudoPessoal() 'Excluir todos os registros, limpar o sistema
            Case Is = "Sites"
                Call ExcluirTudoSites() 'Excluir todos os registros, limpar o sistema
            Case Is = "Email"
                Call ExcluirTudoEmail() 'Excluir todos os registros, limpar o sistema
            Case Is = "Anotações Gerais"
                Call ExcluirTudoAnoGerais() 'Excluir todos os registros, limpar o sistema
            Case Is = "Chaves Pix"
                Call ExcluirTudoPix() 'Excluir todos os registros, limpar o sistema
            Case Is = "Categorias"
                Call ExcluirTudoCategorias() 'Excluir todos os registros, limpar o sistema
            Case Is = "Usuários"
                Call ExcluirTudoUsuario() 'Excluir todos os registros, limpar o sistema
        End Select
        Me.Close()
    End Sub
    Private Sub ExcluirTodosBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tssTexto.Text = pNomeSistema
    End Sub

End Class