Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Collections.Generic
Imports Shell32
Public Class login
    Dim str As String
    Dim str1 As String
    Dim user1 As String
    Dim shellinterface As New Shell32.Shell
    Dim dt As New DataTable
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connect()
            shellinterface.MinimizeAll()
            username.Focus()
            dt = orgregister("", "", "", "", "", "", "", "", "view", "", "", "", "")
            If dt.Rows.Count = 0 Then
                organization.ShowDialog()
            End If
            dt = companyinfo("", 0, "", "Check")
            If dt.Rows(0)(0) = 22 Then
                Company_Info.ShowDialog()
            End If
            dt = login_proced("", "", "", "", "", "view")
            If dt.Rows(0)(0) = 0 Then
                login1.Text = "&Ok"
                username.Focus()
            Else
                login1.Text = "&LOGIN"
                username.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Message")
        End Try
    End Sub
    Private Sub login1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login1.Click
        Try
            If login1.Text = "&Ok" Then
                If Trim(username.Text) = "" Or Trim(password.Text) = "" Then
                    MsgBox("Please fill the all fields", MsgBoxStyle.Information, "Message")
                    username.Focus()
                Else
                    Dim dt As New DataTable
                    dt = login_proced(username.Text, password.Text, "", " ", "A", "Insert")
                    If dt.Rows(0)(0).ToString = 11 Then
                        MsgBox("Username and password is Accepted.", MsgBoxStyle.Information, "Message")
                        login1.Text = "&LOGIN"
                        username.Text = ""
                        password.Text = ""
                        username.Focus()
                    Else
                        MsgBox("Username is Already Exists.", MsgBoxStyle.Information, "Message")
                        username.Text = ""
                        password.Text = ""
                        username.Focus()
                    End If
                End If
            ElseIf login1.Text = "&LOGIN" Then
                Dim dt As New DataTable
                dt = login_proced(username.Text, "", "", " ", "", "login1")
                If Trim(username.Text) = "" Or Trim(password.Text) = "" Then
                    MsgBox("Please fill the all fields", MsgBoxStyle.Information, "Message")
                    username.Focus()
                Else
                    If dt.Rows.Count >= 1 Then
                        If dt.Rows(0)(0).ToString = password.Text Then
                            user_tbl(username.Text, "insert")
                            Dim a As String = dt.Rows(0)(1)
                            If a = "A" Then
                                Me.Hide()
                                CAREWELL.MenuStrip.Visible = True
                                CAREWELL.MenuStrip1.Visible = False
                                CAREWELL.ShowDialog()
                                Me.Close()
                            Else
                                Me.Hide()
                                CAREWELL.MenuStrip.Visible = False
                                CAREWELL.MenuStrip1.Visible = True
                                CAREWELL.ShowDialog()
                                Me.Close()
                            End If
                        Else
                            MsgBox("Username and password is incorrect", MsgBoxStyle.Information, "Message")
                            username.Text = ""
                            password.Text = ""
                            username.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username.KeyDown
        If e.KeyCode = Keys.Enter Then
            password.Focus()
        ElseIf e.KeyData = Keys.Control + Keys.Home Then
            Printer.ShowDialog()
        End If
    End Sub

    Private Sub password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login1.Focus()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class