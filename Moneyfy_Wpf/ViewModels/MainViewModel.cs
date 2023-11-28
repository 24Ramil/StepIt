using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Moneyfy_ProjectWork.ViewModels;
using GalaSoft.MvvmLight;
using Moneyfy_ProjectWork.Messages;
using GalaSoft.MvvmLight.Messaging;

namespace Moneyfy_ProjectWork.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;


    private ViewModelBase _currentView;
    public ViewModelBase CurrentView
    {
        get => _currentView;
        set
        {
            Set(ref _currentView, value);
        }
    }

    public MainViewModel(IMessenger messenger)
    {
        _messenger = messenger;
        CurrentView = App.Container.GetInstance<PieChartViewModel>();

        _messenger.Register<NavigationMessage>(this, message =>
        {
            CurrentView = message.ViewModelType;
        });
    }



}
