Imports system.data.sqlclient
Module pur_ret_module
    Function purret_main(ByVal billid As Integer, ByVal billno As String, ByVal supname As String, ByVal add As String, ByVal pdate As String, ByVal retmode As String, ByVal totamt As Decimal, ByVal retamt As Decimal, ByVal SAM As String, ByVal opt As String)
        ds = New DataSet
        cmd = New SqlCommand("EXEC PUR_RET_MAIN_PROC " & billid & ",'" & billno & "','" & supname & "','" & add & "','" & pdate & "','" & retmode & "'," & totamt & "," & retamt & ",'" & SAM & "', '" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function PURRET_DETAILS(ByVal BILLID As Integer, ByVal BILLNO As String, ByVal BNAME As String, ByVal PNAME As String, ByVal QTY As Integer, ByVal UNIT As String, ByVal PRATE As Decimal, ByVal TOTAMT As Decimal, ByVal SAM As String, ByVal OPT As String)
        ds = New DataSet
        cmd = New SqlCommand("EXEC PUR_RET_DETAILS_PROC " & BILLID & ",'" & BILLNO & "','" & BNAME & "','" & PNAME & "'," & QTY & ",'" & UNIT & "'," & PRATE & "," & TOTAMT & ",'" & SAM & "', '" & OPT & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
