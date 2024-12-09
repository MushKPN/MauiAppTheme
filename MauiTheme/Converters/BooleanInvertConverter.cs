using System.Globalization;

namespace MauiTheme.Converters;

public class BooleanInvertConverter : IValueConverter
{
    #region Methods
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value != null ? !(bool)value : null;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return Binding.DoNothing;
    }
    #endregion
}
