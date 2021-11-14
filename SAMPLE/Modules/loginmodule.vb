Imports System.Data.SqlClient
Module loginmodule
    Function login_proced(ByVal username As String, ByVal password As String, ByVal oldname As String, ByVal oldpassword As String, ByVal status As String, ByVal opt As String)
        ds = New DataSet
        cmd = New SqlCommand("exec loginprocedure '" & username & "','" & password & "','" & oldname & "','" & oldpassword & "','" & status & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function user_tbl(ByVal username As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec sp_user '" & username & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
End Module

