Imports System.Windows.Forms
Imports Shell32
Public Class CAREWELL
    Dim user1 As String
    Public shellinterface As New Shell32.Shell()
    Private Sub BRANDNAMECREATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRANDNAMECREATIONToolStripMenuItem.Click
        Dim frmname As New brandname
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub CLEINTCUSTOMERREGISRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEINTCUSTOMERREGISRATIONToolStripMenuItem.Click
        Dim frmname As New clientcreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()

    End Sub

    Private Sub EMPLOYEEREGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEEREGISTRATIONToolStripMenuItem.Click
        Dim frmname As New empcreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub PRODUCTCREATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTCREATIONToolStripMenuItem.Click
        Dim frmname As New ProductRegister
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub PURCHASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASEToolStripMenuItem.Click
        Dim frmname As New purchase("")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub SALESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESToolStripMenuItem.Click
        Dim frmname As New Sales_Voucher("")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub SUPPLIERREGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPLIERREGISTRATIONToolStripMenuItem.Click
        Dim fname As New suppliercreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()
    End Sub

    Private Sub UNITCREATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNITCREATIONToolStripMenuItem.Click
        Dim fname As New unitcreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()

    End Sub

    Private Sub PURCHASERETURNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASERETURNToolStripMenuItem.Click
        Dim fname As New purchase_return("", "", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()

    End Sub
    Private Sub SALESRETURNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESRETURNToolStripMenuItem.Click
        Dim fname As New Sales_Return("", "", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()

    End Sub
    Private Sub CAREWELL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        Me.Text = "CAREWELL" & "    " & FormatDateTime(Now, DateFormat.LongDate)
        Dim dt1 As New DataTable
        dt1 = Alert_PROC("", Date.Today.ToString("MM/d/yyyy"), "", "showalert-rev")
        If dt1.Rows.Count = 0 Then
        Else
            Dim v As New viewalert
            v.MdiParent = Me
            v.Show()
        End If
        Dim dt2 As New DataTable
        dt2 = Alert_PROC("", Date.Today.ToString("MM/d/yyyy"), "", "showalert-iss")
        If dt2.Rows.Count = 0 Then
        Else
            Dim v As New viewalert_iss
            v.MdiParent = Me
            v.Show()
        End If
        Dim dt3 As New DataTable
        dt3 = commitment("", "", "", "commit_alert", "", "", "")
        If dt3.Rows.Count = 0 Then
        Else
            Dim v As New commit_alert
            v.MdiParent = Me
            v.Show()
        End If
    End Sub

    Private Sub OrganizationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmname As New organization
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frmname As New materialname
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub
    Private Sub AccountCreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmname As New AccountCreation1
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub CompanyInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyInfoToolStripMenuItem.Click
        Dim frmname As New Company_Info2
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub OrganizationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizationToolStripMenuItem1.Click
        Dim frmname As New organization
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub AddBanknameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmname As New Add_BankName
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub
    Private Sub BankPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmname As New payment
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub
    Private Sub SuplierPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuplierPaymentToolStripMenuItem.Click
        Dim frmname As New Purchase_payment("", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub CustomerPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerPaymentToolStripMenuItem.Click
        Dim frmname As New sales_payment("")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub IncomeAndExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeAndExpensesToolStripMenuItem.Click
        Dim frmname As New incomeexpense
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim frmname As New Stock_Ledger
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub OVERALLPURCHASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OVERALLPURCHASEToolStripMenuItem.Click
        Dim frmname As New purchase_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub TODAYSALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODAYSALToolStripMenuItem.Click
        Dim frmname As New sales_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub SalesReturnReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReturnReportToolStripMenuItem.Click
        Dim frmname As New salret_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem1.Click
        Dim frmname As New purret_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem1.Click
        Dim frmname As New in_exp_rpt
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub BankReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankReportsToolStripMenuItem.Click
        Dim frmname As New BankReport
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub DailyTransactionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyTransactionsToolStripMenuItem1.Click
        Dim frmname As New DailyBook
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub SupplierPaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierPaymentReportToolStripMenuItem.Click
        Dim frmname As New supPayment_Rep
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub CustomerPaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerPaymentReportToolStripMenuItem.Click
        Dim frmname As New CustPayment_rep
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        Dim frmname As New changepassword
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub EMPLOYEELOGINREGISTERATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEELOGINREGISTERATIONToolStripMenuItem.Click
        Dim frmname As New Employee_User
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub QUOTATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUOTATIONToolStripMenuItem.Click
        Dim frmname As New quotation_report
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub TRADINGPLAcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRADINGPLAcToolStripMenuItem.Click
        Dim frmname As New Trading_Account
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub BALANCESHEETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BALANCESHEETToolStripMenuItem.Click
        Dim frmname As New Balance_Sheet
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub BankCreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankCreationToolStripMenuItem.Click
        Dim frmname As New AccountCreation1
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Dim frmname As New AssetForm
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub SalaryDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryDetailsToolStripMenuItem.Click
        Dim frmname As New Salary_Details
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub DepositToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositToolStripMenuItem.Click
        Dim frmname As New depositt
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub WithdrawToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawToolStripMenuItem.Click
        Dim frmname As New WithDraw2
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub OdLoanPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdLoanPaymentToolStripMenuItem.Click
        Dim frmname As New payment
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ODLoanReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ODLoanReceiptToolStripMenuItem.Click
        Dim frmname As New BankLoan
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Dim frmname As New ADDCONTACT
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Dim frmname As New TEMPLATE
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub GroupSMSNAGARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupSMSNAGARToolStripMenuItem.Click
        Dim frmname As New GROUPSMS_NAGRPERSONS
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub QuickSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickSMSToolStripMenuItem.Click
        Dim frmname As New QuickSMS
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub SentSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SentSMSToolStripMenuItem.Click
        Dim frmname As New TODAYREPORT1
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub DailyCommitmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCommitmentToolStripMenuItem.Click
        Dim frmname As New dailycommitment
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub DailyCommitmentRepotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCommitmentRepotToolStripMenuItem.Click
        Dim frmname As New dailycommitmentreport
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Dim fname As New unitcreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()

    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Dim frmname As New materialname
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Dim frmname As New brandname
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        Dim frmname As New ProductRegister
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Dim fname As New suppliercreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        Dim frmname As New clientcreation
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        Dim frmname As New AccountCreation1
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Dim frmname As New ADDCONTACT
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        Dim frmname As New TEMPLATE
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        Dim frmname As New purchase("")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        Dim fname As New purchase_return("", "", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()
    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
        Dim frmname As New Sales_Voucher("")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        Dim fname As New Sales_Return("", "", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        fname.MdiParent = Me
        fname.Show()
    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        Dim frmname As New Purchase_payment("", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        Dim frmname As New sales_payment("")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        Dim frmname As New Income_Expense("", "", "", "", "", "", "")
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        Dim frmname As New payment
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        Dim frmname As New depositt
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        Dim frmname As New BankLoan
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        Dim frmname As New WithDraw2
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem39.Click
        Dim frmname As New dailycommitment
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem41.Click
        Dim frmname As New Stock_Ledger
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        Dim frmname As New purchase_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        Dim frmname As New sales_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem45.Click
        Dim frmname As New purret_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        Dim frmname As New salret_reports
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem50.Click
        Dim frmname As New in_exp_rpt
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem51.Click
        Dim frmname As New DailyBook
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem52.Click
        Dim frmname As New BankReport
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        Dim frmname As New dailycommitmentreport
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem62.Click
        Dim frmname As New QuickSMS
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem63.Click
        Dim frmname As New GROUPSMS_NAGRPERSONS
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem64.Click
        Dim frmname As New TODAYREPORT1
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem65.Click
        Dim frmname As New quotation_report
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        Dim frmname As New supPayment_Rep
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem49.Click
        Dim frmname As New CustPayment_rep
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub OrderRemindersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderRemindersToolStripMenuItem.Click
        Dim frmname As New dailyorder
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub DailyOrdersReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyOrdersReportToolStripMenuItem.Click
        Dim frmname As New order_rpt
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub

    Private Sub ToolStripMenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem66.Click
        Dim frmname As New ledger
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        frmname.MdiParent = Me
        frmname.Show()
    End Sub
End Class
