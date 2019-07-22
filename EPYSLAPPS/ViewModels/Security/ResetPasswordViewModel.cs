using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace EPYSLAPPS.ViewModels.Security
{
    /// <summary>
    /// ViewModel for reset password page.
    /// </summary>
    public class ResetPasswordViewModel : INotifyPropertyChanged
    {
        private string newPassword;

        private string confirmPassword;

        public ResetPasswordViewModel()
        {
            SubmitCommand = new Command(SubmitClicked);
        }

        /// <summary>
        /// This property is bound with an entry that gets the new password from the user in the reset password page.
        /// </summary>
        public string NewPassword
        {
            get
            {
                return newPassword;
            }
            set
            {
                if (newPassword == value)
                {
                    return;
                }
                newPassword = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// This property is bound with an entry that gets the new password confirmation from the user in the reset password page.
        /// </summary>
        public string ConfirmPassword
        {
            get
            {
                return confirmPassword;
            }
            set
            {
                if (confirmPassword == value)
                {
                    return;
                }
                confirmPassword = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This command is executed when the Submit button is clicked.
        /// </summary>
        public Command SubmitCommand { get; set; }

        private void SubmitClicked(object obj)
        {

        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}