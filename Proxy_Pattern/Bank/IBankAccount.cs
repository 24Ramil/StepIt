using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Bank;

interface IBankAccount
{
    public void AddAmount(double amount);
    public void Spend(double amount);
    public double GetBalance();
}
