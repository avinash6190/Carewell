Imports System.Data.SqlClient
Public Class payment
    Dim a As New DataTable
    Dim gdt4 As New DataTable
    Dim gdt3 As New DataTable
    Dim gdt2 As New DataTable
    Dim gdt1 As New DataTable
    Dim gdate As DateTime
    Dim a1 As String
    Dim gdt As New DataTable
    Private Sub pay_grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pay_grid1.DoubleClick
        Try
            Dim cnt As New DataTable
            cnt = pay_grid1.DataSource
            If cnt.Rows.Count = 0 Then
            Else
                paymenttype_txt.Text = TextBox2.Text
                loan_date_txt.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(1)
                accno.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(3)
                accname.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(4)
                bank_cbk.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(5)
                id.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(11)
                bank_cbk.Enabled = False
                accno.Enabled = False
                accname.Enabled = False
                Dim a As String
                Dim dat As Date
                a = cnt.Rows(pay_grid1.CurrentRow.Index)(1)
                a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                dat = CDate(a)
                paymentdate_cbk.Value = dat
                a1 = cnt.Rows(pay_grid1.CurrentRow.Index)(8)
                paymentdate_cbk.Focus()
            End If
            Dim s As Integer
            cnt = pay_grid1.DataSource
            s = pay_grid1.CurrentRow.Index
            If cnt.Rows.Count = 0 Then
            Else
                paymenttype_txt.Text = TextBox2.Text
                loan_date_txt.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(1)
                accno.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(3)
                accname.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(4)
                bank_cbk.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(5)
                id.Text = cnt.Rows(pay_grid1.CurrentRow.Index)(11)
                Dim dt As New DataTable
                Dim dat As Date
                Dim aA As String
                aA = cnt.Rows(pay_grid1.CurrentRow.Index)(1)
                aA = aA.Substring(3, 2) & "/" & aA.Substring(0, 2) & "/" & aA.Substring(6, 4)
                dat = CDate(aA)
                If paymenttype_txt.Text = "Bank OD Payment" Then
                    dt = GETODTransaction(Val(id.Text), "")
                ElseIf paymenttype_txt.Text = "Bank Loan Payment" Then
                    dt = GETLOANTransaction(Val(id.Text), "")
                End If
                pay_grid2.DataSource = dt
                pay_grid2.Columns(0).Width = 50
                pay_grid2.Columns(5).Visible = False
                pay_grid2.Columns(6).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_grid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pay_grid2.DoubleClick
        Try
            Dim cnt As New DataTable
            cnt = pay_grid2.DataSource
            Dim cnt1 As New DataTable
            cnt1 = pay_grid1.DataSource
            If cnt.Rows.Count = 0 Then
                MsgBox("No rows Selected")
                paymentdate_cbk.Focus()
            Else
                pay_okbtn.Visible = False
                loan_date_txt.Text = cnt1.Rows(pay_grid1.CurrentRow.Index)(1)
                paymenttype_txt.Text = TextBox2.Text
                payamount_txt.Text = cnt.Rows(pay_grid2.CurrentRow.Index)(2)
                mode.Text = cnt.Rows(pay_grid2.CurrentRow.Index)(3)
                cheqno.Text = cnt.Rows(pay_grid2.CurrentRow.Index)(4)
                paymentdate_cbk.Focus()
                gdate = paymentdate_cbk.Value
                pay_updatebtn.Visible = True
                pay_deletebtn.Visible = True
                bank_cbk.Text = pay_grid1.CurrentRow.Cells(5).Value
                Dim dat As Date
                Dim a As String
                a = cnt.Rows(pay_grid2.CurrentRow.Index)(1)
                a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                dat = CDate(a)
                paymentdate_cbk.Value = dat
                Dim dat1 As Date
                Dim a1 As String
                a1 = cnt.Rows(pay_grid2.CurrentRow.Index)(7)
                a1 = a1.Substring(3, 2) & "/" & a1.Substring(0, 2) & "/" & a1.Substring(6, 4)
                dat1 = CDate(a1)
                chdat.Value = dat1
                paymentdate.Text = cnt.Rows(pay_grid2.CurrentRow.Index)(1)
                id.Text = cnt.Rows(pay_grid2.CurrentRow.Index)(6)
                cid.Text = cnt.Rows(pay_grid2.CurrentRow.Index)(5)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub paymentdate_cbk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles paymentdate_cbk.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If loan_date_txt.Text <> "" Or paymenttype_txt.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = loan_date_txt.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If paymentdate_cbk.Value < dat Then
                        paymentdate_cbk.Value = dat
                    End If
                    mode.Focus()
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub payamount_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles payamount_txt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If mode.Text = "CHEQUE" Then
                    cheqno.Focus()
                Else
                    If pay_okbtn.Visible = True Then
                        pay_okbtn.Focus()
                    Else
                        pay_updatebtn.Focus()
                    End If
                End If
            ElseIf e.KeyCode = Keys.Up Then
                mode.Focus()
            ElseIf e.KeyCode = Keys.Down Then
                cheqno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub payamount_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles payamount_txt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = payamount_txt.Text
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
    Private Sub payamount_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles payamount_txt.TextChanged
        Try
            Dim dt As New DataTable
            If pay_grid1.RowCount <> 0 Then
                dt = pay_grid1.DataSource
                If pay_okbtn.Visible = True Then
                    If dt.Rows.Count > 0 Then
                        If Val(payamount_txt.Text) > Val(dt.Rows(pay_grid1.CurrentRow.Index)(8)) Then
                            MsgBox("Check The Amount", MsgBoxStyle.Critical, "message")
                            payamount_txt.Text = ""
                            payamount_txt.Focus()
                        End If
                    End If
                Else
                    Dim dt2 As New DataTable
                    dt2 = pay_grid2.DataSource
                    Dim amt As Decimal = 0.0
                    For i As Integer = 0 To dt2.Rows.Count - 1
                        If i = pay_grid2.CurrentRow.Index Then
                            amt += dt2.Rows(i)(2)
                        End If
                    Next
                    Dim a As Decimal = pay_grid1.CurrentRow.Cells(8).Value
                    If amt + Val(dt.Rows(pay_grid1.CurrentRow.Index)(8)) < Val(payamount_txt.Text) Then
                        MsgBox("Check The Amount", MsgBoxStyle.Critical, "message")
                        payamount_txt.Text = ""
                        payamount_txt.Focus()
                    End If
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pay_okbtn.Click
        Try
            If pay_grid1.RowCount = 0 Then
                MsgBox("Please Insert Fields")
                paymenttype.Focus()
            Else
                Dim cnt As Integer
                If Trim(loan_date_txt.Text) = "" Or Trim(bank_cbk.Text) = "" Or Trim(accno.Text) = "" Or Trim(accname.Text) = "" Or Trim(paymenttype_txt.Text) = "" Or Trim(payamount_txt.Text) = "" Then
                    MsgBox("Please Fill All Fields", MsgBoxStyle.Information, "message")
                    payamount_txt.Focus()
                Else
                    If paymenttype_txt.Text = "Bank OD Payment" Then
                        Dim dat As Date
                        Dim aa As String
                        aa = loan_date_txt.Text
                        aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                        dat = CDate(aa)
                        cnt = CHECKTRANS(dat, paymentdate_cbk.Value.ToString("MM/dd/yyyy"), 0, "OD", "INSERT")
                        If a1 >= Val(payamount_txt.Text) Then
                            If cnt = 0 Then
                                insertbankODtransp(dat, paymentdate_cbk.Value.ToString("MM/dd/yyyy"), Val(payamount_txt.Text), Trim(bank_cbk.Text), Trim(accno.Text), Trim(accname.Text), Val(id.Text), mode.Text, cheqno.Text, chdat.Value.ToString("MM/dd/yyyy"))
                                MsgBox("Successfully Inserted", MsgBoxStyle.OkOnly, "message")
                                pay_resetbtn_Click(Nothing, Nothing)
                                Call serach()
                                gdt4.Rows.Clear()
                                paymentdate_cbk.Focus()
                                pay_grid2.DataSource = gdt4
                            Else
                                MsgBox("Already Have a transaction On this Day", MsgBoxStyle.Critical, "message")
                                paymentdate_cbk.Focus()
                            End If
                        Else
                            MsgBox("Enter Amount", MsgBoxStyle.Critical, "message")
                            payamount_txt.Focus()
                        End If
                    ElseIf paymenttype_txt.Text = "Bank Loan Payment" Then
                        Dim dat As Date
                        Dim aa As String
                        aa = loan_date_txt.Text
                        aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                        dat = CDate(aa)
                        cnt = CHECKTRANS(dat, paymentdate_cbk.Value.ToString("MM/dd/yyyy"), 0, "OD", "INSERT")
                        If a1 >= Val(payamount_txt.Text) Then
                            If cnt = 0 Then
                                insertbankloantransp(dat, paymentdate_cbk.Value.ToString("MM/dd/yyyy"), Val(payamount_txt.Text), Trim(bank_cbk.Text), Trim(accno.Text), Trim(accname.Text), Val(id.Text), mode.Text, cheqno.Text, chdat.Value.ToString("MM/dd/yyyy"))
                                MsgBox("Successfully Inserted", MsgBoxStyle.OkOnly, "message")
                                pay_resetbtn_Click(Nothing, Nothing)
                                Call serach()
                                gdt4.Rows.Clear()
                                paymentdate_cbk.Focus()
                                pay_grid2.DataSource = gdt4
                            Else
                                MsgBox("Already Have a transaction On this Day", MsgBoxStyle.Critical, "message")
                                paymentdate_cbk.Focus()
                            End If
                            Call payclear()
                        Else
                            MsgBox("Enter Amount", MsgBoxStyle.Critical, "message")
                            payamount_txt.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub payclear()
        Try
            paymenttype_txt.Text = ""
            payamount_txt.Text = "0.00"
            loan_date_txt.Text = ""
            accno.Text = ""
            accname.Text = ""
            mode.SelectedIndex = -1
            paymentdate_cbk.Value = Date.Today
            bank_cbk.Text = ""
            cheqno.Visible = False
            Label4.Visible = False
            lbl.Visible = False
            cheqno.Text = ""
            labl.Visible = False
            Label20.Visible = False
            chdat.Visible = False
            chdat.Value = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_updatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pay_updatebtn.Click
        Try
            Dim cnt As Integer
            If Trim(loan_date_txt.Text) = "" Or Trim(paymenttype_txt.Text) = "" Or Trim(payamount_txt.Text) = "" Then
                MsgBox("Please Fill All Fields", MsgBoxStyle.Information, "message")
                payamount_txt.Focus()
            Else
                If paymenttype_txt.Text = "Bank OD Payment" Then
                    Dim dat As Date
                    Dim aa As String
                    aa = loan_date_txt.Text
                    aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                    dat = CDate(aa)
                    cnt = CHECKTRANS(dat, paymentdate_cbk.Value.ToString("MM/dd/yyyy"), Val(id.Text), "OD", "UPDATE")
                    If cnt = 0 Or gdate.ToString("MM/dd/yyyy") = paymentdate_cbk.Value.ToString("MM/dd/yyyy") Then
                        updatebankODtrans(paymentdate_cbk.Value.ToString("MM/dd/yyyy"), Val(payamount_txt.Text), Val(cid.Text), Val(id.Text), mode.Text, cheqno.Text, chdat.Value.ToString("MM/dd/yyyy"))
                        MsgBox("Updated successfully", MsgBoxStyle.Information, "message")
                        pay_resetbtn_Click(Nothing, Nothing)
                        gdt4.Rows.Clear()
                        paymentdate_cbk.Focus()
                        pay_grid2.DataSource = gdt4
                    Else
                        MsgBox("Already Have a transaction On this Day", MsgBoxStyle.Critical, "message")
                        paymentdate_cbk.Focus()
                    End If
                    paymentdate_cbk.Value = Date.Today
                    pay_okbtn.Visible = True
                    pay_updatebtn.Visible = False
                    pay_deletebtn.Visible = False
                    paymenttype.Focus()
                ElseIf paymenttype_txt.Text = "Bank Loan Payment" Then
                    Dim dat As Date
                    Dim aa As String
                    aa = loan_date_txt.Text
                    aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                    dat = CDate(aa)
                    cnt = CHECKTRANS(dat, paymentdate_cbk.Value.ToString("MM/dd/yyyy"), Val(id.Text), "loan", "UPDATE")
                    If cnt = 0 Or gdate.ToString("MM/dd/yyyy") = paymentdate_cbk.Value.ToString("MM/dd/yyyy") Then
                        updatebankloantrans(paymentdate_cbk.Value.ToString("MM/dd/yyyy"), Val(payamount_txt.Text), Val(cid.Text), Val(id.Text), mode.Text, cheqno.Text, chdat.Value.ToString("MM/dd/yyyy"))
                        MsgBox("Updated successfully", MsgBoxStyle.Information, "message")
                        pay_resetbtn_Click(Nothing, Nothing)
                        gdt4.Rows.Clear()
                        paymentdate_cbk.Focus()
                        pay_grid2.DataSource = gdt4
                    Else

                        MsgBox("Already Have a transaction On this Day", MsgBoxStyle.Critical, "message")
                        paymentdate_cbk.Focus()
                    End If
                    paymentdate_cbk.Value = Date.Today
                    pay_okbtn.Visible = True
                    pay_updatebtn.Visible = False
                    pay_deletebtn.Visible = False
                    paymenttype.Focus()
                End If
            End If
            Call payclear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub paygetdetails()
        Try
            Dim dt1 As New DataTable
            pay_grid1.DataSource = dt1
            paymenttype.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pay_editbtn.Click
        Try
            Dim i As Integer
            Dim cntdt As New DataTable
            Dim response As String
            cntdt = pay_grid1.DataSource
            If cntdt.Rows.Count <= 0 Then
                MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                paymenttype.Focus()
            Else
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                If (response = vbYes) Then
                    pay_okbtn.Visible = False
                    pay_updatebtn.Visible = True
                    pay_editbtn.Visible = False
                    Dim getdt As New DataTable
                    getdt = pay_grid1.DataSource
                    i = pay_grid1.CurrentRow.Index
                    Dim dat As Date
                    Dim a As String
                    a = getdt.Rows(i)(1)
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    TextBox1.Text = ""
                    TextBox3.Text = ""
                    paymenttype_txt.Text = paymenttype.Text
                    loan_date_txt.Text = a
                    TextBox1.Text = getdt.Rows(i)(2)
                    TextBox3.Text = a
                    bank_cbk.Text = getdt.Rows(i)(3)
                    payamount_txt.Text = getdt.Rows(i)(4)
                    payamount_txt.Focus()
                Else
                    payamount_txt.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pay_deletebtn.Click
        Try
            Dim dg As DialogResult
            dg = MsgBox("Are You Sure", MsgBoxStyle.YesNo)
            If dg = Windows.Forms.DialogResult.Yes Then

                Dim aa As String
                Dim dat As Date
                aa = loan_date_txt.Text
                aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                dat = CDate(aa)
                deletebanktrans(Val(cid.Text), Val(id.Text), paymenttype.SelectedItem, accno.Text)
                MsgBox("deleted sucessfully")
                pay_grid1_DoubleClick(Nothing, Nothing)
                pay_resetbtn_Click(Nothing, Nothing)
                pay_deletebtn.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_resetbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Call payclear()
            serach()
            pay_okbtn.Visible = True
            pay_updatebtn.Visible = False
            pay_deletebtn.Visible = False
            paymenttype.Focus()
            paymentdate_cbk.Value = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub serach()
        Try
            Dim dt1 As New DataTable
            If paymenttype.Text = "Bank OD Payment" Then
                dt1 = bankodview()
                TextBox2.Text = "Bank OD Payment"
            ElseIf paymenttype.Text = "Bank Loan Payment" Then
                dt1 = bankloanview()
                TextBox2.Text = "Bank Loan Payment"
            End If
            For i As Integer = 0 To dt1.Rows.Count - 1
                TextBox7.Text = dt1.Rows(i)(8)
            Next
            pay_grid1.DataSource = dt1
            pay_grid1.Columns(0).Width = 50
            pay_grid1.Columns(11).Visible = False
            paymentdate_cbk.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub payment_okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            serach()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub paymenttype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles paymenttype.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If paymenttype.Text <> "" Then
                    paymentdate_cbk.Focus()
                Else
                    paymenttype.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub paymenttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paymenttype.SelectedIndexChanged
        Try
            Dim dt3 As New DataTable
            pay_grid2.DataSource = dt3
            pay_grid1.DataSource = dt3
            payment_okbtn_Click(Nothing, Nothing)
            paymenttype.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            payment_okbtn_Click(Nothing, Nothing)
            paymenttype.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub payment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt7 As New DataTable
            dt7 = viewbank()
            Dim dr As DataRow
            bank_cbk.Items.Clear()
            For Each dr In dt7.Rows()
                bank_cbk.Items.Add(dr("bankname"))
            Next
            paymentdate_cbk.Value = Date.Today
            lbl.Visible = False
            Label4.Visible = False
            cheqno.Visible = False
            chdat.Value = Date.Today
            paymenttype.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_updatebtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pay_updatebtn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            ElseIf e.KeyCode = Keys.Left Then
                payamount_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_okbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pay_okbtn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            ElseIf e.KeyCode = Keys.Left Then
                payamount_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_deletebtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pay_deletebtn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pay_resetbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pay_exitbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub date_txt1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles date_txt1.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pay_grid1.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pay_grid2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pay_grid2.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub payment_okbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.SelectedIndexChanged
        Try
            If mode.SelectedItem = "CASH" Then
                cheqno.Visible = False
                Label4.Visible = False
                lbl.Visible = False
                cheqno.Text = ""
                labl.Visible = False
                Label20.Visible = False
                chdat.Visible = False
                chdat.Value = Date.Today
            ElseIf mode.SelectedItem = "CHEQUE" Then
                cheqno.Visible = True
                Label4.Visible = True
                lbl.Visible = True
                cheqno.Text = ""
                labl.Visible = True
                Label20.Visible = True
                chdat.Visible = True
                chdat.Value = Date.Today
            Else
                cheqno.Visible = False
                Label4.Visible = False
                lbl.Visible = False
                cheqno.Text = ""
                labl.Visible = False
                Label20.Visible = False
                chdat.Visible = False
                chdat.Value = Date.Today
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                payamount_txt.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cheqno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cheqno.KeyDown
        Try
            If e.KeyCode = Keys.Up Then
                payamount_txt.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                chdat.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chdat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chdat.KeyDown
        Try
            If e.KeyCode = Keys.Up Then
                cheqno.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                If paymentdate_cbk.Text <> "" Or chdat.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = paymentdate_cbk.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If chdat.Value < dat Then
                        MsgBox("Check Date Must Be Greater Than Entry Date", MsgBoxStyle.Information, suss)
                        chdat.Value = dat
                        chdat.Focus()
                    Else
                        If pay_okbtn.Visible = True Then
                            pay_okbtn.Focus()
                        Else
                            pay_updatebtn.Focus()
                        End If
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    pay_resetbtn_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cheqno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cheqno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bank_cbk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bank_cbk.KeyPress
        e.Handled = True
    End Sub
End Class