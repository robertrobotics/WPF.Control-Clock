using System;
using System.Globalization;
using System.Windows.Data;

namespace UsefulControls.Clock.Converters
{
    public class DayNameToShortConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>  value is DayOfWeek
                                                                                                        ? value.ToString().Substring(0, 3)
                                                                                                        : string.Empty;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
