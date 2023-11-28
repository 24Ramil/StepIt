using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfy_ProjectWork.ViewModels
{
    public class IncomeViewModel : ViewModelBase
    {
        private double _incomeAmount;
        public double IncomeAmount
        {
            get => _incomeAmount;
            set => Set(ref _incomeAmount, value);
        }

    }

}
