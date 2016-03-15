<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MessageForm.aspx.vb"  EnableEventValidation="false" MasterPageFile="~/ShopMaster.Master" Inherits="Portal.MessageForm" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server"  >




    <form id="form4" method="post"  style="position: relative;">
    <table class="tableStyle1"  border="0">
    <tr><td  colspan="2"  align="center" style="height: 23px" >
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Height="21px" CssClass="labelStyle3" Style="right: -1px; top: 17px; font-weight: bold;"
            Width="304px"></asp:Label></td></tr>
     
     <tr><td align="left" style="height: 28px; width: 179px;" ><asp:Label ID="lblRN" runat="server" Height="23px" 
            Text=" كد سفارش :" Width="133px" CssClass="labelStyle4" style="right: 80px; top: -21px; font-weight: bold;"></asp:Label></td><td align="right" style="height: 28px; width: 214px;">  
        
        <asp:TextBox ID="TextBox1" runat="server" CssClass="textStyle2" Width="153px" Height="17px" style="font-weight: bold" ></asp:TextBox>
       </td>  </tr> 
        <tr><td colspan="2" id="g" align="center" style="height: 34px" ><asp:Label ID="lblHelp" runat="server" Height="25px"  CssClass="labelStyle3" Style="right: 10px; top: -15px; font-weight: bold;"
            Width="374px" ForeColor="Red"></asp:Label></td></tr>
        
       <tr><td align="left" style="height: 20px; width: 179px;" > 
      <asp:Label ID="Label1" runat="server" Height="22px"
            Text="شماره پيگيري تراكنش :" Width="165px" CssClass="labelStyle4" style="right: -1px; top: 3px; font-weight: bold;"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"  Width="152px" Height="15px" CssClass="textStyle2" style="right: 166px; top: -25px; position: relative; font-weight: bold;"></asp:TextBox></td><td align="right" style="height: 20px; width: 214px;">     
         </td>  </tr>
          <tr><td align="left" style="height: 20px; width: 179px;" > 
      <asp:Label ID="Label2" runat="server" Height="22px"
            Text="شماره ارجاع :" Width="165px" CssClass="labelStyle4" style="right: -1px; top: 3px; font-weight: bold;"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"  Width="152px" Height="15px" CssClass="textStyle2" style="right: 166px; top: -25px; position: relative; font-weight: bold;"></asp:TextBox></td><td align="right" style="height: 20px; width: 214px;">     
         </td>  </tr>
         <tr><td align="left" style="height: 20px; width: 179px;" > 
      <asp:Label ID="Label3" runat="server" Height="22px"
            Text="مبلغ  :" Width="165px" CssClass="labelStyle4" style="right: -1px; top: 3px; font-weight: bold;"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"  Width="152px" Height="15px" CssClass="textStyle2" style="right: 166px; top: -25px; position: relative; font-weight: bold;"></asp:TextBox></td><td align="right" style="height: 20px; width: 214px;">     
         </td>  </tr>
       </table>
     </form>
</asp:Content>

