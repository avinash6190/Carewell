Imports System.Data.SqlClient
Public Class purret_reports
    Dim VIEW As New DataTable
    Dim DT As New DataTable
    Private Sub purret_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbk_type.SelectedIndex = -1
            cbk_type.Focus()
            txt_sup.Text = ""
            tdate.Value = Today.Date
            fdate.Value = Today.Date
            fdate.Visible = False
            tdate.Visible = False
            txt_sup.Visible = False
            lb1.Visible = False
            lb2.Visible = False
            L2.Visible = False
            l3.Visible = False
            VIEW = purret_report("", "", "", "", "", "All_purret")
            pur_grid.DataSource = VIEW
            pur_grid.Columns(0).Width = 100
            pur_grid.Columns(1).Width = 100
            pur_grid.Columns(2).Width = 175
            pur_grid.Columns(3).Width = 150
            pur_grid.Columns(4).Width = 100
            pur_grid.Columns(5).Width = 100
            count()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbk_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbk_type.SelectedIndexChanged
        Try
            If cbk_type.Text = "DAY WISE" Then
                fdate.Visible = True
                fdate.Value = Today.Date
                L2.Visible = True
                L2.Text = "DATE"
                lb1.Visible = True
                txt_sup.Visible = False
                l3.Visible = False
                lb2.Visible = False
                tdate.Visible = False
                pur_grid.DataSource = ""
            ElseIf cbk_type.Text = "DATE WISE" Then
                fdate.Visible = True
                tdate.Visible = True
                txt_sup.Visible = False
                lb1.Visible = True
                lb2.Visible = True
                L2.Visible = True
                L2.Text = "FROM DATE"
                l3.Text = "TO DATE"
                l3.Visible = True
                tdate.Value = Today.Date
                fdate.Value = Today.Date
                pur_grid.DataSource = ""
            ElseIf cbk_type.Text = "PRODUCT WISE" Then
                fdate.Visible = False
                tdate.Visible = False
                txt_sup.Visible = True
                txt_sup.Text = ""
                lb1.Visible = True
                lb2.Visible = False
                L2.Visible = True
                L2.Text = "Product Name"
                l3.Visible = False
                pur_grid.DataSource = ""
            ElseIf cbk_type.Text = "SUPPLIER WISE" Then
                fdate.Visible = False
                tdate.Visible = False
                txt_sup.Visible = True
                lb1.Visible = True
                lb2.Visible = False
                L2.Visible = True
                L2.Text = "Supplier Name"
                txt_sup.Text = ""
                l3.Visible = False
                pur_grid.DataSource = ""
            ElseIf cbk_type.Text = "BILLNO WISE" Then
                fdate.Visible = False
                tdate.Visible = False
                txt_sup.Visible = True
                lb1.Visible = True
                lb2.Visible = False
                L2.Visible = True
                L2.Text = "BILL NO."
                txt_sup.Text = ""
                l3.Visible = False
                pur_grid.DataSource = ""
            Else
                fdate.Visible = False
                tdate.Visible = False
                txt_sup.Visible = False
                lb1.Visible = False
                lb2.Visible = False
                L2.Visible = False
                l3.Visible = False
                tdate.Value = Today.Date
                fdate.Value = Today.Date
                pur_grid.DataSource = ""
            End If
            count()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Try
            purret_reports_Load(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbk_type_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_type.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cbk_type.Text = "DAY WISE" Then
                    fdate.Focus()
                ElseIf cbk_type.Text = "DATE WISE" Then
                    fdate.Focus()
                Else
                    txt_sup.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_sup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sup.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If GRID.Visible = True Then
                    GRID.Focus()
                ElseIf tdate.Visible = True Then
                    tdate.Focus()
                Else
                    btn_exp.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If tdate.Visible = True Then
                    tdate.Focus()
                Else
                    btn_exp.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If fdate.Text <> "" Or tdate.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = fdate.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If tdate.Value < dat Then
                        MsgBox("To Date Must Be Greater Than From Date", MsgBoxStyle.Information, suss)
                        tdate.Value = Today.Date
                        tdate.Focus()
                    Else
                        btn_exp.Focus()
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_sup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sup.TextChanged
        Try
            If txt_sup.Text <> "" Then
                If cbk_type.Text = "PRODUCT WISE" Then
                    DT = purret_report("", txt_sup.Text + "%", "", "", "", "PRODUCT")
                    If DT.Rows.Count <> 0 Then
                        GRID.Visible = True
                        GRID.DataSource = DT
                        GRID.Columns(0).Width = 150
                        GRID.Columns(1).Width = 100
                    Else
                        txt_sup.Text = ""
                        txt_sup.Focus()
                        GRID.Visible = False
                    End If
                ElseIf cbk_type.Text = "SUPPLIER WISE" Then
                    DT = purret_report("", txt_sup.Text + "%", "", "", "", "SUPPLIER")
                    If DT.Rows.Count <> 0 Then
                        GRID.DataSource = DT
                        GRID.Columns(0).Width = 200
                        GRID.Visible = True
                    Else
                        txt_sup.Text = ""
                        txt_sup.Focus()
                        GRID.Visible = False
                    End If
                ElseIf cbk_type.Text = "BILLNO WISE" Then
                    DT = purret_report("", txt_sup.Text + "%", "", "", "", "BILLNO")
                    If DT.Rows.Count <> 0 Then
                        GRID.DataSource = DT
                        GRID.Visible = True
                        GRID.Columns(0).Width = 200
                    Else
                        txt_sup.Text = ""
                        txt_sup.Focus()
                        GRID.Visible = False
                    End If
                End If
            Else
                txt_sup.Focus()
                GRID.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cbk_type.Text = "PRODUCT WISE" Then
                    txt_sup.Text = GRID.CurrentRow.Cells(0).Value
                    brand.Text = GRID.CurrentRow.Cells(1).Value
                    txt_sup.Focus()
                    GRID.Visible = False
                Else
                    txt_sup.Text = GRID.CurrentRow.Cells(0).Value
                    txt_sup.Focus()
                    GRID.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GRID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID.DoubleClick
        Try
            If cbk_type.Text = "PRODUCT WISE" Then
                txt_sup.Text = GRID.CurrentRow.Cells(0).Value
                brand.Text = GRID.CurrentRow.Cells(1).Value
                txt_sup.Focus()
                GRID.Visible = False
            Else
                txt_sup.Text = GRID.CurrentRow.Cells(0).Value
                txt_sup.Focus()
                GRID.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exp.Click
        Try
            If cbk_type.Text = "DAY WISE" Then
                VIEW = purret_report("", "", fdate.Value.ToString("MM/dd/yyyy"), "", "", "DAY WISE")
                pur_grid.DataSource = VIEW
            ElseIf cbk_type.Text = "DATE WISE" Then
                VIEW = purret_report("", "", fdate.Value.ToString("MM/dd/yyyy"), tdate.Value.ToString("MM/dd/yyyy"), "", "DATE WISE")
                pur_grid.DataSource = VIEW
            ElseIf cbk_type.Text = "PRODUCT WISE" Then
                VIEW = purret_report(brand.Text, txt_sup.Text, "", "", "", "PRODUCT WISE")
                pur_grid.DataSource = VIEW
            ElseIf cbk_type.Text = "SUPPLIER WISE" Then
                VIEW = purret_report("", "", "", "", txt_sup.Text, "SUPPLIER WISE")
                pur_grid.DataSource = VIEW
            ElseIf cbk_type.Text = "BILLNO WISE" Then
                VIEW = purret_report("", "", "", "", txt_sup.Text, "BILLNO WISE")
                pur_grid.DataSource = VIEW
            End If
            pur_grid.DataSource = VIEW
            pur_grid.Columns(0).Width = 100
            pur_grid.Columns(1).Width = 100
            pur_grid.Columns(2).Width = 175
            pur_grid.Columns(3).Width = 150
            pur_grid.Columns(4).Width = 100
            pur_grid.Columns(5).Width = 100
            count()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub count()
        Try
            Dim price As Decimal = 0.0
            For i As Integer = 0 To pur_grid.Rows.Count - 1
                price += pur_grid.Rows(i).Cells(4).Value
            Next
            puramt.Text = Format(price, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Try

            Dim cnt As New DataTable
            Dim str As String
            Dim ex As String
            If pur_grid.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                cnt = pur_grid.DataSource
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    If cbk_type.Text = "DAY WISE" Then
                        str = "Day Wise PurchaseReturn Report"
                        ex = fdate.Value.ToString("dd/MM/yyyy")
                    ElseIf cbk_type.Text = "DATE WISE" Then
                        str = "Date Wise PurchaseReturn Report"
                        ex = "From " + fdate.Value.ToString("dd/MM/yyyy") + " To " + tdate.Value.ToString("dd/MM/yyyy")
                    ElseIf cbk_type.Text = "PRODUCT WISE" Then
                        str = "Product Wise PurchaseReturn Report"
                        ex = "Product Name " + txt_sup.Text
                    ElseIf cbk_type.Text = "SUPPLIER WISE" Then
                        ex = "Supplier Name " + txt_sup.Text
                        str = "Supplier Wise PurchaseReturn Report"
                    ElseIf cbk_type.Text = "BILLNO WISE" Then
                        ex = "Billno." + txt_sup.Text
                        str = "Billno. Wise PurchaseReturn Report"
                    Else
                        str = "PurchaseReturn Report"
                        ex = ""
                    End If
                    Dim ds As New purret_rpt
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("pur_rpt1").Rows.Add(cnt.Rows(i)(1), cnt.Rows(i)(0), cnt.Rows(i)(2), 0, "", cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), str.ToString, ex.ToString, "")
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New purret_rep
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pur_grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pur_grid.DoubleClick
        Try
            Dim billno As String
            Dim dat As String
            Dim sup As String
            If pur_grid.RowCount <> 0 Then
                dat = pur_grid.CurrentRow.Cells(0).Value
                billno = pur_grid.CurrentRow.Cells(1).Value
                sup = pur_grid.CurrentRow.Cells(2).Value
                Dim sss As New purchase_return(dat, billno, sup)
                sss.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_sup_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sup.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class