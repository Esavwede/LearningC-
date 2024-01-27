


using System.Globalization;

namespace App.LoopNamespace
{

    class Loop 
    {
        string id;
        public Loop( string id )
        {
            this.id = id;
        }

        public void While()
        {
            int specialNumber = 10;
            int currentNumber = 0;     

            while( currentNumber < specialNumber )
            {
                Console.WriteLine($" {currentNumber} is less than {specialNumber}, incrementing current number ... "); 
                currentNumber++; 
            }

            Console.WriteLine($" {currentNumber} = {specialNumber}"); 
            Console.WriteLine("While Loop Ended "); 
        }


        public void For()
        {
            for( int i = 0;  i < 15; i++ )
            {
                Console.WriteLine($" current number {i} "); 
            }
        }

        public void ForEach()
        {
            int[] numbers = [0,100,200,300,400];

            foreach( int number in numbers )
            {
                Console.WriteLine(number); 
            }
        }
    }
    

}