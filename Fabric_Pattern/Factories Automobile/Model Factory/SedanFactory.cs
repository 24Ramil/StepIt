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
    class SedanFactory : IAutomobileFactory
    {
        public IMachine CreateMachine()
        {
            ISedan sedan = new Sedan()
            {
                Model = "Porsche",
                Weight = 1600,
                CountSeats = 2,
                HP = 750,
                Price = 300000,
            };
            return sedan;
        }
    
    }

}
