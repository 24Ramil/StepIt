using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealAbstractFabric.Food.Model;

namespace MealAbstractFabric.Food.Interfaces
{
    interface IMeal : IFood
    {
        public double Price { get; set; }
        public double Callories { get; set; }

        public UInt16 Count { set; get; }
    }

}
