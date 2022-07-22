<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Commesse.aspx.cs" Inherits="Popup_Modifica_ModificaSpese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlAziende" ToolTip="Azienda" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlClienti"  ToolTip="Clienti" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlTipologieCommesse"  ToolTip="Tipo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipologieCommesse_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox ID="txtDescrizioneCommessa" runat="server" Placeholder="Descrizione Commessa" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtInizio" runat="server" Tooltip="Inizio" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtFine" runat="server" Tooltip="Fine" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtTotale" runat="server" Placeholder="Totale" MaxLength="9"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtOrario" runat="server" Placeholder="Importo Orario" MaxLength="6" Visible="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtMensile" runat="server" Placeholder="Importo Mensile" MaxLength="9"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtTrasferta" runat="server" Placeholder="Trasferte" MaxLength="7"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKm" runat="server" Placeholder="Importo/Km" MaxLength="6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPasti" runat="server" Placeholder="Importo/Km" MaxLength="6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPernottamenti" runat="server" Placeholder="Importo/Km" MaxLength="6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Commessa chiusa? <asp:CheckBox ID="cbxChiusa" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
    </form>
</body>
</html>
