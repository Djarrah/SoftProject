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

    <asp:GridView ID="grigliaCommesse" runat="server" CssClass="grid" DataKeyNames="CodiceCommessa" OnSelectedIndexChanged="grigliaCommesse_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="CodiceCommessa" Visible="False" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid"/>
    </asp:GridView>
</asp:Content>

