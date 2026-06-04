using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Maui.Controls;

using System.Text;

namespace AppRpgEtec.Converters
{
    public class ByteArrayTolmageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ImageSource retSource = null;

            if (value != null)
            {
                byte[] imageAsBytes = (byte[])value;
                retSource = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));
            }

            return retSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

       
}

