using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Inserisci_Lavori : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //richiamo tipo Personale
            PERSONALE P = new PERSONALE();
            ddlCodicePersonale.DataSource = P.SelectDdl();
            ddlCodicePersonale.DataTextField="PERSONALEDDL";
            ddlCodicePersonale.DataValueField="CodicePersonale";
            ddlCodicePersonale.DataBind();

            //Richiamo il tipo Commessa
            COMMESSE C = new COMMESSE();
            ddlCodiceCommessa.DataSource = C.Select();
            ddlCodiceCommessa.DataValueField="CodiceCommessa";
            ddlCodiceCommessa.DataTextField="Descrizione Commessa";
            ddlCodiceCommessa.DataBind();
        }
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        // Controlli Formali
        if (
            string.IsNullOrEmpty(txtDataLavoro.Text) ||
            string.IsNullOrEmpty(txtOreLavoro.Text) ||
            string.IsNullOrEmpty(txtTrasferta.Text) ||
            string.IsNullOrEmpty(txtKM.Text) ||
            string.IsNullOrEmpty(txtPasti.Text) ||
            string.IsNullOrEmpty(txtPernottamenti.Text) 
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }
        if ((!decimal.TryParse(txtOreLavoro.Text.Replace('.', ','), out decimal OreLavoro) ||
            !decimal.TryParse(txtTrasferta.Text.Replace('.', ','), out decimal Trasferta) ||
            !decimal.TryParse(txtPasti.Text.Replace('.', ','), out decimal Pasti) ||
            !decimal.TryParse(txtPernottamenti.Text.Replace('.', ','), out decimal Pernottamenti) ||
            !int.TryParse(txtKM.Text.Replace('.',','), out int KM))
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Non valido')", true);
            return;
        }

        //Dichiarazione variabili
        int CodicePersonale= int.Parse(ddlCodicePersonale.SelectedValue);
        int CodiceCommessa= int.Parse(ddlCodiceCommessa.SelectedValue);

        LAVORI L= new LAVORI();
        L.CodicePersonale = CodicePersonale;
        L.CodiceCommessa = CodiceCommessa;
        L.DataLavoro = txtDataLavoro.Text;
        L.OreLavoro = OreLavoro;
        L.Trasferta = Trasferta;
        L.Km = KM;
        L.Pasti = Pasti;
        L.Pernottamenti = Pernottamenti;

        L.Insert();

        txtDataLavoro.Text = "";
        txtOreLavoro.Text= "";
        txtTrasferta.Text= "";
        txtKM.Text= "";
        txtPasti.Text= "";
        txtPernottamenti.Text="";

        lbl.Text= "Record Inserito!";
    }

}