Imports System.Data.SqlClient
Module Income_ExpModule
    Function INCOMEEXPENC_PROC(ByVal Name As String, ByVal Amount As Decimal, ByVal NewDate As String, ByVal Mode As String, ByVal OldName As String, ByVal OldDate As String)
        ds = New DataSet
        cmd = New SqlCommand("exec IncomeExpence_proc '" & Name & "'," & Amount & ",'" & NewDate & "','" & Mode & "','" & OldName & "','" & OldDate & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If OldName = "VIEW_Day" Or OldName = "VIEW_Date" Then
            Return ds
        ElseIf OldName <> "VIEW_Day" And OldName <> "Find_Day" And OldName <> "Find_Date" And OldName <> "VIEW_Date" And OldName <> "I-VIEW" And OldName <> "E-VIEW" And OldName <> "VIEWBYDATE" Then
            If ds.Tables(0).Rows(0)(0) = -1 Then
                MsgBox("Already Exists For This Same Date", MsgBoxStyle.Critical, err)
            ElseIf ds.Tables(0).Rows(0)(0) = 0 Then
                MsgBox("Enter A valid Name", MsgBoxStyle.Critical, err)
            ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox(Mode + " SuccessFully Added", MsgBoxStyle.Information, suss)
            ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                MsgBox(Mode + " SuccessFully Deleted", MsgBoxStyle.Information, suss)
            ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                MsgBox(Mode + " SuccessFully Updated", MsgBoxStyle.Information, suss)
            End If
            Return ds.Tables(0)
        Else
            Return ds.Tables(0)
        End If
    End Function
    Function INEX_PROC(ByVal id As Integer, ByVal cname As String, ByVal MODE As String, ByVal opt As String)
        cmd = New SqlCommand("exec INCEXP " & id & ",'" & cname & "','" & MODE & "','" & opt & "'", con)
        Dim ds = New DataSet
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt <> "VIEW" And opt <> "VIEWINC" And opt <> "VIEWEXP" And opt <> "VIEWBYID" Then
            If ds.Tables(0).Rows(0)(0) = 0 Then
                MsgBox(" Name Already Exists", MsgBoxStyle.Critical, "Message")
            ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox("SuccessFully Added", MsgBoxStyle.Information, "Message")
            ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                MsgBox(" SuccessFully Deleted", MsgBoxStyle.Information, "Message")
            ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                MsgBox(" SuccessFully Updated", MsgBoxStyle.Information, "Message")
            ElseIf ds.Tables(0).Rows(0)(0) = 4 Then
                MsgBox("Sorry You can't Delete This Item", MsgBoxStyle.Information, "Message")
            End If
        End If
        Return ds.Tables(0)
    End Function
    Function income_PROC(ByVal ID As Integer, ByVal date1 As String, ByVal incname As String, ByVal desc1 As String, ByVal accno1 As String, ByVal accname1 As String, ByVal bank1 As String, ByVal chkno As String, ByVal chkdate As String, ByVal AMT As Decimal, ByVal opt As String, ByVal paytype As String)
        cmd = New SqlCommand("exec p_income " & ID & ",'" & date1 & "','" & incname & "',  '" & desc1 & "','" & accno1 & "','" & accname1 & "','" & bank1 & "','" & chkno & "', '" & chkdate & "'," & AMT & ",'" & opt & "','" & paytype & "'", con)
        Dim ds = New DataSet
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt = "INSERT" Or opt = "UPDATE" Then
            Return ds.Tables(0).Rows(0)(0)
        ElseIf opt = "VIEW" Or opt = "VIEWITEM" Or opt = "VIEWDATE" Or opt = "VIEWBYID" Or opt = "viewbydate" Or opt = "viewchk" Or opt = "viewall" Or opt = "viewallbydate" Then
            Return ds.Tables(0)
        Else
            Return ds.Tables(0).Rows(0)(0)
        End If
        Return ds.Tables(0)
    End Function
    Function exp_PROC(ByVal ID As Integer, ByVal date1 As String, ByVal incname As String, ByVal desc1 As String, ByVal accno1 As String, ByVal accname1 As String, ByVal bank1 As String, ByVal chkno As String, ByVal chkdate As String, ByVal AMT As Decimal, ByVal opt As String, ByVal paytype As String)
        cmd = New SqlCommand("exec p_Expense " & ID & ",'" & date1 & "','" & incname & "',  '" & desc1 & "','" & accno1 & "','" & accname1 & "','" & bank1 & "','" & chkno & "', '" & chkdate & "'," & AMT & ",'" & opt & "','" & paytype & "'", con)
        Dim ds = New DataSet
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt = "INSERT" Or opt = "UPDATE" Then
            Return ds.Tables(0).Rows(0)(0)
        ElseIf opt = "VIEW" Or opt = "VIEWITEM" Or opt = "VIEWDATE" Or opt = "VIEWBYID" Or opt = "viewbydate" Or opt = "viewchk" Or opt = "viewall" Then
            Return ds.Tables(0)
        Else
            Return ds.Tables(0).Rows(0)(0)
        End If
        Return ds.Tables(0)
    End Function
End Module
