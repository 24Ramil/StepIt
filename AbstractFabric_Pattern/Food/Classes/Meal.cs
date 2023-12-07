using MealAbstractFabric.Food.Interfaces;
using MealAbstractFabric.Food.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace MealAbstractFabric.Food.Class
{
    class Meal : IMeal
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Callories { get; set; }

        public UInt16 Count { get; set; }

        public Meal(string name, double price, double callories, UInt16 count) 
        {
            Name = name;
            Price = price;
            Callories = callories;
            Count = count;
        }
        public Meal() { }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Callories: {Callories}");
            Console.WriteLine($"Count: {Count}");
        }

    }

}
