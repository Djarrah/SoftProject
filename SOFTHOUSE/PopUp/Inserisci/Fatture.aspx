<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Fatture.aspx.cs" Inherits="PopUp_Inserisci_Fatture" %>

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
                    <td>
                        <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCodiceCommessa" ToolTip="Commessa" runat="server"></asp:DropDownList><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="txtImponibile" PlaceHolder ="Imponibile" runat="server"></asp:DropDownList><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtAliquota" runat="server" PlaceHolder="Aliquota"></asp:TextBox><br />
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
