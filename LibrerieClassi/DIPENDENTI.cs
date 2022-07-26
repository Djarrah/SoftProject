using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DIPENDENTI : LAVORATORI
{
    public override bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        string query = "PERSONALE_CHECKONE";
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        cmd.Parameters.AddWithValue("@PartitaIva", "");
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);

        return c.EseguiSelect(cmd).Rows.Count > 0;
    }

    public override void Insert()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_INSERT");
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
        cmd.Parameters.AddWithValue("@Cognome", Cognome);
        cmd.Parameters.AddWithValue("@Nome", Nome);
        cmd.Parameters.AddWithValue("@RagioneSociale", "");
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        cmd.Parameters.AddWithValue("@PartitaIva", "");
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

    public override void Update()
    {
        SqlCommand cmd = new SqlCommand("PERSONALE_UPDATE");
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
        cmd.Parameters.AddWithValue("@Cognome", Cognome);
        cmd.Parameters.AddWithValue("@Nome", Nome);
        cmd.Parameters.AddWithValue("@RagioneSociale", "");
        cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
        cmd.Parameters.AddWithValue("@PartitaIva", "");
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
