Module LimparForm
    Function APagarForm(ByVal frm As Form)
        'Limpar todo o formulário
        Try
            For Each ctl As Control In frm.Controls
                If TypeOf ctl Is TextBox Then
                    CType(ctl, TextBox).Text = ""
                ElseIf TypeOf ctl Is ComboBox Then
                    CType(ctl, ComboBox).SelectedIndex = -1
                ElseIf TypeOf ctl Is MaskedTextBox Then
                    CType(ctl, MaskedTextBox).Clear() 'ou .Text = ""
                ElseIf TypeOf ctl Is CheckBox Then
                    CType(ctl, CheckBox).Checked = False
                ElseIf TypeOf ctl Is RadioButton Then
                    CType(ctl, RadioButton).Checked = False
                End If
            Next
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, Sistema)
        Finally
        End Try
        Return frm
    End Function

    Public Sub PLimpar()
        Try
            'Percorrer todos os formulários abertos
            For Each form As Form In Application.OpenForms
                'Verifica se não é o formulário principal
                If form.Name <> "FrmPrincipal" Then
                    'Percorrer todos os controles e apagar os dados
                    For Each controle As Control In form.Controls
                        If TypeOf controle Is TextBox Then
                            Dim txt As TextBox = TryCast(controle, TextBox)
                            txt.Text = String.Empty
                            txt.Visible = True
                            'Ajustar este controle para receber os dados padrão 
                            If txt.Name = "txtDataR" Then
                                txt.Text = Today
                            ElseIf txt.Name = "txtSenCartao" Then
                                txt.Enabled = True
                                txt.PasswordChar = ("")
                            ElseIf txt.Name = "txtCSeg" Then
                                txt.Enabled = True
                                txt.PasswordChar = ("")
                            ElseIf txt.Name = "txtValor" Then
                                txt.Text = "0.00"
                            End If
                        ElseIf TypeOf controle Is ComboBox Then
                            Dim cbo As ComboBox = TryCast(controle, ComboBox)
                            cbo.Enabled = True
                            cbo.Visible = True
                            cbo.SelectedIndex = -1
                            cbo.Text = ""
                            'Ajustar este controle para receber os dados padrão
                            If cbo.Name = "CboStatus" Then
                                cbo.Text = "Bloqueado"
                                cbo.Enabled = False
                            ElseIf cbo.Name = "CboTipo" Then
                                cbo.Text = "Crédito"
                                cbo.Enabled = False
                            End If
                        ElseIf TypeOf controle Is Label Then
                            Dim lbl As Label = TryCast(controle, Label)
                            lbl.Visible = True
                            'Restringir a limpeza à estes controles
                            If lbl.Name = "lblId" Or lbl.Name = "LblDataR" Or lbl.Name = "lblNome" Or lbl.Name = "lblSobrenome" Or lbl.Name = "lblInst" Or lbl.Name = "lblNBan" Or lbl.Name = "lblNAg" Or lbl.Name = "lblSaldo" Or lbl.Name = "lblCartao" Then
                                lbl.Text = String.Empty
                            ElseIf lbl.Name = "LblDataR" Then
                                'Ajustar este controle para receber a data de hoje
                                lbl.Text = Now
                            End If
                        ElseIf TypeOf controle Is MaskedTextBox Then
                            Dim mtb As MaskedTextBox = TryCast(controle, MaskedTextBox)
                            mtb.Clear()
                            mtb.Enabled = True
                            mtb.Visible = True
                            If mtb.Name = "TxtProcurar" Then
                                mtb.Mask = ""
                            ElseIf mtb.Name = "mskDataR" Then
                                mtb.Text = Now
                            End If
                        ElseIf TypeOf controle Is DataGridView Then
                            Dim dgv As DataGridView = TryCast(controle, DataGridView)
                            With dgv
                                'Código para percorrer todas as linhas e achar a selecionada
                                For i = .Rows.Count - 1 To 0 Step -1
                                    .Rows(i).Selected = False
                                    .Rows(i).Cells(0).Value = 0
                                Next
                            End With
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
