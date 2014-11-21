<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="guestbook.aspx.cs" Inherits="Bug2Bug.ProtectedContent.guestbook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Guest Book</p>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="name,email,message" DataSourceID="GuestbookDB">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" SortExpression="name"></asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" ReadOnly="True"></asp:BoundField>
                    <asp:BoundField DataField="message" HeaderText="message" SortExpression="message" ReadOnly="True"></asp:BoundField>
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
            <asp:SqlDataSource runat="server" ID="GuestbookDB" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT * FROM [GuestbookEntry]"></asp:SqlDataSource>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="SubmitBtn" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

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
                <asp:RegularExpressionValidator ControlToValidate="GuestEmail" runat="server"
                    CssClass="field-validation-error" ErrorMessage="Invalid email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Message">Message</asp:Label>
                <asp:TextBox runat="server" ID="Message" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Message"
                    CssClass="field-validation-error" ErrorMessage="A message is required." />
            </li>
        </ol>
    </fieldset>
    <p>
        <asp:Button runat="server" CommandName="MoveNext" Text="Submit" ID="SubmitBtn" OnClick="SubmitBtn_Click" />
    </p>
</asp:Content>
