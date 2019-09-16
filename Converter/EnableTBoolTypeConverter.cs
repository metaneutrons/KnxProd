using KnxProd.Model;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace KnxProd.Converter
{
    public class EnableTBoolTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(bool?))
            {
                var enable = value as Enable_T?;
                if (enable == Enable_T.Enabled)
                    return true;

                return false;
            }

            if (targetType == typeof(Enable_T))
            {
                var isEnabled = value as bool?;
                if (isEnabled == true)
                    return Enable_T.Enabled;
                return Enable_T.Disabled;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}