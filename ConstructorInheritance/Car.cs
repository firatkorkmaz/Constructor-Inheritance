using System;
using System.Linq;
using System.Collections.Generic;

namespace ConstructorInheritance
{
    class Car : Vehicle
    {
        public string model;
        public int speed;

        public Car(string brand, string model, int rate, int speed) : base(brand, rate)     // base() Runs the Constructor of "Vehicle"
        {
            this.model = model;
            this.speed = speed;
        }
    }
}
