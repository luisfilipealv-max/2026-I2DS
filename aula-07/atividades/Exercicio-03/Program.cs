internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== AGENDA TELEFÔNICA ===");

        // 1 - Criar um dicionário vazio
        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        // 2 - Adicionar elementos no dicionario
        dicionario.Add("Luis","14 99988-7777");
        dicionario.Add("Rodrigo","14 99988-7766");
        dicionario.Add("Joao","14 99988-7227");
        dicionario.Add("Roberta","14 99988-7117");

        // 3 - Percorrer todos os elemetos de um dicionario
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine("");

        //  - Verificar se uma chave (key) existe dentro do dicionário
        
        Console.WriteLine($"Buscando contato na lista telefônica");

        bool chaveExiste = dicionario.ContainsKey("Roberta");
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"O contato foi encontrado: Roberta");
        }
        else
        {
            Console.WriteLine("O contato não foi encontrada na lista telefônica");
        }
        // 4 - Alterar um elemento do dicionario (telefone)
        Console.WriteLine("-----------------------------"); 
        Console.WriteLine("Um contato mudou de número (Luis)...");
        Console.WriteLine();
        Console.WriteLine("-----------------------------"); 
        Console.WriteLine();
        dicionario["Luis"] = "17 99887-5555";

        Console.WriteLine("Exibindo a agenda atualizada");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 6 - Excluir um contato -> Somente por Chave(Key)
        Console.WriteLine();
        Console.WriteLine("Excluindo um contato da lista");
        Console.WriteLine();
        dicionario.Remove("Rodrigo");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}