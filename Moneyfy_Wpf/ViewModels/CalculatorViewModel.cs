using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using Moneyfy_ProjectWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfy_ProjectWork.ViewModels
{
    class CalculatorViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private PackIcon icon;

        private StringBuilder Expression = new();

        private string _expressionText;

        private string text;
        public string Text
        {
            get => Text;
            set
            {
                Set(ref text, value);
            }
        }
        public PackIcon Icon
        {
            get => icon;
            set
            {
                Set(ref icon, value);
            }
        }

        public string ExpressionText
        {
            get => _expressionText;
            set
            {
                Set(ref _expressionText, value);
            }
        }


        public RelayCommand<string> numClick
        {
            get => new((operation) =>
            {
                if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    ExpressionText += operation;
                else
                {
                    ExpressionText = "";
                }
                Expression.Append(operation);
            });
        }

        public RelayCommand Equal
        {
            get => new(
            () =>
            {
                if (Expression.Length > 0)
                {

                    ExpressionText = new System.Data.DataTable().Compute(Expression.ToString(), null).ToString();
                    Expression.Clear();
                    Expression.Append(ExpressionText);
                }
            });
        }
        public RelayCommand Back
        {
            get => new(() =>
            {
                Expression.Clear();
                _expressionText = "";
                _navigationService.NavigateTo<MainViewModel>();
            });
        }


        public RelayCommand Delete
        {
            get => new(() =>
            {
                if (Expression.Length > 0)
                    Expression.Remove(Expression.Length - 1, 1);

                if (!string.IsNullOrEmpty(ExpressionText))
                    ExpressionText = ExpressionText.Substring(0, ExpressionText.Length - 1);
            });
        }


    }
}
