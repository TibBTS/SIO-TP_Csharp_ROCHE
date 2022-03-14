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

        public char TypeNavireCroisiere { get => typeNavireCroisiere; }
        public int NbPassagersMaxi { get => nbPassagersMaxi; }
        internal Dictionary<string, Passager> Passager { get => passager;}


        public Croisiere(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel, char typeNavireCroisiere, int nbPassagersMaxi)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        public Croisiere(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel, char typeNavireCroisiere, int nbPassagersMaxi, List<Passager>Newpassagers)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        public void embarquer(List<Passager>PassagerEmbarquer)
        {
            if (passager.Count + PassagerEmbarquer.Count < nbPassagersMaxi)
            {
                passager.Add("lol",PassagerEmbarquer);
            }
            else
            {
                throw new Exception
            }
        }

        public void debarquer(List<Passager> PassagerDebarquer)
        {
            if (passager.Count + PassagerDebarquer.Count < nbPassagersMaxi)
            {
                passager.Add(PassagerDebarquer.Count);
            }
            else
            {

            }
        }
    }
}
