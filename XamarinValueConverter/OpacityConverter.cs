using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinValueConverter
{
    public class OpacityConverter : IValueConverter
    {

        public double True { get; set; }

        public double False { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return False;
            }
            if (value.GetType() != typeof(bool))
            {
                return False;
            }
            return ((bool)value) ? True : False;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

    }
}