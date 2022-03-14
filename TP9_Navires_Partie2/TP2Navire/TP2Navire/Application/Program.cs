// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP1Navire.Application
{
    using System;
    using GestionNavire.Exceptions;
    using TP1Navire.ClassesMetier;
    using TP2Navire.Classesmetier;

    /// <summary>
    /// Contient les méthodes que nous allons utiliser.
    /// </summary>
    internal class Program
    {
        private static Port port;

        private static void Main(string[] args)
        {
            try
            {
                port = new Port("Toulon", 5);

                // TestNavire.TesterInstanciations();
                try
                {
                    TesterEnregistrerArrivee();
                }
                catch (GestionPortException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    TesterEnregistrerArriveeV2();
                }
                catch (GestionPortException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("------- Début des déchargements -------");
                Console.WriteLine("---------------------------------------");
                AjouterStockages();
                TesterDechargerNavires();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-------- Fin des déchargements --------");
                Console.WriteLine("---------------------------------------");
                try
                {
                    TesterEnregistrerDepart();
                }
                catch (GestionPortException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // TesterRecupPosition();
                // TesterRecupPositionV2();
                // TesterEnregistrerDepart();
                // TesterEstPresent();
                // Instanciations();
                // TesterInstanciationsStockage();
                Console.WriteLine("Fin normale du programme");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Permet de tester l'enregistrer du départ d'un navire.
        /// </summary>
        public static void TesterEnregistrerDepart()
        {
            try
            {
                port.EnregistrerDepart("IMO9427639");
                port.EnregistrerDepart("IMO9405423");
                port.EnregistrerDepart("IMO1111111");
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Permet de tester la méthode stockage ainsi que l'instanciation.
        /// </summary>
        public static void TesterInstanciationsStockage()
        {
            try
            {
                new Stockage(1, 15000);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                new Stockage(2, 12000, 10000);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                new Stockage(3, -25000, -10000);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                new Stockage(4, 15000, 20000);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Permet de tester si un navire est présent dans le port.
        /// </summary>
        public static void TesterEstPresent()
        {
            Port port = new Port("Toulon", 5);
            port.EnregistrerArrivee(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827, 0));
            port.EnregistrerArrivee(new Navire("IMO9839272", "MSC Isabella", "Porte conteneurs", 197500, 0));
            port.EnregistrerArrivee(new Navire("IMO8715871", "MSC PILAR"));
            string imo = "IMO9427639";
            Console.WriteLine("Le navire " + imo + "est présent dans le port : " + port.EstPresent(imo));
            imo = "IMO1111111";
            Console.WriteLine("Le navire " + imo + "est présent dans le port : " + port.EstPresent(imo));
        }

        /// <summary>
        /// Méthode de test pour ajouter des stockages dans le port.
        /// </summary>
        public static void AjouterStockages()
        {
            port.AjoutStockage(new Stockage(1, 160000));
            port.AjoutStockage(new Stockage(2, 12000));
            port.AjoutStockage(new Stockage(3, 25000));
            port.AjoutStockage(new Stockage(4, 15000));
            port.AjoutStockage(new Stockage(5, 15000));
            port.AjoutStockage(new Stockage(6, 15000));
            port.AjoutStockage(new Stockage(7, 15000));
            port.AjoutStockage(new Stockage(8, 15000));
            port.AjoutStockage(new Stockage(9, 35000));
            port.AjoutStockage(new Stockage(10, 19000));
        }

        /// <summary>
        /// Méthode de test pour décharger les ressources des navires.
        /// </summary>
        public static void TesterDechargerNavires()
        {
            try
            {
                string imo = "IMO9839272";
                port.Dechargement(imo);
                Console.WriteLine("Navire " + imo + " déchargé");
                port.EnregistrerDepart(imo);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                string imo = "IMO1111111";
                port.Dechargement(imo);
                Console.WriteLine("Navire " + imo + " déchargé");
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                string imo = "IMO9574004";
                port.Dechargement(imo);
                Console.WriteLine("Navire " + imo + " déchargé");
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                port.EnregistrerArrivee(new Navire("IMO9786481", "EVER GLOBE", "Porte-conteneur", 198397, 190000));
                string imo = "IMO9786481";
                port.Dechargement(imo);
                Console.WriteLine("Navire " + imo + " déchargé");
                port.EnregistrerDepart(imo);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                port.EnregistrerArrivee(new Navire("IMO9776432", "CMACGM LOUIS BLERIOT", "Porte-conteneur", 202684, 190000));
                string imo = "IMO9776432";
                port.Dechargement(imo);
                Console.WriteLine("Navire " + imo + " déchargé");
                port.EnregistrerDepart(imo);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Méthode qui test l'enregistrement des arrivee des navires dans le port.
        /// </summary>
        private static void TesterEnregistrerArriveeV2()
        {
            Navire navire = null;
            try
            {
                port.EnregistrerArrivee(new Navire("IMO9839272", "MSC Isabella", "Porte conteneurs", 197500, 0));
                port.EnregistrerArrivee(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827, 0));
                port.EnregistrerArrivee(new Navire("IMO8715871", "MSC PILAR"));
                port.EnregistrerArrivee(new Navire("IMO9235232", "FORTUNE TRADER", "Cargo", 74750, 0));
                port.EnregistrerArrivee(new Navire("IMO9405423", "SERENA", "Tanker", 158583, 0));
                port.EnregistrerArrivee(new Navire("IMO9574004", "TRITON SEAHAWK", "Hydrocarbures", 51201, 0));
                port.EnregistrerArrivee(new Navire("IMO974861", "NORDIC SPACE", "Tanker", 157587, 0));
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException)
            {
                throw new GestionPortException("Le navire " + navire.Imo + " est déja enregistré");
            }
        }

        /// <summary>
        /// Test l'enregristrement des arrivee des navires renseignées.
        /// </summary>
        private static void TesterEnregistrerArrivee()
        {
            Navire navire = null;
            try
            {
                navire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827, 0);
                port.EnregistrerArrivee(navire);
                navire = new Navire("IMO9427639", "MSC Isabella", "Porte conteneurs", 197500, 0);
                port.EnregistrerArrivee(navire);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Instanice un port.
        /// </summary>
        private static void Instanciations()
        {
            try
            {
                Navire navire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827, 0);
                navire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500, 0); // Déclencheur de l'exception.
                navire = new Navire("IMO8715871", "MSC PILAR");
                navire = new Navire("IMO9235232", "FORTUNE TRADER");
                navire = new Navire("IMO9574004", "TRITON SEAHAWK", "Hydrocarbures", 51201, 0);
            }
            catch (GestionPortException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
