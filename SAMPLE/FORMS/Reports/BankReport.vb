Imports System.Data.SqlClient
Public Class BankReport

    Private Sub bank_addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bank_addbtn.Click
        Try

            Dim dt As New DataTable
            dt = BankReport1(bankname.Text, Date1.Value.ToString("MM/dd/yyyy"), date2.Value.ToString("MM/dd/yyyy"))
            bank_grid.DataSource = dt
            cashinhand()
            If bankname.Text = "all" Then
                bank_grid.Columns(0).Visible = True
                bank_grid.Columns(0).Width = 100
                bank_grid.Columns(1).Width = 100
                bank_grid.Columns(2).Width = 100
                bank_grid.Columns(3).Width = 100
                bank_grid.Columns(4).Width = 150
            Else
                bank_grid.Columns(0).Visible = False
                bank_grid.Columns(1).Width = 100
                bank_grid.Columns(2).Width = 100
                bank_grid.Columns(3).Width = 100
                bank_grid.Columns(4).Width = 150
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cashinhand()
        Dim i As Integer
        Dim k As Decimal = 0
        Dim k1 As Decimal = 0
        Dim k2 As Decimal = 0
        Dim n As Decimal = 0
        If bank_grid.RowCount > 0 Then
            For i = 0 To bank_grid.RowCount - 1
                If i = 0 Then

                Else
                    n = bank_grid.Rows(i - 1).Cells(4).Value
                End If
                k = bank_grid.Rows(i).Cells(1).Value
                k1 = bank_grid.Rows(i).Cells(2).Value
                ' bankgrid.Rows(i).Cells(4).Value = (n + bankgrid.Rows(i).Cells(2).Value) - (bankgrid.Rows(i).Cells(3).Value)
                k2 = n + k - k1
                bank_grid.Rows(i).Cells(4).Value = k2
            Next
        End If
    End Sub
    Sub count()
        Try
            Dim total As Decimal = 0
            Dim total1 As Decimal = 0
            total = "0.00"
            total1 = "0.00"
            If bank_grid.RowCount > 0 Then
                For i As Integer = 0 To bank_grid.Rows.Count - 1
                    If bank_grid.Rows(i).Cells(3).Value.ToString = "deposit" Or bank_grid.Rows(i).Cells(1).Value.ToString = "loan" Or bank_grid.Rows(i).Cells(1).Value.ToString = "od" Or bank_grid.Rows(i).Cells(1).Value.ToString = "OpeningBalance" Then

                        total += bank_grid.Rows(i).Cells(1).Value
                    Else
                        total1 += bank_grid.Rows(i).Cells(1).Value
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        Try
            
            Dim cnt As New DataTable
            If bank_grid.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                cnt = bank_grid.DataSource
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    Dim ds As New bankrpt
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("BankReport").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3))
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New bankrpt1
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bankname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                Date1.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BankReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt7 As New DataTable
            dt7 = viewbank()
            Dim dr As DataRow
            bankname.Items.Clear()
            For Each dr In dt7.Rows()
                bankname.Items.Add(dr("bankname"))
            Next
            bankname.Items.Add("all")
            bankname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bankname_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bankname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Date1.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                bankname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Date1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                date2.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                Date1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub date2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles date2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Date1.Text <> "" Or date2.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = Date1.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If date2.Value < dat Then
                        MsgBox("To Date Must Be Greater Than From Date", MsgBoxStyle.Information, suss)
                        date2.Value = Today.Date
                        date2.Focus()
                    Else
                        bank_addbtn.Focus()
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                Date1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class