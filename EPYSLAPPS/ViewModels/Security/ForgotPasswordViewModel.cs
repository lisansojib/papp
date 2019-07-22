using Xamarin.Forms;

namespace EPYSLAPPS.ViewModels.Security
{
    /// <summary>
    /// ViewModel for forgot password page.
    /// </summary>
    public class ForgotPasswordViewModel : LoginViewModel
    {
        public ForgotPasswordViewModel()
        {
            SignUpCommand = new Command(SignUpClicked);
            SendCommand = new Command(SendClicked);
        }

        /// <summary>
        /// This command is executed when the Send button is clicked.
        /// </summary>
        public Command SendCommand { get; set; }

        /// <summary>
        /// This command is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        private void SendClicked(object obj)
        {        
            
        }

        private void SignUpClicked(object obj)
        {      
            
        }
    }
}