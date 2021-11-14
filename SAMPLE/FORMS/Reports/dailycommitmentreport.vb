Imports System.Data.SqlClient
Public Class dailycommitmentreport
    Private Sub dailycommitmentreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clear()
            viewall()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub clear()
        type.Text = ""
        dt_frm.Value = Today.Date
        dt_to.Value = Today.Date
        type.Focus()
    End Sub
    Sub viewall()
        Try
            Dim dt As New DataTable
            dt = commitment("", "", "", "viewall", "", "", "")
            grid_cmtrpt.DataSource = dt
            gridwidth()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub gridwidth()
        Try
            grid_cmtrpt.Columns(0).Visible = False
            grid_cmtrpt.Columns(1).Width = 150
            grid_cmtrpt.Columns(2).Width = 400
            grid_cmtrpt.Columns(3).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub type_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles type.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If type.Text <> "" Then
                    dt_frm.Focus()
                Else
                    type.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dt_frm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_frm.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dt_to.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dt_to_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_to.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If dt_frm.Text <> "" Or dt_to.Text <> "" Then
                    Dim dat As Date
                    Dim a As String
                    a = dt_frm.Text
                    a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                    dat = CDate(a)
                    If dt_to.Value < dat Then
                        MsgBox("Check Date Must Be Greater Than Entry Date", MsgBoxStyle.Information, suss)
                        dt_to.Value = dat
                        dt_to.Focus()
                    Else
                        btn_save.Focus()
                    End If
                Else
                    MsgBox("Please Fill the Details")
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.SelectedIndexChanged
        Try
            grid_cmtrpt.DataSource = ""
            type.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            If type.Text = "Finished" Then
                Dim dt As New DataTable
                dt = commitment(dt_frm.Value.ToString("MM/dd/yyyy"), "", "", "finished_commit", "", "", dt_to.Value.ToString("MM/dd/yyyy"))
                grid_cmtrpt.DataSource = dt
                gridwidth()
            ElseIf type.Text = "Pending" Then
                Dim dt As New DataTable
                dt = commitment(dt_frm.Value.ToString("MM/dd/yyyy"), "", "", "pending_commit", "", "", dt_to.Value.ToString("MM/dd/yyyy"))
                grid_cmtrpt.DataSource = dt
                gridwidth()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Try

            Dim cnt As New DataTable
            Dim str As String
            If grid_cmtrpt.RowCount = 0 Then
                MsgBox("No data Found", MsgBoxStyle.Information)
            Else
                Dim rep As String
                rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
                If rep = vbYes Then
                    cnt = grid_cmtrpt.DataSource
                    If type.Text = "Finished" Then
                        str = "Finished Commitment Report"
                    ElseIf type.Text = "Pending" Then
                        str = "Pending Commitment Report"
                    Else
                        str = "Commitment Report"
                    End If
                    Dim ds As New commit_ds
                    Dim da1 As New SqlDataAdapter
                    For i As Integer = 0 To cnt.Rows.Count - 1
                        ds.Tables("commit").Rows.Add(str, cnt.Rows(i)(1), cnt.Rows(i)(2), cnt.Rows(i)(3), "", "", "")
                    Next
                    cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
                    da1 = New SqlDataAdapter(cmd)
                    da1.Fill(ds.Tables("companydetails"))
                    Dim dc1 As New commit_rpt
                    dc1.SetDataSource(ds)
                    ReportForm.ReportViewer.ReportSource = dc1
                    ReportForm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dt_to_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_to.Leave
        If dt_frm.Text <> "" Or dt_to.Text <> "" Then
            Dim dat As Date
            Dim a As String
            a = dt_frm.Text
            a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
            dat = CDate(a)
            If dt_to.Value < dat Then
                MsgBox("Check Date Must Be Greater Than Entry Date", MsgBoxStyle.Information, suss)
                dt_to.Value = dat
                dt_to.Focus()
            Else
                btn_save.Focus()
            End If
        Else
            MsgBox("Please Fill the Details")
        End If
    End Sub
End Class