<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Personale.aspx.cs" Inherits="PopUp_Modifica_Personale" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
        <div id="tabella" runat="server">
            <table> 
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCodiceAzienda" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCodiceTipoContratto" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCognome" runat="server" Placeholder="Cognome" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" Placeholder="Nome" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtRagioneSociale" runat="server" Placeholder="Ragione Sociale" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCodiceFiscale" runat="server" Placeholder="Codice Fiscale" MaxLength="16"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPartitaIva" runat="server" Placeholder="Partita IVA" MaxLength="11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtIndirizzo" runat="server" Placeholder="Indirizzo" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCitta" runat="server" Placeholder="Città" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtProvincia" runat="server" Placeholder="Provincia" MaxLength="2"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCap" runat="server" Placeholder="CAP" MaxLength="5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDataNascita" runat="server" Placeholder="Data Nascita" MaxLength="10" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCostoMensile" runat="server" Placeholder="Costo Mensile" MaxLength="9"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDataInizioCollab" runat="server" Placeholder="Data Inizio Collaborazione" MaxLength="10" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDataFineCollab" runat="server" Placeholder="Data Fine Collaborazione" MaxLength="2" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
