﻿using System;

namespace Projet_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {   //boucle du programme
            do
            {   //menu 
                Console.WriteLine("******\n" +
                                  "Menu :\n" +
                                  "******\n" +
                                  "\n" +
                                  "[1] Voulez-vous jouer au Mastermind?\n" +
                                  "[2] Quitter le programme\n");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        PlayMastermind();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez entrer 1 ou 2.");
                        break;
                }
            } while (true);


            void PlayMastermind()
            {
                Console.Clear();
               
                
                    // combinaison entrée par l'utilisateur
                    string userInput;

                    string combinaison = "";

                    // Nombre maximum d'essais autorisés
                    int highestAttempts = 10;

                    // Conserver les résultats saisis par l'utilisateur
                    char[] userGuess;

                    // Tableau contenant les couleurs disponibles
                    string[] availableColors = { "G", "Y", "W", "R", "B", "M", "C" };

                    //tableau de couleurs
                    ConsoleColor[] couleurs =
                    {
                    ConsoleColor.Green,ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan
                    };

                    char[] colorchoice = { 'G', 'Y', 'W', 'R', 'B', 'M', 'C' };
                    // Générateur de nombres aléatoires
                    Random random = new Random();

                    // Sauvegarde des couleurs sélectionnées aléatoirement dans un tableau
                    string[] selectedColors = new string[4];

                    // Variables
                    int correctColor = 0;
                    int wrongPlace = 0;

                    // Message de bienvenue
                    Console.WriteLine(
                        "****************************\n" +
                        "Bienvenue dans le Mastermind\n" +
                        "****************************\n");

                    // Couleurs que l'utilisateur peut utiliser et le nombre d'essais
                    Console.Write("Couleurs possibles : ");
                    for (int i = 0; i < couleurs.Length; i++)
                    {
                        Console.ForegroundColor = couleurs[i];
                        Console.Write(colorchoice[i] + " ");
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nEssayez de deviner le code à 4 couleurs. Vous avez 10 essais. Bonne chance !");

                    // Génération de 4 couleurs aléatoires
                    for (int cpt = 0; cpt < 4; cpt++)
                    {
                        // générer un index dans la plage des couleurs disponibles
                        int randomIndex = random.Next(0, availableColors.Length);

                        // Ajouter la couleur choisie au tableau
                        selectedColors[cpt] = availableColors[randomIndex];
                    }

                    // Combinaison aléatoire
                    Console.WriteLine("Voici la combinaison aléatoire (affichée uniquement pour démo)");
                    for (int cpt = 0; cpt < selectedColors.Length; cpt++)
                    {
                        combinaison = combinaison + selectedColors[cpt];
                    }

                    // Affichage de la combinaison à cacher
                    Console.WriteLine(combinaison);

                    // Limiter à 10 essais
                    for (int attempts = 1; attempts <= highestAttempts; attempts++)
                    {
                        Console.WriteLine("Essai : " + attempts);
                        // L'utilisateur entre une combinaison
                        userInput = Console.ReadLine().ToUpper();

                        while (userInput.Length != 4)
                        {
                            // Cas où l'utilisateur n'entre pas 4 caractères
                            Console.WriteLine("Veuillez entrer exactement 4 caractères");
                            userInput = Console.ReadLine().ToUpper();
                        }

                        // Combinaison correcte
                        if (userInput.ToUpper() == combinaison)
                        {
                            Console.WriteLine("Bravo, vous avez réussi !\n");
                            break; // Fin de la boucle si le joueur a réussi
                        }
                        else
                        {
                            // Vérifier les couleurs correctes
                            correctColor = 0;
                            wrongPlace = 0;

                            //Comparer les couleurs entrées avec la bonne combinaison
                            for (int i = 0; i < 4; i++)
                            {
                                if (userInput.ToUpper()[i] == combinaison[i])
                                {
                                    switch (combinaison[i])
                                    {
                                        case 'G':
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            break;
                                        case 'Y':
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            break;
                                        case 'W':
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        case 'R':
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            break;
                                        case 'B':
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            break;
                                        case 'M':
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            break;
                                        case 'C':
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            break;
                                    }
                                    Console.Write(userInput[i]);
                                    Console.ResetColor();
                                    correctColor++;
                                }

                                else if (userInput[i] != combinaison[i])
                                {
                                    Console.Write("_");
                                }
                                else if (combinaison.Contains(userInput[i].ToString()))
                                {
                                    wrongPlace++;
                                }

                                else if (attempts == 9)
                                {
                                Console.WriteLine("Dommage, vous avez perdu. Le code était " + combinaison);
                                }
                            }

                            // Donner des indications au joueur
                            Console.WriteLine($"\nCouleurs correctes : {correctColor}");
                            Console.WriteLine($"Couleurs au mauvais endroit : {wrongPlace}");
                        }
                    }



               
            }
        } 
    }
}
