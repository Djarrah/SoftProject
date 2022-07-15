<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneCommesse.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <title>Gestione Commesse</title>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnInserisci').click(function () {
                var url = '/Popup/Inserisci/Commesse.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserimento dati',
                    height: 450,
                    resizable: false,
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
                var url = '/Popup/Modifica/Commesse.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Modifica dati',
                    height: 480,
                    resizable: false,
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

            $('#btnInserisciTipo').click(function () {
                var url = '/Popup/Inserisci/TipologieCommesse.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserimento dati',
                    resizable: false,
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

            $('#btnModificaTipo').click(function () {
                var url = '/Popup/Modifica/TipologieCommesse.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Modifica dati',
                    resizable: false,
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

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Gestione Commesse</h1>
    <div class="pulsanti">
        <asp:Button ID="btnInserisci" runat="server" ClientIDMode="Static" Text="Inserisci" CssClass="button" />
        <asp:Button ID="btnModifica" runat="server" ClientIDMode="Static" Enabled="False" Text="Modifica" CssClass="button" />
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" CssClass="button" OnClick="btnAggiorna_Click" />
    </div>

    <asp:GridView ID="grigliaCommesse" runat="server" CssClass="grid" DataKeyNames="CodiceCommessa" OnSelectedIndexChanged="grigliaCommesse_SelectedIndexChanged" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Azienda" HeaderText="Azienda"/>
            <asp:BoundField DataField="Cliente" HeaderText="Cliente"/>
            <asp:BoundField DataField="Tipologia" HeaderText="Tipologia"/>
            <asp:BoundField DataField="Data inizio" HeaderText="Data Inizio"/>
            <asp:BoundField DataField="Data Fine" HeaderText="Data Fine"/>
            <asp:BoundField DataField="Totale" HeaderText="Importo Totale"/>
            <asp:BoundField DataField="Importo Orario" HeaderText="Importo Orario"/>
            <asp:BoundField DataField="Importo Mensile" HeaderText="Importo Mensile"/>
            <asp:BoundField DataField="Importo Trasferta" HeaderText="Trasferte"/>
            <asp:BoundField DataField="Importo/Km" HeaderText="Importo/Km"/>
            <asp:BoundField DataField="Pasti" HeaderText="Pasti"/>
            <asp:BoundField DataField="Pernottamenti" HeaderText="Pernottamenti"/>
            <asp:BoundField DataField="Commessa Chiusa?" HeaderText="Chiusa?"/>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid"/>
    </asp:GridView>

    <h1>Tipologie Commesse</h1>
    <div class="pulsanti">
        <asp:Button ID="btnInserisciTipo" runat="server" ClientIDMode="Static" Text="Inserisci" CssClass="button" />
        <asp:Button ID="btnModificaTipo" runat="server" ClientIDMode="Static" Enabled="False" Text="Modifica" CssClass="button" />
    </div>

    <asp:GridView ID="grigliaTipi" runat="server" CssClass="grid" DataKeyNames="CodiceTipoCommessa" OnSelectedIndexChanged="grigliaTipi_SelectedIndexChanged" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="DescrizioneTipoCommessa" HeaderText="Descrizione"/>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid"/>
    </asp:GridView>
    
</asp:Content>