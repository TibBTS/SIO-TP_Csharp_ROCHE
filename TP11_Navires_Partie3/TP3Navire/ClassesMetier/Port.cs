﻿using System;
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

    public void EnregistrerArrivee(Navire navire)
    {
        if (navireAttendus.ContainsValue(navire))
            {
                navireAttendus.Add(navire.Imo, navire);
                navireAttendus.Remove(navire.Imo);
            }
        else
        {
                throw new Exception("Le navire n'etait pas attendus");
        }
    }


    
    public void EnregistrerDepart(Navire navire)
    {
            if ()
            {
                navirePartis.Add(navire.Imo, navire);
                navireArrives.Remove(navire.Imo);
               
            }
            else
            {
                throw new Exception("Le navire n'est pas présent dans le port");
            }
    }
    public void AjoutNavireEnAttente(Navire navire)
      {
            navireEnAttente.Add(navire.Imo, navire);
      }
    public bool EstAttendu(string imo)
    {
            return navireEnAttente.ContainsKey(imo);
    }

    public bool EstPresent(string imo)
    {
            return navireArrives.ContainsKey(imo);
    }
    public bool EstEnAttente(string imo)
      {
            return navireEnAttente.ContainsKey(imo);
       }
    public int Chargement(string imo , int qté)
        {
            if (navireArrives.ContainsKey(imo))
            {
                if(this.navireArrives[imo].TonnageDWT > this.navireArrives[imo].TonnageActuel + qté)
                {
                    navireArrives[imo].TonnageActuel + qté;
                }
                else
                {
                    throw new Exception("Il n'y a pas assez de place pour charger cette quantité ");
                }
            }
        }


    }
}