using AutomobileFabric.Automobiles.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFabric.Automobiles.Model
{
    class Truck : ITruck
    {
        public string Model { set; get; }
        public Int32 Price { set; get; }
        public Int32 Weight { set; get; }
        public Int32 HP { set; get; }

        public double LiftingCapacity { set; get; }


        public void Info()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"LiftingCapacity: {LiftingCapacity}");
        }
    }

}
