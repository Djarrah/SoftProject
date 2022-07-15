<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneUtenti.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <title>Gestione Utenti</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                <asp:Button runat="server" Text="Aggiorna Griglia" ID="btnAggiorna" OnClick="btnAggiorna_Click" />
            </td>
        </tr>
    </table>
    <asp:GridView runat="server" ID="griglia" AutoGenerateColumns="False" DataKeyNames="CodiceUtente">
        <Columns>
            <asp:BoundField DataField="CodiceUtente" Visible="False" />
            <asp:BoundField DataField="TipologiaUtente" HeaderText="Tipo Utente" />
            <asp:BoundField DataField="CodicePersonale" HeaderText="Codice Personale" />
            <asp:BoundField DataField="Abilitato" HeaderText="Abilitato" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
        </Columns>
    </asp:GridView>
</asp:Content>