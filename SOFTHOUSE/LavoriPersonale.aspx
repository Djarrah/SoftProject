<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LavoriPersonale.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <title>Gestione Lavori</title>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnInserisci').click(function () {
                var url = '/PopUp/Inserisci/LavoriPersonale.aspx';
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
                var url = '/PopUp/Modifica/LavoriPersonale.aspx';
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

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Gestione Lavori</h1>
    <div class="pulsanti">
        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" ClientIDMode="Static" CssClass="button" />
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" Enabled="False" ClientIDMode="Static" CssClass="button" />
        <asp:Button runat="server" Text="Aggiorna Griglia" ID="btnCaricaGriglia" OnClick="btnCaricaGriglia_Click" CssClass="button" />
    </div>

    <asp:GridView runat="server" ID="griglia" AutoGenerateColumns="False" DataKeyNames="CodiceLavoro" OnSelectedIndexChanged="griglia_SelectedIndexChanged" CssClass="table">
        <Columns>
            <asp:BoundField DataField="CodiceLavoro" Visible="false" />
            <asp:BoundField DataField="DescrizioneCommessa" HeaderText="Commessa" />
            <asp:BoundField DataField="DescrizioneTipoCommessa" HeaderText="Tipo Commessa" />
            <asp:BoundField DataField="DataInizioCommessa" HeaderText="Inizio Commessa" />
            <asp:BoundField DataField="DataFineCommessa" HeaderText="Fine Commessa" />
            <asp:BoundField DataField="DataLavoro" HeaderText="Data Lavoro" />
            <asp:BoundField DataField="OreLavoro" HeaderText="Ore" />
            <asp:BoundField DataField="Trasferta" HeaderText="Ore" />
            <asp:BoundField DataField="Km" HeaderText="Ore" />
            <asp:BoundField DataField="Pasti" HeaderText="Ore" />
            <asp:BoundField DataField="Pernottamenti" HeaderText="Ore" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="headergrid" />
        <SelectedRowStyle CssClass="selezionegrid"/>
    </asp:GridView>
</asp:Content>

