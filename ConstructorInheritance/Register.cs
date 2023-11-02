using System;
using System.Linq;
using System.Collections.Generic;

namespace ConstructorInheritance
{
    class Register
    {
        public List<Car> Data;

        public Register(string Row)
        {
            string[] pieces = Row.Split(';');

            Data = new List<Car>();

            foreach (string item in pieces)
            {
                // Each Car Item will Have Those Parameters: brand(string), model(string), rate(int), speed(int)
                Data.Add(new Car(item.Split(':')[0], item.Split(':')[1], int.Parse(item.Split(':')[2]), int.Parse(item.Split(':')[3])));
            }

        }
    }
}
