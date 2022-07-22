using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Modifica_Lavori : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Codicelavoro"] == null)
            {
                lbl.Text = "ERRORE, Seleziona un campo da modificare";
                tabella.Visible = false;

                return;
            }

            //richiamo tipo Personale
            PERSONALE P = new PERSONALE();
            ddlCodicePersonale.DataSource = P.SelectDdl();
            ddlCodicePersonale.DataTextField="CodicePersonale";
            ddlCodicePersonale.DataValueField="PERSONALEDDL";
            ddlCodicePersonale.DataBind();

            //Richiamo il tipo Commessa
            COMMESSE C = new COMMESSE();
            ddlCodiceCommessa.DataSource = C.Select();
            ddlCodiceCommessa.DataTextField="DescrizioneCommessa";
            ddlCodiceCommessa.DataValueField="CodiceCommessa";
            ddlCodiceCommessa.DataBind();

            
            int cod = int.Parse(Session["CodiceLavoro"].ToString());
            LAVORI L = new LAVORI();
            DataRow sel = L.Select(cod).Rows[0];
            txtDataLavoro.Text = sel["DataLavoro"].ToString();
            txtOreLavoro.Text = sel["OreLavoro"].ToString();
            txtKM.Text = sel["KM"].ToString();
            txtPasti.Text = sel["Pasti"].ToString();
            txtPernottamenti.Text = sel["Pernottamenti"].ToString();
            
        }
    }


    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (Session["CodiceLavoro"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Devi selezionare una riga per poterla modificare')", true);
            return;
        }

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
            !int.TryParse(txtKM.Text.Replace('.', ','), out int KM))
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Non valido')", true);
            return;
        }
        int cod = int.Parse(Session["CodiceLavoro"].ToString());
        int CodicePersonale = int.Parse(ddlCodicePersonale.SelectedValue);
        int CodiceCommessa = int.Parse(ddlCodiceCommessa.SelectedValue);

        LAVORI L = new LAVORI();
        L.Update();
        
        //svuoto i campi
        txtDataLavoro.Text = "";
        txtOreLavoro.Text= "";
        txtTrasferta.Text= "";
        txtKM.Text= "";
        txtPasti.Text= "";
        txtPernottamenti.Text="";

        lbl.Text= "Record Modificato!";
    }
}