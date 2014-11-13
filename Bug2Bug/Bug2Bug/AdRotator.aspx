<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="AdRotator.aspx.cs" Inherits="Bug2Bug.AdRotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Cookie Monster</h3>
        <p>
            <asp:AdRotator ID="cookieRotator" runat="server"
                DataSourceID="adXmlDataSource" />
            <asp:XmlDataSource ID="adXmlDataSource" runat="server"
                DataFile="~/App_Data/Cookie.xml" />
        </p>
    </div>
    </form>
</body>
</html>
