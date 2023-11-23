using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfly_WPF.Models
{
    public class Income
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; } = 0;
        public string Categorty { get; set; }

        public Income() 
        {

        }

    }

}
