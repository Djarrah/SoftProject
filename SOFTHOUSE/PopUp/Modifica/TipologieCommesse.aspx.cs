using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_ModificaPopUp_TipologieCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Session["CodiceTipoCommessa"] == null)
            {
                lbl.Text = "ERRORE, selezionare una voce";
                tabella.Visible = false;

                return;
            }
            int cod = int.Parse(Session["CodiceTipoCommessa"].ToString());
            TIPOLOGIECOMMESSE tc = new TIPOLOGIECOMMESSE();
            DataRow sel = tc.Select(cod).Rows[0];
            txtDescrizioneTipoCommessa.Text = sel["DescrizioneTipoCommessa"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Se non vi è nessun elemento selezionato impedisco il proseguimento
        if (Session["CodiceTipoCommessa"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
            return;
        }
        //controlli formali
        if (string.IsNullOrEmpty(txtDescrizioneTipoCommessa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true);
            return;
        }
        string descrizione = txtDescrizioneTipoCommessa.Text.Trim();
        int codice = int.Parse(Session["CodiceTipoCommessa"].ToString());


        TIPOLOGIECOMMESSE tc = new TIPOLOGIECOMMESSE();
        tc.DescrizioneTipoCommessa= descrizione;
        tc.CodiceTipoCommessa= codice;

        if (tc.CheckOne()==true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        tc.Update();
        txtDescrizioneTipoCommessa.Text="";
        Session["CodiceTipoCommessa"]= null;
        lbl.Text="Dati Modificati";
    }
}