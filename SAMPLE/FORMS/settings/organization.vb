Imports Shell32

Public Class organization
    Dim shellinterface As New Shell32.Shell()
    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Dim dt1 As New DataTable
        Dim cnt As New DataTable
        If Trim(orgname.Text) = "" Or Trim(address.Text) = "" Or Trim(phoneno.Text) = "" Or Trim(mobileno1.Text) = "" Or Trim(mobileno2.Text) = "" Or Trim(tinno.Text) = "" Or Trim(cstno.Text) = "" Or Trim(druglicenceno.Text) = "" Or Trim(txt_ad.Text) = "" Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Information, "Message")
        Else
            If ok.Text = "&SAVE" Then
                orgregister(Trim(orgname.Text), Trim(address.Text), Trim(phoneno.Text), Trim(mobileno1.Text), Trim(mobileno2.Text), Trim(tinno.Text), Trim(cstno.Text), Trim(druglicenceno.Text), "insert", "", Trim(txt_ad.Text), Trim(txt_dl2.Text), dl_dat.Value.ToString("MM/dd/yyyy"))
                dt1 = orgregister("", "", "", "", "", "", "", "", "view", "", "", "", "")
                If dt1.Rows.Count > 0 Then
                    orgname.Text = dt1.Rows(0)(0)
                    address.Text = dt1.Rows(0)(1)
                    phoneno.Text = dt1.Rows(0)(2)
                    mobileno1.Text = dt1.Rows(0)(3)
                    mobileno2.Text = dt1.Rows(0)(4)
                    tinno.Text = dt1.Rows(0)(5)
                    druglicenceno.Text = dt1.Rows(0)(7)
                    cstno.Text = dt1.Rows(0)(6)
                    txt_ad.Text = dt1.Rows(0)(8)
                    txt_dl2.Text = dt1.Rows(0)(9)
                    Dim dat As Date
                    Dim aa As String
                    aa = dt1.Rows(0)(10)
                    aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                    dat = CDate(aa)
                    dl_dat.Value = dat
                    oldname.Text = dt1.Rows(0)(0)
                    Me.Close()
                    txt_ad.Text = ""
                    orgname.Text = ""
                    address.Text = ""
                    phoneno.Text = ""
                    mobileno1.Text = ""
                    mobileno2.Text = ""
                    tinno.Text = ""
                    druglicenceno.Text = ""
                    cstno.Text = ""
                End If
            ElseIf ok.Text = "&UPDATE" Then
                cnt = orgregister(Trim(orgname.Text), Trim(address.Text), Trim(phoneno.Text), Trim(mobileno1.Text), Trim(mobileno2.Text), Trim(tinno.Text), Trim(cstno.Text), Trim(druglicenceno.Text), "update", oldname.Text, Trim(txt_ad.Text), Trim(txt_dl2.Text), dl_dat.Value.ToString("MM/dd/yyyy"))
                If cnt.Rows(0)(0) = 3 Then
                    MsgBox("Successfully Updated", MsgBoxStyle.Information, "message")
                    dt1.Rows.Clear()
                    dt1 = orgregister("", "", "", "", "", "", "", "", "view", "", "", "", "")
                    orgname.Text = dt1.Rows(0)(0)
                    address.Text = dt1.Rows(0)(1)
                    phoneno.Text = dt1.Rows(0)(2)
                    mobileno1.Text = dt1.Rows(0)(3)
                    mobileno2.Text = dt1.Rows(0)(4)
                    tinno.Text = dt1.Rows(0)(5)
                    cstno.Text = dt1.Rows(0)(6)
                    druglicenceno.Text = dt1.Rows(0)(7)
                    txt_ad.Text = dt1.Rows(0)(8)
                    txt_dl2.Text = dt1.Rows(0)(9)
                    Dim dat As Date
                    Dim aa As String
                    aa = dt1.Rows(0)(10)
                    aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                    dat = CDate(aa)
                    dl_dat.Value = dat
                    oldname.Text = dt1.Rows(0)(0)
                    ok.Text = "&UPDATE"
                    oldname.Text = dt1.Rows(0)(0)
                Else
                    MsgBox("Not updated", MsgBoxStyle.Information, "message")
                End If
            End If
        End If
        orgname.Focus()
    End Sub
    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        orgname.Text = ""
        address.Text = ""
        phoneno.Text = ""
        mobileno1.Text = ""
        mobileno2.Text = ""
        tinno.Text = ""
        cstno.Text = ""
        txt_ad.Text = ""
        txt_dl2.Text = ""
        dl_dat.Value = Today.Date
        druglicenceno.Text = ""
        orgname.Focus()
        ok.Text = "&SAVE"
    End Sub

    Private Sub organization_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim dt1 As New DataTable
        dt1 = orgregister("", "", "", "", "", "", "", "", "view", "", "", "", "")
        If dt1.Rows.Count > 0 Then
        Else
            Application.Exit()
        End If
    End Sub
    Private Sub organization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connect()
            Dim dt1 As New DataTable
            dt1.Rows.Clear()
            dt1 = orgregister("", "", "", "", "", "", "", "", "view", "", "", "", "")
            If dt1.Rows.Count > 0 Then
                orgname.Text = dt1.Rows(0)(0)
                address.Text = dt1.Rows(0)(1)
                phoneno.Text = dt1.Rows(0)(2)
                mobileno1.Text = dt1.Rows(0)(3)
                mobileno2.Text = dt1.Rows(0)(4)
                tinno.Text = dt1.Rows(0)(5)
                cstno.Text = dt1.Rows(0)(6)
                druglicenceno.Text = dt1.Rows(0)(7)
                ok.Text = "&UPDATE"
                oldname.Text = dt1.Rows(0)(0)
                txt_ad.Text = dt1.Rows(0)(8)
                txt_dl2.Text = dt1.Rows(0)(9).ToString
                Dim dat As Date
                Dim aa As String
                aa = dt1.Rows(0)(10)
                aa = aa.Substring(3, 2) & "/" & aa.Substring(0, 2) & "/" & aa.Substring(6, 4)
                dat = CDate(aa)
                dl_dat.Value = dat
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub orgname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles orgname.KeyDown
        If e.KeyCode = Keys.Enter Then
            address.Enabled = True
            address.Focus()
        End If
    End Sub
    Private Sub phoneno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles phoneno.KeyDown
        If e.KeyCode = Keys.Enter Then
            mobileno1.Enabled = True
            mobileno1.Focus()
        End If
    End Sub
    Private Sub mobileno1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mobileno1.KeyDown
        If e.KeyCode = Keys.Enter Then
            mobileno2.Enabled = True
            mobileno2.Focus()
        End If
    End Sub
    Private Sub mobileno2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mobileno2.KeyDown
        If e.KeyCode = Keys.Enter Then
            tinno.Enabled = True
            tinno.Focus()
        End If
    End Sub

    Private Sub tinno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tinno.KeyDown
        If e.KeyCode = Keys.Enter Then
            cstno.Enabled = True
            cstno.Focus()
        End If
    End Sub

    Private Sub cstno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstno.KeyDown
        If e.KeyCode = Keys.Enter Then
            druglicenceno.Enabled = True
            druglicenceno.Focus()
        End If
    End Sub
    Private Sub phoneno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneno.KeyPress
        If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 44) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 47) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
            e.Handled = True
        End If
        Dim a As String
        a = phoneno.Text
        Dim index As Int32 = a.LastIndexOf(".")
        If index >= 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub mobileno1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobileno1.KeyPress
        If (Char.IsLetter(e.KeyChar) = True) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 46) Or Char.IsSymbol(e.KeyChar) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 63) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 64) Then
            e.Handled = True
        End If
        Dim a As String
        a = mobileno1.Text
        Dim index As Int32 = a.LastIndexOf(".")
        If index >= 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub druglicenceno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles druglicenceno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If druglicenceno.Text <> "" Then
                txt_dl2.Focus()
            Else
                druglicenceno.Focus()
            End If
        End If
    End Sub
    Private Sub orgname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles orgname.KeyPress
        Try
            e.KeyChar = Char.ToUpper(e.KeyChar)
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub address_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles address.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or address.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mobileno2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobileno2.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_ad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or orgname.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub druglicenceno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles druglicenceno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cstno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cstno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tinno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tinno.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_ad_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ad.KeyPress
        Try
            Static PreviousLetter As Char
            If PreviousLetter = " "c Or txt_ad.Text.Length = 0 Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            PreviousLetter = e.KeyChar
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dl2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_dl2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If druglicenceno.Text <> "" Then
                dl_dat.Focus()
            Else
                druglicenceno.Focus()
            End If
        End If
    End Sub

    Private Sub txt_dl2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dl2.KeyPress
        Try
            e.Handled = TrapKey1(Asc(e.KeyChar))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dl_dat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dl_dat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_ad.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub phoneno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phoneno.TextChanged

    End Sub
End Class

