using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    class Cargo : Navire
    {
        private string typeFret;
        public string TypeFret { get => typeFret; }

        public Cargo(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel,string typeFret)
            : base(imo, nom, latitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

       
        public void charger(int Qtacharger)
        {
            if (TonnageActuel+Qtacharger < TonnageDWT)
            {
                TonnageActuel += Qtacharger;
            }
            else
            {
                Console.WriteLine("Le bateau n'a pas assez de place pour charger la cargaison");
            }
        }

        public void decharger(int Qtadecharger)
        {
            if (Qtadecharger<TonnageActuel)
            {
                TonnageActuel -= Qtadecharger;
            }
            else
            {
                Console.WriteLine("Impossible de décharger cette quantité");
            }
        }

    }
}
