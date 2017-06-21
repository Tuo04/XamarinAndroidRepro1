using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace XamarinAndroidPro1
{
    [Activity(Label = "XamarinAndroidPro1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            MobileCenter.Start("0ed7132c-4ae8-4701-bab7-6c958ae7d95f",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

