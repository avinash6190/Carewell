Public Class Salary_Details


    Dim d As String
    Dim s As String
    Private Sub Salary_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), "VIEW", "")
            sal_view.DataSource = dt
            sal_view.Columns(0).Width = 185
            sal_view.Columns(1).Width = 70
            sal_view.Columns(2).Width = 100
            EMPNAME()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub EMPNAME()
        Dim group As New DataTable
        group = emp_register("", "", "", "", "A", "V2")
        Dim groupdr As DataRow
        empname_cbk.Items.Clear()
        For Each groupdr In group.Rows()
            empname_cbk.Items.Add(groupdr("empname"))
        Next
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        Try
            Dim dt As New DataTable
            dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), "INSERT", "")
            If dt.Rows(0)(0) = 1 Then
                MsgBox("Saved SuccessFully", MsgBoxStyle.DefaultButton1, suss)
            ElseIf dt.Rows(0)(0) = -1 Then
                MsgBox("Already Exists On this same day", MsgBoxStyle.DefaultButton1, err)
            ElseIf dt.Rows(0)(0) = 0 Then
                MsgBox("Enter A valid Employee", MsgBoxStyle.DefaultButton1, err)
            End If
            date_cbk.Focus()
            empname_cbk.SelectedIndex = -1
            date_cbk.Text = Date.Today
            salary_txt.Text = ""
            dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), "VIEW", "")
            sal_view.DataSource = dt
            sal_view.Columns(0).Width = 185
            sal_view.Columns(1).Width = 70
            sal_view.Columns(2).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Button4.Text = "&EDIT" Then
                Dim response As String
                Dim cntdt As New DataTable

                cntdt = sal_view.DataSource
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        date_cbk.Text = sal_view.CurrentRow.Cells(1).Value
                        empname_cbk.Text = sal_view.CurrentRow.Cells(0).Value
                        salary_txt.Text = sal_view.CurrentRow.Cells(2).Value
                        s = sal_view.CurrentRow.Cells(0).Value
                        d = sal_view.CurrentRow.Cells(1).Value
                        date_cbk.Focus()
                        Button4.Text = "&UPDATE"
                        save_btn.Visible = False
                    End If
                End If
            ElseIf Button4.Text = "&UPDATE" Then
                Dim dt As New DataTable

                dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), s, d)
                If dt.Rows(0)(0) = 1 Then
                    MsgBox("Data Updated SuccessFully", MsgBoxStyle.DefaultButton1, suss)
                ElseIf dt.Rows(0)(0) = -1 Then
                    MsgBox("Already Exists On this same day", MsgBoxStyle.DefaultButton1, err)
                ElseIf dt.Rows(0)(0) = 0 Then
                    MsgBox("Enter A valid Customer", MsgBoxStyle.DefaultButton1, err)
                End If
                empname_cbk.SelectedIndex = -1
                date_cbk.Text = Date.Today
                salary_txt.Text = ""
                dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), "VIEW", "")
                sal_view.DataSource = dt
                sal_view.Columns(0).Width = 185
                sal_view.Columns(1).Width = 70
                sal_view.Columns(2).Width = 100
                Button4.Visible = True
                Button4.Text = "&EDIT"
                save_btn.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim dt As New DataTable
            Dim response As String
            Dim cntdt As New DataTable

            cntdt = sal_view.DataSource
            If cntdt.Rows.Count <= 0 Then
                MsgBox("There is No Row", MsgBoxStyle.Information, "message")
            Else
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                If (response = vbYes) Then
                    dt = salary_proc(sal_view.CurrentRow.Cells(0).Value, sal_view.CurrentRow.Cells(1).Value, sal_view.CurrentRow.Cells(2).Value, "DELETE", "")
                    If dt.Rows(0)(0) = 1 Then
                        MsgBox("Data Deleted SuccessFully", MsgBoxStyle.DefaultButton1, suss)
                    End If
                End If
                empname_cbk.SelectedIndex = -1
                date_cbk.Text = Date.Today
                salary_txt.Text = ""
                dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), "VIEW", "")
                sal_view.DataSource = dt
                sal_view.Columns(0).Width = 185
                sal_view.Columns(1).Width = 70
                sal_view.Columns(2).Width = 100
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        Try
            empname_cbk.SelectedIndex = -1
            date_cbk.Text = Date.Today
            salary_txt.Text = ""
            Button4.Text = "&EDIT"
            save_btn.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If Button4.Text = "&EDIT" Then
                Dim response As String
                Dim cntdt As New DataTable

                cntdt = sal_view.DataSource
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        date_cbk.Text = sal_view.CurrentRow.Cells(1).Value
                        empname_cbk.Text = sal_view.CurrentRow.Cells(0).Value
                        salary_txt.Text = sal_view.CurrentRow.Cells(2).Value
                        s = sal_view.CurrentRow.Cells(0).Value
                        d = sal_view.CurrentRow.Cells(1).Value
                        date_cbk.Focus()
                        Button4.Text = "&UPDATE"
                        save_btn.Visible = False
                    End If
                End If
            ElseIf Button4.Text = "&UPDATE" Then
                Dim dt As New DataTable

                dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), s, d)
                If dt.Rows(0)(0) = 1 Then
                    MsgBox("Data Updated SuccessFully", MsgBoxStyle.DefaultButton1, suss)
                ElseIf dt.Rows(0)(0) = -1 Then
                    MsgBox("Already Exists On this same day", MsgBoxStyle.DefaultButton1, err)
                ElseIf dt.Rows(0)(0) = 0 Then
                    MsgBox("Enter A valid Customer", MsgBoxStyle.DefaultButton1, err)
                End If
                empname_cbk.SelectedIndex = -1
                date_cbk.Text = Date.Today
                salary_txt.Text = ""
                dt = salary_proc(empname_cbk.Text, date_cbk.Value.ToString("MM/dd/yyyy"), Val(salary_txt.Text), "VIEW", "")
                sal_view.DataSource = dt
                sal_view.Columns(0).Width = 185
                sal_view.Columns(1).Width = 70
                sal_view.Columns(2).Width = 100
                Button4.Visible = True
                Button4.Text = "&EDIT"
                save_btn.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub salary_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salary_txt.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or (KCode >= 46 And KCode <= 46) Or KCode = 8 Then
            TrapKey = False

        Else
            TrapKey = True

        End If
    End Function

    Private Sub date_cbk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles date_cbk.KeyDown
        If e.KeyCode = Keys.Enter Then
            empname_cbk.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub empname_cbk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles empname_cbk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If empname_cbk.Text <> "" Then
                salary_txt.Focus()
            Else
                empname_cbk.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub salary_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles salary_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(salary_txt.Text) <> 0 Then
                save_btn.Focus()
            Else
                salary_txt.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub
End Class