﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FaturaCartao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FaturaCartao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CboNCartao = New System.Windows.Forms.ComboBox()
        Me.txtHistorico = New System.Windows.Forms.TextBox()
        Me.lblIdCartaoMov = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCPF = New System.Windows.Forms.ComboBox()
        Me.lblvpc = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblvcpg = New System.Windows.Forms.Label()
        Me.cboNParcelas = New System.Windows.Forms.ComboBox()
        Me.lblnpc = New System.Windows.Forms.Label()
        Me.mskVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboConsolidada = New System.Windows.Forms.ComboBox()
        Me.mskDataR = New System.Windows.Forms.MaskedTextBox()
        Me.btnGerParc = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CboFluxo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CboCategorias = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssTexto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mskPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.lbldtpg = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.lblpg = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.lblCartao = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Controls.Add(Me.BtnLimpar)
        Me.GroupBox1.Controls.Add(Me.btnSair)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(80, 630)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1417, 81)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandos:"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.Location = New System.Drawing.Point(549, 23)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(318, 43)
        Me.BtnLimpar.TabIndex = 19
        Me.BtnLimpar.TabStop = False
        Me.BtnLimpar.Text = "Limpar/Cancelar"
        Me.ToolTip1.SetToolTip(Me.BtnLimpar, "Limpar o formulário")
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSair.Location = New System.Drawing.Point(891, 23)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(318, 43)
        Me.btnSair.TabIndex = 20
        Me.btnSair.TabStop = False
        Me.btnSair.Text = "Sair"
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair do Cadastro")
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSalvar.Location = New System.Drawing.Point(207, 23)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(318, 43)
        Me.btnSalvar.TabIndex = 18
        Me.btnSalvar.Text = "Salvar"
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar o registro")
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 46)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 331)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'CboNCartao
        '
        Me.CboNCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNCartao.FormattingEnabled = True
        Me.CboNCartao.Location = New System.Drawing.Point(520, 177)
        Me.CboNCartao.Margin = New System.Windows.Forms.Padding(4)
        Me.CboNCartao.Name = "CboNCartao"
        Me.CboNCartao.Size = New System.Drawing.Size(200, 28)
        Me.CboNCartao.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.CboNCartao, "Por favor, informe o número do Cartão")
        '
        'txtHistorico
        '
        Me.txtHistorico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistorico.Location = New System.Drawing.Point(520, 223)
        Me.txtHistorico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHistorico.MaxLength = 30
        Me.txtHistorico.Multiline = True
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.Size = New System.Drawing.Size(200, 24)
        Me.txtHistorico.TabIndex = 9
        '
        'lblIdCartaoMov
        '
        Me.lblIdCartaoMov.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdCartaoMov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdCartaoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCartaoMov.Location = New System.Drawing.Point(520, 46)
        Me.lblIdCartaoMov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdCartaoMov.Name = "lblIdCartaoMov"
        Me.lblIdCartaoMov.Size = New System.Drawing.Size(107, 26)
        Me.lblIdCartaoMov.TabIndex = 0
        Me.lblIdCartaoMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(771, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Nome do Cartão"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(341, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(341, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(771, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Data de Registro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(340, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Histórico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(341, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Número do Cartão"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(772, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Sobrenome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(341, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ID"
        '
        'cboCPF
        '
        Me.cboCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCPF.FormattingEnabled = True
        Me.cboCPF.Location = New System.Drawing.Point(520, 132)
        Me.cboCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCPF.Name = "cboCPF"
        Me.cboCPF.Size = New System.Drawing.Size(165, 28)
        Me.cboCPF.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cboCPF, "Por favor, informe o número do CPF")
        '
        'lblvpc
        '
        Me.lblvpc.AutoSize = True
        Me.lblvpc.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblvpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvpc.ForeColor = System.Drawing.SystemColors.Window
        Me.lblvpc.Location = New System.Drawing.Point(341, 272)
        Me.lblvpc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvpc.Name = "lblvpc"
        Me.lblvpc.Size = New System.Drawing.Size(150, 18)
        Me.lblvpc.TabIndex = 48
        Me.lblvpc.Text = "Valor das Parcelas"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.Red
        Me.txtValor.Location = New System.Drawing.Point(520, 263)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.MaxLength = 15
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(128, 26)
        Me.txtValor.TabIndex = 11
        Me.txtValor.Text = "0.00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblvcpg
        '
        Me.lblvcpg.AutoSize = True
        Me.lblvcpg.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblvcpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvcpg.ForeColor = System.Drawing.SystemColors.Window
        Me.lblvcpg.Location = New System.Drawing.Point(772, 270)
        Me.lblvcpg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvcpg.Name = "lblvcpg"
        Me.lblvcpg.Size = New System.Drawing.Size(105, 20)
        Me.lblvcpg.TabIndex = 53
        Me.lblvcpg.Text = "Venc/Pagto"
        '
        'cboNParcelas
        '
        Me.cboNParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNParcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNParcelas.FormattingEnabled = True
        Me.cboNParcelas.ItemHeight = 20
        Me.cboNParcelas.Items.AddRange(New Object() {"À vista", "2x sem juros", "3x sem juros", "4x sem juros", "5x sem juros", "6x sem juros", "7x sem juros", "8x sem juros", "9x sem juros", "10x sem juros", "11x sem juros", "12x sem juros"})
        Me.cboNParcelas.Location = New System.Drawing.Point(520, 307)
        Me.cboNParcelas.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNParcelas.Name = "cboNParcelas"
        Me.cboNParcelas.Size = New System.Drawing.Size(128, 28)
        Me.cboNParcelas.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cboNParcelas, "Por favor, informe o número das parcelas")
        '
        'lblnpc
        '
        Me.lblnpc.AutoSize = True
        Me.lblnpc.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblnpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnpc.ForeColor = System.Drawing.SystemColors.Window
        Me.lblnpc.Location = New System.Drawing.Point(340, 316)
        Me.lblnpc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnpc.Name = "lblnpc"
        Me.lblnpc.Size = New System.Drawing.Size(135, 20)
        Me.lblnpc.TabIndex = 57
        Me.lblnpc.Text = "Nº de Parcelas"
        '
        'mskVencimento
        '
        Me.mskVencimento.Enabled = False
        Me.mskVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskVencimento.Location = New System.Drawing.Point(1025, 263)
        Me.mskVencimento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskVencimento.Mask = "00/00/0000"
        Me.mskVencimento.Name = "mskVencimento"
        Me.mskVencimento.Size = New System.Drawing.Size(127, 26)
        Me.mskVencimento.TabIndex = 16
        Me.mskVencimento.TabStop = False
        Me.mskVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskVencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskVencimento.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(773, 316)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Consolidada"
        '
        'cboConsolidada
        '
        Me.cboConsolidada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsolidada.Enabled = False
        Me.cboConsolidada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsolidada.FormattingEnabled = True
        Me.cboConsolidada.Items.AddRange(New Object() {"N", "S"})
        Me.cboConsolidada.Location = New System.Drawing.Point(1096, 307)
        Me.cboConsolidada.Margin = New System.Windows.Forms.Padding(4)
        Me.cboConsolidada.Name = "cboConsolidada"
        Me.cboConsolidada.Size = New System.Drawing.Size(57, 28)
        Me.cboConsolidada.TabIndex = 17
        Me.cboConsolidada.TabStop = False
        '
        'mskDataR
        '
        Me.mskDataR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDataR.Location = New System.Drawing.Point(1049, 44)
        Me.mskDataR.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDataR.Mask = "00/00/0000"
        Me.mskDataR.Name = "mskDataR"
        Me.mskDataR.Size = New System.Drawing.Size(103, 26)
        Me.mskDataR.TabIndex = 1
        Me.mskDataR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskDataR.ValidatingType = GetType(Date)
        '
        'btnGerParc
        '
        Me.btnGerParc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGerParc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerParc.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGerParc.Location = New System.Drawing.Point(661, 307)
        Me.btnGerParc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGerParc.Name = "btnGerParc"
        Me.btnGerParc.Size = New System.Drawing.Size(91, 30)
        Me.btnGerParc.TabIndex = 13
        Me.btnGerParc.Text = "Gerar"
        Me.ToolTip1.SetToolTip(Me.btnGerParc, "Clique aqui para gerar as parcelas")
        Me.btnGerParc.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnInfo.Location = New System.Drawing.Point(728, 174)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(24, 30)
        Me.btnInfo.TabIndex = 7
        Me.btnInfo.TabStop = False
        Me.btnInfo.Text = "?"
        Me.ToolTip1.SetToolTip(Me.btnInfo, "Verifique a lista de cartões cadastrados")
        Me.btnInfo.UseVisualStyleBackColor = False
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
        'CboFluxo
        '
        Me.CboFluxo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFluxo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFluxo.FormattingEnabled = True
        Me.CboFluxo.Items.AddRange(New Object() {"Saída", "Entrada"})
        Me.CboFluxo.Location = New System.Drawing.Point(952, 174)
        Me.CboFluxo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboFluxo.MaxLength = 8
        Me.CboFluxo.Name = "CboFluxo"
        Me.CboFluxo.Size = New System.Drawing.Size(200, 28)
        Me.CboFluxo.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CboFluxo, "Por favor, informe o fluxo da Movimentação")
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 403)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1417, 227)
        Me.DataGridView1.TabIndex = 77
        Me.DataGridView1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DataGridView1, "Bloqueado só para leitura")
        '
        'CboCategorias
        '
        Me.CboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCategorias.FormattingEnabled = True
        Me.CboCategorias.Items.AddRange(New Object() {"Pagamentos", "Estorno"})
        Me.CboCategorias.Location = New System.Drawing.Point(952, 218)
        Me.CboCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCategorias.Name = "CboCategorias"
        Me.CboCategorias.Size = New System.Drawing.Size(200, 28)
        Me.CboCategorias.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.CboCategorias, "Por favor, informe a categoria da compra")
        '
        'ListBox1
        '
        Me.ListBox1.ColumnWidth = 3
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"INFO. DA MOVIMENTAÇÃO:"})
        Me.ListBox1.Location = New System.Drawing.Point(1181, 44)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(316, 340)
        Me.ListBox1.TabIndex = 69
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssTexto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 787)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1579, 26)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssTexto
        '
        Me.tssTexto.BackColor = System.Drawing.Color.Transparent
        Me.tssTexto.Name = "tssTexto"
        Me.tssTexto.Size = New System.Drawing.Size(153, 20)
        Me.tssTexto.Text = "ToolStripStatusLabel1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(773, 182)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 18)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Fluxo de Caixa"
        '
        'mskPagamento
        '
        Me.mskPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPagamento.Location = New System.Drawing.Point(789, 351)
        Me.mskPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskPagamento.Mask = "00/00/0000"
        Me.mskPagamento.Name = "mskPagamento"
        Me.mskPagamento.Size = New System.Drawing.Size(127, 26)
        Me.mskPagamento.TabIndex = 15
        Me.mskPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskPagamento.ValidatingType = GetType(Date)
        '
        'lbldtpg
        '
        Me.lbldtpg.AutoSize = True
        Me.lbldtpg.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbldtpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldtpg.ForeColor = System.Drawing.SystemColors.Window
        Me.lbldtpg.Location = New System.Drawing.Point(679, 355)
        Me.lbldtpg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldtpg.Name = "lbldtpg"
        Me.lbldtpg.Size = New System.Drawing.Size(83, 20)
        Me.lbldtpg.TabIndex = 76
        Me.lbldtpg.Text = "Dt Pagto"
        '
        'txtValorPago
        '
        Me.txtValorPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPago.ForeColor = System.Drawing.Color.Green
        Me.txtValorPago.Location = New System.Drawing.Point(520, 351)
        Me.txtValorPago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorPago.MaxLength = 15
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(128, 26)
        Me.txtValorPago.TabIndex = 14
        Me.txtValorPago.Text = "0.00"
        Me.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblpg
        '
        Me.lblpg.AutoSize = True
        Me.lblpg.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpg.ForeColor = System.Drawing.SystemColors.Window
        Me.lblpg.Location = New System.Drawing.Point(341, 356)
        Me.lblpg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpg.Name = "lblpg"
        Me.lblpg.Size = New System.Drawing.Size(91, 18)
        Me.lblpg.TabIndex = 75
        Me.lblpg.Text = "Valor Pago"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(773, 227)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 18)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Categoria"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Window
        Me.Label17.Location = New System.Drawing.Point(939, 356)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 18)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Saldo"
        '
        'lblSaldo
        '
        Me.lblSaldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(1025, 351)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(127, 26)
        Me.lblSaldo.TabIndex = 82
        Me.lblSaldo.Text = "0.00"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(520, 87)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(163, 26)
        Me.lblNome.TabIndex = 83
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSobrenome
        '
        Me.lblSobrenome.BackColor = System.Drawing.SystemColors.Window
        Me.lblSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrenome.Location = New System.Drawing.Point(953, 87)
        Me.lblSobrenome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(200, 26)
        Me.lblSobrenome.TabIndex = 84
        Me.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCartao
        '
        Me.lblCartao.BackColor = System.Drawing.SystemColors.Window
        Me.lblCartao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartao.Location = New System.Drawing.Point(988, 131)
        Me.lblCartao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCartao.Name = "lblCartao"
        Me.lblCartao.Size = New System.Drawing.Size(164, 26)
        Me.lblCartao.TabIndex = 85
        Me.lblCartao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FaturaCartao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1579, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCartao)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CboCategorias)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.mskPagamento)
        Me.Controls.Add(Me.lbldtpg)
        Me.Controls.Add(Me.txtValorPago)
        Me.Controls.Add(Me.cboConsolidada)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblpg)
        Me.Controls.Add(Me.CboFluxo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnGerParc)
        Me.Controls.Add(Me.mskDataR)
        Me.Controls.Add(Me.mskVencimento)
        Me.Controls.Add(Me.cboNParcelas)
        Me.Controls.Add(Me.lblnpc)
        Me.Controls.Add(Me.lblvcpg)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblvpc)
        Me.Controls.Add(Me.cboCPF)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CboNCartao)
        Me.Controls.Add(Me.txtHistorico)
        Me.Controls.Add(Me.lblIdCartaoMov)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FaturaCartao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fluxo de Caixa do Cartão de Crédito"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CboNCartao As System.Windows.Forms.ComboBox
    Friend WithEvents txtHistorico As System.Windows.Forms.TextBox
    Friend WithEvents lblIdCartaoMov As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCPF As System.Windows.Forms.ComboBox
    Friend WithEvents lblvpc As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblvcpg As System.Windows.Forms.Label
    Friend WithEvents cboNParcelas As System.Windows.Forms.ComboBox
    Friend WithEvents lblnpc As System.Windows.Forms.Label
    Friend WithEvents mskVencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboConsolidada As System.Windows.Forms.ComboBox
    Friend WithEvents mskDataR As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGerParc As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssTexto As ToolStripStatusLabel
    Friend WithEvents CboFluxo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents mskPagamento As MaskedTextBox
    Friend WithEvents lbldtpg As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents lblpg As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CboCategorias As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents lblCartao As Label
End Class
