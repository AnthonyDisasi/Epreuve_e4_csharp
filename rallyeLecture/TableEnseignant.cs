using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class TableEnseignant
    {
    
        
        public TableEnseignant()
        {
            
        }
        public string GetIdAuthByLogin(string login)
        {
            MySqlCommand requette = new MySqlCommand("SELECT idAuth FROM enseignant WHERE login=@login", Connection.GetCnx());
            requette.Parameters.Add(new MySqlParameter("@login", login));
           
            MySqlDataReader rdrr = requette.ExecuteReader();
            if (rdrr.Read())
            {
              
                return Convert.ToString(rdrr["idAuth"]);
            }
            else
            {
           
                return "Null";
            }
          
        }

        public Boolean Access(string login,string password)
        {
            Boolean access=false;
            Connection.Ouvrir();
            string idAuth = GetIdAuthByLogin(login);
            Connection.Fermer();
            if(idAuth == "Null")
            {
                return access;
            }
            MySqlCommand req = new MySqlCommand("SELECT * FROM enseignant INNER JOIN aauth_users ON idAuth=aauth_users.id  WHERE login=@login  and pass=@password", Connection.GetCnx());
            req.Parameters.Add(new MySqlParameter("@login", login));
            req.Parameters.Add(new MySqlParameter("@password", HashPhp.Salt(password, idAuth)));
            Connection.Ouvrir();
            MySqlDataReader rdr = req.ExecuteReader();
       
            if (rdr.Read())
            {
                access = true;   
            }      
                Connection.Fermer();
            return access;
                
         
        }
    }
}
