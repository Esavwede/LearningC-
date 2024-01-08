
using System;
using MyNamespace.Arithmetic; 

namespace MyNamespace 
{
    class MyClass 
    {
        static void Main(string[] args)
        {
            ArithmeticClass A1 = new ArithmeticClass();
            Console.WriteLine( A1.add(200000, 123232 ));  
            
        }
    }
}