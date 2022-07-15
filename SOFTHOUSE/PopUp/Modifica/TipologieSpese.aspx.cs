using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PopUp_Modifica_TipologieSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TIPOLOGIESPESE sp = new TIPOLOGIESPESE();
            int codice = int.Parse(Session["CodiceTipologiaSpesa"].ToString());

            DataTable dt = new DataTable();
            dt = sp.Select(codice);

            txtDescrizioneTipologieSpese.Text = dt.Rows[0]["descrizionetipospesa"].ToString();


        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        string descrizione = txtDescrizioneTipologieSpese.Text.Trim();

        int codice = int.Parse(Session["CodiceTipologiaSpesa"].ToString());

        if (string.IsNullOrEmpty(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }


        TIPOLOGIESPESE ts = new TIPOLOGIESPESE();
        ts.DescrizioneTipoSpesa = descrizione;
        ts.CodiceTipoSpesa = codice;

        if (ts.CheckOne() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        ts.Update();
        txtDescrizioneTipologieSpese.Text = "";
        lblRes.Text = "Dati Modificati";

    }
}