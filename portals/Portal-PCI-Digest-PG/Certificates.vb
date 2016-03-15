Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates

Public Class Certificates

    Shared Function ValidateRemoteCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal policyErrors As SslPolicyErrors) As Boolean
        '//Return True to force the certificate to be accepted.      
        '//Needed so that calling web services with self-signed certs will work.
        Return False
    End Function
End Class
