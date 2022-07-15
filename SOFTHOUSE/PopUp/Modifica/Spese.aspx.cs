using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Popup_Modifica_ModificaSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDDLAz();
            CaricaDDLTipo();
        }
        SPESE sp = new SPESE();
        int codicespesa = int.Parse(Session["codicespesa"].ToString());

        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = sp.Select(codicespesa);

            txtData.Text = dt.Rows[0].Field<DateTime>("dataspesa").ToString("yyyy-MM-dd");
            txtImporto.Text = dt.Rows[0]["importo"].ToString();
            ddlAzienda.SelectedValue = dt.Rows[0]["codiceazienda"].ToString();
            ddlTipoSpesa.SelectedValue = dt.Rows[0]["codicetipospesa"].ToString();

        }
    }

    protected void CaricaDDLAz()
    {
        AZIENDE az = new AZIENDE();
        ddlAzienda.DataSource = az.Select();
        ddlAzienda.DataValueField = "codiceazienda";
        ddlAzienda.DataTextField = "ragionesociale";
        ddlAzienda.DataBind();
    }
    protected void CaricaDDLTipo()
    {
        TIPOLOGIESPESE ts = new TIPOLOGIESPESE();
        ddlTipoSpesa.DataSource = ts.Select();
        ddlTipoSpesa.DataValueField = "codicetipospesa";
        ddlTipoSpesa.DataTextField = "descrizionetipospesa";
        ddlTipoSpesa.DataBind();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {

        //controlli formali
        if (string.IsNullOrEmpty(txtData.Text) && string.IsNullOrEmpty(txtImporto.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Tutti i campi devono essere pieni')", true);
            return;
        }

        if (!decimal.TryParse(txtImporto.Text.Replace('.', ','), out decimal nuovoImporto))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }


        string nuovaData = txtData.Text.Trim();
        int lunghezzaStringa = nuovaData.Length;
        if (lunghezzaStringa > 10)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Formato data errato')", true);
            return;
        }


        int nuovoTipo = int.Parse(ddlTipoSpesa.SelectedValue);

        SPESE s = new SPESE();
        s.CodiceSpesa = int.Parse(Session["codicespesa"].ToString());
        s.Importo = nuovoImporto;

        s.DataSpesa = txtData.Text;
        s.CodiceTipoSpesa = nuovoTipo;

        s.CodiceAzienda = int.Parse(ddlAzienda.SelectedValue);
        s.CodiceTipoSpesa = int.Parse(ddlTipoSpesa.SelectedValue);
        s.Update();
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Modifica effettuata correttamente')", true);

        txtImporto.Text = "";
        txtData.Text = "";

    }
}