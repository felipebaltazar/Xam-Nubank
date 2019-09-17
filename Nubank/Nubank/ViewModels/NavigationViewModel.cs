using Nubank.Abstractions;
using Prism.Navigation;
using Xamarin.Forms;

namespace Nubank.ViewModels
{
    public sealed class NavigationViewModel : BaseViewModel
    {
        private ImageSource imageSource;
        private string title;

        public NavigationViewModel(INavigationService navigationService, ILogger logger,
            string title, ImageSource icon)
            : base(navigationService, logger)
        {
            Title = title;
            Icon = icon;
        }

        public ImageSource Icon
        {
            get => imageSource;
            set => SetProperty(ref imageSource, value);
        }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

    }
}
