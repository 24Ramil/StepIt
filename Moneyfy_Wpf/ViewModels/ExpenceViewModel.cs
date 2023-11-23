using GalaSoft.MvvmLight;
using Moneyfly_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Moneyfly_WPF.Services.Interfaces;
using GalaSoft.MvvmLight.Command;

namespace Moneyfly_WPF.ViewModels
{
    public class ExpenceViewModel:ViewModelBase
    {
        private readonly INavigationService navigationService;

        public ExpenceViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            OpenExpenseCommand = new RelayCommand(OpenExpense);
        }

        public ICommand OpenExpenseCommand { get; }

        internal void OpenExpence()
        {
            throw new NotImplementedException();
        }

        private void OpenExpense()
        {
            navigationService.NavigateTo<MainViewModel>();
        }


        
    }
}
