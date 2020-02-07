using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    public abstract class Personnage
    {
        public string _nom;
        public int _ptVie;

        // Constructeur 
        public Personnage(string nom, int ptVie)
        {
            _nom = nom;
            _ptVie = ptVie;
        }
        



    }
}
