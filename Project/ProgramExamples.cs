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

    private static void OutgoingMessage()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}