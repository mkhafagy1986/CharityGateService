<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizationsItemsServicesHandel.aspx.cs" Inherits="CharityGateService.DonationPages.OrganizationsItemsServicesHandel" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>

    <asp:MultiView ID="FunctionalityViews" runat="server" ActiveViewIndex="0">
        <asp:View ID="PaymentView" runat="server">

            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                برجاء إدخال المبلغ المراد التبرع به .<br />
                يرجى إدخال رقم صحيح.<br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                Please enter the donation amount.<br/>
                Please enter an integer number.<br/>
            <% } %>

            <form action="OrganizationsItemsPaymentSelection.aspx">
                <input type="text" name="response" />
            </form>
        </asp:View>
        <asp:View ID="AboutView" runat="server">
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                سوف يتم ارسال رساله بها معلومات المطلوبة.<br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                We will send you SMS contains the required information.<br/>
            <% } %>
            
        </asp:View>
        <asp:View ID="ContactUsView" runat="server">
            
            <% if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic") %>
            <% { %>
                سوف يتم ارسال رساله بها معلومات التواصل.<br />
            <% } %>
            <% else if(System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")%>
            <% { %>
                    We will send you SMS contains the contact information.<br/>
            <% } %>
            
        </asp:View>
    </asp:MultiView>
</body>
</html>
