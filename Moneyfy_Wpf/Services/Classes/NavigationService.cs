using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using Moneyfly_WPF.Message;
using System;
using Moneyfly_WPF.Services.Interfaces;

namespace Moneyfly_WPF.Services.Classes
{
    class NavigationService : INavigationService
    {
        private readonly IMessenger _messenger;
        public NavigationService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public string CurrentPageKey => throw new NotImplementedException();

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void NavigateTo<T>() where T : ViewModelBase
        {
            _messenger.Send(new NavigationMessage()
            {
                ViewModelType = App.Container.GetInstance<T>()
            });
        }
    }

}
