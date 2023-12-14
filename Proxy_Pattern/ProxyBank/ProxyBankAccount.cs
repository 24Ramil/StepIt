using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Pattern.Bank;

namespace Proxy_Pattern.Proxy
{
    class ProxyBankAccount : IBankAccount
    {
        private BankAccount _bankAccount = new();
        private string password = "mypassword123";
        public void AddAmount(double amount) 
        {
            _bankAccount.AddAmount(amount);
        }
        public void Spend(double amount) 
        {
            string inputPassword;
            Console.Write("Enter password: ");
            inputPassword = Console.ReadLine();

            if (inputPassword != null && inputPassword == this.password) 
            {
                _bankAccount.Spend(amount);
                return;
            }
            Console.WriteLine("Incorrect password!");
        }

        public double GetBalance() 
        {
            return _bankAccount.GetBalance();
        }

    }
}
