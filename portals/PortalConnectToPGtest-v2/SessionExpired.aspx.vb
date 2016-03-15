Imports System
Imports System.Web.UI
Partial Public Class SessionExpired
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Session.Abandon()


    End Sub


End Class