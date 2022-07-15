using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Conferma : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEmail.Text = Request.QueryString["email"].ToString();
    }

    protected void btnModificaPassword_Click(object sender, EventArgs e)
    {
        // Controlli Formali
        if (
            string.IsNullOrEmpty(txtVecchiaPassword.Text) ||
            string.IsNullOrEmpty(txtNuovaPassword.Text) ||
            string.IsNullOrEmpty(txtConfermaPassword.Text)
            )
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Dati non validi')", true);
            return;
        }

        // Controllo password uguali (js?)
        if (txtNuovaPassword.Text != txtConfermaPassword.Text)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Le password devono corrispondere')", true);
            return;
        }

        // Controllo login
        string email = txtEmail.Text.Trim();
        string vecchiaPassword = CRYPTA.Crypta(txtVecchiaPassword.Text);

        UTENTI u = new UTENTI(email, vecchiaPassword);

        if (!u.Login())
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Dati non validi')", true);
            return;
        }

        // Modifica password
        u.password = CRYPTA.Crypta(txtNuovaPassword.Text);
        u.UpdatePWD();

        ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Password modificata con successo!')", true);
        txtEmail.Text = "";
    }
}