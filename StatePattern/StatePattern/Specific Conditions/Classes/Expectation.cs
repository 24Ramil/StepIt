using StatePattern.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Expectation : IState
    {

        public void ReceiveOrder()
        {
            Console.WriteLine("Wait order");
        }

        public void ReturnChange()
        {
            Console.WriteLine("Change is read");
        }

        public void Waiting()
        {
            Console.WriteLine("Put in a coin");
        }
    
    }

}
