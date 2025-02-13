<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExtratoDeMovCartao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtratoDeMovCartao))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCartao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNumero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colHistorico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVencimento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQuant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDtFinal = New System.Windows.Forms.DateTimePicker()
        Me.CkbGeral = New System.Windows.Forms.CheckBox()
        Me.txtDtInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblQtdCartao = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtaString = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLimTotalCar = New System.Windows.Forms.Label()
        Me.lblTotalDivida = New System.Windows.Forms.Label()
        Me.lblLimDisp = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPercDiv = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTotalPago = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSaldoConta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnResumo = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colNome, Me.colCartao, Me.colNumero, Me.colHistorico, Me.colValor, Me.colVencimento, Me.colQuant})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(74, 75)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(1047, 442)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 40
        '
        'colNome
        '
        Me.colNome.Text = "Nome"
        Me.colNome.Width = 100
        '
        'colCartao
        '
        Me.colCartao.Text = "Cartão"
        Me.colCartao.Width = 100
        '
        'colNumero
        '
        Me.colNumero.Text = "Número"
        Me.colNumero.Width = 120
        '
        'colHistorico
        '
        Me.colHistorico.Text = "Historico"
        Me.colHistorico.Width = 150
        '
        'colValor
        '
        Me.colValor.Text = "Valor"
        Me.colValor.Width = 100
        '
        'colVencimento
        '
        Me.colVencimento.Text = "Vencimento"
        Me.colVencimento.Width = 100
        '
        'colQuant
        '
        Me.colQuant.Text = "Quant"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.txtDtFinal)
        Me.GroupBox1.Controls.Add(Me.CkbGeral)
        Me.GroupBox1.Controls.Add(Me.txtDtInicial)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(74, 610)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1427, 83)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa por período:"
        '
        'txtDtFinal
        '
        Me.txtDtFinal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDtFinal.Location = New System.Drawing.Point(629, 27)
        Me.txtDtFinal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDtFinal.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.txtDtFinal.Name = "txtDtFinal"
        Me.txtDtFinal.Size = New System.Drawing.Size(169, 28)
        Me.txtDtFinal.TabIndex = 28
        '
        'CkbGeral
        '
        Me.CkbGeral.AutoSize = True
        Me.CkbGeral.Location = New System.Drawing.Point(808, 32)
        Me.CkbGeral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CkbGeral.Name = "CkbGeral"
        Me.CkbGeral.Size = New System.Drawing.Size(18, 17)
        Me.CkbGeral.TabIndex = 22
        Me.CkbGeral.UseVisualStyleBackColor = True
        Me.CkbGeral.Visible = False
        '
        'txtDtInicial
        '
        Me.txtDtInicial.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDtInicial.Location = New System.Drawing.Point(315, 27)
        Me.txtDtInicial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDtInicial.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.txtDtInicial.Name = "txtDtInicial"
        Me.txtDtInicial.Size = New System.Drawing.Size(169, 28)
        Me.txtDtInicial.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(503, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 22)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Data Final:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(196, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Data Início:"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnPesquisar.Location = New System.Drawing.Point(1109, 27)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(121, 33)
        Me.btnPesquisar.TabIndex = 4
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(845, 31)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 22)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Filtrado por:"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(971, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 33)
        Me.Label11.TabIndex = 21
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label11.Visible = False
        '
        'lblQtdCartao
        '
        Me.lblQtdCartao.BackColor = System.Drawing.SystemColors.Window
        Me.lblQtdCartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdCartao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQtdCartao.Location = New System.Drawing.Point(74, 525)
        Me.lblQtdCartao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQtdCartao.Name = "lblQtdCartao"
        Me.lblQtdCartao.Size = New System.Drawing.Size(1047, 33)
        Me.lblQtdCartao.TabIndex = 7
        Me.lblQtdCartao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1046, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Histórico de Dívidas no Cartão de Crédito"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLimpar.Location = New System.Drawing.Point(77, 34)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(89, 33)
        Me.btnLimpar.TabIndex = 1
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'txtaString
        '
        Me.txtaString.AutoSize = True
        Me.txtaString.Location = New System.Drawing.Point(183, 759)
        Me.txtaString.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtaString.Name = "txtaString"
        Me.txtaString.Size = New System.Drawing.Size(0, 16)
        Me.txtaString.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(74, 566)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1047, 33)
        Me.Label2.TabIndex = 13
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLimTotalCar
        '
        Me.lblLimTotalCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLimTotalCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimTotalCar.Location = New System.Drawing.Point(76, 50)
        Me.lblLimTotalCar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimTotalCar.Name = "lblLimTotalCar"
        Me.lblLimTotalCar.Size = New System.Drawing.Size(198, 32)
        Me.lblLimTotalCar.TabIndex = 15
        Me.lblLimTotalCar.Text = "R$ 0,00"
        Me.lblLimTotalCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDivida
        '
        Me.lblTotalDivida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDivida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDivida.Location = New System.Drawing.Point(76, 109)
        Me.lblTotalDivida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDivida.Name = "lblTotalDivida"
        Me.lblTotalDivida.Size = New System.Drawing.Size(197, 32)
        Me.lblTotalDivida.TabIndex = 16
        Me.lblTotalDivida.Text = "R$ 0,00"
        Me.lblTotalDivida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLimDisp
        '
        Me.lblLimDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLimDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimDisp.Location = New System.Drawing.Point(76, 229)
        Me.lblLimDisp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimDisp.Name = "lblLimDisp"
        Me.lblLimDisp.Size = New System.Drawing.Size(197, 32)
        Me.lblLimDisp.TabIndex = 17
        Me.lblLimDisp.Text = "R$ 0,00"
        Me.lblLimDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblPercDiv)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblTotalPago)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblSaldoConta)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblLimDisp)
        Me.GroupBox2.Controls.Add(Me.lblTotalDivida)
        Me.GroupBox2.Controls.Add(Me.lblLimTotalCar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1151, 124)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(349, 393)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Área de Calculos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(76, 325)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 17)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Crédito usado"
        '
        'lblPercDiv
        '
        Me.lblPercDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercDiv.Location = New System.Drawing.Point(76, 347)
        Me.lblPercDiv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercDiv.Name = "lblPercDiv"
        Me.lblPercDiv.Size = New System.Drawing.Size(197, 32)
        Me.lblPercDiv.TabIndex = 25
        Me.lblPercDiv.Text = "0%"
        Me.lblPercDiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(76, 148)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Total dos pagtos:"
        '
        'lblTotalPago
        '
        Me.lblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPago.Location = New System.Drawing.Point(76, 170)
        Me.lblTotalPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPago.Name = "lblTotalPago"
        Me.lblTotalPago.Size = New System.Drawing.Size(197, 32)
        Me.lblTotalPago.TabIndex = 23
        Me.lblTotalPago.Text = "R$ 0,00"
        Me.lblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 266)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Saldo da conta"
        '
        'lblSaldoConta
        '
        Me.lblSaldoConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldoConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoConta.ForeColor = System.Drawing.Color.Red
        Me.lblSaldoConta.Location = New System.Drawing.Point(76, 288)
        Me.lblSaldoConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldoConta.Name = "lblSaldoConta"
        Me.lblSaldoConta.Size = New System.Drawing.Size(197, 32)
        Me.lblSaldoConta.TabIndex = 21
        Me.lblSaldoConta.Text = "R$ 0,00"
        Me.lblSaldoConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 207)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Limite disponível"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 87)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total da dívida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Limite total do cartão:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btnResumo)
        Me.GroupBox3.Controls.Add(Me.btnLimpar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1151, 30)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(349, 84)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comando"
        '
        'btnResumo
        '
        Me.btnResumo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnResumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnResumo.Location = New System.Drawing.Point(171, 34)
        Me.btnResumo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResumo.Name = "btnResumo"
        Me.btnResumo.Size = New System.Drawing.Size(103, 33)
        Me.btnResumo.TabIndex = 0
        Me.btnResumo.Text = "Resumo"
        Me.btnResumo.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1150, 525)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(351, 72)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Legendas"
        Me.GroupBox4.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Chocolate
        Me.Label10.Location = New System.Drawing.Point(250, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Excluida"
        Me.Label10.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(166, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Atrasada"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(31, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Paga"
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Próxima"
        Me.Label3.UseWaitCursor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 737)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(143, 20)
        Me.tssTexto.Text = "Texto de mensagem"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label16.Location = New System.Drawing.Point(74, 702)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1427, 27)
        Me.Label16.TabIndex = 28
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExtratoDeMovCartao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 763)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaString)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblQtdCartao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExtratoDeMovCartao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCartao As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNumero As System.Windows.Forms.ColumnHeader
    Friend WithEvents colValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVencimento As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblQtdCartao As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtaString As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colNome As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHistorico As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblLimTotalCar As System.Windows.Forms.Label
    Friend WithEvents lblTotalDivida As System.Windows.Forms.Label
    Friend WithEvents lblLimDisp As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents colQuant As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoConta As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnResumo As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDtInicial As DateTimePicker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents CkbGeral As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTotalPago As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPercDiv As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDtFinal As DateTimePicker
End Class
