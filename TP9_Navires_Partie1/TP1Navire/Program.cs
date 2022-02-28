using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.TesterInstanciations();

            Port port = new Port("Mon super port");

            try
            {
                /*port.EnregistrerArrivee(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827));
                port.EnregistrerArrivee(new Navire("IMO9427638", "Copper Spirit", "Hydrocarbures", 156827));
                port.EnregistrerArrivee(new Navire("IMO9427637", "Copper Spirit", "Hydrocarbures", 156827));
                port.EnregistrerArrivee(new Navire("IMO9427636", "Copper Spirit", "Hydrocarbures", 156827));
                port.EnregistrerArrivee(new Navire("IMO9427635", "Copper Spirit", "Hydrocarbures", 156827));

                Console.WriteLine("Navires bien enregistrés dans le port");*/

                TesterEstPresent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void TesterRecupPosition()
        {
            new Port("Toulon").TesterRecupPosition();
        }

        public static void TesterRecupPositionV2()
        {
            new Port("Toulon").TesterRecupPositionV2();
        }

        public static void TesterEnregistrerDepart()
        {
            Port port = new Port("Toulon");
            port.EnregistrerArrivee(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827));
            port.EnregistrerArrivee(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
            port.EnregistrerArrivee(new Navire("IMO8715871", "MSC PILAR"));
            port.EnregisterDepart("IMO8715871");
            Console.WriteLine("Départ du navire IMO8715871 enregistré");
            port.EnregisterDepart("IMO1111111");
            Console.WriteLine("Départ du navire IMO1111111 enregistré");
            Console.WriteLine("fin des enregistrements des départs");
        }

        public static void TesterEstPresent()
        {
            Port port = new Port("Toulon");
            port.EnregistrerArrivee(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827));
            port.EnregistrerArrivee(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
            port.EnregistrerArrivee(new Navire("IMO8715871", "MSC PILAR"));
            string imo = "IMO9427639";
            Console.WriteLine("Le navire " + imo + "  est present dans le port : " + port.EstPresent(imo));
            imo = "IMO1111111";
            Console.WriteLine("Le navire " + imo + "  est present dans le port : " + port.EstPresent(imo));
        }
    }
}
