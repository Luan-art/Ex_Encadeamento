using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Encadeamento
{
    internal class Endereco
    {
        string cep;
        string localidade;
        string uf;
        string logradouro;
        string tipoLogradouro;
        int numero;
        string complemento;

        public Endereco(string cep, string localidade, string uf, string logradouro, string tipoLogadouro, int numero, string complemento)
        {
            this.cep = cep;
            this.localidade = localidade;
            this.uf = uf;
            this.logradouro = logradouro;
            this.tipoLogradouro = tipoLogadouro;
            this.numero = numero;
            this.complemento = complemento;
        }

        public override string? ToString()
        {
            string valor;

            if (complemento == "")
            {
                valor = $"Endereço:\nCep: {cep}\nLocalidade {localidade}" +
                $"\nUF: {uf}\nLogadouro:{tipoLogradouro} {logradouro}" +
                $"\nNumero: {numero}";
            }
            else
            {
                valor = $"Endereço:\nCep: {cep}\nLocalidade {localidade}" +
                $"\nUF: {uf}\nLogadouro:{tipoLogradouro} {logradouro}" +
                $"\nNumero: {numero}\nComplemento: {complemento}";
            }

            return valor;
        }
    }
}
