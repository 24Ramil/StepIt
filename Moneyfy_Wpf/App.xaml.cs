using Moneyfy_ProjectWork.ViewModels;
using System;
using System.Collections.Generic;
using SimpleInjector;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using Moneyfy_ProjectWork.Views;
using Moneyfy_ProjectWork.Service.Interfaces;
using Moneyfy_ProjectWork.Service.Classes;

namespace Moneyfy_ProjectWork
{
    public partial class App : Application
    {
        public static Container Container { get; set; } = new Container();


        public void Register()
        {
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IDataService, DataService>();
            //Container.RegisterSingleton<IChart, ChartService>();


            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<PieChartViewModel>();
            Container.RegisterSingleton<IncomeViewModel>();
            Container.RegisterSingleton<ExpenceViewModel>();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            MainView window = new();

            window.DataContext = Container.GetInstance<MainViewModel>();

            window.ShowDialog();
        }


    }

}
