<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneFatture.aspx.cs" Inherits="GestioneFatture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- ddl Anni -->
    <div>
            <h3>Seleziona Anno </h3>
            <asp:DropDownList ID="ddlAnno" runat="server">
            </asp:DropDownList>

            <!-- ddl Mesi -->

            <h3>Seleziona Mese </h3>
            <asp:DropDownList ID="ddlMese" runat="server">
            </asp:DropDownList>

            <!-- ddl Commesse -->

            <h3>Seleziona Commessa </h3>
            <asp:DropDownList ID="ddlCommessa" runat="server">
            </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnInvia" runat="server" Text="Invia" />
    </div>
     <div>
            <!-- Importo Totale ( a scelta da ddl) -->
            <asp:Label ID="lblImportoTot" runat="server" Text="Importo Totale:"></asp:Label>
            <asp:Label ID="lblImportoTotale" runat="server" Text=""></asp:Label>
        </div>
    <div>
            <!-- Importo Totale ( a scelta da ddl) -->
            <asp:Label ID="lblCostoLav" runat="server" Text="Costo Lavoratori:"></asp:Label>
            <asp:Label ID="lblCostoLavoratori" runat="server" Text=""></asp:Label>
        </div>
    <!--tabella delle fatture -->   
            <asp:GridView ID="giglia" runat="server"></asp:GridView>

</asp:Content>

