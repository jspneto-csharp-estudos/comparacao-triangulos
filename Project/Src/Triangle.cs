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
        S1 = ValidateSide(s1);
        S2 = ValidateSide(s2);
        S3 = ValidateSide(s3);

        if (!TriangleInequality(S1, S2, S3))
        {
            S1 = 3.0;
            S2 = 4.0;
            S3 = 5.0;
        }

        if (NameIsValid(name))
        {
            _name = name;
        }
        else
        {
            _name = "ABC";
        }
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
            if (NameIsValid(value))
            {
                _name = value;
            }
        }
    }

    private static double ValidateSide(double length)
    {
        if (length >= 0.0)
        {
            return length;
        }
        else
        {
            return 1.0;
        }
    }

    private static bool NameIsValid(string name)
    {
        if (name != null && name.Length == 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool TriangleInequality(double s1, double s2, double s3)
    {
        if (s1 < s2 + s3 && s2 < s1 + s3 && s3 < s1 + s2)
        {
            return true;
        }
        else
        {
            return false;
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