Imports System.Data.SqlClient
Public Class ADDCONTACT
    Dim OldGroupName As String
    Dim oldname As String
    Dim oldmobileno As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        s.ShowDialog()
        grpname_cbk.Focus()
        groupitem()
    End Sub
    Sub groupitem()
        Dim group As New DataTable
        group = CONTACT_PROC("", "", "%", "", "VIEW", "")
        Dim groupdr As DataRow
        grpname_cbk.Items.Clear()
        For Each groupdr In group.Rows()
            grpname_cbk.Items.Add(groupdr("GROUPNAME"))
        Next
    End Sub

    Private Sub ADDCONTACT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call groupitem()
        Dim viewgroup As New DataTable
        viewgroup = CONTACT_PROC("%", "", "", "", "NVIEW", "")
        grid_group.DataSource = viewgroup
        grid_group.Columns(0).Width = 140
        grid_group.Columns(1).Width = 110
        grid_group.Columns(2).Width = 130
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim dt As New DataTable
        If txt_name.Text = "" Or txt_phno.Text = "" Or grpname_cbk.Text = "" Then
            MsgBox("Please Enter The Names", MsgBoxStyle.Information, "message")
            txt_name.Focus()
        Else
            dt = CONTACT_PROC(Trim(txt_name.Text), Trim(txt_phno.Text), grpname_cbk.SelectedItem.ToString, "", "INSERT", "")
            If dt.Rows(0)(0) = 0 Then
                MsgBox("Successfully Saved", MsgBoxStyle.Information, err)
                txt_name.Text = ""
                txt_phno.Text = ""
                grpname_cbk.SelectedIndex = -1
                txt_name.Focus()
            Else
                MsgBox("Already Exists", MsgBoxStyle.Critical, err)
                txt_name.Text = ""
                txt_phno.Text = ""
                grpname_cbk.SelectedIndex = -1
                txt_name.Focus()
            End If
            Dim viewgroup As New DataTable
            viewgroup = CONTACT_PROC("%", "", "", "", "NVIEW", "")
            grid_group.DataSource = viewgroup
            grid_group.Columns(0).Width = 140
            grid_group.Columns(1).Width = 110
            grid_group.Columns(2).Width = 130

        End If
        txt_name.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_phno.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub txt_phno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_phno.KeyDown
        If e.KeyCode = Keys.Enter Then
            grpname_cbk.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_phno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phno.KeyPress
        If (Char.IsLetter(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_phno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_phno.TextChanged

    End Sub

    Private Sub grpname_cbk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grpname_cbk.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_save.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub grpname_cbk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grpname_cbk.KeyPress

    End Sub

    Private Sub grpname_cbk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpname_cbk.SelectedIndexChanged

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim i As Integer

        Dim response As String
        Dim cntdt As New DataTable
        cntdt = grid_group.DataSource
        If btn_edit.Text = "&UPDATE" Then

            Dim dt As New DataTable
            If Trim(txt_name.Text) = "" Or Trim(txt_phno.Text) = "" Or Trim(grpname_cbk.Text) = "" Then
                MsgBox("Please Enter The Group Name", MsgBoxStyle.Information, "message")

            Else
                Dim dt12 As New DataTable
                i = grid_group.CurrentRow.Index
                Dim cnt As New DataTable
                cnt = grid_group.DataSource
                dt12 = CONTACT_PROC(Trim(txt_name.Text), Trim(txt_phno.Text), grpname_cbk.SelectedItem.ToString, oldname, OldGroupName, oldmobileno)
                If dt12.Rows(0)(0) = 3 Then
                    MsgBox("Successfully Updated", MsgBoxStyle.Information, "message")
                ElseIf dt12.Rows(0)(0) = 1 Then
                    MsgBox("Group Name Already Exists", MsgBoxStyle.Information, "message")
                End If
                txt_name.Text = ""
                txt_phno.Text = ""
                grpname_cbk.SelectedIndex = -1
                txt_name.Focus()
                Dim viewgroup As New DataTable
                viewgroup = CONTACT_PROC("%", "", "", "", "NVIEW", "")
                grid_group.DataSource = viewgroup
                grid_group.Columns(0).Width = 140
                grid_group.Columns(1).Width = 110
                grid_group.Columns(2).Width = 130
                btn_save.Enabled = True
                btn_delete.Enabled = True
                txt_name.Enabled = True
                btn_edit.Text = "&EDIT"

            End If
        Else
            If cntdt.Rows.Count <= 0 Then
                MsgBox("There is No Row", MsgBoxStyle.Information, "message")
                txt_name.Focus()
            Else
                response = MsgBox("Are you sure", MsgBoxStyle.YesNo, "message")
                If (response = vbYes) Then
                    Dim getdt As New DataTable
                    getdt = grid_group.DataSource
                    i = grid_group.CurrentRow.Index
                    txt_name.Text = getdt.Rows(grid_group.CurrentRow.Index)(0)
                    txt_phno.Text = getdt.Rows(grid_group.CurrentRow.Index)(1)
                    grpname_cbk.Text = getdt.Rows(grid_group.CurrentRow.Index)(2)
                    OldGroupName = getdt.Rows(grid_group.CurrentRow.Index)(2)
                    oldname = getdt.Rows(grid_group.CurrentRow.Index)(0)
                    oldmobileno = getdt.Rows(grid_group.CurrentRow.Index)(1)
                    btn_save.Enabled = False
                    btn_delete.Enabled = False
                    txt_name.Enabled = False
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
                    dt = CONTACT_PROC(cnt.Rows(grid_group.CurrentRow.Index)(0), cnt.Rows(grid_group.CurrentRow.Index)(1), cnt.Rows(grid_group.CurrentRow.Index)(2), "", "DELETE", "")
                    If dt.Rows(0)(0) = 0 Then
                        MsgBox("SuccessFully Deleted", MsgBoxStyle.Information, suss)
                    Else
                    End If
                    Dim viewgroup As New DataTable
                    viewgroup = CONTACT_PROC("%", "", "", "", "NVIEW", "")
                    grid_group.DataSource = viewgroup
                    grid_group.Columns(0).Width = 140
                    grid_group.Columns(1).Width = 110
                    grid_group.Columns(2).Width = 130
                    txt_name.Focus()
                Else

                End If
            End If
        Else
            MsgBox("There Is no Row", MsgBoxStyle.Information)
        End If
    End Sub
End Class