namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("mel", 1);
            Gato gato = new Gato("chico", 1);

            cachorro.EmitirSom();
            gato.EmitirSom();
        }
    }
}
