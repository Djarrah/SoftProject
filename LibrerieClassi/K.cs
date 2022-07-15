using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per k
/// </summary>
public static class K
{
    // Aggiungete la vostra connectionstring!
    public static string connectionString = @"Data Source=CRIMSON-GATE\SQLEXPRESS; Initial Catalog=SOFTHOUSE; Integrated Security=True";

    public static string user;
        public static string pw;
        public static int porta;
        public static string host;

    static K()
    {
        user="doita05@setsistemi.it";
        pw= "corsodoita";
        porta= 25;
        host= "setsistemi.it";
    }
    
}