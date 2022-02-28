// <copyright file="Navire.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP1Navire.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    using GestionNavire.Exceptions;

    /// <summary>
    /// Contient les constructeurs du navire.
    /// </summary>
    internal class Navire
    {
        private string imo;
        private string nom;
        private string libelleFret;
        private int qteFretMaxi;
        private int qteFret;

        /// <summary>
        /// Initializes a new instance of the <see cref="Navire"/> class.
        /// Constructeur du bateau.
        /// </summary>
        /// <param name="imo">Numéro d'identification du navire.</param>
        /// <param name="nom">Nom du navire.</param>
        /// <param name="libelleFret">Type de cargaison du navire.</param>
        /// <param name="qteFretMaxi">Quantité maximale de fret que peut embarquer un navire.</param>
        /// <param name="qteFret">Quantité actuel de fret que contient le navire.</param>
        public Navire(string imo, string nom, string libelleFret, int qteFretMaxi, int qteFret)
        {
            string pattern = @"IMO[\d]{7}$";
            if (Regex.IsMatch(imo, pattern))
            {
                this.imo = imo;
            }
            else
            {
                throw new GestionPortException("Erreur : IMO non valide");
            }

            this.nom = nom;
            this.libelleFret = libelleFret;
            this.QteFretMaxi = qteFretMaxi;
            this.QteFret = qteFret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Navire"/> class.
        /// Constructeur surchargé.
        /// </summary>
        /// <param name="imo">Numéro d'identification du navire.</param>
        /// <param name="nom">Nom du navire.</param>
        public Navire(string imo, string nom)
            : this(imo, nom, "Indéfini", 0, 0)
        {
        }

        /// <summary>
        /// Gets Permet de récupérer le numéro d'identification des navires.
        /// </summary>
        public string Imo { get => this.imo; }

        /// <summary>
        /// Gets or sets permet de récupérer le nom du navire ainsi que de pouvoir le modifier.
        /// </summary>
        public string Nom { get => this.nom; set => this.nom = value; }

        /// <summary>
        /// Gets or sets Permet de récupérer la nature de la cargaison (elle peut être modifiée au cours de la vie du navire).
        /// </summary>
        public string LibelleFret { get => this.libelleFret; set => this.libelleFret = value; }

        /// <summary>
        /// Gets or sets quantité de fret que contient le navire. Exprimé en tonnes entières, …), elle peut être modifiée au cours de la vie du navire..
        /// </summary>
        public int QteFret
        {
            get => this.qteFret;
            set
            {
                if (value >= 0 && value <= this.QteFretMaxi)
                {
                    this.qteFret = value;
                }
                else
                {
                    throw new GestionPortException("Valeur incohérente pour la quantité de fret stockée dans le navire");
                }
            }
        }

        /// <summary>
        /// Gets or sets quantité maximale de fret que peut embarquer un navire. Exprimé en tonnes entières, …), elle peut être modifiée au cours de la vie du navire..
        /// </summary>
        public int QteFretMaxi
        {
            get => this.qteFretMaxi;
            set
            {
                if (value >= 0)
                {
                    this.qteFretMaxi = value;
                }
                else
                {
                    throw new GestionPortException("Erreur, quantité de fretmaxi non valide");
                }
            }
        }

        /// <summary>
        /// Méthode ToString permettant de renvoyer les informations.
        /// </summary>
        /// <returns>Renvoie les informations de chaque navires.</returns>
        public override string ToString()
        {
            return "Identification : " + this.Imo + "\nNom : " + this.Nom + "\nType de fret : " + this.LibelleFret + "\nQuantité de fret : " + this.QteFretMaxi + "\n----------------------------------------";
        }

        /// <summary>
        /// Décharge le navire de ses ressources.
        /// </summary>
        /// <param name="quantite">Indique la quantité que le navire souhaite se débarasser.</param>
        public void Decharger(int quantite)
        {
            if (quantite < 0)
            {
                throw new GestionPortException("La quantité à décharger ne peut être négative ou nulle");
            }

            if (quantite > this.qteFret)
            {
                throw new GestionPortException("Impossible de décharger plus que la quantité de fret dans le navire");
            }
            else
            {
                this.QteFret = this.QteFret - quantite;
            }
        }

        /// <summary>
        /// Méthode qui indique si le navire contient encore du fret.
        /// </summary>
        /// <returns>Renvoie si oui ou non le navire est vide.</returns>
        public bool EstDecharge()
        {
            if (this.qteFret == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
