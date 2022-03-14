using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    abstract class Navire
    {
        private string imo;
        private char nom;
        private string latitude;
        private string longitude;
        private int tonnageGT;
        private int tonnageDWT;
        private int tonnageActuel;

        protected string Imo { get => imo; }
        protected char Nom { get => nom; }
        protected string Latitude { get => latitude; set => latitude = value; }
        protected string Longitude { get => longitude; set => longitude = value; }
        protected int TonnageGT { get => tonnageGT;  }
        protected int TonnageDWT { get => tonnageDWT;  }
        protected int TonnageActuel { get => tonnageActuel; set => tonnageActuel = value; }

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
