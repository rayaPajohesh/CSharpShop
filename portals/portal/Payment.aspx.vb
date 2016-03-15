Public Partial Class Payment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Page.Response.BufferOutput = True
        'Page.Response.Clear()
        'Page.Response.ClearContent()
        'Page.Response.ClearHeaders()
        'Page.Response.Write(strResponseData)

    End Sub

    Private Sub Payment_PreLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreLoad

    End Sub

    Private Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        Me.Form.InnerHtml = strResponseData
    End Sub
End Class