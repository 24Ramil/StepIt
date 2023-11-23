using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfly_WPF.ViewModels
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Messaging;
    using Moneyfly_WPF.Message;
    using Moneyfly_WPF.Models;
    using Moneyfly_WPF.Services.Interfaces;
    using System.Collections.ObjectModel;

    public class MainViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private ViewModelBase _currentView;

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set 
            {
                Set(ref _currentView, value);
            }
        }
        public MainViewModel(IMessenger messenger)
        {
            _messenger = messenger;
            CurrentView = App.Container.GetInstance<PieChartViewModel>();

            _messenger.Register<NavigationMessage>(this, message =>
            {
                CurrentView = message.ViewModelType;
            });
        }

        //PieChartData = new ObservableCollection<MyPieChart>
        //{
        //    new MyPieChart
        //    {
        //        CategoryName = "Home", Balance = 25.5  
        //    },
        //    new MyPieChart
        //    {
        //        CategoryName = "Medichine", Balance = 35.0 
        //    },
        //    new MyPieChart
        //    {
        //        CategoryName = "Car", Balance = 35.0
        //    },
        //    new MyPieChart
        //    {
        //        CategoryName = "Gigiyena", Balance = 35.0
        //    },



        //};
        //public ObservableCollection<MyPieChart> PieChartData
        //{
        //    get { return _pieChartData; }
        //    set
        //    {
        //        _pieChartData = value;
        //        OnPropertyChanged(nameof(PieChartData));
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
