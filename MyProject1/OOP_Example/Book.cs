using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example
{
    public class Book : LibraryItem
    {
        private int _Pages;
        public int Pages { get { return _Pages; } set { if (value > 0) _Pages = value; } }
        public bool isAvailable { get; set; } =true; //default value
        //polymorphism - method overriding
        public override void DisplayInfo()
        {
            Console.WriteLine($"Book ID: {Id}\n, Title: {Title}\n, Author: {Author}\n, Pages: {Pages}\n"+$" Availability : {(isAvailable ?"Available" : "Borrowed")}");
        }
    }
   
}
