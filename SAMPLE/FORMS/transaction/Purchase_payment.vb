Public Class Purchase_payment
    Dim oldmode As String
    Dim mode As String
    Dim billno1 As String
    Dim supname As String
    Dim asd As Integer
    Public Sub New(ByVal a As String, ByVal b As String)
        Try
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Me.billno1 = a
            Me.supname = b
            If billno1 <> "" And supname <> "" Then
                asd = 1
                billno.Text = billno1
                txt_suppliername.Text = supname
                billno_Leave(Nothing, Nothing)
                grid.Visible = False
            End If
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_suppliername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_suppliername.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                If txt_suppliername.Text <> "" Then
                    If grid.Visible = True Then
                        grid.Focus()
                    Else
                        search()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub search()
        Try
            If txt_suppliername.Text = "" Then
                MsgBox("Please Enter SupplierName", MsgBoxStyle.Information, suss)
                txt_suppliername.Focus()
            Else
                Dim ds As New DataTable
                ds = purchasepayview(txt_suppliername.Text, "", "", "viewpay")
                grid_purchasepay.DataSource = ds
                grid_purchasepay.Columns(6).Visible = False
                Call count()
                billno.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub count()
        Try
            Dim tot As Decimal = 0
            Dim paid As Decimal = 0
            For i As Integer = 0 To grid_purchasepay.RowCount - 1
                tot = tot + grid_purchasepay.Rows(i).Cells(2).Value
                paid = paid + grid_purchasepay.Rows(i).Cells(3).Value + grid_purchasepay.Rows(i).Cells(4).Value
            Next
            lbl_totamt.Text = tot
            lbl_paidamt.Text = paid
            pending.Text = Format(Val(tot) - Val(paid), "0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub grid_clear()
        Try
            grid_purchasepay.DataSource = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_suppliername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_suppliername.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_suppliername.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_suppliername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suppliername.TextChanged
        Try
            If txt_suppliername.Text = "" Then
                grid.Visible = False
                Call grid_clear()
                txt_suppliername.Focus()
            Else
                Dim sup As New DataTable
                sup = supplier_procedure(txt_suppliername.Text + "%", "", "", "", "", "", "", "", "VIEW1", "")
                grid.DataSource = sup
                If sup.Rows.Count > 0 Then
                    grid.Visible = True
                    grid.Columns(0).Width = 180
                    grid.Columns(1).Width = 180
                    grid.Columns(2).Visible = False
                    grid.Columns(3).Visible = False
                    grid.Columns(4).Visible = False
                    grid.Columns(5).Visible = False
                    grid.Columns(6).Visible = False
                Else
                    txt_suppliername.Text = ""
                    txt_suppliername.Focus()
                    grid.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub grid_suppliernames_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim a As String
                Dim b As String
                a = grid.CurrentRow.Cells(0).Value
                b = grid.CurrentRow.Cells(1).Value.ToString
                txt_suppliername.Text = a
                grid.Visible = False
                txt_suppliername.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_suppliername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmb_type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_type.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cmb_type.Text = "CASH" Then
                    txt_amount.Focus()
                Else
                    txt_Accname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_suppliername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        Try
            If cmb_type.Text = "CASH" Then
                chequegp.Visible = False
            ElseIf cmb_type.SelectedIndex = -1 Then
                chequegp.Visible = False
            Else
                chequegp.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clr()
        Try
            txt_suppliername.Text = ""
            txt_Accname.Text = ""
            dtp_paydate.Value = Date.Today
            txt_suppliername.Focus()
            chequegp.Visible = False
            txt_amount.Text = "0.00"
            txt_adjust.Text = "0.00"
            cmb_type.SelectedIndex = -1
            billno.Text = ""
            Btn_save.Enabled = True
            btn_edit.Text = "&EDIT"
            lbl_totamt.Text = "0.00"
            lbl_paidamt.Text = "0.00"
            pending.Text = "0.00"
            billno.Enabled = True
            txt_suppliername.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub credit_clr()
        Try
            grid.Visible = False
            grid_purchasepay.DataSource = ""
            txt_Accname.Text = ""
            txt_Accno.Text = ""
            txt_Chequeno.Text = ""
            cmb_Bankname.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_save.Click
        Try
            If dtp_paydate.Text = "" Or billno.Text = "" Or txt_suppliername.Text = "" Or cmb_type.Text = "" Or Val(txt_amount.Text) = 0 And Val(txt_adjust.Text) = 0 Then
                MsgBox("please fill the all fields", MsgBoxStyle.Information, "Message")
                dtp_paydate.Focus()
            Else

                Dim sve As New DataTable
                sve = purchase_pay_proc(dtp_paydate.Value.ToString("MM/dd/yyyy"), Trim(billno.Text), Trim(cmb_type.Text), Val(txt_amount.Text), Val(txt_adjust.Text), Trim(cmb_Bankname.Text), Trim(txt_Accname.Text), txt_Accno.Text, txt_Chequeno.Text, Trim(txt_suppliername.Text), chdat.Value.ToString("MM/dd/yyyy"), "", "INSERT")
                If sve.Rows(0)(0) = 1 Then
                    MsgBox("Saved Successfully", MsgBoxStyle.Information, suss)
                    search2()
                    clr()
                    credit_clr()
                Else
                    MsgBox("Already Exists For This Date.", MsgBoxStyle.Information, suss)
                    dtp_paydate.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Try
            Dim response As String
            If btn_edit.Text = "&EDIT" Then
                Dim getdt As New DataTable
                getdt = grid_purchasepay.DataSource
                If txt_suppliername.Text = "" Then
                    MsgBox("Please Fill Suppliername", MsgBoxStyle.YesNo, "message")
                    txt_suppliername.Focus()
                ElseIf billno.Text = "" Then
                    MsgBox("Please Fill Billno", MsgBoxStyle.YesNo, "message")
                    billno.Focus()
                ElseIf grid_purchasepay.RowCount <> 0 Then
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        If grid_purchasepay.CurrentRow.Cells(5).Value.ToString = "CREDIT" Then
                            MsgBox("Can't Be Edit", MsgBoxStyle.Information, suss)
                        ElseIf grid_purchasepay.CurrentRow.Cells(5).Value = "CHEQUE" Then
                            lbl_paidamt.Text = Val(lbl_paidamt.Text) - (getdt.Rows(grid_purchasepay.CurrentRow.Index)(3) + getdt.Rows(grid_purchasepay.CurrentRow.Index)(4))
                            pending.Text = Format(Val(lbl_totamt.Text) - Val(lbl_paidamt.Text), "0.00")
                            Dim det As New DataTable
                            billno.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(0)
                            btn_edit.Text = "&UPDATE"
                            txt_suppliername.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(6)
                            Dim aa As String
                            Dim dat As Date
                            aa = getdt.Rows(grid_purchasepay.CurrentRow.Index)(1)
                            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                            dat = CDate(aa)
                            dtp_paydate.Value = dat
                            cmb_type.Text = "CHEQUE"
                            txt_amount.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(3)
                            txt_adjust.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(4)
                            Dim aa1 As String
                            aa1 = getdt.Rows(grid_purchasepay.CurrentRow.Index)(1)
                            aa1 = aa1.Substring(6, 4) & "/" & aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2)
                            olddate.Text = aa1
                            Dim details As DataTable
                            details = purchase_pay_proc(Trim(olddate.Text), Trim(billno.Text), "", 0, 0, "", "", "", "", "", "", "", "ChequeDetails")
                            chequegp.Visible = True
                            If details.Rows.Count <> 0 Then
                                txt_Accname.Text = details.Rows(0)(1)
                                txt_Accno.Text = details.Rows(0)(2)
                                txt_Chequeno.Text = details.Rows(0)(3)
                                cmb_Bankname.Text = details.Rows(0)(0)
                                Dim aa2 As String
                                Dim dat2 As Date
                                aa2 = details.Rows(0)(4)
                                aa2 = aa2.Substring(3, 2) & "/" & aa2.Substring(0, 2) & "/" & aa2.Substring(6, 4)
                                dat2 = CDate(aa2)
                                chdat.Value = dat2
                            End If
                            Btn_save.Enabled = False
                            billno.Enabled = False
                            txt_suppliername.Enabled = False
                        ElseIf grid_purchasepay.CurrentRow.Cells(5).Value = "CASH" Then
                            lbl_paidamt.Text = Val(lbl_paidamt.Text) - (getdt.Rows(grid_purchasepay.CurrentRow.Index)(3) + getdt.Rows(grid_purchasepay.CurrentRow.Index)(4))
                            pending.Text = Format(Val(lbl_totamt.Text) - Val(lbl_paidamt.Text), "0.00")
                            Dim det As New DataTable
                            billno.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(0)
                            btn_edit.Text = "&UPDATE"
                            txt_suppliername.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(6)
                            Dim aa As String
                            Dim dat As Date
                            aa = getdt.Rows(grid_purchasepay.CurrentRow.Index)(1)
                            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                            dat = CDate(aa)
                            dtp_paydate.Value = dat
                            cmb_type.Text = "CASH"
                            txt_amount.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(3)
                            txt_adjust.Text = getdt.Rows(grid_purchasepay.CurrentRow.Index)(4)
                            Dim aa1 As String
                            aa1 = getdt.Rows(grid_purchasepay.CurrentRow.Index)(1)
                            aa1 = aa1.Substring(6, 4) & "/" & aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2)
                            olddate.Text = aa1
                            chequegp.Visible = False
                            Btn_save.Enabled = False
                            billno.Enabled = False
                            txt_suppliername.Enabled = False
                        End If
                    End If
                End If
            ElseIf btn_edit.Text = "&UPDATE" Then
                If _billno.Text = "" Then
                    billno.Focus()
                ElseIf txt_suppliername.Text = "" Then
                    txt_suppliername.Focus()
                ElseIf Val(txt_amount.Text) = 0 And Val(txt_adjust.Text) = 0 Then
                    txt_amount.Focus()
                ElseIf dtp_paydate.Text = "" Or billno.Text = "" Or txt_suppliername.Text = "" Or cmb_type.Text = "" Or txt_amount.Text = "" Or txt_adjust.Text = "" Then
                    MsgBox("please fill the all fields", MsgBoxStyle.Information, "Message")
                    dtp_paydate.Focus()
                Else
                    Dim saldt As New DataTable
                    saldt = purchase_pay_proc(dtp_paydate.Value.ToString("MM/dd/yyyy"), Trim(billno.Text), cmb_type.Text, Val(txt_amount.Text), Val(txt_adjust.Text), Trim(cmb_Bankname.Text), Trim(txt_Accname.Text), Trim(txt_Accno.Text), Trim(txt_Chequeno.Text), Trim(txt_suppliername.Text), chdat.Value.ToString("MM/dd/yyyy"), Trim(olddate.Text), "Update")
                    If saldt.Rows(0)(0) = 3 Then
                        MsgBox("Successfully Updated", MsgBoxStyle.Information, suss)
                        chequegp.Visible = False
                        Btn_save.Visible = True
                        btn_edit.Text = "&EDIT"
                        Call search()
                        Call clr()
                        credit_clr()
                    Else
                        MsgBox("Not Successfully updated", MsgBoxStyle.Information, suss)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Purchase_payment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Purchase_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt7 As New DataTable
            dt7 = viewbank()
            Dim dr As DataRow
            cmb_Bankname.Items.Clear()
            For Each dr In dt7.Rows()
                cmb_Bankname.Items.Add(dr("bankname"))
            Next
            dtp_paydate.Value = Date.Today
            txt_amount.Text = "0.00"
            txt_adjust.Text = "0.00"
            count()
            txt_suppliername.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_save_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Btn_save.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_edit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_edit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_xit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_xit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chequegp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chequegp.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid_purchasepay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_purchasepay.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_paydate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_paydate.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                cmb_type.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_amount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_amount.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_adjust.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_amount.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_Accname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Accname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_Accname.Text <> "" Then
                    txt_Accno.Focus()
                Else
                    txt_Accname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Accname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Accname.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_suppliername.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_Accno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Accno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_Accno.Text <> "" Then
                    txt_Chequeno.Focus()
                Else
                    txt_Accno.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_Chequeno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Chequeno.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                If txt_Chequeno.Text <> "" Then
                    cmb_Bankname.Focus()
                Else
                    txt_Chequeno.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmb_Bankname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Bankname.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                If cmb_Bankname.Text <> "" Then
                    chdat.Focus()
                Else
                    cmb_Bankname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_Chequeno.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_adjust_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_adjust.TextChanged
        Try
            If Val(txt_adjust.Text) <> 0 Then
                Dim ad As Decimal
                ad = Val(pending.Text)
                bal.Text = Val(ad.ToString)
                Dim rr As Decimal
                rr = Val(txt_amount.Text) + Val(txt_adjust.Text)
                If Val(rr.ToString) > Val(bal.Text) Then
                    MsgBox("Payment Must Be Less Than Balance", MsgBoxStyle.Information, suss)
                    txt_adjust.Text = "0.00"
                    txt_adjust.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub group_browse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles group_browse.Click
        Try
            Add_BankName.ShowDialog()
            cmb_Bankname.Focus()
            Dim dt7 As New DataTable
            dt7 = viewbank()
            Dim dr As DataRow
            cmb_Bankname.Items.Clear()
            For Each dr In dt7.Rows()
                cmb_Bankname.Items.Add(dr("bankname"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_xit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billno.TextChanged
        Try
            Dim dt As New DataTable
            If billno.Text = "" Then
                grid1.Visible = False
                Call grid_clear()
                billno.Text = ""
            Else
                dt = purchasepayview(txt_suppliername.Text, billno.Text + "%", "", "BILLNO")
                If dt.Rows.Count <> 0 Then
                    grid1.DataSource = dt
                    grid1.Visible = True
                    grid1.Columns(0).Width = 100
                    grid1.Columns(1).Width = 100
                Else
                    billno.Text = ""
                    billno.Focus()
                    grid1.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles billno.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                If billno.Text <> "" And txt_suppliername.Text <> "" Then
                    If grid1.Visible = True Then
                        grid1.Focus()
                    Else
                        search2()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub search2()
        Try
            If billno.Text = "" Then
                MsgBox("Please Enter billno", MsgBoxStyle.Information, )
                txt_suppliername.Focus()
            Else
                Dim ds As New DataTable
                ds = purchasepayview(Trim(txt_suppliername.Text), Trim(billno.Text), "", "BILLWISE")
                grid_purchasepay.DataSource = ds
                grid_purchasepay.Columns(6).Visible = False
                Call count()
                dtp_paydate.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_adjust_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_adjust.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Btn_save.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Up Then
                txt_amount.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_adjust_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_adjust.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_amount.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged
        Try
            If Val(txt_amount.Text) <> 0 Then
                Dim ad As Decimal
                ad = Val(pending.Text)
                bal.Text = Val(ad)
                Dim rr As Decimal
                rr = Val(txt_amount.Text) + Val(txt_adjust.Text)
                If Val(rr.ToString) > Val(bal.Text) Then
                    MsgBox("Payment Must Be Less Than Balance", MsgBoxStyle.Information, suss)
                    txt_amount.Text = "0.00"
                    txt_amount.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        Try
            Dim a As String
            Dim b As String
            a = grid.CurrentRow.Cells(0).Value
            b = grid.CurrentRow.Cells(1).Value.ToString
            txt_suppliername.Text = a
            grid.Visible = False
            txt_suppliername.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Try
            Dim a As String
            Dim b As String
            a = grid1.CurrentRow.Cells(0).Value
            b = grid1.CurrentRow.Cells(1).Value
            billno.Text = a
            grid1.Visible = False
            billno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                grid1_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billno.Leave
        Try
            If billno.Text <> "" And txt_suppliername.Text <> "" Then
                If grid1.Visible = True Then
                    grid1.Focus()
                Else
                    search2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chdat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chdat.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    credit_clr()
                    clr()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                If chdat.Text <> "" And dtp_paydate.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = dtp_paydate.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If chdat.Value < dat Then
                        MsgBox("Check Date Must Be Greater Than Entry Date", MsgBoxStyle.Information, suss)
                        chdat.Value = dat
                        chdat.Focus()
                    Else
                        txt_amount.Focus()
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Left Then
                cmb_Bankname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles billno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_Accno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Accno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Chequeno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Chequeno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_Bankname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Bankname.KeyPress
        Try
            e.Handled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class