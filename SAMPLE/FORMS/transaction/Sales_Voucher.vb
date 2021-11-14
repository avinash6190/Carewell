Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Sales_Voucher
    Dim sgdt As New DataTable
    Dim purqty As New Decimal
    Dim noofqty As New Integer
    Dim wholeunit As String
    Dim subunit As String
    Dim f As Integer
    Dim updatedt As DataTable
    Dim received As Decimal
    Dim mainvat As Decimal
    Dim maindis As Decimal = 0
    Dim maincst As Decimal = 0
    Dim bvatp As Integer
    Dim bvatamt As Decimal
    Dim bvattype As String
    Dim bdisp As Integer
    Dim bdisamt As Decimal
    Dim bdistype As String
    Dim bcstp As Integer
    Dim bcstamt As Decimal
    Dim bcsttype As String
    Dim vatamt As Decimal = 0
    Dim cstamt As Decimal = 0
    Dim disamt As Decimal = 0
    Dim billno As String
    Dim rate As Decimal
    Public Sub New(ByVal a As String)
        Try
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Me.billno = a
            If billno <> "" Then
                txt_billno.Text = billno
                txt_billno_Leave(Nothing, Nothing)
                link()
            End If
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub link()
        Try
            Dim dat As Date
            Dim aa As String
            Dim str As String
            Dim dtype As String
            Dim vtype As String
            Dim ctype1 As String
            aa = billsearch.Rows(0).Cells(4).Value
            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 2)
            dat = CDate(aa)
            sales_date.Value = dat
            sales_date.Enabled = False
            txt_billno.Text = billsearch.Rows(0).Cells(0).Value
            txt_customername.Text = billsearch.Rows(0).Cells(1).Value
            txt_address.Text = billsearch.Rows(0).Cells(2).Value
            txt_phone.Text = billsearch.Rows(0).Cells(3).Value
            txt_billno.ReadOnly = True
            txt_customername.Enabled = False
            txt_address.Enabled = False
            txt_phone.Enabled = False
            str = billsearch.Rows(0).Cells(5).Value
            If str = "Cash" Then
                rd_cash.Checked = True
                rd_cash.Enabled = False
                rd_credit.Enabled = False
            Else
                rd_credit.Checked = True
                rd_credit.Enabled = False
                rd_cash.Enabled = False
            End If
            lbl_amt.Text = billsearch.Rows(0).Cells(6).Value
            tot_vat.Text = billsearch.Rows(0).Cells(7).Value
            tot_discount.Text = billsearch.Rows(0).Cells(8).Value
            lbl_netamt.Text = billsearch.Rows(0).Cells(9).Value
            received = billsearch.Rows(0).Cells(10).Value
            txt_orderby.Text = billsearch.Rows(0).Cells(11).Value
            txt_orderby.Enabled = False
            txt_pay.Text = billsearch.Rows(0).Cells(12).Value
            txt_pay.Enabled = False
            Dim dat1 As Date
            Dim aa1 As String
            aa1 = billsearch.Rows(0).Cells(13).Value
            aa1 = aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2) & "/" & aa1.Substring(6, 4)
            dat1 = CDate(aa1)
            dat_order.Value = dat1
            dat_order.Enabled = False
            txt_dispatch.Text = billsearch.Rows(0).Cells(14).Value
            txt_dispatch.Enabled = False
            txt_dc.Text = billsearch.Rows(0).Cells(15).Value
            txt_dc.Enabled = False
            Dim dat2 As Date
            Dim aa2 As String
            aa2 = billsearch.Rows(0).Cells(16).Value
            aa2 = aa2.Substring(3, 2) & "/" & aa2.Substring(0, 2) & "/" & aa2.Substring(6, 4)
            dat2 = CDate(aa2)
            dat_dc.Value = dat2
            dat_dc.Enabled = False
            txt_billno.ReadOnly = True
            details2()
            vtype = billsearch.Rows(0).Cells(17).Value.ToString
            If vtype = "Percent" Then
                ck_vat.Checked = True
                txt_billvat.Text = billsearch.Rows(0).Cells(18).Value.ToString
            Else
                ck_vat.Checked = False
                txt_billvat.Text = billsearch.Rows(0).Cells(18).Value.ToString
            End If
            dtype = billsearch.Rows(0).Cells(21).Value.ToString
            If dtype = "Percent" Then
                ck_dis.Checked = True
                txt_billdis.Text = billsearch.Rows(0).Cells(22).Value.ToString
            Else
                ck_dis.Checked = False
                txt_billdis.Text = billsearch.Rows(0).Cells(22).Value.ToString
            End If
            ctype1 = billsearch.Rows(0).Cells(19).Value.ToString
            If dtype = "Percent" Then
                ck_cst.Checked = True
                txt_billcst.Text = billsearch.Rows(0).Cells(20).Value.ToString
            Else
                ck_cst.Checked = False
                txt_billcst.Text = billsearch.Rows(0).Cells(20).Value.ToString
            End If
            billsearch.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub details2()
        Try
            Dim k As Integer
            If billsearch.Rows.Count > 0 Then
                sgdt = SALES_DETAILS(Trim(txt_billno.Text), "", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, "", "VIEWDETAILS")
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
                grid_sales.Columns(16).Width = 75
                grid_sales.Columns(17).Width = 100
                grid_sales.Columns(18).Width = 100
                grid_sales.Columns("Cstamt").Visible = False
                grid_sales.Columns(20).Width = 100
                sno.Text = grid_sales.RowCount
                clearitem()
                count()
                txt_u2rate.ReadOnly = True
                btn_save.Text = "&UPDATE"
                grid_custname.Visible = False
                billsearch.Visible = False
                updatedt = grid_sales.DataSource
            Else
                MsgBox("No Row Selected")
            End If
            count()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Sales_Voucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If billno = "" Then
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
                sgdt.Columns.Add("FQty")
                sgdt.Columns.Add("FUnit")
                sgdt.Columns.Add("Cstper")
                sgdt.Columns.Add("Cstamt")
                sgdt.Columns.Add("Batchno")
                sgdt.Columns.Add("Pid")
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
                grid_sales.Columns(16).Width = 75
                grid_sales.Columns(17).Width = 100
                grid_sales.Columns(18).Width = 100
                grid_sales.Columns("Cstamt").Visible = False
                grid_sales.Columns(20).Width = 100
                grid_sales.Columns(21).Visible = False
                maxbill()
            Else
                grid_sales.Columns(0).Width = 50
                grid_sales.Columns(1).Width = 150
                grid_sales.Columns(2).Width = 200
                grid_sales.Columns(3).Width = 75
                grid_sales.Columns(4).Width = 100
                grid_sales.Columns(5).Width = 75
                grid_sales.Columns(6).Visible = True
                grid_sales.Columns(6).Width = 75
                grid_sales.Columns(7).Visible = False
                grid_sales.Columns(8).Visible = True
                grid_sales.Columns(8).Width = 75
                grid_sales.Columns(9).Visible = False
                grid_sales.Columns(10).Visible = False
                grid_sales.Columns(11).Visible = False
                grid_sales.Columns(12).Width = 100
                grid_sales.Columns(13).Visible = False
                grid_sales.Columns(14).Visible = False
                grid_sales.Columns(15).Visible = False
                grid_sales.Columns("billid").Visible = False
                grid_sales.Columns("No_Of_Subunit").Visible = False
                grid_sales.Columns(16).Width = 75
                grid_sales.Columns(17).Width = 100
                grid_sales.Columns(18).Width = 100
                grid_sales.Columns("Cstamt").Visible = False
                grid_sales.Columns(20).Width = 100
                grid_sales.Columns(21).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reset_clear()
        Try
            sgdt.Rows.Clear()
            grid_sales.DataSource = sgdt
            txt_customername.Text = ""
            txt_address.Text = ""
            txt_phone.Text = ""
            txt_address.Enabled = True
            txt_phone.Enabled = True
            sales_date.Text = Today.Date
            sales_date.Enabled = True
            txt_brandname.Text = ""
            txt_productname.Text = ""
            txt_qty.Text = ""
            txt_orderby.Text = ""
            txt_orderby.Enabled = True
            txt_pay.Text = ""
            txt_pay.Enabled = True
            dat_order.Value = Today.Date
            dat_order.Enabled = True
            txt_dispatch.Text = ""
            txt_dispatch.Enabled = True
            txt_dc.Enabled = True
            txt_dc.Text = ""
            dat_dc.Enabled = True
            dat_dc.Text = Today.Date
            cbk_unit.SelectedIndex = -1
            txt_salrate.Text = "0.00"
            txt_u2rate.Text = "0.00"
            txt_billvat.Text = "0"
            txt_billdis.Text = "0"
            txt_billcst.Text = "0"
            ck_vat.Checked = False
            ck_dis.Checked = False
            txt_u2rate.ReadOnly = True
            txt_totprice.Text = "0.00"
            txt_mrp.Text = "0.00"
            btn_save.Text = "&SAVE"
            txt_customername.Enabled = True
            txt_address.Enabled = True
            txt_phone.Enabled = True
            txt_brandname.Enabled = True
            sales_date.Enabled = True
            grid_custname.Visible = False
            GRID_PRODUCTNAME.Visible = False
            BRAND.Visible = False
            tot_discount.Text = "0.00"
            tot_vat.Text = "0.00"
            txt_recamt.Text = "0.00"
            lbl_amt.Text = "0.00"
            lbl_netamt.Text = "0.00"
            rd_cash.Checked = False
            rd_cash.Enabled = True
            rd_credit.Enabled = True
            rd_credit.Checked = True
            clearitem()
            count()
            maxbill()
            sno.Text = grid_sales.RowCount
            txt_billno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub maxbill()
        Try
            Dim ds As DataSet
            ds = New DataSet
            cmd = New SqlCommand("billno")
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            txt_billno.Text = ds.Tables(0).Rows(0)(0)
            txt_billno.ReadOnly = True
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
                    txt_customername.Focus()
                    grid_custname.Visible = False
                End If
            Else
                txt_address.Text = ""
                txt_phone.Text = ""
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
                txt_address.Enabled = False
                txt_phone.Enabled = False
                txt_phone.Text = grid_custname.CurrentRow.Cells(3).Value
                grid_custname.Visible = False
                txt_customername.Focus()
            Else
                txt_customername.Text = ""
                txt_phone.Text = ""
                txt_address.Text = ""
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
                txt_orderby.Focus()
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
                    If txt_brandname.Text <> "" Then
                        txt_productname.Focus()
                    Else
                        txt_brandname.Focus()
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
    Private Sub txt_brandname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_brandname.TextChanged
        Try
            If txt_customername.Text = "" Then
                txt_customername.Focus()
            ElseIf txt_billno.Text = "" Then
                txt_billno.Focus()
            ElseIf txt_address.Text = "" Then
                txt_address.Focus()
            ElseIf txt_phone.Text = "" Then
                txt_phone.Focus()
            ElseIf txt_orderby.Text = "" Then
                txt_orderby.Focus()
            ElseIf txt_pay.Text = "" Then
                txt_pay.Focus()
            ElseIf txt_dispatch.Text = "" Then
                txt_dispatch.Focus()
            ElseIf txt_dc.Text = "" Then
                txt_dc.Focus()
            ElseIf txt_brandname.Text <> "" Then
                Dim bdt As DataTable
                bdt = SALES_DETAILS("", txt_brandname.Text + "%", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, "", "BRANDNAME")
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
                    If txt_productname.Text <> "" Then
                        cbk_unit.Focus()
                    Else
                        txt_productname.Focus()
                    End If
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

    Private Sub txt_qty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_qty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_qty.Text = "" Then
                    txt_qty.Text = 0
                Else
                    Txt_fqty.Focus()
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
    Private Sub cbk_unit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_unit.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cbk_unit.Text = "" Then
                    cbk_unit.Focus()
                Else
                    txt_qty.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_productname.Focus()
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

    Private Sub txt_u2rate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_u2rate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_u2rate.Text = "" Or txt_u2rate.Text = "0.00" Then
                    txt_u2rate.Focus()
                Else
                    txt_cst.Focus()
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
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
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

    Private Sub txt_phone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_phone.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (txt_phone.Text <> "") Then
                    sales_date.Focus()
                Else
                    txt_phone.Focus()
                End If
            ElseIf e.KeyCode = Keys.Up Then
                txt_address.Focus()
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
    Private Sub txt_productname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_productname.TextChanged
        Try
            If txt_brandname.Text <> "" And txt_productname.Text <> "" Then
                Dim pdt As DataTable
                pdt = SALES_DETAILS("", txt_brandname.Text, txt_productname.Text + "%", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, "", "PRODUCTNAME")
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
            ElseIf txt_productname.Text = "" Then
                GRID_PRODUCTNAME.Visible = False
                txt_productname.Focus()
            Else
                txt_productname.Text = ""
                txt_brandname.Focus()
                GRID_PRODUCTNAME.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_PRODUCTNAME_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID_PRODUCTNAME.DoubleClick
        Try
            Dim i As Integer
            If GRID_PRODUCTNAME.Rows.Count <> 0 Then
                txt_pid.Text = GRID_PRODUCTNAME.CurrentRow.Cells(0).Value
                txt_productname.Text = GRID_PRODUCTNAME.CurrentRow.Cells(1).Value
                txt_salrate.Text = Format(GRID_PRODUCTNAME.CurrentRow.Cells(2).Value, "0.00")
                txt_mrp.Text = GRID_PRODUCTNAME.CurrentRow.Cells(6).Value
                rate = GRID_PRODUCTNAME.CurrentRow.Cells(2).Value
                txt_u2rate.Text = Format(rate, "0.00")
                noofqty = GRID_PRODUCTNAME.CurrentRow.Cells(7).Value
                txt_batch.Text = GRID_PRODUCTNAME.CurrentRow.Cells(8).Value
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
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
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
            If Val(txt_u2rate.Text) > Val(txt_mrp.Text) Then
                MsgBox("Purchase Rate Must Be Less Than MRP " & vbNewLine & "MRP Rate is " & txt_mrp.Text, MsgBoxStyle.Information, suss)
                txt_u2rate.Text = ""
                txt_u2rate.Focus()
            Else
                If cbk_unit.Text = wholeunit Then
                    txt_salrate.Text = Format(Val(txt_u2rate.Text) * noofqty, "0.00")
                Else
                    txt_salrate.Text = Format(Val(txt_u2rate.Text), "0.00")
                End If
                If txt_qty.Text <> "" Then
                    If IsNumeric(txt_qty.Text) = True Then
                        If txt_salrate.Text <> "" Then
                            If IsNumeric(txt_qty.Text) = True Then
                                txt_totprice.Text = Val(txt_salrate.Text) * Val(txt_qty.Text)
                                Dim totprice As Decimal = 0.0
                                totprice = txt_totprice.Text
                                txt_totprice.Text = Format(totprice, "0.00")
                                cstamount()
                                vatamount()
                                Discount1()
                            End If
                        End If
                    End If
                Else
                    Dim totprice As Decimal = 0.0
                    txt_totprice.Text = Format(totprice, "0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        Try
            Dim a As Integer = 1
            If txt_qty.Text = "" Then
                txt_totprice.Text = "0.00"
            ElseIf txt_brandname.Text = "" Then
                txt_brandname.Focus()
            Else
                If txt_brandname.Text <> "" And txt_productname.Text <> "" Then
                    Dim dt As New DataTable
                    dt = Find_Items(txt_pid.Text, txt_productname.Text)
                    If dt.Rows.Count <> 0 Then
                        purqty = dt.Rows(0)(2)
                        noofqty = dt.Rows(0)(7)
                    Else
                        purqty = 0
                    End If
                    If txt_qty.Text <> "" And cbk_unit.SelectedIndex <> -1 Then
                        Dim totqty As Decimal = 0
                        Dim cal As Decimal = 0
                        If btn_save.Text = "&UPDATE" Then
                            If updatedt.Rows.Count <> 0 Then
                                For k As Integer = 0 To updatedt.Rows.Count - 1
                                    If grid_sales.Rows(k).Cells(1).Value = txt_brandname.Text And grid_sales.Rows(k).Cells(2).Value = txt_productname.Text Then
                                        purqty = Val(purqty) + updatedt.Rows(k)(15)
                                    End If
                                Next
                            End If
                        End If
                        If grid_sales.RowCount <> 0 Then
                            For gridcnt As Integer = 0 To grid_sales.RowCount - 1
                                If grid_sales.Rows(gridcnt).Cells(1).Value = txt_brandname.Text And grid_sales.Rows(gridcnt).Cells(2).Value = txt_productname.Text Then
                                    totqty = Val(totqty) + grid_sales.Rows(gridcnt).Cells(15).Value
                                End If
                            Next
                        End If
                        cal = totqty
                        Dim s As String
                        If cbk_unit.Text = wholeunit.ToString Then
                            totqty = Val(totqty) / Val(noofqty)
                            totqty = Val(totqty) + Val(txt_qty.Text)
                            cal = Val(cal) / Val(noofqty)
                            If purqty <> 0 And noofqty <> 0 Then
                                purqty = purqty / noofqty
                            End If
                            s = wholeunit.ToString
                        Else
                            totqty = totqty + Val(txt_qty.Text)
                            purqty = purqty
                            s = subunit.ToString
                        End If
                        If totqty > purqty Then
                            Dim j As String
                            j = Format((purqty - cal), "0.00")
                            MsgBox("RemainingQty is  " + j.Substring(0, j.Length - 3) + " " + s.ToString, MsgBoxStyle.Information, suss)
                            If purqty = 0 Then
                                txt_qty.Text = "0"
                                txt_qty.Focus()
                            Else
                                txt_qty.Text = j.Substring(0, j.Length - 3)
                                txt_qty.Focus()
                            End If
                            a = 3
                        Else
                            txt_qty.Focus()
                        End If
                    End If
                Else
                    MsgBox("Enter Quantity Value And Select Unit Value", MsgBoxStyle.Information, suss)
                    txt_qty.Focus()
                End If
            End If
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
                            cstamount()
                            vatamount()
                            Discount1()
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_totprice.Text = Format(totprice, "0.00")
            End If
            txt_vat.Text = "0"
            TXT_DIS.Text = "0"
            txt_vat.ReadOnly = False
            TXT_DIS.ReadOnly = False
            txt_u2rate.ReadOnly = False
            txt_cst.Text = "0"
            txt_cst.ReadOnly = False
            Txt_fqty.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
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
            Dim re As Integer
            Dim noof As Integer
            If e.KeyCode = Keys.Enter Then
                If cbk_unit.SelectedIndex = -1 Then
                    MsgBox("Select UnitName", MsgBoxStyle.Information, suss)
                ElseIf brandname.Text = "" Then
                    MsgBox("Select Brandname", MsgBoxStyle.Information, suss)
                ElseIf txt_productname.Text = "" Then
                    MsgBox("Select Product Name", MsgBoxStyle.Information, suss)
                ElseIf TXT_DIS.Text = "" Or txt_cst.Text = "" Or txt_vat.Text = "" Then
                    MsgBox("Select cst,vat ,dis value", MsgBoxStyle.Information, suss)
                ElseIf txt_qty.Text <> 0 And Val(txt_u2rate.Text) <> 0 Then
                    GR = (Val(txt_qty.Text) * Val(txt_salrate.Text))
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
                            grid_sales.Rows(i).Cells(18).Value = Val(txt_cst.Text) + grid_sales.Rows(i).Cells(18).Value
                            grid_sales.Rows(i).Cells(7).Value = Val(vatamt.ToString) + grid_sales.Rows(i).Cells(7).Value
                            grid_sales.Rows(i).Cells(19).Value = Val(cstamt.ToString) + grid_sales.Rows(i).Cells(19).Value
                            grid_sales.Rows(i).Cells(8).Value = Val(TXT_DIS.Text) + grid_sales.Rows(i).Cells(8).Value
                            grid_sales.Rows(i).Cells(9).Value = Val(disamt.ToString) + grid_sales.Rows(i).Cells(9).Value
                            grid_sales.Rows(i).Cells(12).Value = Val(txt_totprice.Text) + grid_sales.Rows(i).Cells(12).Value
                            grid_sales.Rows(i).Cells(15).Value = Val(Txt1.Text) + grid_sales.Rows(i).Cells(15).Value
                            grid_sales.Rows(i).Cells(10).Value = Val(GR.ToString) + grid_sales.Rows(i).Cells(10).Value
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        sgdt.Rows.Add(sgdt.Rows.Count + 1, txt_brandname.Text, txt_productname.Text, Val(txt_qty.Text), Trim(cbk_unit.Text), Val(txt_salrate.Text), Val(txt_vat.Text), Val(vatamt.ToString), Val(TXT_DIS.Text), Val(disamt.ToString), Val(GR.ToString), Val(txt_u2rate.Text), Val(txt_totprice.Text), Val(txt_mrp.Text), Trim(txt_billno.Text), Val(Txt1.Text), Trim(re.ToString), Trim(subunit.ToString), Val(txt_cst.Text), Val(cstamt.ToString), Trim(txt_batch.Text), Trim(txt_pid.Text))
                        grid_sales.DataSource = sgdt
                        sno.Text = grid_sales.RowCount
                        count()
                        If rd_cash.Checked = True Then
                            txt_recamt.Text = lbl_netamt.Text
                            txt_recamt.ReadOnly = True
                        Else
                            txt_recamt.Text = "0.00"
                            txt_recamt.ReadOnly = False
                        End If
                        clearitem()
                    Else
                        clearitem()
                        txt_brandname.Focus()
                    End If
                ElseIf Val(Txt_fqty.Text) <> 0 And Val(txt_u2rate.Text) <> 0 Then
                    If cbk_unit.SelectedItem.ToString = wholeunit.ToString Then
                        noof = Val(Txt_fqty.Text) * noofqty
                    Else
                        noof = Val(Txt_fqty.Text)
                    End If
                    Txt1.Text = noof
                    For i As Integer = 0 To grid_sales.RowCount - 1
                        If grid_sales.Rows(i).Cells(1).Value = txt_brandname.Text And grid_sales.Rows(i).Cells(2).Value = txt_productname.Text And grid_sales.Rows(i).Cells(4).Value = cbk_unit.SelectedItem.ToString Then
                            grid_sales.Rows(i).Cells(3).Value = Val(txt_qty.Text) + grid_sales.Rows(i).Cells(3).Value
                            grid_sales.Rows(i).Cells(6).Value = Val(txt_vat.Text) + grid_sales.Rows(i).Cells(6).Value
                            grid_sales.Rows(i).Cells(7).Value = Val(vatamt.ToString) + grid_sales.Rows(i).Cells(7).Value
                            grid_sales.Rows(i).Cells(18).Value = Val(txt_cst.Text) + grid_sales.Rows(i).Cells(18).Value
                            grid_sales.Rows(i).Cells(8).Value = Val(TXT_DIS.Text) + grid_sales.Rows(i).Cells(8).Value
                            grid_sales.Rows(i).Cells(9).Value = Val(disamt.ToString) + grid_sales.Rows(i).Cells(9).Value
                            grid_sales.Rows(i).Cells(12).Value = Val(txt_totprice.Text) + grid_sales.Rows(i).Cells(12).Value
                            grid_sales.Rows(i).Cells(15).Value = Val(Txt1.Text) + grid_sales.Rows(i).Cells(15).Value
                            If cbk_unit.Text = wholeunit.ToString Then
                                re = Val(Txt_fqty.Text) * Val(noofqty.ToString)
                                grid_sales.Rows(i).Cells(16).Value = grid_sales.Rows(i).Cells(17).Value + Val(re.ToString)
                                grid_sales.Rows(i).Cells(17).Value = subunit.ToString
                            Else
                                grid_sales.Rows(i).Cells(16).Value = Val(Txt_fqty.Text) + grid_sales.Rows(i).Cells(16).Value
                                grid_sales.Rows(i).Cells(17).Value = subunit.ToString
                            End If
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        sgdt.Rows.Add(sgdt.Rows.Count + 1, txt_brandname.Text, txt_productname.Text, Val(txt_qty.Text), Trim(cbk_unit.Text), Val(txt_salrate.Text), Val(txt_vat.Text), Val(vatamt.ToString), Val(TXT_DIS.Text), Val(disamt.ToString), Val(GR.ToString), Val(txt_u2rate.Text), Val(txt_totprice.Text), Val(txt_mrp.Text), Trim(txt_billno.Text), Val(Txt1.Text), Val(Txt1.Text), Trim(subunit.ToString), Val(txt_cst.Text), Val(cstamt.ToString), Trim(txt_batch.Text), Trim(txt_pid.Text))
                        grid_sales.DataSource = sgdt
                        sno.Text = grid_sales.RowCount
                        count()
                        If rd_cash.Checked = True Then
                            txt_recamt.Text = lbl_netamt.Text
                            txt_recamt.ReadOnly = True
                        Else
                            txt_recamt.Text = "0.00"
                            txt_recamt.ReadOnly = False
                        End If
                        clearitem()
                    Else
                        clearitem()
                        txt_brandname.Focus()
                    End If
                Else
                    MsgBox("Select Qty Or U2-Prate Value", MsgBoxStyle.Information, suss)
                End If
                count()
                txt_u2rate.ReadOnly = True
                ck_vat.Checked = False
                ck_dis.Checked = False
                ck_cst.Checked = False
                txt_billvat.Text = "0"
                txt_billcst.Text = "0"
                txt_billdis.Text = "0"
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
    Sub count()
        Try
            Dim qty As Integer = 0
            Dim net As Decimal = 0.0
            Dim cst As Decimal = 0.0
            Dim cstper As Integer = 0
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
                cstper += grid_sales.Rows(i).Cells(18).Value
                cst += grid_sales.Rows(i).Cells(19).Value
                net += grid_sales.Rows(i).Cells(12).Value
            Next
            lbl_qty.Text = qty
            lbl_amt.Text = Format(gross, "0.00")
            mainvat = Val(vatamt.ToString)
            maincst = Val(cst.ToString)
            maindis = Format(System.Math.Round(Val(disamt)), "0.00")
            tot_vat.Text = Val(vatamt.ToString) + Val(cst.ToString)
            tot_vat.Text = Format(System.Math.Round(Val(tot_vat.Text)), "0.00")
            tot_discount.Text = Format(System.Math.Round(Val(disamt)), "0.00")
            lblvat.Text = Format(vattot, "0.00")
            lbldis.Text = Format(distot, "0.00")
            lblcst.Text = Format(cstper, "0.00")
            lbl_netamt.Text = Format(System.Math.Round(net), "0.00")
            If lbl_netamt.Text <> "" And Val(lbl_netamt.Text) <> 0 And Val(received.ToString) <> 0 Then
                txt_recamt.Text = Val(received.ToString)
                received = 0
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
            txt_salrate.Text = "0.00"
            txt_u2rate.Text = "0.00"
            txt_u2rate.ReadOnly = True
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
            If rd_cash.Checked Then
                txt_recamt.Text = lbl_netamt.Text
                txt_recamt.ReadOnly = True
            Else
                txt_recamt.Text = "0.00"
                txt_recamt.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            f = Val(lbl_amt.Text) * Val(tot_vat.Text) / 100
            lbl_netamt.Text = (Val(lbl_amt.Text) + Val(f)) - Val(tot_discount.Text)
            If rd_cash.Checked Then
                txt_recamt.Text = lbl_netamt.Text
                txt_recamt.ReadOnly = True
            Else
                txt_recamt.Text = "0.00"
                txt_recamt.ReadOnly = False
            End If
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
            ElseIf e.KeyCode = Keys.Left Then

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

    Private Sub txt_discount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                If rd_cash.Checked = True Then
                    btn_save.Focus()
                Else
                    txt_recamt.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                tot_vat.Focus()
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

    Private Sub txt_recamt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_recamt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btn_save.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                tot_discount.Focus()
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

    Private Sub rd_cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_cash.CheckedChanged
        Try
            If rd_cash.Checked = True Then
                txt_recamt.Text = lbl_netamt.Text
                txt_recamt.ReadOnly = True
            Else
                txt_recamt.Text = "0.00"
                txt_recamt.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rd_credit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_credit.CheckedChanged
        Try
            If rd_cash.Checked = True Then
                txt_recamt.Text = lbl_netamt.Text
                txt_recamt.ReadOnly = True
            Else
                txt_recamt.Text = "0.00"
                txt_recamt.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            Dim rep As String
            Dim str As String
            Dim vt As Decimal = 0
            Dim billdt As New DataTable
            Dim succ As String
            If txt_customername.Text = "" Or txt_billno.Text = "" Or txt_address.Text = "" Or txt_phone.Text = "" Or (rd_cash.Checked = False And rd_credit.Checked = False) Or grid_sales.Rows.Count = 0 Or tot_vat.Text = "" Or tot_discount.Text = "" Then
                MsgBox("Please Fill the fields", MsgBoxStyle.Information)
                txt_billno.Focus()
            Else
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    If btn_save.Text = "&SAVE" Then
                        If rd_cash.Checked = True Then
                            str = "Cash"
                        Else
                            str = "Credit"
                        End If
                        If str = "Cash" Or str = "Credit" Then
                            If txt_recamt.Text = "" Then
                                MsgBox("please give some amount")
                                txt_recamt.Text = ""
                                txt_recamt.Focus()
                            ElseIf txt_recamt.Text <> "" Then
                                Dim ds As New DataTable
                                ds = SALES_PROC(Trim(txt_billno.Text), Trim(txt_customername.Text), Trim(txt_address.Text), Trim(txt_phone.Text), sales_date.Value.ToString("MM/dd/yyyy"), str, Val(lbl_amt.Text), Val(lblvat.Text), Val(tot_vat.Text), Val(lbldis.Text), Val(tot_discount.Text), Val(lbl_netamt.Text), Val(txt_recamt.Text), Trim(txt_orderby.Text), Trim(txt_pay.Text), dat_order.Value.ToString("MM/dd/yyyy"), Trim(txt_dispatch.Text), Trim(txt_dc.Text), dat_dc.Value.ToString("MM/dd/yyyy"), "INSERT", bvatp, bvatamt, bvattype, bdisp, bdisamt, bdistype, bcstp, bcstamt, bcsttype)
                                If ds.Rows(0)(0) = 1 Then
                                    For i As Integer = 0 To grid_sales.RowCount - 1
                                        Dim DTT As New DataTable
                                        DTT = SALES_DETAILS(grid_sales.Rows(i).Cells(14).Value, grid_sales.Rows(i).Cells(1).Value, grid_sales.Rows(i).Cells(21).Value, grid_sales.Rows(i).Cells(3).Value, grid_sales.Rows(i).Cells(4).Value, grid_sales.Rows(i).Cells(5).Value, grid_sales.Rows(i).Cells(11).Value, grid_sales.Rows(i).Cells(6).Value, grid_sales.Rows(i).Cells(7).Value, grid_sales.Rows(i).Cells(8).Value, grid_sales.Rows(i).Cells(9).Value, grid_sales.Rows(i).Cells(10).Value, grid_sales.Rows(i).Cells(12).Value, grid_sales.Rows(i).Cells(13).Value, grid_sales.Rows(i).Cells(16).Value, grid_sales.Rows(i).Cells(17).Value, grid_sales.Rows(i).Cells(18).Value, grid_sales.Rows(i).Cells(19).Value, grid_sales.Rows(i).Cells(15).Value, "INSERT")
                                        succ = DTT.Rows(0)(0)
                                    Next
                                    If succ = "1" Then
                                        MsgBox("Succesfully Saved", MsgBoxStyle.Information, "Message")
                                        printbill()
                                        reset_clear()
                                        maxbill()
                                    Else
                                        MsgBox("Not Saved", MsgBoxStyle.Information, "Message")
                                    End If
                                End If
                            End If
                        Else
                            MsgBox("Select Cash or Credit.", MsgBoxStyle.Information, "Message")
                            rd_cash.Focus()
                        End If
                    Else
                        If txt_customername.Text = "" Or txt_address.Text = "" Then
                            MsgBox("Please Select SupplierName", MsgBoxStyle.Information, "Message")
                            txt_customername.Focus()
                        Else
                            If grid_sales.RowCount <> 0 Then
                                If rd_cash.Checked = True Then
                                    str = "Cash"
                                Else
                                    str = "Credit"
                                End If
                                If str = "Cash" Or str = "Credit" Then
                                    If txt_recamt.Text = "" Then
                                        MsgBox("please give some amount")
                                        txt_recamt.Text = ""
                                        txt_recamt.Focus()
                                    ElseIf txt_recamt.Text <> "" Then
                                        Dim ds As New DataTable
                                        ds = SALES_PROC(Trim(txt_billno.Text), Trim(txt_customername.Text), Trim(txt_address.Text), Trim(txt_phone.Text), sales_date.Value.ToString("MM/dd/yyyy"), str, Val(lbl_amt.Text), Val(lblvat.Text), Val(tot_vat.Text), Val(lbldis.Text), Val(tot_discount.Text), Val(lbl_netamt.Text), Val(txt_recamt.Text), Trim(txt_orderby.Text), Trim(txt_pay.Text), dat_order.Value.ToString("MM/dd/yyyy"), Trim(txt_dispatch.Text), Trim(txt_dc.Text), dat_dc.Value.ToString("MM/dd/yyyy"), "UPDATE", bvatp, bvatamt, bvattype, bdisp, bdisamt, bdistype, bcstp, bcstamt, bcsttype)
                                        If ds.Rows(0)(0) = 1 Then
                                            For i As Integer = 0 To grid_sales.RowCount - 1
                                                Dim DTT As New DataTable
                                                DTT = SALES_DETAILS(grid_sales.Rows(i).Cells(14).Value, grid_sales.Rows(i).Cells(1).Value, grid_sales.Rows(i).Cells(21).Value, grid_sales.Rows(i).Cells(3).Value, grid_sales.Rows(i).Cells(4).Value, grid_sales.Rows(i).Cells(5).Value, grid_sales.Rows(i).Cells(11).Value, grid_sales.Rows(i).Cells(6).Value, grid_sales.Rows(i).Cells(7).Value, grid_sales.Rows(i).Cells(8).Value, grid_sales.Rows(i).Cells(9).Value, grid_sales.Rows(i).Cells(10).Value, grid_sales.Rows(i).Cells(12).Value, grid_sales.Rows(i).Cells(13).Value, grid_sales.Rows(i).Cells(16).Value, grid_sales.Rows(i).Cells(17).Value, grid_sales.Rows(i).Cells(18).Value, grid_sales.Rows(i).Cells(19).Value, grid_sales.Rows(i).Cells(15).Value, "INSERT")
                                                succ = DTT.Rows(0)(0)
                                            Next
                                            If succ = "1" Then
                                                MsgBox("Succesfully Updated", MsgBoxStyle.Information, "Message")
                                                printbill()
                                                reset_clear()
                                                updatedt.Rows.Clear()
                                                maxbill()
                                            Else
                                                MsgBox("Not updated", MsgBoxStyle.Information, "Message")
                                            End If
                                        End If
                                    End If
                                Else
                                    MsgBox("Select Cash or Credit.", MsgBoxStyle.Information, "Message")
                                    rd_cash.Focus()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printbill()
        Try
            Dim cnt As New DataTable
            Dim val1 As Decimal
            cnt = grid_sales.DataSource
            Dim cmd1 As New SqlCommand
            Dim ds As New sales_ds
            Dim da1 As New SqlDataAdapter
            Dim lett As String
            lett = RupeesToWord(Trim(lbl_netamt.Text.ToString))
            For i As Integer = 0 To cnt.Rows.Count - 1
                val1 = Val(cnt.Rows(i)(6)) + Val(cnt.Rows(i)(18))
                If cnt.Rows(i)(3) = 0 Then
                    ds.Tables("SalesDetails").Rows.Add(cnt.Rows(i)(20), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(17), cnt.Rows(i)(5), Format(Val(cnt.Rows(i)(10)), "0"), Format(Val(val1), "0"), Format(Val(cnt.Rows(i)(8)), "0"), Format(Val(cnt.Rows(i)(12)), "0.00"), cnt.Rows(i)(16), cnt.Rows(i)(17))
                Else
                    ds.Tables("SalesDetails").Rows.Add(cnt.Rows(i)(20), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), Format(Val(cnt.Rows(i)(10)), "0"), Format(Val(val1), "0"), Format(Val(cnt.Rows(i)(8)), "0"), Format(Val(cnt.Rows(i)(12)), "0.00"), cnt.Rows(i)(16), cnt.Rows(i)(17))
                End If
            Next
            ds.Tables("SalesMain").Rows.Add(Trim(txt_billno.Text), sales_date.Value.ToString("dd/MM/yyyy"), Trim(txt_dc.Text), dat_dc.Value.ToString("dd/MM/yyyy"), Trim(txt_orderby.Text), dat_order.Value.ToString("dd/MM/yyyy"), Trim(txt_pay.Text), Trim(txt_dispatch.Text), Val(lbl_amt.Text), Val(lblvat.Text) + bvatp, Val(tot_vat.Text), Val(lbldis.Text) + bdisp, Val(tot_discount.Text), Val(lbl_netamt.Text), lett.ToString)
            cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2 from Organization", con)
            da1 = New SqlDataAdapter(cmd)
            da1.Fill(ds.Tables("companydetails"))
            cmd1 = New SqlCommand("select name as Name,address as Address,tinno as TinNo1,cstno as CstNo1,phno as Phone,mobno as Mobile,'" & Val(lblcst.Text) + bcstp & "' as sample,'' as sample1 from clientregister where name='" & txt_customername.Text & "' and address='" & txt_address.Text & "'", con)
            da1 = New SqlDataAdapter(cmd1)
            da1.Fill(ds.Tables("Customer"))
            Dim dc1 As New salesFormat1
            dc1.SetDataSource(ds)
            ReportForm.ReportViewer.ReportSource = dc1
            ReportForm.ShowDialog()
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
                        view = SALES_PROC(txt_billno.Text + "%", txt_customername.Text, txt_address.Text, txt_phone.Text, sales_date.Value.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", "VIEW", 0, 0, "", 0, 0, "", 0, 0, "")
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
                            billsearch.Columns(18).Visible = False
                            billsearch.Columns(19).Visible = False
                            billsearch.Columns(20).Visible = False
                            billsearch.Columns(21).Visible = False
                            billsearch.Columns(22).Visible = False
                            billsearch.Columns(17).Visible = False
                            billsearch.Columns(12).Visible = False
                            billsearch.Columns(13).Visible = False
                            txt_billno.Focus()
                        Else
                            txt_customername.Focus()
                            btn_save.Text = "&SAVE"
                            sgdt.Rows.Clear()
                            grid_sales.DataSource = sgdt
                        End If
                    Else
                        txt_billno.Focus()
                        txt_address.Text = ""
                        txt_customername.Text = ""
                        btn_save.Text = "&SAVE"
                        sgdt.Rows.Clear()
                        grid_sales.DataSource = sgdt
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
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub txt_billno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_billno.Leave
        Try
            If billsearch.Visible = True Then
                billsearch.Focus()
            Else
                If txt_brandname.Text = "" Then
                    Dim view As DataTable
                    If txt_billno.Text <> "" Then
                        view = SALES_PROC(txt_billno.Text + "%", txt_customername.Text, txt_address.Text, txt_phone.Text, sales_date.Value.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", "VIEW", 0, 0, "", 0, 0, "", 0, 0, "")
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
                            billsearch.Columns(18).Visible = False
                            billsearch.Columns(19).Visible = False
                            billsearch.Columns(20).Visible = False
                            billsearch.Columns(21).Visible = False
                            billsearch.Columns(22).Visible = False
                            billsearch.Columns(17).Visible = False
                            billsearch.Columns(12).Visible = False
                            billsearch.Columns(13).Visible = False
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
            Dim str As String
            Dim dtype As String
            Dim vtype As String
            Dim ctype1 As String
            aa = billsearch.CurrentRow.Cells(4).Value
            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
            dat = CDate(aa)
            sales_date.Value = dat
            sales_date.Enabled = False
            txt_billno.Text = billsearch.CurrentRow.Cells(0).Value
            txt_customername.Text = billsearch.CurrentRow.Cells(1).Value
            txt_address.Text = billsearch.CurrentRow.Cells(2).Value
            txt_phone.Text = billsearch.CurrentRow.Cells(3).Value
            txt_billno.ReadOnly = True
            txt_customername.Enabled = False
            txt_address.Enabled = False
            txt_phone.Enabled = False
            str = billsearch.CurrentRow.Cells(5).Value
            If str = "Cash" Then
                rd_cash.Checked = True
                rd_cash.Enabled = False
                rd_credit.Enabled = False
            Else
                rd_credit.Checked = True
                rd_credit.Enabled = False
                rd_cash.Enabled = False
            End If
            lbl_amt.Text = billsearch.CurrentRow.Cells(6).Value.ToString
            tot_vat.Text = billsearch.CurrentRow.Cells(7).Value.ToString
            tot_discount.Text = billsearch.CurrentRow.Cells(8).Value.ToString
            lbl_netamt.Text = billsearch.CurrentRow.Cells(9).Value.ToString
            received = billsearch.CurrentRow.Cells(10).Value.ToString
            txt_orderby.Text = billsearch.CurrentRow.Cells(11).Value.ToString
            txt_orderby.Enabled = False
            txt_pay.Text = billsearch.CurrentRow.Cells(12).Value.ToString
            txt_pay.Enabled = False
            Dim dat1 As Date
            Dim aa1 As String
            aa1 = billsearch.CurrentRow.Cells(13).Value.ToString
            aa1 = aa1.Substring(3, 2) & "/" & aa1.Substring(0, 2) & "/" & aa1.Substring(6, 4)
            dat1 = CDate(aa1)
            dat_order.Value = dat1
            dat_order.Enabled = False
            txt_dispatch.Text = billsearch.CurrentRow.Cells(14).Value.ToString
            txt_dispatch.Enabled = False
            txt_dc.Text = billsearch.CurrentRow.Cells(15).Value.ToString
            txt_dc.Enabled = False
            Dim dat2 As Date
            Dim aa2 As String
            aa2 = billsearch.CurrentRow.Cells(16).Value.ToString
            aa2 = aa2.Substring(3, 2) & "/" & aa2.Substring(0, 2) & "/" & aa2.Substring(6, 4)
            dat2 = CDate(aa2)
            dat_dc.Value = dat2
            dat_dc.Enabled = False
            txt_billno.ReadOnly = True
            details()
            vtype = billsearch.CurrentRow.Cells(17).Value.ToString
            If vtype = "Percent" Then
                ck_vat.Checked = True
                txt_billvat.Text = billsearch.CurrentRow.Cells(18).Value.ToString
            Else
                ck_vat.Checked = False
                txt_billvat.Text = billsearch.CurrentRow.Cells(18).Value.ToString
            End If
            dtype = billsearch.CurrentRow.Cells(21).Value.ToString
            If dtype = "Percent" Then
                ck_dis.Checked = True
                txt_billdis.Text = billsearch.CurrentRow.Cells(22).Value.ToString
            Else
                ck_dis.Checked = False
                txt_billdis.Text = billsearch.CurrentRow.Cells(22).Value.ToString
            End If
            ctype1 = billsearch.CurrentRow.Cells(19).Value.ToString
            If dtype = "Percent" Then
                ck_cst.Checked = True
                txt_billcst.Text = billsearch.CurrentRow.Cells(20).Value.ToString
            Else
                ck_cst.Checked = False
                txt_billcst.Text = billsearch.CurrentRow.Cells(20).Value.ToString
            End If
            txt_u2rate.ReadOnly = True
            billsearch.Visible = False
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub details()
        Try
            Dim k As Integer
            If billsearch.Rows.Count > 0 Then
                sgdt = SALES_DETAILS(Trim(txt_billno.Text), "", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, "", "VIEWDETAILS")
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
                'grid_sales.Columns(15).Visible = False
                grid_sales.Columns("billid").Visible = False
                ' grid_sales.Columns("No_Of_Subunit").Visible = False
                grid_sales.Columns(16).Width = 75
                grid_sales.Columns(17).Width = 100
                grid_sales.Columns(18).Width = 100
                grid_sales.Columns("Cstamt").Visible = False
                grid_sales.Columns(20).Width = 100
                sno.Text = grid_sales.RowCount
                clearitem()
                count()
                btn_save.Text = "&UPDATE"
                grid_custname.Visible = False
                billsearch.Visible = False
                updatedt = grid_sales.DataSource
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

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            Dim i As Integer 'first time index
            Dim c_index As Integer
            Dim c_index_value As Integer
            Dim m As Integer
            Dim j As Integer 'second time iindex
            Dim amt As Decimal = 0
            Dim qnty As Integer = 0

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
                    ck_vat.Checked = False
                    ck_dis.Checked = False
                    ck_cst.Checked = False
                    txt_billvat.Text = "0"
                    txt_billcst.Text = "0"
                    txt_billdis.Text = "0"
                    sno.Text = grid_sales.RowCount
                    If rd_cash.Checked = True Then
                        txt_recamt.Text = lbl_netamt.Text
                        txt_recamt.ReadOnly = True
                    Else
                        txt_recamt.Text = "0.00"
                        txt_recamt.ReadOnly = False
                    End If
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
    Private Sub txt_recamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_recamt.TextChanged
        Try
            If Val(txt_recamt.Text) > Val(lbl_netamt.Text) Then
                MsgBox("Paid Amt Must Be Less Than TotAmt", MsgBoxStyle.Information, suss)
                txt_recamt.Text = ""
                txt_recamt.Focus()
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
                txt_cst.Focus()
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
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
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
                lbl_netamt2.Text = txt_totprice.Text + cstamt
                vatamt = 0
            Else
                vatamt = Format(System.Math.Round(Val(txt_totprice.Text) * (Val(txt_vat.Text) / 100)), "0.00")
                lbl_netamt2.Text = Val(txt_totprice.Text) + vatamt + cstamt
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
                disamt = Format(System.Math.Round(Val(lbl_netamt2.Text) * (Val(TXT_DIS.Text) / 100)), "0.00")
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
            cstamount()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub TXT_DIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DIS.TextChanged
        Try
            Quantity()
            cstamount()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_phone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phone.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProductRegister.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            clientcreation.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billno_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billno.DoubleClick
        Try
            txt_billno.ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_u2rate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_u2rate.DoubleClick
        Try
            txt_u2rate.ReadOnly = False
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_address_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_address.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_address.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_orderby_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_orderby.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dat_order.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                sales_date.Focus()
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

    Private Sub txt_orderby_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_orderby.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_orderby.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dat_order_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dat_order.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_pay.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                txt_orderby.Focus()
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

    Private Sub txt_pay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pay.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_dispatch.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                dat_order.Focus()
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

    Private Sub txt_pay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pay.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_pay.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dispatch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_dispatch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_dc.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                txt_pay.Focus()
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

    Private Sub txt_dispatch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dispatch.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_dispatch.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_dc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dat_dc.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                txt_dispatch.Focus()
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

    Private Sub txt_dc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dc.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_dc.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dat_dc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dat_dc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                rd_credit.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                rd_cash.Focus()
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

    Private Sub rd_credit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rd_credit.KeyDown
        Try
            If e.KeyCode = Keys.Up Then
                dat_dc.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                rd_cash.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                rd_credit.Focus()
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
            If e.KeyCode = Keys.Up Then
                dat_dc.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                rd_cash.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                rd_credit.Focus()
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

    Private Sub txt_cst_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cst.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_cst.Text = "" Then
                    txt_cst.Focus()
                Else
                    txt_vat.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_u2rate.Focus()
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

    Private Sub txt_cst_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cst.KeyPress
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

    Private Sub Txt_fqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_fqty.TextChanged
        Try
            Dim a As Integer = 1
            If Txt_fqty.Text = "" Then
                txt_totprice.Text = "0.00"
            ElseIf txt_brandname.Text = "" Then
                txt_brandname.Focus()
            Else
                If txt_brandname.Text <> "" And txt_productname.Text <> "" Then
                    Dim dt As New DataTable
                    dt = Find_Items(txt_pid.Text, txt_productname.Text)
                    If dt.Rows.Count <> 0 Then
                        purqty = dt.Rows(0)(2)
                        noofqty = dt.Rows(0)(7)
                    Else
                        purqty = 0
                    End If
                    If Txt_fqty.Text <> "" And cbk_unit.SelectedIndex <> -1 Then
                        Dim totqty As Decimal = 0
                        Dim cal As Decimal = 0
                        If btn_save.Text = "&UPDATE" Then
                            If updatedt.Rows.Count <> 0 Then
                                For k As Integer = 0 To updatedt.Rows.Count - 1
                                    If grid_sales.Rows(k).Cells(1).Value = txt_brandname.Text And grid_sales.Rows(k).Cells(2).Value = txt_productname.Text Then
                                        purqty = Val(purqty) + updatedt.Rows(k)(15)
                                    End If
                                Next
                            End If
                        End If
                        If grid_sales.RowCount <> 0 Then
                            For gridcnt As Integer = 0 To grid_sales.RowCount - 1
                                If grid_sales.Rows(gridcnt).Cells(1).Value = txt_brandname.Text And grid_sales.Rows(gridcnt).Cells(2).Value = txt_productname.Text Then
                                    totqty = Val(totqty) + grid_sales.Rows(gridcnt).Cells(15).Value
                                End If
                            Next
                        End If
                        cal = totqty
                        Dim s As String
                        If cbk_unit.Text = wholeunit.ToString Then
                            totqty = Val(totqty) / Val(noofqty)
                            totqty = Val(totqty) + Val(Txt_fqty.Text)
                            cal = Val(cal) / Val(noofqty)
                            If purqty <> 0 And noofqty <> 0 Then
                                purqty = purqty / noofqty
                            End If
                            s = wholeunit.ToString
                        Else
                            totqty = totqty + Val(Txt_fqty.Text)
                            purqty = purqty
                            s = subunit.ToString
                        End If
                        If totqty > purqty Then
                            Dim j As String
                            j = Format((purqty - cal), "0.00")
                            MsgBox("RemainingQty is  " + j.Substring(0, j.Length - 3) + " " + s.ToString, MsgBoxStyle.Information, suss)
                            If purqty = 0 Then
                                Txt_fqty.Text = "0"
                                Txt_fqty.Focus()
                            Else
                                Txt_fqty.Text = j.Substring(0, j.Length - 3)
                                Txt_fqty.Focus()
                            End If
                            a = 3
                        Else
                            Txt_fqty.Focus()
                        End If
                    End If
                Else
                    MsgBox("Enter Quantity Value And Select Unit Value", MsgBoxStyle.Information, suss)
                    txt_qty.Focus()
                End If
            End If
            If cbk_unit.Text = wholeunit Then
                txt_salrate.Text = Val(txt_u2rate.Text) * noofqty
            Else
                txt_salrate.Text = txt_u2rate.Text
            End If
            If Txt_fqty.Text <> "" Then
                If IsNumeric(Txt_fqty.Text) = True Then
                    If txt_salrate.Text <> "" Then
                        If IsNumeric(Txt_fqty.Text) = True Then
                            txt_totprice.Text = Val(txt_salrate.Text) * Val(txt_qty.Text)
                            Dim totprice As Decimal = 0.0
                            totprice = txt_totprice.Text
                            txt_totprice.Text = Format(totprice, "0.00")
                            cstamount()
                            vatamount()
                            Discount1()
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_totprice.Text = Format(totprice, "0.00")
            End If
            txt_qty.Text = "0"
            txt_vat.Text = "0"
            TXT_DIS.Text = "0"
            txt_cst.Text = "0"
            txt_vat.ReadOnly = True
            txt_vat.ReadOnly = True
            TXT_DIS.ReadOnly = True
            txt_cst.ReadOnly = True
            txt_u2rate.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_fqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_fqty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (Val(Txt_fqty.Text) <> 0 Or txt_qty.Text <> 0) Then
                    If Txt_fqty.Text <> 0 Then
                        txt_totprice.Focus()
                    ElseIf txt_qty.Text <> 0 Then
                        txt_u2rate.Focus()
                    End If
                Else
                    Txt_fqty.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_qty.Focus()
            ElseIf (e.KeyCode = Keys.Escape) Then
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

    Private Sub Txt_fqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_fqty.KeyPress
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

    Private Sub txt_cst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cst.TextChanged
        Try
            Quantity()
            cstamount()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub cstamount()
        Try
            If txt_cst.Text = "" Or Val(txt_cst.Text) = 0 Then
                lbl_netamt2.Text = txt_totprice.Text
                cstamt = 0
            Else
                cstamt = Format(System.Math.Round(Val(txt_totprice.Text) * (Val(txt_cst.Text) / 100)), "0.00")
                lbl_netamt2.Text = Val(txt_totprice.Text) + cstamt
            End If
            lbl_netamt2.Text = Format(System.Math.Round(Val(lbl_netamt2.Text)), "0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billno.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub txt_billvat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billvat.TextChanged
        Try
            If Val(lbl_amt.Text) <> 0 Then
                If ck_vat.Checked = True Then
                    bvattype = "Percent"
                    bvatp = Val(txt_billvat.Text)
                    Dim v As Decimal
                    v = Val(lbl_amt.Text) * Val(txt_billvat.Text) / 100
                    bvatamt = System.Math.Round(v)
                    tot_vat.Text = Format(System.Math.Round(v) + mainvat + maincst + bcstamt, "0.00")
                    lbl_netamt.Text = Format(Val(lbl_amt.Text) + Val(tot_vat.Text) - Val(tot_discount.Text), "0.00")
                Else
                    bvattype = "AMT"
                    bvatp = 0
                    bvatamt = Val(txt_billvat.Text)
                    tot_vat.Text = Format(Val(txt_billvat.Text) + mainvat + maincst + bcstamt, "0.00")
                    lbl_netamt.Text = Format(Val(lbl_amt.Text) + Val(tot_vat.Text) - Val(tot_discount.Text), "0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub ck_vat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_vat.CheckedChanged
        Try
            If ck_vat.Checked = True Then
                txt_billvat.Text = "0"
            Else
                txt_billvat.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub ck_dis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_dis.CheckedChanged
        Try
            If ck_dis.Checked = True Then
                txt_billdis.Text = "0"
            Else
                txt_billdis.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_cst.CheckedChanged
        Try
            If ck_cst.Checked = True Then
                txt_billcst.Text = "0"
            Else
                txt_billcst.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_billdis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billdis.TextChanged
        Try
            If Val(lbl_amt.Text) Then
                If ck_dis.Checked = True Then
                    Dim d As Decimal
                    bdistype = "Percent"
                    bdisp = Val(txt_billdis.Text)
                    d = Val(lbl_amt.Text) * Val(txt_billdis.Text) / 100
                    bdisamt = System.Math.Round(d)
                    tot_discount.Text = Format(maindis + System.Math.Round(d), "0.00")
                    lbl_netamt.Text = Format(Val(lbl_amt.Text) + Val(tot_vat.Text) - Val(tot_discount.Text), "0.00")
                Else
                    bdistype = "AMT"
                    bdisp = 0
                    bdisamt = Val(txt_billdis.Text)
                    tot_discount.Text = Format(Val(txt_billdis.Text) + maindis, "0.00")
                    lbl_netamt.Text = Format(Val(lbl_amt.Text) + Val(tot_vat.Text) - Val(tot_discount.Text), "0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_billcst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billcst.TextChanged
        Try
            If Val(lbl_amt.Text) <> 0 Then
                If ck_cst.Checked = True Then
                    bcsttype = "Percent"
                    bcstp = Val(txt_billcst.Text)
                    Dim v As Decimal
                    v = Val(lbl_amt.Text) * Val(txt_billcst.Text) / 100
                    bcstamt = System.Math.Round(v)
                    tot_vat.Text = Format(System.Math.Round(v) + mainvat + maincst + bvatamt, "0.00")
                    lbl_netamt.Text = Format(Val(lbl_amt.Text) + Val(tot_vat.Text) - Val(tot_discount.Text), "0.00")
                Else
                    bcsttype = "AMT"
                    bcstp = 0
                    bcstamt = Val(txt_billcst.Text)
                    tot_vat.Text = Format(Val(txt_billcst.Text) + mainvat + maincst + bvatamt, "0.00")
                    lbl_netamt.Text = Format(Val(lbl_amt.Text) + Val(tot_vat.Text) - Val(tot_discount.Text), "0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_billvat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_billvat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_billvat.Text <> "" Then
                    txt_billdis.Focus()
                Else
                    txt_billvat.Focus()
                End If
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

    Private Sub txt_billdis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_billdis.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_billdis.Text <> "" Then
                    txt_billcst.Focus()
                Else
                    txt_billdis.Focus()
                End If
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

    Private Sub txt_billcst_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_billcst.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_billcst.Text <> "" Then
                    txt_recamt.Focus()
                Else
                    txt_billcst.Focus()
                End If
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

    Private Sub txt_billvat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billvat.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_billvat.Text
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

    Private Sub txt_recamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_recamt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_recamt.Text
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

    Private Sub txt_billdis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billdis.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_billdis.Text
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

    Private Sub txt_billcst_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billcst.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_billcst.Text
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

    Private Sub grid_custname_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_custname.CellContentClick

    End Sub
End Class