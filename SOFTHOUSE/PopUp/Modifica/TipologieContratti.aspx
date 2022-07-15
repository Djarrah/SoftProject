<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TipologieContratti.aspx.cs" Inherits="PopUp_ModificaPopUp_TipologieContrratti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDescrizioneTipologieContratti" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" /><br />
            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
