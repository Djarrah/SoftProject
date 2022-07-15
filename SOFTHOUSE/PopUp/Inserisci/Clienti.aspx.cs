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

    }
    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtRagioneSociale.Text) ||
             string.IsNullOrEmpty(txtPartitaIva.Text) ||
             string.IsNullOrEmpty(txtCodiceFiscale.Text) ||
             string.IsNullOrEmpty(txtIndirizzo.Text) ||
             string.IsNullOrEmpty(txtCap.Text) ||
             string.IsNullOrEmpty(txtCitta.Text) ||
             string.IsNullOrEmpty(txtProvincia.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true); ;
            return;
        }
       
        CLIENTI C = new CLIENTI();
        
        C.RagioneSociale = txtRagioneSociale.Text.Trim();
        C.PartitaIva = txtPartitaIva.Text.Trim();
        C.CodiceFiscale = txtCodiceFiscale.Text.Trim();
        C.Indirizzo = txtIndirizzo.Text.Trim();
        C.Cap = txtCap.Text.Trim();
        C.Citta = txtCitta.Text.Trim();
        C.Provincia = txtProvincia.Text.Trim();

        if (C.CheckOne()==true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        C.Insert();
        txtRagioneSociale.Text="";
        txtPartitaIva.Text="";
        txtCodiceFiscale.Text="";
        txtIndirizzo.Text="";
        txtCap.Text="";
        txtCitta.Text="";
        txtProvincia.Text="";
    }
}