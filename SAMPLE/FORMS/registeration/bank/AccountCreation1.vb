Public Class AccountCreation1
    Private Sub Name_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Name_txt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Name_txt.Text <> "" Then
                    accno.Focus()
                Else
                    Name_txt.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                clear()
            End If
        Catch
            MsgBox("Please Contact Adminstrator", MsgBoxStyle.Information, "")
        End Try
    End Sub
    Private Sub bank_addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_addbtn.Click
        Try
            Dim dt As New DataTable
            If Trim(Cmb_bankname.Text) = "" Or Trim(c_type.SelectedItem) = "" Or Trim(Name_txt.Text) = "" Or Trim(accno.Text) = "" Or Trim(openbal.Text) = "" Then
                MsgBox("Please Enter The Fields", MsgBoxStyle.Information, "message")
                Cmb_bankname.Focus()
            Else
                dt = account_procedure(Trim(Cmb_bankname.Text), c_type.SelectedItem, Name_txt.Text, accno.Text, "INSERT", Today.Date.ToString("MM/dd/yyyy"), Val(openbal.Text), 0)
                If dt.Rows(0)(0) = 1 Then
                    Cmb_bankname.SelectedIndex = -1
                    c_type.SelectedIndex = -1
                    Cmb_bankname.Focus()
                    accno.Text = ""
                    Cmb_bankname.SelectedIndex = -1
                    c_type.SelectedIndex = -1
                    Name_txt.Text = ""
                    openbal.Text = ""
                    Dim dt1 As New DataTable
                    dt1 = account_procedure("", "", "", "", "VIEW", "", "", 0)
                    Acct_grid.DataSource = dt1
                Else
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        Try
            bank2()
            c_type.SelectedIndex = -1
            Cmb_bankname.Focus()
            Cmb_bankname.SelectedIndex = -1
            accno.Text = ""
            Name_txt.Text = ""
            openbal.Text = ""
            bank_edit.Text = "&EDIT"
            bank_addbtn.Enabled = True
            bank_delete.Enabled = True
            bank_edit.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AccountCreation1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connect()
            Dim dt As New DataTable
            dt = account_procedure("", "", "", "", "VIEW", "", "", 0)
            Acct_grid.DataSource = dt
            Acct_grid.Columns(0).Width = 50
            Acct_grid.Columns(1).Width = 100
            Acct_grid.Columns(2).Width = 100
            Acct_grid.Columns(3).Width = 100
            Acct_grid.Columns(4).Width = 100
            bank2()
            a1.Visible = False
            oldac.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub bank2()
        Try
            Dim dt As New DataTable
            dt = bank_proc("", "v1")
            Dim dr As DataRow
            Cmb_bankname.Items.Clear()
            For Each dr In dt.Rows()
                Cmb_bankname.Items.Add(dr("BankName"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub gridacctDetails()
        Try
            Dim dt As New DataTable
            dt.Rows.Clear()
            dt = account_procedure(group1.Text, "", "", "", "VIEW", "", "", 0)
            Acct_grid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bank_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_delete.Click
        Try
            Dim response As String
            Dim dt1 As New DataTable
            Dim DT2 As New DataTable
            DT2 = Acct_grid.DataSource
            If DT2.Rows.Count > 0 Then
                Dim index As Integer
                index = Acct_grid.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row")
                    Cmb_bankname.Focus()
                Else
                    response = MsgBox("Are you sure ", MsgBoxStyle.YesNo, "Waring")
                    If vbYes = response Then
                        dt1 = account_procedure(DT2.Rows(Acct_grid.CurrentRow.Index)(1), DT2.Rows(Acct_grid.CurrentRow.Index)(2), DT2.Rows(Acct_grid.CurrentRow.Index)(3), DT2.Rows(Acct_grid.CurrentRow.Index)(4), "DELETE", a1.Text, a2.Text, 0)
                    End If
                    Call gridacctDetails()
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                Cmb_bankname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bank_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_edit.Click
        Try
            Dim response As String
            Dim a As String
            Dim b As String
            Dim dt1 As New DataTable
            If bank_edit.Text = "UPDATE" Then
                If Trim(Cmb_bankname.Text) = "" Or Trim(c_type.SelectedItem) = "" Or Trim(Name_txt.Text) = "" Or Trim(accno.Text) = "" Or Trim(openbal.Text) = "" Then
                    MsgBox("Please Enter The Fields", MsgBoxStyle.Information, "message")
                    Cmb_bankname.Focus()
                Else
                    dt1 = account_procedure(Trim(Cmb_bankname.Text), c_type.SelectedItem, Name_txt.Text, accno.Text, Trim(oldac.Text), a1.Text, a2.Text, Val(openbal.Text))
                    If dt1.Rows(0)(0) = 3 Then
                        Cmb_bankname.Focus()
                        Cmb_bankname.SelectedIndex = -1
                        bank_edit.Text = "&EDIT"
                        bank_addbtn.Enabled = True
                        bank_delete.Enabled = True
                        Cmb_bankname.Text = ""
                        Cmb_bankname.Focus()
                        Name_txt.Text = ""
                        c_type.SelectedIndex = -1
                        accno.Text = ""
                        openbal.Text = ""
                        Call gridacctDetails()
                    Else
                        Name_txt.Text = ""
                        Name_txt.Focus()
                    End If
                End If
            Else
                Dim getdt As New DataTable
                getdt = Acct_grid.DataSource
                If getdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "Message")
                    Cmb_bankname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        c_type.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(2)
                        Name_txt.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(3)
                        accno.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(4)
                        a1.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(1)
                        Cmb_bankname.Text = a1.Text
                        a2.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(2)
                        oldac.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(4)
                        openbal.Text = getdt.Rows(Acct_grid.CurrentRow.Index)(5)
                        bank_addbtn.Enabled = False
                        bank_delete.Enabled = False
                        bank_edit.Text = "UPDATE"
                        Cmb_bankname.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                bank_addbtn.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles accno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If accno.Text <> "" Then
                    openbal.Focus()
                Else
                    accno.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                Name_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub openbal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles openbal.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If openbal.Text <> "" Then
                    If bank_edit.Text = "&EDIT" Then
                        bank_addbtn.Focus()
                    Else
                        bank_edit.Focus()
                    End If
                    bank_addbtn.Focus()
                Else
                    openbal.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub openbal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles openbal.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = openbal.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Add_BankName.ShowDialog()
            bank2()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cmb_bankname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_bankname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Cmb_bankname.Text <> "" Then
                    c_type.Focus()
                Else
                    Cmb_bankname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c_type_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c_type.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If c_type.Text <> "" Then
                    Name_txt.Focus()
                Else
                    c_type.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
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
                    clear()
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
                    clear()
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
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Name_txt.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or Name_txt.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub accno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles accno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cmb_bankname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_bankname.KeyPress
        e.Handled = True
    End Sub
End Class