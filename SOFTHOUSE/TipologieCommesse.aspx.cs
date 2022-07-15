using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TipologieCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void CaricaGriglia()
    {
        TIPOLOGIECOMMESSE tc = new TIPOLOGIECOMMESSE();
        griglia.DataSource=tc.Select();
        griglia.DataBind();
    }


    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceTipopologiaCommessa"]= griglia.SelectedDataKey[0];
        Modifica.Visible=true;
    }
}