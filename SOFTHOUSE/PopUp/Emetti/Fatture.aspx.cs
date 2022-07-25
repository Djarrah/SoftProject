using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Emetti_Fatture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnConferma_Click(object sender, EventArgs e)
    {
        FATTURE F = new FATTURE();
        int CodiceCommessa = int.Parse(Session["CodiceCommessa"].ToString());
        F.CodiceCommessa = CodiceCommessa;
        F.Emetti();
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Fattura emessa con successo!')", true);
    }
}
