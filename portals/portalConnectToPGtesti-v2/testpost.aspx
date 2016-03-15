<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="testpost.aspx.vb" Inherits="Portal.testpost" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>بانکداری الکترونیکی</title>
  
    <style type="text/css">
        .style1
        {
            width: 234px;
        }
        .style2
        {
            width: 228px;
        }
        .style3
        {
            width: 321px;
            height: 467px;
        }
        .style4
        {
            height: 467px;
        }
        .style5
        {
            height: 66px;
        }
    </style>
  

</head>

<body style="background:#cdffeb">
<script language="vbscript" runat="server">

</script>
<table  width="100%" style="height:107px">
<tr><td class="style3"></td>
<td class="style4">
<table id="table1" border="1" dir="rtl"     style="font-weight:border-left-color: #65ccbe; 
  border-bottom-color: #65ccbe; 
  border-top-style: solid; 
  border-top-color: #65ccbe; 
  border-right-style: solid; 
  border-left-style: solid; 
  background-color: #93eecc; 
  border-right-color: #65ccbe; 
  border-bottom-style: solid; width: 63%; height: 243px;" >
<tr >
<td colspan="2" align="center" class="style5"   >
  <asp:Label ID="Label4" runat="server" Text="تایید خرید"  
 
   Font-Names="tahoma" Font-Size="Large" ForeColor="#006666" Font-Bold="true">
 
 </asp:Label>  
   

</td>
</tr>

<tr>
<td align="left" valign="top" class="style1">

 <asp:Label ID="Label1" runat="server" Text="کد سفا رش : "  
 
   Font-Names="tahoma" Font-Size="Small" ForeColor="#006666" Font-Bold="true">
 
 </asp:Label>
 </td>
 <td align="right" valign="top" class="style2" >
 <input id="Text1" type="text"   value='<%=session("reservationNum")%>' />
  </td>
  </tr>
    <tr>
<!--td align="left" valign="top" class="style1">
   <asp:Label ID="Label2" runat="server" Text="کد فروشگاه : " Font-Names="tahoma" Font-Size="Small" ForeColor="#006666" Font-Bold="true" ></asp:Label>
   </td>
   
   <td align="right" valign="top" class="style2" >
   <input id="Text2" type="text"   value='<%=session("userName")%>' />
  </td>
  </tr>
  <tr-->
<td align="left" valign="top" class="style1">

  <asp:Label ID="Label3" runat="server" Text="مبلغ : " Font-Names="tahoma" Font-Size="Small" ForeColor="#006666" Font-Bold="true"></asp:Label>
  </td>
  <td align="right" valign="top" class="style2" >
  
  <input id="Text3" type="text"   value='<%=session("merchantAmount")%>' />
 
  
  </td>
  </tr>
 


    


<tr>
<td   valign="top" class="style1"></td>
<td align="right"  valign="top" class="style2">
<form id="letsplay"   runat="server" > 
  
  <input type="submit" runat="server"  name="confirm" value="تایید"   style="border-style: inset; border-color: #009999; font-weight: bold; 
 font-size:small; 
 color: #006666; 
 font-family: tahoma; 
 background-color: #99cccc; 
 width: 62px; height: 31px;" id="Submit1" onclick="return Submit1_onclick()" 

 /> 
</form>
</td>

</tr>
</table>
</td></tr>
</table>
</body>
</html>
