using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class Enseignant
    {
        int id;
        string nom,prenom,login,hashPassWord;
        public Enseignant(int pId,string pNom,string pPrenom,string pLogin,string pHashPassWord)
        {
            id = pId;
            nom = pNom;
            prenom = pPrenom;
            login = pLogin;
            hashPassWord = pHashPassWord;

        }

       public int GetId()
        {
            return id;
        }
        public string GetPassword()
        {
            return hashPassWord;
        }
    }
}
