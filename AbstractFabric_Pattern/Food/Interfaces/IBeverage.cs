using MealAbstractFabric.Food.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAbstractFabric.Food.Interfaces
{
    interface IBeverage : IFood
    {
        public double Price { get; set; }
        public double Callories { get; set; }

        public double Litres { set; get; }
    }

}
