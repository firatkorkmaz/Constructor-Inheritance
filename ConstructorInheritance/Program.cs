/* Example of Inheritance in Constructors */

using System;
using System.Linq;
using System.Collections.Generic;

namespace ConstructorInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample data = 3x(3x(brand:model:rate:speed;))\n
            string data = "McLaren:M7:9:100;Porche:P3:9:95;Ferrari:F4:8:90\n" +
                          "Audi:A8:8:90;Mercedes:M9:8:85;BMW:B5:7:80\n" +
                          "Mazda:M9:8:90;Nissan:N3:7:80;Toyota:T10:6:75";

            string[] analyzed = data.Split('\n');
            List<Register> Row = new List<Register>();

            foreach (string item in analyzed)
            {
                Row.Add(new Register(item));
            }

            Console.WriteLine("\nBrand" + "Rate".PadLeft(14) + "Speed".PadLeft(10));
            Console.WriteLine("----------" + "----".PadLeft(9) + "-------".PadLeft(12));
            foreach (var item in Row)
            {
                foreach (var car in item.Data)
                {
					Console.WriteLine($"{car.brand}-{car.model}:" +
					$"{car.rate.ToString().PadLeft(15 - (car.brand.Length + car.model.Length + 1))}/10" +
                    $"{car.speed.ToString().PadLeft(7)} km/h");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n-------------");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
