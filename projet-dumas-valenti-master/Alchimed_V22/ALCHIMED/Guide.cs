using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Classe Guide qui hérite de la classe abstraite Personnage
    class Guide : Personnage
    {
        protected string _indice;
        private int nbGet;
        Random alea = new Random();

            //propriété
        public string Indice
        {
                get
                {
                    nbGet++;
                    return _indice;
                }
                set
                {
                    if (nbGet > 0)
                        _indice = "\nJe n'en sais malheureusement pas plus...";
                }
        }
            // Constructeurs de Guide
            public Guide(string nom, int ptVie) : base(nom, 100) { }

            public Guide(string nom, int ptVie, List<string> indices) : base(nom, 100)
            {
                int indexAleatoire = alea.Next(indices.Count);
                indices.ElementAt(indexAleatoire);
            }

            public override string ToString()
            {
                return _nom;
            }
        

    }
}
