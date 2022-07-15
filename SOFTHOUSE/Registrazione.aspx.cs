using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registrazione : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrati_Click(object sender, EventArgs e)
    {
        // Controlli Formali
        if (string.IsNullOrEmpty(txtEmail.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Dati non validi')", true);
            return;
        }

        // Dichiarazione variabili
        string email = txtEmail.Text.Trim();
        string pw = RandomString(8);
        string pwCriptata = CRYPTA.Crypta(pw);

        UTENTI u = new UTENTI(email, pwCriptata);

        // Controllo ridondanza
        if (u.Registrato())
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Dati non validi", "alert('Dati non validi')", true);
            return;
        }

        // Inserimento nel DB
        u.Insert();

        // Mando una mail con la password generata
        MAIL m = new MAIL();
        try
        {
            m.InviaConfermaRegistrazione(email, pw);
        }
        catch (Exception)
        {
            // Assolutamente non da fare in un sito serio, ma fastweb mi dà problemi, quindi uso questa soluzione temporanea
            litErrore.Text = $"È stato impossibile mandare una mail all'indirizzo specificato.<br/>";
            litErrore.Text += $"Password temporanea: {pw}<br/>";
            litErrore.Text += $"<a href='Conferma.aspx?email={email}'>Cambiala qui!<a/>";
            return;
        }        

        ScriptManager.RegisterClientScriptBlock(this, GetType(), "Conferma", "alert('Utente Registrato! Il tuo account verrà abilitato a breve. Controlla la tua mail per leggere cambiare la tua password temporanea!')", true);

        txtEmail.Text = "";
    }

    public static string RandomString(int length)
    {
        Random random = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        string s = "";
        for (int i = 0; i < length; i++) s += chars[random.Next(chars.Length)];

        return s;
    }
}