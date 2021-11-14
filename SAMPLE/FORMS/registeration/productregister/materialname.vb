Public Class materialname
    Dim response As String
    Dim index As Integer
    Dim i As Integer
    Dim cntdt As New DataTable
    Dim a1 As String
    Dim oldname As String
    Sub clear()
        Try
            matname.Text = ""
            active.Checked = True
            deactive.Checked = False
            matname.Enabled = True
            matname.Focus()
            Dim sup As New DataTable
            sup = mat_name("", "", "view")
            grid.DataSource = sup
            grid.Columns(0).Width = 250
            grid.Columns(1).Width = 150
            grid.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            If Trim(matname.Text) = "" Or active.Checked = False And deactive.Checked = False Then
                MsgBox("please fill the all fields properly", MsgBoxStyle.Information, "Message")
                matname.Focus()
            Else
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"
                End If
                Dim dt As New DataTable
                dt = mat_name(Trim(matname.Text), a, "insert")
                If dt.Rows(0)(0) = 0 Then
                    MsgBox("This name is already saved", MsgBoxStyle.Information, "Message")
                    matname.Focus()
                Else
                    MsgBox("Saved Successfully", MsgBoxStyle.Information, "Message")
                    grid.Columns(0).Width = 250
                    grid.Columns(1).Width = 150
                    grid.Columns(2).Visible = False
                    clear()
                End If
            End If
            Call clear()
            matname.Focus()
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
                    matname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If vbYes = response Then
                        dt = mat_name(cnt.Rows(grid.CurrentRow.Index)(0), cnt.Rows(grid.CurrentRow.Index)(1), "DELETE")
                        If dt.Rows(0)(0) = 2 Then
                            MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Message")
                        Else
                            MsgBox("Cannot Be Deleted.", MsgBoxStyle.Information, "Message")
                        End If
                        Call clear()
                    Else
                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                matname.Focus()
            End If
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
                If Trim(matname.Text) = "" Or active.Checked = False And deactive.Checked = False Then
                    MsgBox("please fill the all fields", MsgBoxStyle.Information, "Message")

                Else
                    Dim a As String
                    If active.Checked = True Then

                        a = "A"
                    Else
                        a = "D"
                    End If
                    Dim dt10 As New DataTable
                    dt10 = mat_name(Trim(matname.Text), a, oldname)
                    If dt10.Rows(0)(0) = 3 Then
                        MsgBox("Updated Successfully", MsgBoxStyle.Information, "Message")
                        grid.Columns(0).Width = 250
                        grid.Columns(1).Width = 150
                        grid.Columns(2).Visible = False
                        clear()
                    ElseIf dt10.Rows(0)(0) = 0 Then
                        MsgBox("This name is already saved", MsgBoxStyle.Information, "Message")
                        matname.Focus()
                    Else
                        MsgBox("Cannot Be Updated", MsgBoxStyle.Information, "Message")
                        clear()
                    End If
                    edit.Text = "&EDIT"
                    save.Enabled = True
                    delete.Enabled = True
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "Message")
                    matname.Focus()

                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = grid.DataSource
                        i = grid.CurrentRow.Index
                        matname.Text = getdt.Rows(grid.CurrentRow.Index)(0)
                        oldname = getdt.Rows(grid.CurrentRow.Index)(2)

                        If getdt.Rows(grid.CurrentRow.Index)(1) = "A" Then
                            active.Checked = True
                        Else
                            deactive.Checked = True
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
    Private Sub materialname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sup As New DataTable
            matname.Enabled = True
            matname.Focus()
            sup = mat_name("", "", "view")
            grid.DataSource = sup
            grid.Columns(0).Width = 250
            grid.Columns(1).Width = 150
            active.Checked = True
            deactive.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reset_Click()
        Try
            matname.Text = ""
            active.Checked = True
            deactive.Checked = False
            matname.Enabled = True
            matname.Focus()
            Dim sup As New DataTable
            sup = mat_name("", "", "view")
            grid.DataSource = sup
            grid.Columns(0).Width = 250
            grid.Columns(1).Width = 150
            edit.Text = "&EDIT"
            save.Enabled = True
            delete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub matname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles matname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If matname.Text <> "" Then
                    active.Focus()
                Else
                    matname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_Click()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub active_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles active.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If edit.Text = "&EDIT" Then
                    save.Focus()
                Else
                    edit.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                deactive.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_Click()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub deactive_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles deactive.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If edit.Text = "&EDIT" Then
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
                    reset_Click()
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
                    reset_Click()
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
                    reset_Click()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles delete.KeyDown
        try
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                reset_Click()
            End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub materialname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_Click()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub matname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles matname.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or matname.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class