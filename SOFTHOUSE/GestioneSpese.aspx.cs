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
        CaricaGrigliaTipi();
        CaricaGrigliaSpese();
    }
    protected void CaricaGrigliaTipi()
    {

        TIPOLOGIESPESE TS = new TIPOLOGIESPESE();
        gridTipiSpese.DataSource = TS.Select();
        gridTipiSpese.DataBind();

    }
    protected void CaricaGrigliaSpese()
    {

        SPESE TS = new SPESE();
        gridSpese.DataSource = TS.Select();
        gridSpese.DataBind();

    }


    protected void gridSpese_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        GridViewRow riga = gridSpese.SelectedRow;
        Session["codicespesa"] = gridSpese.SelectedDataKey[0].ToString();
        btnModifica.Enabled = true;

    }
    protected void gridTipiSpese_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow riga = gridTipiSpese.SelectedRow;
        Session["CodiceTipologiaSpesa"] = gridTipiSpese.SelectedDataKey[0].ToString();
        btnModificaTipo.Enabled = true;
    }



    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGrigliaSpese();
        CaricaGrigliaTipi();
    }

}