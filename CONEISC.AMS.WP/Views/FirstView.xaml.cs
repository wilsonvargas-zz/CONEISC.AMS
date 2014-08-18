using Cirrious.MvvmCross.WindowsPhone.Views;
using CONEISC.AMS.Core.ViewModels;

namespace CONEISC.AMS.WP.Views
{
    public partial class FirstView : MvxPhonePage
    {
        public FirstView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (ViewModel != null && ViewModel is FirstViewModel)
            {
                ((FirstViewModel)ViewModel).CargarContactos();
            }
        }
    }
}