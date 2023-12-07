using MealAbstractFabric.Fabrics.Model.Class;
using MealAbstractFabric.Food.Class;
using MealAbstractFabric.Food.Interfaces;
using MealAbstractFabric.Food.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAbstractFabric.Fabrics.Class
{
    class FantaFabric : FoodFabric
    {
        Beverage Fanta {set; get;}

        public IBeverage CreateFanta(IBeverage food)
        {
            return food;
        }

        FantaFabric() { }

        public FantaFabric(IBeverage food) 
        {
            CreateFanta(food);
            Fanta = food as Beverage;
        }

        public void Info()         
        {
            Fanta.Info();
        }

    }

}
