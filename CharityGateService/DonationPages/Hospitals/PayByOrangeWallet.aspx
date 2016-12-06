<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayByOrangeWallet.aspx.cs" Inherits="CharityGateService.DonationPages.Hospitals.PayByOrangeWallet" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    لتأكيد خصم <%= DonationAmount %> قيمة التبرع من حساب Orange wallet برجاء ادخال الرقم السري<br />
    <form action="PayByOrangeWalletHandel.aspx">
        <input type="text" name="response" />
    </form>
</body>
</html>
