using GalaSoft.MvvmLight.Messaging;
using Moneyfy_ProjectWork.Messages;
using Moneyfy_ProjectWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyfy_ProjectWork.Service.Classes
{
    class DataService : IDataService
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
