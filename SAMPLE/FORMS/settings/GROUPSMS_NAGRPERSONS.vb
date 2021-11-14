Public Class GROUPSMS_NAGRPERSONS
    Dim a As String
    Sub groupitem()
        Dim group As New DataTable
        group = CONTACT_PROC("", "", "%", "", "VIEW", "")
        Dim groupdr As DataRow
        grpname_cbk.Items.Clear()
        For Each groupdr In group.Rows()
            grpname_cbk.Items.Add(groupdr("GROUPNAME"))
        Next
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If grid_items.RowCount <> 0 Then
                For i As Integer = 0 To grid_items.RowCount - 1
                    grid_items.Rows(i).Cells(0).Value = True
                Next
                CheckBox1.Text = "DeselectAll"
            End If
        Else
            If grid_items.RowCount <> 0 Then
                For i As Integer = 0 To grid_items.RowCount - 1
                    grid_items.Rows(i).Cells(0).Value = False
                Next
                CheckBox1.Text = "SelectAll"
            End If
        End If
    End Sub

    Private Sub btn_reprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reprint.Click
        a = ""
        For i As Integer = 0 To grid_items.RowCount - 1
            If grid_items.Rows(i).Cells(0).Value = True Then
                If a = "" Then
                    If grid_items.Rows(i).Cells(2).Value.ToString.Length = 10 Then
                        a = grid_items.Rows(i).Cells(2).Value
                    End If
                Else
                    If grid_items.Rows(i).Cells(2).Value.ToString.Length = 10 Then
                        a = a + "," + grid_items.Rows(i).Cells(2).Value
                    End If
                End If
            Else

            End If
        Next
        'Dim s As New SMSFORM(a)
        'Me.Hide()
        's.ShowDialog()
        txt_phno.Text = a
        If txt_msg.Text <> "" And a <> "" Then
            If txt_msg.TextLength > 160 Then
                MsgBox("160 Characters only allowed", MsgBoxStyle.Information, err)

            Else
                Dim str As String
                Dim dt As New DataTable
                dt = SP_SMS(Trim(txt_msg.Text), Today.Date.ToString("MM/dd/yyyy"), "INSERT")
                str = SendSMS1("vedreal", "ved123", txt_phno.Text, txt_msg.Text, "V.E.D")
                MsgBox(str, MsgBoxStyle.Information, "Success")
                txt_phno.Text = ""
                txt_msg.Text = ""
                For i As Integer = 0 To grid_items.RowCount - 1
                    grid_items.Rows(i).Cells(0).Value = False
                    CheckBox1.Checked = False
                Next
            End If
        Else
            MsgBox("Please Provide Message and Mobile No", MsgBoxStyle.Information, err)
            txt_msg.Focus()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If grid_group.Visible = True Then
            grid_group.Visible = False
        Else
            If grid_group.RowCount <> 0 Then
                grid_group.Visible = True
            Else
                grid_group.Visible = False
            End If
            End If
            Dim viewgroup As New DataTable
            viewgroup = SP_TEMP("%", "VIEW")
            grid_group.DataSource = viewgroup
            grid_group.Columns(0).Width = 400
    End Sub

    Private Sub grid_group_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_group.CellContentClick

    End Sub

    Private Sub grid_group_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_group.DoubleClick
        txt_msg.Text = ""
        txt_msg.Text = grid_group.CurrentRow.Cells(0).Value
        grid_group.Visible = False
        btn_reprint.Focus()
    End Sub

    Private Sub GROUPSMS_NAGRPERSONS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        If cmb_type.Text = "Business" Then
            grpname_cbk.Items.Clear()
            grpname_cbk.Items.Add("Customer")
            grpname_cbk.Items.Add("Supplier")
        ElseIf cmb_type.Text = "Others" Then
            Call groupitem()
        End If
    End Sub

    Private Sub grpname_cbk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpname_cbk.SelectedIndexChanged
        If grpname_cbk.Text = "Customer" Then
            view_cust()
        ElseIf grpname_cbk.Text = "Supplier" Then
            view_sup()
        Else
            view_group()
        End If
    End Sub
    Sub view_cust()
        Dim DT As New DataTable
        DT = client_register("", "", "", "", "", "", "", "", "", "VIEW_SMS")
        grid_items.DataSource = DT
        grid_items.Columns(1).Width = 150
        grid_items.Columns(2).Width = 150
    End Sub
    Sub view_sup()
        Dim DT As New DataTable
        DT = supplier_procedure("", "", "", "", "", "", "", "", "VIEW_SMS", "")
        grid_items.DataSource = DT
        grid_items.Columns(1).Width = 150
        grid_items.Columns(2).Width = 150
    End Sub
    Sub view_group()
        Dim DT As New DataTable
        DT = CONTACT_GROUP(Trim(grpname_cbk.SelectedItem.ToString), "VIEWGRP")
        grid_items.DataSource = DT
        grid_items.Columns(1).Width = 150
        grid_items.Columns(2).Width = 150
    End Sub
End Class