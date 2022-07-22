<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lavori.aspx.cs" Inherits="PopUp_Modifica_Lavori" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <div id="tabella" runat="server">
             <table>
                <tr>
                    <td>
                        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCodicePersonale" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCodiceCommessa" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDataLavoro" runat="server" Placeholder="Data Lavoro" MaxLength="10" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtOreLavoro" runat="server" Placeholder="Ore Lavoro" MaxLength="6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtTrasferta" runat="server" Placeholder="Trasferta" MaxLength="9"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKM" runat="server" Placeholder="km" MaxLength="9"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPasti" runat="server" Placeholder="Pasti" MaxLength="8"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPernottamenti" runat="server" Placeholder="Pernottamenti" MaxLength="8"></asp:TextBox>
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
