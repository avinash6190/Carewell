Imports System.Data.SqlClient

Module BalanceandTrading

    Function TRADING123(ByVal FromDate As String, ByVal ToDate As String)
        Dim ds As New DataSet
        cmd = New SqlCommand("exec trading '" & FromDate & "','" & ToDate & "','T',0,0,0,0,0,0", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Trading")
        cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Companydetails")

        Return ds
    End Function
    Function BALANCE(ByVal FromDate As String, ByVal ToDate As String)
        Dim ds As New bal
        cmd = New SqlCommand("exec bal1 '" & FromDate & "','" & ToDate & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Balance")
        cmd = New SqlCommand("select orgname as organizationname,address as address1,phoneno as phoneno,mobno1 as mobileno1,email as email,tinno as tinno,cstno as cstno,druglicenceno as DrugLicenceNo ,Authoriseddistributor as authorised,sample2 as sam2 from Organization", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Companydetails")
        Return ds
    End Function
End Module

