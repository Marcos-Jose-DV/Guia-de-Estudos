

using System.Globalization;

namespace GuiaDeEstudo.Libraries.Converters;

public class PercentualQuestoesBackGroundColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var percentual = (double)value;

        return percentual switch
        {
            < 50 => Color.FromArgb("#FF0000"),
            < 60 => Color.FromArgb("#FF9999"),
            < 70 => Color.FromArgb("#FF4500"),
            < 80 => Color.FromArgb("#FFA500"),
            < 100 => Color.FromArgb("#008000"),
            _ => Color.FromArgb("#000000")
        }; 
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
