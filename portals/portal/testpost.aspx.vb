Public Partial Class testpost
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

    End Sub

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload


    End Sub

    Protected Sub Submit1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit1.ServerClick
        Dim myremotepost As RemotePost = New RemotePost
        myremotepost.Url = PGUrl
        myremotepost.Add("pac", Session("pac"))

        ' myremotepost.Add("callbackUrl", PortalUrl + "MessageForm.aspx")
        myremotepost.Add("callbackUrl", "http://pgtest.sarmayebank.com:3618/MessageForm.aspx")

        myremotepost.Post()
    End Sub
End Class