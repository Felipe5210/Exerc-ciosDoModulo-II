using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Pessoa
    {
        private string Nome;
        protected int Idade;
        public string Endereco;

        public Pessoa(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public string saudacao()
        {
            return $"Olá, meu nome é {Nome} e eu tenho {Idade} anos!";
        }
    }
}
