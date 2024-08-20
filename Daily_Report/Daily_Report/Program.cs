﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

internal class Program
{

    string Name; //Creates string 
    string Course; //Creates string 
    int PageNumber; //Creates integer 
    string NeedsHelp; //Creates boolean 
    string Experience; //Creates string 
    string Feedback; //Creates string 
    double StudyHours; //Creates double 
    static void Main()
    {
        Console.WriteLine("The Tech Academy"); //Creates Text Line
        Console.WriteLine("Student Daily Report"); //Creates Text Line

        Console.WriteLine("A. What is your name?"); //Creates Text Line
        string Name = Console.ReadLine(); //User can input string

        Console.WriteLine("B. What course are you on?"); //Creates Text Line
        string Course = Console.ReadLine(); //User can input string

        Console.WriteLine("C. What page number?"); //Creates Text Line
        int PageNumber = Convert.ToInt32(Console.ReadLine()); //User can input integer

        Console.WriteLine("D. Do you need help with anything ? Please answer \"true\" or \"false\"."); //Creates Text Line
        string NeedsHelp = Console.ReadLine(); //User can input string that gets converted to a boolean output

        Console.WriteLine("E. Were there any positive experiences you'd like to share? Please give specifics."); //Creates Text Line
        string Experience = Console.ReadLine(); //User can input string

        Console.WriteLine("F. Is there any other feedback you'd like to provide? Please be specific."); //Creates Text Line
        string Feedback = Console.ReadLine(); //User can input string

        Console.WriteLine("G. How many hours did you study today?"); //Creates Text Line
        double StudyHours = Console.ReadLine().Length; //User can input double

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //Creates Text Line
        Console.ReadLine(); //Prints Text Lines
    }
}

