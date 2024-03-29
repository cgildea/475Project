﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bug2Bug._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Welcome to Our Password-Protected Book Information Site.</h2>
            </hgroup>
            <p>
                To learn more about our books, <a href="ProtectedContent/Books.aspx">click here</a> or click the Books tab in the navigation bar above. You must be logged in to view the Books page.</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Cookie Monster</h3>
        <p>
            <asp:AdRotator ID="cookieRotator" runat="server"
                DataSourceID="adXmlDataSource" />
            <asp:XmlDataSource ID="adXmlDataSource" runat="server"
                DataFile="~/App_Data/Cookie.xml" />
        </p>
    </asp:Content>
