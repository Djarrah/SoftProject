using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_ModificaPopUp_Aziende : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodiceAzienda"] == null)
            {
                lbl.Text = "ERRORE, selezionare una voce";
                tabella.Visible = false;

                return;
            }

            int cod = int.Parse(Session["CodiceAzienda"].ToString());
            AZIENDE a = new AZIENDE();
            DataRow sel = a.Select(cod).Rows[0];
            txtRagioneSociale.Text = sel["RagioneSociale"].ToString();
            txtPIVA.Text = sel["PartitaIva"].ToString();
            txtIndirizzo.Text = sel["Indirizzo"].ToString();
            txtCap.Text = sel["Cap"].ToString();
            txtCitta.Text = sel["Citta"].ToString();
            txtProvincia.Text = sel["Provincia"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Se non vi è nessun elemento selezionato impedisco il proseguimento
        if (Session["CodiceAzienda"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
            return;
        }

        // Controlli Formali
        if (
            string.IsNullOrEmpty(txtRagioneSociale.Text) ||
            string.IsNullOrEmpty(txtPIVA.Text) ||
            string.IsNullOrEmpty(txtIndirizzo.Text) ||
            string.IsNullOrEmpty(txtCap.Text) ||
            string.IsNullOrEmpty(txtCitta.Text) ||
            string.IsNullOrEmpty(txtProvincia.Text)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }

        // Dichiarazione variabili
        int cod = int.Parse(Session["CodiceAzienda"].ToString());
        string ragSoc = txtRagioneSociale.Text.Trim();
        string piva = txtPIVA.Text.Trim();
        string indirizzo = txtIndirizzo.Text.Trim();
        string cap = txtCap.Text.Trim();
        string citta = txtCitta.Text.Trim();
        string provincia = txtProvincia.Text.Trim().ToUpper();

        AZIENDE a = new AZIENDE(cod, ragSoc, piva, indirizzo, citta, cap, provincia);

        if (a.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Record Esistente')", true);
            return;
        }

        a.Update();

        txtRagioneSociale.Text = String.Empty;
        txtPIVA.Text = String.Empty;
        txtIndirizzo.Text = String.Empty;
        txtCap.Text = String.Empty;
        txtCitta.Text = String.Empty;
        txtProvincia.Text = String.Empty;
        Session["CodiceAzienda"] = null;

        lbl.Text = "Record Modificato";
    }
}