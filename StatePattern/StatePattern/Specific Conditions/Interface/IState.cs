using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model.Interfaces;

interface IState
{
    public void ReceiveOrder();
    public void ReturnChange();
    public void Waiting();

}
