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
    class PizzaFabric : FoodFabric
    {
        Meal Pizza { set; get; }

        public IMeal CreatePizza(IMeal food)
        {
            return food;
        }

        public PizzaFabric(IMeal food) 
        {
            CreatePizza(food);
            Pizza = food as Meal;
        }

        public void Info()
        {
            Pizza.Info();
        }
    }

}
