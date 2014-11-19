<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="guestbook.aspx.cs" Inherits="Bug2Bug.ProtectedContent.guestbook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Guest Book</p>
    <fieldset>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="GuestName">Name</asp:Label>
                <asp:TextBox runat="server" ID="GuestName" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="GuestName"
                    CssClass="field-validation-error" ErrorMessage="A name is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="GuestEmail">Email address</asp:Label>
                <asp:TextBox runat="server" ID="GuestEmail" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="GuestEmail"
                    CssClass="field-validation-error" ErrorMessage="An email address field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Message">Message</asp:Label>
                <asp:TextBox runat="server" ID="Message" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Message"
                    CssClass="field-validation-error" ErrorMessage="A message is required." />
            </li>
        </ol>
        <asp:Button runat="server" CommandName="MoveNext" Text="Submit" />
    </fieldset>
</asp:Content>
