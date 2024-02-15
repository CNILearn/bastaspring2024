using Avalonia.Data.Converters;

namespace SelectedAvaloniaFeatures.Converter;

internal static class NumberConverters
{
    public static FuncValueConverter<int, string> Double { get; } =
        new(num => (num * 2).ToString());

    public static FuncValueConverter<int, string> Triple { get; } =
        new(num => (num * 3).ToString());

    // ...
}
