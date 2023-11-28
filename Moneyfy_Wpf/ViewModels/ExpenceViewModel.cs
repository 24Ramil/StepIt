
using Moneyfy_ProjectWork.Service.Classes;
using Moneyfy_ProjectWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Windows.Media;

namespace Moneyfy_ProjectWork.ViewModels
{
    public class ExpenceViewModel : GalaSoft.MvvmLight.ViewModelBase
    {
        private double _expenseAmount;
        public INavigationService _navigationService;
        public double ExpenseAmount
        {
            get => _expenseAmount;
            set => Set(ref _expenseAmount, value);
        }

        public ExpenceViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        //public ButtonComand BackToMainCommand
        //{
        //    get => new(() =>
        //    {
        //        _navigationService.NavigateTo<MainViewModel>();
        //    });

        //}

    }


}
