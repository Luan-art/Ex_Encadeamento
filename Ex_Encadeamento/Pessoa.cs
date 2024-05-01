using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Encadeamento
{
    internal class Pessoa
    {
        string nome;
        int idade;
        Endereco endereco;

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public override string? ToString()
        {
            string valor = "Dados da Pessoa:\n" +
                "Nome:" + nome + "\nIdade: " + idade + "\n" + endereco.ToString();

            return valor;
        }
    }
}
