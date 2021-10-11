/**
 * Jeu du nombre caché
 * author : SquidGame
 * date : 05/10/2021
 */
using System;


namespace Testconsole
{
    class Program
    {
        static void Main(string[] args)
        {// instructions qui vont se répéter
            // déclaration
            int essai 0, valeur = 0, nbre = 1;
            //saisie du nombre a chercher
            Console.Write("Entrez le nombre a chercher = ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();
            // saisie du premier essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
            // boucle sur les essai
            while (essai != valeur)
            
               // test de l'essai par rapport a la valeur a chercher
                if (essai > valeur)
                
                    Console.WriteLine(" --> trop grand !");
                else
                Console.WriteLine(" --> trop petit !");
            
            // saisie d'un nouvel essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
          
            bool correct = false;
            // saisie du nombre a chercher
            while (!correct)
            
                try
                {
                    Console.Write("Entrez le nombre a chercher = ");
            valeur = int.Parse(Console.ReadLine());
            correct = true;
                }
                catch
                {
                    Console.Write("Erreur de saisie : saisissez une nombre entier ");
                }
            Console.Clear();
                    
                

            // compteur d'essais
            nbre++;

                
                // valeur trouvée
                Console.WriteLine("Vous avez trouvé en " + nbre + " fois !");
            Console.ReadLine();

            
        }
    }
}
