using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using OpenJam.Music.Core;

namespace IntervalCalculator.Views.Converters
{
    public class AccidentalToBrushConverter
        : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((Step) value).Accidental.SignAscii.Length > 2
                ? new SolidColorBrush(Color.FromArgb(255, 0xE8, 0x03, 0x00))
                : new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}