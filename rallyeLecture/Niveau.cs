using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class Niveau
    {
        int id;
        string niveauScolaire;
        public Niveau(int pId,string pNiveauScolaire)
        {
            id = pId;
            niveauScolaire = pNiveauScolaire;
        }
        public string GetNiveauScolaire()
        {
            return niveauScolaire;
        }
        public int GetId()
        {
            return id;
        }
    }
}
