using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneyfy_ProjectWork.Service.Interfaces;
using Moneyfy_ProjectWork.ViewModels;

namespace Moneyfy_ProjectWork.Service.Classes
{
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

}
