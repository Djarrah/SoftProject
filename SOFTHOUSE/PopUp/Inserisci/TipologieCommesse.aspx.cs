using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_InserisciPopUp_TipologieCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        //controlli formaili
        if (string.IsNullOrEmpty(txtTipoCommessa.Text))
        {
            //verifico se ci sono dati
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }
        TIPOLOGIECOMMESSE tc = new TIPOLOGIECOMMESSE();
        tc.DescrizioneTipoCommessa=txtTipoCommessa.Text;


        if (tc.CheckOne()==true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }
        tc.Insert();

        txtTipoCommessa.Text="";
        lbl.Text="Record Inserito";
    }
}