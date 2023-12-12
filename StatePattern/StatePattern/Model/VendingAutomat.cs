using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Model.Interfaces;

namespace StatePattern.Model;

class VendingAutomat
{
    private IState _state;


    public VendingAutomat(IState state)
    {
        ChangeState(state);
    }

    public void ChangeState(IState state)
    {
        this._state = state;
    }

    public void ProcessOrder()
    {
        _state.ReceiveOrder();
    }

    public void ProcessChangeReturn()
    {
        _state.ReturnChange();
    }

    public void ProcessWaiting()
    {
        _state.Waiting();
    }

}
