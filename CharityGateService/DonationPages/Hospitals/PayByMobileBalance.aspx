<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayByMobileBalance.aspx.cs" Inherits="CharityGateService.DonationPages.Hospitals.PayByMobileBalance" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    لتأكيد خصم <%= DonationAmount %> قيمة التبرع من رصيدكم اضغط 1<br />
    <form action="PayByMobileBalanceHandel.aspx">
        <input type="text" name="response" />
    </form>
</body>
</html>
