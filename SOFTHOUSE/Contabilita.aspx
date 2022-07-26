<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contabilita.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <title>Contabilità</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Contabilità</h1>

    Anno di riferimento:
    <asp:DropDownList ID="ddlAnno" runat="server"></asp:DropDownList>
    Mese di Riferimento:
    <asp:DropDownList ID="ddlMese" runat="server">
        <asp:ListItem Selected="True" Value="0">Nessuno</asp:ListItem>
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
    <asp:Button ID="btnCalcola" runat="server" Text="Calcola" OnClick="btnCalcola_Click" />
    <table>
        <tr>
            <th>Fatturato</th>
            <th>Spese Lavoratori</th>
            <th>Spese Varie</th>
            <th>Ricavo</th>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFatturato" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblSpeseLavoratori" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblSpeseVarie" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblRicavi" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

