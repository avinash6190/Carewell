Imports System.Data.SqlClient
Module AlertModule
    Public ds1 As New DataSet
    Function Alert_PROC(ByVal type As String, ByVal date1 As String, ByVal id As String, ByVal opt As String)
        ds1 = New DataSet
        cmd = New SqlCommand("exec Alert_proc '" & type & "','" & date1 & "','" & id & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds1)
        Return ds1.Tables(0)
    End Function
End Module
