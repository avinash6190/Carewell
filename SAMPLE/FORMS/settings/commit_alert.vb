Public Class commit_alert
    Dim gdt As New DataTable
    Sub commit()
        Try
            gdt.Columns.Add("Sno")
            gdt.Columns.Add("Date")
            gdt.Columns.Add("Commitment")
            gdt.Columns.Add("Status")
            gdt.Columns.Add("id")
            gdt.Rows.Clear()
            Dim dt1 As New DataTable
            dt1 = commitment("", "", "", "commit_alert", "", "", "")
            gdt.Rows.Clear()
            For i As Integer = 0 To dt1.Rows.Count - 1
                gdt.Rows.Add(dt1.Rows(i)(0), dt1.Rows(i)(1), dt1.Rows(i)(2), dt1.Rows(i)(3), dt1.Rows(i)(4))
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
                Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("Date").Width = 100
                Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("Commitment").Width = 250
                Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("Status").Width = 75
                Itemgrid.TableStyles(Itemgrid.DataMember).GridColumnStyles("id").Width = 0
                Dim cm As CurrencyManager = DirectCast(Me.BindingContext(Itemgrid.DataSource, Itemgrid.DataMember), CurrencyManager)
                DirectCast(cm.List, DataView).AllowNew = False
                cm.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub commit_alert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            commit()
            Itemgrid.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub commit_alert_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Itemgrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Itemgrid.DoubleClick
        Try
            Dim i As Integer
            Dim response As String
            Dim cntdt As New DataTable
            cntdt = Itemgrid.DataSource
            response = MsgBox("Are You Sure To Finish This Commitment.", MsgBoxStyle.YesNo, "message")
            If (response = vbYes) Then
                Dim getdt As New DataTable
                getdt = Itemgrid.DataSource
                i = Itemgrid.CurrentRowIndex
                commitment("", getdt.Rows(i)(4), "", "upd_cmtfinish", "", "", "")
                Dim dt1 As New DataTable
                dt1 = commitment("", "", "", "commit_alert", "", "", "")
                If dt1.Rows.Count = 0 Then
                    Me.Close()
                Else
                    Call commit()
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
End Class