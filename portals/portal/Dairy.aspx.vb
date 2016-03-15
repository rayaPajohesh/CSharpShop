Partial Public Class Dairy
    Inherits System.Web.UI.Page


    Protected Sub ImageButton8_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "13,پنير,12000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")




    End Sub
    Protected Sub ImageButton9_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "14,بستني,15000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub



    Protected Sub ImageButton20_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton20.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "15,بستني رژيمي,20000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton15_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton15.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "18,ماست,10000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton14_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton14.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "17,شيرخرما,15000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "16,كره,12000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton18_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton18.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "21,كره,8000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton17_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton17.Click

        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If

        Session("Dairy") = "20,كشك,15000," + PortalUrl + "Dairy.aspx"
        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton16_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton16.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Dairy") = "19,شيركاكائو,15000," + PortalUrl + "Dairy.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class