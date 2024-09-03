using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee
            {
                Id = 1,
                FirstName = "Ronald", //Instantiating firstEmployee
                LastName = "McDonald"
            };
            Employee secondEmployee = new Employee
            {
                Id = 2,
                FirstName = "Burger", //Instantiating secondEmployee
                LastName = "King"
            };
            bool equal = firstEmployee == secondEmployee;
            Console.WriteLine($"Are the two employee Id's equal? {equal}"); //returns false
            Console.ReadLine();
        }
    }
}
