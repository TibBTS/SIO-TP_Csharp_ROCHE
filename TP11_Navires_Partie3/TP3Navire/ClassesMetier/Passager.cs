using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    class Passager
    {
        private string numPasseport;
        private string nom;
        private string prenom;
        private string nationalité;
        
        public string NumPasseport { get => numPasseport;  }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Nationalité { get => nationalité; }

        public Passager(string numPasseport, string nom, string prenom, string nationalité)
        {
            this.numPasseport = numPasseport;
            this.nom = nom;
            this.prenom = prenom;
            this.nationalité = nationalité;
        }

        
    }
}
