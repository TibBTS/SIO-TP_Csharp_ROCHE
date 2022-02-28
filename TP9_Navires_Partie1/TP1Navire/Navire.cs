using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Navire
{
    class Navire
    {
        private string imo;
        private string nom;
        private string libelleFret;
        private int qteFretMaxi;

        public string Imo { get => imo; }
        public string Nom { get => nom; set => Nom = value; }
        public string LibelleFret { get => libelleFret; set => libelleFret = value; }
        public int QteFretMaxi { get => qteFretMaxi; set => qteFretMaxi = value; }

        public Navire(string imo, string nom, string libelleFret, int qteFretMaxi)
        {
            this.imo = imo;
            this.nom = nom;
            this.libelleFret = libelleFret;
            this.qteFretMaxi = qteFretMaxi;
        }

        public Navire(string imo, string nom) :
            this(imo, nom, null, 0)
        { }

        public override string ToString()
        {
            return TestNavire.Affiche(this);
        }
    }
}
