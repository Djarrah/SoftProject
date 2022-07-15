<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneClienti.aspx.cs" Inherits="Clienti" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" runat="server" ID="Content2">
    <title>Gestione Clienti</title>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnInserisci').click(function () {
                var url = '/Popup/Inserisci/Clienti.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserimento dati',
                    resizable: false,
                    height:300,
                    overlay: {
                        opacity: 0.9,
                        background: 'black'
                    },

                    open: function (type, data) {
                        $(this).parent().appendTo('form');
                    }
                });

                return false;
            });

            $('#btnModifica').click(function () {
                var url = '/Popup/Modifica/Clienti.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Modifica dati',
                    resizable: false,
                    height: 300,
                    overlay: {
                        opacity: 0.9,
                        background: 'black'
                    },

                    open: function (type, data) {
                        $(this).parent().appendTo('form');
                    }
                });

                return false;
            });

        });
    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1>Gestione Clienti</h1>
    <div>
        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" ClientIDMode="Static" CssClass="button" />
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" ClientIDMode="Static" CssClass="button" Enabled="False" />
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna Griglia" ClientIDMode="Static" CssClass="button" />
    </div>

    <asp:GridView ID="griglia" runat="server" OnSelectedIndexChanged="griglia_SelectedIndexChanged" DataKeyNames="CodiceCliente" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="CodiceCliente" Visible="false" />
            <asp:BoundField DataField="RagioneSociale" HeaderText="RagioneSociale" />
            <asp:BoundField DataField="PartitaIva" HeaderText="PartitaIva" />
            <asp:BoundField DataField="CodiceFiscale" HeaderText="CodiceFiscale" />
            <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo" />
            <asp:BoundField DataField="Cap" HeaderText="Cap" />
            <asp:BoundField DataField="Citta" HeaderText="Città" />
            <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>

