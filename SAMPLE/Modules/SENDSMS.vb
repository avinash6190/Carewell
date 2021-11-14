Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System
Imports System.Net
Imports System.Text
Imports System.Data.SqlClient
Module SENDSMS
    Public Function SendSMS1(ByVal User As String, ByVal password As String, ByVal Mobile_Number As String, ByVal Message As String, ByVal sid As String, Optional ByVal MType As String = "N") As String
        Dim stringpost As String = "User=" & User & "&passwd=" & password & "&mobilenumber=" & Mobile_Number & "&message=" & Message & "&sid=" & sid & "&MTYPE=" & MType
        'Response.Write(stringpost)
        Dim functionReturnValue As String = Nothing
        functionReturnValue = ""

        Dim objWebRequest As HttpWebRequest = Nothing
        Dim objWebResponse As HttpWebResponse = Nothing
        Dim objStreamWriter As StreamWriter = Nothing
        Dim objStreamReader As StreamReader = Nothing

        Try
            Dim stringResult As String = Nothing

            objWebRequest = DirectCast(WebRequest.Create("http://sms.dial4sms.in/WebServiceSMS.aspx"), HttpWebRequest)
            'domain name: Domain name Replace With Your Domain  
            objWebRequest.Method = "POST"

            ' Response.Write(objWebRequest)

            ' Use below code if you want to SETUP PROXY. 
            'Parameters to pass: 1. ProxyAddress 2. Port 
            'You can find both the parameters in Connection settings of your internet explorer.

            ' If you are in the proxy then Uncomment below lines and enter IP and Port.
            ' Dim myProxy As New Net.WebProxy("192.168.1.108", 6666)
            'myProxy.BypassProxyOnLocal = True
            'objWebRequest.Proxy = myProxy

            objWebRequest.ContentType = "application/x-www-form-urlencoded"

            objStreamWriter = New StreamWriter(objWebRequest.GetRequestStream())
            objStreamWriter.Write(stringpost)
            objStreamWriter.Flush()
            objStreamWriter.Close()

            objWebResponse = DirectCast(objWebRequest.GetResponse(), HttpWebResponse)
            objWebResponse = DirectCast(objWebRequest.GetResponse(), HttpWebResponse)
            objStreamReader = New StreamReader(objWebResponse.GetResponseStream())
            stringResult = objStreamReader.ReadToEnd()
            objStreamReader.Close()
            Return (stringResult)
        Catch ex As Exception
            Return (ex.ToString)
        Finally
            If (objStreamWriter IsNot Nothing) Then
                objStreamWriter.Close()
            End If
            If (objStreamReader IsNot Nothing) Then
                objStreamReader.Close()
            End If
            objWebRequest = Nothing
            objWebResponse = Nothing

        End Try
    End Function
    Function SP_TEMP(ByVal Tname As String, ByVal olDTname As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec SP_TEMP '" & Tname & "','" & olDTname & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
    Function SP_SMS(ByVal message As String, ByVal date1 As String, ByVal opt As String)
        Try
            ds = New DataSet
            cmd = New SqlCommand("exec SP_SMS '" & message & "','" & date1 & "','" & opt & "'", con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, suss)
        End Try
    End Function
End Module
