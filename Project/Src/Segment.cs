using System.Globalization;

namespace Project.Src;

class Segment
{
    public string Name { get; private set; }
    public double Length { get; private set; }

    public Segment(string? name, double? length)
    {
        Name = ValidateName(name);
        Length = ValidateLength(length);
    }

    private static string ValidateName(string? name)
    {
        return !string.IsNullOrWhiteSpace(name) && name.Length == 2 ? name!.ToUpper() : "AB";
    }

    private static double ValidateLength(double? length)
    {
        return length.HasValue && length.Value > 0.0 ? length.Value : 1.0;
    }

    public override string ToString()
    {
        return $"{Name}({Length.ToString("F4", CultureInfo.InvariantCulture)})";
    }
}