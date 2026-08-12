internal class Program
{
    public class Frutas
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
    }
    private static void Main(string[] args)
    
    {
        Console.WriteLine("=== ARMAZENAMENTO DE FRUTAS ===");

        // 1 - Iniciar um nova lista
        List<Frutas> listaFrutas = new List<Frutas>();

        Frutas Frutas1 = new Frutas{ Id = 1, Nome = "Maça"};
        Frutas Frutas2 = new Frutas{Id = 2, Nome = "Banana"};
        Frutas Frutas3 = new Frutas{Id = 3, Nome = "Morango"};
        Frutas Frutas4 = new Frutas{Id = 4, Nome = "Uva"};
        Frutas Frutas5 = new Frutas{Id = 5, Nome = "Pera"};
        Frutas Frutas6 = new Frutas{Id = 6, Nome = "Abacaxi"};




    
        listaFrutas.Add(Frutas1);
        listaFrutas.Add(Frutas2); 
        listaFrutas.Add(Frutas3);
        listaFrutas.Add(Frutas4);
        listaFrutas.Add(Frutas5);
   
        foreach (var Frutas in listaFrutas)
        {
            Console.WriteLine($"{Frutas.Nome}");
        }
        listaFrutas[1].Nome = "Melão";

        Console.WriteLine();
        foreach (var Frutas in listaFrutas)
        {
            Console.WriteLine($"{Frutas.Nome}");
        }
        Console.WriteLine();
        Console.WriteLine("lista está sendo atualizada...");
        Console.WriteLine();

        listaFrutas.Add(Frutas6);
         foreach (var Frutas in listaFrutas)
        {
            Console.WriteLine($"{Frutas.Nome}");
        }
        

    }
}
