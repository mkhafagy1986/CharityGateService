<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complaint.aspx.cs" Inherits="CharityGate.Complaint" %>

<?xml version="1.0" encoding="UTF-8" ?>

<html>
<head>
</head>
<body>
    نوع الشكوي:<br />
    <a href="">شكوي خاصة بالخدمة.</a><br/>
    <a href="">شكوي خاصة بالتبرع.</a><br/>
    <form action="ComplaintsHandelling.aspx">
        <input type="text" name="response" />
    </form>
</body>
</html>