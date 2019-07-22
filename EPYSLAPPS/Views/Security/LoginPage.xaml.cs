using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EPYSLAPPS.Views.Security
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (Device.Idiom != TargetIdiom.Desktop)
            {
                if (width > height)
                {
                    rootView.Margin = (Device.Idiom == TargetIdiom.Phone)
                        ? new Thickness(150, 20)
                        : new Thickness(300, 50);
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        BackgroundImage = "LoginBackground-Landscape.png";
                    }
                }
                else
                {
                    rootView.Margin = Device.Idiom == TargetIdiom.Phone
                        ? new Thickness(20, 20)
                        : new Thickness(200, 50);
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        BackgroundImage = "LoginBackground.png";
                    }
                }
            }
            else
            {
                rootView.WidthRequest = 350;
                rootView.Margin = new Thickness(30);
            }
        }
    }
}