using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    class Croisiere : Navire
    {
        private char typeNavireCroisiere;
        private int nbPassagersMaxi;
        
        public char TypeNavireCroisiere { get => typeNavireCroisiere; set => typeNavireCroisiere = value; }
        public int NbPassagersMaxi { get => nbPassagersMaxi; set => nbPassagersMaxi = value; }

        public Croisiere(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel, char typeNavireCroisiere, int nbPassagersMaxi, List<Passager>Newpassagers)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        public void enmbarquer(List<Passager>Newpassager)
        {
            if(list<passager>+nbPassagersMaxi)
        }

    }
}
