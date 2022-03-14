using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesMetier
{
    class Tanker : Navire
    {
        private string typeFluide;
        
        public string TypeFluide { get => typeFluide; set => typeFluide = value; }
        
        public Tanker(string imo, char nom, string latitude, string longitude, int tonnageDT, int tonnageDWT, int tonnageActuel, string typeFluide)
            : base(imo, nom, latitude, longitude, tonnageDT, tonnageDWT, tonnageActuel)
        {

        }


    }
}
