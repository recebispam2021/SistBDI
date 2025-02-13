<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Balancete
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
        Me.GroupCriterios = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupMesAno = New System.Windows.Forms.GroupBox()
        Me.LblAno = New System.Windows.Forms.Label()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        Me.RdbDez = New System.Windows.Forms.RadioButton()
        Me.RdbNov = New System.Windows.Forms.RadioButton()
        Me.RdbOut = New System.Windows.Forms.RadioButton()
        Me.RdbSet = New System.Windows.Forms.RadioButton()
        Me.RdbAgo = New System.Windows.Forms.RadioButton()
        Me.RdbJul = New System.Windows.Forms.RadioButton()
        Me.RdbJun = New System.Windows.Forms.RadioButton()
        Me.RdbMai = New System.Windows.Forms.RadioButton()
        Me.RdbAbr = New System.Windows.Forms.RadioButton()
        Me.RdbMar = New System.Windows.Forms.RadioButton()
        Me.RdbFev = New System.Windows.Forms.RadioButton()
        Me.RdbJan = New System.Windows.Forms.RadioButton()
        Me.GroupCriterios.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupMesAno.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupCriterios
        '
        Me.GroupCriterios.Controls.Add(Me.RadioButton2)
        Me.GroupCriterios.Controls.Add(Me.RadioButton1)
        Me.GroupCriterios.Controls.Add(Me.BtnBuscar)
        Me.GroupCriterios.Controls.Add(Me.BtnLimpar)
        Me.GroupCriterios.Controls.Add(Me.RadioButton16)
        Me.GroupCriterios.Controls.Add(Me.RadioButton17)
        Me.GroupCriterios.Controls.Add(Me.RadioButton18)
        Me.GroupCriterios.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupCriterios.Location = New System.Drawing.Point(560, 348)
        Me.GroupCriterios.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupCriterios.Name = "GroupCriterios"
        Me.GroupCriterios.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupCriterios.Size = New System.Drawing.Size(494, 139)
        Me.GroupCriterios.TabIndex = 2
        Me.GroupCriterios.TabStop = False
        Me.GroupCriterios.Text = "Filtro:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton2.Location = New System.Drawing.Point(37, 29)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 20)
        Me.RadioButton2.TabIndex = 77
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Geral"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton1.Location = New System.Drawing.Point(155, 89)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(118, 20)
        Me.RadioButton1.TabIndex = 76
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Por Categorias"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBuscar.Location = New System.Drawing.Point(289, 29)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(151, 31)
        Me.BtnBuscar.TabIndex = 75
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.Location = New System.Drawing.Point(289, 79)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(151, 31)
        Me.BtnLimpar.TabIndex = 74
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton16.Location = New System.Drawing.Point(155, 59)
        Me.RadioButton16.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(84, 20)
        Me.RadioButton16.TabIndex = 73
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "Por Fluxo"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton17.Location = New System.Drawing.Point(37, 89)
        Me.RadioButton17.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(89, 20)
        Me.RadioButton17.TabIndex = 72
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Text = "Por Nome"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton18.Location = New System.Drawing.Point(37, 59)
        Me.RadioButton18.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(92, 20)
        Me.RadioButton18.TabIndex = 71
        Me.RadioButton18.Text = "Por Cartão"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 92)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1007, 207)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(47, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1007, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Balancete dos Cartões de Crédito"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(52, 309)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1002, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total de gastos mensais"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1096, 26)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'GroupMesAno
        '
        Me.GroupMesAno.Controls.Add(Me.LblAno)
        Me.GroupMesAno.Controls.Add(Me.TxtAno)
        Me.GroupMesAno.Controls.Add(Me.RdbDez)
        Me.GroupMesAno.Controls.Add(Me.RdbNov)
        Me.GroupMesAno.Controls.Add(Me.RdbOut)
        Me.GroupMesAno.Controls.Add(Me.RdbSet)
        Me.GroupMesAno.Controls.Add(Me.RdbAgo)
        Me.GroupMesAno.Controls.Add(Me.RdbJul)
        Me.GroupMesAno.Controls.Add(Me.RdbJun)
        Me.GroupMesAno.Controls.Add(Me.RdbMai)
        Me.GroupMesAno.Controls.Add(Me.RdbAbr)
        Me.GroupMesAno.Controls.Add(Me.RdbMar)
        Me.GroupMesAno.Controls.Add(Me.RdbFev)
        Me.GroupMesAno.Controls.Add(Me.RdbJan)
        Me.GroupMesAno.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupMesAno.Location = New System.Drawing.Point(47, 348)
        Me.GroupMesAno.Name = "GroupMesAno"
        Me.GroupMesAno.Size = New System.Drawing.Size(494, 139)
        Me.GroupMesAno.TabIndex = 7
        Me.GroupMesAno.TabStop = False
        Me.GroupMesAno.Text = "Pesquisa:"
        '
        'LblAno
        '
        Me.LblAno.AutoSize = True
        Me.LblAno.ForeColor = System.Drawing.SystemColors.Window
        Me.LblAno.Location = New System.Drawing.Point(371, 45)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(34, 16)
        Me.LblAno.TabIndex = 91
        Me.LblAno.Text = "Ano:"
        '
        'TxtAno
        '
        Me.TxtAno.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtAno.Location = New System.Drawing.Point(330, 85)
        Me.TxtAno.MaxLength = 4
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Size = New System.Drawing.Size(127, 22)
        Me.TxtAno.TabIndex = 90
        Me.TxtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RdbDez
        '
        Me.RdbDez.AutoSize = True
        Me.RdbDez.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbDez.Location = New System.Drawing.Point(256, 92)
        Me.RdbDez.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbDez.Name = "RdbDez"
        Me.RdbDez.Size = New System.Drawing.Size(52, 20)
        Me.RdbDez.TabIndex = 62
        Me.RdbDez.Tag = "12"
        Me.RdbDez.Text = "Dez"
        Me.RdbDez.UseVisualStyleBackColor = True
        '
        'RdbNov
        '
        Me.RdbNov.AutoSize = True
        Me.RdbNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbNov.Location = New System.Drawing.Point(256, 64)
        Me.RdbNov.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbNov.Name = "RdbNov"
        Me.RdbNov.Size = New System.Drawing.Size(53, 20)
        Me.RdbNov.TabIndex = 61
        Me.RdbNov.Tag = "11"
        Me.RdbNov.Text = "Nov"
        Me.RdbNov.UseVisualStyleBackColor = True
        '
        'RdbOut
        '
        Me.RdbOut.AutoSize = True
        Me.RdbOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbOut.Location = New System.Drawing.Point(256, 35)
        Me.RdbOut.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbOut.Name = "RdbOut"
        Me.RdbOut.Size = New System.Drawing.Size(48, 20)
        Me.RdbOut.TabIndex = 60
        Me.RdbOut.Tag = "10"
        Me.RdbOut.Text = "Out"
        Me.RdbOut.UseVisualStyleBackColor = True
        '
        'RdbSet
        '
        Me.RdbSet.AutoSize = True
        Me.RdbSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbSet.Location = New System.Drawing.Point(183, 92)
        Me.RdbSet.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbSet.Name = "RdbSet"
        Me.RdbSet.Size = New System.Drawing.Size(48, 20)
        Me.RdbSet.TabIndex = 59
        Me.RdbSet.Tag = "9"
        Me.RdbSet.Text = "Set"
        Me.RdbSet.UseVisualStyleBackColor = True
        '
        'RdbAgo
        '
        Me.RdbAgo.AutoSize = True
        Me.RdbAgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAgo.Location = New System.Drawing.Point(183, 64)
        Me.RdbAgo.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbAgo.Name = "RdbAgo"
        Me.RdbAgo.Size = New System.Drawing.Size(53, 20)
        Me.RdbAgo.TabIndex = 58
        Me.RdbAgo.Tag = "8"
        Me.RdbAgo.Text = "Ago"
        Me.RdbAgo.UseVisualStyleBackColor = True
        '
        'RdbJul
        '
        Me.RdbJul.AutoSize = True
        Me.RdbJul.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbJul.Location = New System.Drawing.Point(183, 35)
        Me.RdbJul.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbJul.Name = "RdbJul"
        Me.RdbJul.Size = New System.Drawing.Size(45, 20)
        Me.RdbJul.TabIndex = 57
        Me.RdbJul.Tag = "7"
        Me.RdbJul.Text = "Jul"
        Me.RdbJul.UseVisualStyleBackColor = True
        '
        'RdbJun
        '
        Me.RdbJun.AutoSize = True
        Me.RdbJun.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbJun.Location = New System.Drawing.Point(106, 92)
        Me.RdbJun.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbJun.Name = "RdbJun"
        Me.RdbJun.Size = New System.Drawing.Size(49, 20)
        Me.RdbJun.TabIndex = 56
        Me.RdbJun.Tag = "6"
        Me.RdbJun.Text = "Jun"
        Me.RdbJun.UseVisualStyleBackColor = True
        '
        'RdbMai
        '
        Me.RdbMai.AutoSize = True
        Me.RdbMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMai.Location = New System.Drawing.Point(106, 64)
        Me.RdbMai.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbMai.Name = "RdbMai"
        Me.RdbMai.Size = New System.Drawing.Size(50, 20)
        Me.RdbMai.TabIndex = 55
        Me.RdbMai.Tag = "5"
        Me.RdbMai.Text = "Mai"
        Me.RdbMai.UseVisualStyleBackColor = True
        '
        'RdbAbr
        '
        Me.RdbAbr.AutoSize = True
        Me.RdbAbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAbr.Location = New System.Drawing.Point(106, 35)
        Me.RdbAbr.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbAbr.Name = "RdbAbr"
        Me.RdbAbr.Size = New System.Drawing.Size(49, 20)
        Me.RdbAbr.TabIndex = 54
        Me.RdbAbr.Tag = "4"
        Me.RdbAbr.Text = "Abr"
        Me.RdbAbr.UseVisualStyleBackColor = True
        '
        'RdbMar
        '
        Me.RdbMar.AutoSize = True
        Me.RdbMar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMar.Location = New System.Drawing.Point(38, 92)
        Me.RdbMar.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbMar.Name = "RdbMar"
        Me.RdbMar.Size = New System.Drawing.Size(51, 20)
        Me.RdbMar.TabIndex = 53
        Me.RdbMar.Tag = "3"
        Me.RdbMar.Text = "Mar"
        Me.RdbMar.UseVisualStyleBackColor = True
        '
        'RdbFev
        '
        Me.RdbFev.AutoSize = True
        Me.RdbFev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbFev.Location = New System.Drawing.Point(38, 64)
        Me.RdbFev.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbFev.Name = "RdbFev"
        Me.RdbFev.Size = New System.Drawing.Size(51, 20)
        Me.RdbFev.TabIndex = 52
        Me.RdbFev.Tag = "2"
        Me.RdbFev.Text = "Fev"
        Me.RdbFev.UseVisualStyleBackColor = True
        '
        'RdbJan
        '
        Me.RdbJan.AutoSize = True
        Me.RdbJan.Checked = True
        Me.RdbJan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbJan.Location = New System.Drawing.Point(38, 35)
        Me.RdbJan.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbJan.Name = "RdbJan"
        Me.RdbJan.Size = New System.Drawing.Size(50, 20)
        Me.RdbJan.TabIndex = 51
        Me.RdbJan.TabStop = True
        Me.RdbJan.Tag = "1"
        Me.RdbJan.Text = "Jan"
        Me.RdbJan.UseVisualStyleBackColor = True
        '
        'Balancete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1096, 565)
        Me.Controls.Add(Me.GroupMesAno)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupCriterios)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balancete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupCriterios.ResumeLayout(False)
        Me.GroupCriterios.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupMesAno.ResumeLayout(False)
        Me.GroupMesAno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents GroupMesAno As GroupBox
    Friend WithEvents RdbDez As RadioButton
    Friend WithEvents RdbNov As RadioButton
    Friend WithEvents RdbOut As RadioButton
    Friend WithEvents RdbSet As RadioButton
    Friend WithEvents RdbAgo As RadioButton
    Friend WithEvents RdbJul As RadioButton
    Friend WithEvents RdbJun As RadioButton
    Friend WithEvents RdbMai As RadioButton
    Friend WithEvents RdbAbr As RadioButton
    Friend WithEvents RdbMar As RadioButton
    Friend WithEvents RdbFev As RadioButton
    Friend WithEvents RdbJan As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblAno As Label
    Friend WithEvents TxtAno As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
