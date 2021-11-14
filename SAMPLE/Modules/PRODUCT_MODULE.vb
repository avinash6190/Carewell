Imports System.Data.SqlClient
Module PRODUCT_MODULE
    Function PRODUCT_PROC(ByVal MNAME As String, ByVal BNAME As String, ByVal PNAME As String, ByVal QTY As Integer, ByVal WHOLEUNIT As String, ByVal NOOFQTY As Integer, ByVal UNITID As String, ByVal PRATE As Decimal, ByVal SRATE As Decimal, ByVal MRPRATE As Decimal, ByVal STATUS As String, ByVal SAMPL As String, ByVal SAMPL1 As String, ByVal OPT As String, ByVal BATCH As String)
        ds = New DataSet
        cmd = New SqlCommand("exec PRODUCT_PROC '" & MNAME & "', '" & BNAME & "', '" & PNAME & "'," & QTY & ",'" & WHOLEUNIT & "'," & NOOFQTY & ",'" & UNITID & "'," & PRATE & "," & SRATE & "," & MRPRATE & ",'" & STATUS & "','" & SAMPL & "','" & SAMPL1 & "','" & OPT & "','" & BATCH & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
