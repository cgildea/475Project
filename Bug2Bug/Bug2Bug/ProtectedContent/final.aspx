<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="final.aspx.cs" Inherits="Bug2Bug.ProtectedContent.final" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Your Total is: <asp:Label ID="totalText" runat="server" Text=""></asp:Label></p>
    <p>Your items will be delivered within 3-5 business days.</p>
    <p>Thank You!:</p>
    <a id="G7" runat="server" href="~/ProtectedContent/guestbook">Guestbook</a>
</asp:Content>
