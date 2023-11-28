using Moneyfy_ProjectWork.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfy_ProjectWork.Models
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Description { get; set; }
        public TransactionType Type { get; set; }
    }
}
