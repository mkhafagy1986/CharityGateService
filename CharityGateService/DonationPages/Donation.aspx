<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Donation.aspx.cs" Inherits="CharityGateService.DonationPages.Donation" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <asp:Repeater ID="OrganizationsRepeater" runat="server">
        <ItemTemplate>
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                <a href='OrganizationItems.aspx?OrganizationId=<%# Eval("OrganizationId") %>'><%# Eval("OrganizationArabicName") %></a><br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                <a href='OrganizationItems.aspx?OrganizationId=<%# Eval("OrganizationId") %>'><%# Eval("OrganizationEnglishName") %></a><br />
            <% } %>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
