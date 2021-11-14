Imports System.Data.SqlClient
Public Class clientcreation
    Dim oldname As String
    Public care As String = "CAREWELL DIAGNOSTIC"
    Sub disable()
        Try
            clientname.Enabled = False
            address.Enabled = False
            email.Enabled = False
            phno.Enabled = False
            mobno.Enabled = False
            status.Enabled = False
            tinno.Enabled = False
            cstno.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub enable()
        Try
            clientname.Enabled = True
            address.Enabled = True
            email.Enabled = True
            phno.Enabled = True
            mobno.Enabled = True
            status.Enabled = True
            cstno.Enabled = True
            tinno.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cls()
        Try
            clientname.Text = ""
            address.Text = ""
            email.Text = ""
            phno.Text = ""
            mobno.Text = ""
            active.Checked = True
            expired.Checked = False
            tinno.Text = ""
            cstno.Text = ""
            txt_dlno.Text = ""
            edit.Text = "&Edit"
            save.Enabled = True
            delete.Enabled = True
            clientname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub clientcreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clname.Visible = False
            Call enable()
            Dim sup As New DataTable
            sup = client_register("", "", "", "", "", "", "", "", "", "VIEW")
            viewgrid.DataSource = sup
            viewgrid.Columns(0).Width = 150
            viewgrid.Columns(1).Width = 200
            viewgrid.Columns(2).Width = 120
            viewgrid.Columns(3).Width = 120
            viewgrid.Columns(4).Width = 150
            viewgrid.Columns(5).Width = 110
            viewgrid.Columns(6).Width = 110
            viewgrid.Columns(7).Width = 150
            viewgrid.Columns(8).Width = 110
            viewgrid.Columns(9).Visible = False
            cls()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            If Trim(clientname.Text) = "" Or Trim(txt_dlno.Text) = "" Or Trim(address.Text) = "" Or Trim(phno.Text) = "" Or Trim(mobno.Text) = "" Or Trim(email.Text) = "" Or Trim(tinno.Text) = "" Or Trim(cstno.Text) = "" Or active.Checked = False And expired.Checked = False Then
                MsgBox("Please fill the all fields", MsgBoxStyle.Information, "Message")
            Else
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"
                End If
                Dim dt As New DataTable
                dt = client_register(Trim(clientname.Text), Trim(address.Text), Trim(phno.Text), Trim(mobno.Text), Trim(email.Text), Trim(tinno.Text), Trim(cstno.Text), a, Trim(txt_dlno.Text), "INSERT")
                If dt.Rows(0)(0) = 1 Then
                    MsgBox("saved successfully", MsgBoxStyle.Information, "Message")
                    cls()
                    clientname.Focus()
                Else
                    MsgBox("Client Name Already Exists", MsgBoxStyle.Information, "Message")
                End If
                Dim sup As New DataTable
                sup = client_register("", "", "", "", "", "", "", "", "", "VIEW")
                viewgrid.DataSource = sup
                viewgrid.Columns(0).Width = 150
                viewgrid.Columns(1).Width = 200
                viewgrid.Columns(2).Width = 120
                viewgrid.Columns(3).Width = 120
                viewgrid.Columns(4).Width = 150
                viewgrid.Columns(5).Width = 110
                viewgrid.Columns(6).Width = 110
                viewgrid.Columns(7).Width = 150
                viewgrid.Columns(8).Width = 110
                viewgrid.Columns(9).Visible = False
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
            cnt = viewgrid.DataSource
            If cnt.Rows.Count > 0 Then
                Dim index As Integer
                index = viewgrid.CurrentRow.Index
                If index < 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Information)
                    clientname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If vbYes = response Then
                        dt = client_register(cnt.Rows(viewgrid.CurrentRow.Index)(9), "", "", "", "", "", "", "", "", "DELETE")
                        If dt.Rows(0)(0) = 2 Then
                            MsgBox("Successfully deleted", MsgBoxStyle.Information, "Message")
                            cls()
                            clientname.Focus()
                        ElseIf dt.Rows(0)(0) = -1 Then
                            MsgBox("Cannot Be Deleted", MsgBoxStyle.Information, "Message")
                        End If
                        Dim sup As New DataTable
                        sup = client_register("", "", "", "", "", "", "", "", "", "VIEW")
                        viewgrid.DataSource = sup
                        viewgrid.Columns(0).Width = 150
                        viewgrid.Columns(1).Width = 200
                        viewgrid.Columns(2).Width = 120
                        viewgrid.Columns(3).Width = 120
                        viewgrid.Columns(4).Width = 150
                        viewgrid.Columns(5).Width = 110
                        viewgrid.Columns(6).Width = 110
                        viewgrid.Columns(7).Width = 150
                        viewgrid.Columns(8).Width = 110
                        viewgrid.Columns(9).Visible = False
                    Else
                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
                clientname.Focus()
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
            Dim dt As New DataTable
            cntdt = viewgrid.DataSource
            If edit.Text = "&UPDATE" Then
                If Trim(clientname.Text) = "" Or Trim(address.Text) = "" Or Trim(phno.Text) = "" Or Trim(mobno.Text) = "" Or Trim(email.Text) = "" Or Trim(tinno.Text) = "" Or Trim(cstno.Text) = "" Or active.Checked = False And expired.Checked = False Then
                    MsgBox("Please fill the all fields", MsgBoxStyle.Information, "Message")
                Else
                    Dim a As String
                    If active.Checked = True Then
                        a = "A"
                    Else
                        a = "D"
                    End If
                    dt = client_register(Trim(clientname.Text), Trim(address.Text), Trim(phno.Text), Trim(mobno.Text), Trim(email.Text), Trim(tinno.Text), Trim(cstno.Text), a, Trim(txt_dlno.Text), oldname)
                    If dt.Rows(0)(0) = 3 Then
                        MsgBox("Successfully Updated", MsgBoxStyle.Information, "Message")
                        cls()
                        clientname.Focus()
                    ElseIf dt.Rows(0)(0) = -1 Then
                        MsgBox("Client Name Is Already Exists", MsgBoxStyle.Information, "Message")
                    End If
                    edit.Text = "&Edit"
                    save.Enabled = True
                    delete.Enabled = True
                    Dim sup As New DataTable
                    sup = client_register("", "", "", "", "", "", "", "", "", "VIEW")
                    viewgrid.DataSource = sup
                    viewgrid.Columns(0).Width = 150
                    viewgrid.Columns(1).Width = 200
                    viewgrid.Columns(2).Width = 120
                    viewgrid.Columns(3).Width = 120
                    viewgrid.Columns(4).Width = 150
                    viewgrid.Columns(5).Width = 110
                    viewgrid.Columns(6).Width = 110
                    viewgrid.Columns(7).Width = 150
                    viewgrid.Columns(8).Width = 110
                    viewgrid.Columns(9).Visible = False
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "Message")
                    clientname.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = viewgrid.DataSource
                        i = viewgrid.CurrentRow.Index
                        clientname.Text = getdt.Rows(viewgrid.CurrentRow.Index)(0)
                        address.Text = getdt.Rows(viewgrid.CurrentRow.Index)(1)
                        phno.Text = getdt.Rows(viewgrid.CurrentRow.Index)(2).ToString
                        mobno.Text = getdt.Rows(viewgrid.CurrentRow.Index)(3).ToString
                        email.Text = getdt.Rows(viewgrid.CurrentRow.Index)(4).ToString
                        oldname = getdt.Rows(viewgrid.CurrentRow.Index)(9).ToString
                        tinno.Text = getdt.Rows(viewgrid.CurrentRow.Index)(5).ToString
                        cstno.Text = getdt.Rows(viewgrid.CurrentRow.Index)(6).ToString
                        txt_dlno.Text = getdt.Rows(viewgrid.CurrentRow.Index)(7).ToString
                        If getdt.Rows(viewgrid.CurrentRow.Index)(8) = "A" Then
                            active.Checked = True
                        Else
                            expired.Checked = True
                        End If
                        save.Enabled = False
                        delete.Enabled = False
                        edit.Text = "&UPDATE"
                        clientname.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, care)
        End Try
    End Sub

    Private Sub clientname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles clientname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If clientname.Text <> "" Then
                    address.Focus()
                Else
                    clientname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
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
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub phno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles phno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mobno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mobno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mobno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                email.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub phno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phno.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 44) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = phno.Text
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

    Private Sub mobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobno.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = mobno.Text
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

    Private Sub email_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles email.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                tinno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tinno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tinno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                cstno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cstno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_dlno.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Try

            Dim cnt As New DataTable
            cnt = viewgrid.DataSource
            If viewgrid.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    Dim ds As New cust_ds
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("DataTable1").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), cnt.Rows(i)(6))
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New client
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
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
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub edit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                cls()
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
                    cls()
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
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clientname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientname.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or clientname.Text.Length = 0 Then
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

    Private Sub cstno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cstno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dlno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_dlno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If edit.Text = "&UPDATE" Then
                    edit.Focus()
                Else
                    save.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dlno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dlno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class