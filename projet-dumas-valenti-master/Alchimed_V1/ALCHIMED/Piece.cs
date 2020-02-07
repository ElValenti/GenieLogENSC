using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Piece
    {
        private string _nom;
        private List<Objet> _objets;

        // Constructeur initial
        public Piece(string nom, List<Objet> objets)
        {
            _nom = nom;
            _objets = objets;
        }

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = (" Vous vous trouvez maintenant dans " + _nom + ". Vous voyez : \n");
            int compteur = 0;
            foreach (Objet objet in _objets)
            {
                compteur++;
                ch += compteur + " : " + objet + "\n";
            }
            return ch;
        }

    }
}
