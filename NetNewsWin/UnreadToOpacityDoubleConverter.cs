using System;
using Windows.UI.Xaml.Data;

namespace NetNewsWin
{
    // Converts a boolean to a double. For setting unread markers to opacity=0 when Unread=false
    public class UnreadToOpacityDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double visible = 100d;
            double invisible = 0d;

            var unread = (bool)value;

            return unread ? visible : invisible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
