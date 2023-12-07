using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAbstractFabric.Food.Model
{
    interface IFood
    {
        public double Price { set; get; }
        public double Callories { set; get; }

    }
}
