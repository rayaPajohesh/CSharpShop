Public Partial Class ShopMaster
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Text

            Case "   پرفروشترين ها"
                Me.Context.Response.Redirect(PortalUrl + "ShopHome.aspx")
            Case "   پوشاك"
                Me.Context.Response.Redirect(PortalUrl + "Pooshak.aspx")
            Case "   مواد غذائي"
                Me.Context.Response.Redirect(PortalUrl + "Foods.aspx")

            Case "    ميوه جات "
                Me.Context.Response.Redirect(PortalUrl + "Fruitage.aspx")

            Case "   لبنيات"
                Me.Context.Response.Redirect(PortalUrl + "Dairy.aspx")

            Case "   لوازم خانگي"
                Me.Context.Response.Redirect(PortalUrl + "homeDevice.aspx")
            Case "    كتاب "
                Me.Context.Response.Redirect(PortalUrl + "books.aspx")




        End Select
    End Sub
 



    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class