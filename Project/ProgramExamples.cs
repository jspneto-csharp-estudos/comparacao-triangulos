namespace Project;

static class ProgramExamples
{
    public static void ProblemSolution()
    {
        Console.WriteLine("Hello, World!");
        OutgoingMessage();
    }

    private static void OutgoingMessage()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}