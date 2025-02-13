<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgenda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgenda))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.MskDataHorario = New System.Windows.Forms.MaskedTextBox()
        Me.TxtComplemento = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AtualizarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblStatus)
        Me.GroupBox1.Controls.Add(Me.LblItem)
        Me.GroupBox1.Controls.Add(Me.CmbTipo)
        Me.GroupBox1.Controls.Add(Me.MskDataHorario)
        Me.GroupBox1.Controls.Add(Me.TxtComplemento)
        Me.GroupBox1.Controls.Add(Me.TxtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1187, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LblStatus
        '
        Me.LblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(301, 255)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(763, 22)
        Me.LblStatus.TabIndex = 5
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblItem
        '
        Me.LblItem.BackColor = System.Drawing.SystemColors.Control
        Me.LblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItem.Location = New System.Drawing.Point(299, 42)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(93, 22)
        Me.LblItem.TabIndex = 0
        Me.LblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.SystemColors.Control
        Me.CmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"1 - Mostrar uma mensagem de aviso", "2 - Executar uma tarefa"})
        Me.CmbTipo.Location = New System.Drawing.Point(301, 174)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(763, 28)
        Me.CmbTipo.TabIndex = 3
        '
        'MskDataHorario
        '
        Me.MskDataHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskDataHorario.Location = New System.Drawing.Point(301, 128)
        Me.MskDataHorario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MskDataHorario.Mask = "00/00/0000 00:00"
        Me.MskDataHorario.Name = "MskDataHorario"
        Me.MskDataHorario.Size = New System.Drawing.Size(183, 26)
        Me.MskDataHorario.TabIndex = 2
        Me.MskDataHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComplemento.Location = New System.Drawing.Point(301, 213)
        Me.TxtComplemento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtComplemento.MaxLength = 60
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(763, 26)
        Me.TxtComplemento.TabIndex = 4
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescricao.Location = New System.Drawing.Point(301, 82)
        Me.TxtDescricao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescricao.MaxLength = 60
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(763, 26)
        Me.TxtDescricao.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(91, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(91, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Complemento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(91, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(91, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data e horário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(91, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(91, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        'Me.Label7.Image = Global.ProjSistBDIMax.My.Resources.Resources.calendario1
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(89, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 113)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Agenda"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.toolStripSeparator, Me.AtualizarToolStripButton, Me.toolStripSeparator1, Me.ExcluirToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(100, 199)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(165, 197)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(163, 47)
        Me.NovoToolStripButton.Text = "&Novo"
        Me.NovoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.NovoToolStripButton.ToolTipText = "Nova Tarefa"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(163, 6)
        '
        'AtualizarToolStripButton
        '
        Me.AtualizarToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AtualizarToolStripButton.Image = CType(resources.GetObject("AtualizarToolStripButton.Image"), System.Drawing.Image)
        Me.AtualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarToolStripButton.Name = "AtualizarToolStripButton"
        Me.AtualizarToolStripButton.Size = New System.Drawing.Size(163, 47)
        Me.AtualizarToolStripButton.Text = "&Atualizar"
        Me.AtualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtualizarToolStripButton.ToolTipText = "Atualizar Lista"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'ExcluirToolStripButton1
        '
        Me.ExcluirToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ExcluirToolStripButton1.Image = CType(resources.GetObject("ExcluirToolStripButton1.Image"), System.Drawing.Image)
        Me.ExcluirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirToolStripButton1.Name = "ExcluirToolStripButton1"
        Me.ExcluirToolStripButton1.Size = New System.Drawing.Size(163, 47)
        Me.ExcluirToolStripButton1.Text = "&Excluir"
        Me.ExcluirToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ExcluirToolStripButton1.ToolTipText = "Excluir Tarefa"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(89, 446)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1399, 354)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descição da tarefa"
        Me.ColumnHeader2.Width = 220
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data e Hora"
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tipo"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Comportamento"
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 150
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 837)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(82, 20)
        Me.ToolStripStatusLabel1.Text = "Mensagem"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Agendar Tarefas"
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
        'FrmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 863)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendar Tarefas"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents MskDataHorario As MaskedTextBox
    Friend WithEvents TxtComplemento As TextBox
    Friend WithEvents LblItem As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents AtualizarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExcluirToolStripButton1 As ToolStripButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
