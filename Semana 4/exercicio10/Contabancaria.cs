using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio10
{
    public class ContaBancaria
    {
        private decimal Saldo;
        private List<String> Transacoes = new List<string>();

        public void Deposito(decimal value)
        {
            DateTime today = DateTime.Now;
            Saldo += value;
            Transacoes.Add($"Depósito de R${value} realizado em: {today}.");
            Console.WriteLine($"Depósito de R${value} realizado!\n Saldo atual de R${Saldo}.");
        }

        public void Saque(decimal value)
        {
            DateTime today = DateTime.Now;
            if (Saldo >= value)
            {
                Saldo -= value;
                Console.WriteLine($"Saque de R${value} realizado!\n Saldo atual de R${Saldo}.");
                Transacoes.Add($"Saque de R${value} realizado em: {today}.");
            }
            else
            {
                Console.WriteLine(
                    $"Não foi possivel realizar o saque, pois excede o limite atual."
                );
            }
        }

        public decimal ExtratoSaldo()
        {
            return Saldo;
        }

        public List<string> ExtratoConta()
        {
            return Transacoes;
        }
    }
}
