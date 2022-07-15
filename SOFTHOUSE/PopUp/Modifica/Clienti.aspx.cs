using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Modifica_Clienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodiceCliente"] == null)
            {
                lblRes.Text = "ERRORE, selezionare una voce";
                tabella.Visible = false;

                return;
            }

            int cod = int.Parse(Session["CodiceCliente"].ToString());
            CLIENTI c = new CLIENTI();
            DataRow sel = c.Select(cod).Rows[0];
            txtRagioneSociale.Text = sel["RagioneSociale"].ToString();
            txtPartitaIva.Text = sel["PartitaIva"].ToString();
            txtCodiceFiscale.Text = sel["CodiceFiscale"].ToString();
            txtIndirizzo.Text = sel["Indirizzo"].ToString();
            txtCap.Text = sel["Cap"].ToString();
            txtCitta.Text = sel["Citta"].ToString();
            txtProvincia.Text = sel["Provincia"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Se non vi è nessun elemento selezionato impedisco il proseguimento
        if (Session["CodiceCliente"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
            return;
        }


        if (string.IsNullOrEmpty(txtRagioneSociale.Text) ||
             string.IsNullOrEmpty(txtPartitaIva.Text) ||
             string.IsNullOrEmpty(txtCodiceFiscale.Text) ||
             string.IsNullOrEmpty(txtIndirizzo.Text) ||
             string.IsNullOrEmpty(txtCap.Text) ||
             string.IsNullOrEmpty(txtCitta.Text) ||
             string.IsNullOrEmpty(txtProvincia.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true); ;
            return;
        }

        CLIENTI C = new CLIENTI();
        C.CodiceCliente= int.Parse(Session["CodiceCliente"].ToString()); ;
        C.RagioneSociale = txtRagioneSociale.Text.Trim();
        C.PartitaIva = txtPartitaIva.Text.Trim();
        C.CodiceFiscale = txtCodiceFiscale.Text.Trim();
        C.Indirizzo = txtIndirizzo.Text.Trim();
        C.Cap = txtCap.Text.Trim();
        C.Citta = txtCitta.Text.Trim();
        C.Provincia = txtProvincia.Text.Trim();        

        if (C.CheckOne()==true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati già presenti')", true);
            return;
        }

        C.Update();
        txtRagioneSociale.Text="";
        txtPartitaIva.Text="";
        txtCodiceFiscale.Text="";
        txtIndirizzo.Text="";
        txtCap.Text="";
        txtCitta.Text="";
        txtProvincia.Text="";
        lblRes.Text="Record Modificato";
    }
}