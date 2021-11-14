Public Class TEMPLATE

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim dt As New DataTable
        If txt_TNAME.Text = "" Then
            MsgBox("Please Enter The Names", MsgBoxStyle.Information, "message")
            txt_TNAME.Focus()
        Else

            dt = SP_TEMP(txt_TNAME.Text, "INSERT")
            If dt.Rows(0)(0) = 0 Then
                MsgBox("Successfully Saved", MsgBoxStyle.Information, err)
                txt_TNAME.Text = ""
                txt_TNAME.Focus()
            Else
                MsgBox("Group Name Already Exists", MsgBoxStyle.Critical, err)
                txt_TNAME.Text = ""
                txt_TNAME.Focus()
            End If
            Dim viewgroup As New DataTable
            viewgroup = SP_TEMP("%", "VIEW")
            grid_group.DataSource = viewgroup
            grid_group.Columns(0).Width = 500
        End If
        txt_TNAME.Focus()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim i As Integer
        Static Dim OldGroupName As String
        Dim response As String
        Dim cntdt As New DataTable
        cntdt = grid_group.DataSource
        If btn_edit.Text = "&UPDATE" Then

            Dim dt As New DataTable
            If txt_TNAME.Text = "" Then
                MsgBox("Please Enter The Group Name", MsgBoxStyle.Information, "message")
                txt_TNAME.Focus()
            Else
                Dim dt12 As New DataTable
                i = grid_group.CurrentRow.Index
                Dim cnt As New DataTable
                cnt = grid_group.DataSource
                dt12 = SP_TEMP(txt_TNAME.Text, OldGroupName)
                If dt12.Rows(0)(0) = 3 Then
                    MsgBox("Successfully Updated", MsgBoxStyle.Information, "message")
                ElseIf dt12.Rows(0)(0) = 1 Then
                    MsgBox("Template Already Exists", MsgBoxStyle.Information, "message")
                End If
                Dim viewgroup As New DataTable
                viewgroup = SP_TEMP("%", "VIEW")
                grid_group.DataSource = viewgroup
                grid_group.Columns(0).Width = 500
                txt_TNAME.Focus()
                btn_save.Visible = True
                btn_edit.Text = "&EDIT"
                txt_TNAME.Text = ""
            End If
        Else
            If cntdt.Rows.Count <= 0 Then
                MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                txt_TNAME.Focus()
            Else
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                If (response = vbYes) Then
                    Dim getdt As New DataTable
                    getdt = grid_group.DataSource
                    i = grid_group.CurrentRow.Index
                    txt_TNAME.Text = getdt.Rows(grid_group.CurrentRow.Index)(0)
                    OldGroupName = getdt.Rows(grid_group.CurrentRow.Index)(0)
                    btn_save.Visible = False
                    btn_edit.Text = "&UPDATE"
                End If
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim response As String
        Dim cnt As New DataTable
        Dim dt As New DataTable
        cnt = grid_group.DataSource
        If cnt.Rows.Count > 0 Then
            Dim index As Integer
            index = grid_group.CurrentRow.Index
            If index < 0 Then
                MsgBox("There is no row")
            Else
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                If vbYes = response Then
                    dt = SP_TEMP(cnt.Rows(grid_group.CurrentRow.Index)(0), "DELETE")
                    If dt.Rows(0)(0) = 0 Then
                        MsgBox("SuccessFully Deleted", MsgBoxStyle.Information, suss)
                    Else
                        'MsgBox("This Group Have some Customer So" + vbNewLine + " Delete the Customer First Before Deleting this", MsgBoxStyle.Critical, err)
                    End If
                    Dim viewgroup As New DataTable
                    viewgroup = SP_TEMP("%", "VIEW")
                    grid_group.DataSource = viewgroup
                    grid_group.Columns(0).Width = 500
                    txt_TNAME.Focus()
                Else

                End If
            End If
        Else
            MsgBox("There Is no Row", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txt_TNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_save.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_TNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TNAME.TextChanged

    End Sub

    Private Sub TEMPLATE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim viewgroup As New DataTable
        viewgroup = SP_TEMP("%", "VIEW")
        grid_group.DataSource = viewgroup
        grid_group.Columns(0).Width = 500
        txt_TNAME.Focus()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_TNAME.Text = ""
        txt_TNAME.Focus()
    End Sub
End Class