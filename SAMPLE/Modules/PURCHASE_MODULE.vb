Imports System.Data.SqlClient
Module PURCHASE_MODULE
    Function PURCHASE_PROC(ByVal BILLNO As String, ByVal billid As Integer, ByVal SUPNAME As String, ByVal SUPADDR As String, ByVal STOCKDATE As String, ByVal INVOICEDATE As String, ByVal BILLTYPE As String, ByVal TOTAMT As Decimal, ByVal VATPERCENT As Decimal, ByVal VATAMT As Decimal, ByVal NETAMT As Decimal, ByVal EMPID As Integer, ByVal CREATEDATE As String, ByVal RECAMT As Decimal, ByVal opt As String, ByVal DISCOUNT As Decimal, ByVal SAMPL As Decimal, ByVal bvatper As Integer, ByVal bvatamt As Decimal, ByVal bvattype As String, ByVal bdisper As Integer, ByVal bdisamt As Decimal, ByVal bdistype As String, ByVal oexp As Decimal)
        ds = New DataSet
        cmd = New SqlCommand("exec PURCHASE_PROC '" & BILLNO & "'," & billid & ",'" & SUPNAME & "','" & SUPADDR & "','" & STOCKDATE & "','" & INVOICEDATE & "','" & BILLTYPE & "'," & TOTAMT & "," & VATPERCENT & "," & VATAMT & "," & NETAMT & "," & EMPID & ",'" & CREATEDATE & "'," & RECAMT & ",'" & opt & "'," & DISCOUNT & "," & SAMPL & "," & bvatper & "," & bvatamt & ",'" & bvattype & "'," & bdisper & "," & bdisamt & ",'" & bdistype & "'," & oexp & "", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function PURCHASEDETAILS_PROC(ByVal BILLID As Integer, ByVal BILLNO As String, ByVal MATNAME As String, ByVal ITEMNAME As String, ByVal QTY As Integer, ByVal UNITNAME As String, ByVal FQTY As Integer, ByVal FUNIT As String, ByVal PRATE As Decimal, ByVal VATPERCENT As Decimal, ByVal VATAMT As Decimal, ByVal DISPERCENT As Decimal, ByVal DISAMT As Decimal, ByVal GROSS As Decimal, ByVal totamt As Decimal, ByVal Opt As String, ByVal SAMPL As String, ByVal SAMPL1 As String)
        ds = New DataSet
        cmd = New SqlCommand("exec purchasedetails_proc " & BILLID & ",'" & BILLNO & "','" & MATNAME & "','" & ITEMNAME & "'," & QTY & ",'" & UNITNAME & "'," & FQTY & ",'" & FUNIT & "'," & PRATE & "," & VATPERCENT & "," & VATAMT & "," & DISPERCENT & "," & DISAMT & "," & GROSS & "," & totamt & ",'" & Opt & "','" & SAMPL & "','" & SAMPL1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
