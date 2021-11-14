Public Class Trading_Account
    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Try
            Dim tra As New New_Tradi
            tra.SetDataSource(TRADING123(sdt1.Value.ToString("MM/dd/yyyy"), sdt2.Value.ToString("MM/dd/yyyy")))
            ReportForm.ReportViewer.ReportSource = tra
            ReportForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Trading_Account_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Trading_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sdt1.Value = Date.Today
            sdt2.Value = Date.Today
            sdt1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sdt1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sdt1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            sdt2.Focus()
        End If
    End Sub
    Private Sub sdt2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sdt2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Left Then
            sdt1.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            Submit.Focus()
        End If
    End Sub
    Private Sub Submit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Submit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Left Then
            sdt2.Focus()
        End If
    End Sub
End Class