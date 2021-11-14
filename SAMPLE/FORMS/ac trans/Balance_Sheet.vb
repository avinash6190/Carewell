Imports System.Data.SqlClient
Public Class Balance_Sheet
    Dim dat As Date
    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Try
            Dim dc1 As New BalanceRpt
            Dim dt As New DataTable
            dc1.SetDataSource(BALANCE(sdt1.Value.ToString("MM/dd/yyyy"), sdt2.Value.ToString("MM/dd/yyyy")))
            ReportForm.ReportViewer.ReportSource = dc1
            ReportForm.Show()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        Dim ds As DataSet
        ds = New DataSet
        cmd = New SqlCommand("Select convert(nvarchar(15),date,103) as Date from company_info where name='Asset'")
        cmd.Connection = con
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Dim aa As String
        Dim dat As Date
        aa = ds.Tables(0).Rows(0)(0)
        aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
        dat = CDate(aa)
        sdt1.Value = dat
        sdt1.Enabled = False
        sdt2.Value = Date.Today
    End Sub

    Private Sub Balance_Sheet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Balance_Sheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clear()
            sdt1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sdt1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sdt1.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                sdt2.Focus()
                sdt1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sdt2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sdt2.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                Submit.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                sdt1.Focus()
                sdt1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Submit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Submit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Left Then
            sdt1.Focus()
            sdt1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sdt1.Enabled = True
        sdt1.Focus()
    End Sub
End Class