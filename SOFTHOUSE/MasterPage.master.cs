using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string u = Session["TipologiaUtente"].ToString();
        string t = "";

        if (u == "S" || u == "A" || u == "O")
        {
            t += "<li><div class='dropdown'><button class='dropbtn'>Aziende</button><div class='dropdown-content'><a href='GestioneAziende.aspx'>Gestione Aziende</a></div></li>";
            t += "<li><div class='dropdown'><button class='dropbtn'>Personale</button><div class='dropdown-content'><a href='GestioneUtenti.aspx'>Gestione Utenti</a><a href='GestionePersonale.aspx'>Gestione Personale</a></div></div></li>";
            t += "<li><div class='dropdown'><button class='dropbtn'>Contabilità</button><div class='dropdown-content'><a href='Contabilita.aspx'>Resoconti e Previsioni</a><a href='http://google.it'>Spese del Personale</a><a href='GestioneSpese.aspx'>Gestione Spese Varie</a><a href='GestioneFatture.aspx'>Gestione Fatture</a><a href='GestioneClienti.aspx'>Gestione Clienti</a><a href='GestioneCommesse.aspx'>Gestione Commesse</a></div></div></li>";
        }
 
        t += "<li><div class='dropdown'> <button class='dropbtn'>Rapporti Lavorativi</button>  <div class='dropdown-content'><a href='GestioneLavori.aspx'>Gestione Rapporti</a> </div> </div> </li>";

        litBarra.Text = t;
    }
}


