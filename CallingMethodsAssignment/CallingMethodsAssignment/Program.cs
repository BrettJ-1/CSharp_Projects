using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath math = new BasicMath();
            Console.WriteLine("What number do you want to do math operations on?");

            string input = Console.ReadLine();
            int number;
            number = Convert.ToInt32(input);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
