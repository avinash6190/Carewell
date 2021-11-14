Public Class ledger
    Dim dt As New DataTable
    Dim t As New Integer
    Dim id As String
    Dim response As String
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            response = MsgBox("Are You Sure        ", MsgBoxStyle.YesNo, "Message")
            If vbYes = response Then
                If btn_save.Text = "&SAVE" Then
                    If Trim(TXT_NAME.Text) <> "" And TYPE.SelectedIndex <> -1 Then
                        dt = INEX_PROC(0, Trim(TXT_NAME.Text), TYPE.SelectedItem, "INSERT")
                        If dt.Rows(0)(0) = 1 Then
                            btn_cancel_Click(Nothing, Nothing)
                        End If
                    End If
                Else
                    If Trim(TXT_NAME.Text) <> "" And TYPE.SelectedIndex <> -1 Then
                        dt = INEX_PROC(Val(TXT_ID.Text), Trim(TXT_NAME.Text), TYPE.SelectedItem, "UPDATE")
                        If dt.Rows(0)(0) = 2 Then
                            btn_cancel_Click(Nothing, Nothing)
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("Enter Valid Input", MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Sub view()
        Dim DS1 As New DataTable
        DS1 = INEX_PROC(Val(TXT_ID.Text), Trim(TXT_NAME.Text), TYPE.SelectedItem, "VIEW")
        Itemgrid.DataSource = DS1
        GRIDWITH()
    End Sub
    Sub GRIDWITH()
        Itemgrid.Columns(0).Width = 50
        Itemgrid.Columns(1).Width = 180
        Itemgrid.Columns(2).Width = 125
    End Sub

    Private Sub TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TYPE.SelectedIndex <> -1 Then
                TXT_NAME.Focus()
            Else
                TYPE.Focus()
            End If
        End If
    End Sub
    Private Sub TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TYPE.SelectedIndexChanged

    End Sub
    Private Sub TXT_NAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TXT_NAME.Text <> "" Then
                btn_save.Focus()
            Else
                TXT_NAME.Focus()
            End If
        End If
    End Sub

    Private Sub TXT_NAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME.KeyPress

        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TXT_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME.TextChanged

    End Sub

    Private Sub INCEXP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        btn_cancel_Click(Nothing, Nothing)
    End Sub

    Private Sub Itemgrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Itemgrid.CellContentClick

    End Sub

    Private Sub Itemgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Itemgrid.DoubleClick
        If Itemgrid.Rows.Count <= 0 Then
            MsgBox("Please Select The Row", MsgBoxStyle.Information, "Message")
        Else
            id = Itemgrid.CurrentRow.Cells(0).Value
            TXT_ID.Text = Itemgrid.CurrentRow.Cells(0).Value
            TXT_NAME.Text = Itemgrid.CurrentRow.Cells(1).Value
            TYPE.SelectedItem = Itemgrid.CurrentRow.Cells(2).Value
            btn_save.Text = "&Update"
            btn_delete.Enabled = False
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            response = MsgBox("Are You Sure        ", MsgBoxStyle.YesNo, "Message")
            If vbYes = response Then
                dt = INEX_PROC(Itemgrid.CurrentRow.Cells(0).Value, Trim(TXT_NAME.Text), TYPE.SelectedItem, "DELETE")
                btn_cancel_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox("Enter Valid Input", MsgBoxStyle.Information, "Message")
        End Try
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        TYPE.SelectedIndex = -1
        TXT_NAME.Text = ""
        btn_save.Text = "&SAVE"
        btn_delete.Enabled = True
        view()
        TYPE.Focus()
    End Sub
End Class