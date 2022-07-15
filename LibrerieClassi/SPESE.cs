using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descrizione di riepilogo per SPESE
/// </summary>
public class SPESE
{
    public SPESE()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
    }
    public int CodiceTipoSpesa;
    public int CodiceAzienda;
    public decimal Importo;
    public string DataSpesa;
    public int CodiceSpesa;


    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("SPESE_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable Select(int CodiceSpesa)
    {
        SqlCommand cmd = new SqlCommand("SPESE_SELECTONE");

        cmd.Parameters.AddWithValue("@CodiceSpesa", CodiceSpesa);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("SPESE_INSERT");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpesa);
        cmd.Parameters.AddWithValue("@Importo", Importo);
        cmd.Parameters.AddWithValue("@DataSpesa", DataSpesa);


        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("SPESE_UPDATE");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpesa);
        cmd.Parameters.AddWithValue("@Importo", Importo);
        cmd.Parameters.AddWithValue("@DataSpesa", DataSpesa);
        cmd.Parameters.AddWithValue("@CodiceSpesa", CodiceSpesa);


        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
    public void Delete()
    {
        SqlCommand cmd = new SqlCommand("SPESE_DELETE");
        cmd.Parameters.AddWithValue("@CodiceSpesa", CodiceSpesa);
        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);


    }
}