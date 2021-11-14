Public Class Company_Info2
    Dim dt1 As New DataTable
    Dim b As Integer
    Private Sub Company_Info2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbtype.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged
        Try
            Dim dt As New DataTable
            dt = companyinfo("", 0, cmbtype.SelectedItem.ToString, "view")
            grid1.DataSource = dt
            grid1.Columns(0).Visible = False
            grid1.Columns(1).ReadOnly = False
            grid1.Columns(1).Width = 250
            grid1.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub Company_Info_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim dt1 As New DataTable
            dt1 = companyinfo("", 0, "", "Check")
            If dt1.Rows(0)(0) <> 22 Then
            Else
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtype.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cmbtype.Text <> "" Then
                    grid1.Focus()
                Else
                    cmbtype.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class