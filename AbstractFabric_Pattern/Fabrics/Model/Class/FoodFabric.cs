using MealAbstractFabric.Fabrics.Model.Interface;
using MealAbstractFabric.Food.Class;
using MealAbstractFabric.Food.Interfaces;
using MealAbstractFabric.Food.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAbstractFabric.Fabrics.Model.Class
{
    abstract class FoodFabric : IFoodFabric
    {
        public IFood CreateBeverage(IFood food)
        {
            return food;
        }

        public IFood CreateMeal(IFood food)
        {
            return food;
        }

    }

}
