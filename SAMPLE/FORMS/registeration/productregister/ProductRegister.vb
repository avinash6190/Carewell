Imports System.Data.SqlClient
Public Class ProductRegister
    Dim value As String
    Dim oldname As String
    Dim oldmat As String
    Dim oldbrand As String
    Private Sub ProductRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cls()
            materialitem()
            unititem()
            branditem()
            'enable()
            Dim view As New DataTable
            view = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
            grid.DataSource = view
            Call gridview()
            active.Checked = True
            cbk_material.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub materialitem()
        Try
            Dim dt As New DataTable
            dt = PRODUCT_PROC("%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "MAT_SRCH", "")
            Dim dr As DataRow
            cbk_material.Items.Clear()
            For Each dr In dt.Rows()
                cbk_material.Items.Add(dr("MaterialName"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub enable()
        Try
            cbk_material.Enabled = True
            cbk_brand.Enabled = True
            txt_product.Enabled = True
            cbk_wunit.Enabled = True
            txt_noofqty.Enabled = True
            cbk_unit.Enabled = True
            txt_prate.Enabled = True
            txt_srate.Enabled = True
            txt_mrp.Enabled = True
            active.Enabled = True
            expired.Enabled = True
            expired.Checked = False
            active.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub disable()
        Try
            cbk_material.Enabled = False
            cbk_brand.Enabled = False
            txt_product.Enabled = False
            txt_qty.Enabled = False
            cbk_wunit.Enabled = False
            txt_noofqty.Enabled = False
            cbk_unit.Enabled = False
            txt_prate.Enabled = False
            txt_srate.Enabled = False
            txt_mrp.Enabled = False
            active.Enabled = False
            expired.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cls()
        Try
            cbk_material.Text = ""
            cbk_brand.Text = ""
            cbk_brand.SelectedIndex = -1
            txt_product.Text = ""
            cbk_wunit.SelectedIndex = -1
            cbk_wunit.Text = ""
            txt_noofqty.Text = ""
            cbk_unit.Text = ""
            cbk_unit.SelectedIndex = -1
            txt_prate.Text = ""
            txt_srate.Text = ""
            txt_mrp.Text = ""
            txt_batch.Text = ""
            active.Checked = True
            expired.Checked = False
            edit.Text = "&EDIT"
            save.Enabled = True
            delete.Enabled = True
            cbk_material.SelectedIndex = -1
            cbk_material.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub unititem()
        Try
            Dim dt As New DataTable
            dt = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "UNIT_SRCH", "")
            Dim dr As DataRow
            cbk_unit.Items.Clear()
            cbk_wunit.Items.Clear()
            For Each dr In dt.Rows()
                cbk_unit.Items.Add(dr("UnitName"))
                cbk_wunit.Items.Add(dr("UnitName"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub branditem()
        Try
            Dim group As New DataTable
            group = PRODUCT_PROC(cbk_material.Text + "%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "BRAND_SRCH", "")
            If group.Rows.Count > 0 Then
                cbk_brand.SelectedIndex = -1
                Dim groupdr As DataRow
                cbk_brand.Items.Clear()
                For Each groupdr In group.Rows()
                    cbk_brand.Items.Add(groupdr("BrandName"))
                Next
            Else
                cbk_brand.Items.Clear()
                cbk_brand.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbk_material_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbk_material.SelectedIndexChanged
        Try
            If cbk_material.Text <> "" Then
                branditem()
                mat_view()
                cbk_material.Focus()
            Else
                cbk_material.Focus()
                Dim view As New DataTable
                view = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                grid.DataSource = view
                Call gridview()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbk_brand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_brand.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_product.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gridview()
        Try
            grid.Columns(0).Width = 100
            grid.Columns(1).Width = 100
            grid.Columns(2).Width = 350
            grid.Columns(3).Width = 100
            grid.Columns(4).Width = 100
            grid.Columns(5).Width = 100
            grid.Columns(6).Width = 100
            grid.Columns(7).Width = 100
            grid.Columns(8).Width = 100
            grid.Columns(9).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            If Trim(cbk_material.Text) = "" Or Trim(cbk_brand.Text) = "" Or Trim(txt_product.Text) = "" Or Trim(txt_qty.Text) = "" Or Trim(cbk_wunit.Text) = "" Or Trim(txt_noofqty.Text) = "" Or Trim(cbk_unit.Text) = "" Or Trim(txt_prate.Text) = "" Or Trim(txt_srate.Text) = "" Or Trim(txt_mrp.Text) = "" Or Trim(active.Text) = "" And Trim(expired.Text) = "" Or Trim(txt_batch.Text) = "" Then
                MsgBox("Enter All Fields", MsgBoxStyle.Information, "Message")
            Else
                Dim dt As New DataTable
                Dim a As String
                If active.Checked = True Then
                    a = "A"
                Else
                    a = "D"

                End If
                value = Trim(txt_product.Text) + "-" + Trim(txt_qty.Text)
                dt = PRODUCT_PROC(Trim(cbk_material.Text), Trim(cbk_brand.Text), Trim(txt_product.Text), Val(txt_qty.Text), Trim(cbk_wunit.Text), Trim(txt_noofqty.Text), Trim(cbk_unit.Text), Trim(txt_prate.Text), Trim(txt_srate.Text), Trim(txt_mrp.Text), a, value, "", "INSERT", Trim(txt_batch.Text))
                If dt.Rows(0)(0) = 1 Then
                    MsgBox("Saved Successfully", MsgBoxStyle.Information, "Message")
                    Call cls()

                Else
                    MsgBox("Already existed", MsgBoxStyle.Information, "Message")
                End If
                Dim view As New DataTable
                view = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                grid.DataSource = view
                Call gridview()

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
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If vbYes = response Then
                        dt = PRODUCT_PROC(cnt.Rows(grid.CurrentRow.Index)(0), cnt.Rows(grid.CurrentRow.Index)(1), cnt.Rows(grid.CurrentRow.Index)(2), cnt.Rows(grid.CurrentRow.Index)(3), cnt.Rows(grid.CurrentRow.Index)(4), cnt.Rows(grid.CurrentRow.Index)(5), cnt.Rows(grid.CurrentRow.Index)(6), cnt.Rows(grid.CurrentRow.Index)(7), cnt.Rows(grid.CurrentRow.Index)(8), cnt.Rows(grid.CurrentRow.Index)(9), "", "", "", "DELETE", "")
                        If dt.Rows(0)(0) = 5 Then
                            MsgBox("Successfully deleted", MsgBoxStyle.Information, "Message")
                            cls()
                        Else
                            MsgBox("Cannot Be Deleted", MsgBoxStyle.Information, "Message")
                        End If
                        Dim sup As New DataTable
                        sup = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                        grid.DataSource = sup
                        gridview()
                    Else
                    End If
                End If
            Else
                MsgBox("There Is no Row", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = grid.DataSource
            If edit.Text = "&UPDATE" Then
                If Trim(cbk_material.Text) = "" Or Trim(cbk_brand.Text) = "" Or Trim(txt_product.Text) = "" Or Trim(txt_qty.Text) = "" Or Trim(cbk_wunit.Text) = "" Or Trim(txt_noofqty.Text) = "" Or Trim(cbk_unit.Text) = "" Or Trim(txt_prate.Text) = "" Or Trim(txt_srate.Text) = "" Or Trim(txt_mrp.Text) = "" Or Trim(active.Text) = "" And Trim(expired.Text) = "" Or Trim(txt_batch.Text) = "" Then
                    MsgBox("Enter All Fields", MsgBoxStyle.Information, "Message")
                Else
                    Dim a As String
                    If active.Checked = True Then
                        a = "A"
                    Else
                        a = "D"
                    End If
                    Dim dt As New DataTable
                    dt = PRODUCT_PROC(Trim(cbk_material.Text), Trim(cbk_brand.Text), Trim(txt_product.Text), Val(txt_qty.Text), Trim(cbk_wunit.Text), Trim(txt_noofqty.Text), Trim(cbk_unit.Text), Trim(txt_prate.Text), Trim(txt_srate.Text), Trim(txt_mrp.Text), a, oldmat, oldbrand, oldname, Trim(txt_batch.Text))
                    If dt.Rows(0)(0) = 3 Then
                        MsgBox("Updated successfully", MsgBoxStyle.Information, "Message")
                        cls()
                        edit.Text = "&EDIT"
                        save.Enabled = True
                        delete.Enabled = True
                        Dim sup As New DataTable
                        sup = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                        grid.DataSource = sup
                        Call gridview()
                    ElseIf dt.Rows(0)(0) = 0 Then
                        MsgBox("Already existed", MsgBoxStyle.Information, "Message")
                        cbk_material.Focus()
                    Else
                        MsgBox("Cannot Be Updated", MsgBoxStyle.Information, "Message")
                        edit.Text = "&EDIT"
                        save.Enabled = True
                        delete.Enabled = True
                        Dim sup As New DataTable
                        sup = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                        grid.DataSource = sup
                        Call gridview()
                    End If
                End If
            Else
                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, "Message")
                    cbk_material.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Message")
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = grid.DataSource
                        i = grid.CurrentRow.Index
                        edit.Text = "&UPDATE"
                        cbk_material.Text = getdt.Rows(grid.CurrentRow.Index)(0)
                        oldmat = getdt.Rows(grid.CurrentRow.Index)(0)
                        cbk_brand.Text = getdt.Rows(grid.CurrentRow.Index)(1)
                        oldbrand = getdt.Rows(grid.CurrentRow.Index)(1)
                        txt_product.Text = getdt.Rows(grid.CurrentRow.Index)(2)
                        txt_qty.Text = getdt.Rows(grid.CurrentRow.Index)(3)
                        cbk_wunit.Text = getdt.Rows(grid.CurrentRow.Index)(4)
                        txt_noofqty.Text = getdt.Rows(grid.CurrentRow.Index)(5)
                        cbk_unit.Text = getdt.Rows(grid.CurrentRow.Index)(6)
                        txt_prate.Text = getdt.Rows(grid.CurrentRow.Index)(7)
                        txt_srate.Text = getdt.Rows(grid.CurrentRow.Index)(8)
                        txt_mrp.Text = getdt.Rows(grid.CurrentRow.Index)(9)
                        oldname = getdt.Rows(grid.CurrentRow.Index)(2)
                        txt_batch.Text = getdt.Rows(grid.CurrentRow.Index)(11).ToString
                        If getdt.Rows(grid.CurrentRow.Index)(10) = "A" Then
                            active.Checked = True
                        Else
                            expired.Checked = True
                        End If
                        save.Enabled = False
                        delete.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_mrp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mrp.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                active.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_mrp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mrp.Leave
        Try
            If Val(txt_mrp.Text) < Val(txt_srate.Text) Then
                MsgBox("MRP Rate Must Be High", MsgBoxStyle.Information, suss)
                txt_mrp.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbk_material_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_material.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                cbk_brand.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_product_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_product.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If txt_product.Text <> "" Then
                    cbk_wunit.Focus()
                Else
                    txt_product.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub cbk_wunit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_wunit.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                txt_noofqty.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_noofqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_noofqty.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                cbk_unit.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub cbk_unit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_unit.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                txt_batch.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_prate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_prate.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                txt_srate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_srate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_srate.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                txt_mrp.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
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
                    Dim ds As New product
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("product details").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), "", cnt.Rows(i)(5), cnt.Rows(i)(4) & "-" & cnt.Rows(i)(6), cnt.Rows(i)(7), cnt.Rows(i)(8), cnt.Rows(i)(9), cnt.Rows(i)(11))
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New Prd_rpt
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_noofqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_noofqty.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_prate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_prate.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_prate.Text
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

    Private Sub txt_srate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_srate.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_srate.Text
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

    Private Sub txt_mrp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mrp.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_mrp.Text
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

    Private Sub save_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles save.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
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
                    Call cls()
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
                    Call cls()
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
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductRegister_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
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
                expired.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub expired_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles expired.KeyDown
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
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_product.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_product.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_batch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_batch.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                txt_prate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    Call cls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_batch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_product_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_product.TextChanged
        Try
            If txt_product.Text <> "" And edit.Text = "&EDIT" Then
                Dim view As New DataTable
                view = PRODUCT_PROC("", "", Trim(txt_product.Text) + "%", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW2", "")
                grid.DataSource = view
                Call gridview()
            ElseIf txt_product.Text = "" And edit.Text = "&EDIT" Then
                Dim view As New DataTable
                view = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                grid.DataSource = view
                Call gridview()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mat_view()
        Try
            If cbk_material.Text <> "" And edit.Text = "&EDIT" Then
                Dim view As New DataTable
                view = PRODUCT_PROC(cbk_material.Text + "%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW3", "")
                grid.DataSource = view
                Call gridview()
            ElseIf cbk_material.Text = "" And edit.Text = "&EDIT" Then
                Dim view As New DataTable
                view = PRODUCT_PROC("", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "VIEW", "")
                grid.DataSource = view
                Call gridview()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class