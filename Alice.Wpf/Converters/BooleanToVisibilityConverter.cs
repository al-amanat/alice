using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Alice.Wpf.Converters
{
    /// <summary>
    /// Converts boolean to Visibility.
    /// </summary>
    /// <remarks>True -> Visible, False -> Collapsed</remarks>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(Visibility))
                throw new InvalidOperationException(string.Format(Properties.Resources.Converter_ExpectedTargetType, typeof(Visibility)));

            if (value == null)
                return Visibility.Collapsed;

            bool boolValue;
            if (!Boolean.TryParse(value.ToString(), out boolValue))
                throw new ArgumentException(string.Format(Properties.Resources.Converter_ExpectedSourceType, typeof(bool)));

            if (boolValue)
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
