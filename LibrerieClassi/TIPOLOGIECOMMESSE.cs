using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Gestisce la tabella TIPOLOGIECOMMESSE
/// </summary>
public class TIPOLOGIECOMMESSE
{
    public string DescrizioneTipoCommessa;
    public int CodiceTipoCommessa;

    #region COSTRUTTORI

    public TIPOLOGIECOMMESSE() { }

    public TIPOLOGIECOMMESSE(int CodiceTipoCommessa)
    {
        this.CodiceTipoCommessa = CodiceTipoCommessa;
    }

    public TIPOLOGIECOMMESSE(string DescrizioneTipoCommessa)
    {
        this.DescrizioneTipoCommessa=DescrizioneTipoCommessa;
    }

    #endregion

    #region SELETTORI

    /// <summary>
    /// Seleziona tutti i record dalla Tabella 
    /// </summary>
    /// <returns>Una tabella contenente i dati selezionati</returns>
    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIECOMMESSE_SELECTALL");
        CONNESSIONE conn = new CONNESSIONE();

        return conn.EseguiSelect(cmd);
    }

    /// <summary>
    /// Seleziona un record dalla tabella col codice fornito
    /// </summary>
    /// <param name="CodiceTipoCommessa">Il codice del record da seleizonare</param>
    /// <returns>Una tabella con i dati del record da selezionare</returns>
    public DataTable Select(int CodiceTipoCommessa)
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIECOMMESSE_SELECTONE");
        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    /// <summary>
    /// Controlla la ridondanza tra tipologie commesse
    /// </summary>
    /// <returns>true se esiste già un tipo commessa con il nome indicato, altrimenti false</returns>
    public bool CheckOne()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIECOMMESSE_CHECKONE");
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", DescrizioneTipoCommessa);

        CONNESSIONE c = new CONNESSIONE();
        return c.EseguiSelect(cmd).Rows.Count > 0;
    }

    #endregion

    #region OPERATORI

    /// <summary>
    /// Inserisce un record nel Database
    /// </summary>
    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIECOMMESSE_INSERT");
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", DescrizioneTipoCommessa);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    /// <summary>
    /// Aggiorna un record nel database
    /// </summary>
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIECOMMESSE_UPDATE");
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", DescrizioneTipoCommessa);
        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    #endregion

}