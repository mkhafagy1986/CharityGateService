<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hospitals.aspx.cs" Inherits="CharityGateService.DonationPages.Hospitals.Hospitals" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <asp:Repeater ID="HospitalsRepeater" runat="server">
        <ItemTemplate>
            <a href='HospitalsServices.aspx?Id=<%# Eval("HospitalId") %>'><%# Eval("HospitalName") %></a><br />
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
