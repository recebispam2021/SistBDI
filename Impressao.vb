Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Drawing.Printing
Module Impressao
    ReadOnly cmd As OleDbCommand
    Private paginaAtual As Integer = 1
    Private MyConnection As OleDbConnection
    Private Leitor As OleDbDataReader
    Private RelatorioTitulo As String
    'Private Pesquisa As String
    Function ImprimirAgencias() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Relação das Agencias Cadastradas - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPageAgencias)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintAgencias)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintAgencias)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha1: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintAgencias(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT a.ID_Agencias, a.DataRegistro, p.Nome, a.CPF, a.Instituicao, a.ContaCorrente, a.LoginUsuario, a.Senha from Agencias a inner join Pessoal p on p.CPF=a.CPF Order by a.ID_Agencias ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageAgencias(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim Nome As String
            Dim CPF As String
            Dim Instituicao As String
            Dim ContaCorrente As String
            Dim LoginUsuario As String
            Dim LoginOriginal As String
            Dim asteriskLogin As String
            Dim Senha As String
            Dim SenhaOriginal As String
            Dim asteriskSenha As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            Dim FonteClipto As Font

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            FonteClipto = New Font("Arial", 9) 'MS Outlook

            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0

            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Agências Bancárias =====", FonteTitulo, Brushes.Red, MargemEsquerda + 150, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 150, 120, New StringFormat())

            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Data", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 110, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 180, 170, New StringFormat())
            e.Graphics.DrawString("Instituição", FonteNegrito, Brushes.Black, MargemEsquerda + 280, 170, New StringFormat())
            e.Graphics.DrawString("Conta", FonteNegrito, Brushes.Black, MargemEsquerda + 400, 170, New StringFormat())
            e.Graphics.DrawString("Login", FonteNegrito, Brushes.Black, MargemEsquerda + 480, 170, New StringFormat())
            e.Graphics.DrawString("Senha", FonteNegrito, Brushes.Black, MargemEsquerda + 550, 170, New StringFormat())

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                Nome = Leitor.GetString(2)
                CPF = Leitor.GetString(3)
                Instituicao = Leitor.GetString(4)
                ContaCorrente = Leitor.GetString(5)
                LoginUsuario = Leitor.GetString(6)
                LoginOriginal = LoginUsuario
                asteriskLogin = New String("*", LoginOriginal.Length)
                Senha = Leitor.GetString(7)
                SenhaOriginal = Senha
                asteriskSenha = New String("*", SenhaOriginal.Length)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 30, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(DataRegistro.Date, FonteNormal, Brushes.Black, MargemEsquerda + 40, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 110, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(CPF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 180, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Instituicao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 280, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(ContaCorrente.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 465, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(asteriskLogin.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 480, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(asteriskSenha.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 560, PosicaoDaLinha, New StringFormat())

                LinhaAtual += 1
            End While

            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())

            'Incrementa o n£mero da pagina
            paginaAtual += 1

            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha2: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintAgencias(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirBancos() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Relação dos Bancos Cadastrados - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPageBancos)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintBancos)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintBancos)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha3: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintBancos(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT * from Bancos Order by ID_Bancos ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageBancos(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim CPF As String
            Dim Instituicao As String
            Dim NBancos As String
            Dim NAgencia As String
            Dim Observacao As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Bancos =====", FonteTitulo, Brushes.Red, MargemEsquerda + 200, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 150, 120, New StringFormat())


            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Data", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 120, 170, New StringFormat())
            e.Graphics.DrawString("Instituição", FonteNegrito, Brushes.Black, MargemEsquerda + 220, 170, New StringFormat())
            e.Graphics.DrawString("Banco", FonteNegrito, Brushes.Black, MargemEsquerda + 340, 170, New StringFormat())
            e.Graphics.DrawString("Agência", FonteNegrito, Brushes.Black, MargemEsquerda + 390, 170, New StringFormat())
            e.Graphics.DrawString("Observação", FonteNegrito, Brushes.Black, MargemEsquerda + 450, 170, New StringFormat())

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                CPF = Leitor.GetString(2)
                Instituicao = Leitor.GetString(3)
                NBancos = Leitor.GetString(4)
                NAgencia = Leitor.GetString(5)
                Observacao = Leitor.GetString(6)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 25, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(DataRegistro.Date, FonteNormal, Brushes.Black, MargemEsquerda + 40, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(CPF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 120, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Instituicao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 220, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(NBancos.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 370, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(NAgencia.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 440, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Observacao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 450, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While

            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha4: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintBancos(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirCartao() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Relação dos Cartões Cadastrados - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPageCartao)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintCartao)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintCartao)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha5: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintCartao(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT c.ID_Cartao, c.DataRegistro, p.Nome, c.CPF, c.Cartao, c.Limite, c.Senha, c.CodSeguranca from Cartao c inner join Pessoal p on p.CPF=c.Cpf Order by ID_Cartao ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageCartao(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            'Variaveis de Texto
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim nome As String
            Dim cpf As String
            Dim Cartao As String
            Dim Limite As Double
            Dim Senha As String
            Dim SenhaOriginal As String
            Dim asteriskSenha As String
            Dim CodSeguranca As String
            Dim CodOriginal As String
            Dim asteriskCod As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)

            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Cartão de Crédito =====", FonteTitulo, Brushes.Red, MargemEsquerda + 170, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 190, 120, New StringFormat())


            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat())
            e.Graphics.DrawString("Data", FonteNegrito, Brushes.Black, MargemEsquerda + 60, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 150, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 230, 170, New StringFormat())
            e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 340, 170, New StringFormat())
            e.Graphics.DrawString("Limite", FonteNegrito, Brushes.Black, MargemEsquerda + 420, 170, New StringFormat())
            e.Graphics.DrawString("Senha", FonteNegrito, Brushes.Black, MargemEsquerda + 510, 170, New StringFormat())
            e.Graphics.DrawString("Seg.", FonteNegrito, Brushes.Black, MargemEsquerda + 580, 170, New StringFormat())

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                nome = Leitor.GetString(2)
                cpf = Leitor.GetString(3)
                Cartao = Leitor.GetString(4)
                Limite = Leitor.GetValue(5)
                Senha = Leitor.GetString(6)
                SenhaOriginal = Senha
                asteriskSenha = New String("*", SenhaOriginal.Length)
                CodSeguranca = Leitor.GetString(7)
                CodOriginal = CodSeguranca
                asteriskCod = New String("*", CodOriginal.Length)
                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 30, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(DataRegistro.Date, FonteNormal, Brushes.Black, MargemEsquerda + 60, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 150, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(cpf.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 230, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Cartao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 340, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Limite.ToString("C"), FonteNormal, Brushes.Red, MargemEsquerda + 500, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(asteriskSenha.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 510, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(asteriskCod.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 580, PosicaoDaLinha, New StringFormat())

                LinhaAtual += 1
            End While
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha6: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintCartao(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirHistorico() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Extrato de Movimentações por Caixa - " & System.DateTime.Today.Year - 1 & "/"
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPageHistorico)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintHistorico)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintHistorico)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintHistorico(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Pesquisa As String
        Dim sql = ""
        Pesquisa = InputBox("Entre com o tipo do extrato simples" & Chr(10) & "ou click em Cancelar o extrato geral!" & Chr(10) & "" & Chr(10) & "'E' para entrada." & Chr(10) & "'S' para saída.", "Pesquisa por Fluxo de Caixa!", "Saída")
        If Pesquisa = "E" Or Pesquisa = "e" Or Pesquisa = "Entrada" Then
            Pesquisa = "Entrada"
        ElseIf Pesquisa = "S" Or Pesquisa = "s" Or Pesquisa = "Saída" Then
            Pesquisa = "Saída"
        End If
        If Pesquisa <> "" Then
            sql = "SELECT top 90 p.Nome, cm.Cartao, cm.FluxoCaixa, cm.LCategorias, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where Consolidada not in('E') AND cm.FluxoCaixa='" & Pesquisa & "' GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.LCategorias, cm.Vencimento, cm.Consolidada order by Vencimento DESC, SUM(cm.Valor) DESC"
        ElseIf Pesquisa = "" Then
            sql = "SELECT top 90 p.Nome, cm.Cartao, cm.FluxoCaixa, cm.LCategorias, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF WHERE Consolidada not in('E') AND cm.FluxoCaixa GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.LCategorias, cm.Vencimento, cm.Consolidada order by cm.Vencimento DESC, SUM(cm.Valor) DESC"
        End If
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageHistorico(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            Dim SenhaPassword = New Char().GetType

            Dim Nome As String
            Dim Cartao As String
            Dim FluxoCaixa As String
            Dim LCategorias As String
            Dim Valor As Double
            Dim TotalS As Double
            'Dim TotalE As Double
            'Dim ValorPago As Double
            Dim Vencimento As Date
            Dim Consolidada As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font

            'Dim EsconderSenha As New(9, SenhaPassword)

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8, FontStyle.Bold)
            FonteNormal = New Font("Arial", 9)

            'EsconderSenha =
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Cartão de Crédito =====", FonteTitulo, Brushes.Red, MargemEsquerda + 160, 80, New StringFormat())
            'Imagem
<<<<<<< Updated upstream
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year + 1, FonteSubTitulo, Brushes.Black, MargemEsquerda + 190, 120, New StringFormat())
=======
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\MySistemBDI\Relatorios\" & "Icone.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 130, 120, New StringFormat())
>>>>>>> Stashed changes

            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat())
            e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 170, New StringFormat())
            e.Graphics.DrawString("Caixa", FonteNegrito, Brushes.Black, MargemEsquerda + 180, 170, New StringFormat())
            e.Graphics.DrawString("Categorias", FonteNegrito, Brushes.Black, MargemEsquerda + 240, 170, New StringFormat())
            e.Graphics.DrawString("Valor", FonteNegrito, Brushes.Black, MargemEsquerda + 380, 170, New StringFormat())
            e.Graphics.DrawString("Mês Venc.", FonteNegrito, Brushes.Black, MargemEsquerda + 470, 170, New StringFormat()) '560
            e.Graphics.DrawString("Consolidada", FonteNegrito, Brushes.Black, MargemEsquerda + 550, 170, New StringFormat())

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                Nome = Leitor.GetString(0)
                Cartao = Leitor.GetString(1)
                FluxoCaixa = Leitor.GetString(2)
                LCategorias = Leitor.GetString(3)
                Valor = Leitor.GetValue(4)
                TotalS += Valor 'Somando os valores
                Vencimento = Leitor.GetValue(5)
                Consolidada = Leitor.GetValue(6)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Cartao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 100, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(FluxoCaixa.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 180, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(LCategorias.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 240, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Valor.ToString("C"), FonteNormal, Brushes.Red, MargemDireita - 180, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Vencimento.Date.ToString("MMMM/yy"), FonteNormal, Brushes.Black, MargemEsquerda + 470, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Consolidada.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 580, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            e.Graphics.DrawString("Total Geral:", FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawString(TotalS.ToString("C") & " C", FonteNegrito, Brushes.Red, MargemDireita - 110, PosicaoDaLinha + 30, New StringFormat())
            'e.Graphics.DrawString(TotalE.ToString("C") & " E", FonteNegrito, Brushes.Black, MargemDireita - 90, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha + 20, MargemDireita, PosicaoDaLinha + 20)
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
        MsgBox("Falha8: T" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintHistorico(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirFaturas() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Extrato por período - " & System.DateTime.Today.Year - 1 & "/"
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPageFaturas)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintFaturas)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintFaturas)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintFaturas(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim a As Date
        Dim b As String
        Dim x As Date
        Dim Pesquisa As String
        a = Today
        b = DateAdd("m", 1, a)
        x = b
        Pesquisa = InputBox("Entre com o mês/ano do extrato simples" & Chr(10) & "ou click em Cancelar o extrato geral!" & Chr(10) & "" & Chr(10) & "Digite o mês por extenso e o ano com dois dígitos!" & Chr(10) & "Ex. janeiro/24", "Pesquisa por período!", Format(x, "MMMM/yy"))
        Dim sql = ""
        If Pesquisa <> "" Then
            sql = "SELECT top 90 cm.DataRegistro, p.Nome, cm.Cartao, cm.LCategorias, SUM(cm.Valor) as Valor, cm.Parcela, format(cm.Vencimento,'MMMM/yy') as Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where Consolidada not in('E') AND  cm.FluxoCaixa and format(cm.Vencimento,'MMMM/yy')='" & Pesquisa & "' GROUP BY cm.DataRegistro, p.Nome, cm.Cartao, cm.LCategorias, cm.Parcela, format(cm.Vencimento,'MMMM/yy'), cm.Consolidada, year(cm.Vencimento), month(cm.Vencimento), day(cm.Vencimento) ORDER BY year(cm.Vencimento) Desc, month(cm.Vencimento) Desc, day(cm.Vencimento) Desc, SUM(cm.Valor) DESC"
        ElseIf Pesquisa = "" Then
            sql = "SELECT top 90 cm.DataRegistro, p.Nome, cm.Cartao, cm.LCategorias, SUM(cm.Valor) as Valor, cm.Parcela, format(cm.Vencimento,'MMMM/yy') as Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where Consolidada not in('E') AND cm.FluxoCaixa GROUP BY cm.DataRegistro, p.Nome, cm.Cartao, cm.LCategorias, cm.Parcela, format(cm.Vencimento,'MMMM/yy'), cm.Consolidada, year(cm.Vencimento), month(cm.Vencimento), day(cm.Vencimento) ORDER BY year(cm.Vencimento) Desc, month(cm.Vencimento) Desc, day(cm.Vencimento) Desc, SUM(cm.Valor) DESC"
        End If
        Dim MyComand As New OleDbCommand(sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageFaturas(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            Dim DataRegistro As Date '2
        Dim Nome As String '3
        Dim Cartao As String '6
            Dim LCategorias As String
            Dim Valor As Double '10
        Dim Valor1 As Double '11
        Dim Parcela As String '13
            Dim Vencimento As Date '14
            Dim Consolidada As String '14

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8, FontStyle.Bold)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Cartão de Crédito =====", FonteTitulo, Brushes.Red, MargemEsquerda + 170, 80, New StringFormat())
            'Imagem
<<<<<<< Updated upstream
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 240, 120, New StringFormat())
        'campos a serem impressos: Codigo e Nome
        e.Graphics.DrawString("Dt Registro", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat())
        e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 170, New StringFormat())
        e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 190, 170, New StringFormat())
        e.Graphics.DrawString("Historico", FonteNegrito, Brushes.Black, MargemEsquerda + 270, 170, New StringFormat())
        e.Graphics.DrawString("V. Gasto", FonteNegrito, Brushes.Black, MargemEsquerda + 430, 170, New StringFormat())
        e.Graphics.DrawString("Parc.", FonteNegrito, Brushes.Black, MargemEsquerda + 510, 170, New StringFormat())
        e.Graphics.DrawString("Mês Venc.", FonteNegrito, Brushes.Black, MargemEsquerda + 560, 170, New StringFormat())
=======
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\MySistemBDI\Relatorios\" & "Icone.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 200, 120, New StringFormat())
            'If Pesquisa <> "" Then
            '    e.Graphics.DrawString("Referência - " & Pesquisa, FonteRodape, Brushes.Black, MargemEsquerda + 260, 140, New StringFormat())
            'End If
            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Registro", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 80, 170, New StringFormat())
            e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 170, 170, New StringFormat())
            e.Graphics.DrawString("Categorias", FonteNegrito, Brushes.Black, MargemEsquerda + 240, 170, New StringFormat())
            e.Graphics.DrawString("Valor", FonteNegrito, Brushes.Black, MargemEsquerda + 400, 170, New StringFormat())
            e.Graphics.DrawString("Parc.", FonteNegrito, Brushes.Black, MargemEsquerda + 480, 170, New StringFormat())
            e.Graphics.DrawString("Venc.", FonteNegrito, Brushes.Black, MargemEsquerda + 530, 170, New StringFormat())
            e.Graphics.DrawString("CS", FonteNegrito, Brushes.Black, MargemEsquerda + 600, 170, New StringFormat())
>>>>>>> Stashed changes

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

            'obtem os valores do datareader
            DataRegistro = Leitor.GetValue(0)
            Nome = Leitor.GetString(1)
            Cartao = Leitor.GetString(2)
                LCategorias = Leitor.GetString(3)
                Valor = Leitor.GetValue(4)
            Valor1 += +Valor 'Somando os valores
            Parcela = Leitor.GetString(5)
                Vencimento = Leitor.GetValue(6)
                Consolidada = Leitor.GetValue(7)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(DataRegistro.Date, FonteNormal, Brushes.Black, MargemEsquerda + 0, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 80, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Cartao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 170, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(LCategorias.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 240, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Valor.ToString("C"), FonteNormal, Brushes.Red, MargemDireita - 160, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Parcela.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 510, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Vencimento.Date.ToString("MMMM/yy"), FonteNormal, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Consolidada.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 610, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            e.Graphics.DrawString("Total Geral:", FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawString(Valor1.ToString("C"), FonteNegrito, Brushes.Red, MargemDireita - 80, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha + 20, MargemDireita, PosicaoDaLinha + 20)
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
        MsgBox("Falha8: *" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintFaturas(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirPix() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Relação das Chaves Pix Cadastradas - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf pdRelatorios_PrintPagePix)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintPix)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintPix)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha9: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintPix(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT ch.ID_Pix, ch.DataRegistro, p.Nome, ch.CPF, ch.Instituicao, ch.Chave from ChavePix ch inner join Pessoal p on p.CPF=ch.CPF Order by ID_Pix ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPagePix(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            'Variaveis de texto
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim Nome As String
            Dim CPF As String
            Dim Instituicao As String
            Dim Chave As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Pix =====", FonteTitulo, Brushes.Red, MargemEsquerda + 230, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 150, 120, New StringFormat())


            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Data", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 110, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 180, 170, New StringFormat())
            e.Graphics.DrawString("Instituição", FonteNegrito, Brushes.Black, MargemEsquerda + 280, 170, New StringFormat())
            e.Graphics.DrawString("Chave", FonteNegrito, Brushes.Black, MargemEsquerda + 400, 170, New StringFormat())


            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                Nome = Leitor.GetString(2)
                CPF = Leitor.GetString(3)
                Instituicao = Leitor.GetString(4)
                Chave = Leitor.GetString(5)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 30, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(DataRegistro.Date, FonteNormal, Brushes.Black, MargemEsquerda + 40, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 110, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(CPF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 180, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Instituicao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 280, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Chave.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 400, PosicaoDaLinha, New StringFormat())

                LinhaAtual += 1
            End While
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha10: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintPix(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirPessoal() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Relação das Pessoais Cadastradas - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf pdRelatorios_PrintPagePessoal)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintPessoal)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintPessoal)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha11: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintPessoal(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT * from Pessoal Order by ID_Pessoal asc"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPagePessoal(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)
            'Variaveis dos dados
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim Nome As String
            Dim Sobrenome As String
            Dim Sexo As String
            Dim DataNascimento As Date
            Dim CPF As String
            Dim Identidade As String
            Dim CNH As String
            Dim Passaporte As String
            Dim TituloEleitor As String
            Dim Endereco As String
            'Dim Numero As Integer
            Dim Complemento As String
            Dim Bairro As String
            Dim Cidade As String
            Dim UF As String
            Dim Celular As String
            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Pessoal =====", FonteTitulo, Brushes.Red, MargemEsquerda + 200, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 150, 120, New StringFormat())
            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat())
            e.Graphics.DrawString("Nasc.", FonteNegrito, Brushes.Black, MargemEsquerda + 110, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 180, 170, New StringFormat())
            e.Graphics.DrawString("Bairro", FonteNegrito, Brushes.Black, MargemEsquerda + 290, 170, New StringFormat())
            e.Graphics.DrawString("Cidade", FonteNegrito, Brushes.Black, MargemEsquerda + 420, 170, New StringFormat())
            e.Graphics.DrawString("UF", FonteNegrito, Brushes.Black, MargemEsquerda + 510, 170, New StringFormat())
            e.Graphics.DrawString("Celular", FonteNegrito, Brushes.Black, MargemEsquerda + 535, 170, New StringFormat())


            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                Nome = Leitor.GetString(2)
                Sobrenome = Leitor.GetString(3)
                Sexo = Leitor.GetString(4)
                DataNascimento = Leitor.GetValue(5)
                CPF = Leitor.GetString(6)
                Identidade = Leitor.GetString(7)
                CNH = Leitor.GetString(8)
                Passaporte = Leitor.GetString(9)
                TituloEleitor = Leitor.GetString(10)
                Endereco = Leitor.GetString(11)
                Complemento = Leitor.GetString(13)
                Bairro = Leitor.GetString(14)
                Cidade = Leitor.GetString(15)
                UF = Leitor.GetString(16)
                Celular = Leitor.GetString(17)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 0, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 40, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(DataNascimento.Date, FonteNormal, Brushes.Black, MargemEsquerda + 110, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(CPF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 180, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Bairro.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 290, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Cidade.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 420, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(UF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 510, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Celular.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 535, PosicaoDaLinha, New StringFormat())

                LinhaAtual += 1
            End While
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha12: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintPessoal(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirSites() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn)
        'define o titulo do relatorio
        RelatorioTitulo = "Relação dos Sites Cadastradas - Ano "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf pdRelatorios_PrintPageSites)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintSites)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintSites)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                pd.DefaultPageSettings.Landscape = True 'Impressão em formato paisagem
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha13: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintSites(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT s.ID_Site, s.DataRegistro, p.Nome, s.NomeSite, s.Endereco, s.LoginUsuario, s.Senha from Sites s inner join Pessoal p on p.CPF=s.CPF Order by ID_Site ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageSites(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            'Variaveis dos dados
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim Nome As String
            Dim NomeSite As String
            Dim Endereco As String
            Dim LoginUsuario As String
            Dim LoginOriginal As String
            Dim asteriskLogin As String
            Dim Senha As String
            Dim SenhaOriginal As String
            Dim asteriskSenha As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Sites =====", FonteTitulo, Brushes.Red, MargemEsquerda + 430, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 350, 120, New StringFormat())
            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 60, 170, New StringFormat())
            e.Graphics.DrawString("Site", FonteNegrito, Brushes.Black, MargemEsquerda + 180, 170, New StringFormat())
            e.Graphics.DrawString("Endereço", FonteNegrito, Brushes.Black, MargemEsquerda + 350, 170, New StringFormat())
            e.Graphics.DrawString("Login/Usuario", FonteNegrito, Brushes.Black, MargemEsquerda + 620, 170, New StringFormat())
            e.Graphics.DrawString("Senha", FonteNegrito, Brushes.Black, MargemEsquerda + 820, 170, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                Nome = Leitor.GetString(2)
                NomeSite = Leitor.GetString(3)
                Endereco = Leitor.GetString(4)
                LoginUsuario = Leitor.GetString(5)
                LoginOriginal = LoginUsuario
                asteriskLogin = New String("*", LoginOriginal.Length)
                Senha = Leitor.GetString(6)
                SenhaOriginal = Senha
                asteriskSenha = New String("*", SenhaOriginal.Length)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 30, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 60, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(NomeSite.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 180, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Endereco.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 350, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(asteriskLogin.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 620, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(asteriskSenha.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 820, PosicaoDaLinha, New StringFormat())

                LinhaAtual += 1
            End While
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha14: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintSites(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirEmail() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn)
        'define o titulo do relatorio
        RelatorioTitulo = "Relação dos Email Cadastrados - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf pdRelatorios_PrintPageEmail)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintEmail)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintEmail)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                pd.DefaultPageSettings.Landscape = True 'Impressão em formato paisagem
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha15: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintEmail(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT e.ID_Email, e.DataRegistro, p.Nome, e.CPF, e.Email, e.Login, e.Senha from Email e inner join Pessoal p on p.CPF=e.CPF Order by ID_Email ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageEmail(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try

            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            'Variaveis dos dados
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim Nome As String
            Dim CPF As String
            Dim Email As String
            Dim Login As String
            Dim LoginOriginal As String
            Dim asteriskLogin As String
            Dim Senha As String
            Dim SenhaOriginal As String
            Dim asteriskSenha As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Emails =====", FonteTitulo, Brushes.Red, MargemEsquerda + 400, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 350, 120, New StringFormat())
            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 60, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 160, 170, New StringFormat())
            e.Graphics.DrawString("Email", FonteNegrito, Brushes.Black, MargemEsquerda + 280, 170, New StringFormat())
            e.Graphics.DrawString("Login", FonteNegrito, Brushes.Black, MargemEsquerda + 560, 170, New StringFormat())
            e.Graphics.DrawString("Senha", FonteNegrito, Brushes.Black, MargemEsquerda + 750, 170, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                Nome = Leitor.GetString(2)
                CPF = Leitor.GetString(3)
                Email = Leitor.GetString(4)
                Login = Leitor.GetString(5)
                LoginOriginal = Login
                asteriskLogin = New String("*", LoginOriginal.Length)
                Senha = Leitor.GetString(6)
                SenhaOriginal = Senha
                asteriskSenha = New String("*", SenhaOriginal.Length)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 30, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 60, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(CPF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 160, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Email.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 280, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(asteriskLogin.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 560, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(asteriskSenha.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 750, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha16: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintEmail(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirGerais() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn)
        'define o titulo do relatorio
        RelatorioTitulo = "Cadastro de Anotações Gerais - "
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf pdRelatorios_PrintPageGerais)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintGerais)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintGerais)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                pd.DefaultPageSettings.Landscape = True 'Impressão em formato paisagem
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha17: " & ex.Message, vbExclamation, Sistema) 'MessageBox.Show(ex.ToString())
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintGerais(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Sql As String = "SELECT r.ID_RG, r.DataRegistro, p.Nome, r.CPF, r.Assunto, r.Observacoes from RegGeral r inner join Pessoal p on p.CPF=r.CPF Order by ID_RG ASC"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPageGerais(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            'Variaveis dos dados
            Dim codigo As Integer
            Dim DataRegistro As Date
            Dim Nome As String
            Dim CPF As String
            Dim Assunto As String
            Dim Observacoes As String
            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8)
            FonteNormal = New Font("Arial", 9)
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Anotações Gerais =====", FonteTitulo, Brushes.Red, MargemEsquerda + 360, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\" & "relatorio.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 370, 120, New StringFormat())
            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cód.", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat())
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat())
            e.Graphics.DrawString("CPF", FonteNegrito, Brushes.Black, MargemEsquerda + 120, 170, New StringFormat())
            e.Graphics.DrawString("Assunto", FonteNegrito, Brushes.Black, MargemEsquerda + 250, 170, New StringFormat())
            e.Graphics.DrawString("Observações", FonteNegrito, Brushes.Black, MargemEsquerda + 650, 170, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())
                'obtem os valores do datareader
                codigo = Leitor.GetInt32(0)
                DataRegistro = Leitor.GetValue(1)
                Nome = Leitor.GetString(2)
                CPF = Leitor.GetString(3)
                Assunto = Leitor.GetString(4)
                Observacoes = Leitor.GetString(5)
                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 30, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 40, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(CPF.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 120, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Assunto.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 250, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Observacoes.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 400, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha18: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintGerais(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirPorCartao() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Extrato de Movimentações por Cartão - " & System.DateTime.Today.Year - 1 & "/"
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPagePorCartao)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintPorCartao)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintPorCartao)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintPorCartao(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Pesquisa As String
        Dim sql = ""
        Pesquisa = InputBox("Entre com o nome do cartão para extrato simples," & Chr(10) & "ou click em Cancelar o extrato geral!", "Pesquisa por cartão!", "American")
        If Pesquisa <> "" Then
            sql = "SELECT top 90 cm.Cartao, p.Nome, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where cm.Cartao='" & Pesquisa & "' GROUP BY cm.Cartao, p.Nome, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by Vencimento DESC, SUM(cm.Valor) DESC"
        ElseIf Pesquisa = "" Then
            sql = "SELECT top 90 cm.Cartao, p.Nome, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF GROUP BY cm.Cartao, p.Nome, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by cm.Vencimento DESC, Sum(cm.Valor) DESC"
        End If
        Dim MyComand As New OleDbCommand(sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPagePorCartao(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            Dim SenhaPassword = New Char().GetType

            Dim Cartao As String
            Dim Nome As String
            Dim FluxoCaixa As String
            Dim Valor As Double
            Dim TotalS As Double
            Dim Vencimento As Date
            Dim Consolidada As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font

            'Dim EsconderSenha As New(9, SenhaPassword)

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8, FontStyle.Bold)
            FonteNormal = New Font("Arial", 9)

            'EsconderSenha =
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Cartão de Crédito =====", FonteTitulo, Brushes.Red, MargemEsquerda + 160, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\MySistemBDI\Relatorios\" & "Icone.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 120, 120, New StringFormat())

            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat()) '+ 180
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 130, 170, New StringFormat())
            e.Graphics.DrawString("Caixa", FonteNegrito, Brushes.Black, MargemEsquerda + 260, 170, New StringFormat()) '+ 240
            e.Graphics.DrawString("Valor", FonteNegrito, Brushes.Black, MargemEsquerda + 380, 170, New StringFormat()) '+ 380
            e.Graphics.DrawString("Mês Venc.", FonteNegrito, Brushes.Black, MargemEsquerda + 470, 170, New StringFormat()) '+ 470
            e.Graphics.DrawString("Consolidada", FonteNegrito, Brushes.Black, MargemEsquerda + 550, 170, New StringFormat()) '+ 550

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                Cartao = Leitor.GetString(0)
                Nome = Leitor.GetString(1)
                FluxoCaixa = Leitor.GetString(2)
                Valor = Leitor.GetValue(3)
                TotalS += Valor 'Somando os valores
                Vencimento = Leitor.GetValue(4)
                Consolidada = Leitor.GetValue(5)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(Cartao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 130, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(FluxoCaixa.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 260, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Valor.ToString("C"), FonteNormal, Brushes.Red, MargemDireita - 180, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Vencimento.Date.ToString("MMMM/yy"), FonteNormal, Brushes.Black, MargemEsquerda + 470, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Consolidada.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 580, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            e.Graphics.DrawString("Total Geral:", FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawString(TotalS.ToString("C") & " C", FonteNegrito, Brushes.Red, MargemDireita - 110, PosicaoDaLinha + 30, New StringFormat())
            'e.Graphics.DrawString(TotalE.ToString("C") & " E", FonteNegrito, Brushes.Black, MargemDireita - 90, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha + 20, MargemDireita, PosicaoDaLinha + 20)
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha8: T" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintPorCartao(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirPorNome() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Extrato de Movimentações por Nome - " & System.DateTime.Today.Year - 1 & "/"
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPagePorNome)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintPorNome)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintPorNome)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintPorNome(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Pesquisa As String
        Dim sql = ""
        Pesquisa = InputBox("Entre com o nome para extrato simples," & Chr(10) & "ou click em Cancelar o extrato geral!", "Pesquisa por nome!", "Claudionor")
        If Pesquisa <> "" Then
            sql = "SELECT top 90 p.Nome, cm.Cartao, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where p.Nome='" & Pesquisa & "' GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by Vencimento DESC, SUM(cm.Valor) DESC"
        ElseIf Pesquisa = "" Then
            sql = "SELECT top 90 p.Nome, cm.Cartao, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by cm.Vencimento DESC, Sum(cm.Valor) DESC, SUM(cm.Valor) DESC"
        End If
        Dim MyComand As New OleDbCommand(sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPagePorNome(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            Dim SenhaPassword = New Char().GetType

            Dim Nome As String
            Dim Cartao As String
            Dim FluxoCaixa As String
            Dim Valor As Double
            Dim TotalS As Double
            Dim Vencimento As Date
            Dim Consolidada As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font

            'Dim EsconderSenha As New(9, SenhaPassword)

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8, FontStyle.Bold)
            FonteNormal = New Font("Arial", 9)

            'EsconderSenha =
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Cartão de Crédito =====", FonteTitulo, Brushes.Red, MargemEsquerda + 160, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\MySistemBDI\Relatorios\" & "Icone.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 120, 120, New StringFormat())

            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat()) '+ 180
            e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 130, 170, New StringFormat())
            e.Graphics.DrawString("Caixa", FonteNegrito, Brushes.Black, MargemEsquerda + 260, 170, New StringFormat()) '+ 240
            e.Graphics.DrawString("Valor", FonteNegrito, Brushes.Black, MargemEsquerda + 380, 170, New StringFormat()) '+ 380
            e.Graphics.DrawString("Mês Venc.", FonteNegrito, Brushes.Black, MargemEsquerda + 470, 170, New StringFormat()) '+ 470
            e.Graphics.DrawString("Consolidada", FonteNegrito, Brushes.Black, MargemEsquerda + 550, 170, New StringFormat()) '+ 550

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                Nome = Leitor.GetString(0)
                Cartao = Leitor.GetString(1)
                FluxoCaixa = Leitor.GetString(2)
                Valor = Leitor.GetValue(3)
                TotalS += Valor 'Somando os valores
                Vencimento = Leitor.GetValue(4)
                Consolidada = Leitor.GetValue(5)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Cartao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 130, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(FluxoCaixa.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 260, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Valor.ToString("C"), FonteNormal, Brushes.Red, MargemDireita - 180, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Vencimento.Date.ToString("MMMM/yy"), FonteNormal, Brushes.Black, MargemEsquerda + 470, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Consolidada.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 580, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            e.Graphics.DrawString("Total Geral:", FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawString(TotalS.ToString("C") & " C", FonteNegrito, Brushes.Red, MargemDireita - 110, PosicaoDaLinha + 30, New StringFormat())
            'e.Graphics.DrawString(TotalE.ToString("C") & " E", FonteNegrito, Brushes.Black, MargemDireita - 90, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha + 20, MargemDireita, PosicaoDaLinha + 20)
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha8: T" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintPorNome(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Function ImprimirPorSituacao() As Integer
        'obtem a string de conexao
        MyConnection = New OleDbConnection(conn) '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\teste\Teste.mdb")
        'define o titulo do relatorio
        RelatorioTitulo = "Extrato de Movimentações por Situação - " & System.DateTime.Today.Year - 1 & "/"
        'define os objetos printdocument e os eventos associados
        Dim pd As New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPagePorSituacao)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_PrintPorSituacao)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_PrintPorSituacao)
        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Sistema de Banco de Dados Integrados"
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Falha7: " & ex.Message, vbExclamation, Sistema)
        End Try
    End Function
    'A conexÆo e o DataReader ‚ aberto aqui
    Private Sub Begin_PrintPorSituacao(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        Dim Pesquisa As String
        Dim sql = ""
        Pesquisa = InputBox("Entre com a situação para extrato simples," & Chr(10) & "ou click em Cancelar o extrato geral!", "Pesquisa por situação!", "Divida")
        If Pesquisa = "Divida" Then
            sql = "SELECT p.Nome, cm.Cartao, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where FluxoCaixa='Saída' AND Consolidada= 'N' GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by Vencimento DESC, SUM(cm.Valor) DESC"
        ElseIf Pesquisa = "Pagamento" Then
            sql = "SELECT p.Nome, cm.Cartao, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF where FluxoCaixa='Entrada' AND Consolidada= 'S' GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by cm.Vencimento DESC, Sum(cm.Valor) DESC, SUM(cm.Valor) DESC"
        ElseIf Pesquisa = "" Then
            sql = "SELECT top 90 p.Nome, cm.Cartao, cm.FluxoCaixa, Sum(cm.Valor) as Valor, cm.Vencimento, cm.Consolidada from CartaoMov cm inner join Pessoal p on p.CPF=cm.CPF GROUP BY p.Nome, cm.Cartao, cm.FluxoCaixa, cm.Vencimento, cm.Consolidada order by cm.Vencimento DESC, Sum(cm.Valor) DESC, SUM(cm.Valor) DESC"
        End If
        Dim MyComand As New OleDbCommand(sql, MyConnection)
        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1
    End Sub
    'Layout da(s) p gina(s) a imprimir
    Private Sub PdRelatorios_PrintPagePorSituacao(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Try
            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0
            Dim LinhaAtual As Integer = 0
            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right
            Dim MargemInferior As Single = e.MarginBounds.Bottom
            Dim CanetaDaImpressora As New Pen(Color.Black, 1)

            Dim SenhaPassword = New Char().GetType

            Dim Nome As String
            Dim Cartao As String
            Dim FluxoCaixa As String
            Dim Valor As Double
            Dim TotalS As Double
            Dim Vencimento As Date
            Dim Consolidada As String

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font

            'Dim EsconderSenha As New(9, SenhaPassword)

            'define efeitos em fontes
            FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
            FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
            FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
            FonteRodape = New Font("Arial", 8, FontStyle.Bold)
            FonteNormal = New Font("Arial", 9)

            'EsconderSenha =
            'define valores para linha atual e para linha da impressao
            LinhaAtual = 0
            Dim L As Integer = 0
            'Cabecalho
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
            'nome da empresa
            e.Graphics.DrawString("===== Cartão de Crédito =====", FonteTitulo, Brushes.Red, MargemEsquerda + 160, 80, New StringFormat())
            'Imagem
            e.Graphics.DrawImage(Image.FromFile("C:\Application Files\MySistemBDI\Relatorios\" & "Icone.gif"), 120, 80)
            e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today.Year, FonteSubTitulo, Brushes.Black, MargemEsquerda + 120, 120, New StringFormat())

            'campos a serem impressos: Codigo e Nome
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat()) '+ 180
            e.Graphics.DrawString("Cartão", FonteNegrito, Brushes.Black, MargemEsquerda + 130, 170, New StringFormat())
            e.Graphics.DrawString("Caixa", FonteNegrito, Brushes.Black, MargemEsquerda + 260, 170, New StringFormat()) '+ 240
            e.Graphics.DrawString("Valor", FonteNegrito, Brushes.Black, MargemEsquerda + 380, 170, New StringFormat()) '+ 380
            e.Graphics.DrawString("Mês Venc.", FonteNegrito, Brushes.Black, MargemEsquerda + 470, 170, New StringFormat()) '+ 470
            e.Graphics.DrawString("Consolidada", FonteNegrito, Brushes.Black, MargemEsquerda + 550, 170, New StringFormat()) '+ 550

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)
            'Aqui sao lidos os dados
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())

                'obtem os valores do datareader
                Nome = Leitor.GetString(0)
                Cartao = Leitor.GetString(1)
                FluxoCaixa = Leitor.GetString(2)
                Valor = Leitor.GetValue(3)
                TotalS += Valor 'Somando os valores
                Vencimento = Leitor.GetValue(4)
                Consolidada = Leitor.GetValue(5)

                'inicia a impressao
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(Nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Cartao.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 130, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(FluxoCaixa.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 260, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Valor.ToString("C"), FonteNormal, Brushes.Red, MargemDireita - 180, PosicaoDaLinha, New StringFormat(StringFormatFlags.DirectionRightToLeft))
                e.Graphics.DrawString(Vencimento.Date.ToString("MMMM/yy"), FonteNormal, Brushes.Black, MargemEsquerda + 470, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(Consolidada.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 580, PosicaoDaLinha, New StringFormat())
                LinhaAtual += 1
            End While
            e.Graphics.DrawString("Total Geral:", FonteNegrito, Brushes.Black, MargemEsquerda, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawString(TotalS.ToString("C") & " C", FonteNegrito, Brushes.Red, MargemDireita - 110, PosicaoDaLinha + 30, New StringFormat())
            'e.Graphics.DrawString(TotalE.ToString("C") & " E", FonteNegrito, Brushes.Black, MargemDireita - 90, PosicaoDaLinha + 30, New StringFormat())
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha + 20, MargemDireita, PosicaoDaLinha + 20)
            'Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            'verifica se continua imprimindo
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MsgBox("Falha8: T" & ex.Message, vbExclamation, Sistema)
        End Try
    End Sub
    'Encerra a conexÆo e o DataReader
    Private Sub End_PrintPorSituacao(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

End Module
