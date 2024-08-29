using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperations
    {
        public int Operation (int number)
        {
            return number + 5;
        }
        public int Operation(decimal number)
        {
            return (int)(number - 5);
        }
        public int Operation(string numberString)
        {
            int number = Convert.ToInt32(numberString);
        }
    }
}
