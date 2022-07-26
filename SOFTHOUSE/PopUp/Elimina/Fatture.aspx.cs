using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Elimina_Fatture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnElimina_Click(object sender, EventArgs e)
    {
        FATTURE F = new FATTURE();
        int CodiceFattura = int.Parse(Session["CodiceFattura"].ToString());
        F.CodiceFattura = CodiceFattura;
        F.Delete();
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Eliminazione avvenuta con successo')", true);
    }
}