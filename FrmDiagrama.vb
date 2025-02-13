Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Imports System.Security.Cryptography

Public Class FrmDiagrama
    Private Sub DeselectAllNodes(treeView As TreeView)
        For Each node As TreeNode In treeView.Nodes
            DeselectNode(node)
        Next
    End Sub
    Private Sub DeselectNode(node As TreeNode)
        'Recolhe todos os nós da TreeView
        TreeView1.CollapseAll()
        ' Recursivamente desmarcar nós filhos
        For Each childNode As TreeNode In node.Nodes
            DeselectNode(childNode)
        Next
    End Sub
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        'Bloquear acesso aos itens abaixo
        If Not BloquearNodes(e) Then
            Exit Sub
        End If
        Try
            'Código a ser executado quando um nó é selecionado
            Select Case e.Node.Name
            'Seleciona o arquivo para abrir
                Case "CadEma"
                    EmailPessoais.MdiParent = FrmPrincipal
                    EmailPessoais.Show()
                Case "CadSit"
                    SitesPessoais.MdiParent = FrmPrincipal
                    SitesPessoais.Show()
                Case "CadCha"
                    ChavePix.MdiParent = FrmPrincipal
                    ChavePix.Show()
                Case "CadRg"
                    LivroRegistro.MdiParent = FrmPrincipal
                    LivroRegistro.Show()
                Case "ConPes"
                    ListaPessoal.MdiParent = FrmPrincipal
                    ListaPessoal.Show()
                Case "ConBan"
                    ListaBancos.MdiParent = FrmPrincipal
                    ListaBancos.Show()
                Case "ConAg"
                    ListaAgencias.MdiParent = FrmPrincipal
                    ListaAgencias.Show()
                Case "ConCar"
                    ListaDeCartoes.MdiParent = FrmPrincipal
                    ListaDeCartoes.Show()
                Case "CosEma"
                    ListaEmails.MdiParent = FrmPrincipal
                    ListaEmails.Show()
                Case "CosSit"
                    ListaSites.MdiParent = FrmPrincipal
                    ListaSites.Show()
                Case "CosCha"
                    ListaPix.MdiParent = FrmPrincipal
                    ListaPix.Show()
                Case "CosRg"
                    ListaRegGeral.MdiParent = FrmPrincipal
                    ListaRegGeral.Show()
                Case "NVReg"
                    FaturaCartao.MdiParent = FrmPrincipal
                    FaturaCartao.Show()
                Case "CadPes"
                    PessoalMasters.MdiParent = FrmPrincipal
                    PessoalMasters.Show()
                Case "CadBan"
                    BancosMasters.MdiParent = FrmPrincipal
                    BancosMasters.Show()
                Case "CadAg"
                    AgenciasMasters.MdiParent = FrmPrincipal
                    AgenciasMasters.Show()
                Case "CadCar"
                    CartoesMasters.MdiParent = FrmPrincipal
                    CartoesMasters.Show()
                Case "CosHT"
                    ExtratoDeMovCartao.MdiParent = FrmPrincipal
                    ExtratoDeMovCartao.Show()
                Case "CosBal"
                    Balancete.MdiParent = FrmPrincipal
                    Balancete.Show()
                Case "CosDash"
                    FrmDashbard.MdiParent = FrmPrincipal
                    FrmDashbard.Show()
                Case "RelCarPer"
                    Call ImprimirFaturas()
                Case "RelCarFlu"
                    Call ImprimirHistorico()
                Case "RelPes"
                    Call ImprimirPessoal()
                Case "RelBan"
                    Call ImprimirBancos()
                Case "RelAg"
                    Call ImprimirAgencias()
                Case "RelCar"
                    Call ImprimirCartao()
                Case "RelCha"
                    Call ImprimirPix()
                Case "RelEma"
                    Call ImprimirEmail()
                Case "RelSit"
                    Call ImprimirSites()
                Case "RelAno"
                    Call ImprimirGerais()
                Case "RelCarCart"
                    Call ImprimirPorCartao()
                Case "RelCarNom"
                    Call ImprimirPorNome()
                Case "RelCarSit"
                    Call ImprimirPorSituacao()
                Case Else
                    MsgBox("Nulo")
            End Select
            'Me.Visible = False
        Catch ex As Exception
            MsgBox("Falha TreeView1_AfterSelect: " & ex.Message)
        End Try
    End Sub
    Private Function BloquearNodes(e As TreeViewEventArgs)
        'Bloquear acesso aos itens abaixo
        If e.Node.Name = "CadPes" Or e.Node.Name = "CadBan" Or e.Node.Name = "CadAg" Or e.Node.Name = "CadCar" Or e.Node.Name = "CosHT" Or e.Node.Name = "CosBal" Then
            If pAcessoPermitido = False Then
                AcessoNegado()
                result = False
            Else
                result = True
            End If
        Else
            result = True
        End If
        Return result
    End Function

End Class