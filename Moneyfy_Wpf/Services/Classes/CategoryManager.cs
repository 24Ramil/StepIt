using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfly_WPF.Services.Classes;

using Monefy.ViewModels;
using Moneyfly_WPF.Services.Interfaces;
    using Moneyfly_WPF.ViewModels;

class CategoryManager
    {
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        private readonly INavigationService _messenger;

        public CategoryManager(INavigationService navigationService, IDataService dataService, INavigationService messenger) 
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;

        }

        public ButtonComand CategoriesCommand
        {
            get => new(
            () =>
            {
                _navigationService.NavigateTo<CalculatorViewModel>();
            });
        }


    }

