namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria1 = new ContaBancaria(1234, 200.00);

            contaBancaria1.Deposita(300.00);
            contaBancaria1.Saca(110.00);
            Console.WriteLine("Saldo conta bancaria: " + contaBancaria1.GetSaldo());
        }
    }
}
