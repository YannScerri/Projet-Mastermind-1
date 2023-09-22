﻿using System;
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

            string combination = "";
           
            // nombre maximum d'essais autorisés
            int highestAttempts = 10;
            
            // garder en mémoire les résultats déjà entrés
            string results;

            // Tableau contenant les différentes disponibles
            string[] availableColors = { "G", "Y", "W", "R", "B", "M", "C" };

            // Générateur de nombres aléatoire
            Random random = new Random();

            // Sauvegarde des couleurs sélectionnées aléatoirement dans un tableau
            string[] selectedColors = new string[4];







            //Texte de bienvenue
            Console.WriteLine("Bienvenue sur Mastermind!");
           
                //Couleurs pouvant être utilisés par l'utilisateur et nombres d'essais
                Console.WriteLine("Couleurs possibles: GYWRBMC");
            
                Console.WriteLine("Essayez de deviner le code en 4 couleurs." + " Vous avez 10 essais. " + "Bonne chance!");
                

                //Génération de 4 couleurs aléatoires
                for(int cpt = 0; cpt < 4; cpt++)
            {
                //générer un index dans la plage des couleurs disponibles
                int randomIndex = random.Next(0, availableColors.Length);

                //Ajouter la couleur choisie au tableau
                selectedColors[cpt] = availableColors[randomIndex];

            }
                Console.WriteLine("Voici la combinaison aléatoire");
                for(int cpt = 0; cpt < selectedColors.Length; cpt++) 
                {
                combination = combination + selectedColors[cpt];

                }
                //Affichage de la combinaison qu'il faudrait cacher
                 Console.WriteLine(combination);
                
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
