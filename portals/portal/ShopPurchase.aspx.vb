Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Web
Imports System.Security.Cryptography.X509Certificates



Partial Public Class ShopPurchase
    Inherits BasePage

    Private dvKala As New DataView
    Private sUserId As String
    Public SortExpression As String
    Shared currentKalaCode As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            BindKalaGrid()
        End If
        Me.btnSave.Enabled = False
    End Sub

    Private Sub grdKala_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdKala.DataBinding

    End Sub


    Private Sub grdProducts_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdKala.ItemCommand
        If e.Item.ItemType = ListItemType.Pager Or _
            e.Item.ItemType = ListItemType.Header Then Exit Sub
        Dim btn As Button = CType(e.CommandSource, Button)
        If btn.Text = "تغيير" Then
            txtKalaCode.Text = e.Item.Cells(3).Text
            txtKalaName.Text = e.Item.Cells(2).Text
            txtNoKala.Text = e.Item.Cells(1).Text
            txtKalaPrice.Text = e.Item.Cells(0).Text
            txtNoKala.Focus()
            Me.btnSave.Enabled = True


        Else
            DeleteItem(grdKala.DataKeys(e.Item.ItemIndex).ToString)
            If dvKala.Count = 0 Then
                Me.btnSave.Enabled = False
            End If
        End If
        btnSave.CommandArgument = ""
    End Sub
    Private Sub DeleteItem(ByVal strKalaCode As String)
        Dim strSQL As String = _
            "DELETE " & vbCrLf & _
            "FROM KALA " & _
            "WHERE Kala_Code = " & strKalaCode

        Dim scnnNW As New SqlConnection(SQL_CONNECTION_STRING)
        Dim scmd As New SqlCommand(strSQL, scnnNW)
        Try
            scnnNW.Open()
            scmd.ExecuteNonQuery()

            Cache.Remove("dvKala")
            grdKala.CurrentPageIndex = 0
            BindKalaGrid()
            txtKalaCode.Text = ""
            txtKalaName.Text = ""
            txtNoKala.Text = ""
            txtKalaPrice.Text = ""
            'currentKalaCode = 0
        Catch exp As Exception
            MsgBox("خطا هنگام حذف")
        Finally
            scnnNW.Close()
        End Try
    End Sub
    Private Sub BindKalaGrid()



        GetDataSource()

        With grdKala
            .DataSource = dvKala
            .DataBind()
        End With

        CalculateTotalPrice()
    End Sub
    Private Sub GetDataSource()

        If Not IsNothing(Cache("dvKala")) Then
            dvKala = CType(Cache("dvKala"), DataView)
        Else
            dvKala = CreateDataSet().Tables(0).DefaultView
            Cache("dvKala") = dvKala
        End If
        If SortExpression = "" Then
            SortExpression = "Kala_Code"
        End If
        dvKala.Sort = SortExpression

    End Sub
    Private Function CreateDataSet() As DataSet

        Dim strSQL As String = _
            "SELECT *  " & _
            "FROM KALA " & _
            "Where User_Id='" & sessionId & "'"

        Dim scnnNW As New SqlConnection(SQL_CONNECTION_STRING)

        Dim scmd As New SqlCommand(strSQL, scnnNW)


        Dim sda As New SqlDataAdapter(scmd)

        Dim ds As New DataSet()
        sda.Fill(ds)
        Return ds
    End Function

    Protected Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If IsValid Then
            SaveItem()
        End If

    End Sub
    Private Sub SaveItem()
        Dim strSQL As String

        If txtNoKala.Text = "" Then
            Exit Sub
        End If
        strSQL = _
            "UPDATE Kala " & _
            "SET No_Kala = @NoKala , " & _
            "Kala_Price = @KalaPrice " & _
            "WHERE Kala_Code = @KalaCode"

        Dim scnnNW As New SqlConnection(SQL_CONNECTION_STRING)
        Dim scmd As New SqlCommand(strSQL, scnnNW)

        With scmd.Parameters

            .Add(New SqlParameter("@NoKala", _
                SqlDbType.Int, 4, ParameterDirection.Input, False, 0, 4, "No_Kala", DataRowVersion.Current, CInt(txtNoKala.Text.ToString)))
            .Add(New SqlParameter("@KalaCode", _
                SqlDbType.Int, 4, ParameterDirection.Input, False, 0, 4, "Kala_Code", DataRowVersion.Current, CInt(txtKalaCode.Text.ToString)))
            .Add(New SqlParameter("@KalaPrice", _
                SqlDbType.Int, 4, ParameterDirection.Input, False, 0, 4, "Kala_Price", DataRowVersion.Current, CInt(txtKalaPrice.Text.ToString) * CInt(txtNoKala.Text.ToString)))

        End With

        Try
            scnnNW.Open()
            scmd.ExecuteNonQuery()

            Cache.Remove("dvKala")
            BindKalaGrid()
            Me.btnSave.Enabled = True
            Me.txtNoKala.Focus()
        Catch exp As Exception
            MsgBox("خطا در ثبت تغييرات")
        Finally
            scnnNW.Close()
        End Try
    End Sub

    Private Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        If Not sessionId Is Nothing Then
            Kala = Split(CType(Session.Item(0), String), ",")
            If Not Page.IsPostBack Then
                If currentKalaCode <> Kala(0) Then
                    InsertKala()
                End If
            End If
        End If

    End Sub

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

    End Sub
    Private Sub InsertKala()
        Dim strSQL As String

        strSQL = _
            "Insert Into Kala " & _
            "(User_Id,Kala_Code,Kala_Name,No_Kala,Kala_Price) " & _
            "Values( '" & sessionId & "'," & _
                Kala(0) & ",'" & _
                Kala(1) & "'," & _
                "1" & "," & _
                Kala(2) & ")"
        currentKalaCode = Kala(0)

        Dim scnnNW As New SqlConnection(SQL_CONNECTION_STRING)
        Dim scmd As New SqlCommand(strSQL, scnnNW)
        Try
            scnnNW.Open()
            scmd.ExecuteNonQuery()
            Cache.Remove("dvKala")
            BindKalaGrid()
        Catch exp As Exception
            MsgBox("خطا درج كالا")
        Finally
            scnnNW.Close()
        End Try
    End Sub

    Protected Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        sessionId = Nothing
        Dim src As String = Kala(3).ToString
        Me.Context.Response.Redirect(src)
    End Sub

    Private Sub grdKala_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdKala.PageIndexChanged
        grdKala.CurrentPageIndex = e.NewPageIndex
        BindKalaGrid()
    End Sub

    Private Sub grdKala_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdKala.SortCommand
        SortExpression = e.SortExpression.ToString()
        BindKalaGrid()
    End Sub
    Private Sub CalculateTotalPrice()
        Dim TotalPrice As Long
        Dim drv As DataRowView
        For Each drv In dvKala
            TotalPrice = CInt(drv(4).ToString) + TotalPrice
        Next
        Me.lblTotalPrice.Text = "قيمت كل :" & TotalPrice

    End Sub

    Protected Sub grdKala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdKala.SelectedIndexChanged

    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Dim urlNavigate As String
        Dim urlPG As String
        Dim queryString As String
        Dim urlPostBack As String
        Dim reservationNum As String
        Dim tmp() As String
        Dim purchaseAmount As String

        Dim result As String = ""

        merchantId = 1
        tmp = Split(lblTotalPrice.Text, ":")
        purchaseAmount = tmp(1).ToString()

        Dim Now As DateTime = DateTime.Now
        reservationNum = Now.ToString("yyMMddhhmmss")
        Try
            ref = New Portal.com.sarmayebank.pgtest.SpringWSEndPointService




            'ref.UseDefaultCredentials = False

            Dim credCache As CredentialCache = New CredentialCache()
            Dim netCred As NetworkCredential = New NetworkCredential(userId, passWD)
            credCache.Add(New Uri(ref.Url), "Digest", netCred)
            ref.Credentials = credCache

            result = ref.paymentGatewayMerchantAuthentication(reservationNum, userName, password, url, purchaseAmount.ToString())

            Session("userName") = userName
        Catch ex As Exception

            Session("merchantResponseCode") = "15"
            Response.Redirect(PortalUrl + "MessageForm.aspx")
        End Try





        Dim data() As String = result.Split(";")
        If (data.Length > 1 And data(1) = "00") Then
            If (data(0)) Then

                Session("PGUrl") = PGUrl
                Session("reservationNum") = reservationNum
                Session("merchantAmount") = purchaseAmount.ToString()
                
                Session("pac") = data(0)
                pac = data(0)
                callBackUrl = PortalUrl + "MessageForm.aspx"
                Session("callbackUrl") = PortalUrl + "MessageForm.aspx"
                Response.Redirect("testpost.aspx")



            Else
                Session("merchantResponseCode") = data(1)
                Response.Redirect(PortalUrl + "MessageForm.aspx")

            End If
        Else
            Session("merchantResponseCode") = data(1)
            Response.Redirect(PortalUrl + "MessageForm.aspx")
        End If








    End Sub

    Protected Sub Reconciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reconciliation.Click
        Dim reconciliationRRN As String
        Dim reconciliationStan As String
        Dim reconciliationAmount As String

        Dim merchantResponseCode As String
        Dim data() As String
        Try
            ref = New Portal.com.sarmayebank.pgtest.SpringWSEndPointService
            Dim credCache As CredentialCache = New CredentialCache()
            Dim netCred As NetworkCredential = New NetworkCredential(userId, passWD)
            credCache.Add(New Uri(ref.Url), "Digest", netCred)
            ref.Credentials = credCache

            Dim result As String = ref.paymentGatewayReconciliationRequest(userName, password, url)
            data = result.Split(";")
            reconciliationRRN = data(0)
            reconciliationStan = data(1)
            reconciliationAmount = data(2)
            merchantResponseCode = data(3)

            Session("reconciliationRRN") = reconciliationRRN
            Session("reconciliationStan") = reconciliationStan
            Session("reconciliationAmount") = reconciliationAmount
            Session("merchantResponseCode") = merchantResponseCode
            
        Catch ex As Exception
            Session("merchantResponseCode") = "15"

        Finally
            Response.Redirect(PortalUrl + "MessageForm.aspx")
        End Try
    End Sub
End Class