<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmailPessoais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailPessoais))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbCampos = New System.Windows.Forms.ComboBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboCPF = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSenEmail = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtProcurar = New System.Windows.Forms.MaskedTextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.LblDataR = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Controls.Add(Me.BtnLimpar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.chkPass)
        Me.GroupBox1.Controls.Add(Me.BtnSair)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(91, 632)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1400, 71)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandos:"
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.Color.Red
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnExcluir.Location = New System.Drawing.Point(850, 18)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(107, 43)
        Me.BtnExcluir.TabIndex = 11
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.Location = New System.Drawing.Point(674, 18)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(107, 43)
        Me.BtnLimpar.TabIndex = 10
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(301, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSalvar.Location = New System.Drawing.Point(507, 18)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(107, 43)
        Me.BtnSalvar.TabIndex = 9
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPass.ForeColor = System.Drawing.SystemColors.Window
        Me.chkPass.Location = New System.Drawing.Point(279, 33)
        Me.chkPass.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(18, 17)
        Me.chkPass.TabIndex = 13
        Me.chkPass.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSair.Location = New System.Drawing.Point(1015, 18)
        Me.BtnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(107, 43)
        Me.BtnSair.TabIndex = 12
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
        Me.DataGridView1.Location = New System.Drawing.Point(91, 381)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1400, 222)
        Me.DataGridView1.TabIndex = 17
        '
        'Sel
        '
        Me.Sel.HeaderText = ""
        Me.Sel.MinimumWidth = 6
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
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
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(88, 304)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Procurar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(307, 304)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Critérios"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBuscar.Location = New System.Drawing.Point(1296, 329)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(191, 31)
        Me.BtnBuscar.TabIndex = 16
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'CbCampos
        '
        Me.CbCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCampos.FormattingEnabled = True
        Me.CbCampos.Items.AddRange(New Object() {"Nome", "CPF", "Email", "Login"})
        Me.CbCampos.Location = New System.Drawing.Point(91, 328)
        Me.CbCampos.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCampos.Name = "CbCampos"
        Me.CbCampos.Size = New System.Drawing.Size(197, 28)
        Me.CbCampos.TabIndex = 14
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(565, 219)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogin.MaxLength = 25
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(241, 26)
        Me.txtLogin.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(401, 221)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Login de Usuário"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(1031, 160)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(460, 26)
        Me.txtEmail.TabIndex = 5
        '
        'cboCPF
        '
        Me.cboCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCPF.FormattingEnabled = True
        Me.cboCPF.Location = New System.Drawing.Point(565, 158)
        Me.cboCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCPF.Name = "cboCPF"
        Me.cboCPF.Size = New System.Drawing.Size(231, 28)
        Me.cboCPF.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(91, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'txtSenEmail
        '
        Me.txtSenEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenEmail.Location = New System.Drawing.Point(1278, 221)
        Me.txtSenEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenEmail.MaxLength = 12
        Me.txtSenEmail.Name = "txtSenEmail"
        Me.txtSenEmail.Size = New System.Drawing.Size(213, 26)
        Me.txtSenEmail.TabIndex = 7
        Me.txtSenEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Window
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(565, 40)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(76, 26)
        Me.lblId.TabIndex = 0
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(884, 221)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(403, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(403, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "CPF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(884, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Data de Registro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(884, 163)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(884, 104)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Sobrenome"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(401, 44)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 20)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "ID"
        '
        'TxtProcurar
        '
        Me.TxtProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcurar.Location = New System.Drawing.Point(304, 329)
        Me.TxtProcurar.Name = "TxtProcurar"
        Me.TxtProcurar.Size = New System.Drawing.Size(392, 28)
        Me.TxtProcurar.TabIndex = 93
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(565, 101)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(229, 26)
        Me.lblNome.TabIndex = 94
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSobrenome
        '
        Me.lblSobrenome.BackColor = System.Drawing.SystemColors.Window
        Me.lblSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrenome.Location = New System.Drawing.Point(1125, 100)
        Me.lblSobrenome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(366, 26)
        Me.lblSobrenome.TabIndex = 95
        Me.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDataR
        '
        Me.LblDataR.BackColor = System.Drawing.SystemColors.Window
        Me.LblDataR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDataR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataR.Location = New System.Drawing.Point(1336, 41)
        Me.LblDataR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataR.Name = "LblDataR"
        Me.LblDataR.Size = New System.Drawing.Size(155, 26)
        Me.LblDataR.TabIndex = 96
        Me.LblDataR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailPessoais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblDataR)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.TxtProcurar)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cboCPF)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSenEmail)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.CbCampos)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EmailPessoais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro e Consulta de Emails"
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
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CbCampos As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cboCPF As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSenEmail As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents TxtProcurar As MaskedTextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents LblDataR As Label
End Class
