<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrazione.aspx.cs" Inherits="Registrazione" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnRegistrati" runat="server" Text="Registrati" OnClick="btnRegistrati_Click" />
                    </td>
                </tr>
            </table>
            <asp:Literal ID="litErrore" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
