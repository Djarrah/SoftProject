<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneFatture.aspx.cs" Inherits="GestioneFatture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- ddl Anni -->
    <div>
        <h3>Seleziona Anno </h3>
        <asp:DropDownList ID="ddlAnno" runat="server" AutoPostBack="True">
        </asp:DropDownList>

        <!-- ddl Mesi -->

        <h3>Seleziona Mese </h3>
        <asp:DropDownList ID="ddlMese" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">Gennaio</asp:ListItem>
            <asp:ListItem Value="2">Febbraio</asp:ListItem>
            <asp:ListItem Value="3">Marzo</asp:ListItem>
            <asp:ListItem Value="4">Aprile</asp:ListItem>
            <asp:ListItem Value="5">Maggio</asp:ListItem>
            <asp:ListItem Value="6">Giugno</asp:ListItem>
            <asp:ListItem Value="7">Luglio</asp:ListItem>
            <asp:ListItem Value="8">Agosto</asp:ListItem>
            <asp:ListItem Value="9">Settembre</asp:ListItem>
            <asp:ListItem Value="10">Ottobre</asp:ListItem>
            <asp:ListItem Value="11">Novembre</asp:ListItem>
            <asp:ListItem Value="12">Dicembre</asp:ListItem>
        </asp:DropDownList>

        <!-- ddl Commesse -->

        <h3>Seleziona Commessa </h3>
        <asp:DropDownList ID="ddlCommessa" runat="server">
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
    </div>
    <div>
        <!-- Importo Totale ( a scelta da ddl) -->
        <asp:Label ID="lblImportoTotCorpo" runat="server" Text="Importo Commesse a Corpo:"></asp:Label>
        <asp:Label ID="lblImportoTotale" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <!-- Importo Totale ( a scelta da ddl) -->
        <asp:Label ID="lblImportoTotOre" runat="server" Text="Importo Commesse a Ore:"></asp:Label>
        <asp:Label ID="lblImpOre" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <!-- Importo Totale ( a scelta da ddl) -->
        <asp:Label ID="lblSommaLavori" runat="server" Text="Somma Lavori Totale:"></asp:Label>
        <asp:Label ID="lblSomLav" runat="server" Text=""></asp:Label>
    </div>
    <!--tabella delle fatture -->
    <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CodiceFattura" Visible="False" />
            <asp:BoundField DataField="Numero Fattura" />
            <asp:BoundField DataField="Data" />
            <asp:BoundField DataField="Imponibile" />
            <asp:BoundField DataField="Aliquota" />
            <asp:BoundField DataField="Commessa" />
            <asp:BoundField DataField="Tipo Commessa" />
            <asp:BoundField DataField="Azienda" />
            <asp:BoundField DataField="Cliente" />
            <asp:BoundField DataField="CommessaChiusa" HeaderText="Commessa Chiusa" />
        </Columns>
    </asp:GridView>

</asp:Content>

