using System.Globalization;

namespace Project.Src;

class Triangle
{
    private string _name;
    public Segment S1 { get; private set; }
    public Segment S2 { get; private set; }
    public Segment S3 { get; private set; }

    public Triangle(string? name, double? s1, double? s2, double? s3)
    {
        _name = NameIsValid(name) ? name!.ToUpper() : "ABC";
        
        string[] sideNames = ExtractNameSides(_name);
        S1 = new(sideNames[0], s1);
        S2 = new(sideNames[1], s2);
        S3 = new(sideNames[2], s3);

        if (!TriangleInequality(S1.Length, S2.Length, S3.Length))
        {
            S1 = new(sideNames[0], 3.0);
            S2 = new(sideNames[1], 4.0);
            S3 = new(sideNames[2], 5.0);
        }
    }

    public Triangle(string? name) : this(name, 3.0, 4.0, 5.0) {}

    public string? Name
    {
        get
        {
            return _name;
        }

        set
        {
            if (NameIsValid(value))
            {
                _name = value!.ToUpper();

                string[] sideNames = ExtractNameSides(_name);
                S1 = new(sideNames[0], S1.Length);
                S2 = new(sideNames[1], S2.Length);
                S3 = new(sideNames[2], S3.Length);
            }
        }
    }

    private static bool TriangleInequality(double s1, double s2, double s3)
    {
        return s1 < s2 + s3 && s2 < s1 + s3 && s3 < s1 + s2;
    }

    public static string[] ExtractNameSides(string triangleName)
    {
        return [
            $"{triangleName[0]}{triangleName[1]}",
            $"{triangleName[0]}{triangleName[2]}",
            $"{triangleName[1]}{triangleName[2]}"
        ];
    }

    public static bool NameIsValid(string? name)
    {
        return !string.IsNullOrWhiteSpace(name) && name.Length == 3;
    }

    public double Area()
    {
        double p = (S1.Length + S2.Length + S3.Length) / 2.0;
        return Math.Sqrt(p * (p - S1.Length) * (p - S2.Length) * (p - S3.Length));
    }

    public override string ToString()
    {
        return $"{Name}"
            + $"({Area().ToString("F4", CultureInfo.InvariantCulture)}), "
            + $"{S1.ToString()}, "
            + $"{S2.ToString()}, "
            + $"{S3.ToString()}";
            
    }
}