using System.Globalization;
using Project.Src;

namespace Project;

static class ProgramExamples
{
    public static void ProblemSolution()
    {
        Triangle t1 = new();
        Triangle t2 = new();
        
        Console.WriteLine("Entre com os dados do 1º triângulo:");
        t1.Name = Console.ReadLine()!;
        t1.S1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t1.S2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t1.S3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do 2º triângulo:");
        t2.Name = Console.ReadLine()!;
        t2.S1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t2.S2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        t2.S3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double areaT1 = t1.Area();
        double areaT2 = t2.Area();

        Console.WriteLine();
        Console.WriteLine("Área de X: " + areaT1.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y: " + areaT2.ToString("F4", CultureInfo.InvariantCulture));
        Console.Write("Maior área: ");

        if (areaT1 >= areaT2)
        {
            Console.WriteLine("X");
        }
        else
        {
            Console.WriteLine("Y");
        }

        OutgoingMessage();
    }

    private static void OutgoingMessage()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}