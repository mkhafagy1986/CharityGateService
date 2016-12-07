<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentMethodHandel.aspx.cs" Inherits="CharityGateService.DonationPages.PaymentMethodHandel" %>


<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
        <% if (PaymentTypeId == "1") %>
        <% { %>
                    لتأكيد التبرع بمبلغ <%= DonationAmount %> جنية مصري، برجاء ادخال رقم 1:<br />
        <% } %>
        <% else if(PaymentTypeId=="2") %>
        <%{ %>
                    لتأكيد التبرع بمبلغ <%= DonationAmount %> جنية مصري، برجاء ادخال الرقم السري لخدمة Orange Wallet:<br />
        <% } %>

    <% } %>
    <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
            <% if (PaymentTypeId == "1") %>
            <% { %>
                To confirm donation by <%=DonationAmount %> E.L, Please select enter 1:<br />
            <% } %>
            <% else if(PaymentTypeId=="2") %>
            <%{ %>
                To confirm donation by <%=DonationAmount %> E.L, Please enter Orange Wallet PIN code:<br />
            <% } %>
    <% } %>

    <form action="PaymentExcution.aspx">
        <input type="text" name="response"/>
    </form>
</body>
</html>
