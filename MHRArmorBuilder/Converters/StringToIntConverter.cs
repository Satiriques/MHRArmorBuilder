using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MHRArmorBuilder.Converters
{
    public class StringToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int intValue)
            {
                return intValue.ToString();
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case null:
                case string stringValue when string.IsNullOrEmpty(stringValue):
                    return null;
                case string stringValue when int.TryParse(stringValue, out int intValue):
                    return intValue;
                default:
                    return DependencyProperty.UnsetValue;
            }
        }
    }
}