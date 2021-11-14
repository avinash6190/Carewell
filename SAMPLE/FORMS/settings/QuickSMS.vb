Public Class QuickSMS

    Private Sub btn_sms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sms.Click
        Try
            If txt_phno.Text = "" Or txt_msg.Text = "" Then
                MsgBox("Please Provide Message and Mobile No", MsgBoxStyle.Information, err)
                txt_msg.Focus()
            Else
                If txt_phno.TextLength < 10 Then
                    MsgBox("Please Check Ur Mobile No", MsgBoxStyle.Information, err)
                    txt_msg.Focus()
                Else
                    Dim str As String
                    Dim dt As New DataTable
                    dt = SP_SMS(Trim(txt_msg.Text), Today.Date.ToString("MM/dd/yyyy"), "INSERT")
                    str = SendSMS1("vedreal", "ved123", txt_phno.Text, txt_msg.Text, "V.E.D")
                    MsgBox(str, MsgBoxStyle.Information, "Success")
                    txt_phno.Text = ""
                    txt_msg.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_phno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If grid_group.Visible = True Then
                grid_group.Visible = False
            Else
                grid_group.Visible = True
            End If
            Dim viewgroup As New DataTable
            viewgroup = SP_TEMP("%", "VIEW")
            grid_group.DataSource = viewgroup
            grid_group.Columns(0).Width = 400
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub grid_group_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_group.DoubleClick
        Try
            txt_msg.Text = ""
            If grid_group.RowCount <> 0 Then
                txt_msg.Text = grid_group.CurrentRow.Cells(0).Value
                grid_group.Visible = False
                btn_sms.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class