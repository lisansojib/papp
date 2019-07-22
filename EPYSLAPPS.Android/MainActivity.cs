using Android.App;
using Android.Content.PM;
using Android.OS;

namespace EPYSLAPPS.Android
{
    [Activity(Label = "EPYSLAPPS", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTIzMzIwQDMxMzcyZTMxMmUzMFlXYkJJSFR2S1pjQzB3TDBuUDJSSyswWFdNeDBlbUNPQm52WlRNMVFUbHc9");
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

