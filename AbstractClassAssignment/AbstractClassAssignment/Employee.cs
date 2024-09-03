using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
     class Employee : Person //Employee class is inherited from Person class
    {
        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
    }
}
