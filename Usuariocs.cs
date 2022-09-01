using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Usuariocs
    {
        

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }

        public Usuariocs() { }

        public Usuariocs(string nome, string cpf, string endereco, string fone)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Fone = fone;
        }

        override
        public string ToString()
        {
            return $"Nome: {this.Nome}" +
                $"Cpf: {this.Cpf}" +
                $"Endereço: {this.Endereco}" +
                $"Telefone: {this.Fone}";

    }

    }
}

