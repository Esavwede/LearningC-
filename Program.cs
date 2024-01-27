
using System; 
using App.ArithmeticNamespace;
using App.DatatypesNamespace;
using App.ConditionalNamespace; 
using App.LoopNamespace; 
using App.ArrayNamespace; 

namespace App 
{
    class App 
    {
        static void Main( string[] args)
        {
            // This is a single line comment in C# 
            /*  This is a multiline comment in C# */       


            // Console.WriteLine(" Program Started ");
            // Console.WriteLine(" Enter your name into the terminal ");            
            // string name = Console.ReadLine();
            // Console.WriteLine($" Welcome to C# programming { name } ");


            // /* Datatypes */ 
            // Datatypes dataTypeClass = new Datatypes("I love programming in C# ");
            // dataTypeClass.setDatatypes('a',25,true,6);


            // /* Basic Arithmetic Operations */ 
            // Arithmetic arithmetic = new Arithmetic(); 
            // Console.WriteLine($" 1 + 1 : {  arithmetic.Add(1,1) }");
            // Console.WriteLine($" 1 * 1 : { arithmetic.Mul(1,1) } "); 
            // Console.WriteLine($" 1 - 1 : { arithmetic.Subtract(1,1) }"); 


            // // Conditonals 
            // Conditional conditional = new Conditional();
            // conditional.CheckProgramQualityScore(10); 


            // // Loops 
            // Loop loop = new Loop("randomLoopId");
            // loop.While();
            // loop.For(); 
            // loop.ForEach(); 


            // Array 
            ArrayClass myArray = new ArrayClass(); 
            myArray.Run(); 
        }
    }
}










































