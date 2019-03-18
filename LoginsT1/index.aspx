<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LoginsT1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email:<asp:TextBox ID="tbEmail" runat="server"></asp:TextBox><br />
            Palavra passe:<asp:TextBox ID="tbPassword" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
