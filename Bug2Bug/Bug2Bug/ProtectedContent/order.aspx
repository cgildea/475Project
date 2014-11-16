<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Bug2Bug.ProtectedContent.order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

   <p>
      Your Shopping Cart:
   </p>
    <p>
      <asp:GridView ID="titlesGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
          <Columns>
              <asp:HyperLinkField DataNavigateUrlFields="ISBN" DataNavigateUrlFormatString="Order.aspx?isbn={0}" Text="Select"></asp:HyperLinkField>
          </Columns>

          <EditRowStyle BackColor="#999999" />
         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#E9E7E2" />
         <SortedAscendingHeaderStyle BackColor="#506C8C" />
         <SortedDescendingCellStyle BackColor="#FFFDF8" />
         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
      </asp:GridView>
   </p>
    <a id="G2" runat="server" href="~/ProtectedContent/order">Continue Shopping</a>
    <a id="G3" runat="server" href="~/ProtectedContent/order">Check Out</a>
   <p>
      &nbsp;</p>
</asp:Content>