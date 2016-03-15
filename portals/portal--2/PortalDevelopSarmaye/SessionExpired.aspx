<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SessionExpired.aspx.vb" EnableEventValidation="false"  MasterPageFile="~/ShopMaster.Master" Inherits="Portal.SessionExpired" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server"  >
    <form id="form1"   action="">
    
     <table class="tableStyle1"  style="width :60%; right: 20%; top: 0%; height: 100px; position: relative; clip: rect(auto auto auto auto);"  border="0">
    <tr><td style="width: 29px; height: 8px;"></td><td class="tdSessionExpired"  colspan="2"  align="right" style="height: 8px" >
    پايان زمان خريد
    </td>
   </tr>
    <tr><td  class="tdSessionExpired" colspan="4"  >زمان شما براي انجام اين خريد به پايان رسيده است  
     <!--a href="ShopHome.aspx">بازگشت به صفحه اصلي</a--> 
  
    </td>
    </tr>
   </table>
    </form>
</asp:Content>
