Public Class dailyorder

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
            dat_order.Value = Today.Date
            txt_order.Text = ""
            cbk_type.SelectedIndex = -1
            txt_name.Text = ""
            btn_save.Enabled = True
            btn_delete.Enabled = True
            btn_edit.Text = "&Edit"
            cbk_type.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub viewcomt()
        Try
            Dim dt As New DataTable
            dt = Orders(0, "", 0, "", "", "", "", "viewall")
            grid_cmt.DataSource = dt
            gridwidth()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub gridwidth()
        Try
            grid_cmt.Columns(0).Visible = False
            grid_cmt.Columns(1).Width = 100
            grid_cmt.Columns(3).Visible = False
            grid_cmt.Columns(2).Width = 100
            grid_cmt.Columns(4).Width = 100
            grid_cmt.Columns(5).Width = 400
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dat_comt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dat_order.ValueChanged
        Try
            Dim dt As New DataTable
            dt = Orders(0, "", 0, dat_order.Value.ToString("MM/dd/yyyy"), "", "", "", "datewise")
            grid_cmt.DataSource = dt
            gridwidth()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dat_comt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dat_order.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_order.Focus()
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

    Private Sub txt_cmt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_order.KeyDown
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

    Private Sub txt_cmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_order.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_order.Text.Length = 0 Then
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
            If Trim(txt_order.Text) = "" Or cbk_type.SelectedIndex = -1 Or Trim(txt_name.Text) = "" Then
                MsgBox("Please Fill All Fields", MsgBoxStyle.Information, suss)
                cbk_type.Focus()
            Else
                dt = Orders(0, cbk_type.SelectedItem.ToString, Val(name_id.Text), dat_order.Value.ToString("MM/dd/yyyy"), Trim(txt_order.Text), "", "", "Insert")
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
                        txt_order.Text = getdt.Rows(i)(5)
                        name_id.Text = getdt.Rows(i)(3)
                        cbk_type.Text = getdt.Rows(i)(2)
                        txt_name.Text = getdt.Rows(i)(4)
                        Dim dat As Date
                        Dim a As String
                        a = getdt.Rows(i)(1)
                        a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                        dat = CDate(a)
                        dat_order.Value = dat
                        btn_save.Enabled = False
                        btn_edit.Text = "&Update"
                        btn_delete.Enabled = False
                        GRID.Visible = False
                    End If
                End If
            ElseIf btn_edit.Text = "&Update" Then
                If Trim(txt_order.Text) = "" Or cbk_type.SelectedIndex = -1 Or Trim(txt_name.Text) = "" Then
                    MsgBox("Please Fill All Fields", MsgBoxStyle.Information, suss)
                    cbk_type.Focus()
                Else
                    dt = Orders(Val(id.Text), cbk_type.SelectedItem.ToString, Val(name_id.Text), dat_order.Value.ToString("MM/dd/yyyy"), Trim(txt_order.Text), "", "", "update")
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
                    dat_order.Focus()
                Else
                    response = MsgBox("Are You Sure To Delete This Record", MsgBoxStyle.YesNo, "Warning")
                    If vbYes = response Then
                        dt1 = Orders(DT2.Rows(grid_cmt.CurrentRow.Index)(0), "", 0, "", "", "", "", "delete")
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
                dat_order.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Try
            clear()
            viewcomt()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
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

    Private Sub cbk_type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_type.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cbk_type.Text <> "" Then
                    txt_name.Focus()
                Else
                    cbk_type.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub cbk_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbk_type.SelectedIndexChanged
        Try
            If cbk_type.Text = "Purchase Order" Then
                L2.Text = "Supplier Name"
                txt_name.Text = ""
            ElseIf cbk_type.Text = "Sales Order" Then
                L2.Text = "Customer Name"
                txt_name.Text = ""
            End If
            cbk_type.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub txt_name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_name.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_name.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If GRID.Visible = True Then
                    GRID.Focus()
                ElseIf txt_name.Text <> "" Then
                    dat_order.Focus()
                Else
                    txt_name.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.TextChanged
        Try
            Dim dt As New DataTable
            If txt_name.Text <> "" Then
                If cbk_type.Text = "Purchase Order" Then
                    dt = REPORTS_PROC("", txt_name.Text + "%", "", "", "", "SUPPLIER1")
                    If dt.Rows.Count <> 0 Then
                        GRID.DataSource = dt
                        GRID.Columns(1).Visible = False
                        GRID.Columns(0).Width = 200
                        GRID.Visible = True
                    Else
                        txt_name.Text = ""
                        txt_name.Focus()
                        GRID.Visible = False
                    End If
                ElseIf cbk_type.Text = "Sales Order" Then
                    dt = sales_report("", txt_name.Text + "%", "", "", "", "CUSTOMER1")
                    If dt.Rows.Count <> 0 Then
                        GRID.DataSource = dt
                        GRID.Columns(1).Visible = False
                        GRID.Columns(0).Width = 200
                        GRID.Visible = True
                    Else
                        txt_name.Text = ""
                        txt_name.Focus()
                        GRID.Visible = False
                    End If
                Else
                    txt_name.Focus()
                    GRID.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID.DoubleClick
        Try
            txt_name.Text = GRID.CurrentRow.Cells(0).Value
            name_id.Text = GRID.CurrentRow.Cells(1).Value
            txt_name.Focus()
            GRID.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_name.Text = GRID.CurrentRow.Cells(0).Value
                name_id.Text = GRID.CurrentRow.Cells(1).Value
                txt_name.Focus()
                GRID.Visible = False
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class