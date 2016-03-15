Imports System.Security.Cryptography.X509Certificates
Imports System.Net

Partial Public Class MessageForm
    Inherits BasePage


    Private Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim purchaseAmount As String
        Dim merchantAmount As String
        'Dim partialAmount As String
        'Dim statusReverse As String
        Dim RRN As String
        ' Dim RN As String
        Dim Stan As String
        Dim status As String
        Dim RN As String
        Dim credCache As CredentialCache = New CredentialCache()
        Dim netCred As NetworkCredential = New NetworkCredential(userId, passWD)

        Me.TextBox1.Visible = True
        Dim tryConnect As Integer


        Try

            If Request.RequestType = "POST" Then

                status = Request.Params.Item("merchantResponseCode")
                RRN = Request.Form.Item("rrn")
                Stan = Request.Form.Item("stan")
                purchaseAmount = Request.Form.Item("amount")
                RN = Request.Form.Item("reservationNum")

                lblMessage.Text = RRN

                

                Dim result As String
                Dim data() As String
                Dim purchaseRRN As String
                Dim purchaseStan As String

                Dim merchantResponseCode As String

                merchantAmount = Session("merchantAmount")

                'Dim cert As System.Security.Cryptography.X509Certificates.X509Certificate
                Dim path As String = PathCertificate
                Dim pass As String = PasswordCertificate
                'Dim Cert1 As System.Security.Cryptography.X509Certificates.X509Certificate
                'If pass <> "" Then
                '    Cert1 = New System.Security.Cryptography.X509Certificates.X509Certificate2(path, pass)
                'Else
                '    Cert1 = System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(path)
                'End If

                'ref.ClientCertificates.Add(Cert1)


                ' ref.UseDefaultCredentials = False




                ''ref.Credentials = New System.Net.NetworkCredential(WSUser, WSPwd)
                'Dim store As X509Store = New X509Store(System.Security.Cryptography.X509Certificates.StoreName.TrustedPeople, StoreLocation.LocalMachine)
                'store.Open(OpenFlags.OpenExistingOnly)

                'Dim col As X509CertificateCollection = store.Certificates.Find(X509FindType.FindBySerialNumber, "2", False)
                'Dim cert1 As X509Certificate = col(0)


                'ref.ClientCertificates.Add(Cert1)


                If RN <> "" And status = "00" Then

                    
                    ref = New Portal.WebReference.SpringWSEndPointService

                    
                    credCache.Add(New Uri(ref.Url), "Digest", netCred)
                    ref.Credentials = credCache
                   
retry:
                    result = ref.paymentGatewayVerificationRequest(RRN, Stan, RN, userName, password, url)

                    data = result.Split(";")
                    purchaseAmount = data(0)
                    merchantResponseCode = data(1)

                    If purchaseAmount.Equals(Session("merchantAmount")) Then


                        If merchantResponseCode = "00" Then
                            lblMessage.Text = error_00
                            lblHelp.Text = HELP
                            Me.TextBox1.Text = RN
                            Me.TextBox2.Text = Stan
                            Me.TextBox3.Text = RRN
                            Me.TextBox4.Text = purchaseAmount

                        ElseIf merchantResponseCode = "01" Then
                            lblMessage.Text = error_01
                        ElseIf merchantResponseCode = "02" Then
                            lblMessage.Text = error_02
                        ElseIf merchantResponseCode = "03" Then
                            lblMessage.Text = error_03
                        ElseIf merchantResponseCode = "04" Then
                            lblMessage.Text = error_04
                        ElseIf merchantResponseCode = "05" Then
                            lblMessage.Text = error_05
                        ElseIf merchantResponseCode = "06" Then
                            lblMessage.Text = error_06
                        ElseIf merchantResponseCode = "07" Then
                            lblMessage.Text = error_07
                        ElseIf merchantResponseCode = "08" Then
                            lblMessage.Text = error_08
                        ElseIf merchantResponseCode = "09" Then
                            lblMessage.Text = error_09
                        ElseIf merchantResponseCode = "10" Then
                            lblMessage.Text = error_10
                        ElseIf merchantResponseCode = "11" Then
                            lblMessage.Text = error_11
                        ElseIf merchantResponseCode = "12" Then
                            lblMessage.Text = error_12
                        ElseIf merchantResponseCode = "13" Then
                            lblMessage.Text = error_13
                        ElseIf merchantResponseCode = "14" Then
                            lblMessage.Text = error_14
                        ElseIf merchantResponseCode = "15" Then
                            lblMessage.Text = error_15
                        End If



                    Else
                        Dim responseVoid As String
                        ref = New Portal.WebReference.SpringWSEndPointService
                        
                        credCache.Add(New Uri(ref.Url), "Digest", netCred)
                        ref.Credentials = credCache
                        responseVoid = ref.paymentGatewayVoidRequest(RRN, RN, Session("userName"), Session("password"), Session("url"), purchaseAmount)


                        If responseVoid = "07" Then
                            lblMessage.Text = error_07
                        ElseIf responseVoid = "09" Then
                            lblMessage.Text = error_09
                        ElseIf responseVoid = "01" Then
                            lblMessage.Text = error_01
                        End If

                    End If
                Else
                    'cancel 
                    If status <> Nothing Then
                        lblMessage.Text = error_12

                    End If
                End If

            ElseIf Request.RequestType = "GET" Then
                status = Session("merchantResponseCode")
                If status = "00" Then
                    lblMessage.Text = error_14
                    lblHelp.Text = HELP
                    Me.TextBox1.Visible = False
                    Me.lblRN.Visible = False
                    Me.TextBox2.Text = Session("reconciliationStan")
                    Me.TextBox3.Text = Session("reconciliationRRN")
                    Me.TextBox4.Text = Session("reconciliationAmount")
                ElseIf status = "01" Then
                    lblMessage.Text = error_01
                ElseIf status = "02" Then
                    lblMessage.Text = error_02
                ElseIf status = "03" Then
                    lblMessage.Text = error_03
                ElseIf status = "04" Then
                    lblMessage.Text = error_04
                ElseIf status = "05" Then
                    lblMessage.Text = error_05
                ElseIf status = "06" Then
                    lblMessage.Text = error_06
                ElseIf status = "07" Then
                    lblMessage.Text = error_07
                ElseIf status = "08" Then
                    lblMessage.Text = error_08
                ElseIf status = "09" Then
                    lblMessage.Text = error_09
                ElseIf status = "10" Then
                    lblMessage.Text = error_10
                ElseIf status = "11" Then
                    lblMessage.Text = error_11
                ElseIf status = "12" Then
                    lblMessage.Text = error_12
                ElseIf status = "13" Then
                    lblMessage.Text = error_13
                ElseIf status = "14" Then
                    lblMessage.Text = error_14
                ElseIf status = "15" Then
                    lblMessage.Text = error_15
                End If
            End If



        Catch ex As Exception
            tryConnect = tryConnect + 1
            If tryConnect < 4 Then
                GoTo retry
            End If


            lblMessage.Text = error_15

        End Try
        Session("merchantResponseCode") = ""
    End Sub

 
    Private Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete

    End Sub



    Private Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

    End Sub

    Public Sub New()

    End Sub
End Class