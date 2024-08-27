using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Car", "Truck", "Airplane", "Boat" }; //Creates index of vehicles
            Console.WriteLine("Choose a number between 0 and 3 to select a vehicle");

            string input = Console.ReadLine();
            int index = Convert.ToInt32(input); //Converting string to int
            while (!(index >= 0 && index <= 3))
            {
                Console.WriteLine("Please enter a number between 0 and 3."); //Keeps user within parameters
                input = Console.ReadLine();
                index = Convert.ToInt32(input);
            }

            string vehicle = stringArray[index];
            Console.WriteLine("You selected a " + vehicle); //Output to user


            int[] intArray = { 0, 1, 2, 3, 4, 5, 6 }; //Creates index of numbers
            Console.WriteLine();
            Console.WriteLine("Double a number between 0 and 6");


            string secondInput = Console.ReadLine();
            int secondIndex = Convert.ToInt32(secondInput); //Converting string to int
            while (!(secondIndex >= 0 && secondIndex <= 6))
            {
                Console.WriteLine("Please select a number between 0 and 6."); //Keeps user within parameters
                secondInput = Console.ReadLine();
                secondIndex = Convert.ToInt32(secondInput);
            }

            int result = intArray[secondIndex] * 2;

            Console.WriteLine("Here is your result: " + result); //Output to user

            Console.WriteLine();
            List<string> stringList = new List<string> { "Red", "Blue", "Green", "Yellow" }; //Creates list
            Console.WriteLine("Select a number between 0 and 3 to display a color");

            string userInput = Console.ReadLine();
            int thirdIndex = Convert.ToInt32(userInput); //Converting string to int
            while (!(thirdIndex >= 0 && thirdIndex <= 3))
            {
                Console.WriteLine("Please select a number between 1 and 3."); //Keeps user within parameters
                userInput = Console.ReadLine();
                thirdIndex = Convert.ToInt32(userInput);
            }

            Console.WriteLine("You selected the color " + stringList[thirdIndex]); //Output to user
            Console.ReadLine();

        }

    }
}


