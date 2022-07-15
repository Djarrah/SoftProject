<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Clienti.aspx.cs" Inherits="PopUp_Inserisci_Clienti" %>

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
                        <asp:TextBox ID="txtRagioneSociale" runat="server" Placeholder="Ragione Sociale"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPartitaIva" runat="server" Placeholder="Partita Iva"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCodiceFiscale" runat="server" Placeholder="Codice Fiscale"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtIndirizzo" runat="server"  Placeholder="Indirizzo"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCap" runat="server" Placeholder="CAP"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCitta" runat="server" Placeholder="Città"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtProvincia" runat="server" Placeholder="Provincia"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
    </form>
</body>
</html>
