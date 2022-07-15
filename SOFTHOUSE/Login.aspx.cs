using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // Controlli formali (magari con js?)
        if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Compilare tutti i campi')", true);
            return;
        }

        // Dichiarazione variabili
        string email = txtEmail.Text.Trim();
        string password = CRYPTA.Crypta(txtPassword.Text);

        UTENTI u = new UTENTI(email, password);

        // Controllo utente registrato
        if (!u.Registrato())
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Dati non validi')", true);
            return;
        }

        // Controllo Login
        if (!u.Login() || !u.Abilitato())
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Dati non validi')", true);
            return;
        }

        // Salvo il tipo utente nella Session
        Session["TipologiaUtente"] = u.RecuperaTipoUtente();

        // Reindirizzamento alla pagina principale
        Response.Redirect("Default.aspx");
    }
}