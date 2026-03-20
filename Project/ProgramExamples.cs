using Project.Src;
using Project.Src.IO;
using Project.Src.Utils;

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
        string? name = Console.ReadLine();
        
        while (!Triangle.NameIsValid(name))
        {
            Console.Write("  ¬ Erro. O nome deve ter três caracteres. Digite novamente: ");
            name = Console.ReadLine();
        }
        
        string? s1StringValue = Console.ReadLine();
        string? s2StringValue = Console.ReadLine();
        string? s3StringValue = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Criando 1º triângulo... (Utiliza construtor completo)");
        double? s1 = ParsingUtils.ParseDoubleOrNull(s1StringValue);
        double? s2 = ParsingUtils.ParseDoubleOrNull(s2StringValue);
        double? s3 = ParsingUtils.ParseDoubleOrNull(s3StringValue);
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
        string? name = Console.ReadLine();
        
        while (!Triangle.NameIsValid(name) || string.Equals(t.Name, name!.ToUpper()))
        {
            Console.Write(
                "  ¬ Erro. O nome deve ter três caracteres e ser diferente do atual. Digite novamente: "
            );
            name = Console.ReadLine();
        }
        
        t.Name = name;
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