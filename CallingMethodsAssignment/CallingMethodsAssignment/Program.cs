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
            Console.WriteLine("What number do you want to do math operations on?"); //Asks user to input a number

            string input = Console.ReadLine();
            int number;
            number = Convert.ToInt32(input);

            Console.WriteLine($"Adding 2: {math.AddTwo(number)}"); //Adds 2 from AddTwo in BasicMath
            Console.ReadLine();

            Console.WriteLine($"Subtracting 3: {math.SubtractThree(number)}"); //Subtracts 3 from SubtractThree in BasicMath
            Console.ReadLine();

            Console.WriteLine($"Dividing 4: {math.DivideFour(number)}"); //Divides 4 from DivideFour in BasicMath
            Console.ReadLine();
        }
    }
}
