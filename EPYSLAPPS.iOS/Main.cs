using UIKit;

namespace EPYSLAPPS.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTIzMzIwQDMxMzcyZTMxMmUzMFlXYkJJSFR2S1pjQzB3TDBuUDJSSyswWFdNeDBlbUNPQm52WlRNMVFUbHc9");
            
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
