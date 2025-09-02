using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Programmers : Employee //inheritance from Employee class
    {
        //constructor
        public Programmers(string name, string ssn, decimal salary, decimal bonus)
            : base(name, ssn, salary) //calling base class constructor
        {
            Bonus = bonus;
        }
        public decimal Bonus = 10000;
        
        public decimal SalaryTotal
        {
            get { return Salary + Bonus; }
        }
        public override void Work() //polymorphism (method overriding)
        {
            Console.WriteLine("Programmer is coding");
        }
    }
}
