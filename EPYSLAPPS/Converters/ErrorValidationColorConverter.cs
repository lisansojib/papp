using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using EPYSLAPPS.Controls;
using EPYSLAPPS.ViewModels.Security;

namespace EPYSLAPPS.Converters
{
    /// <summary>
    /// Which is used to convert the email entry border color.
    /// </summary>
    public class ErrorValidationColorConverter : IValueConverter
    {
        /// <summary>
        /// This method is used to convert the bool to color
        /// </summary>
        /// <param name="value">Gets the value</param>
        /// <param name="targetType">Gets the target type</param>
        /// <param name="parameter">Gets the parameter</param>
        /// <param name="culture">Gets the culture</param>
        /// <returns>Return the color</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BorderlessEntry emailEntry = parameter as BorderlessEntry;

            if (emailEntry.BindingContext is LoginViewModel bindingContext)
            {
                var isFocused = (bool)value;
                bindingContext.IsInvalidEmail = isFocused ? false : !CheckValidEmail(bindingContext.Email);

                if (isFocused)
                {
                    return Color.FromRgba(255, 255, 255, 0.6);
                }

                if (bindingContext.IsInvalidEmail)
                {
                    return Color.FromHex("#FF4A4A");
                }
            }

            return Color.Transparent;
        }

        /// <summary>
        /// This method is used to convert back the color to bool
        /// </summary>
        /// <param name="value">Gets the value</param>
        /// <param name="targetType">Gets the target type</param>
        /// <param name="parameter">Gets the parameter</param>
        /// <param name="culture">Gets the culture</param>
        /// <returns>Returns the string</returns>        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        /// <summary>
        /// Which is used to validate the email.
        /// </summary>
        /// <param name="email">Gets the email</param>
        /// <returns>Returns the boolean value</returns>
        private static bool CheckValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return true;

            var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return regex.IsMatch(email) && !email.EndsWith(".");
        }
    }
}
