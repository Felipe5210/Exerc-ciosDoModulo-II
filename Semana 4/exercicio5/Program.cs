namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Carlos";
            pessoa.Idade = 5;
            Console.WriteLine(pessoa.Idade);
            pessoa.DefinirIdade(10);
            Console.WriteLine(pessoa.Idade);
        }
    }
}
