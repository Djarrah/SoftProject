using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Popup_Elimina_EliminaSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        SPESE s = new SPESE();
        int codicespesa = int.Parse(Session["codicespesa"].ToString());
        s.CodiceSpesa = codicespesa;
        s.Delete();
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Eliminazione effettuata correttamente')", true);
    }
}