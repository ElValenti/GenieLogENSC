using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Joueur : Personnage
    {
        public int _ptStress;
        public int _ptForce;
        public List<Objet> _inventaire;

        // Constructeur 
        public Joueur(string nom, int ptStress, int ptForce) : base(nom, 100)
        {
            _ptStress = ptStress;
            _ptForce = ptForce;
            _inventaire = new List<Objet>();
        }
        //Constucteur des valeurs par défaut
        public Joueur(string nom) : this(nom, 0, 10)
        {
        }

        // permet au joueur de choisir entre trois caractéristiques, celle qu'il veut attribuer à son personnage
        // la caractéristique choisie agira soit sur ptVie soit sur ptForce soit sur les savoirs
        public void AttribuerCaracteristique()
        {
            string[] car = new string[3] { "Force", "Résistance", "Intelligence" };

            //Liste des caractériques avec un numéro pour chacune
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i + " : " + car[i - 1]);
            }
            //Récupération du choix du joueur
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    _ptForce = 50;
                    break;

                case 2:
                    _ptVie = 150;
                    break;

                case 3:
                    break;
            }
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
                    objet.Interagir(this);
                    }
                }
        }

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = ("\n   Personnage joueur :\n   " + _nom + "\n   Points de vie : " + _ptVie + "\n   Points de stress : " + _ptStress + "\n   Points de force : " + _ptForce + "\n");
            return ch;
        }
    }
}
