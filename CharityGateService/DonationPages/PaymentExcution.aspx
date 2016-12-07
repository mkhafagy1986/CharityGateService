<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentExcution.aspx.cs" Inherits="CharityGateService.DonationPages.PaymentExcution" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
    <meta name="nav" content="end"/>
</head>
<body>

     <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
         شكرا لتبرعكم لصالح <%= OrganizationName %>

    <% } %>
    <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
             Thanks for donation for <%= OrganizationName %>
    <% } %>

   
    
</body>
</html>
