Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class Sales_Return
    Dim gdt As New DataTable
    Dim wholeunit As String
    Dim subunit As String
    Dim u1qty As Decimal
    Dim u2qty As Decimal
    Dim noofqty As Integer
    Dim rate As Decimal
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
                txt_custname.Text = sup
                TXT_BILLNO.Text = bill
                Dim aa As String
                Dim dat As Date
                aa = dat1
                aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                dat = CDate(aa)
                sales_date.Value = dat
                TXT_BILLNO.Enabled = False
                txt_add.Enabled = False
                txt_add.Text = billsearch.Rows(0).Cells(2).Value
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
            gdt = SALRET_MAIN(TXT_BILLNO.Text, txt_custname.Text, txt_add.Text, sales_date.Value.ToString("MM/dd/yyyy"), 0, 0, "", "VIEWDETAILS")
            grid_salret.DataSource = gdt
            grid_salret.Columns(0).Width = 50
            grid_salret.Columns(1).Width = 150
            grid_salret.Columns(2).Width = 150
            grid_salret.Columns(3).Width = 100
            grid_salret.Columns(4).Width = 100
            grid_salret.Columns(5).Width = 100
            grid_salret.Columns(6).Width = 100
            grid_salret.Columns("BILLID").Visible = False
            grid_salret.Columns("NO_OF_SUBUNIT").Visible = False
            grid_salret.Columns("PID").Visible = False
            sno.Text = grid_salret.RowCount
            count()
            clearitem()
            btn_save.Visible = False
            btn_delete.Visible = False
            btn_xit.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Sales_Return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If bill = "" And dat1 = "" And sup = "" Then
                gdt.Columns.Add("SNO")
                gdt.Columns.Add("BRANDNAME")
                gdt.Columns.Add("PRODUCTNAME")
                gdt.Columns.Add("QTY")
                gdt.Columns.Add("UNIT")
                gdt.Columns.Add("SRATE")
                gdt.Columns.Add("PRICE")
                gdt.Columns.Add("BILLID")
                gdt.Columns.Add("NO_OF_SUBUNIT")
                gdt.Columns.Add("PID")
                grid_salret.DataSource = gdt
                grid_salret.Columns(0).Width = 50
                grid_salret.Columns(1).Width = 150
                grid_salret.Columns(2).Width = 150
                grid_salret.Columns(3).Width = 100
                grid_salret.Columns(4).Width = 100
                grid_salret.Columns(5).Width = 100
                grid_salret.Columns(6).Width = 100
                grid_salret.Columns("BILLID").Visible = False
                grid_salret.Columns("NO_OF_SUBUNIT").Visible = False
                grid_salret.Columns("PID").Visible = False
                reset_clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reset_clear()
        Try
            TXT_BILLNO.Text = ""
            TXT_BILLNO.Enabled = True
            txt_custname.Text = ""
            txt_custname.Enabled = True
            txt_add.Text = ""
            txt_add.Enabled = True
            sales_date.Value = Today.Date
            sales_date.Enabled = True
            TXT_BRANDNAME.Text = ""
            TXT_BRANDNAME.Enabled = True
            TXT_PRODNAME.Text = ""
            TXT_PRODNAME.Enabled = True
            TXT_QTY.Text = "0"
            TXT_QTY.Enabled = True
            CBK_UNIT.SelectedIndex = -1
            CBK_UNIT.Enabled = True
            txt_srate.Text = "0.00"
            txt_srate.Enabled = True
            txt_totprice.Text = "0.00"
            txt_totprice.Enabled = True
            gdt.Rows.Clear()
            grid_salret.DataSource = gdt
            tot_retamt.Text = "0.00"
            rd_PROD.Checked = True
            rd_PROD.Enabled = True
            clearitem()
            count()
            sno.Text = grid_salret.Rows.Count
            If rd_PROD.Checked = True Then
                txt_retamt.Visible = False
                lbl1.Visible = False
                lbl2.Visible = False
            Else
                txt_retamt.Visible = True
                lbl1.Visible = True
                lbl2.Visible = True
                txt_retamt.Text = "0.00"
            End If
            TXT_BILLNO.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub grid_clear()
        Try
            CBK_UNIT.Items.Clear()
            grid_salret.DataSource = ""
            tot_retamt.Text = "0.00"
            sno.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub rd_PROD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_PROD.CheckedChanged
        Try
            If rd_PROD.Checked = True Then
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rd_cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_cash.CheckedChanged
        Try
            If rd_PROD.Checked = True Then
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TXT_BILLNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BILLNO.TextChanged
        Try
            If TXT_BILLNO.Text <> "" Then
                Dim billdt As New DataTable
                billdt = SALRET_MAIN(TXT_BILLNO.Text + "%", "", "", "", 0, 0, 0, "VIEW")
                billsearch.DataSource = billdt
                If billsearch.Rows.Count > 0 Then
                    billsearch.Visible = True
                    billsearch.Columns(0).Width = 100
                    billsearch.Columns(1).Width = 100
                    billsearch.Columns(2).Width = 100
                    clearitem()
                    grid_clear()
                    TXT_BILLNO.Focus()
                Else
                    reset_clear()
                    TXT_BILLNO.Text = ""
                    txt_add.Text = ""
                    txt_custname.Text = ""
                    billsearch.Visible = False
                    clearitem()
                    TXT_BILLNO.Focus()
                End If
            Else
                billsearch.Visible = False
                txt_add.Text = ""
                txt_custname.Text = ""
                clearitem()
                TXT_BILLNO.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub billsearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billsearch.DoubleClick
        Try
            TXT_BILLNO.Text = billsearch.CurrentRow.Cells(0).Value
            txt_custname.Text = billsearch.CurrentRow.Cells(1).Value
            txt_custname.Enabled = False
            txt_add.Enabled = False
            txt_add.Text = billsearch.CurrentRow.Cells(2).Value
            billsearch.Visible = False
            TXT_BILLNO.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_BILLNO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_BILLNO.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If billsearch.Visible = True Then
                    billsearch.Focus()
                Else
                    sales_date.Focus()
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

    Private Sub billsearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles billsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                billsearch_DoubleClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sales_date_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sales_date.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                rd_PROD.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                TXT_BILLNO.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rd_PROD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rd_PROD.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                rd_cash.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                sales_date.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                TXT_BRANDNAME.Focus()
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
                TXT_BRANDNAME.Focus()
            ElseIf e.KeyCode = Keys.Up Then
                rd_cash.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                TXT_BRANDNAME.Focus()
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

    Private Sub TXT_BRANDNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BRANDNAME.TextChanged
        Try
            If TXT_BRANDNAME.Text <> "" Then
                Dim bdt As New DataTable
                bdt = SALRET_DETAILS(TXT_BILLNO.Text, TXT_BRANDNAME.Text + "%", "", 0, "", 0, 0, 0, "Brandname")
                If bdt.Rows.Count <> 0 Then
                    BRAND.DataSource = bdt
                    BRAND.Visible = True
                    BRAND.Columns(0).Width = 150
                    TXT_BRANDNAME.Focus()
                Else
                    BRAND.Visible = False
                    TXT_BRANDNAME.Text = ""
                    TXT_PRODNAME.Text = ""
                    CBK_UNIT.Items.Clear()
                    TXT_QTY.Text = "0"
                    txt_srate.Text = "0.00"
                    txt_totprice.Text = "0.00"
                    TXT_BRANDNAME.Focus()
                    product.Visible = False
                End If

            Else
                BRAND.Visible = False
                TXT_BRANDNAME.Text = ""
                TXT_PRODNAME.Text = ""
                CBK_UNIT.Items.Clear()
                TXT_QTY.Text = "0"
                txt_srate.Text = "0.00"
                txt_totprice.Text = "0.00"
                TXT_BRANDNAME.Focus()
                product.Visible = False
                BRAND.Visible = False
                TXT_BRANDNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BRAND_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRAND.DoubleClick
        Try
            TXT_BRANDNAME.Text = BRAND.CurrentRow.Cells(0).Value
            BRAND.Visible = False
            TXT_BRANDNAME.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_BRANDNAME_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_BRANDNAME.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If BRAND.Visible = True Then
                    BRAND.Focus()
                ElseIf TXT_BRANDNAME.Text <> "" Then
                    TXT_PRODNAME.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                TXT_BRANDNAME.Focus()
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

    Private Sub BRAND_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BRAND.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                BRAND_DoubleClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_xit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_PRODNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRODNAME.TextChanged
        Try
            If TXT_BRANDNAME.Text = "" Then
                BRAND.Visible = False
                TXT_BRANDNAME.Text = ""
                TXT_PRODNAME.Text = ""
                CBK_UNIT.Items.Clear()
                TXT_QTY.Text = "0"
                txt_srate.Text = "0.00"
                txt_totprice.Text = "0.00"
                TXT_BRANDNAME.Focus()
                product.Visible = False
            ElseIf TXT_PRODNAME.Text <> "" Then
                Dim prod As New DataTable
                prod = SALRET_DETAILS(Trim(TXT_BILLNO.Text), Trim(TXT_BRANDNAME.Text), Trim(TXT_PRODNAME.Text) + "%", 0, "", 0, 0, 0, "product")
                If prod.Rows.Count <> 0 Then
                    product.Visible = True
                    product.DataSource = prod
                    product.Columns("noofqty").Visible = False
                    product.Columns(0).Width = 150
                Else
                    product.Visible = False
                    TXT_PRODNAME.Text = ""
                    TXT_PRODNAME.Focus()
                End If
            Else
                TXT_QTY.Text = "0"
                CBK_UNIT.Items.Clear()
                txt_srate.Text = "0.00"
                txt_totprice.Text = "0.00"
                product.Visible = False
                TXT_PRODNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub product_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles product.DoubleClick
        Try
            Dim i As Integer
            If product.Rows.Count <> 0 Then
                TXT_PRODNAME.Text = product.CurrentRow.Cells(0).Value
                noofqty = product.CurrentRow.Cells(3).Value
                u2qty = product.CurrentRow.Cells(4).Value
                u1qty = Val(u2qty) / Val(noofqty)
                rate = product.CurrentRow.Cells(5).Value
                txt_pid.Text = product.CurrentRow.Cells(6).Value
                txt_srate.Text = Format(rate, "0.00")
                For i = 0 To product.Rows.Count - 1
                    If product.CurrentRow.Cells(1).Value <> product.CurrentRow.Cells(2).Value Then
                        wholeunit = product.CurrentRow.Cells(1).Value
                        subunit = product.CurrentRow.Cells(2).Value
                        CBK_UNIT.Items.Add(product.CurrentRow.Cells(1).Value)
                        CBK_UNIT.Items.Add(product.CurrentRow.Cells(2).Value)
                    Else
                        wholeunit = ""
                        subunit = product.CurrentRow.Cells(1).Value
                        CBK_UNIT.Items.Add(product.CurrentRow.Cells(1).Value)
                    End If
                Next
                product.Visible = False
                TXT_PRODNAME.Focus()
            Else
                product.Visible = False
                TXT_PRODNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub product_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles product.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                product_DoubleClick(Nothing, Nothing)
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

    Private Sub TXT_PRODNAME_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_PRODNAME.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If product.Visible = True Then
                    product.Focus()
                Else
                    CBK_UNIT.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                TXT_BRANDNAME.Focus()
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
    Private Sub CBK_UNIT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBK_UNIT.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TXT_QTY.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                TXT_PRODNAME.Focus()
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

    Private Sub TXT_QTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_QTY.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = TXT_QTY.Text
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


    Private Sub TXT_QTY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_QTY.TextChanged
        Try
            Dim totqty As Decimal = 0
            Dim cal As Decimal = 0
            If TXT_QTY.Text <> "" And CBK_UNIT.SelectedIndex <> -1 Then
                If grid_salret.RowCount <> 0 Then
                    For gridcnt As Integer = 0 To grid_salret.RowCount - 1
                        If grid_salret.Rows(gridcnt).Cells(1).Value = TXT_BRANDNAME.Text And grid_salret.Rows(gridcnt).Cells(2).Value = TXT_PRODNAME.Text Then
                            totqty = Val(totqty) + grid_salret.Rows(gridcnt).Cells(8).Value
                        End If
                    Next
                End If
                cal = totqty


                If CBK_UNIT.SelectedItem.ToString = wholeunit.ToString Then
                    totqty = Val(totqty) / Val(noofqty)
                    totqty = Val(totqty) + Val(TXT_QTY.Text)
                    cal = Val(cal) / Val(noofqty)
                    If totqty > u1qty Then
                        Dim j As String
                        j = Format((u1qty - cal), "0.00")
                        MsgBox("RemainingQty is  " + j.Substring(0, j.Length - 3) + " " + wholeunit.ToString, MsgBoxStyle.Information, suss)
                        If u1qty = 0 Then
                            TXT_QTY.Text = "0"
                            TXT_QTY.Focus()
                        Else
                            TXT_QTY.Text = j.Substring(0, j.Length - 3)
                            TXT_QTY.Focus()
                            txt_totprice.Text = Val(TXT_QTY.Text) * Val(txt_srate.Text)
                        End If
                    Else
                        txt_totprice.Text = Val(TXT_QTY.Text) * Val(txt_srate.Text)
                    End If
                ElseIf CBK_UNIT.SelectedItem.ToString = subunit.ToString Then
                    totqty = totqty + Val(TXT_QTY.Text)
                    If totqty > u2qty Then
                        MsgBox("RemainingQty is  " + (u2qty - cal).ToString + " " + subunit.ToString, MsgBoxStyle.Information, suss)
                        If u2qty = 0 Then
                            TXT_QTY.Text = "0"
                            TXT_QTY.Focus()
                        Else
                            TXT_QTY.Text = (u2qty - cal).ToString
                            TXT_QTY.Focus()
                            txt_totprice.Text = Val(TXT_QTY.Text) * Val(txt_srate.Text)
                        End If
                    Else
                        txt_totprice.Text = Val(TXT_QTY.Text) * Val(txt_srate.Text)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_QTY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_QTY.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If TXT_QTY.Text <> 0 Then
                    txt_totprice.Focus()
                Else
                    TXT_QTY.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                CBK_UNIT.Focus()
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

    Private Sub txt_totprice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_totprice.KeyDown
        Try
            Dim a As Integer
            Dim noof As Integer
            If e.KeyCode = Keys.Enter Then
                If TXT_QTY.Text = 0 Then
                    MsgBox("Enter Qty Value", MsgBoxStyle.Information, suss)
                ElseIf CBK_UNIT.SelectedIndex = -1 Then
                    MsgBox("Select UnitName", MsgBoxStyle.Information, suss)
                Else
                    If CBK_UNIT.SelectedItem.ToString = wholeunit.ToString Then
                        noof = Val(TXT_QTY.Text) * noofqty
                    Else
                        noof = Val(TXT_QTY.Text)
                    End If
                    For i As Integer = 0 To grid_salret.RowCount - 1
                        If grid_salret.Rows(i).Cells(1).Value = TXT_BRANDNAME.Text And grid_salret.Rows(i).Cells(2).Value = TXT_PRODNAME.Text And grid_salret.Rows(i).Cells(4).Value = CBK_UNIT.SelectedItem.ToString Then
                            grid_salret.Rows(i).Cells(3).Value = Val(TXT_QTY.Text) + grid_salret.Rows(i).Cells(3).Value
                            grid_salret.Rows(i).Cells(6).Value = Val(txt_totprice.Text) + grid_salret.Rows(i).Cells(6).Value
                            grid_salret.Rows(i).Cells(8).Value = Val(noof) + grid_salret.Rows(i).Cells(8).Value
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        gdt.Rows.Add(gdt.Rows.Count + 1, TXT_BRANDNAME.Text, TXT_PRODNAME.Text, Val(TXT_QTY.Text), Trim(CBK_UNIT.Text), Val(txt_srate.Text), Val(txt_totprice.Text), Trim(TXT_BILLNO.Text), Val(noof.ToString), Trim(txt_pid.Text))
                        grid_salret.DataSource = gdt
                        sno.Text = grid_salret.RowCount
                        count()
                        clearitem()
                    Else
                        clearitem()
                        TXT_BRANDNAME.Focus()
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
    Sub count()
        Try
            Dim price As Decimal = 0.0
            For i As Integer = 0 To grid_salret.Rows.Count - 1
                price += grid_salret.Rows(i).Cells(6).Value
            Next
            tot_retamt.Text = Format(price, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub clearitem()
        Try
            txt_brandname.Text = ""
            TXT_PRODNAME.Text = ""
            txt_qty.Text = "0"
            txt_srate.Text = "0.00"
            txt_totprice.Text = "0.00"
            cbk_unit.SelectedIndex = -1
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            Dim rep As String
            Dim str As String
            Dim succ As String
            Dim a As Integer = 0
            If TXT_BILLNO.Text = "" Or txt_add.Text = "" Or (rd_cash.Checked = False And rd_PROD.Checked = False) Or grid_salret.Rows.Count = 0 Then
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
                    ElseIf rd_PROD.Checked = True Then
                        str = "BY PRODUCT"
                        txt_retamt.Text = "0.00"
                    Else
                        MsgBox("SELECT CASH OR PRODUCT", MsgBoxStyle.Information, suss)
                    End If
                    If a <> 2 Then
                        Dim DS As New DataTable
                        DS = SALRET_MAIN(Trim(TXT_BILLNO.Text), Trim(txt_custname.Text), Trim(txt_add.Text), sales_date.Value.ToString("MM/dd/yyyy"), Val(tot_retamt.Text), Val(txt_retamt.Text), str.ToString, "INSERT")
                        If DS.Rows(0)(0) = 1 Then
                            For i As Integer = 0 To grid_salret.RowCount - 1
                                Dim DTT As New DataTable
                                DTT = SALRET_DETAILS(grid_salret.Rows(i).Cells(7).Value, grid_salret.Rows(i).Cells(1).Value, grid_salret.Rows(i).Cells(9).Value, grid_salret.Rows(i).Cells(3).Value, grid_salret.Rows(i).Cells(4).Value, grid_salret.Rows(i).Cells(5).Value, grid_salret.Rows(i).Cells(6).Value, 0, "INSERT")
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

    Private Sub txt_retamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_retamt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = TXT_QTY.Text
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
            i = grid_salret.RowCount
            If i > 0 Then
                c_index = grid_salret.CurrentRow.Index
                Dim del As New Integer
                del = grid_salret.CurrentRow.Index


                grid_salret.Rows.Remove(grid_salret.CurrentRow)
                c_index_value = grid_salret.RowCount
                If c_index_value < 0 Then
                    MsgBox("There is no row", MsgBoxStyle.Critical)
                Else
                    j = grid_salret.RowCount
                    Dim s As Integer

                    For m = c_index To grid_salret.RowCount - 1
                        s = grid_salret.Rows(c_index).Cells(0).Value

                        grid_salret.Rows(c_index).Cells(0).Value = s - 1

                        c_index = c_index + 1

                    Next
                    count()
                    sno.Text = grid_salret.RowCount
                    gdt = grid_salret.DataSource
                    gdt.AcceptChanges()

                End If
                TXT_BRANDNAME.Focus()
            Else
                MessageBox.Show("Oops!There is no Row", "Warning", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CBK_UNIT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBK_UNIT.SelectedIndexChanged
        Try
            If CBK_UNIT.SelectedItem.ToString = wholeunit Then
                txt_srate.Text = Val(rate.ToString) * Val(noofqty.ToString)
                TXT_QTY.Text = "0"
            Else
                txt_srate.Text = Val(rate.ToString)
                TXT_QTY.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_retamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_retamt.TextChanged
        Try
            If Val(txt_retamt.Text) > Val(tot_retamt.Text) Then
                MsgBox("Paid Amt Must Be Less Than TotAmt", MsgBoxStyle.Information, suss)
                txt_retamt.Text = ""
                txt_retamt.Focus()
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

    Private Sub btn_xit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_xit.KeyDown
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
End Class