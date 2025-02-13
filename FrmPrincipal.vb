Imports System.Data.OleDb

Public Class FrmPrincipal
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Dim _click As Boolean = False
    Dim Cont As Integer
    Dim MTempo, MHora
    Dim Sair As Boolean = True
    Dim Log As Boolean = True
    Dim a, b As Date
    Private sT As Date
    Private Sub MostrarAcesso(ByVal id As Long)
        Dim ax As New Exception("Não foi encontrado o Banco de Dados do sistema!")
        Dim sql = "Select * from Usuarios where id=" & id
        Try
            Using cn = New OleDbConnection(conn)
                ObterPasta()
                If resultado = True Then
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                If dr.Read Then
                                    'Mostra a quantidade de acesso
                                    Label4.Text = dr("Acesso") + 1
                                    'Mostra a data/hora do ultimo acesso
                                    Label5.Text = dr("DataHoje")
                                End If
                            End If
                        End Using
                    End Using
                    cn.Close()
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha MostrarAcesso:  " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub SalvarNovoAcesso(ByVal ID As Integer, ByVal MTempo As String)
        Dim ax As New Exception("Não foi encontrado o Banco de Dados do sistema!")
        Dim sql = ("UPDATE Usuarios SET Acesso=@acesso, DataHoje=@DataHoje where ID=" & ID)
        Try
            Using cn = New OleDbConnection(conn)
                ObterPasta()
                If resultado = True Then
                    cn.Open()
                    Using cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Acesso", Label4.Text)
                        cmd.Parameters.AddWithValue("@DataHoje", MTempo)
                        cmd.ExecuteNonQuery()
                    End Using
                    cn.Close()
                Else
                    MsgBox(ax.Message, MsgBoxStyle.Critical, "Erro")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha no SalvarNovoAcesso: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    Private Function DesHabBotoesDoSistema(pIdUsuario)
        If pIdUsuario = 0 Then
            'Desabilita os botoes do sistema
            MenuCadPessoal.Enabled = False
            MenuCadBancos.Enabled = False
            MenuCadAgencias.Enabled = False
            MenuCadCartoes.Enabled = False
            CadastroToolStripMenuItem.Enabled = False
            AlterarToolStripMenuItem.Enabled = False
            AlterarToolStripMenuItem.Enabled = False
            CadastrarUsuariosToolStripMenuItem.Enabled = False
            ConsultarUsuariosToolStripMenuItem.Enabled = False
            TrocarSenhaToolStripMenuItem.Enabled = False
            BDToolStripMenuItem.Enabled = False
            BackUpToolStripMenuItem.Enabled = False
            TipoDeUsuarioToolStripMenuItem.Enabled = False
            CategoriasToolStripMenuItem1.Enabled = False
            ExclusaoToolStripMenuItem.Enabled = False
            Label3.Visible = False
            Label4.Visible = False
            Label6.Visible = False
            Label5.Visible = False
            TssMarcaRegistrada.Visible = False
        ElseIf pIdUsuario = 1 Then
            'Habilita os botoes do sistema
            MenuCadPessoal.Enabled = True
            MenuCadBancos.Enabled = True
            MenuCadAgencias.Enabled = True
            MenuCadCartoes.Enabled = True
            CadastroToolStripMenuItem.Enabled = True
            AlterarToolStripMenuItem.Enabled = True
            CadastrarUsuariosToolStripMenuItem.Enabled = True
            ConsultarUsuariosToolStripMenuItem.Enabled = True
            TrocarSenhaToolStripMenuItem.Enabled = True
            BDToolStripMenuItem.Enabled = True
            BackUpToolStripMenuItem.Enabled = True
            TipoDeUsuarioToolStripMenuItem.Enabled = True
            CategoriasToolStripMenuItem1.Enabled = True
            ExclusaoToolStripMenuItem.Enabled = True
            Label3.Visible = True
            Label4.Visible = True
            Label6.Visible = True
            Label5.Visible = True
            TssMarcaRegistrada.Visible = True
            TssMarcaRegistrada.Text = _label
        Else
            'Habilita parcialmente os botoes do sistema
            MenuCadPessoal.Enabled = True
            MenuCadBancos.Enabled = True
            MenuCadAgencias.Enabled = True
            MenuCadCartoes.Enabled = True
            CadastroToolStripMenuItem.Enabled = True
            AlterarToolStripMenuItem.Enabled = True
            CadastrarUsuariosToolStripMenuItem.Enabled = False
            ConsultarUsuariosToolStripMenuItem.Enabled = True
            TrocarSenhaToolStripMenuItem.Enabled = True
            BDToolStripMenuItem.Enabled = False
            BackUpToolStripMenuItem.Enabled = False
            TipoDeUsuarioToolStripMenuItem.Enabled = True
            CategoriasToolStripMenuItem1.Enabled = True
            ExclusaoToolStripMenuItem.Enabled = True
            Label3.Visible = True
            Label4.Visible = True
            Label6.Visible = True
            Label5.Visible = True
            TssMarcaRegistrada.Visible = True
            TssMarcaRegistrada.Text = _label
        End If
        Return pIdUsuario
    End Function

    Private Sub FrmPrincipal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        'Identificar o usuario no acesso
        MostrarAcesso(pIdUsuario)
        'Habilita/Desabilita os botoes do sistema
        DesHabBotoesDoSistema(pIdUsuario)

        If Not pAcessoPermitido Then
            TipoDeUsuarioToolStripMenuItem.Text = "Offline"
            Exit Sub
        End If
        If pAdministrador Then
            pNomeAdministrador = "Administrador"
            Label3.Location = New Point(685, 7)
            Label4.Location = New Point(760, 7)
        Else
            pNomeAdministrador = "Usuário"
            Label3.Location = New Point(650, 7)
            Label4.Location = New Point(730, 7)
        End If
        TipoDeUsuarioToolStripMenuItem.Text = pNomeAdministrador
    End Sub

    Private Sub FrmPrincipal_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        If pAdministrador Then
            pNomeAdministrador = "Administrador"
        Else
            pNomeAdministrador = "Usuário"
        End If
        TipoDeUsuarioToolStripMenuItem.Text = pNomeAdministrador
    End Sub
    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ano As Integer
        sT = DateAdd("n", 5, Now)
        ano = Year(Today)
        'Nome do sistema
        tssTexto.Text = pNomeSistema
        For Each control As Control In Me.Controls
            If control.GetType Is GetType(MdiClient) Then
                control.BackColor = Color.White
            End If
        Next
        'Contagem do tempo e saudação
        lblTempo.Text = Format(Now, "Long Date")
        lblHorasGeral.Text = Format(Now, "Long Time")
        'Ativa o relógio do sistema
        Timer1.Start()
        MTempo = Now 'define um tempo
        MHora = Hour(MTempo)
        Cont = MHora 'Data/Hora atual completa
        Select Case Cont
            Case Is <= 5
                Label1.Text = "Boa madrugada, seja bem-vindo!"
            Case 6 To 11
                Label1.Text = "Bom dia, seja bem-vindo!"
            Case 12 To 17
                Label1.Text = "Boa tarde, seja bem-vindo!"
            Case Is >= 18
                Label1.Text = "Boa noite, seja bem-vindo!"
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTempo.Text = Format(Now, "Long Date")
        lblHorasGeral.Text = Format(Now, "Long Time")
        If Not pAcessoPermitido Then
            Dim X As Integer
            X = tspbBarra.Value
            tspbBarra.Maximum = 300
            'Tempo total de 5 minutos
            tssPorcentagem.Text = Convert.ToInt32(X / 300 * 100) & "%"
            If sT <= Now And Me.MdiChildren Is Nothing Then
                tspbBarra.Value = 0
                Fechar = True 'Efetua o fechamento do formulário principal
                Application.Exit()
            ElseIf sT <= Now And Me.MdiChildren IsNot Nothing Then
                For Each formularioAtivo In Me.MdiChildren
                    formularioAtivo.Close()
                Next
                tspbBarra.Value = 0
                Fechar = True 'Efetua o fechamento do formulário principal
                Application.Exit()
            Else
                'Contagem de tempo
                tspbBarra.Value += 1
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim formularioAtivo As Form = Me.ActiveMdiChild
        Dim X As Integer
        X = tspbBarra.Value
        Try
            If pAdministrador Then
                'Se for logado como administrador
                tspbBarra.Maximum = 3600 'Intervavo de uma hora
                'Tempo total de 60 minutos
                tssPorcentagem.Text = Convert.ToInt32(X / 3600 * 100) & "%"
                If tspbBarra.Value >= 3600 And formularioAtivo Is Nothing Then 'Contagem do tempo do programa aberto
                    tspbBarra.Value = 0
                    Sair = False 'Administrador esta logado
                    Application.Exit() 'Fechamento do programa
                ElseIf tspbBarra.Value >= 3600 And formularioAtivo IsNot Nothing Then
                    For Each formularioAtivo In Me.MdiChildren
                        formularioAtivo.Close()
                    Next
                Else
                    tspbBarra.Value += 1
                End If
            Else
                'Se for logado como usuário comum
                tspbBarra.Maximum = 7200 'Intervavo de duas hora
                'Tempo total de 120 minutos
                tssPorcentagem.Text = Convert.ToInt32(X / 7200 * 100) & "%"
                If tspbBarra.Value >= 7200 And Application.OpenForms.Count = 1 Then 'Contagem do tempo do programa aberto
                    tspbBarra.Value = 0
                    Sair = False 'Usuário esta logado
                    Application.Restart() 'Fechamento do programa
                ElseIf tspbBarra.Value >= 7200 And formularioAtivo IsNot Nothing Then
                    For Each formularioAtivo In Me.MdiChildren
                        formularioAtivo.Close()
                    Next
                Else
                    tspbBarra.Value += 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Falha no Timer2: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub FrmPrincipal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Not pAcessoPermitido Then
            TipoDeUsuarioToolStripMenuItem.Text = "Offline"
            Exit Sub
        End If
        If pAdministrador Then
            pNomeAdministrador = "Administrador"
        Else
            pNomeAdministrador = "Usuário"
        End If
        TipoDeUsuarioToolStripMenuItem.Text = pNomeAdministrador
    End Sub

    Private Sub CadastrarUsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarUsuariosToolStripMenuItem.Click
        CadUser.MdiParent = Me
        CadUser.Show()
    End Sub

    Private Sub ConsultarUsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarUsuariosToolStripMenuItem.Click
        UsuariosConsulta.MdiParent = Me
        UsuariosConsulta.Show()
    End Sub

    Private Sub TrocarSenhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocarSenhaToolStripMenuItem.Click
        UsuarioTrocarSenha.MdiParent = Me
        UsuarioTrocarSenha.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        InfoSistema.ShowDialog()
    End Sub
    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        CartaoMovMasters.MdiParent = Me
        CartaoMovMasters.Show()
    End Sub

    Private Sub BancosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem3.Click
        Call ImprimirBancos()
    End Sub

    Private Sub CartõesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartõesToolStripMenuItem2.Click
        Call ImprimirCartao()
    End Sub

    Private Sub ChavesPixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChavesPixToolStripMenuItem.Click
        Call ImprimirPix()
    End Sub

    Private Sub PessoalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PessoalToolStripMenuItem1.Click
        Call ImprimirPessoal()
    End Sub

    Private Sub SitesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SitesToolStripMenuItem2.Click
        Call ImprimirSites()
    End Sub

    Private Sub EmailToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem2.Click
        Call ImprimirEmail()
    End Sub

    Private Sub TipoDeUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeUsuarioToolStripMenuItem.Click
        If Not pAdministrador Then
            MsgBox("Logado como usuário padrão!" & Chr(13) & "Acesso limitado!", vbInformation, Sistema)
        Else
