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
        if ((!decimal.TryParse(txtImponibile.Text.Replace('.', ','), out decimal Imponibile) ||
            !decimal.TryParse(txtAliquota.Text.Replace('.', ','), out decimal Aliquota) 
           ))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Non valido')", true);
            return;
        }

        //Dichiarazione variabili
        int CodiceCommessa = int.Parse(ddlCodiceCommessa.SelectedValue);

    }
}