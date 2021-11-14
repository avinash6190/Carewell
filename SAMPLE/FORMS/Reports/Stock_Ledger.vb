Imports System.Data.SqlClient
Public Class Stock_Ledger
    Private Sub Stock_Ledger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim i As Integer
            txt_brand.Focus()
            txt_brand.Text = ""
            txt_item.Text = ""
            RadioButton2.Checked = True
            Dim stock As New DataTable
            stock = REPORTS_PROC(txt_brand.Text, txt_item.Text, "", "", "", "All_stock")
            stock_grid.DataSource = stock
            Dim s As String
            For i = 0 To stock.Rows.Count - 1
                s = stock_grid.Rows(i).Cells(2).Value
                If Val(s.ToString) <> 0 Then
                    stock_grid.Rows(i).Cells(2).Value = s.Substring(0, s.Length - 7)
                End If
            Next
            stock_grid.Columns(0).Width = 150
            stock_grid.Columns(1).Width = 200
            stock_grid.Columns(2).Width = 120
            stock_grid.Columns(3).Width = 100
            stock_grid.Columns(4).Width = 100
            stock_grid.Columns(5).Width = 100
            tot_stkamount()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_brand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_brand.TextChanged
        Try
            If txt_brand.Text <> "" Then
                Dim dt As New DataTable
                dt = PRODUCT_PROC(txt_brand.Text + "%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "BRANDNAME", "")
                If dt.Rows.Count > 0 Then
                    dg.Visible = True
                    dg.DataSource = dt
                    dg.Columns(0).Width = 160
                Else
                    txt_brand.Text = ""
                    dg.Visible = False
                    txt_brand.Focus()
                End If
            Else
                txt_brand.Text = ""
                dg.Visible = False
                txt_brand.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_item_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_item.TextChanged
        Try
            If txt_brand.Text <> "" Then
                Dim IDT As New DataTable
                IDT = PURCHASE_PROC("", 0, txt_brand.Text, txt_item.Text + "%", Today.Date.ToString("MM/dd/yyyy"), Today.Date.ToString("MM/dd/yyyy"), "", 0, 0, 0, 0, 0, Today.Date.ToString("MM/dd/yyyy"), 0, "product", 0, 0, 0, 0, "", 0, 0, "", 0)
                If IDT.Rows.Count > 0 Then
                    item.Visible = True
                    item.DataSource = IDT
                    item.Columns(0).Width = 160
                ElseIf IDT.Rows.Count = 0 Then
                    item.Visible = False
                    txt_item.Text = ""
                Else
                    item.Visible = False
                End If
            Else
                txt_brand.Focus()
                item.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_brand_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_brand.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If dg.Visible = True Then
                    dg.Focus()
                Else
                    txt_item.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_item_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_item.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If item.Visible = True Then
                    item.Focus()
                Else
                    btn_exp.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub item_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item.DoubleClick
        Try
            If item.Rows.Count <> 0 Then
                txt_item.Text = item.CurrentRow.Cells(0).Value
                txt_item.Focus()
                item.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub item_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles item.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If item.Rows.Count <> 0 Then
                    txt_item.Text = item.CurrentRow.Cells(0).Value
                    txt_item.Focus()
                    item.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Try
            If dg.Rows.Count <> 0 Then
                txt_brand.Text = dg.CurrentRow.Cells(0).Value
                txt_brand.Focus()
                dg.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If dg.Rows.Count <> 0 Then
                    txt_brand.Text = dg.CurrentRow.Cells(0).Value
                    txt_brand.Focus()
                    dg.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        Try
            Stock_Ledger_Load(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_exp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exp.Click
        Try
            If RadioButton2.Checked = True Then
                Dim i As Integer
                Dim stock As New DataTable
                stock = REPORTS_PROC(txt_brand.Text, txt_item.Text, "", "", "", "stock_product")
                stock_grid.DataSource = stock
                Dim s As String
                For i = 0 To stock.Rows.Count - 1
                    s = stock_grid.Rows(i).Cells(2).Value
                    If s.Length > 7 Then
                        stock_grid.Rows(i).Cells(2).Value = s.Substring(0, s.Length - 7)
                    End If
                Next
                stock_grid.Columns(0).Width = 150
                stock_grid.Columns(1).Width = 200
                stock_grid.Columns(2).Width = 120
                stock_grid.Columns(3).Width = 100
                stock_grid.Columns(4).Width = 100
                stock_grid.Columns(5).Width = 100
                tot_stkamount()
            Else
                Dim i As Integer
                Dim stock As New DataTable
                stock = REPORTS_PROC(txt_brand.Text, txt_item.Text, "", "", "", "stock_productp")
                stock_grid.DataSource = stock
                Dim s As String
                For i = 0 To stock.Rows.Count - 1
                    s = stock_grid.Rows(i).Cells(2).Value
                    stock_grid.Rows(i).Cells(2).Value = s.Substring(0, s.Length - 7)
                Next
                stock_grid.Columns(0).Width = 150
                stock_grid.Columns(1).Width = 200
                stock_grid.Columns(2).Width = 120
                stock_grid.Columns(3).Width = 100
                stock_grid.Columns(4).Width = 100
                stock_grid.Columns(5).Width = 100
                tot_stkamount()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tot_stkamount()
        Try
            stkamt1.Text = "0.00"
            Dim tot6 As Decimal = 0
            For i As Integer = 0 To stock_grid.RowCount - 1
                tot6 += stock_grid.Rows(i).Cells(5).Value
            Next
            stkamt1.Text = Format(tot6, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Try

            Dim cnt As New DataTable
            If stock_grid.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                cnt = stock_grid.DataSource
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    Dim ds As New stock_ds
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("stock").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), "", "")
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New stock
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            Dim i As Integer
            txt_brand.Focus()
            txt_brand.Text = ""
            txt_item.Text = ""
            Dim stock As New DataTable
            stock = REPORTS_PROC(txt_brand.Text, txt_item.Text, "", "", "", "All_stockp")
            stock_grid.DataSource = stock
            Dim s As String
            For i = 0 To stock.Rows.Count - 1
                s = stock_grid.Rows(i).Cells(2).Value
                If Val(s.ToString) <> 0 Then
                    stock_grid.Rows(i).Cells(2).Value = s.Substring(0, s.Length - 7)
                End If
            Next
            stock_grid.Columns(0).Width = 150
            stock_grid.Columns(1).Width = 200
            stock_grid.Columns(2).Width = 120
            stock_grid.Columns(3).Width = 100
            stock_grid.Columns(4).Width = 100
            stock_grid.Columns(5).Width = 100
            'stock_grid.Columns(6).Width = 50
            tot_stkamount()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            Dim i As Integer
            txt_brand.Focus()
            txt_brand.Text = ""
            txt_item.Text = ""
            Dim stock As New DataTable
            stock = REPORTS_PROC(txt_brand.Text, txt_item.Text, "", "", "", "All_stock")
            stock_grid.DataSource = stock
            Dim s As String
            For i = 0 To stock.Rows.Count - 1
                s = stock_grid.Rows(i).Cells(2).Value
                If Val(s.ToString) <> 0 Then
                    stock_grid.Rows(i).Cells(2).Value = s.Substring(0, s.Length - 7)
                End If
            Next
            stock_grid.Columns(0).Width = 150
            stock_grid.Columns(1).Width = 200
            stock_grid.Columns(2).Width = 120
            stock_grid.Columns(3).Width = 100
            stock_grid.Columns(4).Width = 100
            stock_grid.Columns(5).Width = 100
            tot_stkamount()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_brand_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_brand.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_item_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_item.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class