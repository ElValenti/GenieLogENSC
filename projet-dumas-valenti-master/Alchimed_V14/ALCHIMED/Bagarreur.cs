using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Classe Bagarreur qui hérite de la classe abstraite Personnage
    class Bagarreur : Personnage
    {
        private int _degat;

        // Constructeur de Bagarreur
        public Bagarreur (string nom, int degat) : base (nom, 50)
        {
            _degat = degat;
        }

        // Méthode permettant au bagarreur de défier le joueur en lui volant une de ses substances et en l'attaquant
        // En entrée : le joueur pj
        // En sortie : un booléen indiquant si le joueur a abandonné (true si oui) et doit aller en salle de repos
        internal bool Defier(Joueur pj)
        {
            // la bagarreur vole une substance au joueur
            Substances substanceVolee = pj._inventaireSubstances[0];
            pj._inventaireSubstances.Remove(substanceVolee);
            Console.WriteLine(this._nom + " vous a volé le " + substanceVolee + " pour vous défier.");
            
            bool abandon = false;
            bool finCombat = false;

            // COMBAT
            while ((finCombat == false) && (abandon == false))
            {
                pj._ptVie -= this._degat;
                Console.WriteLine(this._nom + " vous attaque. Vous perdez " + this._degat + " points de vie. " +
                    "Il vous reste " + pj._ptVie + " points de vie.");

                Console.WriteLine("Que voulez-vous faire ?\n1 : Répliquer avec un coup de pied\n2 : Répliquer avec un coup de poing" +
                    "\n3 : Abandonner puis aller reprendre des forces dans la salle de repos");
                int choix = Program.VerifSaisie(3);

                if ((choix == 1) || (choix == 2)) // si le joueur choisit de répliquer
                {
                    pj.Defier(this, choix);
                }
                if (choix == 3) // si le joueur choisit d'abandonner et de quitter le laboratoire
                {
                    abandon = true;
                }

                if ((pj._ptVie <= 0) || (this._ptVie <= 0))
                { 
                    finCombat = true;
                }
            }

            // Test : pourquoi le combat s'est il arrêté

            // Soit le bagarreur n'a plus de vie, le joueur a gagné le combat
            if (this._ptVie <= 0)
            {
                pj._inventaireSubstances.Add(substanceVolee);
                Console.WriteLine("Bravo ! Vous avez récupéré la substance qui vous avait été volée !" +
                    " Vous pouvez continuer à préparer la potion.");
            }

            // Soit le joueur a abandonné
            else if (abandon==true)
            {
                Console.WriteLine("Vous abandonnez et allez vous reposer");
            }

            // Soit le joueur n'a plus de vie, le joueur a perdu la partie
            else
            {
                Program.Quitter();
                Console.WriteLine("Perdu");
            }

            return abandon;
        }
    }
}
