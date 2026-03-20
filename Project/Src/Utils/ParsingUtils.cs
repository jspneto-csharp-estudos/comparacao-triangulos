using System.Globalization;

namespace Project.Src.Utils;

static class ParsingUtils
{
    public static double? ParseDoubleOrNull(string? value)
    {
        return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double output)
            ? output
            : null;
    }
}