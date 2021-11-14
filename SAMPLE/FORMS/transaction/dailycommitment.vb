Public Class dailycommitment

    Private Sub dailycommitment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clear()
            viewcomt()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub clear()
        Try
            dat_comt.Value = Today.Date
            txt_cmt.Text = ""
            rd_pending.Checked = True
            btn_save.Enabled = True
            btn_delete.Enabled = True
            btn_edit.Text = "&Edit"
            dat_comt.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub viewcomt()
        Try
            Dim dt As New DataTable
            dt = commitment("", "", "", "viewall", "", "", "")
            grid_cmt.DataSource = dt
            gridwidth()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub gridwidth()
        Try
            grid_cmt.Columns(0).Visible = False
            grid_cmt.Columns(1).Width = 110
            grid_cmt.Columns(2).Width = 400
            grid_cmt.Columns(3).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dat_comt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dat_comt.ValueChanged
        Try
            Dim dt As New DataTable
            dt = commitment(dat_comt.Value.ToString("MM/dd/yyyy"), "", "", "datewise", "", "", "")
            grid_cmt.DataSource = dt
            gridwidth()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dat_comt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dat_comt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_cmt.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_cmt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cmt.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_cmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cmt.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_cmt.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            Dim dt As New DataTable
            Dim st As String = ""
            If Trim(txt_cmt.Text) = "" Or rd_finished.Checked = False And rd_pending.Checked = False Then
                MsgBox("Please Fill All Fields", MsgBoxStyle.Information, suss)
                txt_cmt.Focus()
            Else
                If rd_finished.Checked = True Then
                    st = "Finished"
                ElseIf rd_pending.Checked = True Then
                    st = "Pending"
                End If
                dt = commitment(dat_comt.Value.ToString("MM/dd/yyyy"), Trim(txt_cmt.Text), st, "Insert", "", "", "")
                If dt.Rows(0)(0).ToString = "1" And dt.Rows.Count <> 0 Then
                    MsgBox("Saved Successfully", MsgBoxStyle.Information, suss)
                    clear()
                    viewcomt()
                Else
                    MsgBox("Can't Be Saved", MsgBoxStyle.Information, suss)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Try
            Dim st As String = ""
            Dim dt As New DataTable
            Dim response As String
            Dim getdt As New DataTable
            getdt = grid_cmt.DataSource
            Dim i As Integer
            If btn_edit.Text = "&Edit" Then
                If getdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        i = grid_cmt.CurrentRow.Index
                        id.Text = getdt.Rows(i)(0)
                        txt_cmt.Text = getdt.Rows(i)(2)
                        st = getdt.Rows(i)(3)
                        If st = "Finished" Then
                            rd_finished.Checked = True
                        ElseIf st = "Pending" Then
                            rd_pending.Checked = True
                        End If
                        Dim dat As Date
                        Dim a As String
                        a = getdt.Rows(i)(1)
                        a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                        dat = CDate(a)
                        dat_comt.Value = dat
                        btn_save.Enabled = False
                        btn_edit.Text = "&Update"
                        btn_delete.Enabled = False
                    End If
                End If
            ElseIf btn_edit.Text = "&Update" Then
                If Trim(txt_cmt.Text) = "" Or rd_finished.Checked = False And rd_pending.Checked = False Then
                    MsgBox("Please Fill All Fields", MsgBoxStyle.Information, suss)
                    txt_cmt.Focus()
                Else
                    If rd_finished.Checked = True Then
                        st = "Finished"
                    ElseIf rd_pending.Checked = True Then
                        st = "Pending"
                    End If
                    dt = commitment(dat_comt.Value.ToString("MM/dd/yyyy"), Trim(txt_cmt.Text), st, "update", Trim(id.Text), "", "")
                    If dt.Rows(0)(0).ToString = "2" Then
                        MsgBox("Updated Successfully", MsgBoxStyle.Information, suss)
                        clear()
                        viewcomt()
                    Else
                        MsgBox("Can't Be Updated", MsgBoxStyle.Information, suss)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            Dim response As String
            Dim dt1 As New DataTable
            Dim DT2 As New DataTable
            DT2 = grid_cmt.DataSource
            If DT2.Rows.Count > 0 Then
                Dim index As Integer
                index = grid_cmt.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row")
                    dat_comt.Focus()
                Else
                    response = MsgBox("Are You Sure To Delete This Record", MsgBoxStyle.YesNo, "Warning")
                    If vbYes = response Then
                        dt1 = commitment("", "", "", "delete", DT2.Rows(grid_cmt.CurrentRow.Index)(0), "", "")
                        If dt1.Rows(0)(0).ToString = "4" Then
                            MsgBox("Deleted Successfully", MsgBoxStyle.Information, suss)
                            clear()
                            viewcomt()
                        Else
                            MsgBox("Can't Be Deleted", MsgBoxStyle.Information, suss)
                        End If
                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                dat_comt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub rd_finished_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rd_finished.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub rd_pending_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rd_pending.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub btn_save_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_save.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub btn_edit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_edit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub btn_delete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_delete.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub

    Private Sub btn_exit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_exit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                clear()
            End If
        End If
    End Sub
End Class