using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); //Checks for age
            int Age = Console.ReadLine().Length;

            Console.WriteLine("Have you ever had a DUI?"); //Checks for DUI
            string Response = Console.ReadLine();
            bool DUI = (Response == "yes");

            Console.WriteLine("How many speeding tickets do you have?"); //Checks for speeding tickets
            int Tickets = Console.ReadLine().Length;

            bool Qualified = (Age > 15) && DUI && (Tickets <= 3); //Checks if all three qualifications are met

            Console.WriteLine("Qualified?"); //Takes checked qualifications and displays boolean result
            Console.WriteLine(Qualified);

        }
    }
}
