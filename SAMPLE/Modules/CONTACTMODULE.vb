Imports System.Data.SqlClient
Module CONTACTMODULE
    Function CONTACT_PROC(ByVal Name As String, ByVal MOBILENO As String, ByVal GroupName As String, ByVal OLDName As String, ByVal OldGrpName As String, ByVal oldmobileno As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec CONTACT_PROC '" & Name & "','" & MOBILENO & "','" & GroupName & "','" & OLDName & "','" & OldGrpName & "','" & oldmobileno & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            If OldGrpName <> "VIEW" And OldGrpName <> "NVIEW" Then
                If ds.Tables(0).Rows(0)(0) = 1 Then
                    MsgBox("Group Name Already Exists", MsgBoxStyle.Critical, err)
                ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                    MsgBox("This Group Have some Item So" + vbNewLine + " Delete The item First Before Deleting this", MsgBoxStyle.Critical, err)
                    'ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                    '    MsgBox("Group SuccessFully Added", MsgBoxStyle.Information, suss)
                ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                    MsgBox("Group SuccessFully Deleted", MsgBoxStyle.Information, suss)
                    'ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                    '    MsgBox("Group SuccessFully Updated", MsgBoxStyle.Information, suss)
                End If
            End If
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function CONTACT_GROUP(ByVal grpname As String, ByVal olggrpname As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec CONTACT_GROUP '" & grpname & "','" & olggrpname & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
End Module
