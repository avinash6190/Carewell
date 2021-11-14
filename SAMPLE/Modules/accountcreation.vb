Imports System.Data.SqlClient
Module accountcreation
    Function account_procedure(ByVal bname As String, ByVal type As String, ByVal name As String, ByVal accno As String, ByVal opt As String, ByVal a As String, ByVal b As String, ByVal opn As Decimal)
        Dim ds As New DataSet
        cmd = New SqlCommand("exec accountprocedure '" & bname & "','" & type & "','" & name & "','" & accno & "', '" & opt & "','" & a & "','" & b & "'," & opn & "", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt <> "VIEW" And opt <> "VIEW1" And opt <> "VIEW2" Then

            If ds.Tables(0).Rows(0)(0) = 22 Then
                Return ds.Tables(0)
            ElseIf ds.Tables(0).Rows(0)(0) = 99 Then
                Return ds.Tables(0).Rows(0)(0)
            ElseIf ds.Tables(0).Rows(0)(0) = 23 Then
                Return ds.Tables(0)
            ElseIf ds.Tables(0).Rows(0)(0) = 88 Then
                Return ds.Tables(0)
            ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                MsgBox("Updated successfully")
            ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                MsgBox("successfully deleted")
            ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox("Account successfully created")
            ElseIf ds.Tables(0).Rows(0)(0) = -1 Then
                MsgBox("Account No already existed")
            ElseIf ds.Tables(0).Rows(0)(0) = -12 Then
                MsgBox("Cannot Be Deleted.")
            ElseIf ds.Tables(0).Rows(0)(0) = -13 Then
                MsgBox("Cannot Be Updated.")
            End If
        End If
        Return ds.Tables(0)
    End Function
End Module
