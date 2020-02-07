using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    public enum Acces
    {
        Autorise,
        RefuseEtude,
        RefuseEntrainement
    }

    class Piece
    {
        public string _nom;
        public List<Objet> _objets;
        public int _num { get; set; }

        // Constructeur 
        public Piece(string nom, List<Objet> objets)
        {
            _nom = nom;
            _objets = objets;
        }

        public bool testLabo()
        {
            bool isLabo = false;
            if (_nom == "le laboratoire")
            {
                isLabo = true;
            }
            return isLabo;
        }

        // Acceder(savoirs,ptForce) vérifie si les conditions d'entrée sont respectées et renvoie un élément de l'énumération
        public Acces Acceder(List<Savoirs> savoirs, int ptForce)
        {
            if (testLabo())
            {
                if (ptForce >= 100)
                {
                    if (savoirs.Count == 3)
                        return Acces.Autorise;
                    else
                        return Acces.RefuseEtude;
                }
                return Acces.RefuseEntrainement;
            }
            return Acces.Autorise;
        }

        // Assigner un numéro à chaque objet de la pièce
        public void Numeroter()
        {
            int compteur = 0;
            foreach (Objet objet in _objets)
                {
                    compteur++;
                    objet.Num = compteur;
                }
        }

        // Attribuer un savoir à trois objets choisis aléatoirement de la salle étude
        public void AttribuerSavoir()
        {
                Random alea = new Random();
                int r = 0;
                for (int i = 0; i < 3; i++)
                {
                    do
                    { 
                        r = alea.Next(_objets.Count);
                    } while (_objets[r].Verif() == true);

                    _objets[r].Enseignement = (Savoirs)i;
                }
           
        }

        // Proposition d'interaction
        public void Lister()
        {
            string ch = ("Quel élément voulez-vous examiner ? Taper le numéro de l'élément souhaité\n");
            foreach (Objet objet in _objets)
            {
                ch += objet.Num + " : " + objet + "\n";
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ch);
            Console.ResetColor();
        }

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = "";
            if (!testLabo())
            {
                ch = ("Vous vous trouvez maintenant dans " + _nom + ". Vous voyez ");
            }
            else
            {
                ch = ("Vous vous apprêtez à entrer dans le grand Laboratoire...\nComme vous le savez, vous allez être immergé dans un certain contexte blablabla. " +
                    "Vous êtes prêt, vous posez votre main sur la poignée, l'actionnez, vous arrivez dans une pièce sombre et froide." +
                    " Un homme s'adresse à vous. Blabla pandémie blablabla potion pour blablabla. Mais soyez vigilant... " +
                    "ici tout peut arriver... blabla décor immergeant (alarme, etc). Autour de vous, vous voyez ");
            }

            foreach (Objet objet in _objets)
            {
                ch += objet + ", ";
            }

            return ch;
        }



        /* procédure permettant de récupérer les paramètres de jeu selon le niveau. 
         En entrée : N correspond au niveau choisi par le joueur. 
         En sortie, la fonction renvoie nbC (nombre de colonnes), nbL (nombre de lignes) et nbE (nombre d'éléments) */
        /*
        public static void paramNiveau(int N, out int nbC, out int nbL, out int nbE)
        {
            // Création d'une instance de StreamReader pour permettre la lecture de notre fichier source 
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("iso-8859-1");

            /* ouverture du fichier source (à placer dans le même dossier que le fichier .exe 
            (-dans bin/debug- dans un streamreader)) 
            StreamReader monStreamReader = new StreamReader("./mastermind_param.txt", encoding);

            string fichier = monStreamReader.ReadLine(); //découpage du fichier en lignes 

            int compteligne = 1; //indicateur de la première ligne lue dans fichier par le StreamReader

            //initialisation de nos paramètres de sortie
            nbC = 0;
            nbL = 0;
            nbE = 0;

            while (fichier != null) //lecture des lignes du fichier une par une jusqu'à ce qu'une ligne soit nulle
            {
                fichier = monStreamReader.ReadLine();
                compteligne += 1; //incrémentation du compteur (qui compte le nombre de lignes)

                //récupération des paramètres du niveau débutant
                if ((N == 1) && (compteligne == 7))
                {
                    string[] mot = fichier.Split(';', ':'); //création d'un tableau de string contenant un découpage de "fichier" à chaque ";" et ":"
                    nbC = int.Parse(mot[1]); //nombre de colonnes du plateau de mastermind (i.e. nombre de composants de la combinaison à deviner)
                    nbL = int.Parse(mot[2]); // nombre de lignes du plateau de mastermind (i.e. nombre de tentatives maximum)
                    nbE = int.Parse(mot[3]); // nombre d'éléments possibles pour établir la combinaison à deviner
                }

                // récupération des paramètres du niveau normal
                if ((N == 2) && (compteligne == 8))
                {
                    string[] mot = fichier.Split(';', ':');
                    nbC = int.Parse(mot[1]); //nombre de colonnes du plateau de mastermind (i.e. nombre de composants de la combinaison à deviner)
                    nbL = int.Parse(mot[2]); // nombre de lignes du plateau de mastermind (i.e. nombre de tentatives maximum)
                    nbE = int.Parse(mot[3]); // nombre d'éléments possibles pour établir la combinaison à deviner
                }

                // récupération des paramètres du niveau expert
                if ((N == 3) && (compteligne == 9))
                {
                    string[] mot = fichier.Split(';', ':');
                    nbC = int.Parse(mot[1]); //nombre de colonnes du plateau de mastermind (i.e. nombre de composants de la combinaison à deviner)
                    nbL = int.Parse(mot[2]); // nombre de lignes du plateau de mastermind (i.e. nombre de tentatives maximum)
                    nbE = int.Parse(mot[3]); // nombre d'éléments possibles pour établir la combinaison à deviner
                }
            }

            monStreamReader.Close(); // fermeture du StreamReader  
        } */


    }
}
