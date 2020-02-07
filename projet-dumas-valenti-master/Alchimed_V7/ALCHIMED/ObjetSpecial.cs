using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Enumération des effets qu'un objet spécial
    //peut avoir sur le joueur
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
        //caractéristique principale d'un objet spécial :
        //a un effet sur les caractéristiques du joueur
        private Effets _effet;

        // Constructeur
        public ObjetSpecial(string nom, string indic, Effets effet) : base(nom, indic)
        {
            _effet = effet;
        }

        // Application de l'effet de l'objet sur le joueur au moment de l'interaction
        public override void Interagir(Joueur pj)
        {
            switch (_effet)
            {
                // l'effet "force1" ajoute 10points de force au joueur
                case Effets.force1:
                    pj._ptForce += 10;
                    break;

                case Effets.force2:
                    pj._ptForce += 15;
                    break;

                case Effets.force3:
                    pj._ptForce += 30;
                    break;

             // l'effet "stress" remet à 0 les points de stress du joueur
                case Effets.stress:
                    pj._ptStress = 0;
                    break;

             // l'effet "VieP" remet à 100 les points de vie du joueur
                case Effets.vieP:
                    pj._ptVie = 100;
                    break;

             // l'effet "vieM" diminue de 20points la vie du joueur
                case Effets.vieM:
                    pj._ptVie -= 20;
                    break;
            }
        }
    }
}
