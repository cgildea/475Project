<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AuthorManage.aspx.cs" Inherits="Bug2Bug.ProtectedContent.AuthorManage" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script src="../Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>

    <asp:UpdatePanel ID="Update" runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSave" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="btnDelete" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <asp:GridView runat="server" ID="AuthorsList_GridView">
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>


    <fieldset>
        <h2>Add Author</h2>

        <table>


            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox runat="server" ID="fname" /></td>

                <asp:RequiredFieldValidator runat="server" ControlToValidate="fname" ValidationGroup="AuthorName"
                    CssClass="field-validation-error" ErrorMessage="Please enter an author's first name" />
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox runat="server" ID="lname" /></td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="lname" ValidationGroup="AuthorName"
                    CssClass="field-validation-error" ErrorMessage="Please enter an author's last name" />
            </tr>
            <tr>
                <td>
                    <asp:Button Text="Save" runat="server" ID="btnSave" OnClick="SaveBtn_Click" ValidationGroup="AuthorName" /></td>

            </tr>
        </table>
        <br />
    </fieldset>

    <fieldset>
        <h2>Search Author by last name</h2>
        <asp:TextBox ID="authorSearch" runat="server" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="authorSearch" ValidationGroup="SearchAuthor"
            CssClass="field-validation-error" ErrorMessage="Please enter an author's last name" />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="SearchBtn_Click" ValidationGroup="SearchAuthor" />


        <br />
    </fieldset>
    <!--
    <h2>Delete Author</h2>
    <asp:TextBox ID="authorDelete" runat="server" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />

 -->



</asp:Content>
