using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfy_ProjectWork.Messages
{
    public class NavigationMessage
    {
        public Type Data { get; set; }
        public ViewModelBase ViewModelType { get; set; }
    }
}
