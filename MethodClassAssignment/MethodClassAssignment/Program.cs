using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations ops = new Operations(); //Calculation from Operations.cs is applied towards firstNumber
            ops.operation(2, 0);
            ops.operation(firstNumber: 15, secondNumber: 0);
            Console.ReadLine();
        }
    }
}
