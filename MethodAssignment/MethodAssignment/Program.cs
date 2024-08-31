using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations ops = new Operations(); 
            Console.WriteLine("Enter 2 numbers. You do not have to enter anything for the second number:"); //Takes user input for first number
            string input = Console.ReadLine();
            int firstNumber = 0;

            try
            {
                firstNumber = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter an integer.");
            }

            Console.WriteLine("Enter the second number (or skip):"); //Takes user input for second number
            input = Console.ReadLine();
            //int secondNumber = 0;
            //secondNumber = Convert.ToInt32(input); 
            
            int sum = ops.Add(firstNumber); //takes code from Operations.cs to add firstNumber and secondNumber
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
