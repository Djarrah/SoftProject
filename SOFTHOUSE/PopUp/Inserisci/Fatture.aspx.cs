using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Inserisci_Fatture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        // Controlli Formali
        if (
            string.IsNullOrEmpty(txtImponibile.Text) ||
            string.IsNullOrEmpty(txtAliquota.Text)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }

        FATTURE F = new FATTURE();
        
        if (!decimal.TryParse(txtImponibile.Text.Replace('.', ','), out decimal Imponibile) ||
            !decimal.TryParse(txtAliquota.Text.Replace('.', ','), out decimal Aliquota) 
           )
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Non valido')", true);
            return;
        }

        if (F.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Record Esistente')", true);
            return;
        }

        F.Insert();

        txtImponibile.Text = String.Empty;
        txtAliquota.Text = String.Empty;

        lbl.Text = "Record Inserito";

    }
}