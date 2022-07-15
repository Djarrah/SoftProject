using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class CLIENTI
{
	public int CodiceCliente;
	public string RagioneSociale;
	public string PartitaIva;
	public string CodiceFiscale;
	public string Indirizzo;
	public string Cap;
	public string Citta;
	public string Provincia;

	public CLIENTI()
    {
       
    }

    public DataTable Select()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        string query = "CLIENTI_SELECTALL";
        cmd.CommandText = query;
        return c.EseguiSelect(cmd);
    }

    public DataTable Select(int CodiceCliente)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        string query = "CLIENTI_SELECTONE";
        cmd.CommandText=query;
        cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
        return c.EseguiSelect(cmd);
    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        string query = "CLIENTI_INSERT";
        cmd.CommandText=query;
        cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        cmd.Parameters.AddWithValue("@Cap", Cap);
        cmd.Parameters.AddWithValue("@Citta", Citta);
        cmd.Parameters.AddWithValue("@Provincia", Provincia);
        c.EseguiCmd(cmd);
    }

    public void Update()
    {
        CONNESSIONE C = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        string query = "CLIENTI_UPDATE";
        cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
        cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        cmd.Parameters.AddWithValue("@Cap", Cap);
        cmd.Parameters.AddWithValue("@Citta", Citta);
        cmd.Parameters.AddWithValue("@Provincia", Provincia);
        cmd.CommandText=query;
        C.EseguiCmd(cmd);
    }

    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        string query = "CLIENTI_CHECKONE";
        cmd.CommandText=query;
        cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        dt = c.EseguiSelect(cmd);

        return dt.Rows.Count > 0;
    }
}