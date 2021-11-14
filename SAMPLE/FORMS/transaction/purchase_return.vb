Public Class purchase_return
    Dim gdt As New DataTable
    Dim wholeunit As String
    Dim subunit As String
    Dim u1qty As Decimal
    Dim u2qty As Decimal
    Dim noofqty As Decimal
    Dim PQTY1 As Decimal
    Dim PQTY2 As Decimal
    Dim rate As Integer
    Dim bill As String
    Dim sup As String
    Dim dat1 As String
    Public Sub New(ByVal a As String, ByVal b As String, ByVal c As String)
        Try
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Me.bill = b
            Me.dat1 = a
            Me.sup = c
            If bill <> "" And dat1 <> "" And sup <> "" Then
                TXT_SUP.Text = sup
                TXT_BILLNO.Text = bill
                Dim aa As String
                Dim dat As Date
                aa = dat1
                aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                dat = CDate(aa)
                cbk_date.Value = dat
                TXT_BILLNO.Enabled = False
                TXT_ADD.Enabled = False
                TXT_ADD.Text = billsearch.Rows(0).Cells(2).Value
                billsearch.Visible = False
                details()
            End If
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub details()
        Try
            gdt = purret_main(0, TXT_BILLNO.Text, TXT_SUP.Text, TXT_ADD.Text, cbk_date.Value.ToString("MM/dd/yyyy"), 0, 0, 0, "", "VIEWDETAILS")
            grid_purret.DataSource = gdt
            grid_purret.Columns(0).Width = 100
            grid_purret.Columns(1).Width = 150
            grid_purret.Columns(2).Width = 150
            grid_purret.Columns(3).Width = 100
            grid_purret.Columns(4).Width = 100
            grid_purret.Columns(5).Width = 100
            grid_purret.Columns(6).Width = 100
            grid_purret.Columns("BILLID").Visible = False
            grid_purret.Columns("NO_OF_SUBUNIT").Visible = False
            sno.Text = grid_purret.RowCount
            count()
            clearitem()
            btn_save.Visible = False
            btn_delete.Visible = False
            btn_exit.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub purchase_return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If bill = "" And dat1 = "" And sup = "" Then
                gdt.Columns.Add("SNO")
                gdt.Columns.Add("BRANDNAME")
                gdt.Columns.Add("PRODUCTNAME")
                gdt.Columns.Add("QTY")
                gdt.Columns.Add("UNIT")
                gdt.Columns.Add("PRATE")
                gdt.Columns.Add("PRICE")
                gdt.Columns.Add("BILLID")
                gdt.Columns.Add("NO_OF_SUBUNIT")
                gdt.Columns.Add("PID")
                grid_purret.DataSource = gdt
                grid_purret.Columns(0).Width = 100
                grid_purret.Columns(1).Width = 150
                grid_purret.Columns(2).Width = 150
                grid_purret.Columns(3).Width = 100
                grid_purret.Columns(4).Width = 100
                grid_purret.Columns(5).Width = 100
                grid_purret.Columns(6).Width = 100
                grid_purret.Columns("BILLID").Visible = False
                grid_purret.Columns("NO_OF_SUBUNIT").Visible = False
                grid_purret.Columns("PID").Visible = False
                reset_clear()
                ref()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ref()
        Try
            Dim billdt As New DataTable
            billdt = purret_main(0, "", "", "", 0, 0, 0, 0, "", "REFNO")
            TXT_REF.Text = billdt.Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub reset_clear()
        Try
            TXT_BILLNO.Text = ""
            TXT_BILLNO.Enabled = False
            TXT_BILLNO.Enabled = True
            TXT_SUP.Text = ""
            TXT_SUP.Enabled = True
            TXT_ADD.Text = ""
            TXT_ADD.Enabled = True
            cbk_date.Value = Today.Date
            cbk_date.Enabled = True
            txt_brandname.Text = ""
            txt_brandname.Enabled = True
            txt_productname.Text = ""
            txt_productname.Enabled = True
            txt_qty.Text = "0"
            txt_qty.Enabled = True
            CBK_unit.SelectedIndex = -1
            CBK_unit.Enabled = True
            txt_prate.Text = "0.00"
            txt_prate.Enabled = True
            txt_totprice.Text = "0.00"
            txt_totprice.Enabled = True
            gdt.Rows.Clear()
            grid_purret.DataSource = gdt
            tot_lbl.Text = "0.00"
            rd_prod.Checked = True
            rd_prod.Enabled = True
            clearitem()
            count()
            sno.Text = grid_purret.Rows.Count
            If rd_prod.Checked = True Then
                txt_retamt.Visible = False
                lbl1.Visible = False
                lbl2.Visible = False
            Else
                txt_retamt.Visible = True
                lbl1.Visible = True
                lbl2.Visible = True
                txt_retamt.Text = "0.00"
            End If
            TXT_SUP.Focus()
            ref()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub rd_prod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_prod.CheckedChanged
        Try
            If rd_prod.Checked = True Then
                txt_retamt.Visible = False
                lbl1.Visible = False
                lbl2.Visible = False
            Else
                txt_retamt.Visible = True
                lbl1.Visible = True
                lbl2.Visible = True
                txt_retamt.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub rd_cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_cash.CheckedChanged
        Try
            If rd_prod.Checked = True Then
                txt_retamt.Visible = False
                lbl1.Visible = False
                lbl2.Visible = False
            Else
                txt_retamt.Visible = True
                lbl1.Visible = True
                lbl2.Visible = True
                txt_retamt.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub clearitem()
        Try
            txt_brandname.Text = ""
            txt_productname.Text = ""
            txt_qty.Text = "0"
            txt_prate.Text = "0.00"
            txt_totprice.Text = "0.00"
            CBK_unit.SelectedIndex = -1
            CBK_unit.Items.Clear()
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub count()
        Try
            Dim price As Decimal = 0.0
            For i As Integer = 0 To grid_purret.Rows.Count - 1
                price += grid_purret.Rows(i).Cells(6).Value
            Next
            tot_lbl.Text = Format(price, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub billsearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billsearch.DoubleClick
        Try
            TXT_BILLNO.Text = billsearch.CurrentRow.Cells(1).Value
            TXT_SUP.Text = billsearch.CurrentRow.Cells(0).Value
            TXT_BILLNO.Enabled = False
            TXT_ADD.Enabled = False
            TXT_ADD.Text = billsearch.CurrentRow.Cells(2).Value
            billsearch.Visible = False
            TXT_SUP.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub billsearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles billsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                billsearch_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbk_date_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_date.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                rd_prod.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                TXT_BILLNO.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rd_prod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rd_prod.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                rd_cash.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                cbk_date.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rd_cash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rd_cash.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                rd_cash.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_brandname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_brandname.TextChanged
        Try
            If txt_brandname.Text <> "" Then
                Dim bdt As New DataTable
                bdt = PURRET_DETAILS(0, TXT_BILLNO.Text, txt_brandname.Text + "%", "", 0, "", 0, 0, 0, "Brandname")
                If bdt.Rows.Count <> 0 Then
                    brand.DataSource = bdt
                    brand.Visible = True
                    BRAND.Columns(0).Width = 150
                Else
                    brand.Visible = False
                    txt_brandname.Text = ""
                    txt_productname.Text = ""
                    CBK_unit.Items.Clear()
                    txt_qty.Text = "0"
                    txt_prate.Text = "0.00"
                    txt_totprice.Text = "0.00"
                    txt_brandname.Focus()
                    product.Visible = False
                End If

            Else
                brand.Visible = False
                txt_brandname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_brandname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_brandname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If BRAND.Visible = True Then
                    BRAND.Focus()
                ElseIf txt_brandname.Text <> "" Then
                    txt_productname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BRAND_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRAND.DoubleClick
        Try
            txt_brandname.Text = BRAND.CurrentRow.Cells(0).Value
            BRAND.Visible = False
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BRAND_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BRAND.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                BRAND_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_productname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_productname.TextChanged
        Try
            If txt_brandname.Text = "" Then
                BRAND.Visible = False
                txt_brandname.Text = ""
                txt_productname.Text = ""
                CBK_unit.Items.Clear()
                txt_qty.Text = "0"
                txt_prate.Text = "0.00"
                txt_totprice.Text = "0.00"
                txt_brandname.Focus()
                PRODUCT.Visible = False
            ElseIf txt_productname.Text <> "" Then
                Dim prod As New DataTable
                prod = PURRET_DETAILS(0, Trim(TXT_BILLNO.Text), Trim(txt_brandname.Text), Trim(txt_productname.Text) + "%", 0, "", 0, 0, "", "PRODUCTNAME")
                If prod.Rows.Count <> 0 Then
                    PRODUCT.Visible = True
                    PRODUCT.DataSource = prod
                    PRODUCT.Columns("noofqty").Visible = False
                    PRODUCT.Columns("stockqty").Visible = False
                    PRODUCT.Columns("pur_qty").Visible = False
                    PRODUCT.Columns(0).Width = 150
                Else
                    PRODUCT.Visible = False
                    txt_productname.Text = ""
                    txt_productname.Focus()
                End If
            Else
                txt_qty.Text = "0"
                CBK_unit.Items.Clear()
                txt_prate.Text = "0.00"
                txt_totprice.Text = "0.00"
                PRODUCT.Visible = False
                txt_productname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub grid_clear()
        Try
            CBK_unit.Items.Clear()
            grid_purret.DataSource = ""
            tot_lbl.Text = "0.00"
            sno.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_SUP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SUP.TextChanged
        Try
            If TXT_SUP.Text <> "" Then
                clearitem()
                Dim billdt As New DataTable
                billdt = purret_main(0, "", TXT_SUP.Text + "%", "", 0, 0, 0, 0, "", "VIEW")
                billsearch.DataSource = billdt
                If billsearch.Rows.Count > 0 Then
                    billsearch.Visible = True
                    billsearch.Columns(0).Width = 100
                    billsearch.Columns(1).Width = 100
                    billsearch.Columns(2).Width = 100
                    clearitem()
                    grid_clear()
                    TXT_SUP.Focus()
                Else
                    clearitem()
                    TXT_SUP.Text = ""
                    TXT_BILLNO.Text = ""
                    TXT_ADD.Text = ""
                    billsearch.Visible = False
                    TXT_SUP.Focus()
                End If
            Else
                billsearch.Visible = False
                TXT_BILLNO.Text = ""
                TXT_ADD.Text = ""
                clearitem()
                TXT_SUP.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_SUP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_SUP.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If billsearch.Visible = True Then
                    billsearch.Focus()
                Else
                    If TXT_SUP.Text <> "" Then
                        cbk_date.Focus()
                    Else
                        TXT_SUP.Focus()
                    End If
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PRODUCT_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCT.DoubleClick
        Try
            Dim i As Integer
            If PRODUCT.Rows.Count <> 0 Then
                txt_productname.Text = PRODUCT.CurrentRow.Cells(0).Value
                noofqty = PRODUCT.CurrentRow.Cells(3).Value
                u2qty = PRODUCT.CurrentRow.Cells(4).Value
                u1qty = Val(u2qty) / Val(noofqty)
                PQTY2 = PRODUCT.CurrentRow.Cells(5).Value
                PQTY1 = Val(PQTY2) / Val(noofqty)
                rate = PRODUCT.CurrentRow.Cells(6).Value
                txt_pid.Text = PRODUCT.CurrentRow.Cells(7).Value
                txt_prate.Text = Format(rate, "0.00")
                For i = 0 To PRODUCT.Rows.Count - 1
                    If PRODUCT.CurrentRow.Cells(1).Value <> PRODUCT.CurrentRow.Cells(2).Value Then
                        wholeunit = PRODUCT.CurrentRow.Cells(1).Value
                        subunit = PRODUCT.CurrentRow.Cells(2).Value
                        CBK_unit.Items.Add(PRODUCT.CurrentRow.Cells(1).Value)
                        CBK_unit.Items.Add(PRODUCT.CurrentRow.Cells(2).Value)
                    Else
                        wholeunit = ""
                        subunit = PRODUCT.CurrentRow.Cells(1).Value
                        CBK_unit.Items.Add(PRODUCT.CurrentRow.Cells(1).Value)
                    End If
                Next
                PRODUCT.Visible = False
                txt_productname.Focus()
            Else
                PRODUCT.Visible = False
                txt_productname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PRODUCT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PRODUCT.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                PRODUCT_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_productname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_productname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If PRODUCT.Visible = True Then
                    PRODUCT.Focus()
                Else
                    If txt_productname.Text <> "" Then
                        CBK_unit.Focus()
                    End If
                End If
            ElseIf e.KeyCode = Keys.Left Then
                If txt_productname.Text <> "" Then
                    txt_brandname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CBK_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBK_unit.SelectedIndexChanged
        Try
            If CBK_unit.SelectedItem.ToString = wholeunit Then
                txt_prate.Text = Val(rate.ToString) * Val(noofqty.ToString)
                txt_qty.Text = "0"
            Else
                txt_prate.Text = Val(rate.ToString)
                txt_qty.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CBK_unit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBK_unit.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_qty.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                txt_productname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_qty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_qty.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_qty.Text
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

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        Try
            Dim totqty As Decimal = 0
            Dim cal As Decimal = 0
            If txt_qty.Text <> "" And CBK_unit.SelectedIndex <> -1 Then
                If grid_purret.RowCount <> 0 Then
                    For gridcnt As Integer = 0 To grid_purret.RowCount - 1
                        If grid_purret.Rows(gridcnt).Cells(1).Value = txt_brandname.Text And grid_purret.Rows(gridcnt).Cells(2).Value = txt_productname.Text Then
                            totqty = Val(totqty) + grid_purret.Rows(gridcnt).Cells(8).Value
                        End If
                    Next
                End If
                cal = totqty
                If CBK_unit.SelectedItem.ToString = wholeunit.ToString Then
                    totqty = Val(totqty) / Val(noofqty)
                    totqty = Val(totqty) + Val(txt_qty.Text)
                    cal = Val(cal) / Val(noofqty)
                    Dim j As String
                    j = Format((u1qty - cal), "0.00")
                    If totqty > u1qty Then
                        MsgBox("Remaining Stock Qty is  " + j.Substring(0, j.Length - 3).ToString + " " + wholeunit.ToString, MsgBoxStyle.Information, suss)
                        If u1qty = 0 Then
                            txt_qty.Text = "0"
                            txt_qty.Focus()
                        Else
                            txt_qty.Text = ""
                            txt_qty.Focus()
                            txt_totprice.Text = Val(txt_qty.Text) * Val(txt_prate.Text)
                        End If
                    ElseIf totqty > PQTY1 Then
                        j = Format((PQTY1 - cal), "0.00")
                        MsgBox("PurchaseQty is  " + j.Substring(0, j.Length - 3).ToString + " " + wholeunit.ToString, MsgBoxStyle.Information, suss)
                        If u1qty = 0 Then
                            txt_qty.Text = "0"
                            txt_qty.Focus()
                        Else
                            txt_qty.Text = j.Substring(0, j.Length - 3)
                            txt_qty.Focus()
                            txt_totprice.Text = Val(txt_qty.Text) * Val(txt_prate.Text)
                        End If
                    Else
                        txt_totprice.Text = Val(txt_qty.Text) * Val(txt_prate.Text)
                        txt_qty.Focus()
                    End If
                ElseIf CBK_unit.SelectedItem.ToString = subunit.ToString Then
                    totqty = Val(totqty) + Val(txt_qty.Text)
                    If totqty > u2qty Then
                        MsgBox("Remaining Stock Qty is  " + (u2qty - cal).ToString + " " + subunit.ToString, MsgBoxStyle.Information, suss)
                        If u1qty = 0 Then
                            txt_qty.Text = "0"
                            txt_qty.Focus()
                        Else
                            txt_qty.Text = ""
                            txt_qty.Focus()
                            txt_totprice.Text = Val(txt_qty.Text) * Val(txt_prate.Text)
                        End If
                    ElseIf totqty > PQTY2 Then
                        MsgBox("PurchaseQty is  " + (PQTY2 - cal).ToString + " " + subunit.ToString, MsgBoxStyle.Information, suss)
                        If u1qty = 0 Then
                            txt_qty.Text = "0"
                            txt_qty.Focus()
                        Else
                            txt_qty.Text = (PQTY2 - cal).ToString
                            txt_qty.Focus()
                            txt_totprice.Text = Val(txt_qty.Text) * Val(txt_prate.Text)
                        End If
                    Else
                        txt_totprice.Text = Val(txt_qty.Text) * Val(txt_prate.Text)
                        txt_qty.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_qty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_qty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_qty.Text <> "" And txt_qty.Text <> "" Then
                    txt_totprice.Focus()
                Else
                    txt_qty.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                CBK_unit.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_totprice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_totprice.KeyDown
        Try
            Dim a As Integer
            Dim noof As Integer
            If e.KeyCode = Keys.Enter Then
                If txt_qty.Text = 0 Then
                    MsgBox("Enter Qty Value", MsgBoxStyle.Information, suss)
                ElseIf CBK_unit.SelectedIndex = -1 Then
                    MsgBox("Select UnitName", MsgBoxStyle.Information, suss)
                Else
                    If CBK_unit.SelectedItem.ToString = wholeunit.ToString Then
                        noof = Val(txt_qty.Text) * noofqty
                    Else
                        noof = Val(txt_qty.Text)
                    End If
                    For i As Integer = 0 To grid_purret.RowCount - 1
                        If grid_purret.Rows(i).Cells(1).Value = txt_brandname.Text And grid_purret.Rows(i).Cells(2).Value = txt_productname.Text And grid_purret.Rows(i).Cells(4).Value = CBK_unit.SelectedItem.ToString Then
                            grid_purret.Rows(i).Cells(3).Value = Val(txt_qty.Text) + grid_purret.Rows(i).Cells(3).Value
                            grid_purret.Rows(i).Cells(6).Value = Val(txt_totprice.Text) + grid_purret.Rows(i).Cells(6).Value
                            grid_purret.Rows(i).Cells(8).Value = Val(noof) + grid_purret.Rows(i).Cells(8).Value
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        gdt.Rows.Add(gdt.Rows.Count + 1, txt_brandname.Text, txt_productname.Text, Val(txt_qty.Text), Trim(CBK_unit.Text), Val(txt_prate.Text), Val(txt_totprice.Text), Trim(TXT_BILLNO.Text), Val(noof.ToString), Trim(txt_pid.Text))
                        grid_purret.DataSource = gdt
                        sno.Text = grid_purret.RowCount
                        count()
                        clearitem()
                    Else
                        clearitem()
                        txt_brandname.Focus()
                    End If
                End If
                count()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_retamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_retamt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_qty.Text
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

    Private Sub txt_retamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_retamt.TextChanged
        Try
            If Val(txt_retamt.Text) > Val(tot_lbl.Text) Then
                MsgBox("Paid Amt Must Be Less Than TotAmt", MsgBoxStyle.Information, suss)
                txt_retamt.Text = ""
                txt_retamt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            Dim rep As String
            Dim str As String
            Dim succ As String
            Dim a As Integer = 0
            If TXT_SUP.Text = "" Or TXT_BILLNO.Text = "" Or TXT_ADD.Text = "" Or (rd_cash.Checked = False And rd_prod.Checked = False) Or grid_purret.Rows.Count = 0 Then
                MsgBox("FILL ALL FIELD VALUES", MsgBoxStyle.Information, suss)
            Else
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    If rd_cash.Checked = True Then
                        str = "BY CASH"
                        If txt_retamt.Text = "" Or Val(txt_retamt.Text) = 0 Then
                            MsgBox("GIVE SOME CASH AMT FOR RETURN", MsgBoxStyle.Information, suss)
                            txt_retamt.Focus()
                            a = 2
                        Else
                        End If
                    ElseIf rd_prod.Checked = True Then
                        str = "BY PRODUCT"
                        txt_retamt.Text = "0.00"
                    Else
                        MsgBox("SELECT CASH OR PRODUCT", MsgBoxStyle.Information, suss)
                    End If
                    If a <> 2 Then
                        Dim DS As New DataTable
                        DS = purret_main(Trim(TXT_REF.Text), Trim(TXT_BILLNO.Text), Trim(TXT_SUP.Text), Trim(TXT_ADD.Text), cbk_date.Value.ToString("MM/dd/yyyy"), str.ToString, Val(tot_lbl.Text), Val(txt_retamt.Text), "", "INSERT")
                        If DS.Rows(0)(0) = 1 Then
                            For i As Integer = 0 To grid_purret.RowCount - 1
                                Dim DTT As New DataTable
                                DTT = PURRET_DETAILS(Trim(TXT_REF.Text), grid_purret.Rows(i).Cells(7).Value, grid_purret.Rows(i).Cells(1).Value, grid_purret.Rows(i).Cells(9).Value, grid_purret.Rows(i).Cells(3).Value, grid_purret.Rows(i).Cells(4).Value, grid_purret.Rows(i).Cells(5).Value, grid_purret.Rows(i).Cells(6).Value, "", "INSERT")
                                succ = DTT.Rows(0)(0)
                            Next
                            If succ = "1" Then
                                MsgBox("Succesfully Saved", MsgBoxStyle.Information, "Message")
                                reset_clear()
                            Else
                                MsgBox("Not Saved", MsgBoxStyle.Information, "Message")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            Dim i As Integer 'first time index
            Dim c_index As Integer
            Dim c_index_value As Integer
            Dim m As Integer
            Dim j As Integer 'second time iindex
            Dim amt As Decimal = 0
            Dim qnty As Integer = 0
            'try
            i = grid_purret.RowCount
            If i > 0 Then
                c_index = grid_purret.CurrentRow.Index
                Dim del As New Integer
                del = grid_purret.CurrentRow.Index


                grid_purret.Rows.Remove(grid_purret.CurrentRow)
                c_index_value = grid_purret.RowCount
                If c_index_value < 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Critical)
                Else
                    j = grid_purret.RowCount
                    Dim s As Integer

                    For m = c_index To grid_purret.RowCount - 1
                        s = grid_purret.Rows(c_index).Cells(0).Value

                        grid_purret.Rows(c_index).Cells(0).Value = s - 1

                        c_index = c_index + 1

                    Next
                    count()
                    sno.Text = grid_purret.RowCount
                    gdt = grid_purret.DataSource
                    gdt.AcceptChanges()

                End If
                txt_brandname.Focus()
            Else
                MessageBox.Show("Oops!There is no Row", "Warning", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_retamt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_retamt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btn_save.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_save.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_clear_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_delete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_delete.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_exit.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_totprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_totprice.TextChanged

    End Sub
End Class