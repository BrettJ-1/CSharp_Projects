using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n \tHello on a tab.";
            //string fileName = "C:\\Users\\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //name = name.ToLower();

            //Console.WriteLine(quote);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
