using StatePattern;
using StatePattern.Model;
using StatePattern.Model.Interfaces;


IState initialState = new Order();
VendingAutomat vendingMachine = new VendingAutomat(initialState);

vendingMachine.ProcessWaiting();
vendingMachine.ProcessOrder();

IState nextState = new Expectation();
vendingMachine.ChangeState(nextState);

vendingMachine.ProcessOrder();
vendingMachine.ProcessChangeReturn();
