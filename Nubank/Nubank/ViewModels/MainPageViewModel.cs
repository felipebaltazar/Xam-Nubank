using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Nubank.Abstractions;
using Prism.Navigation;

namespace Nubank.ViewModels
{
    public sealed class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<string> navigationItemSource = new ObservableCollection<string>
        {
            "Indicar amigos",
            "Cobrar amigos",
            "Depositar",
            "Transferir"
        };


        private ObservableCollection<string> infoSource = new ObservableCollection<string>
        {
            "Saldo atual"
        };

        public ObservableCollection<string> NavigationItemSource
        {
            get => navigationItemSource;
            set => SetProperty(ref navigationItemSource, value);
        }


        public ObservableCollection<string> InfoSource
        {
            get => infoSource;
            set => SetProperty(ref infoSource, value);
        }

        public MainPageViewModel(INavigationService navigationService, ILogger logger)
            : base(navigationService, logger)
        {
        }
    }
}
