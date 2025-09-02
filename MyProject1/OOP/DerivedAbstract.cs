using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DerivedAbstract : AbstractExample
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived class implementation of abstract method");
        }
    }
    
}
