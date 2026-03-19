using System.Globalization;

namespace Project.Src.IO;

static class TriangleOutputs
{
    public static void ViewArea(Triangle t)
    {
        Console.WriteLine($"Área de {t.Name}: {t.Area().ToString("F4", CultureInfo.InvariantCulture)}");
    }
}