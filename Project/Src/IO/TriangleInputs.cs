using System.Globalization;

namespace Project.Src.IO;

static class TriangleInputs
{
    public static Triangle CreateTriangle()
    {
        Console.Write("Nome: ");
        string name = Console.ReadLine()!;
        Console.Write("Lado 1: ");
        double s1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado 2: ");
        double s2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado 3: ");
        double s3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Triangle t = new(name, s1, s2, s3);

        return t;
    }
}