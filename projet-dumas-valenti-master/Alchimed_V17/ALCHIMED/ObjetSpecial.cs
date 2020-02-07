using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Enumération des effets d'un objet spécial
    //     Les effets commençant par "p_" sont propres aux potions (classe héritée d'ObjetSpecial)
    public enum Effets
    {
        force1,   // augmente force
        force2,   // augmente force
        force3,   // augmente force
        stress,   // diminue stress
        vieP,   // augmente vie
        vieM,   // diminue vie
        regenerateur,  // diminue stress, augmente vie
        p_stress,   // POTION, diminue stress
        p_vieP,   // POTION, augmente vie
        p_vieM   // POTION, diminue vie
    }

    // Classe ObjetSpecial qui hérite de Objet
    class ObjetSpecial : Objet
    {
        protected Effets _effet;

        // Constructeur d'ObjetSpecial
        public ObjetSpecial(string nom, string indic, Effets effet) : base(nom, indic)
        {
            _effet = effet;
        }
        
        // Procédure qui affecte au joueur l'effet de l'objet
        // En entrée : le joueur pj souhaitant interagir avec l'objet
        internal override void Interagir(Joueur pj)
        {
            switch (_effet)
            {
                case Effets.force1:
                    pj._ptForce += 10;
                    Console.WriteLine("Vous gagnez 10 points de force. Vous avez maintenant {0} points de force", pj._ptForce);
                    break;

                case Effets.force2:
                    pj._ptForce += 15;
                    Console.WriteLine("Vous gagnez 15 points de force. Vous avez maintenant {0} points de force", pj._ptForce);
                    break;

                case Effets.force3:
                    pj._ptForce += 30;
                    Console.WriteLine("Vous gagnez 30 points de force. Vous avez maintenant {0} points de force", pj._ptForce);
                    break;

                case Effets.stress:
                    pj._ptStress = 0;
                    Console.WriteLine("Vous êtes maintenant détendu.");
                    break;

                case Effets.vieP:
                    pj._ptVie = 100;
                    Console.WriteLine("Vous êtes maintenant en pleine forme, vous avez 100 points de vie.");
                    break;

                case Effets.vieM:
                    pj._ptVie -= 20;
                    Console.WriteLine("Vous perdez 20 points de vie. Il vous reste {0} points de vie", pj._ptVie);
                    break;

                case Effets.regenerateur:
                    pj._ptVie = 100;
                    pj._ptStress = 0;
                    Console.WriteLine("Vous avez récupéré des forces. Vous avez maintenant {0} points de vie et êtes détendu.", pj._ptVie);
                    break;
            }
        }
    }
}
