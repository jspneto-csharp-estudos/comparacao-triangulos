using System.Globalization;

namespace Project.Src.IO;

static class TriangleInputs
{
    public static Triangle CreateTriangle()
    {
        Triangle t = new();

        Console.Write("Nome: ");
        t.Name = Console.ReadLine()!;
        Console.Write("Lado 1: ");
        t.S1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado 2: ");
        t.S2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado 3: ");
        t.S3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return t;
    }
}