Imports System.Data.SqlClient
Public Class AssetForm
    Dim gdt As New DataTable
    Sub clear()
        Try
            assetname_txt.Text = ""
            assetamt_txt.Text = ""
            pdate.Text = Date.Today
            edit_btn.Text = "Edit"
            ok_btn.Visible = True
            assetname_txt.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_btn.Click
        Try
            If Trim(assetname_txt.Text) = "" Or Trim(assetamt_txt.Text) = "" Then
                MsgBox("Please Enter The Item Name", MsgBoxStyle.Information, err)
                assetname_txt.Focus()
            Else
                Dim dt, dt1 As New DataTable
                gdt.Rows.Clear()
                dt1 = ASSET_PROC(assetname_txt.Text, 0, Date.Today, "", "check_asset")
                If dt1.Rows(0)(0) = 1 Then
                    MsgBox("Please Give Another Name", MsgBoxStyle.Information, err)
                    assetname_txt.Focus()
                Else
                    ASSET_PROC(Trim(assetname_txt.Text), Val(assetamt_txt.Text), pdate.Value.ToString("MM/dd/yyyy"), "", "addasset")
                    MsgBox("Successfully Added", MsgBoxStyle.Information, err)
                    Call clear()
                    assetname_txt.Focus()
                End If
                dt = ASSET_PROC("", 0, Date.Today, "", "viewasset")
                For i As Integer = 0 To dt.Rows.Count - 1
                    gdt.Rows.Add(dt.Rows(i)(0), dt.Rows(i)(1), dt.Rows(i)(2))
                Next
                itemgrid.DataSource = gdt
                itemgrid.Columns(0).Width = 180
                itemgrid.Columns(1).Width = 150
                itemgrid.Columns(2).Width = 90
                assetname_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AssetForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AssetForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gdt.Columns.Add("AssetName")
            gdt.Columns.Add("Amount")
            gdt.Columns.Add("Date")
            Dim dt1 As New DataTable
            gdt.Rows.Clear()
            dt1 = ASSET_PROC("", 0, Date.Today, "", "viewasset")
            For i As Integer = 0 To dt1.Rows.Count - 1
                gdt.Rows.Add(dt1.Rows(i)(0), dt1.Rows(i)(1), dt1.Rows(i)(2))
            Next
            itemgrid.DataSource = gdt
            itemgrid.Columns(0).Width = 180
            itemgrid.Columns(1).Width = 150
            itemgrid.Columns(2).Width = 90
            assetname_txt.Focus()
            pdate.Value = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub assetname_txt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles assetname_txt.Enter
        Try
            assetname_txt.BackColor = Color.LavenderBlush
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub assetname_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles assetname_txt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                pdate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub assetname_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles assetname_txt.KeyPress
        Try
            Static PreviousLetter As Char

            If PreviousLetter = " " Or assetname_txt.Text.Length = 0 Then

                e.KeyChar = Char.ToUpper(e.KeyChar)

            End If

            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub assetamt_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles assetamt_txt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If edit_btn.Text = "&UPDATE" Then
                    edit_btn.Focus()
                Else
                    ok_btn.Focus()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                pdate.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub assetamt_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles assetamt_txt.KeyPress
        Try
            If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
                e.Handled = True
            End If
            Dim a As String
            a = assetamt_txt.Text
            Dim index As Int32 = a.LastIndexOf(".")
            If index >= 0 Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub assetamt_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles assetamt_txt.TextChanged
        Try
            If Not IsNumeric(assetamt_txt.Text) Then
                assetamt_txt.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ok_btn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ok_btn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                assetname_txt.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                edit_btn.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_btn.Click
        Me.Close()
    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_btn.Click
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = itemgrid.DataSource
            If edit_btn.Text = "&UPDATE" Then
                Dim dt As New DataTable

                '                If Trim(assetname_txt.Text) = "" Or Trim(assetamt_txt.Text) = "" Then
                '                    MsgBox("Please Enter The All Fields", MsgBoxStyle.Information, err)
                '                    assetname_txt.Focus()
                '                Else

                '                    Dim dt1 As New DataTable
                '                    If assetname_txt.Text = a.Text Then
                '                        GoTo A
                '                    Else
                '                        dt1 = ASSET_PROC(assetname_txt.Text, 0, Date.Today, "", "check_asset")
                '                        If dt1.Rows(0)(0) = 1 Then
                '                            MsgBox("Please Give Another Name", MsgBoxStyle.Information, err)
                '                            assetname_txt.Focus()
                '                        ElseIf dt1.Rows(0)(0) = 1 Then

                'A:                          
                dt = ASSET_PROC(assetname_txt.Text, assetamt_txt.Text, pdate.Value.ToString("MM/dd/yyyy"), a.Text, "Updateasset")
                If dt.Rows(0)(0) = -1 Then
                    MsgBox("Please Give Another Name", MsgBoxStyle.Information, err)
                    assetname_txt.Focus()
                ElseIf dt.Rows(0)(0) = 0 Then
                    MsgBox("Records are Updated Succesfully", MsgBoxStyle.Information)
                    a.Text = ""
                    dt = ASSET_PROC("", 0, Date.Today, "", "viewasset")
                    gdt.Rows.Clear()
                    For i1 As Integer = 0 To dt.Rows.Count - 1
                        gdt.Rows.Add(dt.Rows(i1)(0), dt.Rows(i1)(1), dt.Rows(i1)(2))
                    Next

                    itemgrid.DataSource = gdt

                    itemgrid.Columns(0).Width = 180
                    itemgrid.Columns(1).Width = 150
                    itemgrid.Columns(2).Width = 90

                    assetname_txt.Focus()

                    ok_btn.Visible = True
                    edit_btn.Text = "&Edit"
                    Call clear()
                    assetname_txt.Focus()
                End If
              
                'End If
                '        End If
                '    End If
            Else

                If cntdt.Rows.Count <= 0 Then
                    MsgBox("There is No Row", MsgBoxStyle.Information, err)
                    assetname_txt.Focus()
                Else
                    response = MsgBox("Are you sure", MsgBoxStyle.YesNo, err)
                    If (response = vbYes) Then
                        Dim getdt As New DataTable
                        getdt = itemgrid.DataSource
                        i = itemgrid.CurrentRow.Index
                        assetname_txt.Text = getdt.Rows(i)(0)
                        a.Text = getdt.Rows(i)(0)
                        assetamt_txt.Text = getdt.Rows(i)(1)
                        Dim dat As Date
                        Dim aa As String
                        aa = getdt.Rows(i)(2)
                        aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                        dat = CDate(aa)
                        pdate.Value = dat

                        ok_btn.Visible = False
                        edit_btn.Text = "&UPDATE"
                        assetname_txt.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub res_btn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                edit_btn.Focus()
            ElseIf e.KeyCode = Keys.Right Then
                Exit_btn.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub edit_btn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edit_btn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then
                ok_btn.Focus()
            ElseIf e.KeyCode = Keys.Right Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Exit_btn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Exit_btn.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Left Then

            ElseIf e.KeyCode = Keys.Right Then
                assetname_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub pdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                assetamt_txt.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Dim response As String
                response = MsgBox("Are you sure to Reset", MsgBoxStyle.YesNo, "Warning")
                If vbYes = response Then
                    clear()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                assetname_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GroupBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox1.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GroupBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox2.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Itemgrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub itemgrid_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles itemgrid.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class