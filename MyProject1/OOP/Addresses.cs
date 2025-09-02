using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Addresses
    {
        public string addressLine, city, state, country;
        public Addresses(string addressLine, string city, string state, string country)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
}
