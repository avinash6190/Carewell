Public Class Company_Info
    Dim dt1 As New DataTable
    Dim b As Integer
    Private Sub Company_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbtype.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged
        Try
            Dim dt As New DataTable
            dt = companyinfo("", 0, cmbtype.SelectedItem.ToString, "view")
            grid1.DataSource = dt
            grid1.Columns(0).Visible = False
            grid1.Columns(1).ReadOnly = True
            grid1.Columns(1).Width = 250
            grid1.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            If cmbtype.Text <> "" Then
                Dim dt1 As New DataTable
                Dim dtgrid = grid1.DataSource
                For i As Integer = 0 To grid1.RowCount - 1
                    Dim a = grid1.Rows(i).Cells(2).Value
                    If grid1.Rows(i).Cells(2).Value IsNot DBNull.Value Then
                        b = 0
                        dt1 = companyinfo(dtgrid.Rows(i)(1), dtgrid.Rows(i)(2), dtgrid.Rows(i)(0), "update")
                    Else
                        MsgBox("Fill All Values", MsgBoxStyle.Information, err)
                        b = 1
                        Exit For
                    End If
                Next
                If b <> 1 Then
                    If dt1.Rows(0)(0).ToString = 1 Then
                        MsgBox("Saved Successfully", MsgBoxStyle.Information, suss)
                        cmbtype.Text = ""
                        cmbtype.Focus()
                    Else
                        MsgBox("Cannot Be Saved", MsgBoxStyle.Information, err)
                        cmbtype.Focus()
                    End If
                Else
                End If
            Else
                MsgBox("Please Select Type", MsgBoxStyle.Information, err)
                cmbtype.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid1.EditingControlShowing
        Try
            If Me.grid1.CurrentCell.ColumnIndex = grid1.Columns("Value").Index And Not e.Control Is Nothing Then

                Dim tb As TextBox = CType(e.Control, TextBox)

                '---add an event handler to the TextBox control---
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox_KeyPress( _
      ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox("Enter Valid Input")
        End Try
    End Sub
    Private Function TraKey(ByVal KCode As String) As Boolean
        Try
            If KCode = 91 Then
                TraKey = False

            Else
                TraKey = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
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
    Private Sub grid1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btn_save.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        Try
            Dim dgs As DialogResult
            dgs = MsgBox("After That You Cannot Edit It.Are You Sure", MsgBoxStyle.YesNo, suss)
            If dgs = Windows.Forms.DialogResult.Yes Then
                dt1 = companyinfo("", 0, "", "conform")
                If dt1.Rows(0)(0) = 3 Then
                    MsgBox("Fill All Values.", MsgBoxStyle.Information, err)
                Else
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Company_Info_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim dt1 As New DataTable
            dt1 = companyinfo("", 0, "", "Check")
            If dt1.Rows(0)(0) <> 22 Then
            Else
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtype.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cmbtype.Text <> "" Then
                    grid1.Focus()
                Else
                    cmbtype.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_save.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                confirm.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class