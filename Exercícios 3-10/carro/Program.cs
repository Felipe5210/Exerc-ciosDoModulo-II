﻿using carro.models;
using System.Reflection.PortableExecutable;

namespace carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proprietario1 = new Proprietario();

            proprietario1.Nome = "Roberto Carlos";
            proprietario1.Cpf = "968.654.785-75";
            proprietario1.Telefone = "78988355723";

            var proprietario2 = new Proprietario()
            {
                Nome = "Clara Cristina",
                Cpf = "977.181.500-89",
                Telefone = "38983546733"
            };

            var proprietario3 = new Proprietario()
            {
                Nome = "Tati Sobral",
                Cpf = "876.896.478-01",
                Telefone = "21983345743"
            };

            var carro1 = new Carro()
            {
                Marca = "Fiat",
                Modelo = "Palio 1.0",
                Placa = "GTY6431",
                Cor = "Azul",
                Proprietario = proprietario1
            };

            var carro2 = new Carro()
            {
                Marca = "Fiat",
                Modelo = "Uno Mille",
                Placa = "LWG9570",
                Cor = "Vermelho",
                Proprietario = proprietario2
            };

            var carro3 = new Carro()
            {
                Marca = "Volkswagen",
                Modelo = "Fusca 78",
                Placa = "FNW7297",
                Cor = "Bege",
                Proprietario = proprietario3
            };

            var Carros = new List<Carro>();
            Carros.Add(carro1);
            Carros.Add(carro2);
            Carros.Add(carro3);

            char opcao = ' ';
            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindos ao sistema de cadastro de carro!");
                Console.WriteLine(
                    "Digite a opção que deseja executar:\n"
                        + "1 - Cadastrar Carro\n"
                        + "2 - Consultar Carros\n"
                        + "3 - Sair"
                );
                opcao = char.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case '1':
                        CadastrarNovoCarro(Carros);
                        break;
                    case '2':
                        ApresentaDados(Carros);
                        break;
                    case '3':
                        Console.WriteLine("Saindo do sistema!");
                        break;
                    default:
                        Console.WriteLine("Dgite uma opção válida!");
                        break;
                }
            } while (opcao != '3');
        }

        static void CadastrarNovoCarro(List<Carro> Carros)
        {
            Console.WriteLine("Cadastro novo carro.");
            Console.WriteLine("Digite o nome do Proprietario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Proprietario:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o Telefone do Proprietario:");
            string telefone = Console.ReadLine();
            var proprietario = new Proprietario()
            {
                Nome = nome,
                Cpf = cpf,
                Telefone = telefone
            };

            Console.WriteLine("Digite a marca do carro:");
            string marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite a placa do carro:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite a cor do carro:");
            string cor = Console.ReadLine();
            var carro = new Carro()
            {
                Marca = marca,
                Modelo = modelo,
                Placa = placa,
                Cor = cor,
                Proprietario = proprietario
            };
            Carros.Add(carro);
        }

        static void ApresentaDados(List<Carro> carros)
        {
            Console.Clear();
            foreach (var carro in carros)
            {
                Console.WriteLine(
                    $" Carro da marca {carro.Marca}, modelo {carro.Modelo}, cor {carro.Cor},\n "
                        + $"pertence ao proprietario {carro.Proprietario.Nome}, cpf {carro.Proprietario.Cpf} e telefone {carro.Proprietario.Telefone}\n\n"
                );
            }
        }
    }
}
