using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Microsoft.WindowsAzure.MobileServices;

namespace CONEISC.AMS.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
            CurrentPlatform.Init();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}