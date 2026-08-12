internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("===  TRABALHANDO COM FILAS (FIFO) ===");  

     //1 - criar uma nova pilha vazia
        Stack<string> pilhaLivros = new Stack<string>();

     //2 - Adicionar elementois em uma pilha
        
        pilhaLivros.Push("dom quixote");
        pilhaLivros.Push("diario de um banana");
        pilhaLivros.Push("diario de uym banana 2");

     //3 - percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }

        //4 - retirar im elemento da lista
        string livroRemovido = pilhaLivros.Pop();
        Console.WriteLine();
        Console.WriteLine($"Dom casmuro");
        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }


}
}