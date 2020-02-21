﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Program
    {
        public static List<Piece> Alchimed;
        public static Joueur pers;
        static void Main(string[] args)
        {
            bool rejouer = true;
            do {
                // Instanciation du personnage joueur
                Console.ForegroundColor = ConsoleColor.Cyan;                
                Console.Write("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage");
                Console.WriteLine("Veuillez entrer son prénom");
                Console.ResetColor();
                string prenom = Console.ReadLine();
                Joueur titan = new Joueur(prenom);
                Program.pers= titan;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
                titan.AttribuerCaracteristique();
                Console.WriteLine("\nAmusez vous bien !");
                Console.ResetColor();

                //Instanciation de l'environnement de jeu

                // Construction des personnages non joueurs
                Bagarreur edgar = new Bagarreur("Edgar", 20);

                // Construction des objets
                ObjetSpecial ob1 = new ObjetSpecial("un lit", "Que ce lit est douillet...", Effets.regenerateur);
                ObjetSpecial ob2 = new ObjetSpecial("un poste radio", "Bonne idée, écoutons un peu de musique pour se détendre...", Effets.stress);
                ObjetSpecial ob3 = new ObjetSpecial("une table avec de la nourriture", "Il y a des smoothies et des gateaux, vous vous régalez !", Effets.vieP);
                ObjetSpecial ob4 = new ObjetSpecial("des haltères", "Vous pouvez utiliser les haltères pour un petit entraînement du haut du corps.",Effets.force1);
                ObjetSpecial ob5 = new ObjetSpecial("une presse", "Vous pouvez entraîner le bas de votre corps grâce à la presse !",Effets.force2);
                ObjetSpecial ob6 = new ObjetSpecial("un tapis de course", "Votre cardio va vite s'améliorer avec cet entraînement !", Effets.force3);
                Objet ob7 = new Objet("une armoire", "Cette armoire est remplie de toutes sortes de choses...");
                Objet ob8 = new Objet("une table basse", "Il y a un tas de journaux et de livres posés ici...");
                Objet ob9 = new Objet("une blouse sur le porte manteau", "C'est une très belle blouse ! Je ne sais pas à qui elle est...");
                Objet ob10 = new Objet("un tableau", "Ce tableau est magnifique ! On pourrait rester ici des heures à le contempler...");
                Objet ob11 = new Objet("une fenêtre", "On a l'impression d'être en pleine nature ici ! Il y a des arbres et des fleurs à perte de vue...");
                Objet ob12 = new Objet("une lampe de bureau", "Cette lampe me rappelle celle de ma grand mère...");
                Objet ob13 = new Objet("un canapé", "Ce canapé marron a l'air douillet, et il vous tend les bras...");
                Objet ob14 = new Objet("des paillasses", "Ces paillasses me seront utiles pour mélanger les substances et fabriquer la potion.");
                Objet ob15 = new Objet("une armoire", "C'est génial, cette armoire est remplie de substances chimiques en tous genre.");
                Objet ob16 = new Objet("un carton", "Ce carton a l'air poussiéreux...");
                Objet ob17 = new Objet("un livre", "Je me demande ce qu'il y a dans ce livre...");

                // Construction des salles
                Piece salleRepos = new Piece("la salle de repos", new List<Objet>() { ob1, ob2, ob3 });
                Piece salleEntrainement = new Piece("la salle d'entraînement", new List<Objet>() { ob4, ob5, ob6 });
                Piece salleEtude = new Piece("la salle d'étude", new List<Objet>() { ob7, ob8, ob9, ob10, ob11, ob12, ob13 });
                salleEtude.AttribuerSavoir();
                Piece laboratoire = new Piece("le laboratoire", new List<Objet>() { ob14, ob15, ob16, ob17 });

                //Construction du Bâtiment Alchimed, enceinte du jeu
                Alchimed = new List<Piece> { salleRepos, salleEtude, salleEntrainement, laboratoire };

                Console.WriteLine("\nEnfin ! La lettre d’Alchimed est arrivée...\n 'Félicitations, vous avez été présélectionné pour " +
                    "intégrer notre prestigieux\n  programme ! Nous vous invitons désormais à nous rejoindre afin de vous\n  préparer au mieux " +
                    "à la sélection finale. Comme vous le savez, cela consiste\n  à la fabrication d’un médicament dans un contexte imposé et un temps imparti.'");

                Console.WriteLine("Deux jours après, je me rendais à l’adresse indiquée dans la lettre et me\ntrouvais devant un bâtiment imposant," +
                    " d’un blanc éclatant.\nJe me présentais alors à l'accueil d’Alchimed...\n\n 'Bonjour, bienvenue chez Alchimed ! Vous êtes" +
                    " {0} n’est ce pas ? Je vais\n vous présenter les locaux qui vous ont été attribués et les différents éléments à votre" +
                    " disposition.Vous pourrez rester ici aussi longtemps que nécessaire !\n Suivez - moi...\n\n La première pièce à votre gauche" +
                    " est la salle de repos, où vous pourrez vous\n détendre et vous reposer. Ensuite, la seconde pièce à votre gauche est la\n salle d'étude," +
                    " c'est ici que vous allez pouvoir enrichir votre culture. Sur\n votre droite se trouve la salle d'entraînement, où divers équipements" +
                    " vous\n permettront d'améliorer votre force. Enfin, au boût du couloir se trouve le\n grand Laboratoire. Lorsque vous serez " +
                    "suffisamment entraîné et vous sentirez\n prêt, présentez vous devant l'entrée. C'est là où se déroulera l'épreuve finale" +
                    " Je vous laisse maintenant !'", titan._nom);

                //Première action du joueur : choisir une pièce à explorer
                Piece destination = ChoisirPiece(Alchimed, titan);

                // boucle choix objet-action dans la pièce courante
                do
                {
                    titan.DeplacerVersObjet(destination);
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
         * En Entrée: la liste des différentes pièces de la partie en cours et le personnage joueur
         * En sortie: la pièce choisie par le joueur
         */
        public static Piece ChoisirPiece(List<Piece> listeChoixPossibles, Joueur j)
        {
            //contrôle si l'action a été effectuée ou non
            bool estEntre = false;
            
            //lieu d'arrivée du joueur après exécution de la fonction
            Piece destination;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nOù voulez vous aller ?");
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