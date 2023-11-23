using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfly_WPF.Models
{
    public class Expence
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
    }

}
