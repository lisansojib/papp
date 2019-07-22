using System;
using System.Globalization;
using Xamarin.Forms;

namespace EPYSLAPPS.Converters
{
    /// <summary>
    /// Which is used to covert the boolean value to color.
    /// </summary>
    public class BooleanToColorConverter : IValueConverter
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
            if ((bool)value)
            {
                return Color.FromRgba(255, 255, 255, 0.6);
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
    }
}
