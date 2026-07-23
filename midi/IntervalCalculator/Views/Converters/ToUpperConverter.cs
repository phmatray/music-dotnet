using System;
using Windows.UI.Xaml.Data;

namespace IntervalCalculator.Views.Converters
{
    public class ToUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
            => ((string)value).ToUpper();

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}