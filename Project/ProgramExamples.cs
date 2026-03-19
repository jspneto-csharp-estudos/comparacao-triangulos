using System.Globalization;
using Project.Src;
using Project.Src.IO;

namespace Project;

static class ProgramExamples
{
    public static void ProblemSolution()
    {
        Console.WriteLine("Entre com os dados do 1º triângulo:");
        Triangle t1 = TriangleInputs.CreateTriangle();

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do 2º triângulo:");
        Triangle t2 = TriangleInputs.CreateTriangle();

        Triangle largestArea = TriangleUtils.CompareAreas(t1, t2);

        Console.WriteLine();
        TriangleOutputs.ViewArea(t1);
        TriangleOutputs.ViewArea(t2);
        Console.WriteLine($"Maior área: {largestArea.Name}");

        OutgoingMessage();
    }

    public static void Override()
    {
        Console.WriteLine("Exemplo de uso de Sobrescrita (Override)");
        
        Console.WriteLine();
        Console.WriteLine("Entre com os dados do triângulo:");
        Triangle t = TriangleInputs.CreateTriangle();

        Console.WriteLine();
        Console.WriteLine(t.ToString());

        OutgoingMessage();
    }

    public static void Overload()
    {
        Console.WriteLine("Exemplo de uso de Sobrecarga (Overload): ");

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do triângulo:");
        string name = Console.ReadLine()!;
        double s1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double s2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double s3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Criando 1º triângulo... (Utiliza construtor completo)");
        Triangle t1 = new(name, s1, s2, s3);
        Console.WriteLine("Criando 2º triângulo... (Utiliza construtor parcial)");
        Triangle t2 = new(name);

        Console.WriteLine();
        Console.WriteLine(t1.ToString());
        Console.WriteLine(t2.ToString());

        OutgoingMessage();
    }

    public static void Encapsulation()
    {
        Console.WriteLine("Exemplo de uso de Encapsulamento:");

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do triângulo:");
        Triangle t = TriangleInputs.CreateTriangle();
        Console.WriteLine(t.ToString());

        Console.WriteLine();
        Console.Write("Entre com um novo nome para o triângulo: ");
        t.Name = Console.ReadLine()!;
        Console.WriteLine(t.ToString());

        OutgoingMessage();
    }

    private static void OutgoingMessage()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}