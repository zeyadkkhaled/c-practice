using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP //organizer for classes
              //we can write multiple namespaces or classes in one file
{
    public class Person //public access modifier to be seen by all priojects
    {
        //fields(variables) or attributes of the class 
        private string ssn; //private access modifier to be seen only in this class

        //properties (can be get or set) of the class
        public string Name { get; set; } //auto-implemented property
        public int Age { get; private set; } //read-only property outside the class
        //constructors
        //we already have default constructor (no parameters) , no need to write it
       //parameterized constructor
        public Person(string name, int age, string ssn) //constructor with parameters
        {
            Name = name;
            Age = age;
            this.ssn = ssn; //this keyword to refer to the current instance of the class
        }
        //methods
        //instance method
        // access returnType MethodName(parameters) { code... }
        public string GetData()
        {
            return $"Name: {Name}, Age: {Age}, SSN: {ssn}";
        }
        public void show()
        {
            Console.WriteLine("Hello from Person class");
        }
        //static method
        //no need for an object of the class to call it
        public static string DispDate() //good for memory management
        {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }
        //overloaded method
        //same method name with different parameters (either their number or datatypes)
        public string GetData(bool showSSN)
        {
            if (showSSN)
                return $"Name: {Name}, Age: {Age}, SSN: {ssn}";
            else
                return $"Name: {Name}, Age: {Age}";
        }
        //Asynchronus methods
        public static async Task<int> Task1() { //returns int  

            return 100;
        }
        public static async Task Task2() //retur void
        {
            var res = await Task1() + 20 ;
            Console.WriteLine(res);

        }
        public static int Add(ref int num)  //passed by reference
        {
            num += 10;
            return num ;
        }
    }
}
