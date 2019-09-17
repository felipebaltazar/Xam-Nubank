using Nubank.Abstractions;
using Nubank.Enums;
using Prism.Navigation;

namespace Nubank.ViewModels
{
    public sealed class DashBoardViewModel : BaseViewModel
    {
        private string info;
        private ModelKind modelKind;

        public DashBoardViewModel(INavigationService navigationService, ILogger logger)
            : base(navigationService, logger)
        {
        }

        public ModelKind ModelKind
        {
            get => modelKind;
            set => SetProperty(ref modelKind, value);
        }

        public string Info
        {
            get => info;
            set => SetProperty(ref info, value);
        }
    }
}
