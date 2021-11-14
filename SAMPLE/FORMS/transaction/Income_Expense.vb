Public Class Income_Expense
    Dim dt As New DataTable
    Dim pDate As Date
    Dim dat As Date
    Dim Oldname As String
    Dim ss As Integer
    Dim a, b, c, d, e1, f, g As String
    Public Sub New(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e1 As String, ByVal f As String, ByVal g As String)
        InitializeComponent()
        Me.a = a
        Me.b = b
        Me.c = c
        Me.d = d
        Me.e1 = e1
        Me.f = f
        Me.g = g
        If a.ToString <> "" And b.ToString <> "" And c.ToString <> "" And d.ToString <> "" And e1.ToString <> "" Then
            cmb_mode.Enabled = False
            cmb_mode.Text = a
            ss = 1
            dt_tdate.Value = b
            pDate = b
            txt_name.Text = c
            txt_amt.Text = d
            Oldname = e1
            btn_add.Text = "&Update"
        End If
    End Sub
    Private Sub Income_Expense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If ss = 0 Then
                dt_tdate.Value = Date.Today
                reset1()
                cmb_mode.SelectedIndex = 0
                cmb_mode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub cmb_mode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_mode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dt_tdate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub cmb_mode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mode.SelectedIndexChanged
        Try
            If cmb_mode.SelectedIndex = 0 Then
                Label1.Text = "Income"

            Else
                Label1.Text = "Expense"

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Sub reset1()
        Try
            txt_amt.Text = ""
            dt_tdate.Value = Date.Today
            txt_name.Text = ""
            dt.Rows.Clear()
            pDate = Date.Today
            btn_add.Text = "&ADD"
            cmb_mode.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_name.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If dg_namelist.Visible = True Then
                    dg_namelist.Focus()
                Else
                    txt_amt.Focus()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                dt_tdate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_name.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dt_tdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_tdate.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset1()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                txt_name.Focus()
            ElseIf e.KeyCode = Keys.Left Then
                cmb_mode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.TextChanged
        Try
            dt.Rows.Clear()
            If txt_name.Text <> "" Then
                If ss = 0 Then
                    If cmb_mode.Text = "Income" Then
                        dt = INCOMEEXPENC_PROC(txt_name.Text + "%", 0, Date.Today.ToString("MM/dd/yyyy"), cmb_mode.Text, "I-VIEW", Date.Today.ToString("MM/dd/yyyy"))
                        dg_namelist.DataSource = dt
                        dg_namelist.Columns(0).Width = 200
                    Else
                        dt = INCOMEEXPENC_PROC(txt_name.Text + "%", 0, Date.Today.ToString("MM/dd/yyyy"), cmb_mode.Text, "E-VIEW", Date.Today.ToString("MM/dd/yyyy"))
                        dg_namelist.DataSource = dt
                        dg_namelist.Columns(0).Width = 200
                    End If
                    If dg_namelist.RowCount > 0 Then
                        dg_namelist.Visible = True
                    Else
                        txt_name.Text = ""
                        dg_namelist.Visible = False
                    End If
                Else
                    dg_namelist.Visible = False
                End If
            Else
                dg_namelist.Visible = False
                txt_name.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_amt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_amt.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If txt_amt.Text <> "" Then
                    btn_add_Click(Nothing, Nothing)
                Else
                    txt_amt.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset1()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_name.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Try
            If btn_add.Text = "&ADD" Then
                dt = INCOMEEXPENC_PROC(txt_name.Text, Val(txt_amt.Text), dt_tdate.Value.ToString("MM/dd/yyyy"), cmb_mode.Text, "INSERT", Date.Today.ToString("MM/dd/yyyy"))
                cmb_mode.Focus()
            Else
                dt = INCOMEEXPENC_PROC(txt_name.Text, Val(txt_amt.Text), dt_tdate.Value.ToString("MM/dd/yyyy"), cmb_mode.Text, Oldname, pDate.ToString("MM/dd/yyyy"))
            End If
            reset1()
            cmb_mode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub txt_amt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = txt_amt.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub dg_namelist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_namelist.DoubleClick
        Try
            txt_name.Text = dg_namelist.CurrentRow.Cells(0).Value
            dg_namelist.Visible = False
            txt_amt.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub dg_namelist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg_namelist.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_name.Text = dg_namelist.CurrentRow.Cells(0).Value
                dg_namelist.Visible = False
                txt_amt.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset1()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                txt_name.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub btn_delete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    reset1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_edit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                reset1()
            End If
        End If
    End Sub

    Private Sub btn_add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_add.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                reset1()
            End If
        End If
    End Sub

    Private Sub btn_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Dim response As String
            response = MsgBox("Are you sure to reset", MsgBoxStyle.YesNo, "Warning")
            If vbYes = response Then
                reset1()
            End If
        End If
    End Sub
End Class