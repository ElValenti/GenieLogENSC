using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Contenant : Objet
    {
        internal List<Contenant> _contenus { private set; get; }
        internal Substances[] _elements;
        

        // Constructeur d'Objet
        public Contenant(string nom, string descr, List<Contenant> contenus) : base(nom, descr)
        {
            _contenus = contenus;
        }

        public Contenant(string nom, string descr, int nbElements, Substances[] elements) : base(nom, descr)
        {
            _elements = elements;
        }

        // Procédure d'affichage lors d'interaction passive avec l'objet
        internal Contenant AfficheContenuO()
        {
            string ch = "\nEn fouillant, tout au fond, vous trouvez ";
            foreach (Contenant e in _contenus)
            {
                ch += e.Nom + " ! ";
                Console.WriteLine(ch);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSur quelle substance voulez-vous avoir des informations ?\n");
                e.ListerL();
                return e;
            }
            return null;
            
        }

        internal void AfficheContenuS()
        {
            string ch = "\nEn fouillant, vous trouvez : ";
            for (int i = 0; i < 9; i++)
            {
                ch += _elements[i] + ", ";
            }
            Console.WriteLine(ch);
        }

        internal void ListerO()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nQuel élément voulez-vous examiner ? Taper le numéro de l'élément souhaité\n");
            int compteur = 0;
            foreach (Contenant e in _contenus)
            {
                compteur++;
                e.Num = compteur;
                Console.WriteLine(e.Num + " : " + e.Nom);
            }
            Console.ResetColor();
        }

        internal void ListerS()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nQuelle substance voulez-vous prendre ?\n");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i+1 + " : " + _elements[i]);
            }
            Console.ResetColor();
        }

        internal void ListerL()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i + 1 + " : " + _elements[i]);
            }
            Console.ResetColor();
        }

        // Redéfinition de la méthode ToString()
        // Méthode permettant de créer une chaîne de caractères comportant les caractéristiques du conteant
        public override string ToString()
        {
           return _description;
        }
    }
}
