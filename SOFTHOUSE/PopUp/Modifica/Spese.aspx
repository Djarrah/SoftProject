<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Spese.aspx.cs" Inherits="Popup_Modifica_ModificaSpese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <div id="tabella" runat="server">
            <table>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlAzienda" ToolTip="Azienda" runat="server"></asp:DropDownList><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlTipoSpesa" ToolTip="Tipo Spesa" runat="server"></asp:DropDownList><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtImporto" runat="server" PlaceHolder="Importo"></asp:TextBox><br />
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:TextBox ID="txtData" runat="server" ToolTip="Data" TextMode="Date"></asp:TextBox><br />
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Button ID="btnInserisci" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
