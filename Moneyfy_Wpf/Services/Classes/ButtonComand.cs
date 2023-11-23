using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Moneyfly_WPF.Services.Classes
{
    class ButtonComand:ICommand
    {
        private readonly Action _funcToExecute;
        private readonly Func<bool> _funcToCheck = () => true;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public ButtonComand(Action funcToExecute)
        {
            _funcToExecute = funcToExecute;
        }

        public ButtonComand(Action funcToExecute, Func<bool> funcToCheck)
        {
            _funcToExecute = funcToExecute;
            _funcToCheck = funcToCheck;
        }

        public bool CanExecute(object? parameter)
        {
            return _funcToCheck();
        }

        public void Execute(object? parameter)
        {
            _funcToExecute();
        }

    }
}
