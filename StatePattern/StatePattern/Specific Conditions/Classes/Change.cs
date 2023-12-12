using StatePattern.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Change : IState
    {
        public void ReceiveOrder()
        {
            Console.WriteLine("Can not return change in time order");
        }

        public void ReturnChange()
        {
            Console.WriteLine("Take the change");
        }

        public void Waiting()
        {
            Console.WriteLine("Change is being calculated");
        }
    }
}
