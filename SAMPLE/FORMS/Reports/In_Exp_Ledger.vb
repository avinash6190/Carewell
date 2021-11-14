Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class In_Exp_Ledger

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        If cmb_mode.Text = "" Then
            MsgBox("Please select Mode", MsgBoxStyle.Information, suss)
            cmb_mode.Focus()
        Else
            dg_Transaction.DataSource = INCOMEEXPENC_PROC("%", 0, dt_frm.Value.ToString("MM/dd/yyyy"), cmb_mode.Text, "VIEWBYDATE", dt_to.Value.ToString("MM/dd/yyyy"))
            dg_Transaction.Columns(1).Width = 150
        End If

    End Sub

    Private Sub Btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Print.Click
        If dg_Transaction.RowCount = 0 Then
            MsgBox("There is No Row", MsgBoxStyle.Information, suss)
            cmb_mode.Focus()
        Else
            Dim rep As String
            rep = MsgBox("Are you sure", MsgBoxStyle.YesNo)
            If rep = vbYes Then
                Dim da1 As New SqlDataAdapter
                Dim ds As New DataTable
                Dim dst As New Inc_Exp_Set
                dst.Tables(0).Rows.Clear()
                dst.Tables(1).Rows.Clear()
                For i As Integer = 0 To dg_Transaction.RowCount - 1
                    dst.Tables("income").Rows.Add(dg_Transaction.Rows(i).Cells(0).Value, dg_Transaction.Rows(i).Cells(1).Value, dg_Transaction.Rows(i).Cells(2).Value, cmb_mode.Text + " Details", dt_frm.Value.ToString("dd/MM/yyyy"), dt_to.Value.ToString("dd/MM/yyyy"))
                Next
                cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as mobileno2,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as sam1,sample2 as sam2 from Organization", con)
                da1 = New SqlDataAdapter(cmd)
                da1.Fill(dst.Tables("companydetails"))
                Dim dc1 As New In_exp
                dc1.SetDataSource(dst)
                ReportForm.ReportViewer.ReportSource = dc1
                ReportForm.Show()
            End If
        End If
    End Sub

    Private Sub In_Exp_Ledger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub In_Exp_Ledger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt_frm.Value = Date.today
        dt_to.Value = Date.today
        dt_frm.Focus()
    End Sub

    Private Sub dt_frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_frm.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            dt_to.Focus()
        End If
    End Sub

    Private Sub dt_frm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_frm.ValueChanged

    End Sub

    Private Sub dt_to_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_to.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            cmb_mode.Focus()
        ElseIf e.KeyCode = Keys.Left Then
            dt_frm.Focus()
        End If
    End Sub

    Private Sub dt_to_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_to.ValueChanged

    End Sub

    Private Sub cmb_mode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_mode.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            btn_find.Focus()
        ElseIf e.KeyCode = Keys.Left Then
            dt_to.Focus()
        End If
    End Sub

    Private Sub cmb_mode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mode.SelectedIndexChanged

    End Sub

    Private Sub Btn_Print_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Btn_Print.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_find_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_find.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Left Then
            cmb_mode.Focus()
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox4.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub dg_Transaction_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_Transaction.CellContentClick

    End Sub

    Private Sub dg_Transaction_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg_Transaction.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class