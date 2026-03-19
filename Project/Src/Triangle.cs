using System.Globalization;

namespace Project.Src;

class Triangle
{
    private string _name;
    public double S1 { get; private set; }
    public double S2 { get; private set; }
    public double S3 { get; private set; }

    public Triangle(string name, double s1, double s2, double s3)
    {
        if (name != null && name.Length == 3)
        {
            _name = name;
        }
        else
        {
            _name = "ABC";
        }

        S1 = s1;
        S2 = s2;
        S3 = s3;
    }

    public Triangle(string name) : this(name, 3.0, 4.0, 5.0) {}

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            if (value != null && value.Length == 3)
            {
                _name = value;
            }
            else
            {
                _name = "ABC";
            }
        }
    }

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