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
        internal Dictionary<string, Passager> Passager { get => passager; }


        public Croisiere(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel, char typeNavireCroisiere, int nbPassagersMaxi)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        public Croisiere(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel, char typeNavireCroisiere, int nbPassagersMaxi, List<Passager> Newpassagers)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        public void embarquer(List<Passager> PassagerEmbarquer)
        {


            if (passager.Count + PassagerEmbarquer.Count < nbPassagersMaxi)
            {
                foreach (Passager p in PassagerEmbarquer)
                {
                    passager.Add(p.NumPasseport, p);
                }
            }
            else
            {
                throw new Exception("Plus de place pour embarquer des passagers");
            }
        }



        public void debarquer(List<Passager> PassagerDebarquer)
        {
            if ( PassagerDebarquer.Count< nbPassagersMaxi)
            {
                foreach (Passager p in PassagerDebarquer)
                {
                    passager.Remove(p.NumPasseport);
                }
            }
            else
            {
                throw new Exception("Il n'y plus de passager à debarquer");
            }
        }
    }
}
