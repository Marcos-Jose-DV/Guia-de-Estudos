using GuiaDeEstudo.Models;
using System.Globalization;

namespace GuiaDeEstudo.Libraries.Converters;

public class PercetualAEstudadarConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        List<Tema> categoria = (List<Tema>)value;

        if (categoria.Count == 0) return "0.00";


        double valorAtual = 0;
        double valorTotal = categoria.Count;

        for (int i = 0; i < categoria.Count; i++)
        {
            if (categoria[i].Concluido)
            {
                valorAtual++;
            }
        }

        double porcentagem = 100 - (valorAtual / valorTotal * 100);

        return porcentagem.ToString("F2") + "%";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
