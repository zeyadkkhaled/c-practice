using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //struct is like classes but with some differences\
    //1- struct is value type while class is reference type
    //2- struct can't have default constructor (no parameter) or destructor
    //3- struct is stored in stack memory while class is stored in heap memory
    //4- struct is used for small data structures that contain primarily data that is not intended to be modified after the struct is created

    public struct MyStruct
    {
        public string ColorName { get; set; }
        public int ColorCode { get; set; }
        //parameterized constructor
        public MyStruct(string colorName, int colorCode)
        {
            ColorName = colorName;
            ColorCode = colorCode;
        }
        public string GetData() => $"Color Name: {ColorName}, Color Code: {ColorCode}";
    }

}
