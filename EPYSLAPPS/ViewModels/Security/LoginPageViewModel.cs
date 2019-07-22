using Android.Content.Res;
using Xamarin.Forms;

namespace EPYSLAPPS.ViewModels.Security
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    public class LoginPageViewModel : LoginViewModel
    {
        private string password;

        public LoginPageViewModel()
        {
            LoginCommand = new Command(LoginClicked);
            ForgotPasswordCommand = new Command(ForgotPasswordClicked);
        }

        /// <summary>
        /// This property is bound with an entry that gets the password from the user in the login page.
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password == value)
                {
                    return;
                }
                password = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// This command is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// This command is executed when the Forgot Password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        private void LoginClicked(object obj)
        {
            var a = Password;
            var b = Email;
        }

        private void ForgotPasswordClicked(object obj)
        {
        }
    }
}