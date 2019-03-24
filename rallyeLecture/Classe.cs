using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class Classe
    {
        int idEnseignant, idNiveau;
        string anneeScolaire;
        public Classe(int pIdEnseignant,int pIdNiveau,string pAnneeScolaire)
        {
            idEnseignant = pIdEnseignant;
            idNiveau = pIdNiveau; ;
            anneeScolaire = pAnneeScolaire;
        }

        public int GetIdEnseignant { get => idEnseignant;  }
        public int GetIdNiveau { get => idNiveau;}
        public string GetAnneeScolaire { get => anneeScolaire; }
    }
}
