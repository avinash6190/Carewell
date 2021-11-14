Imports System.Data.SqlClient
Public Class suppliercreation
    Dim oldname As String
    Public care As String = "CAREWELL DIAGNOSTICS"
    Sub gridview()
        Try
            grid.Columns(0).Width = 150
            grid.Columns(1).Width = 200
            grid.Columns(2).Width = 120
            grid.Columns(3).Width = 120
            grid.Columns(4).Width = 120
            grid.Columns(5).Width = 120
            grid.Columns(6).Width = 150
            grid.Columns(7).Width = 150
            grid.Columns(8).Width = 100
            grid.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub disabletext()
        Try
            supliername.Enabled = False
            address.Enabled = False
            email.Enabled = False
            phoneno.Enabled = False
            mobileno.Enabled = False
            tinno.Enabled = False
            diagnosticno.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub enabletext()
        Try
            supliername.Enabled = True
            address.Enabled = True
            email.Enabled = True
            phoneno.Enabled = True
            mobileno.Enabled = True
            tinno.Enabled = True
            diagnosticno.Enabled = True
            supliername.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub suppliercreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connect()
            Call disabletext()
            Dim dt As New DataTable
            dt = supplier_procedure("", "", "", "", "", "", "", "", "view", "")
            grid.DataSource = dt
            Call gridview()
            clear2()
            active.Checked = True
            expired.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            Dim sup As New DataTable
            If Trim(supliername.Text) = "" Or Trim(txt_cstno.Text) = "" Or Trim(address.Text) = "" Or Trim(mobileno.Text) = "" Or Trim(tinno.Text) = "" Or Trim(email.Text) = "" Or Trim(diagnosticno.Text) = "" Or active.Checked = False And expired.Checked = False Or Trim(phoneno.Text) = "" Then
                MsgBox("Please Enter the Fields", MsgBoxStyle.Information, "message")
                supliername.Focus()
            Else
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"
                End If
                sup = supplier_procedure(Trim(supliername.Text), Trim(address.Text), Trim(phoneno.Text), Trim(mobileno.Text), Trim(email.Text), Trim(tinno.Text), Trim(diagnosticno.Text), a, "INSERT", Trim(txt_cstno.Text))
                If sup.Rows(0)(0) = 1 Then
                    MsgBox("The supplier name is already existed", MsgBoxStyle.Information, "Message")
                    supliername.Text = ""
                    supliername.Focus()
                Else
                    MsgBox("Saved successfully", MsgBoxStyle.Information, "Message")
                    Dim dt As New DataTable
                    clear2()
                    dt = supplier_procedure("", "", "", "", "", "", "", "", "VIEW", "")
                    grid.DataSource = dt
                    Call gridview()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, care)
        End Try
    End Sub
    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = grid.DataSource
            If edit.Text = "&UPDATE" Then
                If Trim(supliername.Text) = "" Or Trim(txt_cstno.Text) = "" Or Trim(address.Text) = "" Or Trim(phoneno.Text) = "" Or Trim(mobileno.Text) = "" Or Trim(tinno.Text) = "" Or Trim(email.Text) = "" Or Trim(diagnosticno.Text) = "" Or active.Checked = False And expired.Checked = False Then
                    MsgBox("Please Enter the Fields", MsgBoxStyle.Information, "message")
                    supliername.Focus()
                Else
                    Dim a As String
                    If active.Checked = True Then
                        a = "A"
                    Else
                        a = "D"
                    End If
                    Dim dt As New DataTable
                    dt = supplier_procedure(Trim(supliername.Text), Trim(address.Text), Trim(phoneno.Text), Trim(mobileno.Text), Trim(email.Text), Trim(tinno.Text), Trim(diagnosticno.Text), a, oldname, Trim(txt_cstno.Text))
                    If dt.Rows(0)(0) = 3 Then
                        MsgBox("Successfully Updated", MsgBoxStyle.Information, "Message")
                        clear2()
                    Else
                        MsgBox("Cannot be Updated", MsgBoxStyle.Information, "Message")
                    End If
                    edit.Text = "&Edit"
                    save.Enabled = True
                    delete.Enabled = True
                    Dim sup As New DataTable
                    sup = supplier_procedure("", "", "", "", "", "", "", "", "view", "")
                    grid.DataSource = sup
                    Call gridview()
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                    supliername.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = grid.DataSource
                        i = grid.CurrentRow.Index
                        supliername.Text = getdt.Rows(grid.CurrentRow.Index)(0)
                        address.Text = getdt.Rows(grid.CurrentRow.Index)(1)
                        phoneno.Text = getdt.Rows(grid.CurrentRow.Index)(2)
                        mobileno.Text = getdt.Rows(grid.CurrentRow.Index)(3)
                        email.Text = getdt.Rows(grid.CurrentRow.Index)(4)
                        txt_cstno.Text = getdt.Rows(grid.CurrentRow.Index)(5)
                        tinno.Text = getdt.Rows(grid.CurrentRow.Index)(6)
                        diagnosticno.Text = getdt.Rows(grid.CurrentRow.Index)(7)
                        oldname = getdt.Rows(grid.CurrentRow.Index)(9)
                        If getdt.Rows(grid.CurrentRow.Index)(8) = "A" Then
                            active.Checked = True
                        Else
                            expired.Checked = True
                        End If
                        Call enabletext()
                        save.Enabled = False
                        delete.Enabled = False
                        edit.Text = "&UPDATE"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, care)
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
                    supliername.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                    If vbYes = response Then
                        dt = supplier_procedure("", "", "", "", "", "", "", cnt.Rows(grid.CurrentRow.Index)(9), "DELETE", "")
                        If dt.Rows(0)(0) = 5 Then
                            MsgBox("Successfully deleted", MsgBoxStyle.Information, "Message")
                            clear2()
                        Else
                            MsgBox("cannot be deleted", MsgBoxStyle.Information, "Message")
                            clear2()
                        End If
                        Dim sup As New DataTable
                        sup = supplier_procedure("", "", "", "", "", "", "", "", "VIEW", "")
                        grid.DataSource = sup
                        gridview()
                    Else
                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                supliername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, care)
        End Try
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Try

            Dim cnt As New DataTable
            cnt = grid.DataSource
            If grid.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    Dim ds As New supplier
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("supp").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), cnt.Rows(i)(6), "", "")
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New supplier1
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear2()
        Try
            supliername.Text = ""
            address.Text = ""
            email.Text = ""
            phoneno.Text = ""
            mobileno.Text = ""
            tinno.Text = ""
            diagnosticno.Text = ""
            txt_cstno.Text = ""
            supliername.Enabled = True
            address.Enabled = True
            email.Enabled = True
            phoneno.Enabled = True
            mobileno.Enabled = True
            tinno.Enabled = True
            save.Enabled = True
            edit.Text = "&Edit"
            delete.Enabled = True
            active.Checked = True
            expired.Checked = False
            diagnosticno.Enabled = True
            supliername.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub supliername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles supliername.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Trim(supliername.Text.ToUpper) = "OWNER" Or Trim(supliername.Text) = "owner" Or Trim(supliername.Text) = "Owner" Then
                    MsgBox("Owner Not Accepted.", MsgBoxStyle.YesNo, "Warning")
                    supliername.Text = ""
                ElseIf supliername.Text <> "" Then
                    address.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub address_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles address.KeyDown
        Try
           If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub phoneno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles phoneno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If phoneno.Text <> "" Then
                    mobileno.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mobileno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mobileno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If mobileno.Text <> "" Then
                    email.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub email_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles email.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_cstno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tinno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tinno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                diagnosticno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                clear2()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub diagnosticno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles diagnosticno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                save.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub phoneno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneno.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 44) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = phoneno.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mobileno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobileno.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = mobileno.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
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
                    clear2()
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
                    clear2()
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
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub print_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles print.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub supliername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles supliername.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or supliername.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub address_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles address.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or address.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub email_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tinno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tinno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub diagnosticno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles diagnosticno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cstno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cstno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                tinno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear2()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cstno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cstno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class