using System;
using System.Globalization;

// Single Line comment 
/* Multiline Comment */

namespace mainNamespace
{
    class MainClass 
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("I love programming in C# "); 
            Console.WriteLine("What is your name ? ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to C# " + name  + " how old are you ?"); 
            int age = Convert.ToInt16( Console.ReadLine() );
            Console.WriteLine( name + " is " + age + " years old ");
        }
    }
}