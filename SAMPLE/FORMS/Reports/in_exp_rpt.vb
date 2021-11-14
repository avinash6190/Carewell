Imports System.Data.SqlClient
Public Class in_exp_rpt
    Dim dt As DataTable
    Private Sub in_exp_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbk_type.Text = ""
        fdate.Value = Today.Date
        todate.Value = Today.Date
        view()
    End Sub
    Sub view()
        dt = income_PROC(0, "", "", "", "", "", "", "", "", 0, "viewall", "")
        exp_grid.DataSource = dt
        gridwidth()
    End Sub
    Sub gridwidth()
        Try
            exp_grid.Columns(0).Visible = False
            exp_grid.Columns(1).Width = 100
            exp_grid.Columns(2).Width = 100
            exp_grid.Columns(3).Width = 200
            exp_grid.Columns(4).Visible = False
            exp_grid.Columns(5).Width = 270
            exp_grid.Columns(6).Width = 150
            count()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub count()
        Try
            Dim tot As Decimal = 0.0
            For i As Integer = 0 To exp_grid.Rows.Count - 1
                tot += exp_grid.Rows(i).Cells(6).Value
            Next
            lbl_tot.Text = Format(tot, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If cbk_type.Text <> "" Then
                If cbk_type.Text.ToUpper = "ALL" Then
                    dt = income_PROC(0, fdate.Value.ToString("MM/dd/yyyy"), "", "", "", "", "", "", todate.Value.ToString("MM/dd/yyyy"), 0, "viewallbydate", "")
                    exp_grid.DataSource = dt
                    gridwidth()
                ElseIf cbk_type.Text = "Direct Income" Or cbk_type.Text = "InDirect Income" Then
                    dt = income_PROC(0, fdate.Value.ToString("MM/dd/yyyy"), "", "", "", "", "", "", todate.Value.ToString("MM/dd/yyyy"), 0, "VIEWDATE", cbk_type.Text + "%")
                    exp_grid.DataSource = dt
                    gridwidth()
                ElseIf cbk_type.Text = "Direct Expense" Or cbk_type.Text = "InDirect Expense" Then
                    dt = exp_PROC(0, fdate.Value.ToString("MM/dd/yyyy"), "", "", "", "", "", "", todate.Value.ToString("MM/dd/yyyy"), 0, "VIEWDATE", cbk_type.Text + "%")
                    exp_grid.DataSource = dt
                    gridwidth()
                End If
            Else
                MsgBox("Select Type First", MsgBoxStyle.Information, "Warnig")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cbk_type.SelectedIndex = -1
            fdate.Value = Today.Date
            todate.Value = Today.Date
            view()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub cbk_type_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbk_type.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cbk_type.SelectedIndex <> -1 Then
                    fdate.Focus()
                Else
                    cbk_type.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub fdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                todate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub todate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles todate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If fdate.Text <> "" Or todate.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = fdate.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If todate.Value < dat Then
                        MsgBox("To Date Must Be Greater Than From Date", MsgBoxStyle.Information, "Message")
                        todate.Value = Today.Date
                        todate.Focus()
                    Else
                        Button1.Focus()
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub todate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todate.Leave
        If fdate.Text <> "" Or todate.Text <> "" Then
            Dim dat As Date
            Dim a As String
            a = fdate.Text
            a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
            dat = CDate(a)
            If todate.Value < dat Then
                MsgBox("To Date Must Be Greater Than From Date", MsgBoxStyle.Information, "Message")
                todate.Value = Today.Date
                todate.Focus()
            Else
                Button1.Focus()
            End If
        Else
            MsgBox("Please Fill the Details")
        End If
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        Try
            Dim rep As String
            rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
            If rep = vbYes Then
                Dim cnt As New DataTable
                cnt = exp_grid.DataSource
                If exp_grid.RowCount = 0 Then
                    MsgBox("No data Found", MsgBoxStyle.Information)
                Else
                    Dim ds As New incexp_ds
                    Dim da1 As New SqlDataAdapter
                    Dim str As String
                    If cbk_type.Text.ToUpper = "ALL" Then
                        str = "Income And Expense Report"
                    ElseIf cbk_type.Text = "Income" Then
                        str = "Income Report"
                    ElseIf cbk_type.Text = "Expense" Then
                        str = "Expense Report"
                    Else
                        str = "Income And Expense Report"
                    End If
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("incexp").Rows.Add(cnt.Rows(i)(0), cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), cnt.Rows(i)(4), cnt.Rows(i)(5), cnt.Rows(i)(6), str)
                    Next
                    Dim dc1 As New incexp_rpt
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbk_type_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbk_type.Enter
        cbk_type.BackColor = Color.Pink
    End Sub

    Private Sub cbk_type_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbk_type.Leave
        cbk_type.BackColor = Color.White
    End Sub
End Class