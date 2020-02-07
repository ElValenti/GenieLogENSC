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
            // Instanciation du personnage joueur
            Console.WriteLine("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage,\nVeuillez entrer son nom");
            string nom = Console.ReadLine();
            Console.WriteLine("\nVeuillez entrer son prénom");
            string prenom = Console.ReadLine();
            Joueur Titan = new Joueur(prenom);
            Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
            Titan.AttribuerCaracteristique();
            Console.WriteLine(Titan);

            //Instanciation de l'environnement de jeu

            //construction des personnages non joueurs
            Bagarreur edgar = new Bagarreur("Edgar", 20);
            //construction des objets
            Objet ob1 = new Objet("un lit", "un beau lit");
            Objet ob2 = new ObjetSpecial("une table", "une belle table", Effets.force1);
            Objet ob3 = new ObjetSpecial("une chaise", "une belle chaise", Effets.force2);
            Objet ob4 = new Objet("une couverture", "une belle couverture");
            Objet ob44 = new Objet("un plaid", "un plaid moche");
            Objet ob5 = new ObjetSpecial("un tabouret", "un beau tabouret", Effets.force3);
            Objet ob6 = new Objet("une armoire", "une belle armoire remplie");
            Objet ob66 = new Objet("une penderie", "une penderie mal rangée");
            Objet ob7 = new ObjetSpecial("une blouse", "un très belle blouse", Effets.vieM);

            //construction des salles
            Piece salleRepos = new Piece("la salle de repos", new List<Objet>(){ob1,ob2,ob3});
            Piece salleSport = new Piece("la salle de sport", new List<Objet>(){ob1,ob2,ob3});
            Piece salleEtude = new Piece("la salle d'étude", new List<Objet>() {ob4, ob44, ob5});
            salleEtude.AttribuerSavoir();
            Piece laboratoire = new Piece("le laboratoire", new List<Objet>() { ob6, ob66, ob7 });
            //Construction du Centre Alchimed, enceinte du jeu
            List<Piece> Alchimed = new List<Piece> {salleEtude, salleRepos, salleSport, laboratoire};

            //Première action du joueur : entrée dans une pièce
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Où voulez vous aller ?");
            int i = 0;
            //décompte des pièces
            foreach (Piece p in Alchimed)
            {
                i++;
                Console.WriteLine(i +" : "+ p.Nom);
            }
            Console.ResetColor();
            //gestion des erreurs de saisie
            int piecechoisie = VerifSaisie(i);
            Piece destination = Alchimed.ElementAt(piecechoisie - 1);
            Titan.Deplacer(destination);

            // boucle d'action dans la pièce
            do
            {
                Titan.DeplacerVersObjet(destination);
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Escape:
                    Quitter();
                    break;
                case ConsoleKey.A:
                    //AffichAide(); à créer
                    break;
                case ConsoleKey.I:
                    //AffichInventaire :Console.WriteLine(Titan);
                    break;
                    //case ....
            }
            Console.WriteLine(Titan);

            /*
            Console.WriteLine(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Console.WriteLine(Titan);

            Titan._savoirs.Add(Savoirs.Chimie);
            Titan._savoirs.Add(Savoirs.Culture);
            
            Titan.Deplacer(laboratoire);
                 //série d'actions quand le joueur souhaite créer une potion --> si veut interagir avec le bécher
            // Titan._inventaireSubstances.Add(Substances.dimercaprol);
            // bool prendlafuite = edgar.Defier(Titan);
            //if (prendlafuite == true) { Titan.Deplacer(salleRepos); }
        */


        } //fin du Main

        public static int VerifSaisie(int range)
        {
            int numChoix = 1; // valeur par défaut en cas d'échec 
            bool repValide = false;
            do
            {
                //récupération de la réponse
                string choix = Console.ReadLine();

                //vérification du contenu de la réponse
                if (choix == null)
                {
                    Console.WriteLine("Vous n'avez pas saisi de chiffre ! Veuillez saisir un chiffre entre 1 et "+range);
                }
                else
                {try
                    {
                        numChoix = int.Parse(choix);
                        repValide = true;
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez saisir un chiffre !");
                        repValide = false;
                    }
                }
            } while (repValide == false);
            return numChoix;
        }
        public static void Quitter()
        {
            Console.WriteLine("Voulez-vous vraiment quitter ? :'(... \nAppuyez sur Echap pour confirmer");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Appuyez sur la touche <Entrée> pour fermer la fenêtre");
            }
        }
    }
}
