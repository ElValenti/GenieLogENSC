using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Bagarreur : Personnage
    {
        private int _degat;
        public Bagarreur (string nom, int degat) : base (nom, 50)
        {
            _degat = degat;
        }

        public bool Defier(Joueur pj)
        {
            Substances substanceVolee = pj._inventaireSubstances[0];
            pj._inventaireSubstances.Remove(substanceVolee);
            Console.WriteLine(this._nom + " vous a volé le " + substanceVolee + " pour vous défier.");
            
            bool abandon = false;

            bool finCombat = false;

            while ((finCombat == false) && (abandon == false))
            {
                pj._ptVie -= this._degat;
                Console.WriteLine(this._nom + " vous attaque. Vous perdez " + this._degat + " points de vie. " +
                    "Il vous reste " + pj._ptVie + " points de vie.");
                Console.WriteLine("Que voulez-vous faire ?\n1 : Répliquer avec un coup de pied\n2 : Répliquer avec un coup de poing" +
                    "\n3 : Abandonner puis aller reprendre des forces dans la salle de repos");
                int choix = int.Parse(Console.ReadLine());
                if ((choix == 1) || (choix == 2))
                {
                    pj.Defier(this, choix);
                }
                if (choix == 3)
                {
                    abandon = true;
                }

                if ((pj._ptVie <= 0) || (this._ptVie <= 0))
                { 
                    finCombat = true;
                }
            }

            if (this._ptVie == 0)
            {
                pj._inventaireSubstances.Add(substanceVolee);
                Console.WriteLine("Bravo ! Vous avez récupéré la substance qui vous avait été volée !" +
                    " Vous pouvez continuer à préparer la potion.");
            }
            else if (abandon==true)
            {
                Console.WriteLine("Vous abandonnez et allez vous reposer");
            }
            else
            {
                // Appel à la fonction qui quitte le jeu
                Console.WriteLine("Perdu");
            }

            return abandon;
        }
    }
}
