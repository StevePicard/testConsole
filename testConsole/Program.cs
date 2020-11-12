/**
 * Jeu du nombre caché
 * author : Emds
 * date : 10/11/2020
 */

using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration
            int valeur;
            int essai;
            int nbre;
            nbre = 1;
            valeur = 0 ;
            essai = 0;

            bool correct = false ;

            // Saisie du nombre à chercher
            Console.Write("Entrez le nombre à chercher = ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.ReadLine();

            // Saisie du premier essai
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : sasissez un nombre entier");
                }
            }
            Console.Clear();
            
            while (essai != valeur)
            {
            // Test de l'essai par rapport à la valeur chercher
            if (essai > valeur)
            {
                Console.WriteLine("--> Trop grand !");
            }
            else
            {
                Console.WriteLine("--> Trop petit !");
            }
            // Saisie d'un nouvel essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
            // Compteur d'essais
            nbre++ ;    
            }
            // Valeur Trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();            
        }
    }
}
