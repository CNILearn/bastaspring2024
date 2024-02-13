using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace SelectedAvaloniaFeatures.Converter;

internal class DoubleMultiplierConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not int number)
            throw new ArgumentException($"{nameof(DoubleMultiplierConverter)} only accepts Int32.");

        return (number * 2).ToString();
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
