using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Objet
    {
        protected string _nom;
        protected string _description;
        internal int Num {get;set;}
        internal Savoirs Enseignement { get; set; } 

        public string Nom { get; }

        // Constructeur 
        public Objet(string nom, string descr)
        {
            _nom = nom;
            _description = descr;
            Enseignement = Savoirs.Aucun;
        }


        // Affichage lors d'interaction passive avec l'objet
        public void AfficheDescription()
        {
            Console.WriteLine(_description);
        }

        public virtual void Interagir(Joueur pj)
        {
        }

        // vérifie si l'objet a un savoir (renvoie false si savoir est aucun et true si savoir est autre)
        public bool Verif()
        {
            if (Enseignement == Savoirs.Aucun)
                return false;
            else
                return true;
        }
        

        // Créer une chaîne de caractères comportant le nom de la pièce
        public override string ToString()
        {
            string ch = (_nom);
            return ch;
        }



    }
}
