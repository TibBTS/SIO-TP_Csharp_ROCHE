using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    class Navire
    {
        private string imo;
        private char nom;
        private string latitude;
        private string longitude;
        private int tonnageDT;
        private int tonnageDWT;
        private int tonnageActuel;

        protected string Imo { get => imo; set => imo = value; }
        protected char Nom { get => nom; set => nom = value; }
        protected string Latitude { get => latitude; set => latitude = value; }
        protected string Longitude { get => longitude; set => longitude = value; }
        protected int TonnageDT { get => tonnageDT; set => tonnageDT = value; }
        protected int TonnageDWT { get => tonnageDWT; set => tonnageDWT = value; }
        protected int TonnageActuel { get => tonnageActuel; set => tonnageActuel = value; }

        public Navire(string imo, char nom, string latitude, string longitude, int tonnageDT, int tonnageDWT, int tonnageActuel)
        {
            this.Imo = imo;
            this.Nom = nom;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.TonnageDT = tonnageDT;
            this.TonnageDWT = tonnageDWT;
            this.TonnageActuel = tonnageActuel;
        }
    }
}
