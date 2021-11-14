Public Class s

    Private Sub CONTACTGROUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim viewgroup As New DataTable
        viewgroup = CONTACT_GROUP("%", "VIEW")
        grid_group.DataSource = viewgroup
        grid_group.Columns(0).Width = 400
        txt_grpname.Focus()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim dt As New DataTable
        If txt_grpname.Text = "" Then
            MsgBox("Please Enter The Names", MsgBoxStyle.Information, "message")
            txt_grpname.Focus()
        Else

            dt = CONTACT_GROUP(Trim(txt_grpname.Text), "INSERT")
            If dt.Rows(0)(0) = 0 Then
                MsgBox("Successfully Saved", MsgBoxStyle.Information, err)
                txt_grpname.Text = ""
                txt_grpname.Focus()
            Else
                MsgBox("Group Name Already Exists", MsgBoxStyle.Critical, err)
                txt_grpname.Text = ""
                txt_grpname.Focus()
            End If
            Dim viewgroup As New DataTable
            viewgroup = CONTACT_GROUP("%", "VIEW")
            grid_group.DataSource = viewgroup
            grid_group.Columns(0).Width = 400
        End If
        txt_grpname.Focus()
    End Sub

    Private Sub txt_grpname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_grpname.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_save.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_grpname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_grpname.TextChanged

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim i As Integer
        Static Dim OldGroupName As String
        Dim response As String
        Dim cntdt As New DataTable
        cntdt = grid_group.DataSource
        If btn_edit.Text = "&UPDATE" Then

            Dim dt As New DataTable
            If txt_grpname.Text = "" Then
                MsgBox("Please Enter The Group Name", MsgBoxStyle.Information, suss)
                txt_grpname.Focus()
            Else
                Dim dt12 As New DataTable
                i = grid_group.CurrentRow.Index
                Dim cnt As New DataTable
                cnt = grid_group.DataSource
                dt12 = CONTACT_GROUP(txt_grpname.Text, OldGroupName)
                If dt12.Rows(0)(0) = 3 Then
                    MsgBox("Successfully Updated", MsgBoxStyle.Information, suss)
                ElseIf dt12.Rows(0)(0) = 1 Then
                    MsgBox("Group Name Already Exists", MsgBoxStyle.Critical, suss)
                End If
                Dim viewgroup As New DataTable
                viewgroup = CONTACT_GROUP("%", "VIEW")
                grid_group.DataSource = viewgroup
                grid_group.Columns(0).Width = 400
                txt_grpname.Focus()
                btn_save.Visible = True
                btn_edit.Text = "&EDIT"
                txt_grpname.Text = ""
            End If
        Else
            If cntdt.Rows.Count <= 0 Then
                MsgBox("There is No Row", MsgBoxStyle.Information, suss)
                txt_grpname.Focus()
            Else
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, suss)
                If (response = vbYes) Then
                    Dim getdt As New DataTable
                    getdt = grid_group.DataSource
                    i = grid_group.CurrentRow.Index
                    txt_grpname.Text = getdt.Rows(grid_group.CurrentRow.Index)(0)
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
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, suss)
                If vbYes = response Then
                    dt = CONTACT_GROUP(cnt.Rows(grid_group.CurrentRow.Index)(0), "DELETE")
                    If dt.Rows(0)(0) = 0 Then
                        MsgBox("Group SuccessFully Deleted", MsgBoxStyle.Information, suss)
                    Else
                        MsgBox("This Group Have some Customer So" + vbNewLine + " Delete the Customer First Before Deleting this", MsgBoxStyle.Critical, err)
                    End If
                    Dim viewgroup As New DataTable
                    viewgroup = CONTACT_GROUP("%", "VIEW")
                    grid_group.DataSource = viewgroup
                    grid_group.Columns(0).Width = 400
                    txt_grpname.Focus()
                Else

                End If
            End If
        Else
            MsgBox("There Is no Row", MsgBoxStyle.Information)
        End If
    End Sub

   
End Class