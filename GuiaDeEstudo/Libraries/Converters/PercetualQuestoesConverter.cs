using System.Globalization;

namespace GuiaDeEstudo.Libraries.Converters;

public class PercetualQuestoesConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null) return null;
        double percentual = (double)value;

        return percentual.ToString("F0") + "%";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
