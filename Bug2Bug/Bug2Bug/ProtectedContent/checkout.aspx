<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="Bug2Bug.ProtectedContent.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Books Ordered:</p>
    <p>
      <asp:ListBox ID="shoppingCart" runat="server" SelectionMode="Single" CssClass="form-select" >
      </asp:ListBox>
    </p>
    <p>
        <table>
            <tr>
                <td style="text-align:right;">Subtotal:</td>
                <td style="text-align:right;"><asp:Label ID="subtotalText" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align:right;">Tax:</td>
                <td style="text-align:right;"><asp:Label ID="taxText" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align:right;">Total:</td>
                <td style="text-align:right;"><asp:Label ID="totalText" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </p>

    
      <fieldset>
        <ol>
         <li>
          <asp:Label runat="server" AssociatedControlID="CreditCard">Credit Card Info (Visa or MasterCharge)</asp:Label>
          <asp:TextBox runat="server" ID="CreditCard"  />
          <asp:RequiredFieldValidator runat="server" ControlToValidate="CreditCard"
           CssClass="field-validation-error" ErrorMessage="This field is required." />
         </li>                   
        </ol>
          <asp:LinkButton runat="server" CommandName="PayFinal" Text="Finalize" PostBackUrl="~/ProtectedContent/final.aspx" />
      </fieldset>
    
    <p>
    <a id="G4" runat="server" href="~/ProtectedContent/Books">View More Books</a>
    <a id="G5" runat="server" href="~/ProtectedContent/order">Review Order</a>
    </p>
</asp:Content>
