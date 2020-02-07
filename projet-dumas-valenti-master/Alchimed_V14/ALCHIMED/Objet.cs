using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Classe Objet
    class Objet
    {
        protected string _nom;
        protected string _description;
        internal int Num {get;set;}
        internal Savoirs Enseignement { get; set; }
        internal string Nom { get { return _nom;} }

        // Constructeur d'Objet
        public Objet(string nom, string descr)
        {
            _nom = nom;
            _description = descr;
            Enseignement = Savoirs.Aucun;
        }


        // Procédure d'affichage lors d'interaction passive avec l'objet
        internal void AfficheDescription()
        {
            Console.WriteLine(_description);
        }

        // Procédure virtuelle Interagir (sera redéfinie dans les classes héritées)
        internal virtual void Interagir(Joueur pj) { }

        // Méthode qui vérifie si l'objet a un savoir (renvoie false si savoir est aucun et true si savoir est autre)
        internal bool Verif()
        {
            if (Enseignement == Savoirs.Aucun)
                return false;
            else
                return true;
        }

        // Redéfinition de la méthode ToString()
        // Méthode permettant de créer une chaîne de caractères comportant le nom de la pièce
        public override string ToString()
        {
            string ch = (_nom);
            return ch;
        }



    }
}
