using Project.Src.Utils;

namespace Project.Src.IO;

static class TriangleInputs
{
    public static Triangle CreateTriangle()
    {
        Console.Write("Nome: ");
        string? name = Console.ReadLine();
        Console.Write("Lado 1: ");
        string? s1StringValue = Console.ReadLine();
        Console.Write("Lado 2: ");
        string? s2StringValue = Console.ReadLine();
        Console.Write("Lado 3: ");
        string? s3StringValue = Console.ReadLine();

        double? s1 = ParsingUtils.ParseDoubleOrNull(s1StringValue);
        double? s2 = ParsingUtils.ParseDoubleOrNull(s2StringValue);
        double? s3 = ParsingUtils.ParseDoubleOrNull(s3StringValue);
        Triangle t = new(name, s1, s2, s3);

        return t;
    }
}