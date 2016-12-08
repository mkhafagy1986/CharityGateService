<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="CharityGateService.RegisterationPages.Registeration" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <% if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
    <% { %>
        برجاء إدخال إسم المؤسسه:<br/>
    <% } %>
    <% else if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
    <% { %>
        Please enter your organization name: <br/>
    <% } %>
     
    <form action="RegisterationSaveName.aspx">
        <input type="text" name="response"/>
    </form>
</body>
</html>
