Imports System.Data.SqlClient
Module connection
    Public con As SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public err As String = "CAREWELL"
    Public suss As String = "CAREWELL"
    Public ds As New DataSet
    Public Function TrapKeysinglequote(ByVal KCode As String) As Boolean
        ' e.Handled = TrapKey1(Asc(e.KeyChar))
        '    If (KCode >= 48 And KCode <= 57) Or (KCode >= 46 And KCode <= 46) Or KCode = 8 Then
        If (KCode = 91 Or KCode = 92 Or KCode = 93 Or KCode = 94 Or KCode = 39) Then
            TrapKeysinglequote = True
            '        TrapKey = False

        Else
            TrapKeysinglequote = False
            '        TrapKey = True

        End If
    End Function
    Function connect()
        Dim fileText As String = My.Computer.FileSystem.ReadAllText("C:\WINDOWS\carewell.txt")
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & fileText & "\carewell.mdf;integrated security=true;Connect Timeout=30;User Instance=True")
        'con = New SqlConnection("Data Source=client5;AttachDbFilename=carewell;Integrated Security=True;Connect Timeout=30;User Instance=True")
        'con = New SqlConnection("Data source=welcome;Initial catalog=carewell;Integrated security=false;User ID=sa;Password=admina")
        'con = New SqlConnection("Data source=client5;Initial catalog=D:\DATA\CAREWELL.MDF;Integrated security=true;")
        con.Open()
        Return 1
    End Function
    Public Function TrapKey1(ByVal KCode As String) As Boolean
        If (KCode = 39) Then
            TrapKey1 = True
        Else
            TrapKey1 = False
        End If
    End Function
End Module


