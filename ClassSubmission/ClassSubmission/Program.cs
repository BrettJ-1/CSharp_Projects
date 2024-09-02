using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecondOperations ops = new SecondOperations();
            Console.WriteLine("Enter an integer");
            int input = Convert.ToInt32(Console.ReadLine()); //Dividing an integer by 2
            ops.VisibleDivision(input);
            Console.ReadLine();
        }
    }
}
