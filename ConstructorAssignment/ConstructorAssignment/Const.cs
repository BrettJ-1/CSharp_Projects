using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Const
    {
        public const int ConstInt = 1; //Created Const Variable

        public void DisplayVar()
        {
            var text = "Example text"; //Displaying string using "var"
            Console.WriteLine(text);
        }

        public Const() : this("Example of default constructor") //Using Default Constructor
        {

        }
        public Const(string text) //Outputs the string from the first constructor
        {
            Console.WriteLine(text);
        }
    }
}
