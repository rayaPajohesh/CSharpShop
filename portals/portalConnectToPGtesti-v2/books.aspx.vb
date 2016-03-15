Partial Public Class books
    Inherits System.Web.UI.Page





    Protected Sub ImageButton26_Click1(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton26.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "42,هويت شهر,15000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton27_Click1(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton27.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If

        Session("books") = "40,حكايت دولت و فرزانگي,5000," + PortalUrl + "books.aspx"
        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton21_Click1(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton21.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "44,الغدير,12000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton23_Click1(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton23.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "45,پرواز با پاراگلايدر,18000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub


    Protected Sub ImageButton24_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton24.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "48,طرح كسب و كار,18000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton60_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton60.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "49,پرچمهاي سبز ,5000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton40_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton40.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "46,موسم آشفتگي,40000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub

    Protected Sub ImageButton25_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton25.Click
        If sessionId Is Nothing Then
            sessionId = Session.SessionID
        Else
            Session.RemoveAll()
        End If
        Session("books") = "41,بادبادك باز,20000," + PortalUrl + "books.aspx"

        Response.Redirect(PortalUrl + "ShopPurchase.aspx")
    End Sub
End Class