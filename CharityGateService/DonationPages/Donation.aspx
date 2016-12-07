<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Donation.aspx.cs" Inherits="CharityGateService.DonationPages.Donation" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
     <asp:Repeater ID="OrganizationsRepeater" runat="server">
        <ItemTemplate>
            <a href='OrganizationItems.aspx?Id=<%# Eval("OrganizationId") %>'><%# Eval("OrganizationName") %></a><br />
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>