<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterationSaveName.aspx.cs" Inherits="CharityGateService.RegisterationPages.RegisterationSaveName" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <% if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
        برجاء ادخال رقم التواصل:<br />
    <% } %>
    <% else if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
        Please enter the contact number: <br />
    <% } %>
    <form action="RegisterationSaveContactNumber.aspx">
        <input type="text" name="response" />
    </form>
</body>
</html>
