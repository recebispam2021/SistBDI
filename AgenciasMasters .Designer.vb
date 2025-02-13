<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgenciasMasters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgenciasMasters))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbCampos = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblDataR = New System.Windows.Forms.Label()
        Me.CboInst = New System.Windows.Forms.ComboBox()
        Me.lblIdBancos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CboCPF = New System.Windows.Forms.ComboBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCAcesso = New System.Windows.Forms.TextBox()
        Me.txtSenB = New System.Windows.Forms.TextBox()
        Me.txtLUser = New System.Windows.Forms.TextBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtProcurar = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.lblNBan = New System.Windows.Forms.Label()
        Me.lblNAg = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkPass)
        Me.GroupBox1.Controls.Add(Me.btnSair)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(89, 670)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1400, 71)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandos:"
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.Color.Red
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnExcluir.Location = New System.Drawing.Point(809, 16)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(107, 43)
        Me.BtnExcluir.TabIndex = 18
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.Location = New System.Drawing.Point(629, 16)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(107, 43)
        Me.BtnLimpar.TabIndex = 17
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSalvar.Location = New System.Drawing.Point(449, 16)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(107, 43)
        Me.BtnSalvar.TabIndex = 16
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPass.ForeColor = System.Drawing.SystemColors.Window
        Me.chkPass.Location = New System.Drawing.Point(305, 30)
        Me.chkPass.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(18, 17)
        Me.chkPass.TabIndex = 20
        Me.chkPass.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSair.Location = New System.Drawing.Point(989, 16)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(107, 43)
        Me.btnSair.TabIndex = 19
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel})
        Me.DataGridView1.Location = New System.Drawing.Point(89, 421)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1400, 222)
        Me.DataGridView1.TabIndex = 24
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
        Me.Label2.Location = New System.Drawing.Point(89, 362)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Procurar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(301, 362)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Critérios:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBuscar.Location = New System.Drawing.Point(1308, 381)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(176, 31)
        Me.BtnBuscar.TabIndex = 23
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'CbCampos
        '
        Me.CbCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCampos.FormattingEnabled = True
        Me.CbCampos.Items.AddRange(New Object() {"Nome", "Instituição", "CPF", "Email"})
        Me.CbCampos.Location = New System.Drawing.Point(92, 386)
        Me.CbCampos.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCampos.Name = "CbCampos"
        Me.CbCampos.Size = New System.Drawing.Size(197, 28)
        Me.CbCampos.TabIndex = 21
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 787)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'LblDataR
        '
        Me.LblDataR.BackColor = System.Drawing.SystemColors.Window
        Me.LblDataR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDataR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataR.Location = New System.Drawing.Point(1352, 23)
        Me.LblDataR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataR.Name = "LblDataR"
        Me.LblDataR.Size = New System.Drawing.Size(124, 31)
        Me.LblDataR.TabIndex = 2
        Me.LblDataR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboInst
        '
        Me.CboInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInst.FormattingEnabled = True
        Me.CboInst.Location = New System.Drawing.Point(1273, 104)
        Me.CboInst.Margin = New System.Windows.Forms.Padding(4)
        Me.CboInst.Name = "CboInst"
        Me.CboInst.Size = New System.Drawing.Size(203, 28)
        Me.CboInst.TabIndex = 6
        '
        'lblIdBancos
        '
        Me.lblIdBancos.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdBancos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdBancos.Location = New System.Drawing.Point(884, 31)
        Me.lblIdBancos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdBancos.Name = "lblIdBancos"
        Me.lblIdBancos.Size = New System.Drawing.Size(57, 26)
        Me.lblIdBancos.TabIndex = 1
        Me.lblIdBancos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIdBancos.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 322)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'CboCPF
        '
        Me.CboCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCPF.FormattingEnabled = True
        Me.CboCPF.Location = New System.Drawing.Point(777, 106)
        Me.CboCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCPF.Name = "CboCPF"
        Me.CboCPF.Size = New System.Drawing.Size(164, 28)
        Me.CboCPF.TabIndex = 5
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(777, 321)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.MaxLength = 85
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(697, 47)
        Me.txtObs.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(777, 282)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 25
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(697, 26)
        Me.txtEmail.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtEmail, "Na ausencia de email, digite null!")
        '
        'txtCAcesso
        '
        Me.txtCAcesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAcesso.Location = New System.Drawing.Point(1275, 239)
        Me.txtCAcesso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCAcesso.MaxLength = 12
        Me.txtCAcesso.Name = "txtCAcesso"
        Me.txtCAcesso.Size = New System.Drawing.Size(201, 26)
        Me.txtCAcesso.TabIndex = 12
        Me.txtCAcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSenB
        '
        Me.txtSenB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenB.Location = New System.Drawing.Point(777, 239)
        Me.txtSenB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenB.MaxLength = 11
        Me.txtSenB.Name = "txtSenB"
        Me.txtSenB.Size = New System.Drawing.Size(163, 26)
        Me.txtSenB.TabIndex = 11
        Me.txtSenB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLUser
        '
        Me.txtLUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLUser.Location = New System.Drawing.Point(1275, 188)
        Me.txtLUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLUser.MaxLength = 10
        Me.txtLUser.Name = "txtLUser"
        Me.txtLUser.Size = New System.Drawing.Size(201, 26)
        Me.txtLUser.TabIndex = 10
        Me.txtLUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCC
        '
        Me.txtCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCC.Location = New System.Drawing.Point(777, 194)
        Me.txtCC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCC.MaxLength = 10
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(163, 26)
        Me.txtCC.TabIndex = 9
        Me.txtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Window
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(777, 31)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(57, 26)
        Me.lblId.TabIndex = 0
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(617, 321)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 20)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Observação"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(617, 282)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "E-mail *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(1025, 242)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Código de Acesso *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(617, 239)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Senha *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(1025, 194)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Login de usuário *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(617, 194)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "C. Corrente *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(1025, 157)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Nº da Agência *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(617, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nº do Banco *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(1025, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Instituição *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(617, 106)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "CPF *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(1025, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Sobrenome *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(617, 74)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Nome *"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Window
        Me.Label16.Location = New System.Drawing.Point(1025, 38)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 20)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Data de Registro **"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Window
        Me.Label17.Location = New System.Drawing.Point(617, 38)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "ID Agência **"
        '
        'TxtProcurar
        '
        Me.TxtProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcurar.Location = New System.Drawing.Point(296, 386)
        Me.TxtProcurar.Name = "TxtProcurar"
        Me.TxtProcurar.Size = New System.Drawing.Size(392, 28)
        Me.TxtProcurar.TabIndex = 58
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(704, 650)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(171, 16)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "* Obrigatório    **Automático"
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(777, 68)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(163, 26)
        Me.lblNome.TabIndex = 60
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSobrenome
        '
        Me.lblSobrenome.BackColor = System.Drawing.SystemColors.Window
        Me.lblSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrenome.Location = New System.Drawing.Point(1193, 68)
        Me.lblSobrenome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(283, 26)
        Me.lblSobrenome.TabIndex = 61
        Me.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNBan
        '
        Me.lblNBan.BackColor = System.Drawing.SystemColors.Window
        Me.lblNBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNBan.Location = New System.Drawing.Point(777, 151)
        Me.lblNBan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNBan.Name = "lblNBan"
        Me.lblNBan.Size = New System.Drawing.Size(163, 26)
        Me.lblNBan.TabIndex = 62
        Me.lblNBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNAg
        '
        Me.lblNAg.BackColor = System.Drawing.SystemColors.Window
        Me.lblNAg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNAg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNAg.Location = New System.Drawing.Point(1275, 148)
        Me.lblNAg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNAg.Name = "lblNAg"
        Me.lblNAg.Size = New System.Drawing.Size(201, 26)
        Me.lblNAg.TabIndex = 63
        Me.lblNAg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Informação"
        '
        'AgenciasMasters
        '
        Me.AcceptButton = Me.BtnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNAg)
        Me.Controls.Add(Me.lblNBan)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtProcurar)
        Me.Controls.Add(Me.LblDataR)
        Me.Controls.Add(Me.CboInst)
        Me.Controls.Add(Me.lblIdBancos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CboCPF)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCAcesso)
        Me.Controls.Add(Me.txtSenB)
        Me.Controls.Add(Me.txtLUser)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgenciasMasters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro e Consulta de Agências Bancárias"
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
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chkPass As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents LblDataR As Label
    Friend WithEvents CboInst As ComboBox
    Friend WithEvents lblIdBancos As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CboCPF As ComboBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCAcesso As TextBox
    Friend WithEvents txtSenB As TextBox
    Friend WithEvents txtLUser As TextBox
    Friend WithEvents txtCC As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtProcurar As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents lblNBan As Label
    Friend WithEvents lblNAg As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
