﻿Imports System.Security.Cryptography.X509Certificates

Public Class RemotePost
    Private Inputs As System.Collections.Specialized.NameValueCollection = New System.Collections.Specialized.NameValueCollection

    Public Url As String = ""
    Public Method As String = "post"
    Public FormName As String = "form1"
    Public Sub Add(ByVal name As String, ByVal value As String)
        Inputs.Add(name, value)
    End Sub
    Public Sub Post()

        Dim path As String = PathCertificate


        System.Web.HttpContext.Current.Response.Write("<html><head>")
        System.Web.HttpContext.Current.Response.Write(String.Format("</head><body onload=""document.{0}.submit()"">", FormName))
        System.Web.HttpContext.Current.Response.Write(String.Format("<form name=""{0}"" method=""{1}"" action=""{2}"" >", FormName, Method, Url))
        Dim i As Integer = 0
        Do While i < Inputs.Keys.Count
            System.Web.HttpContext.Current.Response.Write(String.Format("<input name=""{0}"" type=""hidden"" value=""{1}"">", Inputs.Keys(i), Inputs(Inputs.Keys(i))))
            i += 1
        Loop
        System.Web.HttpContext.Current.Response.Write("</form>")
        System.Web.HttpContext.Current.Response.Write("</body></html>")


        System.Web.HttpContext.Current.Response.End()

      

    End Sub
    Public Sub post2()

    End Sub
End Class




