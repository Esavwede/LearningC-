
using System;
using MyNamespace.Arithmetic; 
using MyNamespace.Conditional; 

namespace MyNamespace 
{
    class MyClass 
    {
        static void Main(string[] args)
        {

            // Arithmetic Class 
            ArithmeticClass A1 = new ArithmeticClass();
            Console.WriteLine( A1.add(200000, 123232 ));  

            // Conditional Class 
            ConditionalClass C1 = new ConditionalClass();
            C1.UserIsOnline(false); 
        }
    }
}