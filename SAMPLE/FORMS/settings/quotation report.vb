Imports System.Data.SqlClient
Public Class quotation_report
    Dim qdt As New DataTable
    Dim aa As Integer = 0
    Private Sub quotation_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qdt.Columns.Add("Batchno")
            qdt.Columns.Add("ProductName")
            qdt.Columns.Add("BrandName")
            qdt.Columns.Add("PRate")
            qdt.Columns.Add("MRP")
            qdt.Columns.Add("Srate")
            qdt.Columns.Add("Percentage")
            grid_items.DataSource = qdt
            gridwidth()
            txt_mat.Text = ""
            txt_mat.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gridwidth()
        grid_items.Columns(0).ReadOnly = False
        grid_items.Columns(1).ReadOnly = True
        grid_items.Columns(2).ReadOnly = True
        grid_items.Columns(3).ReadOnly = True
        grid_items.Columns(4).ReadOnly = True
        grid_items.Columns(5).ReadOnly = False
        grid_items.Columns(6).ReadOnly = False
        grid_items.Columns(7).ReadOnly = False
        grid_items.Columns(0).Width = 50
        grid_items.Columns(1).Width = 100
        grid_items.Columns(2).Width = 175
        grid_items.Columns(3).Width = 100
        grid_items.Columns(4).Width = 100
        grid_items.Columns(5).Width = 100
        grid_items.Columns(6).Width = 100
        grid_items.Columns(7).Width = 100
    End Sub
    Private Sub txt_mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mat.TextChanged
        Try
            If txt_mat.Text <> "" Then
                Dim dt As New DataTable
                dt = PRODUCT_PROC(Trim(txt_mat.Text) + "%", "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "MAT_SRCH2", "")
                If dt.Rows.Count <> 0 Then
                    grid_mat.DataSource = dt
                    grid_mat.Columns(0).Width = 250
                    grid_mat.Visible = True
                    txt_mat.Focus()
                Else
                    txt_mat.Text = ""
                    grid_mat.Visible = False
                    txt_mat.Focus()
                End If
            Else
                txt_mat.Text = ""
                grid_mat.Visible = False
                txt_mat.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            If qdt.Rows.Count = 0 And txt_mat.Text <> "" Then
                Dim rows As DataRow
                dt = PRODUCT_PROC(Trim(txt_mat.Text), "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "QUO_VIEW", "")
                If dt.Rows.Count <> 0 Then
                    qdt.Rows.Add("", " " & Trim(txt_mat.Text.ToUpper) & " ", "", "", "")
                    For Each rows In dt.Rows()
                        qdt.Rows.Add(rows.Item(0), rows.Item(1), rows.Item(2), rows.Item(3), rows.Item(4), rows.Item(5), rows.Item(6).ToString + "%")
                    Next
                    grid_items.DataSource = qdt
                    gridwidth()
                    txt_mat.Text = ""
                    txt_mat.Focus()
                End If
            ElseIf qdt.Rows.Count <> 0 And txt_mat.Text <> "" Then
                Dim str As Boolean
                For Each row In qdt.Rows()
                    Dim index = 1
                    str = Convert.ToString(row(index)).Contains(txt_mat.Text.ToUpper)
                    If str Then
                        Exit For
                    End If
                Next
                If str Then
                    MsgBox("Already Exists These Material's Items.", MsgBoxStyle.Information, suss)
                    txt_mat.Text = ""
                    txt_mat.Focus()
                Else
                    Dim rows As DataRow
                    dt = PRODUCT_PROC(Trim(txt_mat.Text), "", "", 0, "", 0, "", 0, 0, 0, "", "", "", "QUO_VIEW", "")
                    If dt.Rows.Count <> 0 Then
                        qdt.Rows.Add("", " " & Trim(txt_mat.Text.ToUpper) & " ", "", "", "")
                        For Each rows In dt.Rows()
                            qdt.Rows.Add(rows.Item(0), rows.Item(1), rows.Item(2), rows.Item(3), rows.Item(4), rows.Item(5), rows.Item(6).ToString + "%")
                        Next
                        grid_items.DataSource = qdt
                        gridwidth()
                        txt_mat.Text = ""
                        txt_mat.Focus()
                    End If
                End If
            Else
                txt_mat.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_mat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If grid_mat.Visible = True Then
                    grid_mat.Focus()
                ElseIf txt_mat.Text <> "" Then
                    btn_ok.Focus()
                Else
                    txt_mat.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub grid_mat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_mat.DoubleClick
        Try
            If grid_mat.Rows.Count <> 0 Then
                txt_mat.Text = grid_mat.CurrentRow.Cells(0).Value
                grid_mat.Visible = False
                txt_mat.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub grid_mat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_mat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                grid_mat_DoubleClick(Nothing, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                grid_mat.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If grid_items.RowCount <> 0 Then
                If CheckBox1.Checked = True Then
                    If grid_items.RowCount <> 0 Then
                        aa = 1
                        For i As Integer = 0 To grid_items.RowCount - 1
                            grid_items.Rows(i).Cells(0).Value = True
                        Next
                        CheckBox1.Text = "DeselectAll"
                    End If
                Else
                    If grid_items.RowCount <> 0 Then
                        For i As Integer = 0 To grid_items.RowCount - 1
                            grid_items.Rows(i).Cells(0).Value = False
                        Next
                        CheckBox1.Text = "SelectAll"
                    End If
                End If
                aa = 0
            Else
                aa = 0
                CheckBox1.Checked = False
                CheckBox1.Text = "SelectAll"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            Dim dt As DataTable = grid_items.DataSource
            Dim cnt As Integer = 0
            Dim cnt2 As Integer = 0
            Dim ddt As New DataTable
            ddt.Columns.Add("Batchno")
            ddt.Columns.Add("ProductName")
            ddt.Columns.Add("BrandName")
            ddt.Columns.Add("PRate")
            ddt.Columns.Add("MRP")
            ddt.Columns.Add("Srate")
            ddt.Columns.Add("Percentage")
            For i As Integer = 0 To dt.Rows.Count - 1
                If grid_items.Rows(i).Cells(0).Value = False Then
                    ddt.Rows.Add(dt.Rows(i)(0), dt.Rows(i)(1), dt.Rows(i)(2), dt.Rows(i)(3), dt.Rows(i)(4), dt.Rows(i)(5), dt.Rows(i)(6))
                    cnt = 1
                Else
                    cnt2 = 1
                End If
            Next
            If cnt2 <> 1 And cnt = 1 Then
                MsgBox("First Check The Option In ItemList", MsgBoxStyle.Information, suss)
            ElseIf cnt2 = 0 And cnt = 0 Then
                MsgBox("There is no rows to select", MsgBoxStyle.Information, suss)
                CheckBox1.Text = "SelectAll"
                CheckBox1.Checked = False
            End If
            qdt.Rows.Clear()
            qdt = ddt
            grid_items.DataSource = qdt
            CheckBox1.Text = "SelectAll"
            CheckBox1.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Try
            Dim sno As Integer = 0
            Dim cnt As New DataTable
            cnt = grid_items.DataSource
            If grid_items.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    Dim ds As New quote_ds
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        If cnt.Rows(i)(0).ToString = "" Then
                            ds.Tables("quote").Rows.Add(cnt.Rows(i)(0).ToString, cnt.Rows(i)(1).ToString, cnt.Rows(i)(2).ToString, cnt.Rows(i)(4).ToString, cnt.Rows(i)(5).ToString, "", "", "")
                            sno = 0
                        Else
                            sno = sno + 1
                            ds.Tables("quote").Rows.Add(cnt.Rows(i)(0).ToString, cnt.Rows(i)(1).ToString, cnt.Rows(i)(2).ToString, cnt.Rows(i)(4).ToString, cnt.Rows(i)(5).ToString, sno.ToString, "", "")
                        End If
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New Quote_rpt
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid_items_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_items.CellValueChanged
        Try
            Dim per As Integer
            If grid_items.RowCount <> 0 And aa = 0 Then
                If grid_items.CurrentRow.Cells(6).Value <> 0 Then
                    Dim sal As Decimal = grid_items.CurrentRow.Cells(6).Value
                    Dim pur As Decimal = grid_items.CurrentRow.Cells(4).Value
                    per = ((sal - pur) / sal) * 100
                    grid_items.CurrentRow.Cells(7).Value = per.ToString("0") + "%"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class