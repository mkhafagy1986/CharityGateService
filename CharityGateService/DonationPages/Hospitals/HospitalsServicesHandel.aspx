<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospitalsServicesHandel.aspx.cs" Inherits="CharityGateService.DonationPages.Hospitals.HospitalsServicesHandel" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>

    <asp:MultiView ID="FunctionalityViews" runat="server" ActiveViewIndex="0">
        <asp:View ID="PaymentView" runat="server">
            برجاء إدخال المبلغ المراد التبرع به.
            <br />
            يرجى إدخال رقم صحيح.<br />
            <form action="HospitalPaymentConfirmation.aspx">
                <input type="text" name="response" />
            </form>
        </asp:View>
        <asp:View ID="AboutView" runat="server">
            سوف يتم ارسال رساله بها معلومات عن المستشفي
        </asp:View>
        <asp:View ID="ContactUsView" runat="server">
            سوف يتم ارسال رساله بها معلومات التواصل للمستشفي
        </asp:View>
    </asp:MultiView>
</body>
</html>
