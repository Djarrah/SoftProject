using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Modifica_Personale : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodicePersonale"] == null)
            {
                lbl.Text = "ERRORE, Seleziona un campo da modificare";
                tabella.Visible = false;

                return;
            }

            AZIENDE A = new AZIENDE();
            ddlCodiceAzienda.DataSource = A.Select();
            ddlCodiceAzienda.DataTextField="RagioneSociale";
            ddlCodiceAzienda.DataValueField="CodiceAzienda";
            ddlCodiceAzienda.DataBind();

            TIPOLOGIECONTRATTI TC = new TIPOLOGIECONTRATTI();
            ddlCodiceTipoContratto.DataSource = TC.Select();
            ddlCodiceTipoContratto.DataValueField = "CodiceTipoContratto";
            ddlCodiceTipoContratto.DataTextField = "DescrizioneTipoContratto";
            ddlCodiceTipoContratto.DataBind();

            int cod = int.Parse(Session["CodicePersonale"].ToString());
            PERSONALE P = new PERSONALE();
            DataRow sel = P.Select(cod).Rows[0];
            ddlCodiceAzienda.SelectedValue = sel["CodiceAzienda"].ToString();
            ddlCodiceTipoContratto.SelectedValue = sel["CodiceTipoContratto"].ToString();
            txtCognome.Text = sel["Cognome"].ToString();
            txtNome.Text = sel["Nome"].ToString();
            txtRagioneSociale.Text = sel["RagioneSociale"].ToString();
            txtPartitaIva.Text = sel["PartitaIva"].ToString();
            txtCodiceFiscale.Text = sel["CodiceFiscale"].ToString();
            txtIndirizzo.Text = sel["Indirizzo"].ToString();
            txtCitta.Text = sel["Citta"].ToString();
            txtProvincia.Text = sel["Provincia"].ToString();
            txtCap.Text = sel["Cap"].ToString();
            txtDataNascita.Text = sel.Field<DateTime>("DataNascita").ToString("yyyy-MM-dd");
            txtCostoMensile.Text = sel["CostoMensile"].ToString();
            txtDataInizioCollab.Text = sel.Field<DateTime>("DataInizioCollaborazione").ToString("yyyy-MM-dd");
            txtDataFineCollab.Text = sel.Field<DateTime>("DataFineCollaborazione").ToString("yyyy-MM-dd");

            CambiaCampi();
        }
    }
    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Se non vi è nessun elemento selezionato impedisco il proseguimento
        if (Session["CodicePersonale"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Devi selezionare una riga per poterla modificare')", true);
            return;
        }

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

        if (
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

        // Dichiarazione variabili
        if (!decimal.TryParse(txtCostoMensile.Text.Replace('.', ','), out decimal CostoMensile))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Non valido')", true);
            return;
        }

        int cod = int.Parse(Session["CodicePersonale"].ToString());
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
            d.CodicePersonale = cod;
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

            d.Update();
        }
        else if (ddlCodiceTipoContratto.SelectedItem.Text == "Collaboratore P.IVA")
        {
            PARTITEIVA p = new PARTITEIVA();
            p.CodicePersonale = cod;
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

            p.Update();
        }

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

        Session["CodicePersonale"] = null;

        lbl.Text = "Record Modificato!";
    }
    protected void ddlCodiceTipoContratto_SelectedIndexChanged(object sender, EventArgs e)
    {
        CambiaCampi();
    }

    void CambiaCampi()
    {
        if (ddlCodiceTipoContratto.SelectedItem.Text == "Dipendente")
        {
            txtRagioneSociale.Visible = false;
            txtPartitaIva.Visible = false;

        }
        else if (ddlCodiceTipoContratto.SelectedItem.Text == "Collaboratore P.IVA")
        {
            txtRagioneSociale.Visible = true;
            txtPartitaIva.Visible = true;
        }
    }
}
