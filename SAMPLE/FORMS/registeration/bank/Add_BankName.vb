Public Class Add_BankName

    Private Sub bank_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bank_addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_addbtn.Click
        Try
            Dim dt As New DataTable
            If Trim(bankname_txt.Text) = "" Then
                MsgBox("Please Enter The BankName", MsgBoxStyle.Information, "message")
                bankname_txt.Focus()
            Else
                bank_proc(bankname_txt.Text, "INSERT")
                bankname_txt.Text = ""
                bankname_txt.Focus()
                Dim dt1 As New DataTable
                dt1 = bank_proc("", "VIEW")
                bank_grid.DataSource = dt1
                bank_grid.Columns(0).Width = 100
                bank_grid.Columns(1).Width = 250
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Add_BankName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connect()
            Dim dt As New DataTable
            dt = bank_proc("", "VIEW")
            bank_grid.DataSource = dt
            bank_grid.Columns(0).Width = 100
            bank_grid.Columns(1).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub gridbankdetails()
        Try
            Dim dt As New DataTable
            dt.Rows.Clear()
            dt = bank_proc("", "VIEW")
            bank_grid.DataSource = dt
            bank_grid.Columns(0).Width = 100
            bank_grid.Columns(1).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bank_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_edit.Click
        Try
            Dim response As String
            Dim dt1 As New DataTable
            If bank_edit.Text = "UPDATE" Then
                If Trim(bankname_txt.Text) = "" Then
                    MsgBox("please enter the bankname", MsgBoxStyle.Information, "Message")
                    bankname_txt.Focus()
                Else
                    dt1 = bank_proc(bankname_txt.Text, oldname.Text)
                    bankname_txt.Text = ""
                    bankname_txt.Focus()
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    Call gridbankdetails()
                End If
            Else
                Dim getdt As New DataTable
                getdt = bank_grid.DataSource
                If getdt.Rows.Count <= 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Information, "Message")
                    bankname_txt.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        oldname.Text = getdt.Rows(bank_grid.CurrentRow.Index)(1)
                        bankname_txt.Text = getdt.Rows(bank_grid.CurrentRow.Index)(1)
                        bank_addbtn.Enabled = False
                        bank_edit.Text = "UPDATE"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("select which row u want to edit")
        End Try
    End Sub
    Private Sub bank_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_delete.Click
        Try
            Dim response As String
            Dim dt1 As New DataTable
            Dim DT2 As New DataTable
            DT2 = bank_grid.DataSource
            If DT2.Rows.Count > 0 Then
                Dim index As Integer
                index = bank_grid.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row")
                    bankname_txt.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                    If vbYes = response Then
                        dt1 = bank_proc(DT2.Rows(bank_grid.CurrentRow.Index)(1), "DELETE")
                    End If
                    Call gridbankdetails()
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                bankname_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bankname_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bankname_txt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If bankname_txt.Text <> "" Then
                    bank_addbtn.Focus()
                Else
                    bankname_txt.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    bankname_txt.Text = ""
                    bankname_txt.Focus()
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    bank_delete.Enabled = True
                    bank_edit.Enabled = True
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
                    bankname_txt.Text = ""
                    bankname_txt.Focus()
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    bank_delete.Enabled = True
                    bank_edit.Enabled = True
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
                    bankname_txt.Text = ""
                    bankname_txt.Focus()
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    bank_delete.Enabled = True
                    bank_edit.Enabled = True
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
                    bankname_txt.Text = ""
                    bankname_txt.Focus()
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    bank_delete.Enabled = True
                    bank_edit.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bank_exit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bank_exit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    bankname_txt.Text = ""
                    bankname_txt.Focus()
                    bank_edit.Text = "EDIT"
                    bank_addbtn.Enabled = True
                    bank_delete.Enabled = True
                    bank_edit.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bankname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bankname_txt.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or bankname_txt.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class