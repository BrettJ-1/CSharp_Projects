using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to hear current music?"); //Asks user a question
            while (true)
            {
                string response = Console.ReadLine();

                {
                    if (response == "yes") //Provides current music suggestions
                    {
                        Console.WriteLine("Great! Here are three of the top hits from August 2024:");

                        Console.WriteLine("1. Not Like Us");

                        Console.WriteLine("2. I Had Some Help (ft. Morgan Wallen)");

                        Console.WriteLine("3. Espresso");

                        Console.ReadLine();
                    }
                    else if (response == "no") //Doesn't provide music suggestions
                    {
                        Console.WriteLine("Okay, I won't provide any recommendations for current music. Have a great day!");

                        Console.ReadLine();
                    }
                    else //Asks user to keep within specific guidelines
                    {
                        Console.WriteLine("Please answer with a 'yes' or 'no'");

                        Console.ReadLine();
                    }
                }
            }
        }
    }
}