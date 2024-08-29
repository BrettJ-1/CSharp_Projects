using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations ops = new MathOperations();

            int intResult = ops.Operation(5);
            Console.WriteLine(intResult);

            int decimalResult = ops.Operation(12.34m);
            Console.WriteLine(decimalResult);

            int stringResult = ops.Operation("hello");
            Console.WriteLine(stringResult);
        }
    }
}
