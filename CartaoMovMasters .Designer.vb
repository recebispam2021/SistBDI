<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartaoMovMasters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartaoMovMasters))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbCampos = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.lblLegenda = New System.Windows.Forms.Label()
        Me.txtProcurar2 = New System.Windows.Forms.TextBox()
        Me.lblLegenda2 = New System.Windows.Forms.Label()
        Me.lblLegenda3 = New System.Windows.Forms.Label()
        Me.txtProcurar3 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblIdCartaoMov = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCartao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHistorico = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
<<<<<<< Updated upstream
=======
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnResgatar = New System.Windows.Forms.Button()
>>>>>>> Stashed changes
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Controls.Add(Me.btnLimpar)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.btnSair)
        Me.GroupBox1.Controls.Add(Me.btnAlterar)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(91, 622)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1400, 82)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandos:"
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLimpar.Location = New System.Drawing.Point(615, 22)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(170, 39)
        Me.btnLimpar.TabIndex = 14
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.AccessibleDescription = ""
        Me.btnExcluir.AccessibleName = ""
        Me.btnExcluir.BackColor = System.Drawing.Color.Red
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.btnExcluir.Location = New System.Drawing.Point(838, 22)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 39)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSair.Location = New System.Drawing.Point(1061, 22)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(170, 39)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAlterar.Location = New System.Drawing.Point(392, 22)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(170, 39)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAdicionar.Location = New System.Drawing.Point(169, 22)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(170, 39)
        Me.btnAdicionar.TabIndex = 7
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(91, 317)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1400, 222)
        Me.DataGridView1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(89, 252)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Procurar por:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBuscar.Location = New System.Drawing.Point(1340, 278)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(145, 31)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'CbCampos
        '
        Me.CbCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCampos.FormattingEnabled = True
        Me.CbCampos.Items.AddRange(New Object() {"Cartão", "Nome", "Grupo"})
        Me.CbCampos.Location = New System.Drawing.Point(92, 281)
        Me.CbCampos.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCampos.Name = "CbCampos"
        Me.CbCampos.Size = New System.Drawing.Size(197, 28)
        Me.CbCampos.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(91, 553)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(1400, 55)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "R$ 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProcurar
        '
        Me.txtProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcurar.Location = New System.Drawing.Point(301, 283)
        Me.txtProcurar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(240, 26)
        Me.txtProcurar.TabIndex = 2
        Me.txtProcurar.Visible = False
        '
        'lblLegenda
        '
        Me.lblLegenda.AutoSize = True
        Me.lblLegenda.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblLegenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegenda.ForeColor = System.Drawing.SystemColors.Window
        Me.lblLegenda.Location = New System.Drawing.Point(307, 252)
        Me.lblLegenda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegenda.Name = "lblLegenda"
        Me.lblLegenda.Size = New System.Drawing.Size(198, 20)
        Me.lblLegenda.TabIndex = 16
        Me.lblLegenda.Text = "Digite o nome procurado!"
        Me.lblLegenda.Visible = False
        '
        'txtProcurar2
        '
        Me.txtProcurar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcurar2.Location = New System.Drawing.Point(555, 283)
        Me.txtProcurar2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProcurar2.Name = "txtProcurar2"
        Me.txtProcurar2.Size = New System.Drawing.Size(221, 26)
        Me.txtProcurar2.TabIndex = 3
        Me.txtProcurar2.Visible = False
        '
        'lblLegenda2
        '
        Me.lblLegenda2.AutoSize = True
        Me.lblLegenda2.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblLegenda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegenda2.ForeColor = System.Drawing.SystemColors.Window
        Me.lblLegenda2.Location = New System.Drawing.Point(561, 252)
        Me.lblLegenda2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegenda2.Name = "lblLegenda2"
        Me.lblLegenda2.Size = New System.Drawing.Size(204, 20)
        Me.lblLegenda2.TabIndex = 18
        Me.lblLegenda2.Text = "Digite o cartão procurado!"
        Me.lblLegenda2.Visible = False
        '
        'lblLegenda3
        '
        Me.lblLegenda3.AutoSize = True
        Me.lblLegenda3.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblLegenda3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegenda3.ForeColor = System.Drawing.SystemColors.Window
        Me.lblLegenda3.Location = New System.Drawing.Point(796, 252)
        Me.lblLegenda3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegenda3.Name = "lblLegenda3"
        Me.lblLegenda3.Size = New System.Drawing.Size(189, 20)
        Me.lblLegenda3.TabIndex = 20
        Me.lblLegenda3.Text = "Digite o mês procurado!"
        Me.lblLegenda3.Visible = False
        '
        'txtProcurar3
        '
        Me.txtProcurar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcurar3.Location = New System.Drawing.Point(791, 283)
        Me.txtProcurar3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProcurar3.Name = "txtProcurar3"
        Me.txtProcurar3.Size = New System.Drawing.Size(221, 26)
        Me.txtProcurar3.TabIndex = 4
        Me.txtProcurar3.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 787)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'lblIdCartaoMov
        '
        Me.lblIdCartaoMov.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdCartaoMov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdCartaoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCartaoMov.Location = New System.Drawing.Point(724, 54)
        Me.lblIdCartaoMov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdCartaoMov.Name = "lblIdCartaoMov"
        Me.lblIdCartaoMov.Size = New System.Drawing.Size(107, 26)
        Me.lblIdCartaoMov.TabIndex = 14
        Me.lblIdCartaoMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(492, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ID"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(1319, 54)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.MaxLength = 15
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(163, 26)
        Me.txtNome.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(1077, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nome"
        '
        'txtCartao
        '
        Me.txtCartao.Enabled = False
        Me.txtCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCartao.Location = New System.Drawing.Point(1319, 98)
        Me.txtCartao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCartao.Name = "txtCartao"
        Me.txtCartao.Size = New System.Drawing.Size(164, 26)
        Me.txtCartao.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(1077, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Nome do Cartão"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtValor.Location = New System.Drawing.Point(1355, 145)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.MaxLength = 19
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(128, 26)
        Me.txtValor.TabIndex = 50
        Me.txtValor.Text = "0.00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(1077, 150)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 18)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Valor do Lançamento"
        '
        'txtHistorico
        '
        Me.txtHistorico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistorico.Location = New System.Drawing.Point(724, 104)
        Me.txtHistorico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHistorico.MaxLength = 30
        Me.txtHistorico.Multiline = True
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.Size = New System.Drawing.Size(200, 24)
        Me.txtHistorico.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(492, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Histórico"
        '
        'mskVencimento
        '
        Me.mskVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskVencimento.Location = New System.Drawing.Point(724, 150)
        Me.mskVencimento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskVencimento.Mask = "00/00/0000"
        Me.mskVencimento.Name = "mskVencimento"
        Me.mskVencimento.Size = New System.Drawing.Size(127, 26)
        Me.mskVencimento.TabIndex = 18
        Me.mskVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskVencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskVencimento.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(492, 152)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Venc/Pagto"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
<<<<<<< Updated upstream
=======
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(112, 52)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'BtnResgatar
        '
        Me.BtnResgatar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnResgatar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResgatar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnResgatar.Location = New System.Drawing.Point(1187, 279)
        Me.BtnResgatar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnResgatar.Name = "BtnResgatar"
        Me.BtnResgatar.Size = New System.Drawing.Size(145, 31)
        Me.BtnResgatar.TabIndex = 57
        Me.BtnResgatar.Text = "Resgatar"
        Me.BtnResgatar.UseVisualStyleBackColor = False
        Me.BtnResgatar.Visible = False
        '
>>>>>>> Stashed changes
        'CartaoMovMasters
        '
        Me.AcceptButton = Me.BtnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnResgatar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mskVencimento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtHistorico)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCartao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblIdCartaoMov)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblLegenda3)
        Me.Controls.Add(Me.txtProcurar3)
        Me.Controls.Add(Me.lblLegenda2)
        Me.Controls.Add(Me.txtProcurar2)
        Me.Controls.Add(Me.lblLegenda)
        Me.Controls.Add(Me.txtProcurar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.CbCampos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CartaoMovMasters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alteração/Exclusão de Movimentações dos Cartões de Crédito"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents lblLegenda As System.Windows.Forms.Label
    Friend WithEvents txtProcurar2 As System.Windows.Forms.TextBox
    Friend WithEvents lblLegenda2 As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents lblLegenda3 As System.Windows.Forms.Label
    Friend WithEvents txtProcurar3 As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents lblIdCartaoMov As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCartao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHistorico As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mskVencimento As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLimpar As Button
<<<<<<< Updated upstream
=======
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnResgatar As Button
>>>>>>> Stashed changes
End Class
