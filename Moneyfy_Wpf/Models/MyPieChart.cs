using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using Moneyfly_WPF.Views;
using System.Reflection.Emit;
using System.Windows.Media;

namespace Moneyfly_WPF.Models
{
    class MyPieChart
    {
        //private string pieChartData;

        //private string gigiyena;

        //private string products;

        //private string connection;

        //private string transport;

        //private string restaraunt;

        //private string sport;

        //private string car;

        //private string tax;

        //private string clothes;

        //private string party;

        public PieChart MyChart { get; set; }
        public string CategoryName {
            get => CategoryName;
            set 
            {
                
            } 
        }
        public double Balance { get; set; }
        public DateTime dataTime { get; set; }


    }



}
