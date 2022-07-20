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
    public int CodiceCommessa;
    public decimal Imponibile;
    public int AliquotaIva;
    public int Giorno = 15;
    public int CodiceFattura;
    public string NumeroFattura;
    public decimal Importo;

    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTALL");
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable SelectOne(int CodiceFattura)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTONE");
        cmd.Parameters.AddWithValue("@CodiceFattura", CodiceFattura);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable Select(int Anno)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECT");
        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", 0);

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable Select(int Anno, int Mese)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECT");

        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", Mese);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectCommesse(int Anno, int Mese)
    {
        SqlCommand cmd = new SqlCommand("COMMESSE_SELECT");
        DateTime Data = new DateTime(Anno, Mese, Giorno);
        cmd.Parameters.AddWithValue("@Data", Data);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectLavori(int Anno, int Mese, int CodiceCommessa)
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SELECTLAVORI");
        DateTime Data = new DateTime(Anno, Mese, Giorno);
        cmd.Parameters.AddWithValue("@Data", Data);
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable SommaLavori()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SOMMALAVORI");
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", Mese);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }
    public DataTable SommaLavoriOre()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SOMMALAVORI");
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
        cmd.Parameters.AddWithValue("@Anno", Anno);
        cmd.Parameters.AddWithValue("@Mese", Mese);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }



    public decimal ImportoTotale()
    {
        COMMESSE c = new COMMESSE();
        DataTable dt = new DataTable();
        dt = c.Select(CodiceCommessa);
        return Importo = decimal.Parse(dt.Rows[0]["ImportoTotale"].ToString());
    }
    public decimal ImportoTotaleOre()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_SOMMAORE");
        CONNESSIONE conn = new CONNESSIONE();
        
        DataTable dt = new DataTable();
        dt=conn.EseguiSelect(cmd);
        return Importo = decimal.Parse(dt.Rows[0]["ImportoTotale"].ToString());
    }
    //public DataTable SelectCorpo()
    //{

    //}
    
    //public DataTable SelectOre()
    //{
     
    //}

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

    public void Delete()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_DELETE");
        cmd.Parameters.AddWithValue("@CodiceFattura", CodiceCommessa);

        CONNESSIONE conn = new CONNESSIONE();
        conn.EseguiCmd(cmd);
    }


    public void Emissione()
    {
        SqlCommand cmd = new SqlCommand("FATTURE_EMISSIONE");
        DateTime DataFattura = new DateTime();
        DataFattura = DateTime.Now;
        Select(Anno);


        cmd.Parameters.AddWithValue("@CodiceFattura", CodiceFattura);
        cmd.Parameters.AddWithValue("@NumeroFattura", NumeroFattura);
        cmd.Parameters.AddWithValue("@DataFattura", DataFattura);

    }


}