using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrerieClassi
{
   public static class CONTABILITA
    {
        public static decimal SommaFatture(int anno)
        {
            SqlCommand cmd = new SqlCommand("FATTURE_SOMMA");
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@mese", 0);

            CONNESSIONE conn = new CONNESSIONE();
            return decimal.Parse(conn.EseguiSelect(cmd).Rows[0]["SOMMA"].ToString());
        }

        public static decimal SommaFatture(int anno, int mese)
        {
            SqlCommand cmd = new SqlCommand("FATTURE_SOMMA");
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@mese", mese);

            CONNESSIONE conn = new CONNESSIONE();
            return decimal.Parse(conn.EseguiSelect(cmd).Rows[0]["SOMMA"].ToString());
        }

        public static decimal SommaSpese(int anno)
        {
            SqlCommand cmd = new SqlCommand("SPESE_SOMMA");
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@mese", 0);

            CONNESSIONE conn = new CONNESSIONE();
            return decimal.Parse(conn.EseguiSelect(cmd).Rows[0]["SOMMA"].ToString());
        }

        public static decimal SommaSpese(int anno, int mese)
        {
            SqlCommand cmd = new SqlCommand("SPESE_SOMMA");
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@mese", mese);

            CONNESSIONE conn = new CONNESSIONE();
            return decimal.Parse(conn.EseguiSelect(cmd).Rows[0]["SOMMA"].ToString());
        }

        public static decimal SommaStipendi(int anno)
        {
            SqlCommand cmd = new SqlCommand("LAVORI_SOMMA");
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@mese", 0);

            CONNESSIONE conn = new CONNESSIONE();
            return decimal.Parse(conn.EseguiSelect(cmd).Rows[0]["SOMMA"].ToString());
        }

        public static decimal SommaStipendi(int anno, int mese)
        {
            SqlCommand cmd = new SqlCommand("LAVORI_SOMMA");
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@mese", mese);

            CONNESSIONE conn = new CONNESSIONE();
            return decimal.Parse(conn.EseguiSelect(cmd).Rows[0]["SOMMA"].ToString());
        }

        public static decimal Ricavo(int anno)
        {
            return SommaFatture(anno) - (SommaSpese(anno)+SommaStipendi(anno));
        }

        public static decimal Ricavo(int anno, int mese)
        {
            return SommaFatture(anno, mese) - (SommaSpese(anno, mese) + SommaStipendi(anno, mese));
        }
    }
}
