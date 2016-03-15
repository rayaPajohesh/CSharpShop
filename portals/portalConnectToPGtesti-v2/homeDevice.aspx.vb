Partial Public Class homeDevice
    Inherits System.Web.UI.Page

    Protected Sub ImageButton32_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton32.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("homeDevice") = "51,ماكروفر,5000000," + PortalUrl + "homeDevice.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton38_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton38.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("homeDevice") = "52,ماشين ظرفشويي,4000000," + PortalUrl + "homeDevice.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub



    Protected Sub ImageButton35_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton35.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If

        Session("homeDevice") = "54,ماشين لباسشويي,4000000," + PortalUrl + "homeDevice.aspx"
        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton34_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton34.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("homeDevice") = "56,توستر,600000," + PortalUrl + "homeDevice.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton33_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton33.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("homeDevice") = "55,اتو,500000," + PortalUrl + "homeDevice.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub


    Protected Sub ImageButton52_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton52.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("homeDevice") = "53,ظروف تفال,800000," + PortalUrl + "homeDevice.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
End Class