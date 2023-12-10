using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Bank;
class BankAccount : IBankAccount
{
    private double balance = 0;

    public BankAccount() { }

    public void AddAmount(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount will be positive");
            return;
        }
        balance += amount;
    }

    public void Spend(double amount)
    {
        if (balance < 0)
        {
            Console.WriteLine("Your balance is zero\nAdd your balance");
            return;
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Amount will be positive");
            return;
        }
        else if (balance - amount < 0)
        {
            Console.WriteLine("You don't have enough funds");
            return;
        }
        balance -= amount;
    }
    public double GetBalance()
    {
        return balance;
    }
}
