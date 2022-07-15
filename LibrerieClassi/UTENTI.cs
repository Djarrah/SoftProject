using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per UTENTI
/// </summary>
public class UTENTI
{
    public int codUtente;
    public char tipologiaUtente;
    public int codicePersonale;
    public bool abilitato;
    public string email;
    public string password;

    #region COSTRUTTORI

    public UTENTI() { }

    public UTENTI(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    #endregion

    #region CONTROLLI

    public bool Registrato()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_REGISTRATO");
        cmd.Parameters.AddWithValue("@email", email);

        CONNESSIONE conn = new CONNESSIONE();
        DataTable dt = conn.EseguiSelect(cmd);

        return dt.Rows.Count > 0;
    }

    public bool Abilitato()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_ABILITATO");
        cmd.Parameters.AddWithValue("@email", email);

        CONNESSIONE conn = new CONNESSIONE();
        DataTable dt = conn.EseguiSelect(cmd);

        return dt.Rows.Count > 0;
    }

    public bool Login()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_LOGIN");
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@password", password);

        CONNESSIONE conn = new CONNESSIONE();
        DataTable dt = conn.EseguiSelect(cmd);

        return dt.Rows.Count > 0;
    }

    #endregion

    #region OPERAZIONI

    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_INSERT");
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@password", password);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    public void UpdatePWD()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_UPDATE_PASSWORD");
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@password", password);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    #endregion

    #region SELETTORI

    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_SELECTALL");
        CONNESSIONE C = new CONNESSIONE();

        return C.EseguiSelect(cmd);
    }

    public string RecuperaTipoUtente()
    {
        SqlCommand cmd = new SqlCommand("UTENTI_GETUSERTYPE");
        cmd.Parameters.AddWithValue("@email", email);

        CONNESSIONE conn = new CONNESSIONE();
        DataTable dt = conn.EseguiSelect(cmd);

        return dt.Rows[0]["TipologiaUtente"].ToString();
    }

    #endregion
}