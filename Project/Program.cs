namespace Project;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lista de Exemplos:");
            Console.WriteLine();
            Console.WriteLine("   1 — Solução do Problema");
            Console.WriteLine("   2 — Override");
            Console.WriteLine();
            Console.Write("Digite o número do exemplo que deseja executar ou tecle ENTER para sair: ");
            string? escolha = Console.ReadLine();
            Console.Clear();

            if (string.IsNullOrEmpty(escolha))
            {
                return;
            }
            else
            {
                switch (escolha)
                {
                    case "1":
                        ProgramExamples.ProblemSolution();
                        break;
                    case "2":
                        ProgramExamples.Override();
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
