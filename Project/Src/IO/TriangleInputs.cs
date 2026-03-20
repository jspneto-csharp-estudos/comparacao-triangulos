using Project.Src.Utils;

namespace Project.Src.IO;

static class TriangleInputs
{
    public static Triangle CreateTriangle()
    {
        Console.Write("Nome: ");
        string? name = Console.ReadLine();
        
        while (!Triangle.NameIsValid(name))
        {
            Console.Write("  ¬ Erro. O nome deve ter três caracteres. Digite novamente: ");
            name = Console.ReadLine();
        }

        string[] nameSides = Triangle.ExtractNameSides(name!.ToUpper());
        string?[] sideLengths = new string[3];
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Lado {nameSides[i]}: ");
            sideLengths[i] = Console.ReadLine();
        }

        double? s1 = ParsingUtils.ParseDoubleOrNull(sideLengths[0]);
        double? s2 = ParsingUtils.ParseDoubleOrNull(sideLengths[1]);
        double? s3 = ParsingUtils.ParseDoubleOrNull(sideLengths[2]);
        Triangle t = new(name!.ToUpper(), s1, s2, s3);

        return t;
    }
}