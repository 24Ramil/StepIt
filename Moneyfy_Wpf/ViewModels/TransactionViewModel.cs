using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Moneyfy_ProjectWork.Enums;
using Moneyfy_ProjectWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Moneyfy_ProjectWork.ViewModels
{
    public class TransactionViewModel : ViewModelBase
    {
        private ObservableCollection<Transaction> _transactionList;
        public ObservableCollection<Transaction> TransactionList
        {
            get => _transactionList;
            set => Set(ref _transactionList, value);
        }

        public ICommand AddTransactionCommand { get; }

        public TransactionViewModel()
        {
            _transactionList = new ObservableCollection<Transaction>();
            AddTransactionCommand = new RelayCommand(AddTransaction);
        }

        private void AddTransaction()
        {
            var transaction = new Transaction()
            {
                Amount = 100.0, 
                Description = "Sample Transaction",
                Type = TransactionType.Expense
            };

            _transactionList.Add(transaction);
            RaisePropertyChanged(() => TransactionList);
        }
    }
}
