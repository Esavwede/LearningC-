using System.Security.Cryptography.X509Certificates;
using System;

namespace App.DatatypesNamespace
{
    class Datatypes
    {

         public string stringDatatype;
         public char charDatatype;
         public int intDatatype;
         public bool boolDatatype;
         public float floatDatatype; 


        public Datatypes(string _stringDatatype )
        {
           stringDatatype = _stringDatatype;
        }

        public void setDatatypes(char _charDatatype,int _intDatatype,bool _boolDatatype, float _floatDatatype)
        {
            charDatatype = _charDatatype;
            intDatatype = _intDatatype;
            boolDatatype = _boolDatatype;
            floatDatatype = _floatDatatype; 

            Console.WriteLine($"Inputted Char Datatype : {charDatatype}");
            Console.WriteLine($"Inputted intDatatype :  {intDatatype} ");
            Console.WriteLine($"Inputted BoolDatatype : {boolDatatype }");
            Console.WriteLine($"Inputted floatDatatype : { floatDatatype}");
        }

    }
}