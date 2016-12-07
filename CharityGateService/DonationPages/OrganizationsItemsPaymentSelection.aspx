<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizationsItemsPaymentSelection.aspx.cs" Inherits="CharityGateService.DonationPages.OrganizationsItemsPaymentSelection" %>


<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
                للتبرع بمبلغ <%= DonationAmount %> جنية مصري، برجاء إختيار وسيلة الدفع:<br />
    <% } %>
    <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
                To donate by <%=DonationAmount %> E.L, Please select payment method:<br />
    <% } %>

    <asp:Repeater ID="PaymentMethodRepeater" runat="server">
        <ItemTemplate>
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                <a href="PaymentMethodHandel.aspx?donationamount=<%=DonationAmount %>&PaymentTypeId=<%# Eval("PaymentTypeId") %>"><%# Eval("PaymentTypeArabicName") %></a><br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                <a href="PaymentMethodHandel.aspx?donationamount=<%=DonationAmount %>&PaymentTypeId=<%# Eval("PaymentTypeId") %>"><%# Eval("PaymentTypeEnglishName") %></a><br />
            <% } %>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
