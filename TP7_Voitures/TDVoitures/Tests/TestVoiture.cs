using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDVoitures.ClasseMetier;
using TDVoitures.Outils;

namespace TDVoitures.Tests
{
    abstract class TestVoiture
    {
        internal static void InstanciationV1 () 
        {
            Marque m = new Marque(1, "Peugeot", Pays.France);

            Voiture v = new Voiture(1,10000,Couleur.Rouge,2019,60,40,20,m);

            v.ToString();
        }

        internal static void TestVoitureNeuve ()
        {
            Marque m = new Marque(1, "Peugeot", Pays.France);

            Voiture v = new Voiture(1,10000,Couleur.Rouge,2022,40,m);

            v.ToString();
        }

        internal static void TestVoitureAlternative()
        {
            Marque m = new Marque(1, "Peugeot", Pays.France);

            Voiture v = new Voiture(1,10000,Couleur.Rouge,40,20,0,m);

            v.ToString();
        }
    }
}
