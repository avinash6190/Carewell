Public Class DailyBook
    Dim viewset As New DataSet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            viewset = REPORTS_PROC("", "", sdate.Value.ToString("MM/dd/yyyy"), Today.ToString, "", "DayBook")
            Debit_gird.DataSource = viewset.Tables(0)
            credit_grid.DataSource = viewset.Tables(1)
            Debit_gird.Columns(0).Width = 120
            Debit_gird.Columns(1).Width = 120
            Debit_gird.Columns(2).Width = 120
            Debit_gird.Columns(3).Width = 100
            credit_grid.Columns(0).Width = 120
            credit_grid.Columns(1).Width = 120
            credit_grid.Columns(2).Width = 120
            credit_grid.Columns(3).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DailyBook_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DailyBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sdate.Value = Date.Today
            sdate.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub sdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sdate.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                Button1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                sdate.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GroupBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox2.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Debit_gird_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub credit_grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles credit_grid.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class