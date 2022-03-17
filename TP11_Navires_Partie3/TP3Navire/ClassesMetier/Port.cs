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
        private Dictionary<String, Navire> navireAttendus = new Dictionary<string, Navire>();
        private Dictionary<String, Navire> navireArrives = new Dictionary<string, Navire>();
        private Dictionary<String, Navire> navirePartis = new Dictionary<string, Navire>();
        private Dictionary<String, Navire> navireEnAttente = new Dictionary<string, Navire>();

        public Port(string nom, string latitude, string longitude, int nbPortique, int nbQuaisTanker, int nbQuaisSuperTanker, int nbQuaisPassager)
        {
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
            this.NbPortique = nbPortique;
            this.NbQuaisTanker = nbQuaisTanker;
            this.NbQuaisSuperTanker = nbQuaisSuperTanker;
            this.NbQuaisPassager = nbQuaisPassager;
        }

        public string Nom { get => nom;  }
        public string Latitude { get => latitude;  }
        public string Longitude { get => longitude; }
        public int NbPortique { get => nbPortique; set => nbPortique = value; }
        public int NbQuaisTanker { get => nbQuaisTanker; set => nbQuaisTanker = value; }
        public int NbQuaisSuperTanker { get => nbQuaisSuperTanker; set => nbQuaisSuperTanker = value; }
        public int NbQuaisPassager { get => nbQuaisPassager; set => nbQuaisPassager = value; }
        internal Dictionary<string, Navire> NavireAttendus { get => navireAttendus; }
        internal Dictionary<string, Navire> NavireArrives { get => navireArrives; }
        internal Dictionary<string, Navire> NavirePartis { get => navirePartis;  }
        internal Dictionary<string, Navire> NavireEnAttente { get => navireEnAttente; }
    

    public void enregistrerArriveePrevue(Navire navire)
    {
        NavireAttendus.Add(navire.Imo, navire);
    }

    public void EnregistrerArrivee(navire.Imo, navire,)
    {

    }

    public void EnregistrerDepart(Object)
    {
    }

    public bool EstAttendu(String)
    {

    }

    public bool EstPresent(String)
    {

    }



    }
}