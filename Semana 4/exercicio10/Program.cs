namespace exercicio10
{
    class Program
    {
        private static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria();
            List<String> extrato = c1.ExtratoConta();

            void Extrato()
            {
                Console.WriteLine(
                    "________________________________________________________________________"
                );
                Console.WriteLine("                        Extrato de transações:");
                Console.WriteLine(
                    "________________________________________________________________________"
                );
                foreach (var item in extrato)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(
                        "........................................................................"
                    );
                }
                Console.WriteLine(
                    "________________________________________________________________________"
                );
            }
            ;

            c1.Deposito(200);
            c1.Deposito(100);
            c1.Saque(150);
            Console.WriteLine($"Saldo: {c1.ExtratoSaldo()}");

            c1.Deposito(1400);
            c1.Saque(200);
            Console.WriteLine($"Saldo: {c1.ExtratoSaldo()}");

            Extrato();
        }
    }
}
