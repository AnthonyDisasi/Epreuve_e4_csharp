using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class TableClasse
    {
        public TableClasse()
        {

        }
        public long Insert(Classe classe)
        {
            
            MySqlCommand insert = new MySqlCommand("INSERT INTO classe(idEnseignant,anneeScolaire,idNiveau) VALUES(@idEnseignant,@anneeScolaire,@idNiveau)",Connection.GetCnx());
            insert.Parameters.Add(new MySqlParameter("@idEnseignant",classe.GetIdEnseignant));
            insert.Parameters.Add(new MySqlParameter("@anneeScolaire",classe.GetAnneeScolaire));
            insert.Parameters.Add(new MySqlParameter("@idNiveau", classe.GetIdNiveau));
            Connection.Ouvrir();
            insert.ExecuteNonQuery();
            Connection.Fermer();
            return insert.LastInsertedId;
        }
    }
}
