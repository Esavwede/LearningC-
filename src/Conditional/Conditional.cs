

using System.Runtime.Serialization.Formatters;

namespace App.ConditionalNamespace 
{

    class Conditional 
    {

        public void CheckProgramQualityScore( int programQualityScore )
        {
            

            if( programQualityScore <= 4 )
            {
                Console.WriteLine(" Program Quality is low ");
            }
            else if( programQualityScore > 4 && programQualityScore < 7 )
            {
                Console.WriteLine(" Program Quality Score is average "); 
            }
            else if( programQualityScore > 6 && programQualityScore < 11 ) 
            {
                Console.WriteLine("Program Quality Score is excellent "); 
            }
            else 
            {
                Console.WriteLine(" Unknown Quality Score "); 
            }
        }

    }
}