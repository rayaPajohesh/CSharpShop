<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PortalHome.aspx.vb" Inherits="Portal.PortalHome" %>

<!DOCTYPE html PUBLIC "-//W3C//Dtd XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/Dtd/xhtml1-transitional.dtd">

<html  xmlns="http://www.w3.org/1999/xhtml" >

<head id="Head1"  >
    <title>Untitled Page</title>
    <link href="Default.css" rel="stylesheet" type="text/css" />
<script language="javascript" type="text/javascript">
<!--
	function __doPostBack(eventTarget, eventArgument) {
		var theform;
		if (window.navigator.appName.toLowerCase().indexOf("microsoft") > -1) {
			theform = document.Form1;
		}
		else {
			theform = document.forms["Form1"];
		}
		theform.__EVENTTARGET.value = eventTarget.split("$").join(":");
		theform.__EVENTARGUMENT.value = eventArgument;
		theform.submit();
	}
function IMG2_onclick() {

}

function IMG3_onclick() {

}

// -->
</script>
</head>


<body  class="PortalHomeBody" >
    <form id="form1" runat="server" >
        <!-- TABLE HEADER-->
        <table id="TableHeader" cellpadding="0" border="0"  class="PortaLtableHeader">
            <tr class="PortaLtrHeader" >
                <td    class="tdHeader"  >
                    <a id="HomePage" class="PortaLaHeader" href = "PortalHome.aspx" >&nbsp;صفحه اصلی</a>
                </td>
               
                <td class="tdHeader"  >
                    <a id="Suggestions" class="PortaLaHeader">&nbsp;|&nbsp;ديدگاهها و پيشنهادها</a>
                </td>
   
                <td class="portalTdHeader"   >
                    <a id="ContactUsLinkBtn" class="PortaLaHeader">&nbsp;|&nbsp;ارتباط با ما</a>
                </td>

                <td class="tdHeader"  >
                    <a id="Recruitment" class="PortaLaHeader">&nbsp;|&nbsp;راهنما </a>
                </td>
               
            </tr>
        </table>
        <!-- TABLE LOGO -->
        <table id="TableLogo" class="PortaltableLogo" onclick="return TableLogo_onclick()" >
            <tr>
            
                <td   class="PortaltableLogoTR"  >
               <img src="image/purchase portal.jpg" class="PortaltableLogoImage" style="height: 201px;width:100%"   />
                </td>
            </tr>
          
        </table>
        <!-- END TABLE LOGO -->
        <!-- TABLE DETAIL -->
        <table id="TbaleDetail" class="PortaLtableDetail" style="right: 0px; top: 228px; height: 186px; width: 107%;" >
            <tr>
                <td id="Menu" class="PortaltdMenu"   >
                   <asp:Menu ID="Menu1" runat="server" Height="233px" 
                        BorderColor="WhiteSmoke" Font-Italic="False" ForeColor="#004040" Width="153px" >                       
                    <Items>
                       <asp:MenuItem  Value=" " ImageUrl="Image/Menu/kharide interneT.jpg" Text=" "></asp:MenuItem> 
                       
                      <asp:MenuItem  Value="  "  ImageUrl="Image/Menu/ghobo0z.JPG" Text="  " ></asp:MenuItem>
                      
                      <asp:MenuItem  Value="   "  ImageUrl="Image/Menu/Nteghal.JPG" Text="   "></asp:MenuItem>
                      
                      <asp:MenuItem  Value="    " ImageUrl="Image/Menu/mojo0DEhesab.JPG" Text="    "></asp:MenuItem>
                     
                    </Items>
                        
                    </asp:Menu>
                    
                   </td>
                    <td>
                    
                     <table width="100%" class="PortalHomeTable"  align="left" >
                     <tr  align="center">
                   
                     <td   class="PortalHomeTd1"   align="center" style="height: 20px">
                       &nbsp; <img      src="image/PortalHome/caspian.jpg"   />
                     </td>
                     <td    class="PortalHomeTd2" style="height: 20px"     >
                         <img     src="image/PortalHome/iranair-logo2_resize.jpg" style="height: 88px"   /></td>
                     <td   class="PortalHomeTd3" style="height: 20px"   >
                        &nbsp;<img   c   src="image/PortalHome/mofidbourse.gif"   />
                    </td>
                      <td  class="PortalHomeTd4" style="width: 337px; height: 20px;" >
                         <img   src="image/PortalHome/saham.jpg"   /></td>                                         
                    <td  class="PortalHomeTd5" style="height: 20px; width: 337px;"  >
                        <img  class="PortalHomeMahanLogo" src="image/PortalHome/mahanLogo.jpg" style="width: 112px; height: 48px"   />
                    </td> 
                </tr>
                <tr dir="ltr" align="center">
                    <td   class="PortalHomeTd6" style="height: 13px" >
                         <img   src="image/PortalHome/hamrahaval1.jpg"  id="IMG2" onclick="return IMG2_onclick()"   /></td>
                     <td   class="PortalHomeTd7" style="height: 13px"  >
                        <img    src="image/PortalHome/raja_RTL.gif"   />
                     </td>
                     <td  class="PortalHomeTd8" style="height: 13px"  >
                         <img    src="image/PortalHome/irankhodro_resize.jpg"  /></td>
                     <td  class="PortalHomeTd9" style="width: 337px; height: 13px;"   ><img  src="image/PortalHome/new-2.jpg"     />&nbsp;</td> 
                     <td  class="PortalHomeTd10" style="width: 337px; height: 13px"  >
                        &nbsp;<img   src="image/PortalHome/aseman2_resize.jpg"   />&nbsp;</td>     

                </tr><tr dir="ltr" align="center">
                    <td   class="PortalHomeTd11" style="height: 10px"  >
                        <img   src="image/PortalHome/zamiad1_resize.jpg"  id="IMG1" onclick="return IMG1_onclick()"   />&nbsp;</td>
                     <td  class="PortalHomeTd12" style="height: 10px" >
                        <img  class="PortalHomeHamsafar" src="image/PortalHome/hamsafar.JPG" style="height: 84px"   />
                        </td>
                     <td  class="PortalHomeTd13" style="height: 10px"  >
                         <img class="PortalHomeAriaSafarAsia" src="image/PortalHome/AriaSafarAsia.JPG" style="width: 112px; height: 80px"  />
                         </td>
                     <td class="PortalHomeTd14" style="height: 10px"  ><img  src="image/PortalHome/ghasrHotol.jpg" style="width: 80px; height: 80px"   />
                        &nbsp;</td>
                     <td class="PortalHomeTd15" style="height: 10px; width: 337px;" >
                        <img  class="PortalHomeSaipa" src="image/PortalHome/saipa_resize.jpg" style="height: 83px"   />
                    </td>      

                </tr><tr dir="ltr" align="center">
                    <td   class="PortalHomeTd16"  >
                         <img  class="PortalHomeForush2" src="image/PortalHome/forush2.jpg" style="width: 94px; height: 82px"   /></td>
                     <td  class="PortalHomeTd17"   >
                         &nbsp;<img  class="PortalHomeHotelGhasr"  src="image/PortalHome/hotelGhasr.jpg" style="width: 98px; height: 88px"   /></td>
                     <td  class="PortalHomeTd18"  >
                         <img    src="image/PortalHome/hotelHayte.jpg"   /></td>
                     <td  class="PortalHomeTd19" style="width: 337px"  >
                         <img class="PortalHomeDaryush" src="image/PortalHome/daryush kish.jpg" style="width: 101px; height: 81px"  /></td>

                    <td  class="PortalHomeTd20" style="width: 337px"  >
                         <img class="PortalHomeParskhodro" src="image/PortalHome/pars khodro_resize.jpg"  /></td>
                 
              
                </tr>
            <tr >
                <td align="center" id ="license"  colspan="6"  class="PortaLtdLicense" >
                    كليه حقوق اين سايت متعلق به شركت ايران ارقام است
                </td>
            </tr>
        </table>
        </td>
        </tr>
        </table>
    </form>
</body>
</html>