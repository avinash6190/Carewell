Public Class loginregister

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub loginregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            username.Visible = True
            password.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            olduname.Visible = False
            oldpassword.Visible = False
            Label3.Visible = False
            Label4.Visible = False

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click

    End Sub
End Class