using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Classe abstraite Personnage, ne pouvant être instanciée
    public abstract class Personnage
    {
        internal string _nom;
        internal int _ptVie;

        // Constructeur de Personnage
        public Personnage(string nom, int ptVie)
        {
            _nom = nom;
            _ptVie = ptVie;
        }
    }
}
