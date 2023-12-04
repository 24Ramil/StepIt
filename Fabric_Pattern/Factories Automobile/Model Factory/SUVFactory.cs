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
    class SUVFactory : IAutomobileFactory
    {
        public IMachine CreateMachine()
        {
            ISUV suv = new SUV()
            {
                Model = "Toyota",
                Weight = 2000,
                HP = 950,
                Clearance = 280,
                Price = 80000,
            };
            return suv;

        }
    }

}
