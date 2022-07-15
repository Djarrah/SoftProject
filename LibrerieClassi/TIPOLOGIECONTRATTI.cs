using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Gestisce la Tabella TIPOLOGIECONTRATTI   
/// </summary>
public class TIPOLOGIECONTRATTI
{
    public int CodiceTipoContratto;
    public string DescrizioneTipoContratto;

    #region COSTRUTTORI

    public TIPOLOGIECONTRATTI() { }

    public TIPOLOGIECONTRATTI(string DescrizioneTipoContratto)
    { 
        this.DescrizioneTipoContratto = DescrizioneTipoContratto;
    }

    public TIPOLOGIECONTRATTI(int CodiceTipoContratto, string DescrizioneTipoContratto)
    {
        this.CodiceTipoContratto = CodiceTipoContratto;
        this.DescrizioneTipoContratto = DescrizioneTipoContratto;
    }

    #endregion

    #region SELETTORI

    /// <summary>
    /// Seleziona tutti i Record della Tabella
    /// </summary>
    /// <returns>Una tabella contenente i dati selezionati</returns>
    public DataTable Select()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand("TIPOLOGIECONTRATTI_SELECTALL");

        return c.EseguiSelect(cmd);
    }

    /// <summary>
    /// Seleziona un record dalla tabella col codice specificato
    /// </summary>
    /// <param name="CodiceTipoContratto">Il codice del record da selezionare</param>
    /// <returns>Una tabella contenente i dati del record selezionato</returns>
    public DataTable Select(int CodiceTipoContratto)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand("TIPOLOGIECONTRATTI_SELECTONE");
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);

        return c.EseguiSelect(cmd);

    }

    /// <summary>
    /// Controlla la ridondanza di un tipo contratto
    /// </summary>
    /// <returns>true se esiste già nel database, altrimenti false</returns>
    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand("TIPOLOGIECONTRATTI_CHECKONE");
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", DescrizioneTipoContratto);

        return c.EseguiSelect(cmd).Rows.Count > 0;
    }

    #endregion

    #region OPERATORI

    /// <summary>
    /// Inserisce un record nella tabella
    /// </summary>
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand("TIPOLOGIECONTRATTI_INSERT");
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", DescrizioneTipoContratto);

        c.EseguiCmd(cmd);
    }

    /// <summary>
    /// Aggiorna un record nella tabella
    /// </summary>
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand("TIPOLOGIECONTRATTI_UPDATE");
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", DescrizioneTipoContratto);

        c.EseguiCmd(cmd);
    }

    #endregion

}