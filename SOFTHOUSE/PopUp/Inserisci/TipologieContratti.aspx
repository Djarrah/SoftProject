﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TipologieContratti.aspx.cs" Inherits="PopUp_InserisciPopUp_TipologieContratti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:TextBox ID="txtTipologieContratti" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
        
        </div>
    </form>
</body>
</html>