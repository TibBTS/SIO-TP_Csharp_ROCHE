﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Navire
{
    class Port
    {
        private string nom;
        private int nbNaviresMax;
        private List<Navire> navires = new List<Navire>();

        public string Nom { get => nom; }
        public int NbNaviresMax { get => nbNaviresMax; set => nbNaviresMax = value; }

        public Port(string nom)
        {
            this.nom = nom;
            this.nbNaviresMax = 5;
            navires = new List<Navire>();
        }

        public void EnregistrerArrivee(Navire navire)
        {
   
            if (navires.Count + 1 >= NbNaviresMax)
            {
                throw new Exception("Ajout impossible, le port est complet");
            }

            navires.Add(navire);
        }

        public bool EstPresent(string imo)
        {
            int i=0;
            while(i<navires.Count && imo !=navires[i].Imo)
                {
                i++;

           
            }
                return !(i == navires.Count);

        }

        public void EnregisterDepart(string imo)
        {
            if (EstPresent(imo))
            {
                navires.RemoveAt(RecupPosition(imo));
                return;
            }

            throw new Exception("Impossible d'enregistrer le navire " + imo + ", Ce navire n'est pas present dans le port");
        }

        public int RecupPosition(string imo)
        {
            int i = 0;
            while (navires[i].Imo == imo && i<navires.Count)
            {
                i++;
            }
            
            if(i==navires.Count)
                {
                    return -1;
                }
                else
                {
                    return i;
                }
          
        }

        private int RecupPosition(Navire navire)
        {
            if (navires.Contains(navire))
            {
                return navires.IndexOf(navire);
            }

            return -1;
        }

        public void TesterRecupPosition()
        {
            this.EnregistrerArrivee(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827));
            this.EnregistrerArrivee(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
            this.EnregistrerArrivee(new Navire("IMO8715871", "MSC PILAR"));

            string imo = "IMO9427639";
            Console.WriteLine("Indice du navire " + imo + " dans la collection : " + this.RecupPosition(imo));
            imo = "IMO9839272";
            Console.WriteLine("Indice du navire " + imo + " dans la collection : " + this.RecupPosition(imo));
            imo = "IMO8715871";
            Console.WriteLine("Indice du navire " + imo + " dans la collection : " + this.RecupPosition(imo));
        }

        public void TesterRecupPositionV2()
        {
            Navire navire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);
            this.EnregistrerArrivee(navire);
            this.EnregistrerArrivee(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
            this.EnregistrerArrivee(new Navire("IMO8715871", "MSC PILAR"));
            Console.WriteLine("Indice du navire " + navire.Imo + " dans la collection : " + this.RecupPosition(navire));
            Navire unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Console.WriteLine("Indice du navire " + unAutreNavire.Imo + " dans la collection : " + this.RecupPosition(unAutreNavire));
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR", "Porte canteneurs", 52181);
            Console.WriteLine("Indice du navire " + unAutreNavire.Imo + " dans la collection : " + this.RecupPosition(unAutreNavire));
        }
    }
}
