using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

/// <summary>
/// Descrizione di riepilogo per MAIL
/// </summary>
public class MAIL
{
    SmtpClient client;
    
    public MAIL()
    {
        // Configurazione client
        client = new SmtpClient(K.host, K.porta);
        client.Credentials = new NetworkCredential(K.user, K.pw);
    }

    /// <summary>
    /// Invia una mail di registrazione all'indirizzo indicato
    /// </summary>
    /// <param name="email">L'indirizzo registrato</param>
    /// <param name="password">La password temporanea generata casualmente</param>
    public void InviaConfermaRegistrazione(string email, string password)
    {
        MailMessage m = new MailMessage("doita05@setsistemi.it", email);
        m.Subject = "Mail di conferma";
        m.IsBodyHtml = true;
        m.Body = $"Password Temporanea:{password}<br/>";
        m.Body += $"<a href='http://localhost:58524/Conferma.aspx?email={email}'>Cambiala qui!</a>";

        client.Send(m);
    }

}