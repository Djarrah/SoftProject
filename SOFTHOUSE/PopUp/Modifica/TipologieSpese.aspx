﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TipologieSpese.aspx.cs" Inherits="PopUp_Modifica_TipologieSpese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDescrizioneTipologieSpese" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" /><br />
            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
