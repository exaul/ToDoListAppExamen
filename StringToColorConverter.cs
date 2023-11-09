using System.Globalization;

namespace ToDoListApp
{
    public class StringToColorConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value.ToString();
            switch (color)
            {
                case "Blue":
                    return Colors.Blue;
                case "Red":
                    return Colors.Red;
                default:
                    return Colors.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
