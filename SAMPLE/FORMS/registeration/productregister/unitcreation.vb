Public Class unitcreation
    Dim oldname As String
    Private Sub unitcreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clear()
            Dim dt As New DataTable
            dt = unit_procedure("", "", "VIEW")
            grid.DataSource = dt
            Call gridview()
            active.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub disabletext()
        Try
            unitname.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gridview()
        Try
            grid.Columns(0).Width = 250
            grid.Columns(1).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            If Trim(unitname.Text) = "" Or active.Checked = False And expired.Checked = False Then
                MsgBox("Please Enter All Fields", MsgBoxStyle.Information, "Message")
                unitname.Focus()
            Else
                Dim unit As New DataTable
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"
                End If
                unit = unit_procedure(Trim(unitname.Text), a, "INSERT")
                If unit.Rows(0)(0) = 1 Then
                    MsgBox("The unit name is already existed", MsgBoxStyle.Information, "Message")
                    unitname.Text = ""
                    unitname.Focus()
                Else
                    MsgBox("Saved successfully", MsgBoxStyle.Information, "Message")
                    Dim dt As New DataTable
                    dt = unit_procedure("", "", "VIEW")
                    grid.DataSource = dt
                    Call gridview()
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Try
            Dim response As String
            Dim cnt As New DataTable
            Dim dt As New DataTable
            cnt = grid.DataSource
            If cnt.Rows.Count > 0 Then
                Dim index As Integer
                index = grid.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Information)
                    unitname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If vbYes = response Then
                        dt = unit_procedure(cnt.Rows(grid.CurrentRow.Index)(0), cnt.Rows(grid.CurrentRow.Index)(1), "DELETE")
                        If dt.Rows(0)(0) = 5 Then
                            MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Message")
                        Else
                            MsgBox("Connot Be Deleted", MsgBoxStyle.Information, "Message")
                        End If
                        Dim sup As New DataTable
                        sup = unit_procedure("", "", "VIEW")
                        grid.DataSource = sup
                        gridview()
                        clear()
                    Else
                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                unitname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        Try
            unitname.Text = ""
            unitname.Enabled = True
            active.Checked = True
            unitname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = grid.DataSource
            If edit.Text = "&UPDATE" Then
                If Trim(unitname.Text) = "" Or active.Checked = False And expired.Checked = False Then
                    MsgBox("Please Enter All Fields", MsgBoxStyle.Information, "Message")
                    unitname.Focus()
                Else
                    Dim a As String
                    If active.Checked = True Then
                        a = "A"
                    Else
                        a = "D"
                    End If
                    Dim dt As New DataTable
                    dt = unit_procedure(unitname.Text, a, oldname)
                    If dt.Rows(0)(0) = 3 Then
                        MsgBox("updated successfully", MsgBoxStyle.Information, "Message")
                    Else
                        MsgBox("Connot Be Updated", MsgBoxStyle.Information, "Message")
                    End If
                    Dim sup As New DataTable
                    sup = unit_procedure("", "", "VIEW")
                    grid.DataSource = sup
                    Call gridview()
                    edit.Text = "&Edit"
                    save.Enabled = True
                    delete.Enabled = True
                    clear()
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "Message")
                    unitname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = grid.DataSource
                        i = grid.CurrentRow.Index
                        unitname.Text = getdt.Rows(grid.CurrentRow.Index)(0)
                        oldname = getdt.Rows(grid.CurrentRow.Index)(0)
                        If getdt.Rows(grid.CurrentRow.Index)(1) = "A" Then
                            active.Checked = True
                        Else
                            expired.Checked = True
                        End If
                        save.Enabled = False
                        delete.Enabled = False
                        edit.Text = "&UPDATE"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Reset_Click_1()
        Try
            unitname.Text = ""
            active.Checked = True
            expired.Checked = False
            edit.Text = "&Edit"
            save.Enabled = True
            edit.Enabled = True
            clear()
            delete.Enabled = True
            unitname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub unitname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles unitname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If unitname.Text <> "" Then
                    active.Focus()
                Else
                    unitname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Reset_Click_1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub active_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles active.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If edit.Text = "&Edit" Then
                    save.Focus()
                Else
                    edit.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                expired.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Reset_Click_1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub expired_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles expired.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If edit.Text = "&Edit" Then
                    save.Focus()
                Else
                    edit.Focus()
                End If
            ElseIf e.KeyCode = Keys.Right Then
                active.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Reset_Click_1()
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
                    Reset_Click_1()
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
                    Reset_Click_1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles delete.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Reset_Click_1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub unitcreation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub unitname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles unitname.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or unitname.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class