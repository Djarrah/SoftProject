<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TipologieCommesse.aspx.cs" Inherits="TipologieCommesse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<script src="js/PopUpJS.js"></script>
    <div>
        <a href="PopUp/InserisciPopUp/TipologieCommesse.aspx" class="popup">Inserisci</a>
        <a ID="Modifica" href="PopUp/ModificaPopUp/TipologieCommesse.aspx" class="popup" Visible="false" runat="server">Modifica</a>
    </div>
    <div>
        <asp:GridView ID="griglia" runat="server" OnSelectedIndexChanged="griglia_SelectedIndexChanged" DataKeyNames="CodiceTipologiaCommessa" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CodiceTipoCommessa" Visible="false" />
                <asp:BoundField DataField="DescrizioneTipoCommessa" HeaderText="Descrizione" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>

        </asp:GridView>
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click" />
    </div>
</asp:Content>