Public Partial Class ShopHome
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
        End If
    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "150,بستني رژيمي,10000," + PortalUrl + "ShopHome.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "151,شيركاكائو,15000," + PortalUrl + "ShopHome.aspx"


        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "152,كشك,7000," + PortalUrl + "ShopHome.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "153,كفش زنانه,250000," + PortalUrl + "ShopHome.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton5_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "154,كيف زنانه,180000," + PortalUrl + "ShopHome.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton6_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "155,كتاني,800000," + PortalUrl + "ShopHome.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton7_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If

        Session("Home") = "156,انگور,15000," + PortalUrl + "ShopHome.aspx"
        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton8_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "157,سيب,12000," + PortalUrl + "ShopHome.aspx"


        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
    Protected Sub ImageButton9_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("Home") = "158,تخم مرغ,16000," + PortalUrl + "ShopHome.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")

    End Sub

    Private Sub ShopHome_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

    End Sub
End Class