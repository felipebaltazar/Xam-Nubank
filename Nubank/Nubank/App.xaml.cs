using Nubank.Abstractions;
using Nubank.Helpers;
using Nubank.ViewModels;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nubank
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
#if DEBUG
            HotReloader.Current.Run(this, new HotReloader.Configuration {
                ExtensionIpAddress = IPAddress.Parse("192.168.104.2")
            });
#endif
        }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await InitializeNavigationAsync();
        }

        private Task InitializeNavigationAsync()
            => NavigationService.NavigateAsync(nameof(MainPage));

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILogger, Logger>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
