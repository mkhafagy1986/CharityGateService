<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complaint.aspx.cs" Inherits="CharityGateService.ComplaintPages.Complaint" %>

<!DOCTYPE html>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    <asp:Repeater ID="SerComplaintTypeRepeater" runat="server">
        <ItemTemplate>
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                <a href='ComplainContactNumber.aspx?complaintype=<%# Eval("ComplaintTypeId") %>'><%# Eval("ComplaintTypeArabicName") %></a><br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                <a href='ComplainContactNumber.aspx?complaintype=<%# Eval("ComplaintTypeId") %>'><%# Eval("ComplaintTypeEnglishName") %></a><br />
            <% } %>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
