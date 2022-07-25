using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class LAVORATORI : TabellaSQL
{
    public int CodicePersonale;
    public int CodiceAzienda;
    public int CodiceTipoContratto;
    public string Cognome;
    public string Nome;
    public string CodiceFiscale;
    public string Indirizzo;
    public string Citta;
    public string Provincia;
    public string Cap;
    public string DataNascita;
    public decimal CostoMensile;
    public string DataInizioCollaborazione;
    public string DataFineCollaborazione;

    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_SELECTALL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable Select(int codicePersonale)
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_SELECTONE");

        cmd.Parameters.AddWithValue("@codicePersonale", codicePersonale);
        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public DataTable SelectDdl()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_SELECTFORDDL");

        CONNESSIONE conn = new CONNESSIONE();
        return conn.EseguiSelect(cmd);
    }

    public abstract bool CheckOne();

    public abstract void Insert();

    public abstract void Update();
}
