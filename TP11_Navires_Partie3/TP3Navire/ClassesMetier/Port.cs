using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    class Port
    {
        private string nom;
        private string latitude;
        private string longitude;
        private int nbPortique;
        private int nbQuaisTanker;
        private int nbQuaisSuperTanker;
        private int nbQuaisPassager;
        
        
        public string Nom { get => nom; }
        public string Latitude { get => latitude; }
        public string Longitude { get => longitude; }
        public int NbPortique { get => nbPortique; set => nbPortique = value; }
        public int NbQuaisTanker { get => nbQuaisTanker; set => nbQuaisTanker = value; }
        public int NbQuaisSuperTanker { get => nbQuaisSuperTanker; set => nbQuaisSuperTanker = value; }
        public int NbQuaisPassager { get => nbQuaisPassager; set => nbQuaisPassager = value; }
        
        
        public Port(string nom, string latitude, string longitude, int nbPortique, int nbQuaisTanker, int nbQuaisSuperTanker, int nbQuaisPassager)
        {
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
            this.nbPortique = nbPortique;
            this.nbQuaisTanker = nbQuaisTanker;
            this.nbQuaisSuperTanker = nbQuaisSuperTanker;
            this.nbQuaisPassager = nbQuaisPassager;
        }

        



    }
}