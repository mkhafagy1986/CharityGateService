<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CharityGateService.Account.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
                <LayoutTemplate>
                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="FailureText" />
                    </p>
                    <table>
                        <tr>
                            <td>
                                <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="UserName" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button runat="server" CommandName="Login" Text="Log in" />
                            </td>
                        </tr>
                    </table>

                   
                    

                </LayoutTemplate>
            </asp:Login>
        </div>
    </form>
</body>
</html>
