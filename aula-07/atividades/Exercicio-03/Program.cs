internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM DICIONÁRIOS ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <key, value>
        
        // 1 - Criar um dicionário vazio
        Dictionary<string, string> Telefone = new Dictionary<string, string>();
        
        // 2 - Adicionar elementos no dicionario
        Telefone.Add("Luis","1499662-1697");
        Telefone.Add("ROdrigo", "1499783-8359");

        Console.WriteLine();
        foreach (var numero in Telefone) ;
        {
            Console.WriteLine(${Telefone.key} - {Telefone.Value});
        }

        Console.WriteLine();

        bool chaveExiste = Telefone.ContainsKey("Luis");
        if (chaveExiste) ;
        {
            Console.WriteLine($"O Luis foi encontrado");
    }
    else
    {
        Console.WriteLine($"Esse telefone não foi encontrado");
    }

    Console.WriteLine();
    

}