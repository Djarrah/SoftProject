<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Clienti.aspx.cs" Inherits="PopUp_Modifica_Clienti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabella" runat="server">
            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
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
                <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" /><br />
                
            </div>
        </div>
    </form>
</body>
</html>
