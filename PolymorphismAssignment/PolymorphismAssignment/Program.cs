using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employee.SayName(); //Calling function from Person.cs
            employee.Quit(); //Calling function from IQuittable.cs
            Console.ReadLine();
        }
    }
}
