using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopUp_Modifica_Fatture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodiceCommessa"] == null)
            {
                lbl.Text = "ERRORE, selezionare una voce";
                tabella.Visible = false;

                return;
            }

            int cod = int.Parse(Session["CodiceCommessa"].ToString());
            FATTURE F = new FATTURE();
            DataRow sel = F.Select(cod).Rows[0];
            txtImponibile.Text = sel["Imponibile"].ToString();
            txtAliquota.Text = sel["Aliquota"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Se non vi è nessun elemento selezionato impedisco il proseguimento
        if (Session["CodiceCommessa"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
            return;
        }


        if (string.IsNullOrEmpty(txtImponibile.Text) ||
             string.IsNullOrEmpty(txtAliquota.Text)
           )

        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non Validi')", true); ;
            return;
        }
       
    }
}