using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class TableEleve
    {
        public string lastInsert()
        {
            string idAuth="";
            MySqlCommand req = new MySqlCommand("SELECT MAX(id) as idAuth FROM aauth_users", Connection.GetCnx());
            Connection.GetCnx().Open();
            MySqlDataReader rdr = req.ExecuteReader();
            if (rdr.Read())
            {
                idAuth= Convert.ToString(rdr["idAuth"]);
            }
            Connection.GetCnx().Close();
            return idAuth;
        }
        public void Insert(Eleve eleve)
        {
            string idAuth = lastInsert();
            MySqlCommand insertAuth = new MySqlCommand("INSERT INTO aauth_users(email,pass,username,banned,last_login,last_activity,date_created,forgot_exp,remember_time,remember_exp,verification_code,totp_secret,ip_address) " +
                "VALUES(@email,@pass,NULL,0,NULL,NULL,NOW(),NULL,NULL,NULL,NULL,NULL,0)", Connection.GetCnx());
            insertAuth.Parameters.Add(new MySqlParameter("@email" ,eleve.GetLogin()));
            insertAuth.Parameters.Add(new MySqlParameter("@pass", HashPhp.Salt(eleve.GetPassword(), idAuth+1)));
            Connection.GetCnx().Open();
            insertAuth.ExecuteNonQuery();
            long lastidAuth=insertAuth.LastInsertedId;
            Connection.GetCnx().Close();

            MySqlCommand insert = new MySqlCommand("INSERT INTO Eleve(idClasse,nom,prenom,login,idAuth) VALUES(@idClasse,@nom,@prenom,@login,@idAuth)", Connection.GetCnx());
            insert.Parameters.Add(new MySqlParameter("@idClasse", eleve.GetIdClasse()));
            insert.Parameters.Add(new MySqlParameter("@nom",eleve.GetNom()));
            insert.Parameters.Add(new MySqlParameter("@prenom",eleve.GetPrenom()));
            insert.Parameters.Add(new MySqlParameter("@login", eleve.GetLogin()));
            insert.Parameters.Add(new MySqlParameter("@idAuth", lastidAuth));
           
            Connection.GetCnx().Open();
            insert.ExecuteNonQuery();
            Connection.GetCnx().Close();

            MySqlCommand insertAuthToGroup = new MySqlCommand("INSERT INTO  aauth_user_to_group(user_id,group_id)VALUES (@lastidAuth,4) ", Connection.GetCnx());
            insertAuthToGroup.Parameters.Add(new MySqlParameter("@lastidAuth", lastidAuth));
            Connection.GetCnx().Open();
            insertAuthToGroup.ExecuteNonQuery();
            Connection.GetCnx().Close();


        }
    }
}
