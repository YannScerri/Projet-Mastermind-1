//ETML
//Auteur: Yann Scerri
//Version du : 13.10.2023
//Description: Projet de Mastermind en C# (corrigé et approuvé par Sébastien)
using System;

namespace Projet_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // combinaison entrée par l'utilisateur
            string userInput;

            string combination = "";

            // nombre maximum d'essais autorisés
            int highestAttempts = 10;

            // Tableau contenant les différentes disponibles
            string[] availableColors = { "G", "Y", "W", "R", "B", "M", "C" };

            // Générateur de nombres aléatoire
            Random random = new Random();

            // Sauvegarde des couleurs sélectionnées aléatoirement dans un tableau
            string[] selectedColors = new string[4];

            // variables
            int correctColor = 0;
            int wrongPlace = 0;

            // Texte de bienvenue
            Console.WriteLine(
                "****************************\n" +
                "Bienvenue dans le Mastermind\n" +
                "****************************\n");
                                

            // Couleurs pouvant être utilisées par l'utilisateur et nombre d'essais
            Console.WriteLine("Couleurs possibles: GYWRBMC");
            Console.WriteLine("Essayez de deviner le code en 4 couleurs." + " Vous avez 10 essais. " + "Bonne chance!");

            // Génération de 4 couleurs aléatoires
            for (int cpt = 0; cpt < 4; cpt++)
            {
                // générer un index dans la plage des couleurs disponibles
                int randomIndex = random.Next(0, availableColors.Length);

                // Ajouter la couleur choisie au tableau
                selectedColors[cpt] = availableColors[randomIndex];
            }

            // combinaison aléatoire
            Console.WriteLine("Voici la combinaison aléatoire");
            for (int cpt = 0; cpt < selectedColors.Length; cpt++)
            {
                combination = combination + selectedColors[cpt];
            }

            // Affichage de la combinaison qu'il faudra cacher
            Console.WriteLine(combination);

            

            // limitation à 10 essais
            for (int attempts = 1; attempts <= highestAttempts; attempts++)
            {
                Console.WriteLine("Essai : " + attempts);
                // l'utilisateur entre une combinaison
                userInput = Console.ReadLine().ToUpper();

                while (userInput.Length != 4)
                {
                    // cas où l'utilisateur n'entre pas 4 caractères
                    Console.WriteLine("veuillez entrer uniquement 4 caractères");
                    userInput = Console.ReadLine().ToUpper();
                }

                // combinaison correcte
                if (userInput.ToUpper() == combination)
                {
                    Console.WriteLine("Bravo vous avez réussi !");
                    Console.ReadLine();
                    break; //fin de la boucle si le joueur a réussi
                }
                else
                {
                    // vérifier les couleurs justes
                    correctColor = 0;
                    wrongPlace = 0;

                    // comparer les couleurs entrées avec la bonne combinaison
                    for (int i = 0; i < 4; i++)
                    {
                        if (userInput.ToUpper()[i] == combination[i])
                        {
                            correctColor++;
                        }
                        else if (combination.Contains(userInput[i].ToString()))
                        {
                            wrongPlace++;
                        }
                    }

                    //Donner les indications au joueur
                    Console.WriteLine($"Couleurs correctes : {correctColor}");
                    Console.WriteLine($"Couleurs au mauvais endroit : {wrongPlace}");
                }
            }

            Console.ReadLine();
        }
    }
}
