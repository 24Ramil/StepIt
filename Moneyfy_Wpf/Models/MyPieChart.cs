using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Moneyfy_ProjectWork.Models
{
    public class MyPieChart
    {
        public PieChart Chart { get; set; }
        public double Balance { get; set; }
        public DateTime Date { get; set; }

        public MyPieChart()
        {
            Date = DateTime.Today;
            Chart = new();
            Chart.Series.Add(new PieSeries()
            {
                Fill = new SolidColorBrush(Colors.Gray),
                Values = new ChartValues<double> { 100 },
                DataLabels = false
            });
            Chart.InnerRadius = 45;
        }

        public int SearchIndex(Color color)
        {
            for (int i = 0; i < Chart.Series.Count; i++)
            {
                if (Chart.Series[i] is PieSeries pieSeries &&
                    pieSeries.Fill is SolidColorBrush seriesBrush &&
                    seriesBrush.Color == color)
                {
                    return i;
                }
            }
            return 0;
        }

    }

}
