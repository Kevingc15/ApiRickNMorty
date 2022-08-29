using ApiRickNMorty.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ApiRickNMorty.Converters
{
    internal class CharacterStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = value as string;
            switch (valor)
            {
                case "Alive": return Color.FromHex("33FF39");
                case "Dead": return Color.FromHex("FE1919");
                case "unknown": return Color.FromHex("E8FE14");
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
