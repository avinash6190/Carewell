Imports System
Imports System.Data.SqlClient
Public Class Printer
    Private Sub Printer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RichTextBox1.Text = ""
            Dim dt As New DataTable
            Datagridview1.DataSource = dt
            'Dim scope As New ManagementScope("\root\cimv2")
            'scope.Connect()
            '' Select Printers from WMI Object Collections
            'Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Printer")
            'Dim printerName As String = ""
            'For Each printer As ManagementObject In searcher.[Get]()
            '    printerName = printer("Name").ToString().ToLower()
            '    If printerName.Equals("hp deskjet 930c") Then
            '        MsgBox("Printer = " + printer("Name"))
            '        If printer("WorkOffline").ToString().ToLower().Equals("true") Then
            '' printer is offline by user
            '            MsgBox("Your Plug-N-Play printer is not connected.")
            '        Else
            '' printer is not offline
            '            MsgBox("Your Plug-N-Play printer is connected.")
            '        End If
            '    End If
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim s As String
            s = Trim(RichTextBox1.Text)
            Dim dt As New DataSet
            dt = SQL(s)
            If dt.Tables.Count <> 0 Then
                If dt.Tables(0).Rows.Count <> 0 Then
                    Datagridview1.DataSource = dt.Tables(0)
                Else
                    Dim dt1 As New DataTable
                    Datagridview1.DataSource = dt1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Sub
End Class