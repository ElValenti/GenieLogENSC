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


        // Affichage lors d'nteraction avec l'objet
        public void AfficheIndication()
        {
            Console.WriteLine(_indication);
        }
         
        // Effet de l'interaction avec l'objet
        public void Interagir(Joueur pj)
        {
            switch (_effet)
            {
                case "force1":
                    pj._ptForce += 10;
                    break;

                case "force2":
                    pj._ptForce += 15;
                    break;

                case "force3":
                    pj._ptForce += 30;
                    break;

                case "stress":
                    pj._ptStress = 0;
                    break;

                case "vieP":
                    pj._ptVie = 100;
                    break;

                case "vieM":
                    pj._ptVie -= 20;
                    break;
            }
        }
        
        // Créer une chaîne de caractères comportant les nom de la pièce
        public override string ToString()
        {
            string ch = (_nom);
            return ch;
        }



    }
}
