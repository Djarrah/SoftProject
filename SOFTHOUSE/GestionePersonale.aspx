<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestionePersonale.aspx.cs" Inherits="Personale" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <title>Gestione Personale</title>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnInserisciPersonale').click(function () {
                var url = '/PopUp/Inserisci/Personale.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserimento dati',
                    resizable: false,
                    width: 250,
                    height: 520,
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

            $('#btnModificaPersonale').click(function () {
                var url = '/PopUp/Modifica/Personale.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Modifica dati',
                    resizable: false,
                    width: 250,
                    height: 520,
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

            $('#btnInserisciTipologieContratti').click(function () {
                var url = '/PopUp/Inserisci/TipologieContratti.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserimento dati',
                    resizable: false,
                    width: 250,
                    height: 150,
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

            $('#btnModificaTipologieContratti').click(function () {
                var url = '/PopUp/Modifica/TipologieContratti.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Modifica dati',
                    resizable: false,
                    width: 250,
                    height: 150,
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
    <h1>Gestione Personale</h1>
    <div class="pulsanti">
        <asp:Button ID="btnInserisciPersonale" runat="server" Text="Inserisci" ClientIDMode="Static" CssClass="button" />
        <asp:Button ID="btnModificaPersonale" runat="server" Text="Modifica" Enabled="False" ClientIDMode="Static" CssClass="button" />
        <asp:Button runat="server" Text="Aggiorna Griglia" ID="btnCaricaGriglia" OnClick="btnCaricaGriglia_Click" CssClass="button" />
    </div>

    <asp:GridView runat="server" ID="grigliaPersonale" AutoGenerateColumns="False" DataKeyNames="CodicePersonale" OnSelectedIndexChanged="grigliaPersonale_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="CodicePersonale" Visible="false" />
            <asp:BoundField DataField="Azienda" HeaderText="Azienda" />
            <asp:BoundField DataField="Contratto" HeaderText="Contratto" />
            <asp:BoundField DataField="Cognome" HeaderText="Cognome" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="RagioneSociale" HeaderText="Ragione Sociale" />
            <asp:BoundField DataField="CodiceFiscale" HeaderText="Codice Fiscale" />
            <asp:BoundField DataField="PartitaIva" HeaderText="Partita IVA" />
            <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo" />
            <asp:BoundField DataField="Citta" HeaderText="Città" />
            <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
            <asp:BoundField DataField="Cap" HeaderText="CAP" />
            <asp:BoundField DataField="DataNascita" HeaderText="Data di Nascita" />
            <asp:BoundField DataField="CostoMensile" HeaderText="Costo Mensile" />
            <asp:BoundField DataField="DataInizioCollaborazione" HeaderText="Inizio Collaborazione" />
            <asp:BoundField DataField="DataFineCollaborazione" HeaderText="Fine Collaborazione" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid" />

    </asp:GridView>

    <h1>Tipologie Contratti</h1>
    <div class="pulsanti">
        <asp:Button ID="btnInserisciTipologieContratti" runat="server" Text="Inserisci" ClientIDMode="Static" CssClass="button" />
        <asp:Button ID="btnModificaTipologieContratti" runat="server" Text="Modifica" Enabled="False" ClientIDMode="Static" CssClass="button" />
        <asp:Button runat="server" Text="Aggiorna Griglia" ID="Button1" OnClick="btnCaricaGriglia_Click" CssClass="button" />
    </div>

    <asp:GridView ID="grigliaTipologieContratti" runat="server" OnSelectedIndexChanged="grigliaTipologieContratti_SelectedIndexChanged" DataKeyNames="CodiceTipoContratto" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="CodiceTipoContratto" Visible="false" />
            <asp:BoundField DataField="DescrizioneTipoContratto" HeaderText="Descrizione" />
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid" />
    </asp:GridView>

</asp:Content>


