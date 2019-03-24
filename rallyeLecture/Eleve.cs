using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class Eleve
    {
        string nom, prenom, login;
        string password;
        long idClasse;
        static Random r = new Random();
        public Eleve(string pNom,string pPrenom,string pLogin,PassWordType type,long pclasse)
        {
            nom = pNom;
            prenom = pPrenom;
            login = pLogin;
            
            password = GetNewPassWord(type);
            
            idClasse = pclasse;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetPrenom()
        {
            return prenom;
        }
   
        public long GetIdClasse()
        {
            return idClasse;
        }
        public string GetNom()
        {
            return nom;
        }
        public string GetLogin()
        {
            return login;
        }
        private static string GetPassWordAleatoire()
        {
            int RandomAlphabet;
            string chaine = "";
            int indice;
            int nbrCaractere = 0;

            List<String> choix =new List<string>(){ "minuscule", "majuscule","caractereSpecial","alphabet","chiffre" };
            List<String> alphabet =new List<String>() { "A","B","C","D","E","F","G","H","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
            List<String> caractereSpeciaux = new List<String>() { "é", "#", "_", "ç", "^", ")", "@" };
            List<int> chiffre = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      
            do
            {
                nbrCaractere++;
                
               
                indice = r.Next(choix.Count);
                switch (choix[indice])
                {
                    case "minuscule":
                        choix.RemoveAt(indice);
                        RandomAlphabet = r.Next(alphabet.Count);
                        chaine += alphabet[RandomAlphabet].ToLower();
                        break;
                    case "majuscule":

                        choix.RemoveAt(indice);
                        RandomAlphabet = r.Next(alphabet.Count);
                        chaine += alphabet[RandomAlphabet];
                        break;
                    case "caractereSpecial":
                        choix.RemoveAt(indice);
                        RandomAlphabet = r.Next(caractereSpeciaux.Count);
                        chaine += caractereSpeciaux[RandomAlphabet];
                        break;
                    case "alphabet":
                        
                        RandomAlphabet = r.Next(alphabet.Count);
                        chaine += alphabet[RandomAlphabet];
                
                 
                        break;
                    case "chiffre":
                        choix.RemoveAt(indice);

                        RandomAlphabet = r.Next(chiffre.Count);
                        chaine += chiffre[RandomAlphabet];


                        break;
                }




            } while (nbrCaractere < 9);
            return chaine;

        }

        private  string GetPassWordConstruit()
        {
            return prenom.Substring(0, 1)+nom;
        }
        public string GetNewPassWord(PassWordType passWordType)
        {
            if (passWordType == PassWordType.Aleatoire)
               return  GetPassWordAleatoire();
            else
               return  GetPassWordConstruit();

        }
    }
}
