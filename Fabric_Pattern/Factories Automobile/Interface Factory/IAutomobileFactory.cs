using AutomobileFabric.Automobiles.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFabric.Factories_Automobile.Interface_Factory
{
    interface IAutomobileFactory
    {
        public IMachine CreateMachine();
    }

}
