<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="Bug2Bug.ProtectedContent.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Books Ordered:</p>
    <p>
      <asp:ListBox ID="checkoutCart" runat="server" SelectionMode="Single" CssClass="form-select" >
      </asp:ListBox>
    </p>

    <p>Types of Payments (Visa or MasterCharge):
      <asp:FormView ID="VisaForm" runat="server">

      </asp:FormView>
    </p>

    <a id="G4" runat="server" href="~/ProtectedContent/Books">Review Shopping Cart</a>
    <a id="G5" runat="server" href="~/ProtectedContent/order">Review Order</a>
    <a id="G6" runat="server" href="~/ProtectedContent/checkout">Finalize</a>
    <p>
</asp:Content>
