<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospitalsServices.aspx.cs" Inherits="CharityGateService.DonationPages.Hospitals.HospitalsServices" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <asp:Repeater ID="HospitalsFunctionallatyRepeater" runat="server">
        <ItemTemplate>
            <a href='HospitalsServicesHandel.aspx?HospitalId=<%= HospitalId %>&FunctionalityId=<%# Eval("HospitalFunctionalityId") %>'><%# Eval("HospitalFunctionalityName") %><%= HospitalName %></a><br />
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
