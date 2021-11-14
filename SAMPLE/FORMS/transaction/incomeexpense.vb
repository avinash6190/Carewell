Public Class incomeexpense
    Dim A As String
    Dim d As Integer
    Dim id As String
    Dim t As String
    Dim r As String
    Dim gdt As New DataTable
    Dim response As String
    Dim s As String = ""
    Dim dat As Date
    Dim ed As Integer
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click
        Try
            If (income.Checked = False And expense.Checked = False And idi.Checked = False And ide.Checked = False) Or Val(amt.Text) = 0 Or Trim(DESC.Text) = "" Then
                MsgBox("Please Fill All The Details", MsgBoxStyle.Information, "Message")
            ElseIf income.Checked = True Or idi.Checked = True Then
                If txt_inc.SelectedIndex = -1 Then
                    MsgBox("Please Fill All The Details", MsgBoxStyle.Information, "Message")
                Else
                    response = MsgBox("Are You Sure", MsgBoxStyle.YesNo, "Message")
                    If vbYes = response Then
                        If income.Checked = True Then
                            A = "Direct Income"
                        ElseIf idi.Checked = True Then
                            A = "Indirect Income"
                        End If
                        If btn_ADD.Text = "&SAVE" Then
                            d = income_PROC(0, date1.Value.ToString("MM/dd/yyyy"), txt_inc.SelectedItem, DESC.Text, "", "", "", "", "", Val(amt.Text), "INSERT", A)
                            If d = 1 Then
                                MsgBox("Income Saved", MsgBoxStyle.Information, "Message")
                                cancel()
                            ElseIf d = 0 Then
                                MsgBox("Already Exist", MsgBoxStyle.Information, "Message")
                            End If
                        Else
                            If r = "Income" Then
                                d = income_PROC(Val(txt_id.Text), date1.Value.ToString("MM/dd/yyyy"), txt_inc.SelectedItem, DESC.Text, "", "", "", "", "", Val(amt.Text), "UPDATE", A)
                                If d = 2 Then
                                    MsgBox("Income Updated", MsgBoxStyle.Information, "Message")
                                    cancel()
                                ElseIf d = 0 Then
                                    MsgBox("Already Exist", MsgBoxStyle.Information, "Message")
                                End If
                            Else
                                MsgBox("Expenses Can't Change To Income" & vbNewLine & "U Have To Delete", MsgBoxStyle.Information, "Message")
                                cancel()
                            End If
                        End If
                    End If
                End If
            ElseIf expense.Checked = True Or ide.Checked = True Then
                If txt_inc.SelectedIndex = -1 Then
                    MsgBox("Please Fill All The Details", MsgBoxStyle.Information, "Message")
                Else
                    response = MsgBox("Are You Sure        ", MsgBoxStyle.YesNo, "Message")
                    If vbYes = response Then
                        If expense.Checked = True Then
                            A = "Direct Expenses"
                        ElseIf ide.Checked = True Then
                            A = "Indirect Expenses"
                        End If
                        If btn_ADD.Text = "&SAVE" Then
                            d = exp_PROC(0, date1.Value.ToString("MM/dd/yyyy"), txt_inc.SelectedItem, DESC.Text, "", "", "", "", "", Val(amt.Text), "INSERT", A)
                            If d = 1 Then
                                MsgBox("Expense Saved", MsgBoxStyle.Information, "Message")
                                cancel()
                            ElseIf d = 0 Then
                                MsgBox("Already Exist", MsgBoxStyle.Information, "Message")
                            End If
                        Else
                            If r = "Exp" Then
                                d = exp_PROC(Val(txt_id.Text), date1.Value.ToString("MM/dd/yyyy"), txt_inc.SelectedItem, DESC.Text, "", "", "", "", "", Val(amt.Text), "UPDATE", A)
                                If d = 2 Then
                                    MsgBox("Expense Updated", MsgBoxStyle.Information, "Message")
                                    cancel()
                                ElseIf d = 0 Then
                                    MsgBox("Already Exist", MsgBoxStyle.Information, "Message")
                                End If
                            Else
                                MsgBox("Income Can't Change To Expenses" & vbNewLine & "U Have To Delete", MsgBoxStyle.Information, "Message")
                                cancel()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub view()
        Try
            Dim dt_inc As New DataTable
            Dim dt_exp As New DataTable
            dt_inc = income_PROC(0, date1.Value.ToString("MM/dd/yyyy"), "", "", "", "", "", "", "", 0, "viewbydate", cashinhand.Text + "%")
            dt_exp = exp_PROC(0, date1.Value.ToString("MM/dd/yyyy"), "", "", "", "", "", "", "", 0, "viewbydate", cashinhand.Text + "%")
            If income.Checked = True Then
                grid1.DataSource = dt_inc
                gridwidth()
            ElseIf expense.Checked = True Then
                grid1.DataSource = dt_exp
                gridwidth()
            ElseIf idi.Checked = True Then
                grid1.DataSource = dt_inc
                gridwidth()
            ElseIf ide.Checked = True Then
                grid1.DataSource = dt_exp
                gridwidth()
            Else
                gdt.Rows.Clear()
                For Each dr As DataRow In dt_inc.Rows()
                    gdt.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                Next
                For Each dr As DataRow In dt_exp.Rows()
                    gdt.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                Next
                grid1.DataSource = gdt
                gridwidth()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub comments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F8 Then
                cancel()
            ElseIf e.KeyCode = Keys.F3 Then
                btn_save_Click(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Enter Valid Input", MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub comments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            grid_creation()
            cancel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub grid_creation()
        Try
            gdt.Columns.Add("Id")
            gdt.Columns.Add("Date")
            gdt.Columns.Add("Mode")
            gdt.Columns.Add("Name")
            gdt.Columns.Add("Paytype")
            gdt.Columns.Add("Amount")
            gdt.Columns.Add("Description")
            grid1.DataSource = gdt
            gridwidth()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub gridwidth()
        Try
            grid1.Columns(0).Visible = False
            grid1.Columns(1).Width = 100
            grid1.Columns(2).Width = 75
            grid1.Columns(3).Width = 150
            grid1.Columns(4).Visible = False
            grid1.Columns(5).Width = 125
            grid1.Columns(6).Width = 200
            count()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub count()
        Try
            Dim tot As Decimal = 0.0
            For i As Integer = 0 To grid1.Rows.Count - 1
                tot += grid1.Rows(i).Cells(5).Value
            Next
            lbl_tot.Text = Format(tot, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub cancel()
        Try
            amt.Text = ""
            DESC.Text = ""
            date1.Value = Today.Date
            paytype.SelectedIndex = -1
            txt_inc.SelectedIndex = -1
            txt_exp.SelectedIndex = -1
            txt_inc.Items.Clear()
            txt_exp.Items.Clear()
            income.Checked = False
            expense.Checked = False
            idi.Checked = False
            ide.Checked = False
            btn_ADD.Text = "&SAVE"
            cashinhand.Text = ""
            BTN_DELETE.Enabled = True
            view()
            date1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub INC()
        Try
            If cashinhand.Text <> "0.00" Then
                Dim frm1 As New DataTable
                frm1 = INEX_PROC(0, "", cashinhand.Text, "VIEWINC")
                Dim frmdr1 As DataRow
                txt_inc.Items.Clear()
                For Each frmdr1 In frm1.Rows()
                    txt_inc.Items.Add(frmdr1("IENAME"))
                Next
            Else
                MsgBox("Select Mode", MsgBoxStyle.Information, "Message")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub EXP()
        Try
            If cashinhand.Text <> "0.00" Then
                Dim frm2 As New DataTable
                frm2 = INEX_PROC(0, "", cashinhand.Text, "VIEWEXP")
                Dim frmdr2 As DataRow
                txt_inc.Items.Clear()
                For Each frmdr2 In frm2.Rows()
                    txt_inc.Items.Add(frmdr2("IENAME"))
                Next
            Else
                MsgBox("Select Mode", MsgBoxStyle.Information, "Message")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub income_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles income.CheckedChanged
        Try
            If ed = 0 Then
                ed = 1
                expense.Checked = False
                ide.Checked = False
                ed = 0
            End If
            If income.Checked = True Or idi.Checked = True Then
                lblincome.Text = "Income"
                If income.Checked = True Then
                    cashinhand.Text = "direct Income"
                ElseIf idi.Checked = True Then
                    cashinhand.Text = "Indirect Income"
                End If
                INC()
                view()
            ElseIf expense.Checked = True Or ide.Checked = True Then
                lblincome.Text = "Expense"
                If expense.Checked = True Then
                    cashinhand.Text = "direct Expenses"
                ElseIf ide.Checked = True Then
                    cashinhand.Text = "Indirect Expenses"
                End If
                EXP()
                view()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub amt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles amt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Trim(amt.Text) <> "" Then
                    DESC.Focus()
                Else
                    amt.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub amt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles amt.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox("Enter Valid Input", MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Function TraKey(ByVal KCode As String) As Boolean
        Try
            If KCode = 91 Then
                TraKey = False
            Else
                TraKey = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Function
    Private Function TrapKey(ByVal KCode As String) As Boolean
        Try
            If (KCode >= 48 And KCode <= 57) Or (KCode >= 46 And KCode <= 46) Or KCode = 8 Then
                TrapKey = False
            Else
                TrapKey = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Function
    Private Sub paytype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles paytype.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If paytype.SelectedIndex <> -1 Then
                    amt.Focus()
                Else
                    paytype.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub paytype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paytype.SelectedIndexChanged
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub expense_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expense.CheckedChanged
        Try
            If ed = 0 Then
                ed = 1
                income.Checked = False
                idi.Checked = False
                ed = 0
            End If
            If income.Checked = True Or idi.Checked = True Then
                lblincome.Text = "Income"
                If income.Checked = True Then
                    cashinhand.Text = "direct Income"
                ElseIf idi.Checked = True Then
                    cashinhand.Text = "Indirect Income"
                End If
                INC()
                view()
            ElseIf expense.Checked = True Or ide.Checked = True Then
                lblincome.Text = "Expense"
                If expense.Checked = True Then
                    cashinhand.Text = "direct Expenses"
                ElseIf ide.Checked = True Then
                    cashinhand.Text = "Indirect Expenses"
                End If
                EXP()
                view()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_exp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_exp.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_exp.SelectedIndex <> -1 Then
                    paytype.Focus()
                Else
                    txt_exp.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub DESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DESC.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or DESC.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub Cheque_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Try
            cancel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub ACCTNO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    

    Private Sub date1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles date1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If income.Checked = True Then
                    txt_inc.Focus()
                ElseIf expense.Checked = True Then
                    txt_exp.Focus()
                Else
                    income.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub date1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date1.ValueChanged
        Try
            view()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Try
            Dim dt_chk As New DataTable
            Dim name As String
            If grid1.Rows.Count <> 0 Then
                txt_id.Text = grid1.CurrentRow.Cells(0).Value
                Dim aa As String
                aa = grid1.CurrentRow.Cells(1).Value
                aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                dat = CDate(aa)
                date1.Value = dat
                paytype.Text = grid1.CurrentRow.Cells(4).Value.ToString
                amt.Text = grid1.CurrentRow.Cells(5).Value
                DESC.Text = grid1.CurrentRow.Cells(6).Value
                name = grid1.CurrentRow.Cells(3).Value
                Dim str As String
                str = grid1.CurrentRow.Cells(2).Value
                If str = "Direct Income" Then
                    r = "Income"
                    income.Checked = True
                    txt_inc.Text = name
                ElseIf str = "Indirect Income" Then
                    r = "Income"
                    idi.Checked = True
                    txt_inc.Text = name
                ElseIf str = "Direct Expenses" Then
                    r = "Exp"
                    expense.Checked = True
                    txt_inc.Text = name
                ElseIf str = "Indirect Expenses" Then
                    r = "Exp"
                    ide.Checked = True
                    txt_inc.Text = name
                End If
                btn_ADD.Text = "&UPDATE"
                BTN_DELETE.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Select Particular Row On Grid", MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub BTN_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DELETE.Click
        Try
            If grid1.Rows.Count <> 0 Then
                response = MsgBox("Are You Sure        ", MsgBoxStyle.YesNo, "Message")
                If vbYes = response Then
                    Dim mode As String = grid1.CurrentRow.Cells(2).Value
                    txt_id.Text = grid1.CurrentRow.Cells(0).Value
                    If mode = "Direct Income" Or mode = "Indirect Income" Then
                        d = income_PROC(Val(txt_id.Text), "", "", "", "", "", "", "", "", 0, "DELETE", "")
                        If d = "3" Then
                            MsgBox("Income Deleted.", MsgBoxStyle.Information, "Message")
                            cancel()
                        Else
                            MsgBox("Cannot Be Deleted.", MsgBoxStyle.Information, "Message")
                        End If
                    ElseIf mode = "Direct Expenses" Or mode = "Indirect Expenses" Then
                        d = exp_PROC(Val(txt_id.Text), "", "", "", "", "", "", "", "", 0, "DELETE", "")
                        If d = "3" Then
                            MsgBox("Expense Deleted.", MsgBoxStyle.Information, "Message")
                            cancel()
                        Else
                            MsgBox("Cannot Be Deleted.", MsgBoxStyle.Information, "Message")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub txt_inc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_inc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_inc.SelectedIndex <> -1 Then
                    amt.Focus()
                Else
                    txt_inc.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub income_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles income.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                date1.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                expense.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub expense_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles expense.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                date1.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                income.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub amt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amt.TextChanged
     
    End Sub
    Private Sub idi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idi.CheckedChanged
        Try
            If ed = 0 Then
                ed = 1
                expense.Checked = False
                ide.Checked = False
                ed = 0
            End If
            If income.Checked = True Or idi.Checked = True Then
                lblincome.Text = "Income"
                If income.Checked = True Then
                    cashinhand.Text = "direct Income"
                ElseIf idi.Checked = True Then
                    cashinhand.Text = "Indirect Income"
                End If
                INC()

                view()
            ElseIf expense.Checked = True Or ide.Checked = True Then
                lblincome.Text = "Expense"
                If expense.Checked = True Then
                    cashinhand.Text = "direct Expenses"
                ElseIf ide.Checked = True Then
                    cashinhand.Text = "Indirect Expenses"
                End If

                EXP()
                view()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub ide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ide.CheckedChanged
        Try
            If ed = 0 Then
                ed = 1
                income.Checked = False
                idi.Checked = False
                ed = 0
            End If
            If income.Checked = True Or idi.Checked = True Then
                lblincome.Text = "Income"
                If income.Checked = True Then
                    cashinhand.Text = "direct Income"
                ElseIf idi.Checked = True Then
                    cashinhand.Text = "Indirect Income"
                End If
                INC()

                view()
            ElseIf expense.Checked = True Or ide.Checked = True Then
                lblincome.Text = "Expense"
                If expense.Checked = True Then
                    cashinhand.Text = "direct Expenses"
                ElseIf ide.Checked = True Then
                    cashinhand.Text = "Indirect Expenses"
                End If

                EXP()
                view()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub brws_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brws.Click
        ledger.ShowDialog()
    End Sub
End Class