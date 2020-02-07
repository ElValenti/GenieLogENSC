using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    //Enumération des substances, servant à la composition d'une potion
    public enum Substances
    {
        dimercaprol,
        glipizide,
        nalidixique,
        nitrofurantoïne,
        noramidopyrine,
        phytoménadione,
        rasburicase,
        sulfacétamide,
        sulfaméthizol
    }

    // Classe Potion qui hérite de ObjetSpecial
    class Potion : ObjetSpecial
    {
        private List<Substances> _composition;

        // Constructeur de Potion
        public Potion(string nom, string indic, Effets effet, List<Substances> composition) : base(nom, indic, effet)
        {
            _composition = composition;
        }

        // Procédure qui affecte au joueur l'effet de la potion consommée
        // En entrée : le joueur pj souhaitant interagir avec la potion c'est à dire la boire
        internal override void Interagir(Joueur pj)
        {
            switch (_effet)
            {
                case Effets.p_stress:
                    pj._ptStress -= 15;
                    break;

                case Effets.p_vieP:
                    pj._ptVie += 10;
                    break;

                case Effets.p_vieM:
                    pj._ptVie -= 10;
                    break;
            }
        }

        

    }
}
