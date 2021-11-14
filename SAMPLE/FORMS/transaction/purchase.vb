Public Class purchase
    Dim gdt As New DataTable
    Dim viewset As New DataSet
    Dim vatamt As Decimal = 0
    Dim TOTQTY As Decimal = 0
    Dim TOTAMT As Decimal = 0
    Dim disamt As Decimal = 0
    Dim mainvat As Decimal = 0
    Dim maindis As Decimal = 0
    Dim mainnet As Decimal = 0
    Dim paid As Decimal
    Dim bvatp As Integer
    Dim bvatamt As Decimal
    Dim bvattype As String
    Dim bdisp As Integer
    Dim bdisamt As Decimal
    Dim bdistype As String
    Dim wholeunit As String
    Dim subunit As String
    Dim noofqty As Integer
    Dim billno As String
    Dim rate As Decimal
    Dim cnt As String = "LEAVE"
    Public Sub New(ByVal a As String)
        ' This call is required by the Windows Form Designer.
        Try
            InitializeComponent()
            Me.billno = a
            If billno <> "" Then
                TXT_BILLNO.Text = billno
                TXT_BILLNO_Leave(Nothing, Nothing)
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
            Dim vtype As String
            Dim dtype As String
            aa = grid_purchasesearch.Rows(0).Cells(7).Value
            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 2)
            dat = CDate(aa)
            CBK_INVOICEDATE.Value = dat
            CBK_INVOICEDATE.Enabled = False
            TXT_SUPNAME.Text = grid_purchasesearch.Rows(0).Cells(1).Value
            TXT_ADDRESS.Text = grid_purchasesearch.Rows(0).Cells(5).Value
            TXT_SUPNAME.Enabled = False
            TXT_ADDRESS.Enabled = False
            str = grid_purchasesearch.Rows(0).Cells(8).Value
            If str = "Cash" Then
                Radio_cash.Checked = True
                Radio_cash.Enabled = False
                Radio_credit.Enabled = False
            Else
                Radio_credit.Checked = True
                Radio_credit.Enabled = False
                Radio_cash.Enabled = False
            End If
            paid = grid_purchasesearch.Rows(0).Cells(11).Value
            TXT_BILLNO.Enabled = False
            details2()
            vtype = grid_purchasesearch.Rows(0).Cells(12).Value
            If vtype = "Percent" Then
                ck_vat.Checked = True
                txt_billvat.Text = grid_purchasesearch.Rows(0).Cells(13).Value
            Else
                ck_vat.Checked = False
                txt_billvat.Text = grid_purchasesearch.Rows(0).Cells(13).Value
            End If
            dtype = grid_purchasesearch.Rows(0).Cells(14).Value
            If dtype = "Percent" Then
                ck_dis.Checked = True
                txt_billdis.Text = grid_purchasesearch.Rows(0).Cells(15).Value
            Else
                ck_dis.Checked = False
                txt_billdis.Text = grid_purchasesearch.Rows(0).Cells(15).Value
            End If
            txt_Otherexp.Text = grid_purchasesearch.Rows(0).Cells(16).Value
            grid_purchasesearch.Visible = False
            clearitem()
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub details2()
        Try
            If grid_purchasesearch.Rows.Count > 0 Then
                gdt = PURCHASE_PROC(grid_purchasesearch.Rows(0).Cells(0).Value, 0, grid_purchasesearch.Rows(0).Cells(1).Value, grid_purchasesearch.Rows(0).Cells(5).Value, "", "", "", 0, 0, 0, 0, 0, "", 0, "viewdetails", 0, 0, 0, 0, "", 0, 0, "", 0)
                grid_purchase.DataSource = gdt
                sno.Text = grid_purchase.RowCount
                If Radio_cash.Checked = True Then
                    TXT_AMT.Text = tot_lbl.Text
                    TXT_AMT.ReadOnly = True
                    sno.Text = grid_purchase.Rows.Count
                Else
                    TXT_AMT.Text = "0.00"
                    TXT_AMT.ReadOnly = False
                End If
                txt_u2rate.ReadOnly = True
                btn_save.Text = "&UPDATE"
                SUP_GRID.Visible = False
            Else
                MsgBox("No Row Selected")
            End If
            count()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clearitem()
        Try
            txt_brandname.Text = ""
            txt_PRDNAME.Text = ""
            txt_Qty.Text = "0"
            Txt_fqty.Text = "0"
            txt_vat.Text = ""
            TXT_DIS.Text = ""
            txt_prate.Text = "0.00"
            txt_TOTPRICE.Text = "0.00"
            txt_unit.SelectedIndex = -1
            vatamt = 0
            lbl_netamt.Text = "0.00"
            txt_u2rate.Text = "0.00"
            txt_u2rate.ReadOnly = True
            lblvat.Text = ""
            lbldis.Text = ""
            mrp.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub materialitem()
        Try
            Dim dt As New DataTable
            dt = PRODUCT_PROC(txt_brandname.Text + "%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "BRANDNAME", "")
            If dt.Rows.Count = 0 Then
                brand_grid.Visible = False
                txt_brandname.Text = ""
                txt_brandname.Focus()
            ElseIf dt.Rows.Count > 0 Then
                If txt_brandname.Text <> "" Then
                    brand_grid.Visible = True
                    brand_grid.DataSource = dt
                    brand_grid.Columns(0).Width = 150
                End If
            ElseIf dt.Rows.Count = 1 Then
                If txt_brandname.Text <> "" Then
                    txt_brandname.Text = dt.Rows(0)(0)
                    txt_brandname.Focus()
                    brand_grid.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TXT_BILLNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_BILLNO.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If grid_purchasesearch.Visible = True Then
                    grid_purchasesearch.Focus()
                    cnt = "KEY"
                Else
                    Dim view As DataTable
                    If TXT_BILLNO.Text <> "" Then
                        view = PURCHASE_PROC(Trim(TXT_BILLNO.Text), 0, "", "", CBK_STOCKDATE.Value.ToString("MM/dd/yyyy"), CBK_INVOICEDATE.Value.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, "", 0, "View", 0, 0, 0, 0, "", 0, 0, "", 0)
                        grid_purchasesearch.DataSource = view
                        If grid_purchasesearch.RowCount > 0 Then
                            grid_purchasesearch.Visible = True
                            cnt = "KEY"
                            grid_purchasesearch.Columns(0).Width = 100
                            grid_purchasesearch.Columns(1).Width = 200
                            grid_purchasesearch.Columns(2).Width = 250
                            grid_purchasesearch.Columns(3).Width = 100
                            grid_purchasesearch.Columns(4).Visible = False
                            grid_purchasesearch.Columns(5).Width = 150
                            grid_purchasesearch.Columns(6).Width = 100
                            grid_purchasesearch.Columns(7).Width = 100
                            grid_purchasesearch.Columns(9).Visible = False
                            grid_purchasesearch.Columns(8).Width = 100
                            grid_purchasesearch.Columns(10).Visible = False
                            grid_purchasesearch.Columns(11).Visible = False
                            grid_purchasesearch.Columns(12).Visible = False
                            grid_purchasesearch.Columns(13).Visible = False
                            grid_purchasesearch.Columns(14).Visible = False
                            grid_purchasesearch.Columns(15).Visible = False
                            grid_purchasesearch.Columns(16).Visible = False
                            TXT_BILLNO.Focus()
                        Else
                            TXT_SUPNAME.Focus()
                            TXT_ADDRESS.Text = ""
                            TXT_SUPNAME.Text = ""
                            btn_save.Text = "&SAVE"
                            gdt.Rows.Clear()
                            grid_purchase.DataSource = gdt
                            grid_purchasesearch.Visible = False
                        End If
                    Else
                        TXT_BILLNO.Focus()
                        TXT_ADDRESS.Text = ""
                        TXT_SUPNAME.Text = ""
                        btn_save.Text = "&SAVE"
                        gdt.Rows.Clear()
                        grid_purchase.DataSource = gdt
                        grid_purchasesearch.Visible = False
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
    Private Sub TXT_BILLNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_BILLNO.Leave
        Try
            If grid_purchasesearch.Visible = True And cnt = "KEY" Then
                grid_purchasesearch.Focus()
            ElseIf billno <> "" Then
                Dim view As DataTable
                If TXT_BILLNO.Text <> "" Then
                    view = PURCHASE_PROC(Trim(TXT_BILLNO.Text), 0, "", "", CBK_STOCKDATE.Value.ToString("MM/dd/yyyy"), CBK_INVOICEDATE.Value.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, "", 0, "View", 0, 0, 0, 0, "", 0, 0, "", 0)
                    grid_purchasesearch.DataSource = view
                    If grid_purchasesearch.RowCount > 0 Then
                        grid_purchasesearch.Visible = True
                        grid_purchasesearch.Columns(0).Width = 100
                        grid_purchasesearch.Columns(1).Width = 200
                        grid_purchasesearch.Columns(2).Width = 250
                        grid_purchasesearch.Columns(3).Width = 100
                        grid_purchasesearch.Columns(4).Visible = False
                        grid_purchasesearch.Columns(5).Width = 150
                        grid_purchasesearch.Columns(6).Width = 100
                        grid_purchasesearch.Columns(7).Width = 100
                        grid_purchasesearch.Columns(9).Visible = False
                        grid_purchasesearch.Columns(8).Width = 100
                        grid_purchasesearch.Columns(10).Visible = False
                        grid_purchasesearch.Columns(11).Visible = False
                        grid_purchasesearch.Columns(12).Visible = False
                        grid_purchasesearch.Columns(13).Visible = False
                        grid_purchasesearch.Columns(14).Visible = False
                        grid_purchasesearch.Columns(15).Visible = False
                        grid_purchasesearch.Columns(16).Visible = False
                        TXT_BILLNO.Focus()
                    Else
                        TXT_SUPNAME.Focus()
                        TXT_ADDRESS.Text = ""
                        TXT_SUPNAME.Text = ""
                        btn_save.Text = "&SAVE"
                        gdt.Rows.Clear()
                        grid_purchase.DataSource = gdt
                        grid_purchasesearch.Visible = False
                    End If
                Else
                    TXT_SUPNAME.Focus()
                    TXT_ADDRESS.Text = ""
                    TXT_SUPNAME.Text = ""
                    btn_save.Text = "&SAVE"
                    gdt.Rows.Clear()
                    grid_purchase.DataSource = gdt
                    grid_purchasesearch.Visible = False
                End If
            Else
                TXT_SUPNAME.Focus()
                TXT_ADDRESS.Text = ""
                TXT_SUPNAME.Text = ""
                btn_save.Text = "&SAVE"
                gdt.Rows.Clear()
                grid_purchase.DataSource = gdt
                grid_purchasesearch.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub txt_purchasebillno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BILLNO.TextChanged
        Try
            If Trim(TXT_BILLNO.Text) = "" Then
                SUP_GRID.Visible = False
                grid_purchasesearch.Visible = False
                clearitem()
                TXT_BILLNO.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub TXT_SUPNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_SUPNAME.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If TXT_SUPNAME.Text <> "" Then
                    If SUP_GRID.Visible = True Then
                        SUP_GRID.Focus()
                    Else
                        CBK_INVOICEDATE.Focus()
                    End If
                Else
                    TXT_SUPNAME.Focus()
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
    Private Sub txt_suppliername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SUPNAME.TextChanged
        Try
            Dim dt As New DataTable
            If TXT_BILLNO.Text <> "" Then
                If TXT_SUPNAME.Text <> "" Then
                    dt = PURCHASE_PROC("", 0, TXT_SUPNAME.Text + "%", "", Today.Date.ToString("MM/dd/yyyy"), Today.Date.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, Today.Date.ToString("MM/dd/yyyy"), 0, "sup_search", 0, 0, 0, 0, "", 0, 0, "", 0)
                    If dt.Rows.Count > 0 Then
                        SUP_GRID.DataSource = dt
                        SUP_GRID.Visible = True
                        SUP_GRID.Columns(0).Width = 200
                    ElseIf dt.Rows.Count = 0 Then
                        SUP_GRID.Visible = False
                        TXT_SUPNAME.Text = ""
                        TXT_SUPNAME.Focus()
                    Else
                        SUP_GRID.Visible = False
                        TXT_SUPNAME.Text = ""
                    End If
                Else
                    TXT_SUPNAME.Focus()
                    TXT_ADDRESS.Text = ""
                    SUP_GRID.Visible = False
                End If
            Else
                MsgBox("Please Enter BillNo..", MsgBoxStyle.Information, "Message")
                TXT_BILLNO.Text = ""
                TXT_BILLNO.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub reset_clear()
        Try
            Dim dt1 As New DataTable
            gdt.Rows.Clear()
            TXT_AMT.Text = ""
            grid_purchase.DataSource = gdt
            TXT_SUPNAME.Text = ""
            TXT_BILLNO.Text = ""
            CBK_STOCKDATE.Text = Today.Date
            CBK_INVOICEDATE.Text = Today.Date
            TXT_BILLNO.Enabled = True
            TXT_SUPNAME.Enabled = True
            btn_save.Visible = True
            TXT_SUPNAME.Enabled = True
            TXT_ADDRESS.Text = ""
            TXT_ADDRESS.Enabled = True
            grid_itemnames.Visible = False
            SUP_GRID.Visible = False
            tot_lbl.Text = "0.00"
            txt_vat.Text = ""
            lbl_qty.Text = "0"
            clearitem()
            count()
            txt_billvat.Text = "0"
            txt_billdis.Text = "0"
            txt_Otherexp.Text = "0.00"
            ck_vat.Checked = False
            ck_dis.Checked = False
            txt_vat.Text = "0"
            TXT_DIS.Text = "0"
            txt_vat.ReadOnly = False
            TXT_DIS.ReadOnly = False
            txt_u2rate.ReadOnly = False
            Txt_fqty.Text = "0"
            txt_u2rate.Text = "0.00"
            Radio_cash.Enabled = True
            Radio_credit.Enabled = True
            Radio_cash.Checked = False
            Radio_credit.Checked = True
            txt_u2rate.ReadOnly = True
            TXT_BILLNO.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub count()
        Try
            Dim qty As Integer = 0
            Dim price As Decimal = 0.0
            Dim vattot As Decimal = 0.0
            Dim distot As Decimal = 0.0
            Dim vatamt As Decimal = 0.0
            Dim disamt As Decimal = 0.0
            Dim gross As Decimal = 0.0
            For i As Integer = 0 To grid_purchase.Rows.Count - 1
                qty += grid_purchase.Rows(i).Cells(3).Value
                price += grid_purchase.Rows(i).Cells(10).Value
                vattot += grid_purchase.Rows(i).Cells(5).Value
                distot += grid_purchase.Rows(i).Cells(7).Value
                vatamt += grid_purchase.Rows(i).Cells(6).Value
                disamt += grid_purchase.Rows(i).Cells(8).Value
                gross += grid_purchase.Rows(i).Cells(12).Value
            Next
            lbl_qty.Text = qty
            tot_lbl.Text = Format(price, "0.00")
            mainnet = Val(tot_lbl.Text)
            totvat.Text = Format(System.Math.Round(Val(vatamt)), "0.00")
            mainvat = Val(totvat.Text)
            discount.Text = Format(System.Math.Round(Val(disamt)), "0.00")
            maindis = Val(discount.Text)
            lblvat.Text = Format(vattot, "0.00")
            lbldis.Text = Format(distot, "0.00")
            tot_Gross.Text = Format(gross, "0.00")
            If tot_lbl.Text <> "" And Val(tot_lbl.Text) <> 0 And Val(paid.ToString) <> 0 Then
                TXT_AMT.Text = Val(paid.ToString)
                paid = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If billno.ToString = "" Then
                Radio_credit.Checked = True
                reset_clear()
                gdt.Columns.Add("SNo")
                gdt.Columns.Add("BrandName")
                gdt.Columns.Add("ProductName")
                gdt.Columns.Add("Qty")
                gdt.Columns.Add("Unit")
                gdt.Columns.Add("Vat")
                gdt.Columns.Add("vatamt")
                gdt.Columns.Add("Discount")
                gdt.Columns.Add("disamt")
                gdt.Columns.Add("Rate")
                gdt.Columns.Add("Price")
                gdt.Columns.Add("Billno")
                gdt.Columns.Add("GROSSAMT")
                gdt.Columns.Add("FQTY")
                gdt.Columns.Add("FUNIT")
                gdt.Columns.Add("Pid")
                grid_purchase.DataSource = gdt
                grid_purchase.Columns(0).Width = 50
                grid_purchase.Columns(1).Width = 150
                grid_purchase.Columns(2).Width = 200
                grid_purchase.Columns(3).Width = 75
                grid_purchase.Columns(4).Width = 100
                grid_purchase.Columns(5).Width = 75
                grid_purchase.Columns(6).Width = 75
                grid_purchase.Columns(7).Width = 75
                grid_purchase.Columns(8).Width = 75
                grid_purchase.Columns(9).Width = 75
                grid_purchase.Columns(10).Width = 100
                grid_purchase.Columns(11).Width = 50
                grid_purchase.Columns(12).Width = 100
                grid_purchase.Columns(13).Width = 75
                grid_purchase.Columns(14).Width = 100
                grid_purchase.Columns("billno").Visible = False
                grid_purchase.Columns("vatamt").Visible = False
                grid_purchase.Columns("disamt").Visible = False
                grid_purchase.Columns("GROSSAMT").Visible = False
                grid_purchase.Columns("FQTY").Visible = True
                grid_purchase.Columns("FUNIT").Visible = True
                grid_purchase.Columns("Pid").Visible = False
            Else
                grid_purchase.Columns(0).Width = 50
                grid_purchase.Columns(1).Width = 150
                grid_purchase.Columns(2).Width = 200
                grid_purchase.Columns(3).Width = 75
                grid_purchase.Columns(4).Width = 100
                grid_purchase.Columns(5).Width = 75
                grid_purchase.Columns(6).Width = 75
                grid_purchase.Columns(7).Width = 75
                grid_purchase.Columns(8).Width = 75
                grid_purchase.Columns(9).Width = 75
                grid_purchase.Columns(10).Width = 100
                grid_purchase.Columns(11).Width = 50
                grid_purchase.Columns(12).Width = 100
                grid_purchase.Columns(13).Width = 75
                grid_purchase.Columns(14).Width = 100
                grid_purchase.Columns("billno").Visible = False
                grid_purchase.Columns("vatamt").Visible = False
                grid_purchase.Columns("disamt").Visible = False
                grid_purchase.Columns("GROSSAMT").Visible = False
                grid_purchase.Columns("FQTY").Visible = True
                grid_purchase.Columns("FUNIT").Visible = True
                grid_purchase.Columns("Pid").Visible = False
            End If
            TXT_BILLNO.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CBK_STOCKDATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBK_STOCKDATE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                CBK_INVOICEDATE.Focus()
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
    Private Sub TXT_AMT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_AMT.KeyDown
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
    Private Sub TXT_AMT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_AMT.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = TXT_AMT.Text
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
    Private Sub txt_TOTPRICE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TOTPRICE.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub TXT_ADDRESS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ADDRESS.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or TXT_ADDRESS.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKeysinglequote(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub SUP_GRID_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SUP_GRID.DoubleClick
        Try
            Dim a As String
            Dim B As String
            Dim c As String
            If SUP_GRID.RowCount <> 0 Then
                a = SUP_GRID.Rows(SUP_GRID.CurrentRow.Index).Cells(0).Value
                B = SUP_GRID.Rows(SUP_GRID.CurrentRow.Index).Cells(1).Value
                c = SUP_GRID.Rows(SUP_GRID.CurrentRow.Index).Cells(2).Value
                TXT_SUPNAME.Text = a
                TXT_ADDRESS.Text = B
                TXT_ADDRESS.Enabled = False
                SUP_GRID.Visible = False
                txt_brandname.Focus()
                If TXT_BILLNO.Text <> "" Or TXT_SUPNAME.Text <> "" Then
                    Dim DT As New DataTable
                    DT = PURCHASE_PROC(TXT_BILLNO.Text, 0, TXT_SUPNAME.Text, TXT_ADDRESS.Text, Today.Date.ToString("MM/dd/yyyy"), Today.Date.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, Today.Date.ToString("MM/dd/yyyy"), 0, "CHECKBILL", 0, 0, 0, 0, "", 0, 0, "", 0)
                    If DT.Rows(0)(0) = -12 Then
                        CBK_INVOICEDATE.Focus()
                    Else
                        MsgBox("BillNo & Supplier Already Exists..", MsgBoxStyle.Information, "Message")
                        TXT_SUPNAME.Text = ""
                        TXT_ADDRESS.Text = ""
                        TXT_BILLNO.Text = ""
                        TXT_BILLNO.Focus()
                    End If
                Else

                End If
            Else
                TXT_SUPNAME.Text = ""
                TXT_ADDRESS.Text = ""
                TXT_SUPNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub SUP_GRID_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SUP_GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SUP_GRID_DoubleClick1(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Left Then
                TXT_SUPNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_PRDNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PRDNAME.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_brandname.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                'Button1.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                If grid_itemnames.Visible = True Then
                    grid_itemnames.Focus()
                ElseIf txt_PRDNAME.Text = "" Then
                    txt_PRDNAME.Focus()
                Else
                    txt_Qty.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_PRDNAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PRDNAME.KeyPress
        Try
            e.Handled = TrapKeysinglequote(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_PRDNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PRDNAME.TextChanged
        Try
            If txt_brandname.Text <> "" And txt_PRDNAME.Text <> "" Then
                Dim IDT As New DataTable
                IDT = PURCHASE_PROC("", 0, txt_brandname.Text, txt_PRDNAME.Text + "%", Today.Date.ToString("MM/dd/yyyy"), Today.Date.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, Today.Date.ToString("MM/dd/yyyy"), 0, "PRD_SRCH", 0, 0, 0, 0, "", 0, 0, "", 0)
                If IDT.Rows.Count > 0 Then
                    grid_itemnames.Visible = True
                    grid_itemnames.DataSource = IDT
                    grid_itemnames.Columns(1).Width = 300
                ElseIf IDT.Rows.Count = 0 Then
                    grid_itemnames.Visible = False
                    txt_PRDNAME.Text = ""
                Else
                    grid_itemnames.Visible = False
                End If
            ElseIf txt_PRDNAME.Text = "" Then
                txt_PRDNAME.Focus()
                txt_u2rate.ReadOnly = True
                grid_itemnames.Visible = False
            Else
                txt_brandname.Focus()
                txt_u2rate.ReadOnly = True
                grid_itemnames.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub grid_itemnames_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_itemnames.DoubleClick
        Try
            Dim a As Integer
            Dim b As String
            Dim c As Decimal
            Dim d As String
            Dim e1 As String
            Dim f As String
            Dim g As Decimal
            If grid_itemnames.RowCount <> 0 Then
                a = grid_itemnames.CurrentRow.Cells(0).Value
                b = grid_itemnames.CurrentRow.Cells(1).Value
                c = grid_itemnames.CurrentRow.Cells(2).Value
                d = grid_itemnames.CurrentRow.Cells(3).Value
                e1 = grid_itemnames.CurrentRow.Cells(4).Value
                f = grid_itemnames.CurrentRow.Cells(5).Value
                g = grid_itemnames.CurrentRow.Cells(6).Value
                noofqty = grid_itemnames.CurrentRow.Cells(7).Value
                mrp.Text = g
                txt_u2rate.Text = Format(c, "0.00")
                rate = Format(c, "0.00")
                txt_pid.Text = a
                txt_PRDNAME.Text = b
                item()
                grid_itemnames.Visible = False
                txt_Qty.Focus()
            Else
                txt_PRDNAME.Text = ""
                txt_unit.Items.Clear()
                txt_prate.Text = "0.00"
                txt_PRDNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub item()
        Try
            Dim i As Integer
            Dim IDT As New DataTable
            IDT = PURCHASE_PROC("", 0, txt_brandname.Text, txt_PRDNAME.Text + "%", Today.Date.ToString("MM/dd/yyyy"), Today.Date.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, Today.Date.ToString("MM/dd/yyyy"), 0, "PRD_SRCH", 0, 0, 0, 0, "", 0, 0, "", 0)
            txt_unit.Items.Clear()
            For i = 0 To IDT.Rows.Count - 1
                If IDT.Rows(i).Item(3) <> IDT.Rows(i).Item(4) Then
                    txt_unit.Items.Add(IDT.Rows(i).Item(3))
                    txt_unit.Items.Add(IDT.Rows(i).Item(4))
                    wholeunit = IDT.Rows(i).Item(3)
                    subunit = IDT.Rows(i).Item(4)
                Else
                    txt_unit.Items.Add(IDT.Rows(i).Item(3))
                    subunit = IDT.Rows(i).Item(3)
                    wholeunit = "null"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_unit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_unit.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_unit.Text <> "" Then
                    If txt_Qty.Text <> 0 Then
                        txt_vat.Focus()
                    ElseIf Txt_fqty.Text <> 0 Then
                        txt_TOTPRICE.Focus()
                    End If
                Else
                    txt_unit.Focus()
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
    Private Sub txt_matname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_brandname.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                If brand_grid.Visible = True Then
                    brand_grid.Focus()
                ElseIf txt_brandname.Text = "" Then
                    txt_brandname.Focus()
                Else
                    txt_PRDNAME.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub txt_Qty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Qty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_Qty.Text = "" Then
                    txt_Qty.Text = 0
                Else
                    Txt_fqty.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_PRDNAME.Focus()
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
    Private Sub txt_Qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Qty.TextChanged
        Try
            If txt_Qty.Text <> "" Then
                If IsNumeric(txt_Qty.Text) = True Then
                    If txt_prate.Text <> "" Then
                        If IsNumeric(txt_Qty.Text) = True Then
                            txt_TOTPRICE.Text = Val(txt_prate.Text) * Val(txt_Qty.Text)
                            Dim totprice As Decimal = 0.0
                            totprice = txt_TOTPRICE.Text
                            txt_TOTPRICE.Text = Format(totprice, "0.00")
                            vatamount()
                            Discount1()
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_TOTPRICE.Text = Format(totprice, "0.00")
            End If
            txt_vat.Text = "0"
            TXT_DIS.Text = "0"
            txt_vat.ReadOnly = False
            TXT_DIS.ReadOnly = False
            txt_u2rate.ReadOnly = False
            Txt_fqty.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub txt_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_unit.SelectedIndexChanged
        Try
            Dim DT As New DataTable
            Dim rate1 As Decimal
            If txt_unit.SelectedIndex <> -1 Then
                DT = PURCHASEDETAILS_PROC(0, "", Trim(txt_brandname.Text), Trim(txt_PRDNAME.Text), 0, txt_unit.SelectedItem.ToString(), 0, "", 0, 0, 0, 0, 0, 0, 0, "RATE_SRCH", "", "")
                rate1 = DT.Rows(0)(0)
                txt_prate.Text = Format(rate1, "0.00")
                txt_u2rate.Text = Format(rate, "0.00")
                If txt_unit.Text = wholeunit Then
                    txt_prate.Text = Val(txt_u2rate.Text) * noofqty
                Else
                    txt_prate.Text = txt_u2rate.Text
                End If
                txt_u2rate.ReadOnly = True
                Quantity()
                vatamount()
                Discount1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Quantity()
        Try
            If txt_Qty.Text <> "" Then
                If IsNumeric(txt_Qty.Text) = True Then
                    If txt_prate.Text <> "" Then
                        If IsNumeric(txt_Qty.Text) = True Then
                            txt_TOTPRICE.Text = Val(txt_prate.Text) * Val(txt_Qty.Text)
                            Dim totprice As Decimal = 0.0
                            totprice = txt_TOTPRICE.Text
                            txt_TOTPRICE.Text = Format(totprice, "0.00")
                        End If
                    End If
                End If
            Else
                Dim totprice As Decimal = 0.0
                txt_TOTPRICE.Text = Format(totprice, "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub grid_itemnames_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_itemnames.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                grid_itemnames_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Left Then
                txt_PRDNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_vat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_vat.TextChanged
        Try
            Quantity()
            vatamount()
            Discount1()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub vatamount()
        Try
            If txt_vat.Text = "" Or Val(txt_vat.Text) = 0 Then
                lbl_netamt.Text = txt_TOTPRICE.Text
                vatamt = 0
            Else
                vatamt = Val(txt_TOTPRICE.Text) * (Val(txt_vat.Text) / 100)
                lbl_netamt.Text = Val(txt_TOTPRICE.Text) + vatamt
            End If
            lbl_netamt.Text = Format(System.Math.Round(Val(lbl_netamt.Text)), "0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Sub Discount1()
        Try
            If TXT_DIS.Text = "" Or Val(TXT_DIS.Text) = 0 Then
                totdis.Text = lbl_netamt.Text
                disamt = 0
            Else
                disamt = Val(lbl_netamt.Text) * (Val(TXT_DIS.Text) / 100)
                totdis.Text = Val(lbl_netamt.Text) - disamt
            End If
            txt_TOTPRICE.Text = Format(System.Math.Round(Val(totdis.Text)), "0.00")
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
            If TXT_SUPNAME.Text = "" Or TXT_BILLNO.Text = "" Or TXT_ADDRESS.Text = "" Or (Radio_cash.Checked = False And Radio_credit.Checked = False) Or grid_purchase.Rows.Count = 0 Then
                MsgBox("Please Fill the fields", MsgBoxStyle.Information)
                TXT_BILLNO.Focus()
            Else
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    If btn_save.Text = "&SAVE" Then
                        If Radio_cash.Checked = True Then
                            str = "Cash"
                        Else
                            str = "Credit"
                        End If
                        If str = "Cash" Or str = "Credit" Then
                            If TXT_AMT.Text = "" Then
                                MsgBox("please give some amount")
                                TXT_AMT.Text = ""
                                TXT_AMT.Focus()
                            ElseIf TXT_AMT.Text <> "" Then
                                Dim ds As New DataTable
                                ds = PURCHASE_PROC(Trim(TXT_BILLNO.Text), 0, TXT_SUPNAME.Text, TXT_ADDRESS.Text, CBK_STOCKDATE.Value.ToString("MM/dd/yyyy"), CBK_INVOICEDATE.Value.ToString("MM/dd/yyyy"), str, Val(tot_lbl.Text), lblvat.Text, totvat.Text, Val(discount.Text), 0, Today.Date.ToString("MM/dd/yyyy"), Val(TXT_AMT.Text), "INSERT", Val(lbldis.Text), Val(tot_Gross.Text), Val(bvatp), Val(bvatamt), bvattype, Val(bdisp), bdisamt, bdistype, Val(txt_Otherexp.Text))
                                If ds.Rows(0)(0) = 1 Then
                                    For i As Integer = 0 To grid_purchase.RowCount - 1
                                        Dim DTT As New DataTable
                                        DTT = PURCHASEDETAILS_PROC(0, grid_purchase.Rows(i).Cells(11).Value, grid_purchase.Rows(i).Cells(1).Value, grid_purchase.Rows(i).Cells(15).Value, grid_purchase.Rows(i).Cells(3).Value, grid_purchase.Rows(i).Cells(4).Value, grid_purchase.Rows(i).Cells(13).Value, grid_purchase.Rows(i).Cells(14).Value, grid_purchase.Rows(i).Cells(9).Value, grid_purchase.Rows(i).Cells(5).Value, grid_purchase.Rows(i).Cells(6).Value, grid_purchase.Rows(i).Cells(7).Value, grid_purchase.Rows(i).Cells(8).Value, grid_purchase.Rows(i).Cells(12).Value, grid_purchase.Rows(i).Cells(10).Value, "INSERT", TXT_SUPNAME.Text, "")
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
                        Else
                            MsgBox("Select Cash or Credit.", MsgBoxStyle.Information, "Message")
                            Radio_cash.Focus()
                        End If
                    Else
                        If TXT_SUPNAME.Text = "" Or TXT_ADDRESS.Text = "" Then
                            MsgBox("Please Select SupplierName", MsgBoxStyle.Information, "Message")
                            TXT_SUPNAME.Focus()
                        Else
                            If grid_purchase.RowCount <> 0 Then
                                If Radio_cash.Checked = True Then
                                    str = "Cash"
                                Else
                                    str = "Credit"
                                End If
                                If str = "Cash" Or str = "Credit" Then
                                    If TXT_AMT.Text = "" Then
                                        MsgBox("please give some amount")
                                        TXT_AMT.Text = ""
                                        TXT_AMT.Focus()
                                    ElseIf TXT_AMT.Text <> "" Then
                                        Dim ds As New DataTable
                                        ds = PURCHASE_PROC(Trim(TXT_BILLNO.Text), 0, TXT_SUPNAME.Text, TXT_ADDRESS.Text, CBK_STOCKDATE.Value.ToString("MM/dd/yyyy"), CBK_INVOICEDATE.Value.ToString("MM/dd/yyyy"), str, Val(tot_lbl.Text), Val(lblvat.Text), Val(totvat.Text), Val(discount.Text), 0, Today.Date.ToString("MM/dd/yyyy"), Val(TXT_AMT.Text), "Update", Val(lbldis.Text), Val(tot_Gross.Text), Val(bvatp), Val(bvatamt), bvattype, Val(bdisp), bdisamt, bdistype, Val(txt_Otherexp.Text))
                                        If ds.Rows(0)(0) = 1 Then
                                            For i As Integer = 0 To grid_purchase.RowCount - 1
                                                Dim DTT As New DataTable
                                                DTT = PURCHASEDETAILS_PROC(0, grid_purchase.Rows(i).Cells(11).Value, grid_purchase.Rows(i).Cells(1).Value, grid_purchase.Rows(i).Cells(15).Value, grid_purchase.Rows(i).Cells(3).Value, grid_purchase.Rows(i).Cells(4).Value, grid_purchase.Rows(i).Cells(13).Value, grid_purchase.Rows(i).Cells(14).Value, grid_purchase.Rows(i).Cells(9).Value, grid_purchase.Rows(i).Cells(5).Value, grid_purchase.Rows(i).Cells(6).Value, grid_purchase.Rows(i).Cells(7).Value, grid_purchase.Rows(i).Cells(8).Value, grid_purchase.Rows(i).Cells(12).Value, grid_purchase.Rows(i).Cells(10).Value, "INSERT", TXT_SUPNAME.Text, "")
                                                succ = DTT.Rows(0)(0)
                                            Next
                                            If succ = "1" Then
                                                MsgBox("Succesfully Updated", MsgBoxStyle.Information, "Message")
                                                reset_clear()
                                            Else
                                                MsgBox("Not Updated", MsgBoxStyle.Information, "Message")
                                            End If
                                        End If
                                    End If
                                Else
                                    MsgBox("Select Cash or Credit.", MsgBoxStyle.Information, "Message")
                                    Radio_cash.Focus()
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

    Private Sub TXT_AMT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_AMT.TextChanged
        Try
            If btn_save.Text = "&SAVE" Then
                If Val(TXT_AMT.Text) > Val(tot_lbl.Text) Then
                    MsgBox("Paid Amt Must Be Less Than TotAmt", MsgBoxStyle.Information, suss)
                    TXT_AMT.Text = ""
                    TXT_AMT.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_matname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_brandname.TextChanged
        Try
            If TXT_BILLNO.Text = "" Then
                txt_brandname.Text = ""
                TXT_BILLNO.Focus()
            ElseIf TXT_SUPNAME.Text = "" Then
                txt_brandname.Text = ""
                TXT_SUPNAME.Focus()
            ElseIf txt_brandname.Text <> "" Then
                txt_PRDNAME.Text = ""
                txt_Qty.Text = "0"
                txt_unit.Items.Clear()
                txt_prate.Text = "0.00"
                txt_vat.Text = ""
                TXT_DIS.Text = ""
                txt_TOTPRICE.Text = "0.00"
                materialitem()
            Else
                grid_itemnames.Visible = False
                txt_PRDNAME.Text = ""
                txt_Qty.Text = "0"
                txt_unit.Items.Clear()
                txt_prate.Text = "0.00"
                txt_vat.Text = ""
                TXT_DIS.Text = ""
                txt_TOTPRICE.Text = "0.00"
                brand_grid.Visible = False
                txt_u2rate.ReadOnly = True
                txt_brandname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub material_grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brand_grid.DoubleClick
        Try
            Dim a As String
            If brand_grid.RowCount <> 0 Then
                a = brand_grid.CurrentRow.Cells(0).Value
                txt_brandname.Text = a
                brand_grid.Visible = False
                txt_PRDNAME.Focus()
            Else
                txt_PRDNAME.Text = ""
                txt_unit.Text = ""
                txt_prate.Text = ""
                txt_brandname.Text = ""
                txt_brandname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub material_grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles brand_grid.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                material_grid_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Left Then
                txt_PRDNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CBK_INVOICEDATE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBK_INVOICEDATE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_brandname.Focus()
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

    Private Sub txt_vat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_vat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_vat.Text <> "" Then
                    txt_u2rate.Focus()
                Else
                    txt_vat.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_unit.Focus()
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
                    txt_TOTPRICE.Focus()
                Else
                    TXT_DIS.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_prate.Focus()
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
    Private Sub txt_TOTPRICE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TOTPRICE.KeyDown
        Try
            Dim a As Integer
            Dim GR As Integer
            Dim re As Integer
            If e.KeyCode = Keys.Enter Then
                Dim b As String = subunit.ToString
                discount.Text = "0"
                totvat.Text = "0"
                tot_lbl.Text = "0"
                GR = (Val(txt_Qty.Text) * Val(txt_prate.Text))
                If txt_brandname.Text = "" Or txt_PRDNAME.Text = "" Then
                    MsgBox("Please Enter the material name and Item Name", MsgBoxStyle.Information)
                    txt_brandname.Focus()
                ElseIf txt_Qty.Text = "" Then
                    MsgBox("Please Enter the Qty value.", MsgBoxStyle.Information)
                    txt_Qty.Focus()
                ElseIf txt_vat.Text = "" Then
                    MsgBox("Please Enter vat value.", MsgBoxStyle.Information, suss)
                    txt_vat.Focus()
                ElseIf TXT_DIS.Text = "" Then
                    MsgBox("Please Enter the discount", MsgBoxStyle.Information, suss)
                    TXT_DIS.Focus()
                ElseIf txt_unit.SelectedIndex = -1 Then
                    MsgBox("Please select unit value.", MsgBoxStyle.Information, suss)
                    txt_unit.Focus()
                ElseIf Txt_fqty.Text <> 0 And Val(txt_u2rate.Text) <> 0 Then
                    For i As Integer = 0 To grid_purchase.RowCount - 1
                        If grid_purchase.Rows(i).Cells(2).Value = txt_PRDNAME.Text And grid_purchase.Rows(i).Cells(1).Value = txt_brandname.Text And grid_purchase.Rows(i).Cells(4).Value = txt_unit.SelectedItem.ToString Then
                            grid_purchase.Rows(i).Cells(3).Value = Val(txt_Qty.Text) + grid_purchase.Rows(i).Cells(3).Value
                            grid_purchase.Rows(i).Cells(10).Value = Val(txt_TOTPRICE.Text) + grid_purchase.Rows(i).Cells(10).Value
                            grid_purchase.Rows(i).Cells(5).Value = Val(txt_vat.Text) + grid_purchase.Rows(i).Cells(5).Value
                            grid_purchase.Rows(i).Cells(6).Value = Val(vatamt.ToString) + grid_purchase.Rows(i).Cells(6).Value
                            grid_purchase.Rows(i).Cells(7).Value = Val(TXT_DIS.Text) + grid_purchase.Rows(i).Cells(7).Value
                            grid_purchase.Rows(i).Cells(8).Value = Val(disamt.ToString) + grid_purchase.Rows(i).Cells(8).Value
                            grid_purchase.Rows(i).Cells(12).Value = Val(GR.ToString) + grid_purchase.Rows(i).Cells(12).Value
                            If txt_unit.Text = wholeunit.ToString Then
                                re = Val(Txt_fqty.Text) * Val(noofqty.ToString)
                                grid_purchase.Rows(i).Cells(13).Value = grid_purchase.Rows(i).Cells(13).Value + Val(re.ToString)
                                grid_purchase.Rows(i).Cells(14).Value = subunit.ToString
                            Else
                                grid_purchase.Rows(i).Cells(13).Value = Val(Txt_fqty.Text) + grid_purchase.Rows(i).Cells(13).Value
                                grid_purchase.Rows(i).Cells(14).Value = subunit.ToString
                            End If
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        If txt_unit.Text = wholeunit.ToString Then
                            re = Val(Txt_fqty.Text) * Val(noofqty.ToString)
                        Else
                            re = Val(Txt_fqty.Text)
                        End If
                        gdt.Rows.Add(gdt.Rows.Count + 1, txt_brandname.Text, txt_PRDNAME.Text, Val(txt_Qty.Text), Trim(txt_unit.Text), Val(txt_vat.Text), Val(vatamt.ToString), Val(TXT_DIS.Text), Val(disamt.ToString), Val(txt_prate.Text), Val(txt_TOTPRICE.Text), Trim(TXT_BILLNO.Text), Val(GR.ToString), Trim(re.ToString), Trim(subunit.ToString), Trim(txt_pid.Text))
                        grid_purchase.DataSource = gdt
                        sno.Text = grid_purchase.RowCount
                        count()
                        If Radio_cash.Checked = True And btn_save.Text = "&SAVE" Then
                            TXT_AMT.Text = tot_lbl.Text
                            TXT_AMT.ReadOnly = True
                        ElseIf Radio_credit.Checked = True And btn_save.Text = "&SAVE" Then
                            TXT_AMT.Text = "0.00"
                            TXT_AMT.ReadOnly = False
                        End If
                        clearitem()
                    Else
                        clearitem()
                        txt_brandname.Focus()
                    End If
                    count()
                    txt_u2rate.ReadOnly = True
                    ck_vat.Checked = False
                    ck_dis.Checked = False
                    txt_billvat.Text = "0"
                    txt_billdis.Text = "0"
                    txt_Otherexp.Text = "0.00"
                ElseIf txt_Qty.Text <> 0 And Val(txt_u2rate.Text) <> 0 Then
                    For i As Integer = 0 To grid_purchase.RowCount - 1
                        If grid_purchase.Rows(i).Cells(2).Value = txt_PRDNAME.Text And grid_purchase.Rows(i).Cells(1).Value = txt_brandname.Text And grid_purchase.Rows(i).Cells(4).Value = txt_unit.SelectedItem.ToString Then
                            grid_purchase.Rows(i).Cells(3).Value = Val(txt_Qty.Text) + grid_purchase.Rows(i).Cells(3).Value
                            grid_purchase.Rows(i).Cells(10).Value = Val(txt_TOTPRICE.Text) + grid_purchase.Rows(i).Cells(10).Value
                            grid_purchase.Rows(i).Cells(5).Value = Val(txt_vat.Text) + grid_purchase.Rows(i).Cells(5).Value
                            grid_purchase.Rows(i).Cells(6).Value = Val(vatamt.ToString) + grid_purchase.Rows(i).Cells(6).Value
                            grid_purchase.Rows(i).Cells(7).Value = Val(TXT_DIS.Text) + grid_purchase.Rows(i).Cells(7).Value
                            grid_purchase.Rows(i).Cells(8).Value = Val(disamt.ToString) + grid_purchase.Rows(i).Cells(8).Value
                            grid_purchase.Rows(i).Cells(12).Value = Val(GR.ToString) + grid_purchase.Rows(i).Cells(12).Value
                            a = 1
                        End If
                    Next
                    If a <> 1 Then
                        re = Val(Txt_fqty.Text)
                        gdt.Rows.Add(gdt.Rows.Count + 1, txt_brandname.Text, txt_PRDNAME.Text, Val(txt_Qty.Text), Trim(txt_unit.Text), Val(txt_vat.Text), Val(vatamt.ToString), Val(TXT_DIS.Text), Val(disamt.ToString), Val(txt_prate.Text), Val(txt_TOTPRICE.Text), Trim(TXT_BILLNO.Text), Val(GR.ToString), Trim(re.ToString), Trim(subunit.ToString), Trim(txt_pid.Text))
                        grid_purchase.DataSource = gdt
                        sno.Text = grid_purchase.RowCount
                        count()
                        If Radio_cash.Checked = True And btn_save.Text = "&SAVE" Then
                            TXT_AMT.Text = tot_lbl.Text
                            TXT_AMT.ReadOnly = True
                        ElseIf Radio_credit.Checked = True And btn_save.Text = "&SAVE" Then
                            TXT_AMT.Text = "0.00"
                            TXT_AMT.ReadOnly = False
                        End If
                        clearitem()
                    Else
                        clearitem()
                        txt_brandname.Focus()
                    End If
                    count()
                    txt_u2rate.ReadOnly = True
                    ck_vat.Checked = False
                    ck_dis.Checked = False
                    txt_billvat.Text = "0"
                    txt_billdis.Text = "0"
                    txt_Otherexp.Text = "0.00"
                Else
                    MsgBox("Select Qty Or U2-Prate Value", MsgBoxStyle.Information, suss)
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset_clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                TXT_DIS.Focus()
            End If
                grid_itemnames.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub Radio_cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_cash.CheckedChanged
        Try
            If Radio_cash.Checked = True Then
                TXT_AMT.Text = tot_lbl.Text
                TXT_AMT.ReadOnly = True
            Else
                TXT_AMT.Text = "0.00"
                TXT_AMT.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Radio_credit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_credit.CheckedChanged
        Try
            If Radio_cash.Checked = True Then
                TXT_AMT.Text = tot_lbl.Text
                TXT_AMT.ReadOnly = True
            Else
                TXT_AMT.Text = "0.00"
                TXT_AMT.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid_purchasesearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_purchasesearch.DoubleClick
        Try
            Dim dat As Date
            Dim aa As String
            Dim str As String
            Dim dtype As String
            Dim vtype As String
            aa = grid_purchasesearch.CurrentRow.Cells(7).Value
            aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
            dat = CDate(aa)
            CBK_INVOICEDATE.Value = dat
            CBK_INVOICEDATE.Enabled = False
            TXT_SUPNAME.Text = grid_purchasesearch.CurrentRow.Cells(1).Value
            TXT_ADDRESS.Text = grid_purchasesearch.CurrentRow.Cells(5).Value
            TXT_SUPNAME.Enabled = False
            TXT_ADDRESS.Enabled = False
            str = grid_purchasesearch.CurrentRow.Cells(8).Value
            If str = "Cash" Then
                Radio_cash.Checked = True
                Radio_cash.Enabled = False
                Radio_credit.Enabled = False
            Else
                Radio_credit.Checked = True
                Radio_credit.Enabled = False
                Radio_cash.Enabled = False
            End If
            paid = grid_purchasesearch.CurrentRow.Cells(11).Value
            TXT_BILLNO.Enabled = False
            details()
            vtype = grid_purchasesearch.CurrentRow.Cells(12).Value
            If vtype = "Percent" Then
                ck_vat.Checked = True
                txt_billvat.Text = grid_purchasesearch.CurrentRow.Cells(13).Value
            Else
                ck_vat.Checked = False
                txt_billvat.Text = grid_purchasesearch.CurrentRow.Cells(13).Value
            End If
            dtype = grid_purchasesearch.CurrentRow.Cells(14).Value
            If dtype = "Percent" Then
                ck_dis.Checked = True
                txt_billdis.Text = grid_purchasesearch.CurrentRow.Cells(15).Value
            Else
                ck_dis.Checked = False
                txt_billdis.Text = grid_purchasesearch.CurrentRow.Cells(15).Value
            End If
            txt_Otherexp.Text = grid_purchasesearch.CurrentRow.Cells(16).Value
            txt_u2rate.ReadOnly = True
            grid_purchasesearch.Visible = False
            txt_brandname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub details()
        Try
            If grid_purchasesearch.Rows.Count > 0 Then
                gdt = PURCHASE_PROC(grid_purchasesearch.CurrentRow.Cells(0).Value, 0, grid_purchasesearch.CurrentRow.Cells(1).Value, grid_purchasesearch.CurrentRow.Cells(5).Value, "", "", "", 0, 0, 0, 0, 0, "", 0, "viewdetails", 0, 0, 0, 0, "", 0, 0, "", 0)
                grid_purchase.DataSource = gdt
                sno.Text = grid_purchase.RowCount
                If Radio_cash.Checked = True Then
                    TXT_AMT.Text = tot_lbl.Text
                    TXT_AMT.ReadOnly = True
                Else
                    TXT_AMT.Text = "0.00"
                    TXT_AMT.ReadOnly = False
                End If
                clearitem()
                btn_save.Text = "&UPDATE"
                SUP_GRID.Visible = False
            Else
                MsgBox("No Row Selected")
            End If
            count()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub grid_purchasesearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_purchasesearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                grid_purchasesearch_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                grid_purchasesearch.Visible = False
                TXT_SUPNAME.Focus()
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
            i = grid_purchase.RowCount
            If i > 0 Then
                c_index = grid_purchase.CurrentRow.Index
                Dim del As New Integer
                del = grid_purchase.CurrentRow.Index
                Dim aa As New DataTable
                aa = PURCHASEDETAILS_PROC(0, "", grid_purchase.CurrentRow.Cells(1).Value, grid_purchase.CurrentRow.Cells(2).Value, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, "checkitem", "", "")
                Dim d As Integer
                d = aa.Rows(0)(0)
                If d = 1 Then
                    MsgBox("Item Already Selected in Sales")
                    count()
                    sno.Text = grid_purchase.RowCount
                    If Radio_cash.Checked = True Then
                        TXT_AMT.Text = tot_lbl.Text
                        TXT_AMT.ReadOnly = True
                    Else
                        TXT_AMT.Text = ""
                        TXT_AMT.ReadOnly = False
                    End If
                Else
                    grid_purchase.Rows.Remove(grid_purchase.CurrentRow)
                    c_index_value = grid_purchase.RowCount
                    If c_index_value < 0 Then
                        MsgBox("There is no row", MsgBoxStyle.Critical)
                    Else
                        j = grid_purchase.RowCount
                        Dim s As Integer

                        For m = c_index To grid_purchase.RowCount - 1
                            s = grid_purchase.Rows(c_index).Cells(0).Value

                            grid_purchase.Rows(c_index).Cells(0).Value = s - 1

                            c_index = c_index + 1

                        Next
                        count()
                        ck_vat.Checked = False
                        ck_dis.Checked = False
                        txt_billvat.Text = "0"
                        txt_billdis.Text = "0"
                        txt_Otherexp.Text = "0.00"
                        sno.Text = grid_purchase.RowCount
                        If Radio_cash.Checked = True Then
                            TXT_AMT.Text = tot_lbl.Text
                            TXT_AMT.ReadOnly = True
                        Else
                            TXT_AMT.Text = "0.00"
                            TXT_AMT.ReadOnly = False
                        End If
                        gdt = grid_purchase.DataSource
                        gdt.AcceptChanges()
                    End If
                End If
                txt_brandname.Focus()
            Else
                MessageBox.Show("Oops!There is no Row", "Warning", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_Qty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Qty.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_vat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_vat.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXT_DIS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DIS.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_fqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_fqty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (Val(Txt_fqty.Text) <> 0 Or txt_Qty.Text <> 0) And Txt_fqty.Text <> "" Then
                    txt_unit.Focus()
                Else
                    Txt_fqty.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_Qty.Focus()
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

    Private Sub cbk_funit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                txt_vat.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                Txt_fqty.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_fqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_fqty.TextChanged
        Try
            txt_Qty.Text = "0"
            txt_vat.Text = "0"
            TXT_DIS.Text = "0"
            txt_vat.ReadOnly = True
            TXT_DIS.ReadOnly = True
            txt_u2rate.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            suppliercreation.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_prate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_prate.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_u2rate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_u2rate.TextChanged
        Try
            If Val(txt_u2rate.Text) > Val(mrp.Text) Then
                MsgBox("Purchase Rate Must Be Less Than MRP " & vbNewLine & "MRP Rate is " & mrp.Text, MsgBoxStyle.Information, suss)
                txt_u2rate.Text = "0.00"
                txt_u2rate.Focus()
            Else
                If txt_unit.Text = wholeunit Then
                    txt_prate.Text = Format(Val(txt_u2rate.Text) * noofqty, "0.00")
                Else
                    txt_prate.Text = txt_u2rate.Text
                End If
                If txt_Qty.Text <> "" Then
                    If IsNumeric(txt_Qty.Text) = True Then
                        If txt_prate.Text <> "" Then
                            If IsNumeric(txt_Qty.Text) = True Then
                                txt_TOTPRICE.Text = Val(txt_prate.Text) * Val(txt_Qty.Text)
                                Dim totprice As Decimal = 0.0
                                totprice = txt_TOTPRICE.Text
                                txt_TOTPRICE.Text = Format(totprice, "0.00")
                                vatamount()
                                Discount1()
                            End If
                        End If
                    End If
                Else
                    Dim totprice As Decimal = 0.0
                    txt_TOTPRICE.Text = Format(totprice, "0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_u2rate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_u2rate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TXT_DIS.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                txt_prate.Focus()
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ProductRegister.ShowDialog()
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
            a = txt_u2rate.Text
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

    Private Sub Txt_fqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_fqty.KeyPress
        Try
            e.Handled = TrapKey(Asc(e.KeyChar))
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

    Private Sub TXT_BILLNO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BILLNO.KeyPress
        Try

            Static PreviousLetter As Char
            If PreviousLetter = " "c Or TXT_BILLNO.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_billvat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billvat.TextChanged
        Try
            If Val(tot_Gross.Text) <> 0 Then
                If ck_vat.Checked = True Then
                    bvattype = "Percent"
                    bvatp = Val(txt_billvat.Text)
                    Dim v As Decimal
                    v = Val(tot_Gross.Text) * Val(txt_billvat.Text) / 100
                    bvatamt = System.Math.Round(v)
                    totvat.Text = Format(System.Math.Round(v) + mainvat, "0.00")
                    tot_lbl.Text = Format(Val(tot_Gross.Text) + Val(totvat.Text) - Val(discount.Text) + Val(txt_Otherexp.Text), "0.00")
                Else
                    bvattype = "AMT"
                    bvatp = 0
                    bvatamt = Val(txt_billvat.Text)
                    totvat.Text = Format(Val(txt_billvat.Text) + mainvat, "0.00")
                    tot_lbl.Text = Format(Val(tot_Gross.Text) + Val(totvat.Text) - Val(discount.Text) + Val(txt_Otherexp.Text), "0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_billdis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_billdis.TextChanged
        Try
            If Val(tot_Gross.Text) <> 0 Then
                If ck_dis.Checked = True Then
                    Dim d As Decimal
                    bdistype = "Percent"
                    bdisp = Val(txt_billdis.Text)
                    d = Val(tot_Gross.Text) * Val(txt_billdis.Text) / 100
                    bdisamt = System.Math.Round(d)
                    discount.Text = Format(maindis + System.Math.Round(d), "0.00")
                    tot_lbl.Text = Format(Val(tot_Gross.Text) + Val(totvat.Text) - Val(discount.Text) + Val(txt_Otherexp.Text), "0.00")
                Else
                    bdistype = "AMT"
                    bdisp = 0
                    bdisamt = Val(txt_billdis.Text)
                    discount.Text = Format(Val(txt_billdis.Text) + maindis, "0.00")
                    tot_lbl.Text = Format(Val(tot_Gross.Text) + Val(totvat.Text) - Val(discount.Text) + Val(txt_Otherexp.Text), "0.00")
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

    Private Sub txt_Otherexp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Otherexp.TextChanged
        Try
            If Val(tot_Gross.Text) <> 0 Then
                tot_lbl.Text = Format(Val(tot_Gross.Text) + Val(totvat.Text) - Val(discount.Text) + Val(txt_Otherexp.Text), "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub txt_billvat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billvat.KeyPress
        Try
            If ck_vat.Checked = True Then
                e.Handled = TrapKey(Asc(e.KeyChar))
            Else
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_billdis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billdis.KeyPress
        Try
            If ck_dis.Checked = True Then
                e.Handled = TrapKey(Asc(e.KeyChar))
            Else
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_Otherexp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Otherexp.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_Otherexp.Text
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
                    txt_Otherexp.Focus()
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

    Private Sub txt_Otherexp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Otherexp.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_Otherexp.Text <> "" Then
                    TXT_AMT.Focus()
                Else
                    txt_Otherexp.Focus()
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
 Private Sub tot_lbl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tot_lbl.TextChanged
        Try
            If Radio_cash.Checked = True Then
                TXT_AMT.Text = tot_lbl.Text
                TXT_AMT.ReadOnly = True
            Else
                TXT_AMT.Text = "0.00"
                TXT_AMT.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class