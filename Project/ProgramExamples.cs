using Project.Src;
using Project.Src.IO;
using Project.Src.Utils;

namespace Project;

class ProgramExamples
{
    public static void ProgramSolution()
    {
        Console.WriteLine("Entre com os dados do 1º triângulo:");
        Triangle t1 = TriangleInputs.ReadTriangle();

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do 2º triângulo:");
        Triangle t2 = TriangleInputs.ReadTriangle();

        Triangle largestArea = TriangleCompare.GetLargestAreaTriangle(t1, t2);

        Console.WriteLine();
        TriangleOutputs.ShowArea(t1);
        TriangleOutputs.ShowArea(t2);
        Console.WriteLine($"Maior área: {largestArea.Name}");

        ShowExitPrompt();
    }

    private static void ShowExitPrompt()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}