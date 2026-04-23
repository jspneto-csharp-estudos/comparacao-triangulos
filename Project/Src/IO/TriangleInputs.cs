using System.Globalization;

namespace Project.Src.IO;

class TriangleInputs
{
    public static Triangle ReadTriangle()
    {
        Triangle t = new();

        Console.Write("Nome: ");
        t.Name = Console.ReadLine()!;
        Console.Write("Lado 1: ");
        t.Side1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado 2: ");
        t.Side2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado 3: ");
        t.Side3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return t;
    }
}