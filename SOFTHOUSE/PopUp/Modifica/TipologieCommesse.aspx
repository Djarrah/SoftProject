<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TipologieCommesse.aspx.cs" Inherits="PopUp_ModificaPopUp_TipologieCommesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
        <div id="tabella" runat="server">
            <table>
                <tr>
                    <td>

                        <asp:TextBox ID="txtDescrizioneTipoCommessa" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
