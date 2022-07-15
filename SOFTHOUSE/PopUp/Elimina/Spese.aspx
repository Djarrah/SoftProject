<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Spese.aspx.cs" Inherits="Popup_Elimina_EliminaSpese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sei sicuro/a di voler eliminare la spesa selezionata?<br />
            <asp:Button ID="btnElimina" runat="server" Text="Elimina" OnClick="btnElimina_Click" />
        </div>
    </form>
</body>
</html>
