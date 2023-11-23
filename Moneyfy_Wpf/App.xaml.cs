using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using Monefy.ViewModels;
using Moneyfly_WPF.Services.Classes;
using Moneyfly_WPF.Services.Interfaces;
using Moneyfly_WPF.ViewModels;
using Moneyfly_WPF.Views;
using SimpleInjector;
using System.Windows;

namespace Moneyfly_WPF
{
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        public void Register()
        {
            Container.RegisterSingleton<IJsonService, JsonService>();
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IDataService, DataService>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<PieChartViewModel>();
            Container.RegisterSingleton<CalculatorViewModel>();
            Container.RegisterSingleton<IncomeViewModel>();
            Container.RegisterSingleton<ExpenceViewModel>();

            Container.Verify();
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