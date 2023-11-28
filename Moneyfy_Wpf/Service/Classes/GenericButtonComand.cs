using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Moneyfy_ProjectWork.Service.Classes
{
    class GenericButtonComand<T> where T : ICommand
    {
        private readonly Action<T> _funcToExecute;
        private readonly Func<T, bool> _funcToCheck = (T) => true;


        public event EventHandler? CanExecute
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public GenericButtonComand(Action<T> funcToExecute, Func<T, bool> funcToCheck)
        {
            _funcToExecute = funcToExecute;
            _funcToCheck = funcToCheck;
        }

        public GenericButtonComand(Action<T> funcToExecute)
        {
            _funcToExecute = funcToExecute;
        }

        //public bool CanExecute(object? parameter)
        //{
        //    if (parameter is T value)
        //    {
        //        return _funcToCheck(value);
        //    }
        //    return false;
        //}

        public void Execute(object? parameter)
        {
            if (parameter is T value)
            {
                _funcToExecute(value);
            }
        }
    }

}
