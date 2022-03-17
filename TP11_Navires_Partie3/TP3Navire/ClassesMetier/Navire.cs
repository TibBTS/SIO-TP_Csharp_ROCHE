﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    abstract class Navire
    {
        protected string imo;
        protected char nom;
        protected string latitude;
        protected string longitude;
        protected int tonnageGT;
        protected int tonnageDWT;
        protected int tonnageActuel;

        public string Imo { get => imo; }
        public char Nom { get => nom; }
        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public int TonnageGT { get => tonnageGT;  }
        public int TonnageDWT { get => tonnageDWT;  }
        public int TonnageActuel { get => tonnageActuel; set => tonnageActuel = value; }

        public Navire(string imo, char nom, string latitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel)
        {
            this.imo = imo;
            this.nom = nom;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.tonnageGT = tonnageGT;
            this.tonnageDWT = tonnageDWT;
            this.TonnageActuel = tonnageActuel;
        }

       


    }
}
