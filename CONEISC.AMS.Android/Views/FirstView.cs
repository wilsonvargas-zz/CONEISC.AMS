using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace CONEISC.AMS.Android.Views
{
    [Activity(Label = "View for FirstViewModel", MainLauncher = true, Icon = "@drawable/icon")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

        }
    }
}