using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using Moneyfly_WPF.Models;
using GalaSoft.MvvmLight;
using System.Windows.Media;
using System.Windows.Data;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace Moneyfly_WPF.ViewModels
{
    class PieChartViewModel : ViewModelBase
    {
        private MyPieChart myPieChart = new();
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


        public MyPieChart MyPieChart
        {
            get => myPieChart;
            set
            {
                Set(ref  myPieChart, value);
            }
        }

        private SeriesCollection _data = new();

        public SeriesCollection Data
        {
            get => _data;
            set
            {
                Set(ref _data, value);
            }
        }

        public PieChartViewModel()
        {
            AddDataCommand = new RelayCommand<Brush>(AddDataToChart);
        }

     

        public void AddData(string title, double value, Brush color)
        {
            Data.Add(new PieSeries
            {
                Title = title,
                Values = new ChartValues<double> { value },
                Fill = color
            });
        }

        public RelayCommand<Brush> AddDataCommand { get; private set; }


        private void AddDataToChart(Brush buttonColor)
        {
            AddData("Button command", 50, buttonColor);
        }

    }






        //public string PieChartData { get => pieChartData; set => Set(ref pieChartData, value); }


        //public string Gigiyena { get => gigiyena; set => Set(ref gigiyena, value); }


        //public string Products { get => products; set => Set(ref products, value); }


        //public string Transport { get => transport; set => Set(ref transport, value); }


        //public string Restaraunt { get => restaraunt; set => Set(ref restaraunt, value); }


        //public string Connection { get => connection; set => Set(ref connection, value); }


        //public string Car { get => car; set => Set(ref car, value); }


        //public string Tax { get => tax; set => Set(ref tax, value); }


        //public string Sport { get => sport; set => Set(ref sport, value); }


        //public string Clothes { get => clothes; set => Set(ref clothes, value); }


        //public string Party { get => party; set => Set(ref party, value); }



        //public SeriesCollection DatSeries { get; set; }
        //public PieSeries Home { get; set; }
        //public PieSeries Medichine { get; set; }
        //public PieSeries Gigiyena { get; set; }
        //public PieSeries Products { get; set; }
        //public PieSeries Transport { get; set; }
        //public PieSeries Restaraunt { get; set; }
        //public PieSeries Connection { get; set; }
        //public PieSeries Car { get; set; }
        //public PieSeries Tax { get; set; }
        //public PieSeries Sport { get; set; }
        //public PieSeries Clothes { get; set; }
        //public PieSeries Party { get; set; }

        //public PieChartVM()
        //{
        //   DatSeries = new SeriesCollection
        //{
        //    new PieSeries
        //    {
        //        Title = "Home",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(40) },
        //    },

        //    new PieSeries
        //    {
        //        Title = "Medichine",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(30) },
        //    },

        //    new PieSeries
        //    {
        //        Title = "Gigiyena",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(20) },
        //    },

        //    new PieSeries
        //    {
        //        Title = "Products",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Transport",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Restaraunt",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Connection",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Car",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Tax",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Sport",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Clothes",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //    new PieSeries
        //    {
        //        Title = "Party",
        //        Values = new ChartValues<ObservableValue> {new ObservableValue(30)}
        //    },

        //};

        //}
}