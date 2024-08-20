using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Name of Program


            Console.WriteLine("Person 1"); //Displays "Person 1"

            Console.WriteLine("Hourly Rate?"); //Displays "Hourly Rate"
            double PersonOneHourlyRate = Convert.ToDouble(Console.ReadLine()); //Takes user input for hourly rate

            Console.WriteLine("Hours worked per week?"); //Displays "Hours worked per week"
            double PersonOneHoursWorked = Convert.ToDouble(Console.ReadLine()); //Takes user input for hours worked


            Console.WriteLine("Person 2"); //Displays "Person 2"

            Console.WriteLine("Hourly Rate?"); //Displays "Hourly Rate?"
            double PersonTwoHourlyRate = Convert.ToDouble(Console.ReadLine()); //Takes user input for hourly rate

            Console.WriteLine("Hours worked per week?"); //Displays "Hours worked per week?"
            double PersonTwoHoursWorked = Convert.ToDouble(Console.ReadLine()); //Takes user input for hours worked


            double PersonOneAnnualSalary = PersonOneHourlyRate * PersonOneHoursWorked * 52; //Calculates annual salary of Person 1
            Console.WriteLine("Annual salary of Person 1:"); //Displays "Annual salary of Person 1:"
            Console.WriteLine(PersonOneAnnualSalary); //Displays result of PersonOneAnnualSalary

            double PersonTwoAnnualSalary = PersonTwoHourlyRate * PersonTwoHoursWorked * 52; //Calculates annual salary of Person 2
            Console.WriteLine("Annual salary of Person 2:"); //Displays "Annual salary of Person 2:"
            Console.WriteLine(PersonTwoAnnualSalary); //Displays result of PersonTwoAnnualSalary


            bool Answer = PersonOneAnnualSalary > PersonTwoAnnualSalary; //Checks if Person 1 makes more money than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?"); //Displays "Does Person 1 make more money than Person 2?"


            Console.WriteLine(Answer); //Displays result of Answer
        }
    }
}
