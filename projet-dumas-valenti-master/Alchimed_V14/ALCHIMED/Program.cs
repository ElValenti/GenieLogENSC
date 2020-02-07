using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Program
    {
        public static List<Piece> Alchimed;
        public static Joueur Titan;
        static void Main(string[] args)
        {
            bool rejouer = true;
            do {
                // Instanciation du personnage joueur
                Console.WriteLine("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage,\nVeuillez entrer son nom");
                string nom = Console.ReadLine();
                Console.WriteLine("\nVeuillez entrer son prénom");
                string prenom = Console.ReadLine();
                Joueur Titan = new Joueur(prenom);
                Program.Titan= Titan;
                Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
                Titan.AttribuerCaracteristique();
                Console.WriteLine(Titan);

                //Instanciation de l'environnement de jeu

                //construction des personnages non joueurs
                Bagarreur edgar = new Bagarreur("Edgar la Bagarre", 20);
                //construction des objets
                Objet ob1 = new ObjetSpecial("un lit", "C'est un beau lit douillet", Effets.regenerateur);
                Objet ob2 = new ObjetSpecial("une table", "C'est une belle table", Effets.force1);
                Objet ob3 = new ObjetSpecial("une chaise", "C'est une belle chaise", Effets.force2);
                Objet ob4 = new Objet("une couverture", "C'est une belle couverture");
                Objet ob44 = new Objet("un plaid", "C'est juste un plaid moche");
                Objet ob5 = new ObjetSpecial("un tabouret", "C'est un beau tabouret", Effets.force3);
                Objet ob6 = new Objet("une armoire", "C'est une belle armoire remplie");
                Objet ob66 = new Objet("une penderie", "C'est juste une penderie mal rangée");
                Objet ob7 = new ObjetSpecial("une blouse", "un très belle blouse", Effets.vieM);
                //construction des salles
                Piece salleRepos = new Piece("la salle de repos", new List<Objet>() { ob1, ob2, ob3 });
                Piece salleSport = new Piece("la salle de sport", new List<Objet>() { ob1, ob2, ob3 });
                Piece salleEtude = new Piece("la salle d'étude", new List<Objet>() { ob4, ob44, ob5 });
                salleEtude.AttribuerSavoir();
                Piece laboratoire = new Piece("le laboratoire", new List<Objet>() { ob6, ob66, ob7 });
                //Construction du Centre Alchimed, enceinte du jeu
                Alchimed = new List<Piece> { salleEtude, salleRepos, salleSport, laboratoire };

                //Première action du joueur : entrée dans une pièce
                Piece destination = ChoisirPiece(Alchimed, Titan);
                // boucle choix objet-action dans la pièce courante
                do
                {
                    Titan.DeplacerVersObjet(destination);
                }
                while (Console.ReadKey().Key != ConsoleKey.A);

               //Console.WriteLine(Titan);

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
                //if (prendlafuite == true) { Titan.SeReposer(salleRepos); }
            */
                // fin du jeu : proposer de rejouer + enregistrement score

            } while (rejouer);
        }//fin du Main



        /* Méthode qui gère les éventuelles fautes de frappe lors de la saisie d'une commande par un joueur
         * En Entrée : l'intervalle de valeurs entières proposé au joueur
         * En Sortie : le choix du joueur sous la forme d'un entier
         */
        public static int VerifSaisie(int range)
        {
            int numChoix = 1; // valeur par défaut en cas d'échec 
            bool repValide = false;
            do
            {
                //récupération de la réponse
                string choix = Console.ReadLine();

                //vérification du contenu de la réponse
                /* if (choix.GetType() == typeof(string))
                {
                    //interactions déclenchées par pression sur une touche
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Escape:
                                Quitter();
                                break;
                            case ConsoleKey.A:
                                Console.WriteLine("\n   AIDE COMMANDES \n  Appuyer sur <Entrée> puis sur A pour afficher l'aide \n     <Entrée> + B : pour changer de pièce \n    <Entrée> + Echap : pour quitter\n     <Entrée> + I : pour afficher l'inventaire... \n\nPour sortir du menu d'aide et revenir au jeu, appuyez sur <Entrée> + 0");
                                break;
                            case ConsoleKey.I:
                                //AffichInventaire :Console.WriteLine(Titan)+BOUCLE FOREACH;
                                break;
                            case ConsoleKey.B:
                                Piece pieceSuivante = ChoisirPiece(Alchimed, Titan);
                                break;
                        }
                }
                //gestion des exceptions
                else*/
                { try
                    {
                        numChoix = int.Parse(choix);
                        repValide = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erreur : {0} \nVeuillez saisir un chiffre ou appuyer sur A pour obtenir de l'aide", e.Message);
                        repValide = false;
                    }
                }// à répéter jusqu'à ce que la réponse soit du type attendu et dans les valeurs attendues
            } while (repValide == false);
            return numChoix;
        }

        /* Méthode permettant au joueur de quitter la partie en cours
         * sans sauvegarde de sa progression
         */
        public static void Quitter()
        {
                Console.Clear();
                Environment.Exit(0);
        } 

        /*Méthode permettant de proposer au joueur de se déplacer dans les salles du jeu
         * En Entrée: la liste des différentes pièces de la partie en cours et le joueur courant
         * En sortie: la pièce choisie  par le joueur
         */
        public static Piece ChoisirPiece(List<Piece> listeChoixPossibles, Joueur j)
        {
            //contrôle si l'action a été effectuée ou non
            bool estEntre = false;
            
            //lieu d'arrivée du joueur après exécution de la fonction
            Piece destination;
            Console.ForegroundColor = ConsoleColor.Yellow;
            do
            {
                Console.WriteLine("Où voulez vous aller ?");
                int i = 0;
                //décompte des pièces
                foreach (Piece p in listeChoixPossibles)
                {
                    i++;
                    Console.WriteLine(i + " : " + p.Nom);
                }
                Console.ResetColor();

                //gestion des erreurs de saisie
                int piecechoisie = VerifSaisie(i);

                //correspondance entre la saisie et les propositions
                destination = listeChoixPossibles.ElementAt(piecechoisie - 1);

                //vérification du droit d'accès et description de la pièce de destination si autorisé 
                estEntre = j.Deplacer(destination);

            } while (!estEntre);

            return destination;
        }
    }
}
