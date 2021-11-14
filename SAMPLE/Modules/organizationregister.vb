Imports System.Data.SqlClient
Module organizationregister
    Function orgregister(ByVal orgname As String, ByVal address As String, ByVal phoneno As String, ByVal mobile1 As String, ByVal mobile2 As String, ByVal tinno As String, ByVal cstno As String, ByVal druglicenceno As String, ByVal addition As String, ByVal oldname As String, ByVal sam As String, ByVal sam2 As String, ByVal dldat As String)
        ds = New DataSet
        cmd = New SqlCommand("exec organization2 '" & orgname & "','" & address & "','" & phoneno & "', '" & mobile1 & "','" & mobile2 & "','" & tinno & "', '" & cstno & "','" & druglicenceno & "','" & addition & "','" & oldname & "','" & sam & "','" & sam2 & "','" & dldat & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function

End Module
