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

            string input =
            Console.ReadLine();
            int index = Convert.ToInt32(input); //Converting int to string

            if (index >= 0 && index <= 3)
            {
                string vehicle = stringArray[index];
                Console.WriteLine("You selected a " + vehicle); //Output to user
            }
            else
            {
                Console.WriteLine("Please select a number between 0 and 3.");
                Console.ReadLine();
            }


            int[] intArray = { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Double a number between 0 and 6");
            string secondInput = Console.ReadLine();

            int selectedNumber = Convert.ToInt32(secondInput);

            if (selectedNumber >= 0 && selectedNumber <= 6)
            {

                int secondIndex = Convert.ToInt32(secondInput);

                int result = intArray[secondIndex] * 2;

                Console.WriteLine("Here is your result: " + result);

            }
            else
            {
                Console.WriteLine("Please select a number between 0 and 6.");
                Console.ReadLine();
            }

            List<string> stringList = new List<string> { "Red", "Blue", "Green", "Yellow" };
            Console.WriteLine("Select an index to display a color");

            string userInput = Console.ReadLine();

            int thirdIndex = Convert.ToInt32(userInput);

            Console.WriteLine("You selected the color " + thirdIndex);
            Console.ReadLine();

        }

    }
}


