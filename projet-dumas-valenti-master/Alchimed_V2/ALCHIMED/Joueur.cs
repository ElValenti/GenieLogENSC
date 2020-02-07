using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Joueur : Personnage
    {
        private int _ptStress;
        private int _ptForce;
        private List<Objet> _inventaire;
        
        // Constructeur 
        public Joueur (string nom, int ptStress, int ptForce) : base (nom, 100)
        {
            _ptStress = ptStress;
            _ptForce = ptForce;
            _inventaire = new List<Objet>();
        }

        /* public override void Combattre(Bagarreur Edgar)
        {
            _abscisse += 2; // provient de la classe Personnage, on peut l'utiliser ici car protected
            _ordonnee += 2; // provient de la classe Personnage, on peut l'utiliser ici car protected
        }
        */

        // Intéragir avec un objet de la pièce
        public void DeplacerVersObjet(Piece lieu)
        {
            int choix = int.Parse(Console.ReadLine());

            foreach (Objet objet in lieu._objets)
                {
                    if (objet._num == choix)
                    {
                        objet.AfficheIndication();
                    }
                }
        }

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = (_nom + "\n" + _ptVie + "\n" + _ptStress + "\n" + _ptForce);
            return ch;
        }
    }
}
