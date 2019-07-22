using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EPYSLAPPS.ViewModels.Security
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string email;

        private bool isInvalidEmail;

        /// <summary>
        /// This property is bound with an entry that gets the email ID from the user in the login page.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email == value)
                {
                    return;
                }
                email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the value indicating whether the entered email is valid or invalid.
        /// </summary>
        public bool IsInvalidEmail
        {
            get
            {
                return isInvalidEmail;
            }
            set
            {
                if (isInvalidEmail == value)
                {
                    return;
                }
                isInvalidEmail = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
