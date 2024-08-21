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
            string response;

            do
            {
                Console.WriteLine("Would you like to hear current music? (yes/no)"); // Asks user a question
                response = Console.ReadLine();

                if (response == "yes") // Provides current music suggestions
                {
                    Console.WriteLine("Great! Here are three of the top hits from August 2024:");
                    Console.WriteLine("1. Not Like Us");
                    Console.WriteLine("2. I Had Some Help (ft. Morgan Wallen)");
                    Console.WriteLine("3. Espresso");
                }
                else if (response == "no") // Doesn't provide music suggestions
                {
                    Console.WriteLine("Okay, I won't provide any recommendations for current music. Have a great day!");
                }
                else // Asks user to keep within specific guidelines
                {
                    Console.WriteLine("Please answer with 'yes' or 'no'");
                }
                Console.ReadLine();

            } while (response != "yes" && response != "no"); // Continues loop until user provides a valid response

            while (true)
            {
                Console.WriteLine("Would you like to hear 80's music? (yes/no)"); //Asks user a question
                response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.WriteLine("Great! I would recommend 'Livin on a Prayer' by Bon Jovi"); //Provides an 80's music suggestion
                }

                else if (response == "no")
                {
                    Console.WriteLine("Okay, I won't provide any recommendations for 80's music. Have a great day!"); //Doesn't provide a music suggestion
                }
                else
                {
                    Console.WriteLine("Please answer with 'yes' or 'no'"); //Asks user to keep within specific guidelines
                }
                Console.ReadLine();
                break;
            }
        }
    }
}