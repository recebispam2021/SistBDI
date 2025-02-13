<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChavePix
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChavePix))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbCampos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cboCPF = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtChavePix = New System.Windows.Forms.TextBox()
        Me.txtDataR = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtProcurar = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.cboNBanco = New System.Windows.Forms.ComboBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(89, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Procurar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(301, 283)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Critérios:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBuscar.Location = New System.Drawing.Point(1303, 303)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(188, 31)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'CbCampos
        '
        Me.CbCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCampos.FormattingEnabled = True
        Me.CbCampos.Items.AddRange(New Object() {"Nome", "CPF", "Instituição", "Chave"})
        Me.CbCampos.Location = New System.Drawing.Point(92, 308)
        Me.CbCampos.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCampos.Name = "CbCampos"
        Me.CbCampos.Size = New System.Drawing.Size(197, 28)
        Me.CbCampos.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnSair)
        Me.GroupBox1.Controls.Add(Me.BtnLimpar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(91, 610)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1400, 71)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandos:"
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.Color.Red
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnExcluir.Location = New System.Drawing.Point(717, 16)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(153, 43)
        Me.BtnExcluir.TabIndex = 10
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSalvar.Location = New System.Drawing.Point(345, 16)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(153, 43)
        Me.BtnSalvar.TabIndex = 8
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSair.Location = New System.Drawing.Point(903, 16)
        Me.BtnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(153, 43)
        Me.BtnSair.TabIndex = 11
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.Location = New System.Drawing.Point(531, 16)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(153, 43)
        Me.BtnLimpar.TabIndex = 9
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel})
        Me.DataGridView1.Location = New System.Drawing.Point(91, 343)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1400, 222)
        Me.DataGridView1.TabIndex = 15
        '
        'Sel
        '
        Me.Sel.HeaderText = ""
        Me.Sel.MinimumWidth = 6
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.Width = 30
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 787)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'cboCPF
        '
        Me.cboCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCPF.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cboCPF.FormattingEnabled = True
        Me.cboCPF.Location = New System.Drawing.Point(573, 170)
        Me.cboCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCPF.Name = "cboCPF"
        Me.cboCPF.Size = New System.Drawing.Size(165, 28)
        Me.cboCPF.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 64)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'txtChavePix
        '
        Me.txtChavePix.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtChavePix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChavePix.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtChavePix.Location = New System.Drawing.Point(573, 233)
        Me.txtChavePix.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChavePix.MaxLength = 50
        Me.txtChavePix.Name = "txtChavePix"
        Me.txtChavePix.Size = New System.Drawing.Size(918, 26)
        Me.txtChavePix.TabIndex = 7
        '
        'txtDataR
        '
        Me.txtDataR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataR.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDataR.Location = New System.Drawing.Point(1369, 60)
        Me.txtDataR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataR.MaxLength = 10
        Me.txtDataR.Name = "txtDataR"
        Me.txtDataR.Size = New System.Drawing.Size(122, 26)
        Me.txtDataR.TabIndex = 1
        Me.txtDataR.TabStop = False
        Me.txtDataR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(439, 235)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 25)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Chave Pix *"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(439, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Nome *"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(439, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "CPF *"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(881, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 23)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Data de Registro *"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(1103, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Instituição/Banco *"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(881, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 23)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Sobrenome *"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(439, 64)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 22)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "ID **"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtProcurar
        '
        Me.TxtProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcurar.Location = New System.Drawing.Point(305, 308)
        Me.TxtProcurar.Name = "TxtProcurar"
        Me.TxtProcurar.Size = New System.Drawing.Size(379, 28)
        Me.TxtProcurar.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(885, 172)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 23)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Banco *"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(704, 584)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 16)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "* Obrigatório   ** Automático"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 3500
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Informação do Banco:"
        '
        'lblInst
        '
        Me.lblInst.BackColor = System.Drawing.SystemColors.Window
        Me.lblInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.Location = New System.Drawing.Point(1275, 173)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(216, 26)
        Me.lblInst.TabIndex = 92
        '
        'lblSobrenome
        '
        Me.lblSobrenome.BackColor = System.Drawing.SystemColors.Window
        Me.lblSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrenome.Location = New System.Drawing.Point(1103, 118)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(388, 26)
        Me.lblSobrenome.TabIndex = 94
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Window
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(573, 60)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(79, 26)
        Me.lblId.TabIndex = 95
        '
        'cboNBanco
        '
        Me.cboNBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNBanco.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cboNBanco.FormattingEnabled = True
        Me.cboNBanco.Location = New System.Drawing.Point(969, 170)
        Me.cboNBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNBanco.Name = "cboNBanco"
        Me.cboNBanco.Size = New System.Drawing.Size(103, 28)
        Me.cboNBanco.TabIndex = 96
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(573, 113)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(233, 26)
        Me.lblNome.TabIndex = 93
        '
        'ChavePix
        '
        Me.AcceptButton = Me.BtnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboNBanco)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtProcurar)
        Me.Controls.Add(Me.cboCPF)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtChavePix)
        Me.Controls.Add(Me.txtDataR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.CbCampos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ChavePix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro e Consulta de Chaves Pix"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents cboCPF As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtChavePix As TextBox
    Friend WithEvents txtDataR As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents TxtProcurar As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblInst As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents lblId As Label
    Friend WithEvents cboNBanco As ComboBox
    Friend WithEvents lblNome As Label
End Class
