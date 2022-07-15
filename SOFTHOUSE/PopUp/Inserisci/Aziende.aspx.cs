using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_InserisciPopUp_Aziende : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
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
        string ragSoc = txtRagioneSociale.Text.Trim();
        string piva = txtPIVA.Text.Trim();
        string indirizzo = txtIndirizzo.Text.Trim();
        string cap = txtCap.Text.Trim();
        string citta = txtCitta.Text.Trim();
        string provincia = txtProvincia.Text.Trim().ToUpper();

        AZIENDE a = new AZIENDE(ragSoc, piva, indirizzo, citta, cap, provincia);

        if (a.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Record Esistente')", true);
            return;
        }

        a.Insert();

        txtRagioneSociale.Text = String.Empty;
        txtPIVA.Text = String.Empty;
        txtIndirizzo.Text = String.Empty;
        txtCap.Text = String.Empty;
        txtCitta.Text = String.Empty;
        txtProvincia.Text = String.Empty;

        lbl.Text = "Record Inserito";
    }
}