using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppSixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part One
            string[] firstArray = { "Red", "Blue", "Yellow", "Green" };
            Console.WriteLine("Write a description of your favorite color. For example, Apple 'is a fruit and company'.");
            string userInput = Console.ReadLine();

            for (int i = 0; i < firstArray.Length; i++) //Iterates through each string in array
            {
                firstArray[i] += " " + userInput;
            }
            Console.WriteLine("Printed strings:");
            foreach (string text in firstArray) //Prints same result after each string in array 
            {
                Console.WriteLine(text);
                Console.ReadLine();
            }
            //End Assignment Part One

            //Assignment Part Two
            while (true)
            {
                //Console.WriteLine("This sentence will run INFINITELY!!!");
                Console.WriteLine("This sentence will end when you type 'exit'.");

                string input = Console.ReadLine(); //Loop ends when "if" conditional statement is met
                if (input == "exit")
                {
                    break;
                }
            }
            Console.WriteLine();
            //End Assignment Part Two

            //Assignment Part Three

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Iteration {i}");
                Console.ReadLine();
            }

            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine($"Iteration {j}");
                Console.ReadLine();
            }
            //End Assignment Part Three

            //Assignment Part Four

            List<string> videoGames = new List<string>() { "The Legend of Zelda", "Super Mario Bros.", "Call of Duty", "Madden" };
            Console.WriteLine("Search for game title: ");
            string secondUserInput = Console.ReadLine();

            bool gameTitle = false;
            for (int i = 0; i < videoGames.Count; i++)
            {
                if (videoGames[i] == secondUserInput)
                {
                    gameTitle = true;
                    Console.WriteLine($"Are you searching for {i} ?");
                    Console.ReadLine();
                    break;
                }

            }
            if (!gameTitle)
            {
                Console.WriteLine("Your game title is not on the list... we apologize for the inconvenience.");
                Console.ReadLine();
            }
            //End Assignment Part Four

            //Assignment Part Five

            List<string> seasonList = new List<string>() { "Winter", "Autumn", "Summer", "Summer", "Spring" };
            Console.WriteLine("Enter the name of a season:");
            string thirdUserInput = Console.ReadLine();
            bool season = false;
            for (int i = 0; i < seasonList.Count; i++)
                if (seasonList[i] == thirdUserInput)
                {
                    season = true;
                    Console.WriteLine(seasonList.Count > 0);
                    Console.WriteLine($"The season '{thirdUserInput}'is at indices {seasonList} ");
                    Console.ReadLine();
                    break;
                }
            if (!season)
            {
                Console.WriteLine($"The season '{thirdUserInput}' is not a season.");
                Console.ReadLine();
            }
            //End Assignment Part Five

            //Assignment Part Six
            List<string> animalList = new List<string>() { "Alligator", "Bumblebee", "Cat", "Dog", "Dog", "Elephant" };
            List<string> animalCheck = new List<string>();
            foreach (string animal in animalList)
            {
                if (animalCheck.Contains(animal))
                {
                    continue;
                }
                bool duplicate = false;
                for (int i = 0; i < animalList.Count; i++)
                {
                    if (animal == animalCheck[i] && animalList.IndexOf(animal) != i)
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    Console.WriteLine($"{animal} - this animal is a duplicate");
                }

                else
                {
                    Console.WriteLine($"{animal} - this animal is unique");
                }
                animalCheck.Add(animal);
            }
            Console.ReadLine();
        }
    }
}


