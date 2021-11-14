Imports System.Data.SqlClient
Module salret_module
    Function SALRET_MAIN(ByVal BILLNO As String, ByVal CUSTNAME As String, ByVal ADD As String, ByVal SDATE As String, ByVal TOTAMT As Decimal, ByVal RETAMT As Decimal, ByVal billtype As String, ByVal OPT As String)
        ds = New DataSet
        cmd = New SqlCommand("EXEC SALRET_MAIN_PROC '" & BILLNO & "','" & CUSTNAME & "','" & ADD & "','" & SDATE & "'," & TOTAMT & "," & RETAMT & ",'" & billtype & "', '" & OPT & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function SALRET_DETAILS(ByVal BILLNO As String, ByVal BRANDNAME As String, ByVal PRODUCTNAME As String, ByVal QTY As Integer, ByVal UNIT As String, ByVal SRATE As Decimal, ByVal TOTAMT As Decimal, ByVal U2RAT As Decimal, ByVal OPT As String)
        ds = New DataSet
        cmd = New SqlCommand("EXEC SALRET_DETAILS_PROC '" & BILLNO & "','" & BRANDNAME & "','" & PRODUCTNAME & "'," & QTY & ",'" & UNIT & "'," & SRATE & "," & TOTAMT & "," & U2RAT & ",'" & OPT & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
