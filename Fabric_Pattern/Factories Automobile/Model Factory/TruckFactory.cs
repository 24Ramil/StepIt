using AutomobileFabric.Automobiles.Intreface;
using AutomobileFabric.Automobiles.Model;
using AutomobileFabric.Factories_Automobile.Interface_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFabric.Factories_Automobile.Model_Factory
{
    class TruckFactory : IAutomobileFactory
    {
        public IMachine CreateMachine()
        {
            ITruck truck = new Truck() 
            {
                Model = "Volvo",
                Weight = 8000,
                HP = 800,
                LiftingCapacity = 25000,
                Price = 150000,                
            };

            return truck;
        }

    }

}
