using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descrizione di riepilogo per TIPOLOGIESPESE
/// </summary>
public class TIPOLOGIESPESE
{
    public string DescrizioneTipoSpesa;
    public int CodiceTipoSpesa;
    public TIPOLOGIESPESE()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
    }
    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIESPESE_INSERT");
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", DescrizioneTipoSpesa);


        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIESPESE_UPDATE");
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", DescrizioneTipoSpesa);
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpesa);


        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIESPESE_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable Select(int CodiceTipoSpesa)
    {
        SqlCommand cmd = new SqlCommand("TIPOLOGIESPESE_SELECTONE");

        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpesa);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public bool CheckOne()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "TIPOLOGIESPESE_CHECKONE";
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", DescrizioneTipoSpesa);
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        dt = c.EseguiSelect(cmd);
        return dt.Rows.Count > 0;

    }

}