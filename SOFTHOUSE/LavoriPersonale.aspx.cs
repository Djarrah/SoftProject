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
        Session["CodiceLavoro"] = griglia.SelectedDataKey[0];
        btnModifica.Enabled = true;
    }

    protected void CaricaGriglia()
    {
        LAVORI l = new LAVORI();

        int codicePersonale = int.Parse(Session["codicePersonale"].ToString());
        griglia.DataSource = l.SelectForPersonale(codicePersonale);
        griglia.DataBind();
    }
}