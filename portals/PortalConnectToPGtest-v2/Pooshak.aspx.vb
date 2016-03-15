Public Partial Class Pooshak
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub PooshakImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton1.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "1,پيراهن,160000," + PortalUrl + "Pooshak.aspx"

        Me.Context.Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton2.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "2,پيراهن,180000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton3.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "3,پيراهن,160000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton4.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "4,كفش زنانه,160000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton5_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton5.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "5,كتاني,160000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton6_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton6.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "6,كفش مردانه,160000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton7_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton7.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "7,كيف زنانه,160000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton8_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton8.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "8,سامسونت,1500000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub PooshakImageButton9_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PooshakImageButton9.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Pooshak") = "9,كيف زنانه,160000," + PortalUrl + "Pooshak.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub
End Class