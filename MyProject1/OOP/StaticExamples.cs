using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Statis class 
    //like normal class but can't be instantiated (we can't create object of static class)
    //it can have only static members (fields, properties, methods)
    //can't have constructors (except static constructor)
    public static class StaticExamples
    {
        //static field
        public static int _Number; //shared by all instances of the class
        //static property
        public static int Data { 
            get { return _Number; }
            set { if (value > 0) _Number = value; }
        }
        //static method
        public static void Show() => Console.WriteLine("Static method called"); //inline method

        //no destructor for static class
    }

}
