
using System;



namespace MyNamespace.Conditional 
{
    class ConditionalClass
    {
        public void UserIsOnline(bool online)
        {
            if( online )
            {
                Console.WriteLine("User is online ");
            }
            else 
            {
                Console.WriteLine("User is not online "); 
            }
        }
    }
}