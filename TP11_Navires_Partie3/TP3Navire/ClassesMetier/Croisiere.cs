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
        private Dictionary<String, Passager> passager = new Dictionary<string, Passager>();

        public char TypeNavireCroisiere1 { get => typeNavireCroisiere; set => typeNavireCroisiere = value; }
        public int NbPassagersMaxi1 { get => nbPassagersMaxi; set => nbPassagersMaxi = value; }
        internal Dictionary<string, Passager> Passager { get => passager; set => passager = value; }

        public Croisiere(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel, char typeNavireCroisiere, int nbPassagersMaxi, List<Passager>Newpassagers)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        public void enmbarquer(List<Passager>Newpassager)
        {
            if (passager.Count + Newpassager.Count < nbPassagersMaxi)
            {
                passager.Add(Newpassager.Count);
            }
            else
            {

            }
        }

    }
}
