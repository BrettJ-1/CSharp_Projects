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
            string[] stringArray = { "Car", "Truck", "Airplane", "Boat" };
            Console.WriteLine("Choose a vehicle (1-4):");
            if (stringArray.Length >= 4)
            {
                Console.WriteLine("You selected a " + stringArray.Length);

                Console.ReadLine();
            }
        }
    }
}
