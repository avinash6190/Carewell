Imports System.Data.SqlClient
Public Class empcreation
    Dim oldname As String
    Sub enable()
        Try
            name1.Enabled = True
            address1.Enabled = True
            email1.Enabled = True
            mobno1.Enabled = True
            status.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub disable()
        Try
            name1.Enabled = False
            address1.Enabled = False
            email1.Enabled = False
            mobno1.Enabled = False
            status.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub empcreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sup As New DataTable
            sup = emp_register("", "", "", "", "", "VIEW")
            grid.DataSource = sup
            grid.Columns(0).Width = 180
            grid.Columns(1).Width = 200
            grid.Columns(2).Width = 130
            grid.Columns(3).Width = 180
            grid.Columns(4).Width = 140
            reset_cls()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        Try
            name1.Text = ""
            address1.Text = ""
            email1.Text = ""
            mobno1.Text = ""
            active.Checked = False
            expired.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            If Trim(name1.Text) = "" Or Trim(address1.Text) = "" Or Trim(email1.Text) = "" Or Trim(mobno1.Text) = "" Or active.Checked = False And expired.Checked = False Then
                MsgBox("Please fill the all fields", MsgBoxStyle.Information, "Message")
            Else
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"
                End If
                Dim dt As New DataTable
                dt = emp_register(Trim(name1.Text), Trim(address1.Text), Trim(email1.Text), Trim(mobno1.Text), a, "INSERT")
                If dt.Rows(0)(0) = 1 Then
                    MsgBox("saved successfully", MsgBoxStyle.Information, "Message")
                    reset_cls()
                Else
                    MsgBox("Already saved", MsgBoxStyle.Information, "Message")
                End If
                Dim sup As New DataTable
                sup = emp_register("", "", "", "", "", "view")
                grid.DataSource = sup
                grid.Columns(0).Width = 180
                grid.Columns(1).Width = 200
                grid.Columns(2).Width = 130
                grid.Columns(3).Width = 180
                grid.Columns(4).Width = 140
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim response As String
        '    Dim cnt As New DataTable
        '    Dim dt As New DataTable
        '    cnt = grid.DataSource
        '    If cnt.Rows.Count > 0 Then
        '        Dim index As Integer
        '        index = grid.CurrentRow.Index
        '        If index < 0 Then
        '            MsgBox("There is no row", MsgBoxStyle.Information)
        '            name1.Focus()
        '        Else
        '            response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
        '            If vbYes = response Then
        '                dt = emp_register(cnt.Rows(grid.CurrentRow.Index)(0), cnt.Rows(grid.CurrentRow.Index)(1), "", "", cnt.Rows(grid.CurrentRow.Index)(4), "DELETE")
        '                If dt.Rows(0)(0) = 10 Then
        '                    MsgBox("Successfully deleted", MsgBoxStyle.Information, "Message")
        '                Else
        '                    MsgBox("Cannot Be Deleted", MsgBoxStyle.Information, "Message")
        '                End If
        '                Dim sup As New DataTable
        '                sup = emp_register("", "", "", "", "", "VIEW")
        '                grid.DataSource = sup
        '                grid.Columns(0).Width = 180
        '                grid.Columns(1).Width = 200
        '                grid.Columns(2).Width = 130
        '                grid.Columns(3).Width = 180
        '                grid.Columns(4).Width = 140
        '                reset_cls()
        '            Else
        '            End If
        '        End If
        '    Else
        '        MsgBox("There Is no Row", MsgBoxStyle.Information)
        '        name1.Focus()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = grid.DataSource
            If edit.Text = "&UPDATE" Then
                If Trim(name1.Text) = "" Or Trim(address1.Text) = "" Or Trim(email1.Text) = "" Or Trim(mobno1.Text) = "" Or active.Checked = False And expired.Checked = False Then
                    MsgBox("Please fill the all fields", MsgBoxStyle.Information, "Message")
                    name1.Focus()
                Else
                    Dim a As String
                    If active.Checked = True Then

                        a = "A"
                    Else
                        a = "D"
                    End If
                    Dim dt As New DataTable
                    dt = emp_register(Trim(name1.Text), Trim(address1.Text), Trim(email1.Text), Trim(mobno1.Text), a, oldname)
                    If dt.Rows(0)(0) = 3 Then
                        MsgBox("updated successfully", MsgBoxStyle.Information, "Message")
                        reset_cls()
                    Else
                        MsgBox("Connot Be Updated", MsgBoxStyle.Information, "Message")
                    End If
                    Dim sup As New DataTable
                    sup = emp_register("", "", "", "", "", "VIEW")
                    grid.DataSource = sup
                    grid.Columns(0).Width = 180
                    grid.Columns(1).Width = 200
                    grid.Columns(2).Width = 130
                    grid.Columns(3).Width = 180
                    grid.Columns(4).Width = 140
                    edit.Text = "&Edit"
                    save.Enabled = True
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "Message")
                    name1.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = grid.DataSource
                        i = grid.CurrentRow.Index
                        name1.Text = getdt.Rows(grid.CurrentRow.Index)(0)
                        address1.Text = getdt.Rows(grid.CurrentRow.Index)(1)
                        email1.Text = getdt.Rows(grid.CurrentRow.Index)(2)
                        mobno1.Text = getdt.Rows(grid.CurrentRow.Index)(3)
                        oldname = getdt.Rows(grid.CurrentRow.Index)(0)
                        If getdt.Rows(grid.CurrentRow.Index)(4) = "A" Then
                            active.Checked = True
                        Else
                            expired.Checked = True
                        End If
                        save.Enabled = False
                        edit.Text = "&UPDATE"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reset_cls()
        Try
            name1.Text = ""
            address1.Text = ""
            email1.Text = ""
            mobno1.Text = ""
            active.Checked = True
            save.Enabled = True
            edit.Enabled = True
            edit.Text = "&Edit"
            name1.Focus()
            expired.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Try

            Dim cnt As New DataTable
            cnt = grid.DataSource
            If grid.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    Dim ds As New employee
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("emp").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(3), cnt.Rows(i)(2), "", "", "")
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New employee_rpt
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub name1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles name1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If name1.Text <> "" Then
                    address1.Focus()
                Else
                    name1.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub address1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles address1.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mobno1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mobno1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If mobno1.Text <> "" Then
                    save.Focus()
                Else
                    mobno1.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub email1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles email1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If email1.Text <> "" Then
                    mobno1.Focus()
                Else
                    email1.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub active_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles active.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub expired_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles expired.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub save_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles save.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub edit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub print_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles print.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub empcreation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub name1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles name1.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or name1.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub address1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles address1.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or address1.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub email1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email1.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mobno1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobno1.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = mobno1.Text
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
End Class