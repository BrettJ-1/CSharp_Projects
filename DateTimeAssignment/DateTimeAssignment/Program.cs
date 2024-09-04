﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time:" + currentDateTime);
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int hours))
            {
                DateTime userDateTime = currentDateTime.AddHours(hours);
                Console.WriteLine("The exact time in " + hours + " hours will be:" + userDateTime);
            }
            Console.ReadLine();
        }
    }
}
