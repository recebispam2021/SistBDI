<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartaoCategMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartaoCategMaster))
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.TxtCategorias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblidCateg = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtDataR = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGravar
        '
        Me.BtnGravar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGravar.Location = New System.Drawing.Point(180, 427)
        Me.BtnGravar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(111, 34)
        Me.BtnGravar.TabIndex = 4
        Me.BtnGravar.Text = "&Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = False
        '
        'TxtCategorias
        '
        Me.TxtCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategorias.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtCategorias.Location = New System.Drawing.Point(202, 165)
        Me.TxtCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCategorias.MaxLength = 30
        Me.TxtCategorias.Name = "TxtCategorias"
        Me.TxtCategorias.Size = New System.Drawing.Size(386, 26)
        Me.TxtCategorias.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TxtCategorias, "Por favor, informe a senha antiga")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(60, 168)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "* Categorias :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(60, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "** ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(60, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "* Data Registro:"
        '
        'lblidCateg
        '
        Me.lblidCateg.BackColor = System.Drawing.SystemColors.Window
        Me.lblidCateg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblidCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidCateg.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblidCateg.Location = New System.Drawing.Point(204, 90)
        Me.lblidCateg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidCateg.Name = "lblidCateg"
        Me.lblidCateg.Size = New System.Drawing.Size(41, 28)
        Me.lblidCateg.TabIndex = 0
        Me.lblidCateg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 3500
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipTitle = "Informação:"
        '
        'TxtDataR
        '
        Me.TxtDataR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDataR.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtDataR.Location = New System.Drawing.Point(202, 130)
        Me.TxtDataR.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDataR.MaxLength = 30
        Me.TxtDataR.Name = "TxtDataR"
        Me.TxtDataR.Size = New System.Drawing.Size(137, 26)
        Me.TxtDataR.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtDataR, "Por favor, informe a senha antiga")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 494)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(652, 26)
        Me.StatusStrip1.TabIndex = 38
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(62, 208)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(526, 168)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Dt Registro"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categorias"
        Me.ColumnHeader3.Width = 200
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.Location = New System.Drawing.Point(358, 427)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(111, 34)
        Me.BtnExcluir.TabIndex = 40
        Me.BtnExcluir.Text = "&Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(0, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(652, 31)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Categorias Cadastradas no Sistema"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(242, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "* Obrigatório  ** Automático"
        '
        'CartaoCategMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(652, 520)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDataR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblidCateg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnGravar)
        Me.Controls.Add(Me.TxtCategorias)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CartaoCategMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.TopMost = True
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGravar As System.Windows.Forms.Button
    Friend WithEvents TxtCategorias As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblidCateg As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDataR As TextBox
    Friend WithEvents Label3 As Label
End Class
