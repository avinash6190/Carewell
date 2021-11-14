Imports System.Data.SqlClient
Public Class changepassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Trim(username_txt.Text) = "" Or Trim(password_txt.Text) = "" Or oldpass_txt.Text = "" Or olduser_txt.Text = "" Then
                MsgBox("Fields Cannot Be Left", MsgBoxStyle.Information, "message")
                username_txt.Focus()
            Else
                Dim dt3 As New DataTable
                dt3 = login_proced("", "", olduser_txt.Text, oldpass_txt.Text, "", "view2")
                If dt3.Rows(0)(0).ToString = olduser_txt.Text And dt3.Rows(0)(1).ToString = oldpass_txt.Text Then
                    login_proced(Trim(username_txt.Text), Trim(password_txt.Text), Trim(olduser_txt.Text), Trim(oldpass_txt.Text), "", "UPDATE")
                    MsgBox("Successfully Updated", MsgBoxStyle.Information, "message")
                    username_txt.Focus()
                Else
                    MsgBox("Give Correct OldUserName & Oldpassword", MsgBoxStyle.Information, "message")
                    username_txt.Focus()
                End If
                username_txt.Text = ""
                password_txt.Text = ""
                olduser_txt.Text = ""
                oldpass_txt.Text = ""
                username_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub username_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username_txt.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            password_txt.Focus()
        End If
    End Sub
    Private Sub password_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_txt.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                olduser_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub retypepass_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles oldpass_txt.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                Button1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoginRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub LoginRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            username_txt.Visible = True
            password_txt.Visible = True
            olduser_txt.Visible = True
            oldpass_txt.Visible = True
            Button1.Text = "&UPDATE"
            username_txt.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub olduser_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles olduser_txt.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                oldpass_txt.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GroupBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class