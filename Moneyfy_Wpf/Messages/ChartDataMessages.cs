using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Moneyfy_ProjectWork.Messages
{
    public class ChartDataMessage
    {
        public Action<string, double, Brush> AddDataToChart { get; set; }

        public string Name { get; set; }
        public double Value { get; set; }
        public Brush Color { get; set; }
        public string Title { get; internal set; }

        public ChartDataMessage() 
        {
            
        }
    }
}
