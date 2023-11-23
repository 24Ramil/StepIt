using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using Moneyfly_WPF.Message;
using Moneyfly_WPF.Services.Interfaces;

namespace Moneyfly_WPF.Services.Classes
{
    class DataService:IDataService
    {
        private readonly IMessenger _messenger;
        public DataService(IMessenger service) 
        {
            _messenger = service;
        }
        public void SendData(object data)
        {
            _messenger.Send(new DataMessage()
            {
                Data = data
            });
        }

    }
}
