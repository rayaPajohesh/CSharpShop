Public Partial Class PortalHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
        End If
    End Sub
    Private Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick



        Dim URL As String
        Dim queryString As String
        Dim urlFundtranfer As String
        Dim urlNavigate As String
        Select Case e.Item.ImageUrl
            Case "Image/Menu/kharide interneT.jpg"
                Response.Redirect(PortalUrl + "ShopHome.aspx")
                'Case "Image/Menu/Nteghal.JPG"
                '    URL =  PortalUrl + "PortalHome.aspx"
                '    queryString = "fundTransfer=true" & "&" & "URL=" & URL
                '    urlFundtranfer = "http://aroohi:8989/SGP/"
                '    urlNavigate = urlFundtranfer & "?" & queryString
                '    Response.Redirect(urlNavigate)
        End Select



    End Sub



    
End Class


