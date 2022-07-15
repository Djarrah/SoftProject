<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <title>Gestione Spese</title>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnInserisci').click(function () {
                var url = '/Popup/Inserisci/Spese.aspx';
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
                var url = '/Popup/Modifica/Spese.aspx';
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

            $('#btnElimina').click(function () {
                var url = '/Popup/Elimina/Spese.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Cancellazione dati',
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
                var url = '/Popup/Inserisci/TipologieSpese.aspx';
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
                var url = '/Popup/Modifica/TipologieSpese.aspx';
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



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="spese">
        <h1>Gestione Spese</h1>
        <div>
            <asp:Button ID="btnInserisci" runat="server" ClientIDMode="Static" Text="Inserisci" CssClass="button" />
            <asp:Button ID="btnModifica" runat="server" ClientIDMode="Static" Enabled="False" Text="Modifica" CssClass="button" />
            <asp:Button ID="btnElimina" runat="server" ClientIDMode="Static" Text="Elimina" CssClass="button" />
        </div>

        <asp:GridView ID="gridSpese" runat="server" DataKeyNames="CodiceSpesa" AutoGenerateColumns="false" OnSelectedIndexChanged="gridSpese_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="CodiceSpesa" Visible="false" />
                <asp:BoundField DataField="RagioneSociale" HeaderText="Azienda" />
                <asp:BoundField DataField="DescrizioneTipoSpesa" HeaderText="Tipo" />
                <asp:BoundField DataField="Importo" HeaderText="Importo" />
                <asp:BoundField DataField="DataSpesa" HeaderText="Data" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </div>

    <div id="tipispese">
        <h1>Gestione Tipi Spese</h1>
        <div>
            <asp:Button ID="btnInserisciTipo" runat="server" ClientIDMode="Static" Text="Inserisci" CssClass="button" />
            <asp:Button ID="btnModificaTipo" runat="server" ClientIDMode="Static" Enabled="False" Text="Modifica" CssClass="button" />
        </div>

        <asp:GridView ID="gridTipiSpese" runat="server" DataKeyNames="CodiceTipoSpesa" AutoGenerateColumns="false" OnSelectedIndexChanged="gridTipiSpese_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="CodiceTipoSpesa" Visible="false" />
                <asp:BoundField DataField="DescrizioneTipoSpesa" HeaderText="Descrizione" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click" CssClass="button" />
    </div>

</asp:Content>

