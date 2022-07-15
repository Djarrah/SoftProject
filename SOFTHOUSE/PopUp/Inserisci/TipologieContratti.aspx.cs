using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_InserisciPopUp_TipologieContratti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipologieContratti.Text))
        {
            //verifico se ci sono dati
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true); 
            return;
        }
        TIPOLOGIECONTRATTI t = new TIPOLOGIECONTRATTI();
        t.DescrizioneTipoContratto=txtTipologieContratti.Text;

        if (t.CheckOne()==true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        t.Insert();
        lbl.Text = "Record Inserito";
        txtTipologieContratti.Text="";

    }
}