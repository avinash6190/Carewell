Public Class viewalert
    Dim gdt As New DataTable
    Sub cheque()
        gdt.Columns.Add("Sno")
        gdt.Columns.Add("ChequeDate")
        gdt.Columns.Add("ChequeNo")
        gdt.Columns.Add("BankName")
        gdt.Columns.Add("ChequeAmt")
        gdt.Columns.Add("type")
        gdt.Columns.Add("id")
        gdt.Rows.Clear()
        Dim dt1 As New DataTable
        dt1 = Alert_PROC("", Date.Today.ToString("MM/d/yyyy"), "", "showalert-rev")
        gdt.Rows.Clear()
        For i As Integer = 0 To dt1.Rows.Count - 1
            gdt.Rows.Add(dt1.Rows(i)(0), dt1.Rows(i)(1), dt1.Rows(i)(2), dt1.Rows(i)(3), dt1.Rows(i)(4), dt1.Rows(i)(5), dt1.Rows(i)(6))
        Next
        If gdt.Rows.Count = 0 Then
            Itemgrid.Visible = False
        Else
            Itemgrid.DataSource = gdt
            Itemgrid.TableStyles.Clear()
            Itemgrid.Refresh()
            Itemgrid.Visible = True
            Dim ts1 As New DataGridTableStyle()
            ts1.MappingName = Itemgrid.DataMember
            Itemgrid.TableStyles.Add(ts1) 
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("Sno").Width = 50
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("ChequeDate").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("ChequeNo").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("BankName").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("ChequeAmt").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("type").Width = 0
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("id").Width = 0
            Dim cm As CurrencyManager = DirectCast(Me.BindingContext(Itemgrid.DataSource, Itemgrid.DataMember), CurrencyManager)
            DirectCast(cm.List, DataView).AllowNew = False
            cm.Refresh()
        End If

    End Sub
    Sub cheque1()
        Dim dt1 As New DataTable
        dt1 = Alert_PROC("", Date.Today.ToString("MM/d/yyyy"), "", "showalert-rev")
        gdt.Rows.Clear()
        For i As Integer = 0 To dt1.Rows.Count - 1
            gdt.Rows.Add(dt1.Rows(i)(0), dt1.Rows(i)(1), dt1.Rows(i)(2), dt1.Rows(i)(3), dt1.Rows(i)(4), dt1.Rows(i)(5), dt1.Rows(i)(6))
        Next
        If gdt.Rows.Count = 0 Then
            Itemgrid.Visible = False
        Else
            Itemgrid.DataSource = gdt
            Itemgrid.TableStyles.Clear()
            Itemgrid.Refresh()
            Itemgrid.Visible = True
            Dim ts1 As New DataGridTableStyle()
            ts1.MappingName = Itemgrid.DataMember
            Itemgrid.TableStyles.Add(ts1)
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("Sno").Width = 50
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("ChequeDate").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("ChequeNo").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("BankName").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("ChequeAmt").Width = 100
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("type").Width = 0
            Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("id").Width = 0
            Dim cm As CurrencyManager = DirectCast(Me.BindingContext(Itemgrid.DataSource, Itemgrid.DataMember), CurrencyManager)
            DirectCast(cm.List, DataView).AllowNew = False
            cm.Refresh()
        End If

    End Sub

    Private Sub viewalert_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub viewalert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cheque()
        Itemgrid.Focus()
    End Sub

    Private Sub Itemgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Itemgrid.DoubleClick
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = Itemgrid.DataSource
            response = MsgBox("Are you sure for cheque Received.", MsgBoxStyle.YesNo, "message")
            If (response = vbYes) Then
                Dim getdt As New DataTable
                getdt = Itemgrid.DataSource
                i = Itemgrid.CurrentRowIndex

                Dim dat As Date
                Dim a As String
                a = getdt.Rows(i)(1)
                a = a.Substring(3, 2) & "/" & a.Substring(0, 2) & "/" & a.Substring(6, 4)
                dat = CDate(a)
                Alert_PROC(getdt.Rows(i)(5), dat.ToString("MM/d/yyyy"), getdt.Rows(i)(6), "update-rev")
                Dim dt1 As New DataTable
                dt1 = Alert_PROC("", Date.Today.ToString("MM/d/yyyy"), "", "showalert-rev")
                If dt1.Rows.Count = 0 Then
                    Me.Close()
                Else
                    Call cheque1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Itemgrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Itemgrid.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Itemgrid_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Itemgrid.Navigate

    End Sub
End Class