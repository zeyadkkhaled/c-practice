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
        //we already have 1-default constructor (no parameters) , no need to write it
        public Person() { } //default constructor

        // 2-Private constructor prevents direct object creation
        // Ensures class can't be instantiated from outside
        // Commonly used in Singleton or Factory pattern
        // Forces object creation to go through this method
        // Compiler makes constructor private automatically for static classes
        
        //3-parameterized constructor
        public Person(string name, int age, string ssn) //constructor with parameters
        {
            Name = name;
            Age = age;
            this.ssn = ssn; //this keyword to refer to the current instance of the class
        }
        //4-copy constructor is creating a new object by taking a copy from another object
        public Person(Person p)
        {
            this.Name = p.Name;
            this.Age = p.Age;
            this.ssn = p.ssn;

        }
        //5- copy constructors 
        // Static constructor:
        // - Runs only once, before the class is used (first access).
        // - Used to initialize static fields.
        // - Cannot have parameters.
        // - Cannot be called manually (runtime calls it automatically).
        // - Executes before any instance constructor or static method is accessed.

        static Person() { 
            
        
        
        
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
        public static void calc(int num, out int res)  //passed by reference
        {
            res = num + 10;
        }
        
    }
}
