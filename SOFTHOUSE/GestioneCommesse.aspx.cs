using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { CaricaGriglie(); }
    }

    protected void grigliaCommesse_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceCommessa"] = grigliaCommesse.SelectedDataKey[0];
        btnModifica.Enabled = true;
    }

    protected void btnAggiorna_Click(object sender, EventArgs e) { CaricaGriglie(); }

    protected void CaricaGriglie()
    {
        grigliaCommesse.DataSource = new COMMESSE().Select();
        grigliaCommesse.DataBind();

        grigliaTipi.DataSource = new TIPOLOGIECOMMESSE().Select();
        grigliaTipi.DataBind();
    }

    protected void grigliaTipi_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceTipoCommessa"] = grigliaTipi.SelectedDataKey[0];
        btnModificaTipo.Enabled = true;
    }
}