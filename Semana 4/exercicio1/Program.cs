namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Dona", 33, "Rua Mamede de Souza");
            Console.WriteLine(pessoa1.saudacao());
        }
    }
}
