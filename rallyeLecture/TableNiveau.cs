using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class TableNiveau
    {
        public TableNiveau()
        {

        }
        public List<Niveau> GetAll()
        {
            Connection.Fermer();
            List<Niveau> nv = new List<Niveau>();
            MySqlCommand niveau = new MySqlCommand("SELECT * FROM NIVEAU",Connection.GetCnx());
            Connection.Ouvrir();
            MySqlDataReader rdr = niveau.ExecuteReader();
            while (rdr.Read())
            {
                nv.Add(new Niveau(Convert.ToInt32(rdr["id"]),Convert.ToString(rdr["niveauScolaire"])));
            }
            Connection.Fermer();
            return nv;
        }
    }
}
