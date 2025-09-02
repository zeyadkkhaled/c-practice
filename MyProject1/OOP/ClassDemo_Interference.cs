using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ClassDemo_Interference : Imoveable, IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing from ClassDemo_Interference");
        }
        public void move()
        {
            Console.WriteLine("Moving from ClassDemo_Interference");
        }
    }
}
