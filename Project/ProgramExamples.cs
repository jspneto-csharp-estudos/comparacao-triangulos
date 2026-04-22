using System.Globalization;
using Project.Src;

namespace Project;

class ProgramExamples
{
    public static void ProgramSolution()
    {
        Triangle t1 = new();
        Triangle t2 = new();
        
        Console.WriteLine("Entre com os dados do 1º triângulo:");
        t1.Name = Console.ReadLine()!;
        t1.Side1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t1.Side2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t1.Side3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do 2º triângulo:");
        t2.Name = Console.ReadLine()!;
        t2.Side1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t2.Side2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t2.Side3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double areaT1 = t1.Area();
        double areaT2 = t2.Area();

        Console.WriteLine();
        Console.WriteLine($"Área de {t1.Name}: {areaT1.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Área de {t2.Name}: {areaT2.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.Write("Maior área: ");

        if (areaT1 >= areaT2)
        {
            Console.WriteLine($"{t1.Name}");
        }
        else
        {
            Console.WriteLine($"{t2.Name}");
        }

        ShowExitPrompt();
    }

    private static void ShowExitPrompt()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}