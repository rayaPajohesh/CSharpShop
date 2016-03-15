<%@ Page Language="vb"   EnableEventValidation="false" AutoEventWireup="false"  MasterPageFile="~/ShopMaster.Master"  CodeBehind="ShopPurchase.aspx.vb" Inherits="Portal.ShopPurchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form3" method="post" >
<table id="EditKala" width="100%" border="0" >
    <tr >
			<td colspan="5" style="height: 21px; " align="left" >
			<asp:Button id="btAdd"  Text="سبد خريد         " CssClass="buttonStyle1" Runat="server" style="background-image: url(Image/shopping_cart1.PNG); right: 336px; top: 0px;" Height="47px" ></asp:Button>       
        </td>        

    </tr>


    <tr>
    <!--td style="width: 6112px"></td-->
    </tr>

</table>      
<table id="KalaGrid" width="100%" border="0">

    <tr>
    <td  colspan="5" align="center" valign="top"  style=" height: 174px;">
        <asp:datagrid id="grdKala" runat="server" AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True"   PagerStyle-NextPageText="صفحه بعدي" PagerStyle-PrevPageText="صفحه قبلي" PageSize="6" DataKeyField="Kala_Code" CssClass="gridStyle1"  Width="100%">
							       <SelectedItemStyle CssClass="DataGrid_SelectedItemStyle" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
							        <ItemStyle CssClass="DataGrid_ItemStyle" />
							        <AlternatingItemStyle CssClass="DataGrid_AlternatingItemStyle" />
							        <HeaderStyle CssClass="DataGrid_HeaderStyle" />
							        <FooterStyle CssClass="DataGrid_FooterStyle" />
							        <Columns   >
								        <asp:BoundColumn DataField="Kala_Price"  SortExpression="Kala_Price" HeaderText="قيمت"  >
                                        <HeaderStyle Font-Bold="True" Font-Names="Zar"  ForeColor="#006699" />
                                        </asp:BoundColumn>
								        <asp:BoundColumn DataField="No_Kala" SortExpression="No_Kala" HeaderText="(تعداد / وزن )كيلو">
                                            <HeaderStyle Font-Bold="True" Font-Names="Zar"  ForeColor="#006699" />
                                        </asp:BoundColumn>
								        <asp:BoundColumn DataField="kala_Name" SortExpression="Kala_Name" HeaderText="نام كالا">
                                            <HeaderStyle Font-Bold="True" Font-Names="Zar" ForeColor="#006699"/>
                                        </asp:BoundColumn>
								        <asp:BoundColumn DataField="Kala_Code" SortExpression="Kala_Code" HeaderText="كد كالا"  >
                                            <HeaderStyle Font-Bold="True" Font-Names="Zar" ForeColor="#006699"/>
                                        </asp:BoundColumn>
					
								        <asp:ButtonColumn Text="تغيير" ButtonType="PushButton" CommandName="Select">
                                            <HeaderStyle Font-Bold="True" Font-Names="Zar"  ForeColor="#006699" />
                                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="Medium"
                                                Font-Strikeout="False" Font-Underline="False" />
                                        </asp:ButtonColumn>
								        <asp:ButtonColumn Text="حذف" ButtonType="PushButton" CommandName="Select">
                                           <HeaderStyle Font-Bold="True" Font-Names="Zar"  ForeColor="#006699" />
                                        </asp:ButtonColumn>
							        </Columns>							 
            <PagerStyle NextPageText="صفحه بعدي" PrevPageText="صفحه قبلي" />
						        </asp:datagrid>

    </td>
    </tr>
        <tr >
          <td  align="left" class="labelStyle1" style="height: 13px; width: 130px;" > كد كالا :</td>
        <td align="right" style="height: 13px;"  >
    		<asp:textbox id="txtKalaCode" runat="server"  MaxLength="20" EnableViewState="False" CssClass="textStyle1" Height="20px" Width="105px"></asp:textbox>&nbsp;    
        </td>
        <td  align="left" class="labelStyle1" style="color: #006699; height: 13px; position: relative;" > نام كالا :</td>    
       <td align="right" style="height: 13px;">
    		<asp:textbox id="txtKalaName" runat="server"  MaxLength="50" EnableViewState="False" CssClass="textStyle1" Height="21px" Width="106px"></asp:textbox>&nbsp;    
        </td>      
      <td style="height: 13px"></td>
    </tr>
    <tr >
              <td  align="left" class="labelStyle1" style="height: 22px; width: 130px;" >تعداد/وزن(كيلو):</td>    
        <td align="right" style=" height: 19px;">
    		<asp:textbox id="txtNoKala" runat="server"  MaxLength="20" EnableViewState="False" CssClass="textStyle1" Height="18px" Width="106px" ></asp:textbox>&nbsp;    
        </td>
        
    
  
         <td  align="left" class="labelStyle1" style="height: 22px;" > قيمت :</td>    
        <td align="right" style=" height: 19px;">
    		<asp:textbox id="txtKalaPrice" runat="server"  MaxLength="20" EnableViewState="False" CssClass="textStyle1" Height="18px" Width="106px" ></asp:textbox>&nbsp;    
        </td>
     			<td style="height: 21px; "   >
			<asp:Button id="btnSave" Text="ثبت تغييرات"  CssClass="buttonStyle1" Runat="server" Height="31px"   ></asp:Button>       
        
        </td>        
    
    </tr>
    <tr>

        <td style=" height: 80px; width: 130px;">
	        
       <asp:Label ID="lblTotalPrice"  runat="server" Text=" مبلغ كل  :" CssClass="labelStyle2" style="left: -7px; top: 0px; " Height="1px" Width="125px"></asp:Label>						        
						                
        </td>
            <td colspan="4"   style="height: 80px"  align="left">
                <asp:Button ID="Reconciliation" runat="server" Font-Bold="True" Font-Names="Tahoma"
                    Font-Size="Medium" Text="تسويه حساب" Width="111px" />
                &#160;&#160;
         <asp:LinkButton ID="LinkButton1" runat="server"     Height="98px" Style="left: 253px; 
            background-image: url(image/sarmayehLogo.jpg);  top: -3px" Width="127px" BorderStyle="Outset"></asp:LinkButton>
        </td>

    </tr>
</table>
  

    </form>
    
</asp:Content> 
