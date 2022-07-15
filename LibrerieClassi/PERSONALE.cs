using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per PERSONALE
/// </summary>
public class PERSONALE
{
    public int CodicePersonale;
    public int CodiceAzienda;
    public int CodiceTipoContratto;
    public string RagioneSociale;
    public string Cognome;
    public string Nome;
    public string PartitaIva;
    public string CodiceFiscale;
    public string Indirizzo;
    public string Citta;
    public string Provincia;
    public string Cap;
    public string DataNascita;
    public decimal CostoMensile;
    public string DataInizioCollaborazione;
    public string DataFineCollaborazione;

    public PERSONALE()
    {
        
    }

    public PERSONALE(int CodicePersonale, int CodiceAzienda, int CodiceTipoContratto, string Cognome, string Nome, string RagioneSociale, string CodiceFiscale, string PartitaIva, string Indirizzo, string Citta, string Provincia, string Cap, string DataNascita, decimal CostoMensile, string DataInizioCollaborazione, string DataFineCollaborazione)
    {
        this.CodicePersonale = CodicePersonale;
        this.CodiceAzienda = CodiceAzienda;
        this.CodiceTipoContratto = CodiceTipoContratto;
        this.Cognome = Cognome;
        this.Nome = Nome;
        this.RagioneSociale = RagioneSociale;
        this.CodiceFiscale = CodiceFiscale;
        this.PartitaIva = PartitaIva;
        this.Indirizzo = Indirizzo;
        this.Citta = Citta;
        this.Provincia = Provincia;
        this.Cap = Cap;
        this.DataNascita = DataNascita;
        this.CostoMensile = CostoMensile;
        this.DataInizioCollaborazione = DataInizioCollaborazione;
        this.DataFineCollaborazione = DataFineCollaborazione;
    }

    public PERSONALE(int CodiceAzienda, int CodiceTipoContratto, string Cognome, string Nome, string RagioneSociale, string CodiceFiscale, string PartitaIva, string Indirizzo, string Citta, string Provincia, string Cap, string DataNascita, decimal CostoMensile, string DataInizioCollaborazione, string DataFineCollaborazione)
    {
        this.CodiceAzienda = CodiceAzienda;
        this.CodiceTipoContratto = CodiceTipoContratto;
        this.Cognome = Cognome;
        this.Nome = Nome;
        this.RagioneSociale = RagioneSociale;
        this.CodiceFiscale = CodiceFiscale;
        this.PartitaIva = PartitaIva;
        this.Indirizzo = Indirizzo;
        this.Citta = Citta;
        this.Provincia = Provincia;
        this.Cap = Cap;
        this.DataNascita = DataNascita;
        this.CostoMensile = CostoMensile;
        this.DataInizioCollaborazione = DataInizioCollaborazione;
        this.DataFineCollaborazione = DataFineCollaborazione;
    }


    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable Select(int CodicePersonale)
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_SELECTONE");

        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_INSERT");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
        cmd.Parameters.AddWithValue("@Cognome", Cognome);
        cmd.Parameters.AddWithValue("@Nome", Nome);
        cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        cmd.Parameters.AddWithValue("@Citta", Citta);
        cmd.Parameters.AddWithValue("@Provincia", Provincia);
        cmd.Parameters.AddWithValue("@Cap", Cap);
        cmd.Parameters.AddWithValue("@DataNascita", DataNascita);
        cmd.Parameters.AddWithValue("@CostoMensile", CostoMensile);
        cmd.Parameters.AddWithValue("@DataInizioCollaborazione", DataInizioCollaborazione);
        cmd.Parameters.AddWithValue("@DataFineCollaborazione", DataFineCollaborazione);


        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        string query = "PERSONALE_CHECKONE";
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        dt = c.EseguiSelect(cmd);


        return dt.Rows.Count > 0;
    }
public void Update()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_UPDATE");
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
        cmd.Parameters.AddWithValue("@Cognome", Cognome);
        cmd.Parameters.AddWithValue("@Nome", Nome);
        cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        cmd.Parameters.AddWithValue("@Citta", Citta);
        cmd.Parameters.AddWithValue("@Provincia", Provincia);
        cmd.Parameters.AddWithValue("@Cap", Cap);
        cmd.Parameters.AddWithValue("@DataNascita", DataNascita);
        cmd.Parameters.AddWithValue("@CostoMensile", CostoMensile);
        cmd.Parameters.AddWithValue("@DataInizioCollaborazione", DataInizioCollaborazione);
        cmd.Parameters.AddWithValue("@DataFineCollaborazione", DataFineCollaborazione);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
}