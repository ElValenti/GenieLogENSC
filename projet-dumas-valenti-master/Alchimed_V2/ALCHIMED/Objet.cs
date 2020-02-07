using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Objet
    {
        private string _nom;
        private string _indication;
        private string _effet;
        public int _num {get;set;}

        // Constructeur 
        public Objet(string nom, string indic, string effet)
        {
            _nom = nom;
            _indication = indic;
            _effet = effet;
        }


        // Interaction avec l'objet
        public void AfficheIndication()
        {
            Console.WriteLine(_indication);
        }
         
        /*
        public int Interagir(Joueur perso)
        {
            switch (_effet)
            {
                case "force1":
                    perso.ptForce += 10;
                    break;

                case "force2":
                    perso.ptForce += 15;
                    break;

                case "force3":
                    perso.ptForce += 30;
                    break;

                case "stress":
                    perso.ptStress = 0;
                    break;

                case "vieP":
                    perso.ptVie = 100;
                    break;

                case "vieM":
                    perso.ptVie -= 20;
                    break;


            }
        }
        */

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = (_nom);
            return ch;
        }



    }
}
