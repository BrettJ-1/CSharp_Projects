using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Const Variable: " + Const.ConstInt);  //Chaining two constructors together

            Const example = new Const();
            example.DisplayVar();
            Console.ReadLine();
        }
    }
}
