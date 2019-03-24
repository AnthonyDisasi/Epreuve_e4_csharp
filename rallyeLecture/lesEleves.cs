using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class lesEleves
    {
        List<Eleve> Eleves;
        public lesEleves() {
            Eleves = new List<Eleve>();
        }
        public List<Eleve> GetEleves()
        {
            return Eleves;
        }
        public void CreateCsvPasswordFile()
        {
            using(StreamWriter sw=new StreamWriter("test.csv",
           false, Encoding.UTF8))
            {
                for(int i = 0; i < Eleves.Count; i++)
                {
                     sw.WriteLine(Eleves[i].GetNom() +";"+ Eleves[i].GetPrenom()+";"+Eleves[i].GetLogin()+";"+Eleves[i].GetPassword());
                }
               
            }
        }
      
        public List<Eleve> LoadCsv(PassWordType typePass,string filename)
        {
  
            using (StreamReader sr = new StreamReader(filename))
            {

                string line;
                string prenom=" ",nom=" ",login;   
                while ((line = sr.ReadLine()) != null)
                {
                  string[] attribut =line.Split(';');
                  for(int i=0; i < attribut.Count(); i++)
                    {
                        if (i == 0)
                            prenom = attribut[i];
                        else
                            nom = attribut[i]; 
                    }
                    login = prenom+nom+"@sio.jjr.fr";
                    this.Eleves.Add(new Eleve(nom, prenom, login,typePass,1));
                   
                }
                return Eleves;
            }
        }
    }
}
