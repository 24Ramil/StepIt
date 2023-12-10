using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Pattern.Bank;

namespace Proxy_Pattern.Proxy
{
    class ProxyBankAccount : IBankAccount
    {
        private BankAccount _bankAccount = new();

        public void AddAmount(double amount) 
        {
            _bankAccount.AddAmount(amount);
        }
        public void Spend(double amount) 
        {
            _bankAccount.Spend(amount);
        }

        public double GetBalance() 
        {
            return _bankAccount.GetBalance();
        }

    }
}
