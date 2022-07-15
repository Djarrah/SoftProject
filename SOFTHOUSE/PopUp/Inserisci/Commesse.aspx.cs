using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Inserisci_Clienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Carico DDL

            ddlAziende.DataSource = new AZIENDE().Select();
            ddlAziende.DataTextField = "RagioneSociale";
            ddlAziende.DataValueField = "CodiceAzienda";
            ddlAziende.DataBind();

            ddlClienti.DataSource = new CLIENTI().Select();
            ddlClienti.DataTextField = "RagioneSociale";
            ddlClienti.DataValueField = "CodiceCliente";
            ddlClienti.DataBind();

            ddlTipologieCommesse.DataSource = new TIPOLOGIECOMMESSE().Select();
            ddlTipologieCommesse.DataTextField = "DescrizioneTipoCommessa";
            ddlTipologieCommesse.DataValueField = "CodiceTipoCommessa";
            ddlTipologieCommesse.DataBind();
        }
    }
    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        // Controlli Formali

        if (
            string.IsNullOrEmpty(txtInizio.Text) ||
            string.IsNullOrEmpty(txtFine.Text) ||
            string.IsNullOrEmpty(txtTotale.Text) ||
            string.IsNullOrEmpty(txtTrasferta.Text) ||
            string.IsNullOrEmpty(txtKm.Text) ||
            string.IsNullOrEmpty(txtPasti.Text) ||
            string.IsNullOrEmpty(txtPernottamenti.Text)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi or')", true); ;
            return;
        }

        if (string.IsNullOrEmpty(txtOrario.Text) && string.IsNullOrEmpty(txtMensile.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi and')", true); ;
            return;
        }

        if (
            !decimal.TryParse(txtTotale.Text, out decimal totale) ||
            !decimal.TryParse(txtTrasferta.Text, out decimal trasferta) ||
            !decimal.TryParse(txtKm.Text, out decimal km) ||
            !decimal.TryParse(txtPasti.Text, out decimal pasti) ||
            !decimal.TryParse(txtPernottamenti.Text, out decimal pernottamenti)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi dec')", true); ;
            return;
        }

        decimal orario = 0;
        decimal mensile = 0;

        if (txtMensile.Visible)
        {
            if (!decimal.TryParse(txtMensile.Text, out mensile))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi dec')", true); ;
                return;
            }
        }
        else
        {
            if (!decimal.TryParse(txtOrario.Text, out orario))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi dec')", true); ;
                return;
            }
        }

        // Dichiarazione variabili rimanenti

        int codiceAzienda = int.Parse(ddlAziende.SelectedValue);
        int codiceCliente = int.Parse(ddlClienti.SelectedValue);
        int codiceTipoCommessa = int.Parse(ddlTipologieCommesse.SelectedValue);
        bool commessaChiusa = cbxChiusa.Checked;

        COMMESSE c = new COMMESSE(
            codiceAzienda, codiceCliente, codiceTipoCommessa, txtInizio.Text, txtFine.Text, totale,
            orario, mensile, trasferta, km, pasti, pernottamenti, commessaChiusa
            );

        // Inserimento
        c.Insert();
        lbl.Text = "Inserimento Effettuato";

        // Pulizia campi
        ddlAziende.SelectedIndex = 0;
        ddlClienti.SelectedIndex = 0;
        ddlTipologieCommesse.SelectedIndex = 0;
        txtInizio.Text = string.Empty;
        txtFine.Text = string.Empty;
        txtTotale.Text = string.Empty;
        txtOrario.Text = string.Empty;
        txtMensile.Text = string.Empty;
        txtTrasferta.Text = string.Empty;
        txtKm.Text = string.Empty;
        txtPasti.Text = string.Empty;
        txtPernottamenti.Text = string.Empty;
        cbxChiusa.Checked = false;
    }

    protected void ddlTipologieCommesse_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlTipologieCommesse.SelectedItem.Text == "A corpo")
        {
            txtMensile.Visible = true;
            txtOrario.Visible = false;
        }
        else if (ddlTipologieCommesse.SelectedItem.Text == "A ore")
        {
            txtMensile.Visible = false;
            txtOrario.Visible = true;
        }
    }
}