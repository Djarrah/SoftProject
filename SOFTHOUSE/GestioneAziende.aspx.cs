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
        if (!IsPostBack)
        {
            CaricaGriglia();
        }

    }

    protected void btnCaricaGriglia_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceAzienda"] = griglia.SelectedDataKey[0];
        btnModifica.Enabled = true;
    }

    protected void CaricaGriglia()
    {
        AZIENDE a = new AZIENDE();

        griglia.DataSource = a.Select();
        griglia.DataBind();
    }
}