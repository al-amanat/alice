using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace Alice.Wpf.Converters
{
    class EnumToDescriptionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(string))
                throw new InvalidOperationException(string.Format(Properties.Resources.Converter_ExpectedTargetType, typeof(string)));

            if (value == null)
                return null;

            var type = value.GetType();

            if (!type.IsEnum)
                throw new ArgumentException(string.Format(Properties.Resources.Converter_ExpectedSourceType, typeof(Enum)));

            return EnumExtension.GetDescription((Enum)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
