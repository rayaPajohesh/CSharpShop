Imports System.IO

Module modPortal
    Public Kala() As String
    Public frame1 As HtmlControl
    Public merchantId As String
    Public sessionId As String
    'Public RRN As String
    'Public RN As String
    'Public status As String
    'Public purchaseAmount As String
    Public Const merchantPassword = "aaaaaa"
    Public DataSource = System.Configuration.ConfigurationSettings.AppSettings("DataSource")
    Public PathCertificate = System.Configuration.ConfigurationSettings.AppSettings("pathCertificate")
    Public PasswordCertificate = System.Configuration.ConfigurationSettings.AppSettings("passwordCertificate")
    Public strResponseData As String

    Public SQL_CONNECTION_STRING As String = DataSource
    Public Const HELP = "لطفا جهت پيگيري سفارش اين شماره را نزد خود نگهداريد"

    Public Const SITE_NOT_AVAILABLE = "امكان برقراري ارتباط با بانك وجود ندارد"

    Public Const error_00 = "تراكنش با موفقيت انجام شد"
    Public Const error_01 = "خطا در فرمت پارامترهای ارسالي "
    Public Const error_02 = "فروشگاه نا معتبر مي باشد"
    Public Const error_03 = "مدت زمان انجام تراكنش به پايان رسيده است"
    Public Const error_04 = "فروشگاه مجاز نيست"
    Public Const error_05 = "كد سفارش قبلا استفاده شده است "
    Public Const error_06 = "خطاي داخلي در سيستم بانكي "
    Public Const error_07 = " قبلا انجام شده است void تراكنش "
    Public Const error_08 = " وضعيت تراكنش خريد ، وارسي شده نمي باشد"
    Public Const error_09 = "شود برابر نيست void  مبلغ تراكنش خريد با مبلغي كه قرار است"
    Public Const error_10 = "تراكنش خريد يافت نشد"
    Public Const error_11 = "فروشگاه مجوز تسويه آني ندارد"
    Public Const error_12 = "انصراف از خريد"
    Public Const error_13 = "معتبر نمي باشد pac"
    Public Const error_14 = "تسويه حساب با موفقيت انجام شد"
    Public Const error_15 = "امكان برقراري ارتباط با درگاه پرداخت وجود ندارد"

   
    Public PortalUrl = System.Configuration.ConfigurationSettings.AppSettings("PortalUrl")
    Public PGUrl = System.Configuration.ConfigurationSettings.AppSettings("PGUrl")
    Public userName = System.Configuration.ConfigurationSettings.AppSettings("userName")
    Public password = System.Configuration.ConfigurationSettings.AppSettings("password")
    Public userId = System.Configuration.ConfigurationSettings.AppSettings("userId")
    Public passWD = System.Configuration.ConfigurationSettings.AppSettings("passWD")
    Public url = System.Configuration.ConfigurationSettings.AppSettings("url")
    Public ref As Portal.com.sarmayebank.pgtest.SpringWSEndPointService
    Public pac As String
    Public callBackUrl As String

End Module
