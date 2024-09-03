using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week.");
            string input = Console.ReadLine();
            try
            {
                daysOfWeek currentDay = (daysOfWeek)Enum.Parse(typeof(daysOfWeek), input, true); //Using Enum.Parse method
                Console.WriteLine($"The day of the week is {currentDay}");
            }
            catch (Exception ex) {
                Console.WriteLine("Please enter an actual day of the week."); //catching any exceptions
            }
            Console.ReadLine();
        }
    }
}
