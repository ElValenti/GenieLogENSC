using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    public enum Substances
    {
        sub1,
        sub2,
        sub3,
        sub4,
        sub5,
        sub6,
        sub7,
        sub8,
        sub9
    }

    class Potion : ObjetSpecial
    {
        private List<Substances> _composition;

        // Constructeur
        public Potion(string nom, string indic, Effets effet, List<Substances> composition) : base(nom, indic, effet)
        {
            _composition = composition;
        }

        // Effet de la potion
        public override void Interagir(Joueur pj)
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
