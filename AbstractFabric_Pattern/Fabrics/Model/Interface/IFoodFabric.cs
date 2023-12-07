using MealAbstractFabric.Food.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAbstractFabric.Fabrics.Model.Interface
{
    interface IFoodFabric
    {
        public IFood CreateMeal(IFood food);
        public IFood CreateBeverage(IFood food);
    }

}
