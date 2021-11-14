Public Class Employee_User
    Private Sub password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Button1.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub empname_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles empname.DoubleClick, DataGridView1.DoubleClick
        Try
            Dim a As Integer, b As String
            a = DataGridView1.CurrentRow.Cells(0).Value
            b = DataGridView1.CurrentRow.Cells(1).Value
            eid.Text = a
            empname.Text = b
            DataGridView1.Visible = False
            empname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub empname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles empname.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                If DataGridView1.Visible = True Then
                    empname.Text = ""
                    DataGridView1.Visible = False
                Else
                End If
            ElseIf e.KeyCode = Keys.Left Then
                username.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                If DataGridView1.Visible = True Then
                    DataGridView1.Focus()
                Else
                    username.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empname.TextChanged
        Try
            If empname.Text <> "" Then
                Dim dta As New DataTable
                dta = emp_register(empname.Text + "%", "", "", "", "A", "V1")
                DataGridView1.DataSource = dta
                DataGridView1.Columns(0).Width = 150
                If empname.TextLength = 0 Or DataGridView1.RowCount <= 0 Then
                    DataGridView1.Visible = False
                    empname.Text = ""
                    empname.Focus()
                Else
                    DataGridView1.Visible = True
                    DataGridView1.DataSource = dta
                    DataGridView1.Columns(0).Width = 100
            End If
            Else
                If DataGridView1.Visible = True Then
                    DataGridView1.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Trim(empname.Text) = "" Or Trim(username.Text) = "" Or Trim(password.Text) = "" Or active.Checked = False And deactive.Checked = False Then
                MsgBox("PLEASE INSERT ALL FEILDS")
                empname.Text = ""
                empname.Focus()
            Else
                Dim str1 As String
                If active.Checked = True Then
                    str1 = "a"
                Else
                    str1 = "d"
                End If
                Dim ss As New DataTable
                ss = emp_register(empname.Text, username.Text, password.Text, eid.Text, str1, "insert-log")
                Dim q As Integer
                q = ss.Rows(0)(0)
                If q = 66 Then
                    MsgBox("successfully Saved", MsgBoxStyle.Information, suss)
                    empname.Text = ""
                    username.Text = ""
                    password.Text = ""
                    active.Checked = False
                    deactive.Checked = False
                    Dim as1 As New DataTable
                    as1 = emp_register("", "", "", "", "", "view_log")
                    emp.DataSource = as1
                ElseIf q = 11 Then
                    MsgBox("UserName Aldready Exists", MsgBoxStyle.Information, suss)
                    empname.Text = ""
                    username.Text = ""
                    password.Text = ""
                    active.Checked = False
                    deactive.Checked = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            Dim cdt As New DataTable
            cntdt = emp.DataSource
            If Button2.Text = "&UPDATE" Then
                If Trim(empname.Text) = "" Or Trim(username.Text) = "" Or Trim(password.Text) = "" Or active.Checked = False And deactive.Checked = False Then
                    MsgBox("PLEASE INSERT ALL FEILDS")
                    empname.Focus()
                Else
                    Dim A As String
                    If active.Checked = True Then
                        A = "a"
                    Else
                        A = "d"
                    End If
                    cdt = emp_register(Trim(oldempname.Text), Trim(username.Text), Trim(password.Text), Trim(eid.Text), A, "Update_log")
                    If cdt.Rows(0)(0) = 77 Then
                        MsgBox("Updated successfully", MsgBoxStyle.Information, suss)
                        oldempname.Text = ""
                        Button2.Text = "&EDIT"
                        Button1.Enabled = True
                        Button3.Enabled = True
                        empname.Text = ""
                        username.Text = ""
                        password.Text = ""
                        active.Checked = False
                        deactive.Checked = False
                        Dim sup As New DataTable
                        sup = emp_register("", "", "", "", "", "view_log")
                        emp.DataSource = sup
                    ElseIf cdt.Rows(0)(0) = 22 Then
                        MsgBox("Please Give Correct Username.", MsgBoxStyle.Information, suss)
                        oldempname.Text = ""
                        Button2.Text = "&EDIT"
                        Button1.Enabled = True
                        Button3.Enabled = True
                        empname.Text = ""
                        username.Text = ""
                        password.Text = ""
                        active.Checked = False
                        deactive.Checked = False
                        Dim sup As New DataTable
                        sup = emp_register("", "", "", "", "", "view_log")
                        emp.DataSource = sup
                    End If
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                    empname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = emp.DataSource
                        i = emp.CurrentRow.Index
                        eid.Text = getdt.Rows(emp.CurrentRow.Index)(0)
                        username.Text = getdt.Rows(emp.CurrentRow.Index)(2)
                        password.Text = getdt.Rows(emp.CurrentRow.Index)(3)
                        If getdt.Rows(emp.CurrentRow.Index)(4) = "ACTIVE" Then
                            active.Checked = True
                        Else
                            deactive.Checked = True
                        End If
                        empname.Text = getdt.Rows(emp.CurrentRow.Index)(1)
                        oldempname.Text = getdt.Rows(emp.CurrentRow.Index)(2)
                        DataGridView1.Visible = False
                        Button1.Enabled = False
                        Button3.Enabled = False
                        enable()
                        Button2.Text = "&UPDATE"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim response As String
            Dim cnt As New DataTable
            Dim dt As New DataTable
            cnt = emp.DataSource
            If cnt.Rows.Count > 0 Then
                Dim index As Integer
                index = emp.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Information)
                    empname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If vbYes = response Then
                        dt = emp_register(cnt.Rows(emp.CurrentRow.Index)(0), cnt.Rows(emp.CurrentRow.Index)(1), cnt.Rows(emp.CurrentRow.Index)(2), "", "", "DELETE-log")
                        If dt.Rows(0)(0).ToString = -1 Then
                            MsgBox("Successfully Deleted", MsgBoxStyle.Information, suss)
                            empname.Text = ""
                            username.Text = ""
                            password.Text = ""
                            active.Checked = False
                            deactive.Checked = False
                        Else
                            MsgBox("Please Give Correct UserName.", MsgBoxStyle.Information, suss)
                            empname.Text = ""
                            username.Text = ""
                            password.Text = ""
                            active.Checked = False
                            deactive.Checked = False
                        End If
                        Dim sup As New DataTable
                        sup = emp_register("", "", "", "", "", "view_log")
                        emp.DataSource = sup
                    Else

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Employee_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            active.Checked = True
            Dim as1 As New DataTable
            as1 = emp_register("", "", "", "", "", "view_log")
            emp.DataSource = as1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub enable()
        Try
            empname.Enabled = True
            username.Enabled = True
            password.Enabled = True
            status.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub disable()
        Try
            empname.Enabled = False
            username.Enabled = False
            password.Enabled = False
            status.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                empname_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                username.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                password.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub empname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles empname.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub username_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub password_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class