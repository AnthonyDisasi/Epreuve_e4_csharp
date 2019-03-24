using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    static class Connection
    {
        static private MySqlConnection cnx;

        public static MySqlConnection GetCnx()
        {
           
                return Connection.cnx;
            
        }
        static private string sConnection;

        static Connection()
        {
            sConnection = "host=localhost; database=rallyelecture; user=root; password=;SslMode=none";
            cnx = new MySqlConnection(sConnection);
        }
        public static void Ouvrir()
        {
           cnx.Open();
        }
        public static void Fermer()
        {
            cnx.Close();
        }
    }
}
