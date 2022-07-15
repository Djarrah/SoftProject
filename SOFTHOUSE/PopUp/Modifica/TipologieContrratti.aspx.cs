using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_ModificaPopUp_TipologieContrratti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        string descrizione = txtDescrizioneTipologieContratti.Text.Trim();
        int codice = int.Parse(Session["CodiceTipoContratto"].ToString());


        if (string.IsNullOrEmpty(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }


        TIPOLOGIECONTRATTI t = new TIPOLOGIECONTRATTI();
        t.DescrizioneTipoContratto= descrizione;
        t.CodiceTipoContratto= codice;

        if (t.CheckOne()==true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        t.Update();
        txtDescrizioneTipologieContratti.Text="";
        lblRes.Text="Dati Modificati";

    }
}