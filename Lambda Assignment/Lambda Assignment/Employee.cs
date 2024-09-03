﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(int id , string firstName, string lastName) //setting the employee class with properties
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
