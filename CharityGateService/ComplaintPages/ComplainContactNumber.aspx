<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComplainContactNumber.aspx.cs" Inherits="CharityGateService.ComplaintPages.ComplainContactNumber" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
    <meta name="nav" content="end" />
</head>
<body>
    <% if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
        برجاء ادخال رقم التواصل.<br />
    <% } %>
    <% else if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
        Please enter the number of communication.<br />
    <% } %>

    <form action="ComplainHandel.aspx">
        <input type="text" name="response" />
    </form>
</body>
</html>
