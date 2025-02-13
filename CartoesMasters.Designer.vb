<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartoesMasters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartoesMasters))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtProcurar = New System.Windows.Forms.TextBox()
        Me.CbCampos = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CboStatus = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mskNCartao = New System.Windows.Forms.MaskedTextBox()
        Me.txtDiaFecha = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblIdAgencias = New System.Windows.Forms.Label()
        Me.cboInst = New System.Windows.Forms.ComboBox()
        Me.txtDiaVenc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboCPF = New System.Windows.Forms.ComboBox()
        Me.mskValidade = New System.Windows.Forms.MaskedTextBox()
        Me.CboTipo = New System.Windows.Forms.ComboBox()
        Me.txtCSeg = New System.Windows.Forms.TextBox()
        Me.txtSenCartao = New System.Windows.Forms.TextBox()
        Me.txtCartao = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.lblNBan = New System.Windows.Forms.Label()
        Me.txtDataR = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Controls.Add(Me.BtnLimpar)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkPass)
        Me.GroupBox1.Controls.Add(Me.BtnSair)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(76, 669)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1400, 71)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandos:"
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExcluir.BackColor = System.Drawing.Color.Red
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnExcluir.Location = New System.Drawing.Point(830, 16)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(107, 43)
        Me.BtnExcluir.TabIndex = 24
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.Location = New System.Drawing.Point(665, 16)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(107, 43)
        Me.BtnLimpar.TabIndex = 23
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSalvar.Location = New System.Drawing.Point(498, 16)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(107, 43)
        Me.BtnSalvar.TabIndex = 22
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(317, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'chkPass
        '
        Me.chkPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkPass.AutoSize = True
        Me.chkPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPass.ForeColor = System.Drawing.SystemColors.Window
        Me.chkPass.Location = New System.Drawing.Point(296, 30)
        Me.chkPass.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(18, 17)
        Me.chkPass.TabIndex = 21
        Me.chkPass.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSair.Location = New System.Drawing.Point(997, 16)
        Me.BtnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(107, 43)
        Me.BtnSair.TabIndex = 25
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel})
        Me.DataGridView1.Location = New System.Drawing.Point(76, 428)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1400, 222)
        Me.DataGridView1.TabIndex = 26
        '
        'Sel
        '
        Me.Sel.HeaderText = ""
        Me.Sel.MinimumWidth = 6
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        Me.Sel.Width = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(73, 367)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Procurar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(285, 367)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Critérios:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBuscar.Location = New System.Drawing.Point(1310, 386)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(157, 31)
        Me.BtnBuscar.TabIndex = 19
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtProcurar
        '
        Me.TxtProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcurar.Location = New System.Drawing.Point(289, 393)
        Me.TxtProcurar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProcurar.MaxLength = 90
        Me.TxtProcurar.Name = "TxtProcurar"
        Me.TxtProcurar.Size = New System.Drawing.Size(428, 26)
        Me.TxtProcurar.TabIndex = 18
        '
        'CbCampos
        '
        Me.CbCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCampos.FormattingEnabled = True
        Me.CbCampos.Items.AddRange(New Object() {"Nome", "Cartão", "Status", "Instituição"})
        Me.CbCampos.Location = New System.Drawing.Point(76, 393)
        Me.CbCampos.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCampos.Name = "CbCampos"
        Me.CbCampos.Size = New System.Drawing.Size(197, 28)
        Me.CbCampos.TabIndex = 17
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 787)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 349)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'CboStatus
        '
        Me.CboStatus.DisplayMember = "Bloqueado"
        Me.CboStatus.Enabled = False
        Me.CboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboStatus.FormattingEnabled = True
        Me.CboStatus.Items.AddRange(New Object() {"Ativo", "Bloqueado", "Cancelado"})
        Me.CboStatus.Location = New System.Drawing.Point(754, 240)
        Me.CboStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(177, 28)
        Me.CboStatus.TabIndex = 10
        Me.CboStatus.Text = "Bloqueado"
        Me.CboStatus.ValueMember = "Bloqueado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Window
        Me.Label16.Location = New System.Drawing.Point(552, 245)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 20)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Status do Cartão ***"
        '
        'mskNCartao
        '
        Me.mskNCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNCartao.Location = New System.Drawing.Point(754, 192)
        Me.mskNCartao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskNCartao.Mask = "0000000000000009"
        Me.mskNCartao.Name = "mskNCartao"
        Me.mskNCartao.Size = New System.Drawing.Size(177, 27)
        Me.mskNCartao.TabIndex = 8
        Me.mskNCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaFecha
        '
        Me.txtDiaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaFecha.Location = New System.Drawing.Point(712, 293)
        Me.txtDiaFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaFecha.MaxLength = 2
        Me.txtDiaFecha.Name = "txtDiaFecha"
        Me.txtDiaFecha.Size = New System.Drawing.Size(79, 27)
        Me.txtDiaFecha.TabIndex = 12
        Me.txtDiaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Window
        Me.Label17.Location = New System.Drawing.Point(552, 296)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 20)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Fechamento *"
        '
        'lblIdAgencias
        '
        Me.lblIdAgencias.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdAgencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdAgencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdAgencias.Location = New System.Drawing.Point(878, 17)
        Me.lblIdAgencias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdAgencias.Name = "lblIdAgencias"
        Me.lblIdAgencias.Size = New System.Drawing.Size(53, 26)
        Me.lblIdAgencias.TabIndex = 95
        Me.lblIdAgencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIdAgencias.Visible = False
        '
        'cboInst
        '
        Me.cboInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInst.FormattingEnabled = True
        Me.cboInst.Location = New System.Drawing.Point(1299, 104)
        Me.cboInst.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInst.Name = "cboInst"
        Me.cboInst.Size = New System.Drawing.Size(177, 28)
        Me.cboInst.TabIndex = 5
        '
        'txtDiaVenc
        '
        Me.txtDiaVenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaVenc.Location = New System.Drawing.Point(1021, 293)
        Me.txtDiaVenc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaVenc.MaxLength = 2
        Me.txtDiaVenc.Name = "txtDiaVenc"
        Me.txtDiaVenc.Size = New System.Drawing.Size(84, 27)
        Me.txtDiaVenc.TabIndex = 13
        Me.txtDiaVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(552, 152)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 20)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Número do Banco **"
        '
        'txtLimite
        '
        Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.Location = New System.Drawing.Point(1299, 243)
        Me.txtLimite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimite.MaxLength = 10
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(177, 27)
        Me.txtLimite.TabIndex = 11
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(1016, 242)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 20)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Limite Total *"
        '
        'cboCPF
        '
        Me.cboCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCPF.FormattingEnabled = True
        Me.cboCPF.Location = New System.Drawing.Point(754, 101)
        Me.cboCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCPF.Name = "cboCPF"
        Me.cboCPF.Size = New System.Drawing.Size(177, 28)
        Me.cboCPF.TabIndex = 4
        '
        'mskValidade
        '
        Me.mskValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskValidade.Location = New System.Drawing.Point(712, 339)
        Me.mskValidade.Margin = New System.Windows.Forms.Padding(4)
        Me.mskValidade.Mask = "00/00"
        Me.mskValidade.Name = "mskValidade"
        Me.mskValidade.Size = New System.Drawing.Size(89, 27)
        Me.mskValidade.TabIndex = 15
        Me.mskValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboTipo
        '
        Me.CboTipo.Enabled = False
        Me.CboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Items.AddRange(New Object() {"Crédito", "Débito"})
        Me.CboTipo.Location = New System.Drawing.Point(1299, 193)
        Me.CboTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(177, 28)
        Me.CboTipo.TabIndex = 9
        Me.CboTipo.Text = "Crédito"
        '
        'txtCSeg
        '
        Me.txtCSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSeg.Location = New System.Drawing.Point(1021, 339)
        Me.txtCSeg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCSeg.MaxLength = 4
        Me.txtCSeg.Name = "txtCSeg"
        Me.txtCSeg.Size = New System.Drawing.Size(84, 27)
        Me.txtCSeg.TabIndex = 16
        Me.txtCSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSenCartao
        '
        Me.txtSenCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenCartao.Location = New System.Drawing.Point(1300, 293)
        Me.txtSenCartao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenCartao.MaxLength = 6
        Me.txtSenCartao.Name = "txtSenCartao"
        Me.txtSenCartao.Size = New System.Drawing.Size(176, 27)
        Me.txtSenCartao.TabIndex = 14
        Me.txtSenCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCartao
        '
        Me.txtCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCartao.Location = New System.Drawing.Point(1299, 151)
        Me.txtCartao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCartao.MaxLength = 20
        Me.txtCartao.Name = "txtCartao"
        Me.txtCartao.Size = New System.Drawing.Size(177, 27)
        Me.txtCartao.TabIndex = 7
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Window
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(754, 14)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(53, 26)
        Me.lblId.TabIndex = 0
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(886, 342)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 20)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "CódSeg *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(1158, 296)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 20)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Senha *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(1016, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Nome do Cartão *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(552, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Nome **"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(552, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "CPF *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(1016, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Data de Registro **"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(552, 342)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 20)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Validade *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(1016, 194)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 20)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Tipo do Cartão **"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(552, 197)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 20)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Número do Cartão *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(1016, 108)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 20)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Instituição *"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(1016, 62)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 20)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "Sobrenome **"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Window
        Me.Label19.Location = New System.Drawing.Point(552, 21)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 20)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "ID **"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Window
        Me.Label20.Location = New System.Drawing.Point(886, 296)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 20)
        Me.Label20.TabIndex = 98
        Me.Label20.Text = "Vencimento *"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Window
        Me.Label21.Location = New System.Drawing.Point(1158, 342)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 20)
        Me.Label21.TabIndex = 100
        Me.Label21.Text = "Saldo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Yellow
        Me.Label22.Location = New System.Drawing.Point(632, 654)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(315, 16)
        Me.Label22.TabIndex = 101
        Me.Label22.Text = "*Obrigatório    **Automático   ***Automático/Editável "
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(754, 59)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(177, 27)
        Me.lblNome.TabIndex = 102
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSobrenome
        '
        Me.lblSobrenome.BackColor = System.Drawing.SystemColors.Window
        Me.lblSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrenome.Location = New System.Drawing.Point(1193, 59)
        Me.lblSobrenome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(283, 27)
        Me.lblSobrenome.TabIndex = 103
        Me.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNBan
        '
        Me.lblNBan.BackColor = System.Drawing.SystemColors.Window
        Me.lblNBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNBan.Location = New System.Drawing.Point(754, 149)
        Me.lblNBan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNBan.Name = "lblNBan"
        Me.lblNBan.Size = New System.Drawing.Size(177, 27)
        Me.lblNBan.TabIndex = 104
        Me.lblNBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataR
        '
        Me.txtDataR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataR.Location = New System.Drawing.Point(1339, 17)
        Me.txtDataR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataR.MaxLength = 10
        Me.txtDataR.Name = "txtDataR"
        Me.txtDataR.Size = New System.Drawing.Size(137, 27)
        Me.txtDataR.TabIndex = 105
        Me.txtDataR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSaldo
        '
        Me.lblSaldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(1299, 339)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(177, 27)
        Me.lblSaldo.TabIndex = 106
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CartoesMasters
        '
        Me.AcceptButton = Me.BtnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.txtDataR)
        Me.Controls.Add(Me.lblNBan)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CboStatus)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.mskNCartao)
        Me.Controls.Add(Me.txtDiaFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblIdAgencias)
        Me.Controls.Add(Me.cboInst)
        Me.Controls.Add(Me.txtDiaVenc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtLimite)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboCPF)
        Me.Controls.Add(Me.mskValidade)
        Me.Controls.Add(Me.CboTipo)
        Me.Controls.Add(Me.txtCSeg)
        Me.Controls.Add(Me.txtSenCartao)
        Me.Controls.Add(Me.txtCartao)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtProcurar)
        Me.Controls.Add(Me.CbCampos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CartoesMasters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro e Consultas de Cartões"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPass As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents CbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CboStatus As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents mskNCartao As MaskedTextBox
    Friend WithEvents txtDiaFecha As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblIdAgencias As Label
    Friend WithEvents cboInst As ComboBox
    Friend WithEvents txtDiaVenc As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtLimite As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboCPF As ComboBox
    Friend WithEvents mskValidade As MaskedTextBox
    Friend WithEvents CboTipo As ComboBox
    Friend WithEvents txtCSeg As TextBox
    Friend WithEvents txtSenCartao As TextBox
    Friend WithEvents txtCartao As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents lblNBan As Label
    Friend WithEvents txtDataR As TextBox
    Friend WithEvents lblSaldo As Label
End Class
