Imports System.Data.SqlClient
Module brand
    Dim ds As New DataSet
    Function brand_name(ByVal name As String, ByVal status As String, ByVal opt As String)
        ds = New DataSet
        cmd = New SqlCommand("exec brandname2 '" & name & "', '" & status & "', '" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt <> "view" Then
            If ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox("successfully added", MsgBoxStyle.Information, "Message")
            End If
        End If
        Return ds.Tables(0)
    End Function
    Function client_register(ByVal name As String, ByVal address As String, ByVal email As String, ByVal phno As String, ByVal mobno As String, ByVal tinno As String, ByVal cstno As String, ByVal status As String, ByVal dlno As String, ByVal option1 As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec clientregister1 '" & name & "','" & address & "','" & email & "','" & phno & "','" & mobno & "','" & tinno & "','" & cstno & "','" & status & "','" & dlno & "','" & option1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function emp_register(ByVal name As String, ByVal address As String, ByVal email As String, ByVal mobno As String, ByVal status As String, ByVal option1 As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec empregister '" & name & "', '" & address & "', '" & email & "', '" & mobno & "', '" & status & "', '" & option1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function unit_procedure(ByVal unitname As String, ByVal status As String, ByVal option1 As String)
        ds = New DataSet
        cmd = New SqlCommand("exec unitcreation '" & unitname & "','" & status & "','" & option1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function supplier_procedure(ByVal supliername As String, ByVal address As String, ByVal phoneno As String, ByVal mobileno As String, ByVal tinno As String, ByVal email As String, ByVal diagnosticno As String, ByVal status As String, ByVal option1 As String, ByVal cstno As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec supplier1 '" & supliername & "', '" & address & "','" & phoneno & "','" & mobileno & "','" & tinno & "','" & email & "','" & diagnosticno & "','" & status & "','" & option1 & "','" & cstno & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function brand_saved(ByVal matname As String, ByVal brandname As String, ByVal status As String, ByVal option1 As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec brandcreation1 '" & matname & "','" & brandname & "','" & status & "', '" & option1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function mat_name(ByVal materialname As String, ByVal status As String, ByVal option1 As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec material10 '" & materialname & "', '" & status & "', '" & option1 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Public Function mat()
        cmd = New SqlCommand("matname")
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "material")
        Return ds.Tables(0)
    End Function
End Module