Imports System.Data.SqlClient
Public Class BankLoan
    Sub getdetails1()
        Try
            Dim dt As New DataTable
            dt = bankodview()
            loan_grid.DataSource = dt
            loan_grid.Columns(0).Width = 50
            loan_grid.Columns(11).Visible = False
            loan_grid.Columns(8).Visible = False
            loandate_cbk.Value = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub getdetails()
        Try
            Dim dt As New DataTable
            dt = bankloanview()
            loan_grid.DataSource = dt
            loan_grid.Columns(0).Width = 50
            loan_grid.Columns(11).Visible = False
            loan_grid.Columns(8).Visible = False
            loandate_cbk.Value = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        Try
            loantype_txt.Enabled = False
            accno.Text = ""
            accname.Text = ""
            bankname_cbk.Text = ""
            loanamount_txt.Text = ""
            chequeno.Text = ""
            loan_okbtn.Visible = True
            loanamount_txt.Text = ""
            loandate_cbk.Value = Date.Today
            loan_editbtn.Text = "&EDIT"
            loan_deletebtn.Visible = True
            chequeno.Visible = False
            Label8.Visible = False
            Label18.Visible = False
            chdat.Visible = False
            labl.Visible = False
            Label20.Visible = False
            mode.SelectedIndex = -1
            ComboBox1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loan_okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_okbtn.Click
        Try
            If (loantype_txt.Text) = "Bankloan" Then
                If Trim(mode.Text) = "CASH" Then
                    If Trim(loandate_cbk.Text) = "" Or Trim(loantype_txt.Text) = "" Or Trim(accno.Text) = "" Or Trim(accname.Text) = "" Or Trim(bankname_cbk.Text) = "" Or Trim(mode.Text) = "" Or Trim(loanamount_txt.Text) = "" Then
                        MsgBox("please fill the fields", MsgBoxStyle.Information)
                    Else
                        Dim bankdt As New DataTable
                        Dim dt As New DataTable
                        dt = Existbankloan(loandate_cbk.Value.ToString("MM/dd/yyyy"), accno.Text, 0, "INSERT")
                        If dt.Rows(0)(0) = 1 Then
                            MsgBox("Already u have inserted your values...", MsgBoxStyle.Information, "message")
                            loandate_cbk.Focus()
                        Else
                            insertbankloan(loandate_cbk.Value.ToString("MM/dd/yyyy"), loantype_txt.Text, Trim(accno.Text), Trim(accname.Text), bankname_cbk.Text, mode.Text, loanamount_txt.Text, Trim(chequeno.Text), Date.Today.ToString("MM/dd/yyyy"), "")
                            MsgBox("Saved successfully", MsgBoxStyle.Information)
                            Call clear()
                        End If
                        getdetails()
                        loanamount_txt.Text = ""
                        loan_resetbtn_Click(Nothing, Nothing)
                    End If
                ElseIf Trim(mode.Text) = "CHEQUE" Then
                    If Trim(loandate_cbk.Text) = "" Or Trim(loantype_txt.Text) = "" Or Trim(accno.Text) = "" Or Trim(accname.Text) = "" Or Trim(bankname_cbk.Text) = "" Or Trim(mode.Text) = "" Or Trim(loanamount_txt.Text) = "" Or Trim(chequeno.Text) = "" Then
                        MsgBox("please fill the fields", MsgBoxStyle.Information)
                    Else
                        Dim bankdt As New DataTable
                        Dim dt As New DataTable
                        dt = Existbankloan(loandate_cbk.Value.ToString("MM/dd/yyyy"), accno.Text, 0, "INSERT")
                        If dt.Rows(0)(0) = 1 Then
                            MsgBox("Already u have inserted your values...", MsgBoxStyle.Information, "message")
                            loandate_cbk.Focus()
                        Else
                            insertbankloan(loandate_cbk.Value.ToString("MM/dd/yyyy"), loantype_txt.Text, Trim(accno.Text), Trim(accname.Text), bankname_cbk.Text, mode.Text, loanamount_txt.Text, Trim(chequeno.Text), Trim(chdat.Value.ToString("MM/dd/yyyy")), "")
                            MsgBox("Saved successfully", MsgBoxStyle.Information)
                            Call clear()
                        End If
                        getdetails()
                        loan_resetbtn_Click(Nothing, Nothing)
                    End If
                End If
            Else
                If Trim(mode.Text) = "CASH" Then
                    If Trim(loandate_cbk.Text) = "" Or Trim(loantype_txt.Text) = "" Or Trim(accno.Text) = "" Or Trim(accname.Text) = "" Or Trim(bankname_cbk.Text) = "" Or Trim(mode.Text) = "" Or Trim(loanamount_txt.Text) = "" Then
                        MsgBox("please fill the fields", MsgBoxStyle.Information)
                    Else
                        Dim bankdt As New DataTable
                        Dim dt As New DataTable
                        dt = ExistbankOD(loandate_cbk.Value.ToString("MM/dd/yyyy"), accno.Text, 0, "INSERT")
                        If dt.Rows(0)(0) = 1 Then
                            MsgBox("Already u have inserted your values...", MsgBoxStyle.Information, "message")
                            loandate_cbk.Focus()
                        Else
                            insertbankod(loandate_cbk.Value.ToString("MM/dd/yyyy"), loantype_txt.Text, Trim(accno.Text), accname.Text, bankname_cbk.Text, mode.Text, loanamount_txt.Text, chequeno.Text, Date.Today.ToString("MM/dd/yyyy"))
                            MsgBox("Saved successfully", MsgBoxStyle.Information)
                            Call clear()
                        End If
                        getdetails1()
                        loan_resetbtn_Click(Nothing, Nothing)
                    End If
                ElseIf Trim(mode.Text) = "CHEQUE" Then
                    If Trim(loandate_cbk.Text) = "" Or Trim(loantype_txt.Text) = "" Or Trim(accno.Text) = "" Or Trim(accname.Text) = "" Or Trim(bankname_cbk.Text) = "" Or Trim(mode.Text) = "" Or Trim(loanamount_txt.Text) = "" Or Trim(chequeno.Text) = "" Then
                        MsgBox("please fill the fields", MsgBoxStyle.Information)
                    Else
                        Dim bankdt As New DataTable
                        Dim dt As New DataTable
                        dt = ExistbankOD(loandate_cbk.Value.ToString("MM/dd/yyyy"), accno.Text, 0, "INSERT")
                        If dt.Rows(0)(0) = 1 Then
                            MsgBox("Already u have inserted your values...", MsgBoxStyle.Information, "message")
                            loandate_cbk.Focus()
                        Else
                            insertbankod(loandate_cbk.Value.ToString("MM/dd/yyyy"), loantype_txt.Text, Trim(accno.Text), accname.Text, bankname_cbk.Text, mode.Text, loanamount_txt.Text, chequeno.Text, Trim(chdat.Value.ToString("MM/dd/yyyy")))
                            MsgBox("Saved successfully", MsgBoxStyle.Information)
                            Call clear()
                        End If
                        getdetails1()
                        loan_resetbtn_Click(Nothing, Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loan_resetbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loan_editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_editbtn.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = loan_grid.DataSource
            If (ComboBox1.Text) = "Bankloan" Then
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                    loandate_cbk.Focus()
                Else
                    i = loan_grid.CurrentRow.Index
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        If loan_editbtn.Text = "&UPDATE" Then
                            If Trim(loanamount_txt.Text) = "" Then
                                MsgBox("Please Enter Amount", MsgBoxStyle.Information, "message")
                                loanamount_txt.Focus()
                            Else
                                Dim dt As New DataTable
                                dt = Existbankloan(loandate_cbk.Value.ToString("MM/dd/yyyy"), accno.Text, TextBox2.Text, "UPDATE")
                                If dt.Rows(0)(0) <> 0 Then
                                    MsgBox("Already u have inserted For this Date....", MsgBoxStyle.Information, "message")
                                    loandate_cbk.Focus()
                                Else
                                    Dim dd As New DataTable
                                    dd = updatebankloan1(TextBox2.Text, loandate_cbk.Value.ToString("MM/dd/yyyy"), Trim(loantype_txt.Text), Trim(accno.Text), accname.Text, bankname_cbk.Text, mode.Text, loanamount_txt.Text, chequeno.Text, chdat.Value.ToString("MM/dd/yyyy"))
                                    If dd.Rows(0)(0) = 1 Then
                                        loan_editbtn.Text = "&EDIT"
                                        MsgBox("Updated Successfully", MsgBoxStyle.Information, "message")
                                        Call getdetails()
                                        clear()
                                        loan_okbtn.Visible = True
                                        loan_deletebtn.Visible = True
                                        loanamount_txt.Text = ""
                                        loan_editbtn.Text = "&EDIT"
                                        loanamount_txt.Focus()
                                        loandate_cbk.Value = Date.Today
                                        chdat.Value = Date.Today
                                    Else
                                        loan_editbtn.Text = "&EDIT"
                                        MsgBox("Cannot Be Updated", MsgBoxStyle.Information, "message")
                                        Call getdetails()
                                        clear()
                                        loan_okbtn.Visible = True
                                        loan_deletebtn.Visible = True
                                        loanamount_txt.Text = ""
                                        loan_editbtn.Text = "&EDIT"
                                        loanamount_txt.Focus()
                                        loandate_cbk.Value = Date.Today
                                        chdat.Value = Date.Today
                                    End If
                                End If
                            End If
                        ElseIf cntdt.Rows(i)(7) = cntdt.Rows(i)(8) Then
                            Dim getdt As New DataTable
                            getdt = loan_grid.DataSource
                            i = loan_grid.CurrentRow.Index
                            Dim dat As Date
                            Dim a As String
                            a = getdt.Rows(i)(1)
                            a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                            dat = CDate(a)
                            loandate_cbk.Value = dat
                            TextBox1.Text = getdt.Rows(i)(7)
                            TextBox2.Text = getdt.Rows(loan_grid.CurrentRow.Index)(11)
                            loanamount_txt.Text = getdt.Rows(loan_grid.CurrentRow.Index)(7)
                            loantype_txt.Text = getdt.Rows(loan_grid.CurrentRow.Index)(2)
                            mode.Text = getdt.Rows(loan_grid.CurrentRow.Index)(6)
                            chequeno.Text = getdt.Rows(loan_grid.CurrentRow.Index)(9)
                            accno.Text = getdt.Rows(loan_grid.CurrentRow.Index)(3)
                            accname.Text = getdt.Rows(loan_grid.CurrentRow.Index)(4)
                            bankname_cbk.Text = getdt.Rows(loan_grid.CurrentRow.Index)(5)
                            accname.Enabled = False
                            bankname_cbk.Enabled = False
                            loan_editbtn.Text = "&UPDATE"
                            loan_okbtn.Visible = False
                            loan_deletebtn.Visible = False
                            GRID.Visible = False
                            Dim dat1 As Date
                            Dim a1 As String
                            a1 = getdt.Rows(i)(10)
                            a1 = a1.Substring(3, 2) & "/" & a1.Substring(0, 2) & "/" & a1.Substring(6, 4)
                            dat1 = CDate(a1)
                            chdat.Value = dat1
                            loandate_cbk.Focus()
                        Else
                            MsgBox("Sorry!Cant To Edit", MsgBoxStyle.Critical, "message")
                            bankname_cbk.Focus()
                        End If
                    End If
                End If
            ElseIf (ComboBox1.Text) = "Bankod" Then
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                    loandate_cbk.Focus()
                Else
                    i = loan_grid.CurrentRow.Index
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        If loan_editbtn.Text = "&UPDATE" Then
                            If Trim(loanamount_txt.Text) = "" Then
                                MsgBox("Please Enter Amount", MsgBoxStyle.Information, "message")
                                loanamount_txt.Focus()
                            Else
                                loan_editbtn.Text = "&EDIT"
                                Dim dt As New DataTable
                                dt = ExistbankOD(loandate_cbk.Value.ToString("MM/dd/yyyy"), accno.Text, TextBox2.Text, "UPDATE")
                                If dt.Rows(0)(0) <> 0 Then
                                    MsgBox("Already u have inserted for this date.....", MsgBoxStyle.Information, "message")
                                    loandate_cbk.Focus()
                                Else
                                    Dim dd As New DataTable
                                    dd = updatebankod1(TextBox2.Text, loandate_cbk.Value.ToString("MM/dd/yyyy"), Trim(loantype_txt.Text), Trim(accno.Text), accname.Text, bankname_cbk.Text, mode.Text, loanamount_txt.Text, chequeno.Text, chdat.Value.ToString("MM/dd/yyyy"))
                                    If dd.Rows(0)(0) = 1 Then
                                        loan_editbtn.Text = "&EDIT"
                                        MsgBox("Updated Successfully", MsgBoxStyle.Information, "message")
                                        Call getdetails1()
                                        clear()
                                        loan_okbtn.Visible = True
                                        loan_deletebtn.Visible = True
                                        loanamount_txt.Text = ""
                                        loan_editbtn.Text = "&EDIT"
                                        loanamount_txt.Focus()
                                        loandate_cbk.Value = Date.Today
                                        chdat.Value = Date.Today
                                    Else
                                        loan_editbtn.Text = "&EDIT"
                                        MsgBox("Cannot Be Updated", MsgBoxStyle.Information, "message")
                                        Call getdetails()
                                        clear()
                                        loan_okbtn.Visible = True
                                        loan_deletebtn.Visible = True
                                        loanamount_txt.Text = ""
                                        loan_editbtn.Text = "&EDIT"
                                        loanamount_txt.Focus()
                                        loandate_cbk.Value = Date.Today
                                        chdat.Value = Date.Today
                                    End If
                                End If
                            End If
                        ElseIf cntdt.Rows(i)(7) = cntdt.Rows(i)(8) Then
                            Dim getdt As New DataTable
                            getdt = loan_grid.DataSource
                            i = loan_grid.CurrentRow.Index
                            Dim dat As Date
                            Dim a As String
                            a = getdt.Rows(i)(1)
                            a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                            dat = CDate(a)
                            loandate_cbk.Value = dat
                            TextBox1.Text = getdt.Rows(i)(7)
                            loanamount_txt.Text = getdt.Rows(loan_grid.CurrentRow.Index)(7)
                            loantype_txt.Text = getdt.Rows(loan_grid.CurrentRow.Index)(2)
                            mode.Text = getdt.Rows(loan_grid.CurrentRow.Index)(6)
                            chequeno.Text = getdt.Rows(loan_grid.CurrentRow.Index)(9)
                            accno.Text = getdt.Rows(loan_grid.CurrentRow.Index)(3)
                            TextBox2.Text = getdt.Rows(loan_grid.CurrentRow.Index)(11)
                            accname.Text = getdt.Rows(loan_grid.CurrentRow.Index)(4)
                            bankname_cbk.Text = getdt.Rows(loan_grid.CurrentRow.Index)(5)
                            loan_editbtn.Text = "&UPDATE"
                            accname.Enabled = False
                            bankname_cbk.Enabled = False
                            loan_okbtn.Visible = False
                            loan_deletebtn.Visible = False
                            GRID.Visible = False
                            Dim dat1 As Date
                            Dim a1 As String
                            a1 = getdt.Rows(i)(10)
                            a1 = a1.Substring(3, 2) & "/" & a1.Substring(0, 2) & "/" & a1.Substring(6, 4)
                            dat1 = CDate(a1)
                            chdat.Value = dat1
                            loandate_cbk.Focus()
                        Else
                            MsgBox("Sorry!Cant To Edit", MsgBoxStyle.Critical, "message")
                            bankname_cbk.Focus()
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loan_deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_deletebtn.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = loan_grid.DataSource
            If ComboBox1.Text = "Bankloan" Then
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                    ComboBox1.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = loan_grid.DataSource
                        i = loan_grid.CurrentRow.Index
                        If getdt.Rows(i)(7) = getdt.Rows(i)(8) Then
                            TextBox1.Text = getdt.Rows(i)(7)
                            TextBox2.Text = getdt.Rows(loan_grid.CurrentRow.Index)(11)
                            updatebankloan(Val(TextBox2.Text), Val(TextBox1.Text), getdt.Rows(loan_grid.CurrentRow.Index)(5))
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                            MsgBox("Deleted Successfully", MsgBoxStyle.Information, "message")
                            ComboBox1.Focus()
                        Else
                            MsgBox("Sorry U Cant Deleted", MsgBoxStyle.Information, "message")
                            ComboBox1.Focus()
                        End If
                        getdetails()
                    End If
                End If
            Else
                If ComboBox1.Text = "Bankod" Then

                    If cntdt.Rows.Count <= 0 Then
                        MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                        ComboBox1.Focus()
                    Else
                        response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                        If (response = vbYes) Then
                            Dim getdt As New DataTable
                            getdt = loan_grid.DataSource
                            i = loan_grid.CurrentRow.Index
                            If getdt.Rows(i)(7) = getdt.Rows(i)(8) Then
                                TextBox1.Text = getdt.Rows(i)(7)
                                TextBox2.Text = getdt.Rows(loan_grid.CurrentRow.Index)(11)
                                updatebankOD(Val(TextBox2.Text), Val(TextBox1.Text), getdt.Rows(loan_grid.CurrentRow.Index)(5))
                                TextBox1.Text = ""
                                TextBox2.Text = ""
                                MsgBox("Deleted Successfully", MsgBoxStyle.Information, "message")
                                ComboBox1.Focus()
                            Else
                                MsgBox("Sorry U Cant Deleted", MsgBoxStyle.Information, "message")
                                ComboBox1.Focus()
                            End If
                            getdetails1()
                        End If
                    End If


                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BankLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clear()
            chequeno.Visible = False
            Label8.Visible = False
            Label18.Visible = False
            chdat.Value = Date.Today
            loandate_cbk.Value = Date.Today
            ComboBox1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loanamount_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles loanamount_txt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If mode.Text = "CHEQUE" Then
                    chequeno.Focus()
                Else
                    loan_okbtn.Focus()
                End If
            Else
                If e.KeyCode = Keys.Up Then
                    mode.Focus()
                ElseIf e.KeyCode = Keys.Down Then
                    chequeno.Focus()
                ElseIf e.KeyCode = Keys.Escape Then
                    Dim response As String
                    response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                    If vbYes = response Then
                        clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loanamount_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loanamount_txt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = loanamount_txt.Text
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
    Private Sub loan_exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.SelectedItem = "Bankloan" Then
                loantype_txt.Text = "Bankloan"
                Call getdetails()
                ComboBox1.Focus()
            ElseIf ComboBox1.SelectedItem = "Bankod" Then
                loantype_txt.Text = "Bankod"
                Call getdetails1()
                ComboBox1.Focus()
            Else
                loan_grid.DataSource = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub accno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles accno.KeyDown
        Try
            Dim dt As New DataTable
            If e.KeyCode = Keys.Enter Then
                If GRID.Visible = True Then
                    GRID.Focus()
                Else
                    dt = accountnosearch(accno.Text, "", "")
                    If accno.Text = dt.Rows(0)(2) Then
                        accname.Text = dt.Rows(0)(0)
                        bankname_cbk.Text = dt.Rows(0)(1)
                        accname.Enabled = False
                        bankname_cbk.Enabled = False
                        mode.Focus()
                    Else
                        accname.Focus()
                        accname.Text = ""
                        bankname_cbk.Text = ""
                        accname.Enabled = False
                        bankname_cbk.Enabled = False
                        MsgBox("This account number is not created,please created the account no", MsgBoxStyle.Information)
                    End If
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                loanamount_txt.Focus()
            Else
                If e.KeyCode = Keys.Up Then
                    bankname_cbk.Focus()
                ElseIf e.KeyCode = Keys.Down Then
                    loanamount_txt.Focus()
                ElseIf e.KeyCode = Keys.Escape Then
                    Dim response As String
                    response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                    If vbYes = response Then
                        clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.SelectedIndexChanged
        Try
            If mode.SelectedItem = "CASH" Then
                chequeno.Visible = False
                Label8.Visible = False
                Label18.Visible = False
                labl.Visible = False
                Label20.Visible = False
                chdat.Visible = False
                chequeno.Text = ""
                chdat.Value = Date.Today
            Else
                If mode.SelectedItem = "CHEQUE" Then
                    chequeno.Visible = True
                    Label8.Visible = True
                    Label18.Visible = True
                    labl.Visible = True
                    Label20.Visible = True
                    chdat.Visible = True
                    chequeno.Text = ""
                    chdat.Value = Date.Today
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub accno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accno.TextChanged
        Try
            If accno.Text = "" Then
                accname.Text = ""
                accname.Enabled = True
                bankname_cbk.Text = ""
                bankname_cbk.Enabled = True
                GRID.Visible = False
            Else
                Dim acc As New DataTable
                acc = account_procedure("", "", "", accno.Text + "%", "VIEW2", "", "", 0)
                If acc.Rows.Count <> 0 Then
                    GRID.DataSource = acc
                    GRID.Columns(0).Width = 150
                    GRID.Visible = True
                Else
                    accno.Text = ""
                    accno.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chequeno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chequeno.KeyDown
        Try
            If e.KeyCode = Keys.Up Then
                loanamount_txt.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                chdat.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bankname_cbk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                mode.Focus()
            ElseIf e.KeyCode = Keys.Down Then
                mode.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loan_editbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles loan_editbtn.KeyDown
        Try
            If e.KeyCode = Keys.Right Then
                loan_deletebtn.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                loan_okbtn.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loan_okbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles loan_okbtn.KeyDown
        Try
            If e.KeyCode = Keys.Right Then
                loan_editbtn.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID.DoubleClick
        Try
            accno.Text = GRID.CurrentRow.Cells(0).Value
            accno.Focus()
            GRID.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GRID_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If ComboBox1.Text <> "" Then
                    loandate_cbk.Focus()
                Else
                    ComboBox1.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loandate_cbk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles loandate_cbk.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                accno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub accname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles accname.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bankname_cbk_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bankname_cbk.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loan_deletebtn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles loan_deletebtn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub group_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_browse.Click
        Try
            Dim a As New AccountCreation1
            a.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chdat_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chdat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If loandate_cbk.Text <> "" Or chdat.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = loandate_cbk.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If chdat.Value < dat Then
                        MsgBox("Check Date Must Be Greater Than Entry Date", MsgBoxStyle.Information, suss)
                        chdat.Value = dat
                        chdat.Focus()
                    Else
                        If loan_okbtn.Visible = True Then
                            loan_okbtn.Focus()
                        Else
                            loan_editbtn.Focus()
                        End If
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chequeno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chequeno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
