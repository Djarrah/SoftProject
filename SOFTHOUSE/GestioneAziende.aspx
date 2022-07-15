<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneAziende.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <title>Gestione Aziende</title>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnInserisci').click(function () {
                var url = '/PopUp/Inserisci/Aziende.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserimento dati',
                    resizable: false,
                    width: 250,
                    height: 280,
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
                var url = '/PopUp/Modifica/Aziende.aspx';
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Modifica dati',
                    resizable: false,
                    width: 250,
                    height: 280,
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

    <h1>Gestione Aziende</h1>
    <div class="pulsanti">
        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" ClientIDMode="Static" CssClass="button" />
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" Enabled="False" ClientIDMode="Static" CssClass="button" />
        <asp:Button runat="server" Text="Carica Griglia" ID="btnCaricaGriglia" OnClick="btnCaricaGriglia_Click" CssClass="button" />
    </div>

    <asp:GridView runat="server" ID="griglia" AutoGenerateColumns="False" DataKeyNames="CodiceAzienda" OnSelectedIndexChanged="griglia_SelectedIndexChanged" CssClass="table">
        <Columns>
            <asp:BoundField DataField="CodiceAzienda" Visible="false" />
            <asp:BoundField DataField="RagioneSociale" HeaderText="Ragione Sociale" />
            <asp:BoundField DataField="PartitaIva" HeaderText="P.IVA" />
            <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo" />
            <asp:BoundField DataField="Citta" HeaderText="Citta" />
            <asp:BoundField DataField="Cap" HeaderText="CAP" />
            <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid"/>
    </asp:GridView>

</asp:Content>

