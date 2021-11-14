Imports System.Data.SqlClient
Module Quotation_module
    Function quotation_proc(ByVal billno As String, ByVal custname As String, ByVal custadd As String, ByVal PHONE As String, ByVal salesdate As String, ByVal mode As String, ByVal grossamount As Decimal, ByVal vatper As Decimal, ByVal vatamt As Decimal, ByVal dispercent As Decimal, ByVal DISCOUNT As Decimal, ByVal netamount As Decimal, ByVal RECAMT As Decimal, ByVal SAMPLE As String, ByVal SAMPLE2 As String, ByVal OPT As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec quotation_PROC '" & billno & "','" & custname & "','" & custadd & "','" & PHONE & "','" & salesdate & "','" & mode & "'," & grossamount & "," & vatper & "," & vatamt & "," & dispercent & "," & DISCOUNT & "," & netamount & "," & RECAMT & ",'" & SAMPLE & "','" & SAMPLE2 & "','" & OPT & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function quotation_DETAILS(ByVal BILLNO As String, ByVal BRANDNAME As String, ByVal PRODUCTNAME As String, ByVal QTY As Integer, ByVal UNIT As String, ByVal SRATE As Decimal, ByVal U2SRAT As Decimal, ByVal vatper As Decimal, ByVal vatamt As Decimal, ByVal disper As Decimal, ByVal disamt As Decimal, ByVal grossamt As Decimal, ByVal netamt As Decimal, ByVal MRP As Decimal, ByVal OPT As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("EXEC quotation_DETAILS_PROC '" & BILLNO & "','" & BRANDNAME & "','" & PRODUCTNAME & "'," & QTY & ",'" & UNIT & "'," & SRATE & "," & U2SRAT & "," & vatper & "," & vatamt & "," & disper & "," & disamt & "," & grossamt & "," & netamt & "," & MRP & ",'" & OPT & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Module
