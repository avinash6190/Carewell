Imports System.Data.SqlClient
Module companyinfo_module
    Function companyinfo(ByVal name as String, ByVal value as Decimal, ByVal type as String, ByVal opt as String)
        ds = New DataSet
        cmd = New SqlCommand("exec companyinfo '" & name & "'," & value & ",'" & type & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function ASSET_PROC(ByVal assetname As String, ByVal amt As Decimal, ByVal date1 As String, ByVal oldassetname As String, ByVal opt As String)

        ds = New DataSet
        cmd = New SqlCommand("exec asset_proc '" & assetname & "'," & amt & ",'" & date1 & "','" & oldassetname & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function salary_proc(ByVal empname As String, ByVal date1 As String, ByVal salary As Decimal, ByVal oldempname As String, ByVal olddate As String)
        ds = New DataSet
        cmd = New SqlCommand("exec salary_proc '" & empname & "','" & date1 & "','" & salary & "','" & oldempname & "','" & olddate & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
