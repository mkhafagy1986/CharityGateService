<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizationItems.aspx.cs" Inherits="CharityGateService.DonationPages.OrganizationItems" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <asp:Repeater ID="HospitalsRepeater" runat="server">
        <ItemTemplate>
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                <a href='OrganizationsItemsFunctionalities.aspx?OrganizationTypeId=<%# Eval("OrganizationTypeId") %>&OrganizationItemId=<%# Eval("OrganizationItemId") %>'><%# Eval("OrganizationItemArabicName") %></a><br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                <a href='OrganizationsItemsFunctionalities.aspx?OrganizationTypeId=<%# Eval("OrganizationTypeId") %>&OrganizationItemId=<%# Eval("OrganizationItemId") %>'><%# Eval("OrganizationItemEnglishName") %></a><br />
            <% } %>

        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
