Imports System.Data.SqlClient
Module ReportModule
    Function REPORTS_PROC(ByVal brandname As String, ByVal productnmae As String, ByVal FromDate As String, ByVal ToDate As String, ByVal sam As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec Reports_proc '" & brandname & "','" & productnmae & "','" & FromDate & "','" & ToDate & "','" & sam & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            If opt = "DayBook" Then
                Return ds
            Else
                Return ds.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function sales_report(ByVal brandname As String, ByVal productnmae As String, ByVal FromDate As String, ByVal ToDate As String, ByVal sam As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec sales_reports '" & brandname & "','" & productnmae & "','" & FromDate & "','" & ToDate & "','" & sam & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function salret_report(ByVal brandname As String, ByVal productnmae As String, ByVal FromDate As String, ByVal ToDate As String, ByVal sam As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec salret_reports '" & brandname & "','" & productnmae & "','" & FromDate & "','" & ToDate & "','" & sam & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function purret_report(ByVal brandname As String, ByVal productnmae As String, ByVal FromDate As String, ByVal ToDate As String, ByVal sam As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec purret_reports '" & brandname & "','" & productnmae & "','" & FromDate & "','" & ToDate & "','" & sam & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
End Module
