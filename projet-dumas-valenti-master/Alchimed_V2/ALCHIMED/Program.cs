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

            Objet ob1 = new Objet("un lit", "un beau lit", "vieP");
            Objet ob2 = new Objet("une table", "une belle table", "vieP");
            Objet ob3 = new Objet("une chaise", "une belle chaise", "vieP");
            Objet ob4 = new Objet("une couverture", "une belle couverture", "vieP");
            Objet ob5 = new Objet("un tabouret", "un beau tabouret", "vieP");

            List<Objet> objetsInfirmerie = new List<Objet>(){ob1,ob2,ob3};

            List<Objet> objetsBureau = new List<Objet>() { ob4, ob5 };
            
            Piece infirmerie = new Piece("l'infirmerie",objetsInfirmerie);

            Piece bureau = new Piece("le bureau", objetsBureau);

            Joueur Titan = new Joueur("Titan", 2, 10);

            infirmerie.Numeroter();

            Console.WriteLine(infirmerie);

            infirmerie.Lister();

            

            Titan.DeplacerVersObjet(infirmerie);

            bureau.Numeroter();

            Console.WriteLine(bureau);

            bureau.Lister();

            Titan.DeplacerVersObjet(bureau);

        
    
        }
    }
}
