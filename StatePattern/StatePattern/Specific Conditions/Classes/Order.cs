using StatePattern.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Order : IState
    {
        public void ReceiveOrder()
        {
            Console.WriteLine("Choise the product");
        }

        public void ReturnChange()
        {
            Console.WriteLine("Can not return change in time order");
        }

        public void Waiting()
        {
            Console.WriteLine("Automat wait order user");
        }

    }
}
