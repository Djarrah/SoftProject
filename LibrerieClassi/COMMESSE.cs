using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Gestisce le interazioni con la tabella COMMESSE
/// </summary>
public class COMMESSE
{
    public int CodiceCommessa;
    public int CodiceAzienda;
    public int CodiceCliente;
    public int CodiceTipoCommessa;
    public string DataInizioCommessa;
    public string DataFineCommessa;
    public decimal ImportoTotale;
    public decimal ImportoOrario;
    public decimal ImportoMensile;
    public decimal ImportoTrasferta;
    public decimal ImportoKm;
    public decimal ImportoPasti;
    public decimal ImportoPernottamenti;
    public bool CommessaChiusa;

    #region COSTRUTTORI

    public COMMESSE() { }

    public COMMESSE(int CodiceCommessa) { this.CodiceCommessa = CodiceCommessa;}

    public COMMESSE(
        int CodiceAzienda, int CodiceCliente, int CodiceTipoCommessa, string DataInizioCommessa, string DataFineCommessa,
        decimal ImportoTotale, decimal ImportoOrario, decimal ImportoMensile, decimal ImportoTrasferta,
        decimal ImportoKm, decimal ImportoPasti, decimal ImportoPernottamenti, bool CommessaChiusa
        )
    {
        this.CodiceAzienda = CodiceAzienda;
        this.CodiceCliente = CodiceCliente;
        this.CodiceTipoCommessa = CodiceTipoCommessa;
        this.DataInizioCommessa = DataInizioCommessa;
        this.DataFineCommessa = DataFineCommessa;
        this.ImportoTotale = ImportoTotale;
        this.ImportoOrario = ImportoOrario;
        this.ImportoMensile = ImportoMensile;
        this.ImportoTrasferta = ImportoTrasferta;
        this.ImportoKm = ImportoKm;
        this.ImportoPasti = ImportoPasti;
        this.ImportoPernottamenti = ImportoPernottamenti;
        this.CommessaChiusa = CommessaChiusa;
    }

    public COMMESSE(
        int CodiceCommessa, int CodiceAzienda, int CodiceCliente, int CodiceTipoCommessa, string DataInizioCommessa,
        string DataFineCommessa, decimal ImportoTotale, decimal ImportoOrario, decimal ImportoMensile, decimal ImportoTrasferta,
        decimal ImportoKm, decimal ImportoPasti, decimal ImportoPernottamenti, bool CommessaChiusa
        )
    {
        this.CodiceCommessa = CodiceCommessa;
        this.CodiceAzienda = CodiceAzienda;
        this.CodiceCliente = CodiceCliente;
        this.CodiceTipoCommessa = CodiceTipoCommessa;
        this.DataInizioCommessa = DataInizioCommessa;
        this.DataFineCommessa = DataFineCommessa;
        this.ImportoTotale = ImportoTotale;
        this.ImportoOrario = ImportoOrario;
        this.ImportoMensile = ImportoMensile;
        this.ImportoTrasferta = ImportoTrasferta;
        this.ImportoKm = ImportoKm;
        this.ImportoPasti = ImportoPasti;
        this.ImportoPernottamenti = ImportoPernottamenti;
        this.CommessaChiusa = CommessaChiusa;
    }

    #endregion

    #region SELETTORI

    /// <summary>
    /// Seleziona tutti i record dalla tabella
    /// </summary>
    /// <returns>Una tabella contenente i dati selezionati</returns>
    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("COMMESSE_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    /// <summary>
    /// Seleziona un record col codice specificato
    /// </summary>
    /// <param name="CodiceCommessa">Il codice del record da selezionare</param>
    /// <returns>Una tabella contenente i dati del record selezionato</returns>
    public DataTable Select(int CodiceCommessa)
    {
        SqlCommand cmd = new SqlCommand("COMMESSE_SELECTONE");
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    #endregion

    #region OPERATORI

    /// <summary>
    /// Inserisce un record nella tabella
    /// </summary>
    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("COMMESSE_INSERT");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);
        cmd.Parameters.AddWithValue("@DataInizioCommessa", DataInizioCommessa);
        cmd.Parameters.AddWithValue("@DataFineCommessa", DataFineCommessa);
        cmd.Parameters.AddWithValue("@ImportoTotale", ImportoTotale);
        cmd.Parameters.AddWithValue("@ImportoOrario", ImportoOrario);
        cmd.Parameters.AddWithValue("@ImportoMensile", ImportoMensile);
        cmd.Parameters.AddWithValue("@ImportoTrasferta", ImportoTrasferta);
        cmd.Parameters.AddWithValue("@ImportoKm", ImportoKm);
        cmd.Parameters.AddWithValue("@ImportoPasti", ImportoPasti);
        cmd.Parameters.AddWithValue("@ImportoPernottamenti", ImportoPernottamenti);
        cmd.Parameters.AddWithValue("@CommessaChiusa", CommessaChiusa);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    /// <summary>
    /// Aggiorna un record nella tabella
    /// </summary>
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("COMMESSE_UPDATE");
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);
        cmd.Parameters.AddWithValue("@DataInizioCommessa", DataInizioCommessa);
        cmd.Parameters.AddWithValue("@DataFineCommessa", DataFineCommessa);
        cmd.Parameters.AddWithValue("@ImportoTotale", ImportoTotale);
        cmd.Parameters.AddWithValue("@ImportoOrario", ImportoOrario);
        cmd.Parameters.AddWithValue("@ImportoMensile", ImportoMensile);
        cmd.Parameters.AddWithValue("@ImportoTrasferta", ImportoTrasferta);
        cmd.Parameters.AddWithValue("@ImportoKm", ImportoKm);
        cmd.Parameters.AddWithValue("@ImportoPasti", ImportoPasti);
        cmd.Parameters.AddWithValue("@ImportoPernottamenti", ImportoPernottamenti);
        cmd.Parameters.AddWithValue("@CommessaChiusa", CommessaChiusa);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    #endregion
}