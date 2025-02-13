<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadUser))
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSalvar.Location = New System.Drawing.Point(172, 258)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 34)
        Me.btnSalvar.TabIndex = 22
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Checked = True
        Me.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtivo.ForeColor = System.Drawing.SystemColors.Window
        Me.chkAtivo.Location = New System.Drawing.Point(467, 201)
        Me.chkAtivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(18, 17)
        Me.chkAtivo.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.chkAtivo, "Selecione se a conta de usuário for ativa")
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdmin.ForeColor = System.Drawing.SystemColors.Window
        Me.chkAdmin.Location = New System.Drawing.Point(224, 201)
        Me.chkAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(18, 17)
        Me.chkAdmin.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.chkAdmin, "Selecione se o usuário for admin")
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtSenha.Location = New System.Drawing.Point(213, 138)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(344, 26)
        Me.txtSenha.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtSenha, "Por favor, informe a senha do usuário/admin")
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtUsuario.Location = New System.Drawing.Point(213, 97)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(344, 26)
        Me.txtUsuario.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txtUsuario, "Por favor, informe o login do usuário/admin")
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNome.Location = New System.Drawing.Point(213, 59)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(344, 26)
        Me.txtNome.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtNome, "Por favor, informe a identificação do usuário/admin ")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(37, 137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Senha :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(37, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Login :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(37, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nome do usuário :"
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Window
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblId.Location = New System.Drawing.Point(213, 23)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(107, 26)
        Me.lblId.TabIndex = 13
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID :"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Red
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.btnExcluir.Location = New System.Drawing.Point(348, 258)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(91, 34)
        Me.btnExcluir.TabIndex = 24
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 3500
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Informação:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 341)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(612, 26)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Administrador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(489, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Ativo"
        '
        'CadUser
        '
        Me.AcceptButton = Me.btnSalvar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(612, 367)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de usuários"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
