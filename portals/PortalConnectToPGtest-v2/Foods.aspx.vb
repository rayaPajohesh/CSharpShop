Public Partial Class Foods
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "10,تخم مرغ,16000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "11,گوشت,100000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "12,مرغ,23000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "34,ماكاروني,9000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "33,تن ماهي جنوب ,10000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "32,هات داگ,16000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "31,برنج,30000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Food") = "30,تن ماهي شيدان,11000," + PortalUrl + "Foods.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
End Class