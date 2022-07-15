using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Gestisce la Tabella AZIENDE
/// </summary>
public class AZIENDE
{
    public int CodiceAzienda;
    public string RagioneSociale;
    public string PartitaIva;
    public string Indirizzo;
    public string Citta;
    public string Cap;
    public string Provincia;

    #region COSTRUTTORI

    public AZIENDE() {}

    public AZIENDE(int CodiceAzienda) { this.CodiceAzienda = CodiceAzienda; }

    public AZIENDE(string RagioneSociale, string PartitaIva, string Indirizzo, string Citta, string Cap, string Provincia)
    {
        this.RagioneSociale = RagioneSociale;
        this.PartitaIva = PartitaIva;
        this.Indirizzo = Indirizzo;
        this.Citta = Citta;
        this.Cap = Cap;
        this.Provincia = Provincia;
    }

    public AZIENDE(int CodiceAzienda, string RagioneSociale, string PartitaIva, string Indirizzo, string Citta, string Cap, string Provincia)
    {
        this.CodiceAzienda = CodiceAzienda;
        this.RagioneSociale = RagioneSociale;
        this.PartitaIva = PartitaIva;
        this.Indirizzo = Indirizzo;
        this.Citta = Citta;
        this.Cap = Cap;
        this.Provincia = Provincia;
    }

    #endregion

    #region SELETTORI

    /// <summary>
    /// Seleziona tutti i record dalla tabella
    /// </summary>
    /// <returns>Una tabella contenente i dati selezionati</returns>
    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("AZIENDE_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    /// <summary>
    /// Seleziona un record col codice specificato
    /// </summary>
    /// <param name="CodiceAzienda">Il codice del record da selezionare</param>
    /// <returns>Una tabella contenente i dati del record selezionato</returns>
    public DataTable Select(int CodiceAzienda)
    {
        SqlCommand cmd = new SqlCommand("AZIENDE_SELECTONE");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    /// <summary>
    /// Controlla la ridondanza tra aziende
    /// </summary>
    /// <returns>true se esiste già una azienda con il nome indicato, altrimenti false</returns>
    public bool CheckOne()
    {
        SqlCommand cmd = new SqlCommand("AZIENDE_CHECKONE");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);

        CONNESSIONE c = new CONNESSIONE();
        return c.EseguiSelect(cmd).Rows.Count > 0;
    }

    #endregion

    #region OPERATORI

    /// <summary>
    /// Inserisce un record nella tabella
    /// </summary>
    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("AZIENDE_INSERT");
        cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        cmd.Parameters.AddWithValue("@Citta", Citta);
        cmd.Parameters.AddWithValue("@Cap", Cap);
        cmd.Parameters.AddWithValue("@Provincia", Provincia);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    /// <summary>
    /// Aggiorna un record nella tabella
    /// </summary>
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("AZIENDE_UPDATE");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        cmd.Parameters.AddWithValue("@Citta", Citta);
        cmd.Parameters.AddWithValue("@Cap", Cap);
        cmd.Parameters.AddWithValue("@Provincia", Provincia);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    #endregion
}