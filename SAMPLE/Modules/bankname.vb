Imports System.Data.SqlClient
Module bankname
    Function bank_proc(ByVal name As String, ByVal oldname As String)
        ds = New DataSet
        cmd = New SqlCommand("exec bank_procedure '" & name & " ', '" & oldname & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If oldname <> "VIEW" And oldname <> "v1" Then
            If ds.Tables(0).Rows(0)(0) = -1 Then
                MsgBox("Bank Name already existed")
            ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox("Bank name is successfully added")
            ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                MsgBox("successfully deleted")
            ElseIf ds.Tables(0).Rows(0)(0) = -2 Then
                MsgBox("Does not deleted the bank")
            ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                MsgBox("Bank name is updated successfully")
            ElseIf ds.Tables(0).Rows(0)(0) = -8 Then
                MsgBox("Does not updated")
            End If
        End If
        Return ds.Tables(0)
    End Function
    Public Function viewbank()
        cmd = New SqlCommand("viewbank")
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "viewbank1")
        Return ds.Tables(0)
    End Function
    Public Function Existbankloan(ByVal a As String, ByVal name As String, ByVal id As Integer, ByVal opt As String)
        cmd = New SqlCommand("exec Existbankloan '" & a & "','" & name & "'," & id & ",'" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Public Function updatebankloan1(ByVal olddate As String, ByVal curdate As String, ByVal loantype As String, ByVal accno As String, ByVal accname As String, ByVal bankname As String, ByVal mode As String, ByVal loanamount As String, ByVal cheqno As String, ByVal cdat As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec updatebankloan1 '" & olddate & "','" & curdate & "','" & loantype & "','" & accno & "','" & accname & "','" & bankname & "','" & mode & "','" & loanamount & "','" & cheqno & "','" & cdat & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Public Function insertbankloan(ByVal old_date As String, ByVal loantype As String, ByVal accno As String, ByVal accname As String, ByVal bankname As String, ByVal mode As String, ByVal loanamt As String, ByVal chequeno As String, ByVal chdat As String, ByVal opt1 As String)
        cmd = New SqlCommand("exec insertbankloan1 '" & old_date & "','" & loantype & "'," & accno & ",'" & accname & "','" & bankname & "','" & mode & "','" & loanamt & "','" & chequeno & "','" & chdat & "','" & opt1 & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function bankloanview()
        cmd = New SqlCommand("bankloanview")
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "bankl")
        Return ds.Tables(0)
    End Function
    Public Function updatebankloan(ByVal a As Integer, ByVal b As String, ByVal bname As String)
        cmd = New SqlCommand("exec updatebankloan '" & a & "','" & b & "','" & bname & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function updatebankOD(ByVal a As Integer, ByVal b As Decimal, ByVal bname As String)
        cmd = New SqlCommand("exec updatebankOD '" & a & "','" & b & "','" & bname & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function ExistbankOD(ByVal a As String, ByVal bak As String, ByVal id As Integer, ByVal opt As String)
        cmd = New SqlCommand("exec ExistbankOD '" & a & "','" & bak & "'," & id & ",'" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Public Function insertbankod(ByVal old_date As String, ByVal old_amt As String, ByVal new_date As String, ByVal new_amt As String, ByVal bankname As String, ByVal mode1 As String, ByVal loanamount As String, ByVal opt1 As String, ByVal opt2 As String)
        cmd = New SqlCommand("exec insertbankod1 '" & old_date & "'," & old_amt & ",'" & new_date & "'," & new_amt & ",'" & bankname & "','" & mode1 & "','" & loanamount & "','" & opt1 & "', '" & opt2 & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1

    End Function
    Public Function bankodview()
        cmd = New SqlCommand("bankodview", con)
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "bankod11")
        Return ds.Tables(0)
    End Function
    Public Function updatebankod1(ByVal olddate As String, ByVal curdate As String, ByVal loantype As String, ByVal accno As String, ByVal accname As String, ByVal bankname As String, ByVal mode As String, ByVal loanamount As String, ByVal cheqno As String, ByVal chdat As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec updatebankod1 '" & olddate & "','" & curdate & "','" & loantype & "','" & accno & "','" & accname & "','" & bankname & "','" & mode & "','" & loanamount & "','" & cheqno & "','" & chdat & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Public Function GETLOANTransaction(ByVal A As Integer, ByVal b As String)
        cmd = New SqlCommand("exec GETloanTransaction '" & A & "','" & b & "'", con)
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "GETloanTransaction1")
        Return ds.Tables(0)
    End Function
    Public Function CHECKTRANS(ByVal ldate As String, ByVal pdate As String, ByVal id As Integer, ByVal tbl As String, ByVal opt As String)
        cmd = New SqlCommand("exec checktrans '" & ldate & "','" & pdate & "'," & id & ",'" & tbl & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "checktrans1")
        Return ds.Tables(0).Rows(0)(0)
    End Function
    Public Function insertbankODtransp(ByVal a As String, ByVal b As String, ByVal c As Decimal, ByVal eaddress As String, ByVal accno As String, ByVal accname As String, ByVal id As Integer, ByVal mode As String, ByVal checkno As String, ByVal chdat As String)
        cmd = New SqlCommand("exec insertbankODtransp '" & a & "','" & b & "'," & c & ",'" & eaddress & "','" & accno & "','" & accname & "'," & id & ",'" & mode & "','" & checkno & "','" & chdat & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function insertbankloantransp(ByVal a As String, ByVal b As String, ByVal c As Decimal, ByVal eaddress As String, ByVal accno As String, ByVal accname As String, ByVal id As Integer, ByVal mode As String, ByVal checkno As String, ByVal chdat As String)
        cmd = New SqlCommand("exec insertbankloantransp '" & a & "','" & b & "'," & c & ",'" & eaddress & "','" & accno & "','" & accname & "'," & id & ",'" & mode & "','" & checkno & "','" & chdat & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function updatebankODtrans(ByVal date1 As String, ByVal amount As Decimal, ByVal cid As Integer, ByVal pid As Integer, ByVal mode As String, ByVal chno As String, ByVal chdat As String)
        cmd = New SqlCommand("exec updatebankODtrans '" & date1 & "'," & amount & ",'" & cid & "','" & pid & "','" & mode & "','" & chno & "','" & chdat & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function updatebankloantrans(ByVal date1 As String, ByVal amount As Decimal, ByVal cid As Integer, ByVal pid As Integer, ByVal mode As String, ByVal chno As String, ByVal chdat As String)
        cmd = New SqlCommand("exec updatebankloantrans '" & date1 & "'," & amount & ",'" & cid & "','" & pid & "','" & mode & "','" & chno & "','" & chdat & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Return 1
    End Function
    Public Function deletebanktrans(ByVal a As Integer, ByVal b As Integer, ByVal opt As String, ByVal c As String)
        cmd = New SqlCommand("exec deletebanktrans '" & a & "','" & b & "','" & opt & "','" & c & "'", con)
        da = New SqlDataAdapter(cmd)
        cmd.ExecuteScalar()
        Return 1
    End Function
    Function deposit_proc(ByVal datee As String, ByVal name As String, ByVal acctno As String, ByVal amt As Decimal, ByVal bank As String, ByVal branch As String, ByVal oldno As String, ByVal oldname As String, ByVal deptype As String, ByVal checkno As String, ByVal date2 As String, ByVal chdat As String, ByVal opt As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec deposit_proc '" & datee & "','" & name & "','" & acctno & "'," & amt & ",'" & bank & "','" & branch & "','" & oldno & "','" & oldname & "','" & deptype & "','" & checkno & "','" & date2 & "','" & chdat & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt <> "VIEW" Then
            If ds.Tables(0).Rows(0)(0) = -1 Then
                MsgBox("Already Exists", MsgBoxStyle.Critical, err)

            ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox("SuccessFully Deposited ")
            ElseIf ds.Tables(0).Rows(0)(0) = 0 Then
                MsgBox("Cannot Be Deleted ")
            ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                MsgBox("Account SuccessFully Deleted")
            ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                MsgBox("Account SuccessFully Updated")
            End If
        End If
        Return ds.Tables(0)
    End Function
    Function withdraw_PROC(ByVal datee As String, ByVal name As String, ByVal acctno As String, ByVal amt As Decimal, ByVal bank As String, ByVal branch As String, ByVal oldno As String, ByVal oldname As String, ByVal chdat As String, ByVal opt As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec withdraw_PROC '" & datee & "','" & name & "','" & acctno & "'," & amt & ",'" & bank & "','" & branch & "','" & oldno & "','" & oldname & "','" & chdat & "','" & opt & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If opt <> "VIEW" And opt <> "amtcheck" Then
            If ds.Tables(0).Rows(0)(0) = -1 Then
                MsgBox("Already Exists", MsgBoxStyle.Critical, err)

            ElseIf ds.Tables(0).Rows(0)(0) = 1 Then
                MsgBox("SuccessFully withdraw the amount ")

            ElseIf ds.Tables(0).Rows(0)(0) = 3 Then
                MsgBox("Account SuccessFully Deleted")
            ElseIf ds.Tables(0).Rows(0)(0) = 2 Then
                MsgBox("Account SuccessFully Updated")
            End If
        End If
        Return ds.Tables(0)
    End Function
    Public Function GETODTransaction(ByVal A As Integer, ByVal bankname As String)
        cmd = New SqlCommand("exec GETODTransaction '" & A & "','" & bankname & "'", con)
        da = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "GETODTransaction1")
        Return ds.Tables(0)
    End Function
    Public Function BankReport1(ByVal a As String, ByVal billfrom As String, ByVal billto As String)
        ds = New DataSet
        cmd = New SqlCommand("exec bankreport '" & a & "','" & billfrom & "','" & billto & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Function accountnosearch(ByVal accno As String, ByVal opt1 As String, ByVal opt2 As String)
        ds = New DataSet()
        cmd = New SqlCommand("exec acc '" & accno & "','" & opt1 & "','" & opt2 & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module

