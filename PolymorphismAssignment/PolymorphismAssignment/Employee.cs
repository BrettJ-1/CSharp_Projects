using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable //Employee class is inheriting Person class and IQuittable interface
    {
        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit.");
        }
    }
}