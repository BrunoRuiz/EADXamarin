using System;
using System.Globalization;
using Xamarin.Forms;

namespace TODOList.Converter
{
    public class FinalizadoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (bool)value;

            if (valor)
                return "Finalizado";
            else
                return "Aberto";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
