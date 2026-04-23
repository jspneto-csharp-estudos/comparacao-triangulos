using System.Globalization;

namespace Project.Src.IO;

class TriangleOutputs
{
    public static void ShowArea(Triangle t)
    {
        Console.WriteLine($"Área de {t.Name}: {t.Area().ToString("F4", CultureInfo.InvariantCulture)}");
    }
}