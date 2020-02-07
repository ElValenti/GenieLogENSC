using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    public enum Effets
    {
        force1,
        force2,
        force3,
        stress,
        vieP,
        vieM
    }

    class ObjetSpecial : Objet
    {
        private Effets _effet;

        // Constructeur
        public ObjetSpecial(string nom, string indic, Effets effet) : base(nom, indic)
        {
            _effet = effet;
        }

        // Effet de l'interaction avec l'objet
        public override void Interagir(Joueur pj)
        {
            switch (_effet)
            {
                case Effets.force1:
                    pj._ptForce += 10;
                    break;

                case Effets.force2:
                    pj._ptForce += 15;
                    break;

                case Effets.force3:
                    pj._ptForce += 30;
                    break;

                case Effets.stress:
                    pj._ptStress = 0;
                    break;

                case Effets.vieP:
                    pj._ptVie = 100;
                    break;

                case Effets.vieM:
                    pj._ptVie -= 20;
                    break;
            }
        }
    }
}
