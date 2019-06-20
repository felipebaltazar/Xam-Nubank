using Nubank.Abstractions;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nubank.ViewModels
{
    public abstract class BaseViewModel
        : BindableBase, INavigationAware, IDestructible
    {
        #region Field

        private bool isBusy;

        #endregion

        #region Properties

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value, () => RaisePropertyChanged(nameof(IsNotBusy)));
        }

        protected INavigationService NavigationService { get; }

        protected ILogger Logger { get; }

        public bool IsNotBusy => !IsBusy;

        #endregion

        #region Constructors

        protected BaseViewModel(INavigationService navigationService, ILogger logger)
        {
            NavigationService = navigationService;
            Logger = logger;
        }

        #endregion

        #region Public Methods

        protected async Task ExecuteBusyActionAsync(Func<Task> theBusyAction)
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                await theBusyAction?.Invoke();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        #endregion

        #region IDestructible

        public virtual void Destroy() { }

        #endregion

        #region INavigationAware

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void OnNavigatingTo(INavigationParameters parameters) { }

        #endregion
    }
}
