using System;
using System.Linq;
using System.Collections.Generic;

namespace ConstructorInheritance
{
    class Vehicle
    {
        public string brand;
        public int rate;

        public Vehicle(string brand, int rate)
        {
            this.brand = brand;
            this.rate = rate;

        }
    }
}
