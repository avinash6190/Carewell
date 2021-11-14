Imports System.Data.SqlClient
Module payment_module
    Function sales_pay_proc(ByVal date1 As String, ByVal BillNo As String, ByVal mode As String, ByVal paidamt As Decimal, ByVal discount As Decimal, ByVal bankname As String, ByVal accholdername As String, ByVal accno As String, ByVal chequeno As String, ByVal custname As String, ByVal SALES As Decimal, ByVal SAM As String, ByVal SAM1 As String, ByVal opt As String)
        ds = New DataSet
        cmd = New SqlCommand("exec sales_pay_proc '" & date1 & "','" & BillNo & "','" & mode & "'," & paidamt & "," & discount & ",'" & bankname & "','" & accholdername & "','" & accno & "','" & chequeno & "','" & custname & "'," & SALES & ",'" & SAM & "','" & SAM1 & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function cust_pay_rpt(ByVal cust As String, ByVal billno As String, ByVal FromDate As String, ByVal ToDate As String, ByVal sam As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec custpay_rpt '" & cust & "','" & billno & "','" & FromDate & "','" & ToDate & "','" & sam & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function purchasepayview(ByVal suppliername As String, ByVal opt1 As String, ByVal opt2 As String, ByVal opt3 As String)
        ds = New DataSet
        cmd = New SqlCommand("exec purchasepayview '" & suppliername & "','" & opt1 & "','" & opt2 & "','" & opt3 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function purchase_pay_proc(ByVal date1 As String, ByVal BillNo As String, ByVal mode As String, ByVal paidamt As Decimal, ByVal discount As Decimal, ByVal bankname As String, ByVal accholdername As String, ByVal accno As String, ByVal chequeno As String, ByVal supname As String, ByVal purchase As String, ByVal SAM As String, ByVal SAM1 As String)
        ds = New DataSet
        cmd = New SqlCommand("exec purchase_pay_proc '" & date1 & "','" & BillNo & "','" & mode & "'," & paidamt & "," & discount & ",'" & bankname & "','" & accholdername & "','" & accno & "','" & chequeno & "','" & supname & "','" & purchase & "','" & SAM & "','" & SAM1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function sup_pay_rpt(ByVal sup As String, ByVal billno As String, ByVal FromDate As String, ByVal ToDate As String, ByVal sam As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec suppay_rpt '" & sup & "','" & billno & "','" & FromDate & "','" & ToDate & "','" & sam & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
End Module
