<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterationSaveContactNumber.aspx.cs" Inherits="CharityGateService.RegisterationPages.RegisterationSaveContactNumber" %>


<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
    <meta name="nav" content="end"/>
</head>
<body>
    <% if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
        سوف يقوم أحد ممثلى خدمة العملاء بالتواصل مع سيادتكم خلال 24 ساعه.<br/>
    <% } %>
    <% else if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
        Will a customer service representatives to communicate with you to within 24 hours. <br/>
    <% } %>
    <br/>
</body>
</html> 