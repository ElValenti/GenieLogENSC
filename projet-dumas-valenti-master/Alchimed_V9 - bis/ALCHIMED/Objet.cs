using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Objet
    {
        public string Nom { get; private set; }
        protected string _description;
        public int Num { get { return Piece._objets.IndexOf(this); } }
        internal Savoirs Enseignement { get; set; } 

        // Constructeur 
        public Objet(string nom, string descr)
        {
            Nom = nom;
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
            string ch = (Nom);
            return ch;
        }



    }
}
