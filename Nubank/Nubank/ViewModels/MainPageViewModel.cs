using Nubank.Abstractions;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Nubank.ViewModels
{
    public sealed class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<NavigationViewModel> navigationItemSource;
        private ObservableCollection<DashBoardViewModel> infoSource;

        public ObservableCollection<NavigationViewModel> NavigationItemSource
        {
            get => navigationItemSource;
            set => SetProperty(ref navigationItemSource, value);
        }

        public ObservableCollection<DashBoardViewModel> InfoSource
        {
            get => infoSource;
            set => SetProperty(ref infoSource, value);
        }

        public MainPageViewModel(INavigationService navigationService, ILogger logger)
            : base(navigationService, logger)
        {
            NavigationItemSource = new ObservableCollection<NavigationViewModel>
            {
                new NavigationViewModel(navigationService, logger, "Indicar amigos", ImageSource.FromFile("ic_invite.png")),
                new NavigationViewModel(navigationService, logger, "Cobrar amigos", ImageSource.FromFile("ic_charge.png")),
                new NavigationViewModel(navigationService, logger, "Depositar", ImageSource.FromFile("ic_deposit.png")),
                new NavigationViewModel(navigationService, logger, "Transferir", ImageSource.FromFile("ic_transfer_sent.png")),
                new NavigationViewModel(navigationService, logger, "Pagar", ImageSource.FromFile("ic_payment.png")),
                new NavigationViewModel(navigationService, logger, "Bloquear cartão", ImageSource.FromFile("ic_block.png")),
                new NavigationViewModel(navigationService, logger, "Organizar atalhos", ImageSource.FromFile("ic_order.png"))
            };

            InfoSource = new ObservableCollection<DashBoardViewModel>
            {
                new DashBoardViewModel(navigationService, logger){ ModelKind = Enums.ModelKind.Balance },
                new DashBoardViewModel(navigationService, logger){ ModelKind = Enums.ModelKind.Info },
            };
        }
    }
}
