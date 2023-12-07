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
    class Beverage : IBeverage
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Callories { get; set; }

        public double Litres { set; get; }

        public Beverage(string name, double price, double callories, double litres)
        {
            Name = name;
            Price = price;
            Callories = callories;
            Litres = litres;
        }

        public Beverage() { }
        public void Info() 
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Callories: {Callories}");
            Console.WriteLine($"Litres: {Litres}");
        }

    }

}
