using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descrizione di riepilogo per SPESE
/// </summary>
public class FATTURE
{
    public FATTURE()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
    }
    public int Anno;
    public int Mese;
    public int AnnoInizio;
    public int AnnoFine;
    public int MeseInizio;
    public int MeseFine;
    public int CodiceCommessa;
    public decimal Imponibile;
    public int AliquotaIva;




    public DataTable Select(int anno)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECT");
        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", 0);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable Select(int anno, int mese)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECT");

        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", Mese);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectCommesse(int AnnoInizio, int AnnoFine, int MeseInizio, int MeseFine)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTCOMMESSE");

        cmd.Parameters.AddWithValue("@AnnoInizio", AnnoInizio);
        cmd.Parameters.AddWithValue("@AnnoFine", AnnoFine);
        cmd.Parameters.AddWithValue("@MeseInizio", MeseInizio);
        cmd.Parameters.AddWithValue("@MeseFine", MeseFine);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectLavori(int Anno, int Mese, int CodiceCommessa)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTCOMMESSE");

        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", Mese);
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectCorpo()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTCORPO");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectOre()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTORE");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public void Insert()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_INSERT");
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@Imponibile", Imponibile);
        cmd.Parameters.AddWithValue("@AliquotaIva", AliquotaIva);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }
    public void Update()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_UPDATE");
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@Imponibile", Imponibile);
        cmd.Parameters.AddWithValue("@AliquotaIva", AliquotaIva);
        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }

}