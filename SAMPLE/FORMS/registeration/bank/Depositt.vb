Imports System.Data.SqlClient
Public Class depositt
    Dim dat As Date
    Private Sub bank_addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_addbtn.Click
        Try
            Dim dt As New DataTable
            If acctname.Text = "" Or accountno.Text = "" Or bankname.Text = "" Or amt.Text = "0.00" Or amt.Text = "" Or amt.Text = "0" Or Date1.Text = "" Then
                MsgBox("Please Enter The Fields", MsgBoxStyle.Information, "message")
                Date1.Focus()
            Else
                dt = deposit_proc(Date1.Value.ToString("MM/dd/yyyy"), acctname.Text, accountno.Text, amt.Text, bankname.Text, "", "", "", ComboBox1.Text, checkno.Text, "", chdat.Value.ToString("MM/dd/yyyy"), "insert")
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
            accountno.Text = ""
            bankname.Text = ""
            Date1.Text = Today.Date
            ComboBox1.Text = ""
            amt.Text = "0.00"
            acctname.Enabled = True
            bankname.Enabled = True
            l1.Visible = False
            l2.Visible = False
            bank_edit.Text = "EDIT"
            labl.Visible = False
            Label20.Visible = False
            chdat.Visible = False
            chdat.Value = Date.Today
            bank_addbtn.Enabled = True
            bank_delete.Enabled = True
            ComboBox1.Text = ""
            checkno.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bank_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_delete.Click
        Try
            Dim response As String
            Dim dt1 As New DataTable
            Dim DT2 As New DataTable
            DT2 = Deposit_grid.DataSource
            If DT2.Rows.Count > 0 Then
                Dim index As Integer
                index = Deposit_grid.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row")
                    acctname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Waring")
                    If vbYes = response Then
                        dt1 = deposit_proc(DT2.Rows(Deposit_grid.CurrentRow.Index)(1), DT2.Rows(Deposit_grid.CurrentRow.Index)(2), DT2.Rows(Deposit_grid.CurrentRow.Index)(2), 0, "", "", "", DT2.Rows(Deposit_grid.CurrentRow.Index)(0), "", "", "", "", "delete")
                    End If
                    Call view1()
                    Call cancel()
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                acctname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub view1()
        Try
            Dim dt As New DataTable
            dt.Rows.Clear()
            dt = deposit_proc("", "", "", 0, "", "", "", "", "", "", "", "", "VIEW")
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
    Private Sub depositt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cancel()
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
                If acctname.Text = "" Or accountno.Text = "" Or bankname.Text = "" Or amt.Text = "0.00" Or amt.Text = "0" Or amt.Text = "" Or Date1.Text = "" Then
                    MsgBox("Please Enter The Fields", MsgBoxStyle.Information, "message")
                    acctname.Focus()
                Else
                    dt1 = deposit_proc(Date1.Value.ToString("MM/dd/yyyy"), acctname.Text, accountno.Text, amt.Text, bankname.Text, "", "", name1.Text, ComboBox1.Text, checkno.Text, "", chdat.Value.ToString("MM/dd/yyyy"), "update")
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    bank_delete.Enabled = True
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
                        accountno.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(2)
                        GRID.Visible = False
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
                        name1.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(0)
                        ComboBox1.Text = getdt.Rows(Deposit_grid.CurrentRow.Index)(6)
                        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
                        bank_addbtn.Enabled = False
                        bank_delete.Enabled = False
                        acctname.Enabled = False
                        bankname.Enabled = False
                        bank_edit.Text = "UPDATE"
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
                If ComboBox1.Text = "Cheque" Then
                    checkno.Focus()
                Else
                    bank_addbtn.Focus()
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
                    Dim ds As New deposit

                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("Deposit").Rows.Add(cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(5), cnt.Rows(i)(4), "", cnt.Rows(i)(1))
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2,'0' as Column1 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New deposit1
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
    Private Sub branch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
    Private Sub acctname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acctname.KeyDown
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
    Private Sub acountdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acountdetail.Click
        Try
            AccountCreation1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub accountno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles accountno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If GRID.Visible = True Then
                    GRID.Focus()
                Else
                    If accountno.Text <> "" Then
                        Dim acc As New DataTable
                        acc = account_procedure("", "", "", accountno.Text, "VIEW1", "", "", 0)
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

    Private Sub accountno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountno.TextChanged
        Try
            If accountno.Text = "" Then
                acctname.Text = ""
                acctname.Enabled = True
                bankname.Text = ""
                bankname.Enabled = True
                GRID.Visible = False
            Else
                Dim acc As New DataTable
                acc = account_procedure("", "", "", accountno.Text + "%", "VIEW2", "", "", 0)
                If acc.Rows.Count <> 0 Then
                    GRID.DataSource = acc
                    GRID.Columns(0).Width = 150
                    GRID.Visible = True
                Else
                    accountno.Text = ""
                    accountno.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub accountno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountno.Leave
        Try
            Dim acc As New DataTable
            If accountno.Text <> "" And GRID.Visible = False Then
                acc = account_procedure("", "", "", accountno.Text, "VIEW1", "", "", 0)
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

    Private Sub bank_delete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bank_delete.KeyDown
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

    Private Sub GRID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GRID_DoubleClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID.DoubleClick
        Try
            accountno.Text = GRID.CurrentRow.Cells(0).Value
            accountno.Focus()
            GRID.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Date1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                accountno.Focus()
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

    Private Sub chdat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chdat.KeyDown
        Try
            If e.KeyCode = Keys.Up Then
                checkno.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
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
End Class