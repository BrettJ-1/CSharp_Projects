using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 2, 4, 6, 8, 10, 12 };
            while (true)
            {
                Console.WriteLine("What number do you want to divide each number by?");
                string input = Console.ReadLine();
                int divisor;
                try
                {
                    divisor = Convert.ToInt32(input);
                    foreach (int number in numberList)
                    {
                        try
                        {
                            int result = number / divisor;
                            Console.WriteLine(result);
                        }
                        catch (DivideByZeroException ex) //Catches dividing by zero

                        {
                            Console.WriteLine("Divide by a number other than zero");
                            Console.WriteLine();
                        }
                    }
                }

                catch (FormatException ex) //Catches using other data types

                {
                    Console.WriteLine("Divide using an integer");
                    Console.WriteLine();
                }

                catch (OverflowException ex) //Catches using too large of a number

                {
                    Console.WriteLine("Try using a smaller number");
                    Console.WriteLine();
                }
                break;
            }
            Console.WriteLine("The program is now outside the try/catch block of code. The next program can now be executed.");
            Console.ReadLine();
        }
    }
}




