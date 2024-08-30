using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public static class Operations
    {
        public static void division(int input, int output)
        {
            output = input / 2;
        }
        public static void division(double input, double output)
        {
            output = input / 2;
        }
    }
    public class SecondOperations
    {
        public void VisibleDivision(int input)
        {
            int result = input / 2;
            Console.WriteLine(result);
        }
    }
}
