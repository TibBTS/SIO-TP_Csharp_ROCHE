namespace TP1Navire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestNavire
    {
        public static void TesterInstanciations()
        {
            // déclaration de l'objet unNavire de la classe Navire
            Navire unNavire;
            // Instantiation de l'objet
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);

            Console.WriteLine(unNavire.ToString());
            // Declaration ET instanciation d'un autre objet de la classe Navire
            Navire unAutreNavire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500);
            Console.WriteLine(unAutreNavire.ToString());
            // ??
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Console.WriteLine(unAutreNavire.ToString());
        }

        public static string Affiche(Navire navire)
        {
            string txt = "Identification : " + navire.Imo;
            txt += "\nNom : " + navire.Nom;
            txt += "\nType de frêt : " + navire.LibelleFret;
            txt += "\nQuantité de frêt : " + navire.QteFretMaxi;
            txt += "\n------------------------------------";

            return txt;
        }
    }
}
