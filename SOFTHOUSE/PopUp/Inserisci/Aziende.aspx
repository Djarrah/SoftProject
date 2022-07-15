<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Aziende.aspx.cs" Inherits="PopUp_InserisciPopUp_Aziende" %>

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
                    <td>
                        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtRagioneSociale" runat="server" Placeholder="Ragione Sociale" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPIVA" runat="server" Placeholder="P.IVA" MaxLength="11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtIndirizzo" runat="server" Placeholder="Indirizzo" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCap" runat="server" Placeholder="CAP" MaxLength="5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCitta" runat="server" Placeholder="Città" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtProvincia" runat="server" Placeholder="Pr." MaxLength="2"></asp:TextBox>
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
