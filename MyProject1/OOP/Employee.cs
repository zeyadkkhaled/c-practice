using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Employee
    {
        //auto propertis (auto-implemented properties)
        public string Name { get; set; }
        //full property (with backing field)
        public String DOB {
            get { 
                return DOB;
            }
            set
            {
                DOB = value;
            }
            
        }
        //Read only property
        public String SSN { get; }
        public decimal Salary { get; set; }
        //constructor
        public Employee(string name, string ssn, decimal salary)
        {
            Name = name;
            SSN = ssn;
            Salary = salary;
        }
        public Employee(string name, string ssn, decimal salary,Addresses address)
        {
            Name = name;
            SSN = ssn;
            Salary = salary;
            this.address = address;

        }
        public Addresses address { get; set; } //aggregation (has-a relationship)
        public virtual void Work() //polymorphism (method overriding)
        {
            Console.WriteLine("Employee is working");
        }
    }
}
