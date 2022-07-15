using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Popup_Inserisci_InserisciSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDDLAz();
            CaricaDDLTipo();
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

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtImporto.Text) || string.IsNullOrEmpty(txtData.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Tutti i campi devono essere pieni')", true);
            return;
        }

        if(!decimal.TryParse(txtImporto.Text.Replace('.',','), out decimal importo)) {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        string dataspesa = txtData.Text;
        int codicetipospesa = int.Parse(ddlTipoSpesa.SelectedValue.ToString());
        int codiceazienda = int.Parse(ddlAzienda.SelectedValue.ToString());

        SPESE sp = new SPESE();
        sp.Importo = importo;
        sp.DataSpesa = dataspesa;
        sp.CodiceTipoSpesa = codicetipospesa;
        sp.CodiceAzienda = codiceazienda;
        sp.Insert();

        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Inserimento effettuato correttamente')", true);
        txtImporto.Text = "";
        txtData.Text = "";
    }
}