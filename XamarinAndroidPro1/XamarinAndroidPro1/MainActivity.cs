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
            MobileCenter.Start("26a6302a-d4bc-44ad-933f-c7affe860b90",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

