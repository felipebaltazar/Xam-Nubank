using Nubank.Enums;
using Nubank.ViewModels;
using Xamarin.Forms;

namespace Nubank.Helpers
{
    public sealed class BalanceTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ValidTemplate { get; set; }
        public DataTemplate InvalidTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((DashBoardViewModel)item).ModelKind == ModelKind.Balance ? ValidTemplate : InvalidTemplate;
        }
    }
}
