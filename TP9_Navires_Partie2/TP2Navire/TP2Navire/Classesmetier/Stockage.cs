// <copyright file="Stockage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP2Navire.Classesmetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GestionNavire.Exceptions;

    /// <summary>
    /// Classe mettant a disposition tout ce qui concerne le stockage des navires.
    /// </summary>
    internal class Stockage
    {
        private int numero;
        private int capaciteMaxi;
        private int capaciteDispo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stockage"/> class.
        /// </summary>
        /// <param name="numero">Il s'agit du numéro du stockage dans le port.</param>
        /// <param name="capaciteMaxi">Capacité de stockage maximum en tonnes.</param>
        /// <param name="capaciteDispo">Capacité de stockage disponible exprimé en tonnes.</param>
        public Stockage(int numero, int capaciteMaxi, int capaciteDispo)
        {
            this.numero = numero;
            this.CapaciteMaxi = capaciteMaxi;
            this.CapaciteDispo = capaciteDispo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stockage"/> class.
        /// Constructeur surchargé.
        /// </summary>
        /// <param name="numero">Donne l'identifiant unique de chaque stockage.</param>
        /// <param name="capaciteMaxi">Donne la capacité maximum qu'un stockage peux avoir.</param>
        public Stockage(int numero, int capaciteMaxi)
    : this(numero, capaciteMaxi, capaciteMaxi)
        {
        }

        /// <summary>
        /// Gets or sets permet d'obtenir le numero de stockage dans le port.
        /// </summary>
        public int Numero { get => this.numero; set => this.numero = value; }

        /// <summary>
        /// Gets or sets permet d'avoir capacité de stockage maximum en tonnes. Modifiable et accessible depuis l extérieur de la classe.
        /// </summary>
        public int CapaciteMaxi
        {
            get => this.capaciteMaxi;
            set
            {
                if (value >= 0)
                {
                    this.capaciteMaxi = value;
                }
                else
                {
                    throw new GestionPortException("Impossible de créer un stockage avec une capacité négative");
                }
            }
        }

        /// <summary>
        /// Gets permet de récupérer la capacité disponible en tonnes.
        /// </summary>
        public int CapaciteDispo
        {
            get => this.capaciteDispo;
            private set
            {
                if (value <= 0)
                {
                    throw new GestionPortException("La capacité dispo ne peut etre inférieur ou null.");
                }
                else if (value > this.CapaciteMaxi)
                {
                    throw new GestionPortException("Impossible de stocker plus que la capacité disponible");
                }
                else
                {
                    this.capaciteDispo -= value;
                }
            }
        }

        /// <summary>
        /// Stock une quantié demander en paramètre et réduit la capacité disponible.
        /// </summary>
        /// <param name="quantite">Donne une quantité positive qui réduira la capacité disponible.</param>
        public void Stocker(int quantite)
        {
            if (quantite < 0)
            {
                throw new GestionPortException("La quantité à stocker dans un stockage ne peut être négative ou nulle");
            }
            else if (this.CapaciteDispo < quantite)
            {
                throw new GestionPortException("Impossible de stocker plus que la capacité disponible dans le stockage");
            }
            else
            {
                this.CapaciteDispo = this.capaciteDispo - quantite;
            }
        }
    }
}
