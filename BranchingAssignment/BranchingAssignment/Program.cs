using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Package Weight:");
            double weight = Convert.ToDouble(Console.ReadLine()); //Input package weight

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //Exits program if package weighs over 50lbs
            }

            Console.WriteLine("Package Width:");
            double width = Convert.ToDouble(Console.ReadLine()); //Input package width

            Console.WriteLine("Package Height:");
            double height = Convert.ToDouble(Console.ReadLine()); //Input package height

            Console.WriteLine("Package Length:");
            double length = Convert.ToDouble(Console.ReadLine()); //Input package length

            if (width + height + length > 50)
            { 
                Console.WriteLine("Package too big to be shipped via Package Express."); //Exits program if dimensions exceed 50"
            }

            double product = width * height * length;
            double quote = (product * weight) / 100; //Calculation for quote

            Console.WriteLine("Your estimated total for shipping this package is: " + quote); //Displays quote
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
