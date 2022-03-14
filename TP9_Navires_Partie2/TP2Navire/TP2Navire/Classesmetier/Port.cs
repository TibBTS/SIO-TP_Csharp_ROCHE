// <copyright file="Port.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP1Navire.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GestionNavire.Exceptions;
    using TP1Navire.ClassesMetier;
    using TP2Navire.Classesmetier;

    /// <summary>
    /// Contient les constructeurs et méthode de Port.
    /// </summary>
    internal class Port
    {
        private int nbNaviresMax;

        private Dictionary<string, Navire> navires = new Dictionary<string, Navire>();

        private List<Stockage> stockages;

        private string nom;

        /// <summary>
        /// Initializes a new instance of the <see cref="Port"/> class.
        /// Constructeur du bateau.
        /// </summary>
        /// <param name="nom">Nom du port.</param>
        /// <param name="nbNaviresMax">Nombre de bateaux maximum que le port peut accueillir à un instant.</param>
        public Port(string nom, int nbNaviresMax)
        {
            this.nom = nom;
            this.nbNaviresMax = 5;
            this.navires = new Dictionary<string, Navire>();
            this.stockages = new List<Stockage>();
        }

        /// <summary>
        /// Gets or sets Permet de récupérer le nom du port et le modifier.
        /// </summary>
        public string Nom { get => this.nom; set => this.nom = value; }

        /// <summary>
        /// Gets or sets Permet de récupérer et modifier le nombre de bateaux maximum que le port peut accueillir à un instant.
        /// </summary>
        public int NbNaviresMax { get => this.nbNaviresMax; set => this.nbNaviresMax = value; }

        /// <summary>
        /// Enregistre un nouveau navire.
        /// </summary>
        /// <param name="navire">Collection navire.</param>
        public void EnregistrerArrivee(Navire navire)
        {
            try
            {
                if (this.navires.Count < this.nbNaviresMax)
                {
                    this.navires.Add(navire.Imo, navire);
                }
                else
                {
                    throw new GestionPortException("Ajout impossible, le port est complet");
                }
            }
            catch (ArgumentException)
            {
                throw new GestionPortException("Le navire " + navire.Imo + " est déja enregistré");
            }
        }

        /// <summary>
        /// Vérifie si le navire est présent dans le port.
        /// </summary>
        /// <param name="imo">Imatriculation du bateau.</param>
        /// <returns>Renvoie si le navire est présent ou non.</returns>
        public bool EstPresent(string imo)
        {
            return this.navires.ContainsKey(imo);
        }

        /// <summary>
        /// Enregistre le départ d'un bateau et vérifie son existence.
        /// </summary>
        /// <param name="imo">Imatriculation du navire.</param>
        public void EnregistrerDepart(string imo)
        {
            if (!this.EstPresent(imo))
            {
                throw new GestionPortException("Impossible d'enregistrer me départ du navire " + imo + " il n'est pas dans le port.");
            }
            else
            {
                if (this.navires.ContainsKey(imo))
                {
                    this.navires.Remove(imo);
                }
            }
        }

        /// <summary>
        /// Décharge la cargaison du navire.
        /// </summary>
        /// <param name="imo">Imatriculation du navire.</param>
        public void Dechargement(string imo)
        {
            while 
            
            
            
            
            
            
            
            if (!this.EstPresent(imo))
            {
                throw new GestionPortException("Impossible de trouver le navire " + imo + " il n'est pas dans le port.");
            }
            else
            {
                Navire n = this.navires[imo];
                n.Decharger(n.QteFret);
            }
        }

        /// <summary>
        /// Ajoute un lieu de stockage dans le port.
        /// </summary>
        /// <param name="stockage">Ajoute les paramètres du stockage pour le construc.</param>
        public void AjoutStockage(Stockage stockage)
        {
            this.stockages.Add(stockage);
        }
    }
}
