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
        
        public string NumPasseport { get => numPasseport; set => numPasseport = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nationalité { get => nationalité; set => nationalité = value; }

        public Passager(string numPasseport, string nom, string prenom, string nationalité)
        {
            this.numPasseport = numPasseport;
            this.nom = nom;
            this.prenom = prenom;
            this.nationalité = nationalité;
        }

        
    }
}
