using System.Globalization;

namespace Project.Src;

class Triangle
{
    public string Name = "ABC";
    public double S1;
    public double S2;
    public double S3;

    public double Area()
    {
        double p = (S1 + S2 + S3) / 2.0;
        return Math.Sqrt(p * (p - S1) * (p - S2) * (p - S3));
    }

    public override string ToString()
    {
        return $"{Name}"
            + $"({Area().ToString("F4", CultureInfo.InvariantCulture)}), "
            + $"{S1.ToString("F4", CultureInfo.InvariantCulture)}, "
            + $"{S2.ToString("F4", CultureInfo.InvariantCulture)}, "
            + $"{S3.ToString("F4", CultureInfo.InvariantCulture)}";
            
    }
}