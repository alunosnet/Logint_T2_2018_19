<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="segura.aspx.cs" Inherits="LoginsT1.segura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Isto é uma página segura!</h1>
            <br />
            <asp:Button runat="server" ID="Button1" Text="Logout" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
