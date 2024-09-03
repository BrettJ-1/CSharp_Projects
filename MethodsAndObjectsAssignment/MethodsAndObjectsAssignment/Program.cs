using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Sample", //Filling in variables from employee and Person class
                LastName = "Student",
                Id = 1
            }; 
            employee.SayName(); //Function from Person.cs
            Console.ReadLine();
        }
    }
}
