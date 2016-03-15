Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Public Class MyWebClient
    Inherits System.Net.WebClient
    Private _ClientCertificates As New System.Security.Cryptography.X509Certificates.X509CertificateCollection

    Protected Overrides Function GetWebRequest(ByVal address As System.Uri) As System.Net.WebRequest
        Dim R = MyBase.GetWebRequest(address)
        If TypeOf R Is HttpWebRequest Then
            Dim WR = DirectCast(R, HttpWebRequest)
            If Me.ClientCertificates.Count > 0 And Me.ClientCertificates IsNot Nothing Then
                WR.ClientCertificates.AddRange(Me._ClientCertificates)
            End If
        End If

        Return R
    End Function
    Public ReadOnly Property ClientCertificates() As System.Security.Cryptography.X509Certificates.X509CertificateCollection
        Get
            Dim store As System.Security.Cryptography.X509Certificates.X509Store = New X509Store(System.Security.Cryptography.X509Certificates.StoreName.TrustedPeople, StoreLocation.LocalMachine)
            store.Open(OpenFlags.OpenExistingOnly)

            Dim col As X509CertificateCollection = store.Certificates.Find(X509FindType.FindBySerialNumber, "2", False)
            _ClientCertificates = col
            Return Me._ClientCertificates
        End Get
    End Property

End Class
