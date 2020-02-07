using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Bagarreur : Personnage
    {
        public Bagarreur(string nom, int ptVie) : base(nom, ptVie)
        {
        }

        public void Defier(Personnage p)
        {
            p.Defier(this);
            
        }
        
    }
}
