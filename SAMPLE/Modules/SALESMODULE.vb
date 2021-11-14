Imports System.Data.SqlClient
Module SALESMODULE
    Function SALES_PROC(ByVal billno As String, ByVal custname As String, ByVal custadd As String, ByVal PHONE As String, ByVal salesdate As String, ByVal mode As String, ByVal grossamount As Decimal, ByVal vatper As Decimal, ByVal vatamt As Decimal, ByVal dispercent As Decimal, ByVal DISCOUNT As Decimal, ByVal netamount As Decimal, ByVal RECAMT As Decimal, ByVal orderby As String, ByVal payment As String, ByVal orderdate As String, ByVal dispatch As String, ByVal dcno As String, ByVal dcdate As String, ByVal OPT As String, ByVal bvatper As Integer, ByVal bvatamt As Decimal, ByVal bvattype As String, ByVal bdisper As Integer, ByVal bdisamt As Decimal, ByVal bdistype As String, ByVal bcstp As Integer, ByVal bcstamt As Decimal, ByVal bcsttype As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec SALES_PROC '" & billno & "','" & custname & "','" & custadd & "','" & PHONE & "','" & salesdate & "','" & mode & "'," & grossamount & "," & vatper & "," & vatamt & "," & dispercent & "," & DISCOUNT & "," & netamount & "," & RECAMT & ",'" & orderby & "','" & payment & "','" & orderdate & "','" & dispatch & "','" & dcno & "','" & dcdate & "','" & OPT & "'," & bvatper & "," & bvatamt & ",'" & bvattype & "'," & bdisper & "," & bdisamt & ",'" & bdistype & "'," & bcstp & "," & bcstamt & ",'" & bcsttype & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function SALES_DETAILS(ByVal BILLNO As String, ByVal BRANDNAME As String, ByVal PRODUCTNAME As String, ByVal QTY As Integer, ByVal UNIT As String, ByVal SRATE As Decimal, ByVal U2SRAT As Decimal, ByVal vatper As Decimal, ByVal vatamt As Decimal, ByVal disper As Decimal, ByVal disamt As Decimal, ByVal grossamt As Decimal, ByVal netamt As Decimal, ByVal MRP As Decimal, ByVal fqty As Decimal, ByVal funit As String, ByVal cst As Decimal, ByVal cstamt As Decimal, ByVal batchno As String, ByVal OPT As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("EXEC SALES_DETAILS_PROC '" & BILLNO & "','" & BRANDNAME & "','" & PRODUCTNAME & "'," & QTY & ",'" & UNIT & "'," & SRATE & "," & U2SRAT & "," & vatper & "," & vatamt & "," & disper & "," & disamt & "," & grossamt & "," & netamt & "," & MRP & "," & fqty & ",'" & funit & "'," & cst & "," & cstamt & ",'" & batchno & "','" & OPT & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function Find_Items(ByVal brandname As String, ByVal productname As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec Find_Items '" & brandname & "','" & productname & " '", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Module
