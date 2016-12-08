<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CharityGateService.Default" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
     <asp:Repeater ID="ServiceFunctionalitiesRepeater" runat="server">
        <ItemTemplate>
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                <a href='<%# Eval("ServicePageURL") %>'><%# Eval("ServiceFunctionalityArabicName") %></a><br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                <a href='<%# Eval("ServicePageURL") %>'><%# Eval("ServiceFunctionalityEnglishName") %></a><br />
            <% } %>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>


