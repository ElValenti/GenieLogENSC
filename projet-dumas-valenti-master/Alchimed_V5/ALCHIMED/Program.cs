using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage,\nVeuillez entrer son nom");
            string nom = Console.ReadLine();
            Console.WriteLine("\nVeuillez entrer son prénom");
            string prenom = Console.ReadLine();
            Joueur Titan = new Joueur(prenom);
            Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
            Titan.AttribuerCaracteristique();
            

            Console.WriteLine(Titan);

            Objet ob1 = new Objet("un lit", "un beau lit", "force2");
            Objet ob2 = new Objet("une table", "une belle table", "force2");
            Objet ob3 = new Objet("une chaise", "une belle chaise", "force2");
            Objet ob4 = new Objet("une couverture", "une belle couverture", "force3");
            Objet ob5 = new Objet("un tabouret", "un beau tabouret", "force3");
            Objet ob6 = new Objet("une armoire", "une belle armoire remplies", "VieM");
            Objet ob7 = new Objet("une blouse", "un très belle blouse", "VieM");

            List<Objet> objetsInfirmerie = new List<Objet>(){ob1,ob2,ob3};

            List<Objet> objetsBureau = new List<Objet>() { ob4, ob5 };

            List<Objet> objetsLaboratoire = new List<Objet>() { ob6, ob7 };

            Piece infirmerie = new Piece("l'infirmerie",objetsInfirmerie);

            Piece bureau = new Piece("le bureau", objetsBureau);

            Piece laboratoire = new Piece("le laboratoire", objetsLaboratoire);





             infirmerie.Numeroter();

            Console.WriteLine(infirmerie);

            infirmerie.Lister();

            Titan.DeplacerVersObjet(infirmerie);

            infirmerie.Lister();

            Titan.DeplacerVersObjet(infirmerie);

            infirmerie.Lister();

            Titan.DeplacerVersObjet(infirmerie);

            Console.WriteLine(Titan);

            
            bureau.Numeroter();

            Console.WriteLine(bureau);

            bureau.Lister();

            Titan.DeplacerVersObjet(bureau);

            bureau.Lister();

            Titan.DeplacerVersObjet(bureau);

            bureau.Lister();

            Titan.DeplacerVersObjet(bureau);

            bureau.Lister();

            Titan.DeplacerVersObjet(bureau);

            Console.WriteLine(Titan);

            Titan._savoirs.Add(Savoirs.Chimie);
            Titan._savoirs.Add(Savoirs.Culture);

            List<Piece> pieces = new List<Piece> { infirmerie, bureau, laboratoire };

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Où voulez vous aller ?");

            foreach (Piece piece in pieces)
            {
                Console.WriteLine(piece._nom + "\n");
            }

            Console.ResetColor();
            
            Titan.Deplacer(laboratoire);



        }
    }
}
