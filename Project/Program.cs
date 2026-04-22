namespace Project;

class Program
{
    static void Main(string[] args)
    {
        string ProjectName = "Projeto de Estudo em C#";
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"<><><><><><><><> {ProjectName} <><><><><><><><>");
            Console.WriteLine();
            Console.WriteLine("Lista de Exemplos:");
            Console.WriteLine();
            Console.WriteLine("   1 — Solução do Problema");
            Console.WriteLine();
            Console.Write("Digite o número do exemplo para executar ou digite outro caractere para sair: ");
            char input = char.Parse(Console.ReadLine()!);
            Console.Clear();

            switch (input)
            {
                case '1':
                    ProgramExamples.ProgramSolution();
                    break;
                default:
                    return;
            }
        }
    }
}
