



namespace App.ArrayNamespace 
{

    class ArrayClass
    {

        public void Run()
        {
            Console.WriteLine(" C# Array "); 

            int[] myNumbers = [1,2,3];
            string[] myFruits = ["apple","pineapple","banana"]; 

            Console.WriteLine($" My first fruit is {myFruits[0]} ");
            Console.WriteLine(" Changing My first fruit to another fruit "); 
            myFruits[0] = "Guava";
            Console.WriteLine($" My first fruit is now {myFruits[0] }"); 
            Console.WriteLine($" I have {myNumbers.Length } special numbers "); 

        }
    }
}