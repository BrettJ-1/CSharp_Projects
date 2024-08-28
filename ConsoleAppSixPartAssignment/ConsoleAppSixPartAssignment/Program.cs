using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string seconduserInput = Console.ReadLine();

            bool gameTitle = false;
            for (int i = 0; i < videoGames.Count; i++)
            {
                if (videoGames[i] == seconduserInput)
                {
                    Console.WriteLine($"Are you searching for {i} ?");
                    gameTitle = true;
                    break;
                }
                if (!gameTitle)
                {
                    Console.WriteLine("Your game title is not on the list... we apologize for the inconvenience.");
                }
            }
        }
    }
}
