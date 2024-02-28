using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor2.Converters
{
    public class FloatToIntConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float multiplier;

            if (!float.TryParse(parameter as string, out multiplier))
            {
                multiplier = 1;
            }

            return (int)Math.Round(multiplier * (float)value);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float devider;

            if (!float.TryParse(parameter as string, out devider))
            {
                devider = 1;
            }

            return (float)value / devider;
        }
    }
}
