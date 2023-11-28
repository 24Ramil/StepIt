using GalaSoft.MvvmLight;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using GalaSoft.MvvmLight.Command;
using Moneyfy_ProjectWork.Models;
using Moneyfy_ProjectWork.Service.Classes;
using Moneyfy_ProjectWork.Service.Interfaces;

namespace Moneyfy_ProjectWork.ViewModels
{
    class PieChartViewModel : ViewModelBase
    {
        private MyPieChart myPieChart = new();
        private SeriesCollection _data = new();
        public INavigationService _navigationService;
     
        public MyPieChart MyPieChart
        {
            get => myPieChart;
            set
            {
                Set(ref myPieChart, value);
            }
        }
        public RelayCommand<Brush> AddDataCommand { get; private set; }


        public SeriesCollection Data
        {
            get => _data;
            set
            {
                Set(ref _data, value);
            }
        }

        public PieChartViewModel(INavigationService navigationService)
        {
            AddDataCommand = new RelayCommand<Brush>(AddDataToChart);
            _navigationService = navigationService;
        }

        private void AddDataToChart(Brush brush)
        {
            throw new NotImplementedException();
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

        private void AddDataToChart(string Category, double value, Brush buttonColor)
        {
            AddData(Category, value, buttonColor);
        }

        public ButtonComand CategoryCommand
        {
            get => new(() =>
            {
                _navigationService.NavigateTo<ExpenceViewModel>();
            });
        }
        public ButtonComand IncomeCommand
        {
            get => new(() =>
            {
                _navigationService.NavigateTo<IncomeViewModel>();
            });
        }


        //private readonly INavigationService _navigationService;
        //private readonly IMessenger _messenger;

        //private SeriesCollection _data;

        //public SeriesCollection Data
        //{
        //    get => _data;
        //    set
        //    {
        //        Set(ref _data, value);
        //    }
        //}

        //public PieChartViewModel(INavigationService navigationService, IMessenger messenger)
        //{
        //    _navigationService = navigationService;
        //    _messenger = messenger;
        //    _data = new();

        //    AddDataCommand = new RelayCommand<Brush>(AddDataToChart);

        //    _messenger.Register<ChartDataMessage>(this, message =>
        //    {
        //        message.AddDataToChart?.Invoke(message.Title, message.Value, message.Color);
        //    });
        //}


        //private void AddDataToChart(Brush brush)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddData(string title, double value, Brush color)
        //{
        //    Data.Add(new PieSeries
        //    {
        //        Title = title,
        //        Values = new ChartValues<double> { value },
        //        Fill = color
        //    });
        //}

        //public RelayCommand<Brush> AddDataCommand { get; private set; }

        //private void AddDataToChart(string title, double value, Brush buttonColor)
        //{
        //    var chartDataMessage = new ChartDataMessage
        //    {
        //        Title = title,
        //        Value = value,
        //        Color = buttonColor
        //    };
        //    _messenger.Send(chartDataMessage);
        //}



        //public RelayCommand IncomeCommand => new(
        //    () =>
        //    {
        //        _navigationService.NavigateTo<IncomeViewModel>();
        //    });


        //public RelayCommand ExpenseButton => new(
        //    () =>
        //    {
        //        _navigationService.NavigateTo<ExpenceViewModel>();
        //    });

    }

}
