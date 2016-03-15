<%@ Page Language="vb"  EnableEventValidation="false" AutoEventWireup="false" MasterPageFile="~/ShopMaster.Master" CodeBehind="ShopHome.aspx.vb" Inherits="Portal.ShopHome" 
    title="Untitled Page" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  id="form1"  method="post"   >
    <table  id="tblShopHome"  class="tblCommon"  >
        <tr>
             <td align="center"  valign="bottom" style="width: 330px; height: 128px;" >
                 &nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="88px" 
                    Width="96px" ImageUrl="image/Dairy/gbasrej31.jpg" />
                 
                     &nbsp;<asp:Label ID="Label5"  runat="server" Text="قيمت : 10000"  Width="114px"  BackColor="#FFE0C0" BorderColor="White"  style="left: 28px; top: 0px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;" ></asp:Label>        
            </td>  
            <td align="center"  valign="bottom" style="width: 272px; height: 128px;" >
                 <asp:ImageButton ID="ImageButton2" runat="server" Height="96px" 
                    Width="80px" ImageUrl="image/Dairy/small_chcolat_milk_3.jpg" style="left: 20px; top: -8px" />
                 
                     &nbsp;<asp:Label ID="Label3"  runat="server" Text="قيمت : 15000"  Width="114px"  BackColor="#FFE0C0" BorderColor="White" style="left: 28px; top: 0px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>        
            </td>  
            <td align="center"  valign="bottom" style="height: 128px; width: 212px;" >
                 <asp:ImageButton ID="ImageButton3" runat="server" Height="96px" 
                    Width="72px" ImageUrl="image/Dairy/kashk02.jpg" />
                 
                     &nbsp;<asp:Label ID="Label6"  runat="server" Text="قيمت : 7000"  Width="114px"  BackColor="#FFE0C0" BorderColor="White" style="left: -32px; top: -2px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>        
            </td> 
            
            
                   
        </tr>

        <tr>
      <td align="center"  valign="bottom" style="width: 330px; height: 129px;" >
          &nbsp;
                 <asp:ImageButton ID="ImageButton4" runat="server" Height="104px" 
                    Width="120px" ImageUrl="image/Pooshak/2cmte2r.jpg" style="left: 44px; top: -17px" />
                     &nbsp;<asp:Label ID="lbl4"  runat="server" Text="قيمت : 250000"  Width="114px"  BackColor="#FFE0C0" BorderColor="White" style="left: -61px; top: -4px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>        
            </td>
           <td align="center"  valign="bottom" style="width: 272px; height: 129px;">
               &nbsp;<asp:ImageButton ID="ImageButton5" runat="server" Height="96px" 
                    Width="96px" ImageUrl="image/Pooshak/wqzi4o.jpg" style="left: 64px; top: -30px" />
                 
                     &nbsp;<asp:Label ID="lbl9"  runat="server" Text="قيمت : 180000"  Width="112px"  BackColor="#FFE0C0" BorderColor="White" style="left: -34px; top: -10px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>        
            </td>   
             <td align="center"  valign="bottom" style="height: 129px; width: 212px;">
                 &nbsp;
                 <asp:ImageButton ID="ImageButton6" runat="server" Height="96px" 
                    Width="96px" ImageUrl="image/Pooshak/2itrho8.jpg" style="position: relative" />
                 
                     <asp:Label ID="lbl5"  runat="server" Text="قيمت : 800000"  Width="114px"  BackColor="#FFE0C0" BorderColor="White" style="font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>        
            </td> 
                                             
        </tr>
               <tr>
       <td align="center"  valign="bottom" style="width: 330px; height: 115px;">
                <asp:ImageButton ID="ImageButton7" runat="server" Height="88px" 
                    Width="120px" ImageUrl="image/Fruitage/انگور.jpg" style="left: 68px; top: -17px" />
                
                    <asp:Label ID="Label1" runat="server" BackColor="#FFE0C0" BorderColor="White"
                     Text="قيمت : 15000" 
                    Width="114px" style="left: -24px; top: -1px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>
                &nbsp;
            </td> 
             <td align="center"  valign="bottom" style="width: 272px; height: 115px;">
                 <asp:ImageButton ID="ImageButton8" runat="server" Height="88px" 
                    Width="96px" ImageUrl="image/Fruitage/sib.jpg" style="left: 52px; top: -24px" />
                 
                     &nbsp;<asp:Label ID="Label2"  runat="server" Text="قيمت : 15000"  Width="114px"  BackColor="#FFE0C0" BorderColor="White" style="left: -45px; top: -3px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>        
            </td> 
           
             <td align="center" valign="bottom" style="height: 115px; width: 212px;" >
                &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton9" runat="server" Height="80px"  Width="48px" ImageUrl="image/Foods/تخم مرغ_resize.JPG" style="left: 27px; top: -17px" />
                
                     <asp:Label ID="lbl1"  runat="server" Text="قيمت : 16000"  Width="114px"   BackColor="#FFE0C0" BorderColor="White" Height="16px" style="left: -61px; top: 2px; font-weight: bold; font-size: small; font-family: Zar; color: #000000;"></asp:Label>&nbsp;               
                
            </td>                                     
        </tr>
    </table>
           
    </form>

</asp:Content>
