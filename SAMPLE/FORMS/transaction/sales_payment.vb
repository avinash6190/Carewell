Public Class sales_payment
    Dim billno As String
    Dim asd As Integer
    Public Sub New(ByVal a As String)
        Try
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Me.billno = a
            If billno <> "" Then
                asd = 1
                txt_billno.Text = billno
                txt_billno_Leave(Nothing, Nothing)
            End If
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sales_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "SALES PAYMENT"
            If billno = "" Then
                Dim dt As New DataTable
                dt = viewbank()
                Dim dr As DataRow
                cmb_Bankname.Items.Clear()
                For Each dr In dt.Rows()
                    cmb_Bankname.Items.Add(dr("bankname"))
                Next
                txt_billno.Focus()
                dtp_paydate.Value = Date.Today
                clr()
            Else
                Dim dt As New DataTable
                dt = viewbank()
                Dim dr As DataRow
                cmb_Bankname.Items.Clear()
                For Each dr In dt.Rows()
                    cmb_Bankname.Items.Add(dr("bankname"))
                Next
                txt_billno.Focus()
                dtp_paydate.Value = Date.Today
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clr()
        Try
            dtp_paydate.Value = Date.Today
            custname.Text = ""
            txt_amount.Text = "0.00"
            txt_adjust.Text = "0.00"
            cmb_type.SelectedIndex = -1
            txt_billno.Enabled = True
            txt_billno.Text = ""
            txt_billno.Focus()
            chequegp.Visible = False
            Btn_save.Enabled = True
            btn_edit.Text = "&EDIT"
            lbl_totamt.Text = "0.00"
            lbl_paidamt.Text = "0.00"
            Label10.Text = "0.00"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub credit_clr()
        Try
            GRID.Visible = False
            grid_salespay.DataSource = ""
            txt_Accname.Text = ""
            txt_Accno.Text = ""
            txt_Chequeno.Text = ""
            cmb_Bankname.SelectedIndex = -1
            txt_billno.Enabled = True
            custname.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_billno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_billno.Text <> "" Then
                    If GRID.Visible = True Then
                        GRID.Focus()
                    Else
                        Call search()
                    End If
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
    Sub search()
        Try
            If txt_billno.Text = "" Then
                MsgBox("Please Enter The BillNo", MsgBoxStyle.Information, )
                txt_billno.Focus()
            Else
                Dim saldt As New DataTable
                saldt = sales_pay_proc(Date.Today, Trim(txt_billno.Text), "", 0, 0, "", "", "", "", "", 0, "", "", "VIEWPAY")
                If saldt.Rows.Count > 0 Then
                    grid_salespay.DataSource = saldt
                    custname.Text = saldt.Rows(0)(6)
                    custname.Enabled = False
                    grid_salespay.Columns(0).Visible = False
                    count()
                    grid_salespay.Focus()
                Else
                    MsgBox("BillNo Not Exists", MsgBoxStyle.Information)
                    txt_billno.Text = ""
                    txt_billno.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub count()
        Try
            Dim tot As Decimal = 0
            Dim paid As Decimal = 0
            For i As Integer = 0 To grid_salespay.RowCount - 1
                tot = tot + grid_salespay.Rows(i).Cells(2).Value
                paid = paid + grid_salespay.Rows(i).Cells(3).Value + grid_salespay.Rows(i).Cells(4).Value
            Next
            lbl_totamt.Text = tot
            lbl_paidamt.Text = paid
            Label10.Text = tot - paid
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_paydate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_paydate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                cmb_type.Focus()
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

    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        Try
            If btn_edit.Text = "&EDIT" Then
                If cmb_type.Text = "CASH" Then
                    chequegp.Visible = False
                    txt_amount.Focus()
                ElseIf cmb_type.SelectedIndex = -1 Then
                    chequegp.Visible = False
                Else
                    If txt_billno.Text = "" Then
                        MsgBox("Please Select The BillNo ")
                        cmb_type.Text = "CASH"
                    Else
                        chequegp.Visible = True
                        txt_Accname.Focus()
                    End If
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Accname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Accname.KeyDown
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

    Private Sub txt_Accno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Accno.KeyDown
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

    Private Sub cmb_Bankname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Bankname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cmb_Bankname.Text <> "" Then
                    chdat.Focus()
                Else
                    cmb_Bankname.Focus()
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

    Private Sub txt_amount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_amount.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_amount.Text <> "0.00" Then
                    txt_adjust.Focus()
                Else
                    txt_amount.Focus()
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

    Private Sub txt_amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function TrapKey(ByVal KCode As String) As Boolean
        Try
            If (KCode >= 48 And KCode <= 57) Or (KCode >= 46 And KCode <= 46) Or KCode = 8 Then
                TrapKey = False

            Else
                TrapKey = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

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
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged
        Try
            If Val(txt_amount.Text) <> "0.00" Then
                Dim ad As Decimal
                ad = Val(Label10.Text)
                bal.Text = Val(ad.ToString)
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

    Private Sub txt_adjust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_adjust.TextChanged
        Try
            If Val(txt_adjust.Text) <> "0.00" Then
                Dim ad As Decimal
                ad = Val(Label10.Text)
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

    Private Sub txt_Chequeno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Chequeno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_Chequeno.Text <> "" Then
                    cmb_Bankname.Focus()
                Else
                    txt_Chequeno.Focus()
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

    Private Sub Btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_save.Click
        Try
            If dtp_paydate.Text = "" Or txt_billno.Text = "" Or cmb_type.Text = "" Or txt_amount.Text = "" Or txt_adjust.Text = "" Or Val(txt_amount.Text) = 0 And Val(txt_adjust.Text) = 0 Then
                MsgBox("please fill the all fields", MsgBoxStyle.Information, "Message")
                dtp_paydate.Focus()
            Else
                Dim sve As DataTable
                sve = sales_pay_proc(dtp_paydate.Value.ToString("MM/dd/yyyy"), Trim(txt_billno.Text), cmb_type.Text, Val(txt_amount.Text), Val(txt_adjust.Text), Trim(cmb_Bankname.Text), Trim(txt_Accname.Text), Trim(txt_Accno.Text), Trim(txt_Chequeno.Text), Trim(custname.Text), Val(bal.Text), "", chdat.Value.ToString("MM/dd/yyyy"), "INSERT")
                If sve.Rows(0)(0) = 1 Then
                    MsgBox("Saved Successfully", MsgBoxStyle.Information, suss)
                    search()
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
    Private Sub txt_billno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billno.TextChanged
        Try
            Dim dt As New DataTable
            If asd = 0 Then
                If txt_billno.Text = "" Then
                    grid_salespay.DataSource = ""
                    txt_billno.Focus()
                Else
                    dt = sales_pay_proc("", txt_billno.Text + "%", "", 0, 0, "", "", "", "", "", 0, "", "", "BILLNO")
                    If dt.Rows.Count <> 0 Then
                        GRID.DataSource = dt
                        GRID.Visible = True
                        GRID.Columns(0).Width = 100
                        GRID.Columns(1).Width = 100
                    End If
                End If
            Else
                GRID.Visible = False
            End If
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

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Try
            Dim response As String
            If btn_edit.Text = "&EDIT" Then
                Dim getdt As New DataTable
                getdt = grid_salespay.DataSource
                If grid_salespay.RowCount <> 0 Then
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        If grid_salespay.CurrentRow.Cells(5).Value.ToString = "CREDIT" Then
                            MsgBox("Can't Be Edit", MsgBoxStyle.Information, suss)
                        ElseIf grid_salespay.CurrentRow.Cells(5).Value = "CHEQUE" Then
                            lbl_paidamt.Text = Val(lbl_paidamt.Text) - (getdt.Rows(grid_salespay.CurrentRow.Index)(3) + getdt.Rows(grid_salespay.CurrentRow.Index)(4))
                            Label10.Text = Format(Val(lbl_totamt.Text) - Val(lbl_paidamt.Text), "0.00")
                            Dim det As New DataTable
                            txt_billno.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(0)
                            btn_edit.Text = "&UPDATE"
                            custname.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(6)
                            Dim aa As String
                            Dim dat As Date
                            aa = getdt.Rows(grid_salespay.CurrentRow.Index)(1)
                            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                            dat = CDate(aa)
                            dtp_paydate.Value = dat
                            cmb_type.Text = "CHEQUE"
                            txt_amount.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(3)
                            txt_adjust.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(4)
                            Dim aa1 As String
                            aa1 = getdt.Rows(grid_salespay.CurrentRow.Index)(1)
                            aa1 = aa1.Substring(6, 4) & "/" & aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2)
                            olddate.Text = aa1
                            Dim details As DataTable
                            details = sales_pay_proc(Trim(olddate.Text), Trim(txt_billno.Text), "", 0, 0, "", "", "", "", "", 0, "", "", "ChequeDetails")
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
                            txt_billno.Enabled = False
                        ElseIf grid_salespay.CurrentRow.Cells(5).Value = "CASH" Then
                            lbl_paidamt.Text = Val(lbl_paidamt.Text) - (getdt.Rows(grid_salespay.CurrentRow.Index)(3) + getdt.Rows(grid_salespay.CurrentRow.Index)(4))
                            Label10.Text = Format(Val(lbl_totamt.Text) - Val(lbl_paidamt.Text), "0.00")
                            Dim det As New DataTable
                            txt_billno.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(0)
                            btn_edit.Text = "&UPDATE"
                            custname.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(6)
                            Dim aa As String
                            Dim dat As Date
                            aa = getdt.Rows(grid_salespay.CurrentRow.Index)(1)
                            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                            dat = CDate(aa)
                            dtp_paydate.Value = dat
                            cmb_type.Text = "CASH"
                            txt_amount.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(3)
                            txt_adjust.Text = getdt.Rows(grid_salespay.CurrentRow.Index)(4)
                            Dim aa1 As String
                            aa1 = getdt.Rows(grid_salespay.CurrentRow.Index)(1)
                            aa1 = aa1.Substring(6, 4) & "/" & aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2)
                            olddate.Text = aa1
                            chequegp.Visible = False
                            Btn_save.Enabled = False
                            txt_billno.Enabled = False
                        End If
                    End If
                End If
            ElseIf btn_edit.Text = "&UPDATE" Then
                If txt_billno.Text = "" Then
                    txt_billno.Focus()
                ElseIf Val(txt_amount.Text) = 0 Then
                    txt_amount.Focus()
                ElseIf dtp_paydate.Text = "" Or txt_billno.Text = "" Or cmb_type.Text = "" Or txt_amount.Text = "" Or txt_adjust.Text = "" Then
                    MsgBox("please fill the all fields", MsgBoxStyle.Information, "Message")
                    dtp_paydate.Focus()
                Else
                    Dim saldt As New DataTable
                    saldt = sales_pay_proc(dtp_paydate.Value.ToString("MM/dd/yyyy"), Trim(txt_billno.Text), cmb_type.Text, Val(txt_amount.Text), Val(txt_adjust.Text), Trim(cmb_Bankname.Text), Trim(txt_Accname.Text), Trim(txt_Accno.Text), Trim(txt_Chequeno.Text), Trim(custname.Text), Val(bal.Text), Trim(olddate.Text), chdat.Value.ToString("MM/dd/yyyy"), "Update")
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
                        dtp_paydate.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRID.DoubleClick
        Try
            txt_billno.Text = GRID.CurrentRow.Cells(0).Value
            txt_billno.Focus()
            GRID.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GRID_DoubleClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billno.Leave
        Try
            If txt_billno.Text <> "" Then
                If GRID.Visible = True Then
                    GRID.Focus()
                Else
                    Call search()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub group_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_browse.Click
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

    Private Sub txt_Accname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Accname.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_Accname.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
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
        e.Handled = True
    End Sub

    Private Sub txt_billno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub custname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles custname.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class