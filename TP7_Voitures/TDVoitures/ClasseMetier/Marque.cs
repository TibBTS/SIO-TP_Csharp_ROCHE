using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDVoitures.Outils;

namespace TDVoitures.ClasseMetier
{
    class Marque
    {
        private int id;
        public string nom;
        private Pays nationalite;

        public string Nom { get => nom; }
        public int Id { get => id; }
        public Pays Nationalité { get => nationalite; }

        public Marque (int id,string nom,Pays nationalite)
        {
            this.id = id;
            this.nom = nom;
            this.nationalite = nationalite;
        }

        //Marque m = new Marque(1, "Peugeot", Pays.France);
    }
}
