<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizationsItemsFunctionalities.aspx.cs" Inherits="CharityGateService.DonationPages.OrganizationsItemsFunctionalities" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <asp:Repeater ID="OrganizationsFunctionallatyRepeater" runat="server">
        <ItemTemplate>
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                <a href='OrganizationsItemsServicesHandel.aspx?OrganizationTypeId=<%= OrganizationTypeId %>&OrganizationItemId=<%= OrganizationItemId %>&FunctionalityId=<%# Eval("OrganizationFunctionalityId") %>'><%# Eval("OrganizationFunctionalityArabicName") %><%= OrganizationItemName %></a><br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                <a href='OrganizationsItemsServicesHandel.aspx?OrganizationTypeId=<%= OrganizationTypeId %>&OrganizationItemId=<%= OrganizationItemId %>&FunctionalityId=<%# Eval("OrganizationFunctionalityId") %>'><%# Eval("OrganizationFunctionalityEnglishName") %><%= OrganizationItemName %></a><br />
            <% } %>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
