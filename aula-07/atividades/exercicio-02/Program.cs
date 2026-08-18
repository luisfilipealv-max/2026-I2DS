internal class Program
{
    public class Alunos
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Idade {get;set;}
    }
    private static void Main(string[] args)
    
    {
        Console.WriteLine("=== Lista de Alunos ===");

        // 1 - Iniciar um nova lista
        List<Alunos> listaAlunos = new List<Alunos>();

        Alunos Alunos1 = new Alunos{ Id = 1, Nome = "Maria", Idade = "16"};
        Alunos Alunos2 = new Alunos{Id = 2, Nome = "Lucas", Idade = "16"}; 
        Alunos Alunos3 = new Alunos{Id = 3, Nome = "Luis", Idade = "17"};
        Alunos Alunos4 = new Alunos{Id = 4, Nome = "Matheus", Idade = "16"};
        Alunos Alunos5 = new Alunos{Id = 5, Nome = "Joao", Idade = "17"};
        




    
        listaAlunos.Add(Alunos1);
        listaAlunos.Add(Alunos2); 
        listaAlunos.Add(Alunos3);
        listaAlunos.Add(Alunos4);
        listaAlunos.Add(Alunos5);
   
        foreach (var Alunos in listaAlunos)
        {
            Console.WriteLine($"{Alunos.Nome} - {Alunos.Idade}");
        }
        Console.WriteLine();

        listaAlunos[1].Idade = "18";

        Console.WriteLine();
        foreach (var Alunos in listaAlunos)
        {
            Console.WriteLine($"{Alunos.Nome} - {Alunos.Idade}");
        }
        Console.WriteLine();
        Console.WriteLine("Removendo aluno");
        Console.WriteLine();

        listaAlunos.Remove(Alunos2);
         foreach (var Alunos in listaAlunos)
        {
            Console.WriteLine($"{Alunos.Nome}");
        }
        

    }
}
