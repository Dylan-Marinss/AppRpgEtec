using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics.Converters;
using System.Globalization;

namespace AppRpgEtec.Converters
{
    public class PontosVidaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ColorTypeConverter converter = new ColorTypeConverter();

            int pontosVidas = (int)value;

            if (pontosVidas == 100)
                return converter.ConvertFromInvariantString("SeaGreen");
            else if (pontosVidas >= 75)
                return converter.ConvertFromInvariantString("YellowGreen");
            else if (pontosVidas >= 25)
                return converter.ConvertFromInvariantString("Yellow");
            else if (pontosVidas >= 1)
                return converter.ConvertFromInvariantString("OrangeRed");
            else
                return converter.ConvertFromInvariantString("Red");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}