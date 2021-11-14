Imports System.Data.SqlClient
Module comt_module
    Function commitment(ByVal date1 As String, ByVal com As String, ByVal status As String, ByVal opt As String, ByVal sam As String, ByVal sam1 As String, ByVal sam2 As String)
        ds = New DataSet
        cmd = New SqlCommand("exec comitment_proc '" & date1 & "','" & com & "','" & status & "','" & opt & "','" & sam & "','" & sam1 & "','" & sam2 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function SQL(ByVal s As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("" & s & "", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function Orders(ByVal id As Integer, ByVal type As String, ByVal nameid As Integer, ByVal date1 As String, ByVal Order As String, ByVal s1 As String, ByVal s2 As String, ByVal opt As String)
        ds = New DataSet
        cmd = New SqlCommand("exec order_proc " & id & ",'" & type & "'," & nameid & ",'" & date1 & "','" & Order & "','" & s1 & "','" & s2 & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
