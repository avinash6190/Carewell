Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Quotation
    Dim sgdt As New DataTable
    Dim purqty As New Decimal
    Dim noofqty As New Integer
    Dim wholeunit As String
    Dim subunit As String
    Dim f As Integer
    Dim updateqty As Integer = 0
    Dim received As Decimal
    Dim vatamt As Decimal = 0
    Dim disamt As Decimal = 0
    Dim rate As Decimal
    Private Sub Quotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reset_clear()
            sgdt.Columns.Add("Sno")
            sgdt.Columns.Add("BrandName")
            sgdt.Columns.Add("ProductName")
            sgdt.Columns.Add("QTY")
            sgdt.Columns.Add("Unit")
            sgdt.Columns.Add("Rate")
            sgdt.Columns.Add("Vatper")
            sgdt.Columns.Add("vatamt")
            sgdt.Columns.Add("Disper")
            sgdt.Columns.Add("Disamt")
            sgdt.Columns.Add("Grossamt")
            sgdt.Columns.Add("Subunit_Rate")
            sgdt.Columns.Add("NetAmt")
            sgdt.Columns.Add("MRP")
            sgdt.Columns.Add("billid")
            sgdt.Columns.Add("No_Of_Subunit")
            grid_sales.DataSource = sgdt
            grid_sales.Columns(0).Width = 50
            grid_sales.Columns(1).Width = 150
            grid_sales.Columns(2).Width = 200
            grid_sales.Columns(3).Width = 75
            grid_sales.Columns(4).Width = 100
            grid_sales.Columns(5).Width = 75
            grid_sales.Columns(6).Width = 75
            grid_sales.Columns(7).Visible = False
            grid_sales.Columns(8).Width = 75
            grid_sales.Columns(9).Visible = False
            grid_sales.Columns(10).Width = 100
            grid_sales.Columns(11).Visible = False
            grid_sales.Columns(12).Width = 100
            grid_sales.Columns(13).Visible = False
            grid_sales.Columns(14).Visible = False
            grid_sales.Columns(15).Visible = False
            grid_sales.Columns("billid").Visible = False
            grid_sales.Columns("No_Of_Subunit").Visible = False
            maxbill1()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub reset_clear()
        Try
            sgdt.Rows.Clear()
            btn_save.Enabled = True
            grid_sales.DataSource = sgdt
            txt_customername.Text = ""
            txt_address.Text = ""
            txt_phone.Text = ""
            sales_date.Text = Today.Date
            txt_brandname.Text = ""
            txt_productname.Text = ""
            txt_qty.Text = ""
            cbk_unit.SelectedIndex = -1
            txt_salrate.Text = "0.00"
            txt_u2rate.Text = "0.00"
            txt_totprice.Text = "0.00"
            txt_mrp.Text = "0.00"
            txt_customername.Enabled = True
            txt_address.Enabled = True
            txt_phone.Enabled = True
            txt_brandname.Enabled = True
            sales_date.Enabled = True
            txt_billno.Enabled = True
            grid_custname.Visible = False
            GRID_PRODUCTNAME.Visible = False
            BRAND.Visible = False
            tot_discount.Text = "0.00"
            tot_vat.Text = "0.00"
            lbl_amt.Text = "0.00"
            lbl_netamt.Text = "0.00"
            clearitem()
            count()
            maxbill1()
            sno.Text = grid_sales.RowCount
            txt_billno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub maxbill1()
        Try
            Dim ds As DataSet
            ds = New DataSet
            cmd = New SqlCommand("Quotation_billno")
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            txt_billno.Text = ds.Tables(0).Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_customername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_customername.TextChanged
        Try
            If txt_customername.Text <> "" Then
                Dim CUSTDT As New DataTable
                CUSTDT = SALES_PROC("", txt_customername.Text + "%", "", "", "", "", 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", "CUSTNAME", 0, 0, "", 0, 0, "", 0, 0, "")
                If CUSTDT.Rows.Count <> 0 Then
                    grid_custname.Visible = True
                    grid_custname.DataSource = CUSTDT
                Else
                    txt_address.Text = ""
                    txt_phone.Text = ""
                    tinno.Text = ""
                    txt_customername.Focus()
                    grid_custname.Visible = False
                End If
            Else
                txt_address.Text = ""
                txt_phone.Text = ""
                tinno.Text = ""
                grid_custname.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_xit.Click
        Me.Close()
    End Sub
    Private Sub grid_custname_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_custname.DoubleClick
        Try
            If grid_custname.Rows.Count <> 0 Then
                txt_customername.Text = grid_custname.CurrentRow.Cells(1).Value
                txt_address.Text = grid_custname.CurrentRow.Cells(2).Value
                txt_phone.Text = grid_custname.CurrentRow.Cells(3).Value
                tinno.Text = grid_custname.CurrentRow.Cells(4).Value.ToString
                grid_custname.Visible = False
                txt_customername.Focus()
            Else
                txt_customername.Text = ""
                txt_phone.Text = ""
                txt_address.Text = ""
                tinno.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid_custname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_custname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                grid_custname_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                grid_custname.Visible = False
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_customername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_customername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_customername.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_customername.Text <> "" Then
                    If grid_custname.Visible = True Then
                        grid_custname.Focus()
                    ElseIf txt_address.Text = "" Then
                        txt_address.Focus()
                    ElseIf txt_phone.Text = "" Then
                        txt_phone.Focus()
                    Else
                        sales_date.Focus()
                    End If
                Else
                    txt_customername.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sales_date_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sales_date.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                txt_customername.Focus()
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

    Private Sub txt_brandname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_brandname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If BRAND.Visible = True Then
                    BRAND.Focus()
                Else
                    txt_productname.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                sales_date.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
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
            If txt_customername.Text = "" Then
                txt_customername.Focus()
            ElseIf txt_address.Text = "" Then
                txt_address.Focus()
            ElseIf txt_phone.Text = "" Then
                txt_phone.Focus()
            ElseIf txt_brandname.Text <> "" Then
                Dim bdt As DataTable
                bdt = PRODUCT_PROC(txt_brandname.Text + "%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "BRANDNAME", "")
                If bdt.Rows.Count <> 0 Then
                    BRAND.Visible = True
                    BRAND.DataSource = bdt
                    BRAND.Columns(0).Width = 150
                Else
                    BRAND.Visible = False
                    txt_brandname.Text = ""
                    txt_brandname.Focus()
                End If
            Else
                BRAND.Visible = False
                txt_productname.Text = ""
                GRID_PRODUCTNAME.Visible = False
                txt_qty.Text = ""
                cbk_unit.Items.Clear()
                txt_mrp.Text = "0.00"
                txt_salrate.Text = "0.00"
                txt_u2rate.Text = "0.00"
                txt_totprice.Text = "0.00"
                txt_salrate.Text = "0.00"
                txt_brandname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_productname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_productname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If GRID_PRODUCTNAME.Visible = True Then
                    GRID_PRODUCTNAME.Focus()
                Else
                    cbk_unit.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_qty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_qty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_qty.Text = "" Or txt_qty.Text = "0" Then
                    txt_qty.Focus()
                Else
                    txt_u2rate.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                cbk_unit.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbk_unit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_unit.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_qty.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                txt_productname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_u2rate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_u2rate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_u2rate.Text = "" Or txt_u2rate.Text = "0.00" Then
                    txt_u2rate.Focus()
                Else
                    txt_vat.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BRAND_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BRAND.DoubleClick
        Try
            If BRAND.Rows.Count <> 0 Then
                txt_brandname.Text = BRAND.CurrentRow.Cells(0).Value
                BRAND.Visible = False
                txt_brandname.Focus()
            Else
                txt_brandname.Text = ""
                BRAND.Visible = False
                txt_brandname.Focus()
            End If
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
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_brandname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_address_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_address.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_address.Text <> "" Then
                    txt_phone.Focus()
                Else
                    txt_address.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_customername.Focus()
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

    Private Sub txt_phone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_phone.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                tinno.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                txt_phone.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_productname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_productname.TextChanged
        Try
            If txt_brandname.Text <> "" Then
                Dim pdt As DataTable
                pdt = PURCHASE_PROC("", 0, txt_brandname.Text, txt_productname.Text + "%", Today.Date.ToString("MM/dd/yyyy"), Today.Date.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, Today.Date.ToString("MM/dd/yyyy"), 0, "PRD_SRCH", 0, 0, 0, 0, "", 0, 0, "", 0)
                If pdt.Rows.Count <> 0 Then
                    GRID_PRODUCTNAME.DataSource = pdt
                    GRID_PRODUCTNAME.Visible = True
                    GRID_PRODUCTNAME.Columns(0).Width = 100
                    GRID_PRODUCTNAME.Columns(1).Width = 200
                    GRID_PRODUCTNAME.Columns(2).Width = 100
                    GRID_PRODUCTNAME.Columns(3).Width = 100
                    GRID_PRODUCTNAME.Columns(4).Width = 100
                    GRID_PRODUCTNAME.Columns(7).Visible = False
                Else
                    GRID_PRODUCTNAME.Visible = False
                    txt_productname.Text = ""
                    txt_productname.Focus()
                End If
            Else
                txt_productname.Text = ""
                txt_brandname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_PRODUCTNAME_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID_PRODUCTNAME.DoubleClick
        Try
            Dim i As Integer
            If GRID_PRODUCTNAME.Rows.Count <> 0 Then
                txt_productname.Text = GRID_PRODUCTNAME.CurrentRow.Cells(1).Value
                txt_salrate.Text = Format(GRID_PRODUCTNAME.CurrentRow.Cells(2).Value, "0.00")
                txt_u2rate.Text = Format(GRID_PRODUCTNAME.CurrentRow.Cells(2).Value, "0.00")
                rate = Format(GRID_PRODUCTNAME.CurrentRow.Cells(2).Value, "0.00")
                txt_mrp.Text = GRID_PRODUCTNAME.CurrentRow.Cells(6).Value
                noofqty = GRID_PRODUCTNAME.CurrentRow.Cells(7).Value
                cbk_unit.Items.Clear()
                For i = 0 To GRID_PRODUCTNAME.Rows.Count - 1
                    If GRID_PRODUCTNAME.CurrentRow.Cells(3).Value <> GRID_PRODUCTNAME.CurrentRow.Cells(4).Value Then
                        wholeunit = GRID_PRODUCTNAME.CurrentRow.Cells(3).Value
                        subunit = GRID_PRODUCTNAME.CurrentRow.Cells(4).Value
                        cbk_unit.Items.Add(GRID_PRODUCTNAME.CurrentRow.Cells(3).Value)
                        cbk_unit.Items.Add(GRID_PRODUCTNAME.CurrentRow.Cells(4).Value)
                    Else
                        wholeunit = ""
                        subunit = GRID_PRODUCTNAME.CurrentRow.Cells(3).Value
                        cbk_unit.Items.Add(GRID_PRODUCTNAME.CurrentRow.Cells(3).Value)
                    End If
                Next
                GRID_PRODUCTNAME.Visible = False
                txt_productname.Focus()
            Else
                txt_productname.Text = ""
                txt_productname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_PRODUCTNAME_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_PRODUCTNAME.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GRID_PRODUCTNAME_DoubleClick(Nothing, Nothing)
                txt_productname.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                GRID_PRODUCTNAME.Visible = False
                txt_productname.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_u2rate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_u2rate.TextChanged
        Try
            If cbk_unit.Text = wholeunit Then
                txt_salrate.Text = Val(txt_u2rate.Text) * noofqty
            Else
                txt_salrate.Text = txt_u2rate.Text
            End If
            If txt_qty.Text <> "" Then
                If IsNumeric(txt_qty.Text) = True Then
                    If txt_salrate.Text <> "" Then
                        If IsNumeric(txt_qty.Text) = True Then
                            txt_totprice.Text = Val(txt_salrate.Text) * Val(txt_qty.Text)
                            Dim totprice As Decimal = 0.0
                            totprice = txt_totprice.Text
                            txt_totprice.Text = Format(totprice, "0.00")
                            vatamount()
                            Discount1()
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_totprice.Text = Format(totprice, "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        Try
            If txt_qty.Text <> "" Then
                If IsNumeric(txt_qty.Text) = True Then
                    If txt_salrate.Text <> "" Then
                        If IsNumeric(txt_qty.Text) = True Then
                            txt_totprice.Text = Val(txt_salrate.Text) * Val(txt_qty.Text)
                            Dim totprice As Decimal = 0.0
                            totprice = txt_totprice.Text
                            txt_totprice.Text = Format(totprice, "0.00")
                            vatamount()
                            Discount1()
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_totprice.Text = Format(totprice, "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub cbk_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbk_unit.SelectedIndexChanged
        Try
            If cbk_unit.Text = wholeunit Then
                txt_u2rate.Text = Format(rate, "0.00")
                txt_salrate.Text = Val(txt_u2rate.Text) * noofqty
            Else
                txt_u2rate.Text = Format(rate, "0.00")
                txt_salrate.Text = txt_u2rate.Text
            End If
            Quantity()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_totprice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_totprice.KeyDown
        Try
            Dim GR As Integer
            Dim a As Integer
            Dim noof As Integer
            GR = (Val(txt_qty.Text) * Val(txt_salrate.Text))
            If e.KeyCode = Keys.Enter Then
                If txt_qty.Text = 0 Then
                    MsgBox("Select Qty Value", MsgBoxStyle.Information, suss)
                ElseIf cbk_unit.SelectedIndex = -1 Then
                    MsgBox("Select UnitName", MsgBoxStyle.Information, suss)
                Else
                    If cbk_unit.SelectedItem.ToString = wholeunit.ToString Then
                        noof = Val(txt_qty.Text) * noofqty
                    Else
                        noof = Val(txt_qty.Text)
                    End If
                    Txt1.Text = noof
                    For i As Integer = 0 To grid_sales.RowCount - 1
                        If grid_sales.Rows(i).Cells(1).Value = txt_brandname.Text And grid_sales.Rows(i).Cells(2).Value = txt_productname.Text And grid_sales.Rows(i).Cells(4).Value = cbk_unit.SelectedItem.ToString Then
                            grid_sales.Rows(i).Cells(3).Value = Val(txt_qty.Text) + grid_sales.Rows(i).Cells(3).Value
                            grid_sales.Rows(i).Cells(6).Value = Val(txt_vat.Text) + grid_sales.Rows(i).Cells(6).Value
                            grid_sales.Rows(i).Cells(7).Value = Val(vatamt.ToString) + grid_sales.Rows(i).Cells(7).Value
                            grid_sales.Rows(i).Cells(8).Value = Val(TXT_DIS.Text) + grid_sales.Rows(i).Cells(8).Value
                            grid_sales.Rows(i).Cells(9).Value = Val(disamt.ToString) + grid_sales.Rows(i).Cells(9).Value
                            grid_sales.Rows(i).Cells(12).Value = Val(txt_totprice.Text) + grid_sales.Rows(i).Cells(12).Value
                            grid_sales.Rows(i).Cells(15).Value = Val(Txt1.Text) + grid_sales.Rows(i).Cells(15).Value
                            grid_sales.Rows(i).Cells(10).Value = Val(GR.ToString) + grid_sales.Rows(i).Cells(3).Value
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        sgdt.Rows.Add(sgdt.Rows.Count + 1, txt_brandname.Text, txt_productname.Text, Val(txt_qty.Text), Trim(cbk_unit.Text), Val(txt_salrate.Text), Val(txt_vat.Text), Val(vatamt.ToString), Val(TXT_DIS.Text), Val(disamt.ToString), Val(GR.ToString), Val(txt_u2rate.Text), Val(txt_totprice.Text), Val(txt_mrp.Text), Trim(txt_billno.Text), Val(Txt1.Text))
                        grid_sales.DataSource = sgdt
                        sno.Text = grid_sales.RowCount
                        count()
                        clearitem()
                    Else
                        clearitem()
                        txt_brandname.Focus()
                    End If
                End If
                count()
            ElseIf e.KeyCode = Keys.Escape Then

            ElseIf e.KeyCode = Keys.Left Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub count()
        Try
            Dim qty As Integer = 0
            Dim net As Decimal = 0.0
            Dim vattot As Decimal = 0.0
            Dim distot As Decimal = 0.0
            Dim vatamt As Decimal = 0.0
            Dim disamt As Decimal = 0.0
            Dim gross As Decimal = 0.0
            For i As Integer = 0 To grid_sales.Rows.Count - 1
                qty += grid_sales.Rows(i).Cells(3).Value
                gross += grid_sales.Rows(i).Cells(10).Value
                vattot += grid_sales.Rows(i).Cells(6).Value
                distot += grid_sales.Rows(i).Cells(8).Value
                vatamt += grid_sales.Rows(i).Cells(7).Value
                disamt += grid_sales.Rows(i).Cells(9).Value
                net += grid_sales.Rows(i).Cells(12).Value
            Next
            lbl_qty.Text = qty
            lbl_amt.Text = Format(gross, "0.00")
            tot_vat.Text = Format(System.Math.Round(Val(vatamt)), "0.00")
            tot_discount.Text = Format(System.Math.Round(Val(disamt)), "0.00")
            lblvat.Text = Format(vattot, "0.00")
            lbldis.Text = Format(distot, "0.00")
            lbl_netamt.Text = Format(net, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub clearitem()
        Try
            txt_brandname.Text = ""
            txt_productname.Text = ""
            txt_qty.Text = "0"
            txt_salrate.Text = "0.00"
            txt_u2rate.Text = "0.00"
            txt_totprice.Text = "0.00"
            txt_mrp.Text = "0.00"
            cbk_unit.SelectedIndex = -1
            txt_vat.Text = "0"
            TXT_DIS.Text = "0"
            lblvat.Text = ""
            lbldis.Text = ""
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
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

    Private Sub txt_u2rate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_u2rate.KeyPress
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
    Private Sub txt_vat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            f = Val(lbl_amt.Text) * Val(tot_vat.Text) / 100
            lbl_netamt.Text = (Val(lbl_amt.Text) + Val(f)) - Val(tot_discount.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            f = Val(lbl_amt.Text) * Val(tot_vat.Text) / 100
            lbl_netamt.Text = (Val(lbl_amt.Text) + Val(f)) - Val(tot_discount.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_vat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                If tot_vat.Text = "0.00" Then
                    tot_vat.Focus()
                Else
                    tot_discount.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_discount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                btn_save.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                tot_vat.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            Dim rep As String
            Dim vt As Decimal = 0
            Dim billdt As New DataTable
            Dim succ As String
            If txt_customername.Text = "" Or txt_billno.Text = "" Or txt_address.Text = "" Or txt_phone.Text = "" Or tinno.Text = "" Or grid_sales.Rows.Count = 0 Or tot_vat.Text = "" Or tot_discount.Text = "" Then
                MsgBox("Please Fill the fields", MsgBoxStyle.Information)
                txt_billno.Focus()
            Else
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    If btn_save.Text = "&SAVE" Then
                        Dim ds As New DataTable
                        ds = quotation_proc(Trim(txt_billno.Text), Trim(txt_customername.Text), Trim(txt_address.Text), Trim(txt_phone.Text), sales_date.Value.ToString("MM/dd/yyyy"), Trim(tinno.Text), Val(lbl_amt.Text), Val(lblvat.Text), Val(tot_vat.Text), Val(lbldis.Text), Val(tot_discount.Text), Val(lbl_netamt.Text), 0, "", "", "INSERT")
                        If ds.Rows(0)(0) = 1 Then
                            For i As Integer = 0 To grid_sales.RowCount - 1
                                Dim DTT As New DataTable
                                DTT = quotation_DETAILS(grid_sales.Rows(i).Cells(14).Value, grid_sales.Rows(i).Cells(1).Value, grid_sales.Rows(i).Cells(2).Value, grid_sales.Rows(i).Cells(3).Value, grid_sales.Rows(i).Cells(4).Value, grid_sales.Rows(i).Cells(5).Value, grid_sales.Rows(i).Cells(11).Value, grid_sales.Rows(i).Cells(6).Value, grid_sales.Rows(i).Cells(7).Value, grid_sales.Rows(i).Cells(8).Value, grid_sales.Rows(i).Cells(9).Value, grid_sales.Rows(i).Cells(10).Value, grid_sales.Rows(i).Cells(12).Value, grid_sales.Rows(i).Cells(13).Value, "INSERT")
                                succ = DTT.Rows(0)(0)
                            Next
                            If succ = "1" Then
                                MsgBox("Succesfully Saved", MsgBoxStyle.Information, "Message")
                                quotationbill()
                                reset_clear()
                                maxbill1()
                            Else
                                MsgBox("Not Saved", MsgBoxStyle.Information, "Message")
                            End If
                        End If
                    End If
                Else
                    If txt_customername.Text = "" Or txt_address.Text = "" Then
                        MsgBox("Please Select SupplierName", MsgBoxStyle.Information, "Message")
                        txt_customername.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub quotationbill()
        Try
            Dim cnt As New DataTable
            cnt = grid_sales.DataSource
            Dim cmd1 As New SqlCommand
            Dim ds As New quotation_ds
            Dim da1 As New SqlDataAdapter
            Dim lett As String
            lett = RupeesToWord(Trim(lbl_netamt.Text.ToString))
            For i As Integer = 0 To cnt.Rows.Count - 1
                ds.Tables("quodetails").Rows.Add(Trim(txt_billno.Text), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), cnt.Rows(i)(10), cnt.Rows(i)(6), cnt.Rows(i)(8), cnt.Rows(i)(12), "", "")
            Next
            ds.Tables("quomain").Rows.Add(Trim(txt_billno.Text), sales_date.Value.ToString("dd/MM/yyyy"), "", "", "", "", "", "", Val(lbl_amt.Text), Val(lblvat.Text), Val(tot_vat.Text), Val(lbldis.Text), Val(tot_discount.Text), Val(lbl_netamt.Text), lett.ToString)
            cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2 from Organization", con)
            da1 = New SqlDataAdapter(cmd)
            da1.Fill(ds.Tables("companydetails"))
            cmd1 = New SqlCommand("select name as Name,address as Address,tinno as TinNo1,cstno as CstNo1,phno as Phone,mobno as Mobile,'' as sample,'' as sample1 from clientregister where name='" & txt_customername.Text & "' and address='" & txt_address.Text & "'", con)
            da1 = New SqlDataAdapter(cmd1)
            da1.Fill(ds.Tables("Customer"))
            Dim dc1 As New QuoBill
            dc1.SetDataSource(ds)
            ReportForm.ReportViewer.ReportSource = dc1
            ReportForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_billno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If billsearch.Visible = True Then
                    billsearch.Focus()
                Else
                    Dim view As DataTable
                    If txt_billno.Text <> "" Then
                        view = quotation_proc(txt_billno.Text + "%", txt_customername.Text, txt_address.Text, txt_phone.Text, sales_date.Value.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, 0, 0, "", "", "VIEW")
                        billsearch.DataSource = view
                        If billsearch.RowCount > 0 Then
                            billsearch.Visible = True
                            billsearch.Columns(0).Width = 100
                            billsearch.Columns(1).Width = 200
                            billsearch.Columns(2).Width = 250
                            billsearch.Columns(3).Width = 100
                            billsearch.Columns(4).Width = 100
                            billsearch.Columns(5).Width = 150
                            billsearch.Columns(6).Width = 100
                            billsearch.Columns(7).Width = 100
                            billsearch.Columns(9).Width = 100
                            billsearch.Columns(8).Width = 100
                            billsearch.Columns(10).Width = 100
                            txt_billno.Focus()
                        Else
                            txt_customername.Focus()
                            btn_save.Text = "&SAVE"
                            sgdt.Rows.Clear()
                            grid_sales.DataSource = sgdt
                        End If
                    Else
                        txt_customername.Focus()
                        txt_address.Text = ""
                        txt_customername.Text = ""
                        btn_save.Text = "&SAVE"
                        sgdt.Rows.Clear()
                        grid_sales.DataSource = sgdt
                    End If
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_billno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_billno.Leave
        Try
            If billsearch.Visible = True Then
                billsearch.Focus()
            Else
                Dim view As DataTable
                If txt_billno.Text <> "" Then
                    view = quotation_proc(txt_billno.Text + "%", txt_customername.Text, txt_address.Text, txt_phone.Text, sales_date.Value.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, 0, 0, "", "", "VIEW")
                    billsearch.DataSource = view
                    If billsearch.RowCount > 0 Then
                        billsearch.Visible = True
                        billsearch.Columns(0).Width = 100
                        billsearch.Columns(1).Width = 200
                        billsearch.Columns(2).Width = 250
                        billsearch.Columns(3).Width = 100
                        billsearch.Columns(4).Width = 100
                        billsearch.Columns(5).Width = 150
                        billsearch.Columns(6).Width = 100
                        billsearch.Columns(7).Width = 100
                        billsearch.Columns(9).Width = 100
                        billsearch.Columns(8).Width = 100
                        billsearch.Columns(10).Width = 100
                        txt_billno.Focus()
                    Else
                        txt_customername.Focus()
                        btn_save.Text = "&SAVE"
                        sgdt.Rows.Clear()
                        grid_sales.DataSource = sgdt
                    End If
                Else
                    txt_customername.Focus()
                    txt_address.Text = ""
                    txt_customername.Text = ""
                    btn_save.Text = "&SAVE"
                    sgdt.Rows.Clear()
                    grid_sales.DataSource = sgdt
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billno.TextChanged
        Try
            billsearch.Visible = False
            txt_billno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billsearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billsearch.DoubleClick
        Try
            Dim dat As Date
            Dim aa As String
            aa = billsearch.CurrentRow.Cells(4).Value
            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 2)
            dat = CDate(aa)
            sales_date.Value = dat
            sales_date.Enabled = False
            txt_billno.Text = billsearch.CurrentRow.Cells(0).Value
            txt_customername.Text = billsearch.CurrentRow.Cells(1).Value
            txt_address.Text = billsearch.CurrentRow.Cells(2).Value
            txt_phone.Text = billsearch.CurrentRow.Cells(3).Value
            txt_billno.Enabled = False
            txt_customername.Enabled = False
            txt_address.Enabled = False
            txt_phone.Enabled = False
            tinno.Enabled = False
            tinno.Text = billsearch.CurrentRow.Cells(4).Value
            sales_date.Text = billsearch.CurrentRow.Cells(5).Value
            lbl_amt.Text = billsearch.CurrentRow.Cells(6).Value
            tot_vat.Text = billsearch.CurrentRow.Cells(7).Value
            tot_discount.Text = billsearch.CurrentRow.Cells(8).Value
            lbl_netamt.Text = billsearch.CurrentRow.Cells(9).Value
            received = billsearch.CurrentRow.Cells(10).Value
            txt_billno.Enabled = False
            btn_save.Enabled = False
            details()
            billsearch.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub details()
        Try
            Dim k As Integer
            If billsearch.Rows.Count > 0 Then
                sgdt = quotation_DETAILS(Trim(txt_billno.Text), "", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, "VIEWDETAILS")
                grid_sales.DataSource = sgdt
                grid_sales.Columns(0).Width = 100
                grid_sales.Columns(1).Width = 200
                grid_sales.Columns(2).Width = 200
                grid_sales.Columns(3).Width = 100
                grid_sales.Columns(4).Width = 100
                grid_sales.Columns(5).Width = 150
                grid_sales.Columns(6).Visible = False
                grid_sales.Columns(7).Width = 150
                grid_sales.Columns(8).Visible = False
                grid_sales.Columns("billid").Visible = False
                grid_sales.Columns("No_Of_Subunit").Visible = False
                sno.Text = grid_sales.RowCount
                clearitem()
                count()
                btn_save.Text = "&SAVE"
                grid_custname.Visible = False
                billsearch.Visible = False
                For k = 0 To grid_sales.Rows.Count - 1
                    updateqty = Val(updateqty) + grid_sales.Rows(k).Cells(10).Value
                Next

            Else
                MsgBox("No Row Selected")
            End If
            count()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billsearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles billsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                billsearch_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                billsearch.Visible = False
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
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
            i = grid_sales.RowCount
            If i > 0 Then
                c_index = grid_sales.CurrentRow.Index
                Dim del As New Integer
                del = grid_sales.CurrentRow.Index


                grid_sales.Rows.Remove(grid_sales.CurrentRow)
                c_index_value = grid_sales.RowCount
                If c_index_value < 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Critical)
                Else
                    j = grid_sales.RowCount
                    Dim s As Integer

                    For m = c_index To grid_sales.RowCount - 1
                        s = grid_sales.Rows(c_index).Cells(0).Value

                        grid_sales.Rows(c_index).Cells(0).Value = s - 1

                        c_index = c_index + 1

                    Next
                    count()
                    sno.Text = grid_sales.RowCount
                    sgdt = grid_sales.DataSource
                    sgdt.AcceptChanges()
                End If
                txt_brandname.Focus()
            Else
                MessageBox.Show("Oops!There is no Row", "Warning", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_vat_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_vat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_vat.Text <> "" Then
                    TXT_DIS.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_u2rate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_DIS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_DIS.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If TXT_DIS.Text <> "" Then
                    txt_totprice.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_vat.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_vat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_vat.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_vat.Text
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

    Private Sub TXT_DIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DIS.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = TXT_DIS.Text
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
    Sub Quantity()
        Try
            If txt_qty.Text <> "" Then
                If IsNumeric(txt_qty.Text) = True Then
                    If txt_salrate.Text <> "" Then
                        If IsNumeric(txt_qty.Text) = True Then
                            txt_totprice.Text = Val(txt_salrate.Text) * Val(txt_qty.Text)
                            Dim totprice As Decimal = 0.0
                            totprice = txt_totprice.Text
                            txt_totprice.Text = Format(totprice, "0.00")
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_totprice.Text = Format(totprice, "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub vatamount()
        Try
            If txt_vat.Text = "" Or Val(txt_vat.Text) = 0 Then
                lbl_netamt2.Text = txt_totprice.Text
                vatamt = 0
            Else
                vatamt = Val(txt_totprice.Text) * (Val(txt_vat.Text) / 100)
                lbl_netamt2.Text = Val(txt_totprice.Text) + vatamt
            End If
            lbl_netamt2.Text = Format(System.Math.Round(Val(lbl_netamt2.Text)), "0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Discount1()
        Try
            If TXT_DIS.Text = "" Or Val(TXT_DIS.Text) = 0 Then
                totdis.Text = lbl_netamt2.Text
                disamt = 0
            Else
                disamt = Val(lbl_netamt2.Text) * (Val(TXT_DIS.Text) / 100)
                totdis.Text = Val(lbl_netamt2.Text) - disamt
            End If
            txt_totprice.Text = Format(System.Math.Round(Val(totdis.Text)), "0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_vat_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_vat.TextChanged
        Try
            Quantity()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub TXT_DIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DIS.TextChanged
        Try
            Quantity()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub tinno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tinno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                sales_date.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                txt_phone.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            clientcreation.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ProductRegister.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_customername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_customername.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_customername.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_address_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_address.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_address.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
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

    Private Sub txt_billno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class