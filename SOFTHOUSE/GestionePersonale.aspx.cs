using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Personale : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { CaricaGriglie(); }
    }

    protected void btnCaricaGriglia_Click(object sender, EventArgs e)
    {
        CaricaGriglie();
    }

    protected void grigliaPersonale_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodicePersonale"] = grigliaPersonale.SelectedDataKey[0];
        btnModificaPersonale.Enabled = true;
    }

    protected void CaricaGriglie()
    {
        PERSONALE p = new PERSONALE();

        grigliaPersonale.DataSource = p.Select();
        grigliaPersonale.DataBind();

        TIPOLOGIECONTRATTI t = new TIPOLOGIECONTRATTI();

        grigliaTipologieContratti.DataSource = t.Select();
        grigliaTipologieContratti.DataBind();
    }

    protected void grigliaTipologieContratti_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceTipoContratto"] = grigliaTipologieContratti.SelectedDataKey[0];
        btnModificaTipologieContratti.Enabled = true;
    }
}