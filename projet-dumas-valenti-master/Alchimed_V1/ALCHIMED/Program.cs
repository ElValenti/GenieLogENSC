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

            List<Objet> objetsInfirmerie = new List<Objet>(){ob1,ob2,ob3};
            
            Piece infirmerie = new Piece("l'infirmerie",objetsInfirmerie);

            Console.WriteLine(infirmerie);

            Joueur Titan = new Joueur("Titan", 2, 10);

            Console.WriteLine(Titan);

            ob3.AfficheIndication();

        }
    }
}
