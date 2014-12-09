<%@ Page Title="AuthorManage" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AuthorManage.aspx.cs" Inherits="Bug2Bug.AuthorManage" Async="true" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="Content1" >
   

    <h2>Add Author</h2>

    <asp:Label ID="addLabel1" runat="server" AssociatedControlID="addfname">First Name</asp:Label>
    <asp:TextBox ID="addfname" runat="server" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="addfname" ID="RequiredAddFieldValidator1" ErrorMessage="Please provide a name" CssClass="field-validation-error" Display="Dynamic" ValidationGroup="AddAuthorGroup"/>

    <asp:Label ID="addLabel2" runat="server" AssociatedControlID="addlname">Last Name</asp:Label>
    <asp:TextBox ID="addlname" runat="server" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="addlname" ID="RequiredAddFieldValidator2" ErrorMessage="Please provide a name" CssClass="field-validation-error" Display="Dynamic" ValidationGroup="AddAuthorGroup"/>

    <asp:Button runat="server" ID="UpdateButton2" OnClick="addAuthorButton_Click"  Text="Add" ValidationGroup="AddAuthorGroup" />

    <br />
    <br />
    <h2>Search</h2>

    <asp:Label ID="LastNameLabel1" runat="server" AssociatedControlID="searchlname">Last Name</asp:Label>
    <asp:TextBox ID="searchlname" runat="server" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="searchlname" ID="RequiredLNameSearchValidator" ErrorMessage="Please provide a name" CssClass="field-validation-error" Display="Dynamic" ValidationGroup="SearchGroup"/>
    <asp:Button runat="server" ID="UpdateButton1" OnClick="getAuthorButton_Click" Text="Search" ValidationGroup="SearchGroup" />

    <br />
    <asp:TextBox ID="serverResponse" runat="server" Height="113px" Width="323px" TextMode="MultiLine" />
   
    

</asp:Content>