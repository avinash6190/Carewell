Imports System.Data.SqlClient
Public Class WithDraw2
    Dim dat As Date
    Private Sub bank_addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_addbtn.Click
        Try
            Dim dt As New DataTable
            If acctname.Text = "" Or no.Text = "" Or bankname.Text = "" Or ComboBox1.Text = "" Or amt.Text = "0.00" Or amt.Text = "" Or amt.Text = "0" Or Date1.Text = "" Then
                MsgBox("Please Enter The Fields", MsgBoxStyle.Information, "message")
                acctname.Focus()
            Else
                dt = withdraw_PROC(Date1.Value.ToString("MM/dd/yyyy"), acctname.Text, no.Text, amt.Text, bankname.Text, ComboBox1.Text, "", Trim(checkno.Text), chdat.Value.ToString("MM/dd/yyyy"), "insert")
                If dt.Rows(0)(0) = 1 Then
                    Call view1()
                    cancel()
                Else
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cancel()
        Try
            acctname.Text = ""
            no.Text = ""
            bankname.Text = ""
            amt.Text = "0.00"
            Date1.Text = Today.Date
            acctname.Enabled = True
            bankname.Enabled = True
            bank_edit.Text = "EDIT"
            bank_addbtn.Enabled = True
            l1.Visible = False
            l2.Visible = False
            labl.Visible = False
            Label20.Visible = False
            chdat.Visible = False
            chdat.Value = Date.Today
            checkno.Visible = False
            checkno.Text = ""
            checkno.Visible = False
            ComboBox1.Text = ""
            Date1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub view1()
        Try
            Dim dt As New DataTable
            dt.Rows.Clear()
            dt = withdraw_PROC("", "", "", 0, "", "", "", "", "", "VIEW")
            Deposit_grid.DataSource = dt
            Deposit_grid.Columns(0).Visible = False
            Deposit_grid.Columns(1).Width = 100
            Deposit_grid.Columns(2).Width = 150
            Deposit_grid.Columns(3).Width = 150
            Deposit_grid.Columns(4).Width = 100
            Deposit_grid.Columns(5).Width = 150
            Deposit_grid.Columns(6).Width = 150
            Deposit_grid.Columns(7).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub WithDraw2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call view1()
            Dim dt7 As New DataTable
            dt7 = viewbank()
            Dim dr As DataRow
            bankname.Items.Clear()
            For Each dr In dt7.Rows()
                bankname.Items.Add(dr("bankname"))
            Next
            Date1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bank_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_edit.Click
        Try
            Dim response As String
            Dim a As String
            Dim b As String

            Dim dt1 As New DataTable
            If bank_edit.Text = "UPDATE" Then
                If acctname.Text = "" Or no.Text = "" Or bankname.Text = "" Or ComboBox1.Text = "" Or amt.Text = "0.00" Or amt.Text = "0" Or amt.Text = "" Or Date1.Text = "" Then
                    MsgBox("Please Enter The Fields", MsgBoxStyle.Information, "message")
                    acctname.Focus()
                Else
                    dt1 = withdraw_PROC(Date1.Value.ToString("MM/dd/yyyy"), acctname.Text, no.Text, amt.Text, bankname.Text, ComboBox1.Text, no1.Text, checkno.Text, chdat.Value.ToString("MM/dd/yyyy"), "update")
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    Call cancel()
                    Call view1()
                End If
            Else

                Dim getdt As New DataTable
                getdt = Deposit_grid.DataSource
                If getdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        Dim aa As String
                        aa = getdt.Rows(Deposit_grid.CurrentRow.Index)(1)
                        aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                        dat = CDate(aa)
                        Date1.Text = dat
                        no1.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(0)
                        acctname.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(3)
                        bankname.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(4)
                        checkno.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(7)
                        Dim aa1 As String
                        Dim dat1 As Date
                        aa1 = getdt.Rows(Deposit_grid.CurrentRow.Index)(8)
                        aa1 = aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2) & "/" & aa1.Substring(6, 4)
                        dat1 = CDate(aa1)
                        chdat.Value = dat1
                        amt.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(5)
                        no.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(2)
                        ComboBox1.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(6)
                        bank_addbtn.Enabled = False
                        bank_edit.Text = "UPDATE"
                        GRID.Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub amt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles amt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim dt As New DataTable
                dt = withdraw_PROC("", "", Trim(no.Text), 0, "", "", "", "", "", "amtcheck")
                If Val(amt.Text) <= Val(dt.Rows(0)(0).ToString) Then
                    If ComboBox1.Text = "Cheque" Then
                        checkno.Focus()
                    Else
                        bank_addbtn.Focus()
                    End If
                Else
                    MsgBox("Insuficient Balancce In This Account", MsgBoxStyle.YesNo, suss)
                    amt.Text = "0.00"
                    amt.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub amt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles amt.KeyPress
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
    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        Try
            Dim rep As String
            rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
            If rep = vbYes Then
                Dim cnt As New DataTable
                cnt = Deposit_grid.DataSource
                If Deposit_grid.RowCount = 0 Then
                    MsgBox("No data Found", MsgBoxStyle.Information)
                Else
                    Dim ds As New withdraw
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("Deposit").Rows.Add(cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(5), cnt.Rows(i)(4), "", cnt.Rows(i)(1))
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New withdraw1
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bankname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then

            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub branch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                amt.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub acctname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acctname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                bankname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles no.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If GRID.Visible = True Then
                    GRID.Focus()
                Else
                    If no.Text <> "" Then
                        Dim acc As New DataTable
                        acc = account_procedure("", "", "", no.Text, "VIEW1", "", "", 0)
                        acctname.Text = acc.Rows(0)(0)
                        bankname.Text = acc.Rows(0)(1)
                        acctname.Enabled = False
                        bankname.Enabled = False
                        ComboBox1.Focus()
                    End If
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub acountdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acountdetail.Click
        Try
            AccountCreation1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Date1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                no.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no.Leave
        Try
            Dim acc As New DataTable
            If no.Text <> "" And GRID.Visible = False Then
                acc = account_procedure("", "", "", no.Text, "VIEW1", "", "", 0)
                acctname.Text = acc.Rows(0)(0)
                bankname.Text = acc.Rows(0)(1)
                acctname.Enabled = False
                bankname.Enabled = False
                ComboBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no.TextChanged
        Try
            If no.Text = "" Then
                acctname.Text = ""
                acctname.Enabled = True
                bankname.Text = ""
                bankname.Enabled = True
                GRID.Visible = False
            Else
                Dim acc As New DataTable
                acc = account_procedure("", "", "", no.Text + "%", "VIEW2", "", "", 0)
                If acc.Rows.Count <> 0 Then
                    GRID.DataSource = acc
                    GRID.Columns(0).Width = 150
                    GRID.Visible = True
                Else
                    no.Text = ""
                    no.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID.DoubleClick
        Try
            no.Text = GRID.CurrentRow.Cells(0).Value
            no.Focus()
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.SelectedItem = "Cheque" Then
                checkno.Visible = True
                l1.Visible = True
                l2.Visible = True
                labl.Visible = True
                Label20.Visible = True
                chdat.Visible = True
                chdat.Value = Date.Today
            Else
                l1.Visible = False
                l2.Visible = False
                labl.Visible = False
                Label20.Visible = False
                chdat.Visible = False
                chdat.Value = Date.Today
                checkno.Visible = False
                checkno.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If ComboBox1.Text <> "" Then
                    amt.Focus()
                Else
                    ComboBox1.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub checkno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles checkno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If checkno.Text = "" Then
                    checkno.Focus()
                Else
                    chdat.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bank_addbtn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bank_addbtn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bank_edit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bank_edit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Print_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Print.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chdat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chdat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Date1.Text <> "" Or chdat.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = Date1.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If chdat.Value < dat Then
                        MsgBox("Check Date Must Be Greater Than Entry Date", MsgBoxStyle.Information, suss)
                        chdat.Value = dat
                        chdat.Focus()
                    Else
                        If bank_addbtn.Visible = True Then
                            bank_addbtn.Focus()
                        Else
                            bank_edit.Focus()
                        End If
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cancel()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles checkno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub amt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amt.Leave
        If Trim(no.Text) <> "" And Val(amt.Text) <> 0 Then
            Dim dt As New DataTable
            dt = withdraw_PROC("", "", Trim(no.Text), 0, "", "", "", "", "", "amtcheck")
            If Val(amt.Text) <= Val(dt.Rows(0)(0).ToString) Then
                If ComboBox1.Text = "Cheque" Then
                    checkno.Focus()
                Else
                    bank_addbtn.Focus()
                End If
            Else
                MsgBox("Insuficient Balancce In This Account", MsgBoxStyle.Information, suss)
                amt.Text = "0.00"
                amt.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
End Class