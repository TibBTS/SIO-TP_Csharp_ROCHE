using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireHeritage.ClassesTechniques
{
    public abstract class Test
    {
       public static void chargementinitial(Port port)
        {
            try
            {
                //cargo
                port.EnregistrerArriveePrevue(new Cargo)("IMO9780859","CMA CGM","43.43279 N","134.76258 W",140872,148992,123000,"Marchandises diverses"));
            }
        }

    }
}
