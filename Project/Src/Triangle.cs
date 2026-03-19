using System.Globalization;

namespace Project.Src;

class Triangle
{
    private string _name;
    private double _s1;
    private double _s2;
    private double _s3;

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

        _s1 = s1;
        _s2 = s2;
        _s3 = s3;
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

    public double S1
    {
        get
        {
            return _s1;
        }
    }

    public double S2
    {
        get
        {
            return _s2;
        }
    }

    public double S3
    {
        get
        {
            return _s3;
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