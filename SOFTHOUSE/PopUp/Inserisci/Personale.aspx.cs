using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Inserisci_Personale : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AZIENDE A = new AZIENDE();
            ddlCodiceAzienda.DataSource = A.Select();
            ddlCodiceAzienda.DataTextField = "RagioneSociale";
            ddlCodiceAzienda.DataValueField = "CodiceAzienda";
            ddlCodiceAzienda.DataBind();
        }

        if (!IsPostBack)
        {
            TIPOLOGIECONTRATTI TC = new TIPOLOGIECONTRATTI();
            ddlCodiceTipoContratto.DataSource = TC.Select();
            ddlCodiceTipoContratto.DataValueField = "CodiceTipoContratto";
            ddlCodiceTipoContratto.DataTextField = "DescrizioneTipoContratto";
            ddlCodiceTipoContratto.DataBind();
        }
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        // Controlli Formali
        if (
            string.IsNullOrEmpty(txtIndirizzo.Text) ||
            string.IsNullOrEmpty(txtCitta.Text) ||
            string.IsNullOrEmpty(txtProvincia.Text) ||
            string.IsNullOrEmpty(txtCap.Text) ||
            string.IsNullOrEmpty(txtDataNascita.Text) ||
            string.IsNullOrEmpty(txtCostoMensile.Text) ||
            string.IsNullOrEmpty(txtDataInizioCollab.Text) ||
            string.IsNullOrEmpty(txtDataFineCollab.Text)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }

        if(
            (string.IsNullOrEmpty(txtCognome.Text) || string.IsNullOrEmpty(txtNome.Text))
            &&
            string.IsNullOrEmpty(txtRagioneSociale.Text)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }

        if (string.IsNullOrEmpty(txtCodiceFiscale.Text) && string.IsNullOrEmpty(txtPartitaIva.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }

        if (!decimal.TryParse(txtCostoMensile.Text.Replace('.', ','), out decimal CostoMensile))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Non valido')", true);
            return;
        }

        // Dichiarazione variabili
        int CodiceAzienda = int.Parse(ddlCodiceAzienda.SelectedValue);
        int CodiceTipoContratto = int.Parse(ddlCodiceTipoContratto.SelectedValue);
        string Cognome = txtCognome.Text.Trim();
        string Nome = txtNome.Text.Trim();
        string RagioneSociale = txtRagioneSociale.Text.Trim();
        string CodiceFiscale = txtCodiceFiscale.Text.Trim();
        string PartitaIva = txtPartitaIva.Text.Trim();
        string Indirizzo = txtIndirizzo.Text.Trim();
        string Citta = txtCitta.Text.Trim();
        string Provincia = txtProvincia.Text.Trim().ToUpper();
        string Cap = txtCap.Text.Trim();
        string DataNascita = txtDataNascita.Text.Trim();
        string DataInizioCollab = txtDataInizioCollab.Text.Trim();
        string DataFineCollab = txtDataFineCollab.Text.Trim();

        if (ddlCodiceTipoContratto.SelectedItem.Text == "Dipendente")
        {
            DIPENDENTI d = new DIPENDENTI();
            d.CodiceAzienda = CodiceAzienda;
            d.CodiceTipoContratto = CodiceTipoContratto;
            d.Cognome = Cognome;
            d.Nome = Nome;
            d.CodiceFiscale = CodiceFiscale;
            d.Indirizzo = Indirizzo;
            d.Citta = Citta;
            d.Provincia = Provincia;
            d.Cap = Cap;
            d.DataNascita = DataNascita;
            d.DataInizioCollaborazione = DataInizioCollab;
            d.DataFineCollaborazione = DataFineCollab;
            d.CostoMensile = CostoMensile;

            if (d.CheckOne())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Già Esistente')", true);
                return;
            }

            d.Insert();
        }
        else if (ddlCodiceTipoContratto.SelectedItem.Text == "Collaboratore P.IVA")
        {
            PARTITEIVA p = new PARTITEIVA();
            p.CodiceAzienda = CodiceAzienda;
            p.CodiceTipoContratto = CodiceTipoContratto;
            p.RagioneSociale = RagioneSociale;
            p.Cognome = Cognome;
            p.Nome = Nome;
            p.PartitaIva = PartitaIva;
            p.CodiceFiscale = CodiceFiscale;
            p.Indirizzo = Indirizzo;
            p.Citta = Citta;
            p.Provincia = Provincia;
            p.Cap = Cap;
            p.DataNascita = DataNascita;
            p.DataInizioCollaborazione = DataInizioCollab;
            p.DataFineCollaborazione = DataFineCollab;
            p.CostoMensile = CostoMensile;

            if (p.CheckOne())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Già Esistente')", true);
                return;
            }

            p.Insert();
        }

        //PERSONALE P = new PERSONALE(CodiceAzienda, CodiceTipoContratto, Cognome, Nome, RagioneSociale, CodiceFiscale, PartitaIva, Indirizzo, Citta, Provincia, Cap, DataNascita, CostoMensile, DataInizioCollab, DataFineCollab);
        //if (P.CheckOne())
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Già Esistente')", true);
        //    return;
        //}

        //P.Insert();

        txtCognome.Text = String.Empty;
        txtNome.Text = String.Empty;
        txtRagioneSociale.Text = String.Empty;
        txtCodiceFiscale.Text = String.Empty;
        txtPartitaIva.Text = String.Empty;
        txtIndirizzo.Text = String.Empty;
        txtCitta.Text = String.Empty;
        txtProvincia.Text = String.Empty;
        txtCap.Text = String.Empty;
        txtDataNascita.Text = String.Empty;
        txtCostoMensile.Text = String.Empty;
        txtDataInizioCollab.Text = String.Empty;
        txtDataFineCollab.Text = String.Empty;

        lbl.Text = "Record Inserito!";
    }

    protected void ddlCodiceTipoContratto_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCodiceTipoContratto.SelectedItem.Text=="Dipendente")
        {
            txtRagioneSociale.Visible = false;
            txtPartitaIva.Visible=false;
           
        }
        else if (ddlCodiceTipoContratto.SelectedItem.Text=="Collaboratore P.IVA")
        {
            txtRagioneSociale.Visible = true;
            txtPartitaIva.Visible = true;
        }
        else
        {
            lbl.Text = "ERRORE";
        }
    }
}