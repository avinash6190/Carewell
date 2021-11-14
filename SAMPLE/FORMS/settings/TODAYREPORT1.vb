Public Class TODAYREPORT1

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim dt As New DataTable
        dt = SP_SMS("", cbk_date1.Value.ToString("MM/dd/yyyy"), "VIEW")
        If dt.Columns.Count <> 1 Then
            grid_group.DataSource = dt
            grid_group.Columns(0).Width = 1000
            grid_group.Columns(1).Visible = False
        Else
            Dim dt1 As New DataTable
            grid_group.DataSource = dt1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TODAYREPORT1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class