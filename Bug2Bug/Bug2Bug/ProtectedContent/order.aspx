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
      <asp:ListBox ID="shoppingCart" runat="server" SelectionMode="Single" CssClass="form-select" >
      </asp:ListBox>
    </p>
    <a id="G2" runat="server" href="~/ProtectedContent/books">Continue Shopping</a>
    <a id="G3" runat="server" href="~/ProtectedContent/checkout">Check Out</a>
   <p>
      &nbsp;</p>
</asp:Content>