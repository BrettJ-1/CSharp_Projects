using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Ronald", "McDonald"),
                new Employee(2, "Burger", "King"),
                new Employee(3, "Joe", "Burrow"),
                new Employee(4, "Joe", "Flacco"),
                new Employee(5, "Aaron", "Rodgers"),
                new Employee(6, "Kirk", "Cousins"),
                new Employee(7, "Jared", "Goff"),
                new Employee(8, "Fernando", "Tatis"),
                new Employee(9, "Matt", "Olson"),
                new Employee(10, "Shohei", "Ohtani"),
            };
            List<Employee> employeesNamedJoe = new List<Employee>();
            foreach (var employee in employees)
            {

                if (employee.FirstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }
            Console.WriteLine("Employees named Joe:");
            Console.WriteLine($"{employeesNamedJoe}");
            Console.ReadLine();

            List<Employee> employeesNamedJoeLambda = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Employees named Joe:");
            Console.WriteLine($"{employeesNamedJoeLambda}");
            Console.ReadLine();

            List<Employee> IdMoreThanFive = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("Employees with an Id greater than 5:");
            Console.WriteLine($"{IdMoreThanFive}");
            Console.ReadLine();
        }
    }
}