<<<<<<< Updated upstream
            MsgBox("Logado como administrador!" & Chr(13) & "Acesso ilimitado ao programa!" & Chr(13) & "" & Chr(13) & "Ultima atualização: 24/09/2024 18:50", vbInformation, Sistema)
=======
            MsgBox("Logado como administrador!" & Chr(13) & "Acesso ilimitado ao programa!" & Chr(13) & "" & Chr(13) & "Ultima atualização: 14/01/2025 18:58", vbInformation, Sistema)
>>>>>>> Stashed changes
        End If
    End Sub

    Private Sub AnotaçõesGeraisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnotacoesGeraisToolStripMenuItem.Click
        Call ImprimirGerais()
    End Sub

    Private Sub AgenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenciasToolStripMenuItem.Click
        Call ImprimirAgencias()
    End Sub

    Private Sub BDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDToolStripMenuItem.Click
        ExcluirTodosBD.MdiParent = Me
        ExcluirTodosBD.Show() 'Exclui todo o banco de dados
    End Sub
    Private Sub PosicaoDosElementos()
        Dim vAltura As Long
        Dim vLargura As Long
        vAltura = Me.Height '664
        vLargura = Me.Width '1155
        'Distancia de cima
        lblHorasGeral.Top = 0.1551204819277108 * vAltura '0.1551204819277108 média da altura
        'Distancia da esquerda
        lblHorasGeral.Left = 0.79653679653679654 * vLargura '0.7965367965367965 média da distancia
        'Distancia de cima
        lblTempo.Top = 0.1144578313253012 * vAltura '0.1144578313253012 média da altura
        'Distancia da esquerda
        lblTempo.Left = 0.79653679653679654 * vLargura '0.7965367965367965 média da distancia
    End Sub

    Private Sub BackUpToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BackUpToolStripMenuItem.Click
        FazerCopia()
    End Sub

    Private Sub MenuCadPessoal_Click(sender As Object, e As EventArgs) Handles MenuCadPessoal.Click
        PessoalMasters.MdiParent = Me
        PessoalMasters.Show()
    End Sub

    Private Sub MenuCadBancos_Click(sender As Object, e As EventArgs) Handles MenuCadBancos.Click
        BancosMasters.MdiParent = Me
        BancosMasters.Show()
    End Sub

    Private Sub MenuCadAgencias_Click(sender As Object, e As EventArgs) Handles MenuCadAgencias.Click
        AgenciasMasters.MdiParent = Me
        AgenciasMasters.Show()
    End Sub

    Private Sub MenuCadCartoes_Click(sender As Object, e As EventArgs) Handles MenuCadCartoes.Click
        CartoesMasters.MdiParent = Me
        CartoesMasters.Show()
    End Sub

    Private Sub MenuCadEmails_Click(sender As Object, e As EventArgs) Handles MenuCadEmails.Click
        EmailPessoais.MdiParent = Me
        EmailPessoais.Show()
    End Sub

    Private Sub MenuCadSites_Click(sender As Object, e As EventArgs) Handles MenuCadSites.Click
        SitesPessoais.MdiParent = Me
        SitesPessoais.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Acesso ao sistema
        Using frm = New LoginUser
            frm.ShowDialog()
            If Not pAcessoPermitido = True Then 'Verifica se o acesso foi negado
                Application.Exit() 'Sai do sistema
                Exit Sub
            Else
                tspbBarra.Value = 0 'Limpar a barra de status
                tssPorcentagem.Text = 0 & "%"
                Timer2.Start()
                LoginToolStripMenuItem.Enabled = False 'Desabilita o menu de login
                LogoffToolStripMenuItem.Enabled = True 'Habilita o menu de logoff
            End If
        End Using
        Sair = True 'Usuário esta logado
    End Sub

    Private Sub LogoffUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffToolStripMenuItem.Click
        Timer2.Stop()
        Sair = False 'Usuário esta logado
        Log = False
        Application.Restart()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ax As InvalidOperationException
            MsgBox("Falha: ", ax.Message, "Falha do sistema!")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Application.OpenForms.Count > 1 Then
            If (MessageBox.Show("Exite formulário aberto, deseja fechar?", "Saída do Sistema!", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                For Each formularioAtivo In Me.MdiChildren
                    formularioAtivo.Close()
                Next
            Else
                e.Cancel = True 'Cancelar o fechamento do formulário principal
                Exit Sub
            End If
        End If

        If Sair = False Then 'Verifica se o usuário esta logado
            'Modificar a quantidade de acesso
            SalvarNovoAcesso(pIdUsuario, MTempo)
            Log = False
            Exit Sub
        End If

        If Fechar = True Then
            'Sai completamente do sistema
            e.Cancel = False 'Efetua o fechamento do formulário principal
            Exit Sub
        End If

        If (MessageBox.Show("Deseja realmente sair do sistema?", "Saída do Sistema!", MessageBoxButtons.YesNo) = DialogResult.No) Then
            e.Cancel = True 'Cancelar o fechamento do formulário principal
        Else
            'Modificar a quantidade de acesso
            SalvarNovoAcesso(pIdUsuario, MTempo)
            Fechar = True
        End If
    End Sub

    Private Sub AgendaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem1.Click
        If Not pAcessoPermitido = True Then 'Verifica se o acesso foi negado
            AcessoNegado()
            Exit Sub
        Else
            FrmAgenda.MdiParent = Me
            FrmAgenda.Show()
        End If
    End Sub
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Try
            FrmDashbard.MdiParent = Me
            FrmDashbard.Show()
        Catch ex As Exception
            MsgBox("Falha no DashboardToolStripMenuItem2: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub

    Private Sub MenuCadChPix_Click(sender As Object, e As EventArgs) Handles MenuCadChPix.Click
        ChavePix.MdiParent = Me
        ChavePix.Show()
    End Sub

    Private Sub MenuCadLGeral_Click(sender As Object, e As EventArgs) Handles MenuCadLGeral.Click
        LivroRegistro.MdiParent = Me
        LivroRegistro.Show()
    End Sub

    Private Sub FrmPrincipal_MdiChildActivate(sender As Object, e As EventArgs) Handles MyBase.MdiChildActivate
        'Este evento será acionado quando um formulário filho for ativado ou desativado
        Dim childForm As Form = Me.ActiveMdiChild
        If childForm IsNot Nothing Then
            DesativarControles()
            PercorrerAplicação()
        Else
            AtivarControles()
        End If
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        FaturaCartao.MdiParent = Me
        FaturaCartao.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem1.Click
        If Not pAdministrador Then
            MsgBox("Você não tem permissão!" & Chr(13) & "Entre como Admin!", vbCritical, "Acesso Negado!")
            Exit Sub
        Else
            CartaoCategMaster.MdiParent = Me
            CartaoCategMaster.Show()
        End If
    End Sub

    Private Sub BalanceteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceteToolStripMenuItem.Click
        Balancete.MdiParent = Me
        Balancete.Show()
    End Sub

    Private Sub HistoricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoToolStripMenuItem.Click
        ExtratoDeMovCartao.MdiParent = Me
        ExtratoDeMovCartao.Show()
    End Sub

    Private Sub ExclusaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExclusaoToolStripMenuItem.Click
        If Not pAdministrador Then
            MsgBox("Você não tem permissão para excluir registro!" & Chr(13) & "Faça login e entre como administrador!", vbCritical, "Acesso Negado!")
            Exit Sub
        Else
            'Acesso ao sistema
            Using frm = New FrmPrincipal
                CartaoMovAltConsulta.MdiParent = Me
                CartaoMovAltConsulta.Show()
            End Using
        End If
    End Sub

    Private Sub DiagramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagramaToolStripMenuItem.Click
        'Acesso ao sistema
        Using frm = New FrmPrincipal
            FrmDiagrama.MdiParent = Me
            FrmDiagrama.Show()
        End Using
    End Sub

    Private Sub PorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem.Click
        Call ImprimirFaturas()
    End Sub

    Private Sub PorCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCaixaToolStripMenuItem.Click
        Call ImprimirHistorico()
    End Sub

    Private Sub PorCartãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCartãoToolStripMenuItem.Click
        ImprimirPorCartao()
    End Sub

    Private Sub PorNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorNomeToolStripMenuItem.Click
        ImprimirPorNome()
    End Sub

    Private Sub PorSituaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorSituaçãoToolStripMenuItem.Click
        ImprimirPorSituacao()
    End Sub
    Private Sub DesativarControles()
        MenuStrip1.Enabled = False
        PictureBox1.Hide()
        lblTempo.Hide()
        lblHorasGeral.Hide()
    End Sub
    Private Sub AtivarControles()
        MenuStrip1.Enabled = True
        PictureBox1.Show()
        lblTempo.Show()
        lblHorasGeral.Show()
    End Sub
End Class
