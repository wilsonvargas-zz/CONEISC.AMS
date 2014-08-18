using Cirrious.MvvmCross.WindowsStore.Views;
using CONEISC.AMS.Core.ViewModels;

namespace CONEISC.AMS.W8_1.Views
{
    public sealed partial class FirstView : MvxStorePage
    {
        public FirstView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (ViewModel != null && ViewModel is FirstViewModel)
            {
                ((FirstViewModel)ViewModel).CargarContactos();
            }

        }
    }
}
