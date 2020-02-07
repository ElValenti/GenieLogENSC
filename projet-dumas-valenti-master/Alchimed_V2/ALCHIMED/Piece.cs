using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Piece
    {
        private string _nom;
        public List<Objet> _objets;

        // Constructeur 
        public Piece(string nom, List<Objet> objets)
        {
            _nom = nom;
            _objets = objets;
        }

        // Assigner un numéro à chaque objet de la pièce
        public void Numeroter()
        {
            int compteur = 0;
            foreach (Objet objet in _objets)
                {
                    compteur++;
                    objet._num = compteur;
                }
        }

        // Proposition d'interaction
        public void Lister()
        {
            string ch = ("Que voulez-vous faire ? Taper le numéro de l'élément souhaité\n");
            foreach (Objet objet in _objets)
            {
                ch += objet._num + " : " + objet + "\n";
            }
            Console.WriteLine(ch);
        }

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = (" Vous vous trouvez maintenant dans " + _nom + ". Vous voyez ");
            foreach (Objet objet in _objets)
            {
                ch += objet + ", ";
            }
            return ch;
        }

    }
}
