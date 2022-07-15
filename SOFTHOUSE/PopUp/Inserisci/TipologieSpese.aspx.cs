using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_InserisciPopUp_TipologieSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipologieSpese.Text))
        {
            //verifico se ci sono dati
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }
        TIPOLOGIESPESE ts = new TIPOLOGIESPESE();
        ts.DescrizioneTipoSpesa = txtTipologieSpese.Text;

        if (ts.CheckOne() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        ts.Insert();
        lbl.Text = "Record Inserito";
        txtTipologieSpese.Text = "";

    }
}
