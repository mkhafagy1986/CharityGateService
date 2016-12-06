<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospitalPaymentConfirmation.aspx.cs" Inherits="CharityGateService.DonationPages.Hospitals.HospitalPaymentConfirmation" %>


<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    للتبرع بمبلغ <%= DonationAmount %>، برجاء إختيار وسيلة الدفع:<br/>
    <a href="PayByMobileBalance.aspx?donationamount=<%=DonationAmount %>">الخصم من الرصيد</a><br/>
    <a href="PayByOrangeWallet.aspx??donationamount=<%=DonationAmount %>">الخصم من رصيد Orange Wallet</a><br/>
</body>
</html>
