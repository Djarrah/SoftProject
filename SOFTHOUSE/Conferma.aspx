<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Conferma.aspx.cs" Inherits="Conferma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Vecchia password:</td>
                    <td>
                        <asp:TextBox ID="txtVecchiaPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nuova password:</td>
                    <td>
                        <asp:TextBox ID="txtNuovaPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Conferma password:</td>
                    <td>
                        <asp:TextBox ID="txtConfermaPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnModificaPassword" runat="server" Text="Modifica Password" OnClick="btnModificaPassword_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
