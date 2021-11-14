Public Class brandname
    Dim response As String
    Dim index As Integer
    Dim i As Integer
    Dim cntdt As New DataTable
    Dim a1 As String
    Dim oldname As String
    Private Sub brandname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt1 As New DataTable
            dt1 = brand_saved("", "", "", "view")
            grid.DataSource = dt1
            Dim dt As New DataTable
            dt = mat()
            Dim dr As DataRow
            matname.Items.Clear()
            For Each dr In dt.Rows()
                matname.Items.Add(dr("materialname"))
            Next
            grid.Columns(0).Visible = False
            grid.Columns(1).Width = 150
            grid.Columns(2).Width = 150
            grid.Columns(3).Width = 150
            clear()
            matname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        Try
            If Trim(matname.Text) = "" Or Trim(brname.Text) = "" Or active.Checked = False And deactive.Checked = False Then
                MsgBox("please fill the fields", MsgBoxStyle.Information, "Message")
            Else
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"

                End If
                Dim save As New DataTable
                save = brand_saved(Trim(matname.SelectedItem.ToString()), Trim(brname.Text), a, "insert")

                If save.Rows(0)(0) = 1 Then
                    MsgBox("saved successfully", MsgBoxStyle.Information, "Message")
                    Dim dt As New DataTable
                    dt = brand_saved("", "", "", "view")
                    grid.DataSource = dt
                    grid.Columns(0).Visible = False
                    grid.Columns(1).Width = 150
                    grid.Columns(2).Width = 150
                    grid.Columns(3).Width = 150
                    clear()
                Else
                    MsgBox("That type is already saved", MsgBoxStyle.Information, "Message")
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
                    matname.Focus()

                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If vbYes = response Then
                        dt = brand_saved(cnt.Rows(grid.CurrentRow.Index)(1), cnt.Rows(grid.CurrentRow.Index)(2), cnt.Rows(grid.CurrentRow.Index)(3), "delete")
                        If dt.Rows(0)(0) = 5 Then
                            MsgBox("Successfully deleted", MsgBoxStyle.Information, "Message")
                        Else
                            MsgBox("Cannot Be Deleted", MsgBoxStyle.Information, "Message")
                        End If
                        clear()
                        Dim sup As New DataTable
                        sup = brand_saved("", "", "", "VIEW")
                        grid.DataSource = sup
                        grid.Columns(0).Visible = False
                        grid.Columns(1).Width = 150
                        grid.Columns(2).Width = 150
                        grid.Columns(3).Width = 150
                    Else

                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)

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
                If Trim(matname.Text) = "" Or Trim(brname.Text) = "" Or active.Checked = False And deactive.Checked = False Then
                    MsgBox("please fill the fields", MsgBoxStyle.Information, "Message")
                Else
                    Dim a As String
                    If active.Checked = True Then

                        a = "A"
                    Else
                        a = "D"
                    End If
                    Dim dt10 As New DataTable
                    dt10 = brand_saved(Trim(matname.SelectedItem.ToString()), Trim(brname.Text), a, oldname)
                    If dt10.Rows(0)(0) = 3 Then
                        MsgBox("Updated successfully", MsgBoxStyle.Information, "Message")
                    ElseIf dt10.Rows(0)(0) = 0 Then
                        MsgBox("This is already saved", MsgBoxStyle.Information, "Message")
                    Else
                        MsgBox("Cannot Be Updated.", MsgBoxStyle.Information, "Message")
                    End If
                    Dim viewgroup As New DataTable
                    viewgroup = brand_saved("", "", "", "view")
                    grid.DataSource = viewgroup
                    grid.Columns(0).Visible = False
                    grid.Columns(1).Width = 150
                    grid.Columns(2).Width = 150
                    grid.Columns(3).Width = 150
                    clear()
                    edit.Text = "&EDIT"
                    add.Enabled = True
                    delete.Enabled = True
                    Dim sup As New DataTable
                    sup = brand_saved("", "", "", "view")
                    grid.DataSource = sup
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = grid.DataSource
                        i = grid.CurrentRow.Index
                        matname.Text = getdt.Rows(grid.CurrentRow.Index)(1)
                        brname.Text = getdt.Rows(grid.CurrentRow.Index)(2)
                        oldname = getdt.Rows(grid.CurrentRow.Index)(0)
                        If getdt.Rows(grid.CurrentRow.Index)(3) = "A" Then
                            active.Checked = True
                        Else
                            deactive.Checked = True
                        End If

                        add.Enabled = False
                        edit.Text = "&UPDATE"
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        Try
            matname.Focus()
            matname.SelectedIndex = -1
            brname.Text = ""
            active.Checked = True
            deactive.Checked = False
            add.Enabled = True
            delete.Enabled = True
            edit.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub matname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles matname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If matname.Text <> "" Then
                    brname.Focus()
                Else
                    matname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub brname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles brname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If brname.Text <> "" Then
                    active.Focus()
                Else
                    brname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
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
                    add.Focus()
                Else
                    edit.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                deactive.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
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
                    add.Focus()
                Else
                    edit.Focus()
                End If
            ElseIf e.KeyCode = Keys.Right Then
                active.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub add_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles add.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub brandname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub brname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles brname.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or brname.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class