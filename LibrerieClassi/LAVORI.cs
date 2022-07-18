using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descrizione di riepilogo per SPESE
/// </summary>
public class LAVORI
{
    public LAVORI()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
    }
    int CodiceLavoro;
    int CodicePersonale;
    int CodiceCommessa;
    string DataLavoro;
    decimal OreLavoro;
    decimal Trasferta;
    int Km;
    decimal Pasti;
    decimal Pernottamenti;




    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("LAVORI_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable Select(int CodiceLavoro)
    {
        SqlCommand cmd = new SqlCommand("LAVORI_SELECTONE");

        cmd.Parameters.AddWithValue("@CodiceLavoro", CodiceLavoro);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable SelectForPersonale(int CodicePersonale)
    {
        SqlCommand cmd = new SqlCommand("LAVORI_SELECTFORPERSONALE");
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("LAVORI_INSERT");
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@DataLavoro", DataLavoro);
        cmd.Parameters.AddWithValue("@OreLavoro", OreLavoro);
        cmd.Parameters.AddWithValue("@Trasferta", Trasferta);
        cmd.Parameters.AddWithValue("@Km", Km);
        cmd.Parameters.AddWithValue("@Pasti", Pasti);
        cmd.Parameters.AddWithValue("@Pernottamenti", Pernottamenti);
        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("LAVORI_UPDATE");
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@DataLavoro", DataLavoro);
        cmd.Parameters.AddWithValue("@OreLavoro", OreLavoro);
        cmd.Parameters.AddWithValue("@Trasferta", Trasferta);
        cmd.Parameters.AddWithValue("@Km", Km);
        cmd.Parameters.AddWithValue("@Pasti", Pasti);
        cmd.Parameters.AddWithValue("@Pernottamenti", Pernottamenti);
        cmd.Parameters.AddWithValue("@CodiceLavoro", CodiceLavoro);
        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
    public void Delete()
    {
        SqlCommand cmd = new SqlCommand("SPESE_DELETE");
        cmd.Parameters.AddWithValue("@CodiceLavoro", CodiceLavoro);
        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);


    }
}