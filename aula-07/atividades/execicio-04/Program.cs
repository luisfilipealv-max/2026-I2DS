internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> Fila = new Queue<string>();
        Fila.Enqueue("João");
        Fila.Enqueue("Maria");
        Fila.Enqueue("Carlos");
        Fila.Enqueue("Luis");
        Fila.Enqueue("Pedro");

        // 1. Exibir a fila
        Console.WriteLine("Fila de atendimento:");
        foreach (string cliente in Fila)
        {
            Console.WriteLine(cliente);
        }

        // 2. Atender o primeiro cliente
        string atendimento = Fila.Dequeue();

        // 3. Informar quem foi atendido
        Console.WriteLine("\nCliente atendido: " + atendimento);

        // 4. Exibir a fila restante
        Console.WriteLine("\nFila restante:");
        foreach (string cliente in Fila)
        {
            Console.WriteLine(cliente);
        }

        // 5. Permitir adicionar um novo cliente
        Console.Write("\nDigite o nome do novo cliente: ");
        string novoCliente = Console.ReadLine();

        Fila.Enqueue(novoCliente);

        Console.WriteLine("\nFila após adicionar o novo cliente:");
        foreach (string cliente in Fila)
        {
            Console.WriteLine(cliente);
        }

    }
}