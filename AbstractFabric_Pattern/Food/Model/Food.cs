using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAbstractFabric.Food.Model
{
    class Food : IFood
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Callories { get; set; }

        public Food(string name, double price, double callories)
        {
            Name = name;
            Price = price;
            Callories = callories;
        }

    }
}
