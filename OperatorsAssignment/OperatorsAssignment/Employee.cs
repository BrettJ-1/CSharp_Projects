using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            if (ReferenceEquals(firstEmployee, secondEmployee)) return true; //checks if the employees Id's are equal
            return firstEmployee.Id == secondEmployee.Id;
        }
        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            if (!ReferenceEquals(firstEmployee, secondEmployee)) return false; //checks if the employees Id's aren't equal
            return !(firstEmployee.Id == secondEmployee.Id);
        }

    }
}
