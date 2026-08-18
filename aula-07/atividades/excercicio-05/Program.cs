internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> Histórico = new Stack<string>();

        // 1. Exibir página

        Histórico.Push("google.com");
        Histórico.Push("youtube.com");
        Histórico.Push("github.com");
        Histórico.Push("miscrosofit.com");

        // 2. Voltar
        Histórico.Pop();

        Console.WriteLine("Voltando...");
        Console.WriteLine("Página atual: " + Histórico.Peek());

        // 3. Adicionar uma nova página
        Console.WriteLine();
        Console.Write("\nDigite uma nova página: ");
        string novaPagina = Console.ReadLine();

        Histórico.Push(novaPagina);

        Console.WriteLine("Página adicionada!");

    
    }
}