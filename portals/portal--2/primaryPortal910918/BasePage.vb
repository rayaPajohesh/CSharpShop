Imports System.Web.SessionState
Public Class BasePage
    Inherits System.Web.UI.Page


    Protected Overrides Sub OnInit(ByVal e As System.EventArgs)
        MyBase.OnInit(e)

        If Not Context.Session Is Nothing Then
            If Session.IsNewSession Then
                Dim strCookieHeader As String = Request.Headers("Cookie")
                If Not strCookieHeader Is Nothing Then
                    If strCookieHeader.IndexOf("ASP.NET_SessionId") >= 0 Then
                        sessionId = Guid.NewGuid().ToString()
                        If Response.Cookies("ASP.NET_SessionId").Value = "" Then
                            Dim myCookie As HttpCookie = New HttpCookie("ASP.NET_SessionId")
                            myCookie.Value = "TimeOut"
                            Response.Cookies.Add(myCookie)
                            Response.Redirect(PortalUrl + "SessionExpired.aspx")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class
