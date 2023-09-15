using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        ///ETML
        ///Auteur: Yann Scerri
        ///Date: 08.09.2023
        ///Description: Projet de Mastermind en C#

         
        
        
       
        {   // combinaison entrée par l'utilisateur
            string userInput;
            
            // nombre maximum d'essais autorisés
            int highestAttempts = 10;
            
            // garder en mémoire les résultats déjà entrés
            string results;
            
            //Texte de bienvenue
            Console.WriteLine("Bienvenue sur Mastermind!");
           
            //Couleurs pouvant être utilisés par l'utilisateur et nombres d'essais
            Console.WriteLine("Couleurs possibles: GYWRBMC");
            
            Console.WriteLine("Essayez de deviner le code en 4 couleurs." + " Vous avez 10 essais. " + "Bonne chance!");

            // limitation à 10 essais
            for (int attempts = 1; attempts <= highestAttempts; attempts++)
            {
                Console.WriteLine("Essai : " + attempts);
                //l'utilisateur entre une combinaison
                userInput = Console.ReadLine();

                while (userInput.Length != 4)
                {   //cas où l'utilisateur n'entre pas 4 caractères
                    Console.WriteLine("veuillez entrer uniquement 4 caractères");
                    userInput = Console.ReadLine();
                }
                




            }



            Console.ReadLine();

        }
    }
}
